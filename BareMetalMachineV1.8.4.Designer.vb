<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BareMetalMachine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BareMetalMachine))
        Me.lblDisk = New System.Windows.Forms.Label()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.radDisk0 = New System.Windows.Forms.RadioButton()
        Me.btnOutputDisk = New System.Windows.Forms.Button()
        Me.gpbDisk = New System.Windows.Forms.GroupBox()
        Me.lblDisk2 = New System.Windows.Forms.Label()
        Me.radDisk2 = New System.Windows.Forms.RadioButton()
        Me.radDisk1 = New System.Windows.Forms.RadioButton()
        Me.lblDisk1 = New System.Windows.Forms.Label()
        Me.lblClean = New System.Windows.Forms.Label()
        Me.gpbOS = New System.Windows.Forms.GroupBox()
        Me.radGPT = New System.Windows.Forms.RadioButton()
        Me.radMBR = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtWim = New System.Windows.Forms.TextBox()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.gpbOptions = New System.Windows.Forms.GroupBox()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.nmbIndex = New System.Windows.Forms.NumericUpDown()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblSWMPath = New System.Windows.Forms.Label()
        Me.txtDiskInfo = New System.Windows.Forms.TextBox()
        Me.gpbDisk.SuspendLayout()
        Me.gpbOS.SuspendLayout()
        Me.gpbOptions.SuspendLayout()
        CType(Me.nmbIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDisk
        '
        Me.lblDisk.AutoSize = True
        Me.lblDisk.Location = New System.Drawing.Point(184, 31)
        Me.lblDisk.Name = "lblDisk"
        Me.lblDisk.Size = New System.Drawing.Size(38, 15)
        Me.lblDisk.TabIndex = 0
        Me.lblDisk.Text = "Disk 0"
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(20, 69)
        Me.btnClean.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(87, 26)
        Me.btnClean.TabIndex = 1
        Me.btnClean.Text = "Clean"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'radDisk0
        '
        Me.radDisk0.AutoSize = True
        Me.radDisk0.Checked = True
        Me.radDisk0.Location = New System.Drawing.Point(152, 31)
        Me.radDisk0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radDisk0.Name = "radDisk0"
        Me.radDisk0.Size = New System.Drawing.Size(14, 13)
        Me.radDisk0.TabIndex = 2
        Me.radDisk0.TabStop = True
        Me.radDisk0.UseVisualStyleBackColor = True
        '
        'btnOutputDisk
        '
        Me.btnOutputDisk.Location = New System.Drawing.Point(20, 26)
        Me.btnOutputDisk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOutputDisk.Name = "btnOutputDisk"
        Me.btnOutputDisk.Size = New System.Drawing.Size(87, 26)
        Me.btnOutputDisk.TabIndex = 3
        Me.btnOutputDisk.Text = "Display Disk"
        Me.btnOutputDisk.UseVisualStyleBackColor = True
        '
        'gpbDisk
        '
        Me.gpbDisk.Controls.Add(Me.lblDisk2)
        Me.gpbDisk.Controls.Add(Me.radDisk2)
        Me.gpbDisk.Controls.Add(Me.radDisk1)
        Me.gpbDisk.Controls.Add(Me.lblDisk1)
        Me.gpbDisk.Controls.Add(Me.lblClean)
        Me.gpbDisk.Controls.Add(Me.btnOutputDisk)
        Me.gpbDisk.Controls.Add(Me.radDisk0)
        Me.gpbDisk.Controls.Add(Me.btnClean)
        Me.gpbDisk.Controls.Add(Me.lblDisk)
        Me.gpbDisk.Location = New System.Drawing.Point(26, 44)
        Me.gpbDisk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDisk.Name = "gpbDisk"
        Me.gpbDisk.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDisk.Size = New System.Drawing.Size(295, 131)
        Me.gpbDisk.TabIndex = 4
        Me.gpbDisk.TabStop = False
        Me.gpbDisk.Text = "Select Disk"
        '
        'lblDisk2
        '
        Me.lblDisk2.AutoSize = True
        Me.lblDisk2.Location = New System.Drawing.Point(184, 82)
        Me.lblDisk2.Name = "lblDisk2"
        Me.lblDisk2.Size = New System.Drawing.Size(38, 15)
        Me.lblDisk2.TabIndex = 9
        Me.lblDisk2.Text = "Disk 2"
        '
        'radDisk2
        '
        Me.radDisk2.AutoSize = True
        Me.radDisk2.Location = New System.Drawing.Point(152, 82)
        Me.radDisk2.Name = "radDisk2"
        Me.radDisk2.Size = New System.Drawing.Size(14, 13)
        Me.radDisk2.TabIndex = 8
        Me.radDisk2.TabStop = True
        Me.radDisk2.UseVisualStyleBackColor = True
        '
        'radDisk1
        '
        Me.radDisk1.AutoSize = True
        Me.radDisk1.Location = New System.Drawing.Point(152, 56)
        Me.radDisk1.Name = "radDisk1"
        Me.radDisk1.Size = New System.Drawing.Size(14, 13)
        Me.radDisk1.TabIndex = 7
        Me.radDisk1.TabStop = True
        Me.radDisk1.UseVisualStyleBackColor = True
        '
        'lblDisk1
        '
        Me.lblDisk1.AutoSize = True
        Me.lblDisk1.Location = New System.Drawing.Point(184, 56)
        Me.lblDisk1.Name = "lblDisk1"
        Me.lblDisk1.Size = New System.Drawing.Size(38, 15)
        Me.lblDisk1.TabIndex = 6
        Me.lblDisk1.Text = "Disk 1"
        '
        'lblClean
        '
        Me.lblClean.AutoSize = True
        Me.lblClean.Location = New System.Drawing.Point(34, 104)
        Me.lblClean.Name = "lblClean"
        Me.lblClean.Size = New System.Drawing.Size(53, 15)
        Me.lblClean.TabIndex = 4
        Me.lblClean.Text = "Cleaned!"
        Me.lblClean.Visible = False
        '
        'gpbOS
        '
        Me.gpbOS.Controls.Add(Me.radGPT)
        Me.gpbOS.Controls.Add(Me.radMBR)
        Me.gpbOS.Location = New System.Drawing.Point(26, 183)
        Me.gpbOS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbOS.Name = "gpbOS"
        Me.gpbOS.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbOS.Size = New System.Drawing.Size(295, 68)
        Me.gpbOS.TabIndex = 5
        Me.gpbOS.TabStop = False
        Me.gpbOS.Text = "Select Partition Structure"
        '
        'radGPT
        '
        Me.radGPT.AutoSize = True
        Me.radGPT.Location = New System.Drawing.Point(187, 30)
        Me.radGPT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radGPT.Name = "radGPT"
        Me.radGPT.Size = New System.Drawing.Size(47, 19)
        Me.radGPT.TabIndex = 1
        Me.radGPT.Text = "GPT"
        Me.radGPT.UseVisualStyleBackColor = True
        '
        'radMBR
        '
        Me.radMBR.AutoSize = True
        Me.radMBR.Checked = True
        Me.radMBR.Location = New System.Drawing.Point(36, 30)
        Me.radMBR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radMBR.Name = "radMBR"
        Me.radMBR.Size = New System.Drawing.Size(50, 19)
        Me.radMBR.TabIndex = 0
        Me.radMBR.TabStop = True
        Me.radMBR.Text = "MBR"
        Me.radMBR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select Image File"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtWim
        '
        Me.txtWim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWim.Location = New System.Drawing.Point(26, 304)
        Me.txtWim.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtWim.Name = "txtWim"
        Me.txtWim.Size = New System.Drawing.Size(258, 23)
        Me.txtWim.TabIndex = 7
        '
        'btnFile
        '
        Me.btnFile.Location = New System.Drawing.Point(290, 304)
        Me.btnFile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(31, 23)
        Me.btnFile.TabIndex = 8
        Me.btnFile.Text = "..."
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(178, 355)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(143, 42)
        Me.btnApply.TabIndex = 9
        Me.btnApply.Text = "Apply!"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'gpbOptions
        '
        Me.gpbOptions.Controls.Add(Me.lblIndex)
        Me.gpbOptions.Controls.Add(Me.nmbIndex)
        Me.gpbOptions.Location = New System.Drawing.Point(14, 349)
        Me.gpbOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbOptions.Name = "gpbOptions"
        Me.gpbOptions.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbOptions.Size = New System.Drawing.Size(143, 48)
        Me.gpbOptions.TabIndex = 11
        Me.gpbOptions.TabStop = False
        Me.gpbOptions.Text = "Options"
        '
        'lblIndex
        '
        Me.lblIndex.AutoSize = True
        Me.lblIndex.Location = New System.Drawing.Point(29, 20)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.Size = New System.Drawing.Size(35, 15)
        Me.lblIndex.TabIndex = 1
        Me.lblIndex.Text = "Index"
        '
        'nmbIndex
        '
        Me.nmbIndex.Location = New System.Drawing.Point(92, 18)
        Me.nmbIndex.Name = "nmbIndex"
        Me.nmbIndex.Size = New System.Drawing.Size(39, 23)
        Me.nmbIndex.TabIndex = 0
        Me.nmbIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nmbIndex.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(178, 268)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(143, 23)
        Me.ProgressBar1.TabIndex = 12
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(178, 411)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(143, 42)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.Location = New System.Drawing.Point(213, 335)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(0, 15)
        Me.lblCheck.TabIndex = 15
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(14, 411)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(143, 42)
        Me.btnHelp.TabIndex = 16
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'lblSWMPath
        '
        Me.lblSWMPath.AutoSize = True
        Me.lblSWMPath.Location = New System.Drawing.Point(59, 330)
        Me.lblSWMPath.Name = "lblSWMPath"
        Me.lblSWMPath.Size = New System.Drawing.Size(0, 15)
        Me.lblSWMPath.TabIndex = 17
        Me.lblSWMPath.Visible = False
        '
        'txtDiskInfo
        '
        Me.txtDiskInfo.Location = New System.Drawing.Point(342, 54)
        Me.txtDiskInfo.Multiline = True
        Me.txtDiskInfo.Name = "txtDiskInfo"
        Me.txtDiskInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDiskInfo.Size = New System.Drawing.Size(341, 399)
        Me.txtDiskInfo.TabIndex = 18
        '
        'BareMetalMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 490)
        Me.Controls.Add(Me.txtDiskInfo)
        Me.Controls.Add(Me.lblSWMPath)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.gpbOptions)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnFile)
        Me.Controls.Add(Me.txtWim)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gpbOS)
        Me.Controls.Add(Me.gpbDisk)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "BareMetalMachine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bare Metal Machine"
        Me.gpbDisk.ResumeLayout(False)
        Me.gpbDisk.PerformLayout()
        Me.gpbOS.ResumeLayout(False)
        Me.gpbOS.PerformLayout()
        Me.gpbOptions.ResumeLayout(False)
        Me.gpbOptions.PerformLayout()
        CType(Me.nmbIndex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDisk As System.Windows.Forms.Label
    Friend WithEvents btnClean As System.Windows.Forms.Button
    Friend WithEvents radDisk0 As System.Windows.Forms.RadioButton
    Friend WithEvents btnOutputDisk As System.Windows.Forms.Button
    Friend WithEvents gpbDisk As System.Windows.Forms.GroupBox
    Friend WithEvents gpbOS As System.Windows.Forms.GroupBox
    Friend WithEvents radGPT As System.Windows.Forms.RadioButton
    Friend WithEvents radMBR As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtWim As System.Windows.Forms.TextBox
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents gpbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents lblClean As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents radDisk1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblDisk1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblCheck As System.Windows.Forms.Label
    Friend WithEvents lblDisk2 As System.Windows.Forms.Label
    Friend WithEvents radDisk2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblIndex As System.Windows.Forms.Label
    Friend WithEvents nmbIndex As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSWMPath As System.Windows.Forms.Label
    Friend WithEvents txtDiskInfo As System.Windows.Forms.TextBox

End Class
