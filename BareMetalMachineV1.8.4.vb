' Name: Bare Metal Machine
' Purpose: Provides GUI to perform Manual Bare Metal Recovery (restoring a unit using a windows image file)
'Programmer: Luis Juarez

Option Explicit On
Option Strict On
Option Infer Off

'I should start a changelog for version builds...
'***V1.8.2 --11-19-14: Added a changelog comment section
'V1.8.3 11-24-14: removed line where disk info button would set text box to blank
'V1.8.4 11-30-14: removed another line where disk info set text box to blank /facepalm
' Also outputs help log now

Public Class BareMetalMachine
    ' Declare and Initatlize variables

    Dim intIndex As Integer
    Dim strIndex As String
    Dim intDisk As Integer
    Dim strImagePath As String = "%WinDir%\ImagePath"
    Dim strDisk As String = "0"
    Dim intPass As Integer
    Dim strSWMPath As String = "R:\recovery\install*.swm"
    Dim check As String


    Dim SW As System.IO.StreamWriter
    Dim SR As System.IO.StreamReader


    Private Sub btnOutputDisk_Click(sender As Object, e As EventArgs) Handles btnOutputDisk.Click
        'When Disk Info is clicked
        Me.Size = New Size(720, 516)

        Dim CMD As New Process
        'Create Process to output and Parse diskpart info

        CMD.StartInfo.FileName = "diskpart"
        CMD.StartInfo.UseShellExecute = False
        CMD.StartInfo.RedirectStandardInput = True
        CMD.StartInfo.RedirectStandardOutput = True
        CMD.StartInfo.CreateNoWindow = True

        CMD.Start()

        SW = CMD.StandardInput
        SR = CMD.StandardOutput

        SW.WriteLine("list disk")


        CMD.Dispose()
        SW.Dispose()

        Do Until SR.EndOfStream = True
            txtDiskInfo.Text &= SR.ReadLine
            txtDiskInfo.Text &= Environment.NewLine

        Loop

        SR.Dispose()
        

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        'opens file directory
        OpenFileDialog1.Title = "Please Select Image File"
        ' OpenFileDialog1.InitialDirectory = "X:"
        OpenFileDialog1.Filter = "Windows Image Files (*.wim)|*.wim|Split Windows Image Files (*.swm)|*.swm|All Files (*.*)|*.*"
        'OpenFileDialog1.FilterIndex = 3
        OpenFileDialog1.ShowDialog()


    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        'What happens when Agent has selected file - checks for correct file type and which dism switches to use (if .swm)
        txtWim.Text = OpenFileDialog1.FileName.ToString()

        check = _
    System.IO.Path.GetExtension(txtWim.Text)
        lblCheck.Text = check

        If lblCheck.Text = ".swm" Then
            intPass = 1
        ElseIf lblCheck.Text = ".wim" Then
            intPass = 2
        Else
            MessageBox.Show("Please select a Wim or Swm file", "Incorrect File Type", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
  

    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        'Apply Click 
        'activate progress bar
        ProgressBar1.Value = 10
        'pass file path input to variable string ImagePath and strSwmPath
        strImagePath = txtWim.Text
        strSWMPath = txtWim.Text

        'passes radio button disk selection to string disk variable
        If radDisk0.Checked Then
            strDisk = "0"
        ElseIf radDisk1.Checked Then
            strDisk = "1"
        ElseIf radDisk2.Checked Then
            strDisk = "2"
        End If

        'pass numeric counter value to index variable
        strIndex = nmbIndex.Value.ToString


        ' create processes
        Dim Partition As New Process
        Dim Apply As New Process
        'Create Partitions Process
        Partition.StartInfo.FileName = "diskpart"
        Partition.StartInfo.UseShellExecute = False
        Partition.StartInfo.RedirectStandardInput = True
        Partition.StartInfo.RedirectStandardOutput = True
        Partition.StartInfo.CreateNoWindow = True

        Partition.Start()

        SW = Partition.StandardInput
        SR = Partition.StandardOutput

        'If MBR
        If radMBR.Checked Then
            SW.WriteLine("select disk " + strDisk)
            SW.WriteLine("create partition primary size=1000")
            SW.WriteLine("format quick fs=ntfs label=System")
            SW.WriteLine("assign letter=S")
            SW.WriteLine("active")
            SW.WriteLine("create partition primary")
            SW.WriteLine("shrink minimum=32000")
            SW.WriteLine("format quick fs=ntfs label=Windows")
            SW.WriteLine("assign letter=W")
            SW.WriteLine("create partition primary")
            SW.WriteLine("format quick fs=ntfs label=Recovery Image")
            SW.WriteLine("assign letter=R")
            SW.WriteLine("set id=27")
            SW.WriteLine("exit")



            'If GPT
        ElseIf radGPT.Checked Then
            SW.WriteLine("select disk " + strDisk)
            SW.WriteLine("convert gpt")
            SW.WriteLine("create partition primary size=1000")
            SW.WriteLine("format quick fs=ntfs label=WinRE")
            SW.WriteLine("assign letter=T")
            SW.WriteLine("set id=de94bba4-06d1-4d40-a16a-bfd50179d6ac")
            SW.WriteLine("gpt attributes=0x8000000000000001")
            SW.WriteLine("create partition efi size=300")
            SW.WriteLine("format quick fs=fat32 label=System")
            SW.WriteLine("assign letter=S")
            SW.WriteLine("create partition msr size=128")
            SW.WriteLine("create partition primary")
            SW.WriteLine("shrink minimum=32000")
            SW.WriteLine("format quick fs=ntfs label=Windows")
            SW.WriteLine("assign letter=W")
            SW.WriteLine("create partition primary")
            SW.WriteLine("format quick fs=ntfs label=RecoveryImage")
            SW.WriteLine("assign letter=R")
            SW.WriteLine("set id=de94bba4-06d1-4d40-a16a-bfd50179d6ac")
            SW.WriteLine("gpt attributes=0x8000000000000001")
            SW.WriteLine("exit")


        End If
        'End of Partition Scripts

        Partition.Dispose()
        SW.Dispose()

        Do Until SR.EndOfStream = True
            txtDiskInfo.Text &= SR.ReadLine
            txtDiskInfo.Text &= Environment.NewLine

        Loop

        SR.Dispose()
        ProgressBar1.Value = 50
        'Copy WIM file
        Apply.StartInfo.FileName = "cmd"
        Apply.StartInfo.UseShellExecute = False
        Apply.StartInfo.RedirectStandardInput = True
        Apply.StartInfo.RedirectStandardOutput = True
        Apply.StartInfo.CreateNoWindow = True

        Apply.Start()

        SW = Apply.StandardInput
        SR = Apply.StandardOutput

        'Create Recovery Folder on R: partition and copy wim/swm files to it
        Dim intLocation As Integer
        intLocation = strSWMPath.ToUpper.IndexOf(".")
        strSWMPath = strSWMPath.Insert(intLocation, "*")
        SW.WriteLine("R:")
        SW.WriteLine("md Recovery")
        SW.WriteLine("xcopy " + strSWMPath + " R:\Recovery")
        SW.WriteLine("C:")


        'Apply Image
        If lblCheck.Text = ".swm" Then
            SW.WriteLine("Dism /apply-image /imagefile:" + strImagePath + " /swmfile:" + strSWMPath + " /index:" + strIndex + " /applydir:W:\")

        Else
            SW.WriteLine("Dism /apply-image /imagefile:" + strImagePath + " /index:" + strIndex + " /applydir:W:\")
        End If


        Apply.Dispose()
        SW.Dispose()

        Do Until SR.EndOfStream = True
            txtDiskInfo.Text &= SR.ReadLine
            txtDiskInfo.Text &= Environment.NewLine

        Loop

        SR.Dispose()

        'Rebuild BCD
        Dim BCD As New Process
        BCD.StartInfo.FileName = "cmd"
        BCD.StartInfo.UseShellExecute = False
        BCD.StartInfo.RedirectStandardInput = True
        BCD.StartInfo.RedirectStandardOutput = True
        BCD.StartInfo.CreateNoWindow = True

        BCD.Start()

        SW = BCD.StandardInput
        SR = BCD.StandardOutput

        SW.WriteLine("C:")
        SW.WriteLine("cd %windir%\system32")
        SW.WriteLine("bcdboot W:\Windows /s S:")

        'Could also specify partition layout using:
        'If radMBR.Checked Then
        'SW.WriteLine("bcdboot W:\Windows /s S: /f BIOS")
        'ElseIf radGPT.Checked Then
        'SW.WriteLine("bcdboot W:\Windows /s S: /f UEFI")
        'End If
        BCD.Dispose()
        SW.Dispose()

        Do Until SR.EndOfStream = True
            txtDiskInfo.Text &= SR.ReadLine
            txtDiskInfo.Text &= Environment.NewLine
        Loop
        ProgressBar1.Value = ProgressBar1.Maximum
        MessageBox.Show("BMR is Complete, please restart the computer", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'WinRE ~ coming soon
        'SW.WriteLine("T:")
        'SW.WriteLine("md Recovery\WindowsRE")

        'SW.WriteLine("attrib W:\windows\system32\recovery\winre.wim -h -s")
        'SW.WriteLine("copy W:\windows\system32\recovery\winre.wim T:\Recovery\WindowsRE")
        'SW.WriteLine("attrib W:\windows\system32\recovery\winre.wim +h +s")



        'Reagentc ~ coming soon
        'SW.WriteLine("W:")
        'SW.WriteLine("cd W:\Windows\System32")
        'SW.WriteLine("reagentc /setosimage /path R:\Recovery /target W:\Windows /index 1")
        'SW.WriteLine("reagentc /setreimage /path T:\Recovery\WindowsRE /target W:\Windows")

    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        'Clean button will wipe HDD partitions 
        Dim Clean As New Process
        ' Adjust selected disk based on radio button
        If radDisk0.Checked Then
            strDisk = "0"
        ElseIf radDisk1.Checked Then
            strDisk = "1"
        ElseIf radDisk2.Checked Then
            strDisk = "2"
        End If



        'Display MessageBox
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("HDD cleaning will delete all data!", "Clean", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If dlgButton = Windows.Forms.DialogResult.OK Then


            Clean.StartInfo.FileName = "diskpart"
            Clean.StartInfo.UseShellExecute = False
            Clean.StartInfo.RedirectStandardInput = True
            Clean.StartInfo.RedirectStandardOutput = True
            Clean.StartInfo.CreateNoWindow = True

            Clean.Start()

            SW = Clean.StandardInput
            SR = Clean.StandardOutput

            SW.WriteLine("select disk " + strDisk)

            SW.WriteLine("clean")

            Clean.Dispose()
            SW.Dispose()

            Do Until SR.EndOfStream = True
                txtDiskInfo.Text &= SR.ReadLine
                txtDiskInfo.Text &= Environment.NewLine

            Loop

            SR.Dispose()
            'Run Clean command with selected disk
            MessageBox.Show("Cleaned", "Clean Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblClean.Visible = True


        Else
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radGPT.CheckedChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BareMetalMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'This will output everything stream reader has been outputting to the label/textbox, as well as detailed disk info, to a text file
        MessageBox.Show("A text log has been exported as BMRlog.txt", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim HelpLogWriter As IO.StreamWriter

        HelpLogWriter = IO.File.CreateText("BMRlog.txt")
        HelpLogWriter.Write(txtDiskInfo.Text)
        HelpLogWriter.Close()

        ' HelpLogWriter = IO.File.AppendText("BMRlog.txt")

        


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class
