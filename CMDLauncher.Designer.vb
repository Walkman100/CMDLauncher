<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMDLauncher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CMDLauncher))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpFlag = New System.Windows.Forms.GroupBox()
        Me.lnkFlagHelp = New System.Windows.Forms.LinkLabel()
        Me.optC = New System.Windows.Forms.RadioButton()
        Me.optK = New System.Windows.Forms.RadioButton()
        Me.btnOpenWith = New System.Windows.Forms.Button()
        Me.btnAdvanced = New System.Windows.Forms.Button()
        Me.btnFlags = New System.Windows.Forms.Button()
        Me.btnResetIgnore = New System.Windows.Forms.Button()
        Me.grpLaunchMethod = New System.Windows.Forms.GroupBox()
        Me.lnkLaunchHelp = New System.Windows.Forms.LinkLabel()
        Me.optLaunchShell = New System.Windows.Forms.RadioButton()
        Me.optLaunchProcessDotStart = New System.Windows.Forms.RadioButton()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.cbxLocation = New System.Windows.Forms.ComboBox()
        Me.grpLaunch = New System.Windows.Forms.GroupBox()
        Me.optLaunchVar = New System.Windows.Forms.RadioButton()
        Me.txtLaunchVar = New System.Windows.Forms.TextBox()
        Me.optLaunchFile = New System.Windows.Forms.RadioButton()
        Me.txtLaunchFile = New System.Windows.Forms.TextBox()
        Me.btnLaunchBrowse = New System.Windows.Forms.Button()
        Me.selectProgram = New System.Windows.Forms.OpenFileDialog()
        Me.grpFlag.SuspendLayout()
        Me.grpLaunchMethod.SuspendLayout()
        Me.grpLocation.SuspendLayout()
        Me.grpLaunch.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Location = New System.Drawing.Point(12, 93)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(96, 93)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpFlag
        '
        Me.grpFlag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFlag.Controls.Add(Me.lnkFlagHelp)
        Me.grpFlag.Controls.Add(Me.optC)
        Me.grpFlag.Controls.Add(Me.optK)
        Me.grpFlag.Location = New System.Drawing.Point(12, 12)
        Me.grpFlag.Name = "grpFlag"
        Me.grpFlag.Size = New System.Drawing.Size(162, 42)
        Me.grpFlag.TabIndex = 2
        Me.grpFlag.TabStop = False
        Me.grpFlag.Text = "CMD Flag"
        '
        'lnkFlagHelp
        '
        Me.lnkFlagHelp.AutoSize = True
        Me.lnkFlagHelp.Location = New System.Drawing.Point(90, 21)
        Me.lnkFlagHelp.Name = "lnkFlagHelp"
        Me.lnkFlagHelp.Size = New System.Drawing.Size(29, 13)
        Me.lnkFlagHelp.TabIndex = 2
        Me.lnkFlagHelp.TabStop = True
        Me.lnkFlagHelp.Text = "Help"
        '
        'optC
        '
        Me.optC.AutoSize = True
        Me.optC.Location = New System.Drawing.Point(48, 19)
        Me.optC.Name = "optC"
        Me.optC.Size = New System.Drawing.Size(36, 17)
        Me.optC.TabIndex = 1
        Me.optC.TabStop = True
        Me.optC.Text = "/c"
        Me.optC.UseVisualStyleBackColor = True
        '
        'optK
        '
        Me.optK.AutoSize = True
        Me.optK.Location = New System.Drawing.Point(6, 19)
        Me.optK.Name = "optK"
        Me.optK.Size = New System.Drawing.Size(36, 17)
        Me.optK.TabIndex = 0
        Me.optK.TabStop = True
        Me.optK.Text = "/k"
        Me.optK.UseVisualStyleBackColor = True
        '
        'btnOpenWith
        '
        Me.btnOpenWith.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOpenWith.Location = New System.Drawing.Point(80, 64)
        Me.btnOpenWith.Name = "btnOpenWith"
        Me.btnOpenWith.Size = New System.Drawing.Size(94, 23)
        Me.btnOpenWith.TabIndex = 3
        Me.btnOpenWith.Text = "Set Open With..."
        Me.btnOpenWith.UseVisualStyleBackColor = True
        '
        'btnAdvanced
        '
        Me.btnAdvanced.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAdvanced.Location = New System.Drawing.Point(12, 64)
        Me.btnAdvanced.Name = "btnAdvanced"
        Me.btnAdvanced.Size = New System.Drawing.Size(64, 23)
        Me.btnAdvanced.TabIndex = 4
        Me.btnAdvanced.Text = "Advanced"
        Me.btnAdvanced.UseVisualStyleBackColor = True
        '
        'btnFlags
        '
        Me.btnFlags.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFlags.Location = New System.Drawing.Point(12, 60)
        Me.btnFlags.Name = "btnFlags"
        Me.btnFlags.Size = New System.Drawing.Size(162, 23)
        Me.btnFlags.TabIndex = 5
        Me.btnFlags.Text = "Custom flags..."
        Me.btnFlags.UseVisualStyleBackColor = True
        Me.btnFlags.Visible = False
        '
        'btnResetIgnore
        '
        Me.btnResetIgnore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResetIgnore.Enabled = False
        Me.btnResetIgnore.Location = New System.Drawing.Point(12, 89)
        Me.btnResetIgnore.Name = "btnResetIgnore"
        Me.btnResetIgnore.Size = New System.Drawing.Size(162, 23)
        Me.btnResetIgnore.TabIndex = 6
        Me.btnResetIgnore.Text = "Reset Ignore install dir Mesage"
        Me.btnResetIgnore.UseVisualStyleBackColor = True
        Me.btnResetIgnore.Visible = False
        '
        'grpLaunchMethod
        '
        Me.grpLaunchMethod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLaunchMethod.Controls.Add(Me.lnkLaunchHelp)
        Me.grpLaunchMethod.Controls.Add(Me.optLaunchShell)
        Me.grpLaunchMethod.Controls.Add(Me.optLaunchProcessDotStart)
        Me.grpLaunchMethod.Location = New System.Drawing.Point(12, 118)
        Me.grpLaunchMethod.Name = "grpLaunchMethod"
        Me.grpLaunchMethod.Size = New System.Drawing.Size(162, 65)
        Me.grpLaunchMethod.TabIndex = 7
        Me.grpLaunchMethod.TabStop = False
        Me.grpLaunchMethod.Text = "Launch Method"
        Me.grpLaunchMethod.Visible = False
        '
        'lnkLaunchHelp
        '
        Me.lnkLaunchHelp.AutoSize = True
        Me.lnkLaunchHelp.Location = New System.Drawing.Point(66, 44)
        Me.lnkLaunchHelp.Name = "lnkLaunchHelp"
        Me.lnkLaunchHelp.Size = New System.Drawing.Size(29, 13)
        Me.lnkLaunchHelp.TabIndex = 2
        Me.lnkLaunchHelp.TabStop = True
        Me.lnkLaunchHelp.Text = "Help"
        '
        'optLaunchShell
        '
        Me.optLaunchShell.AutoSize = True
        Me.optLaunchShell.Location = New System.Drawing.Point(6, 42)
        Me.optLaunchShell.Name = "optLaunchShell"
        Me.optLaunchShell.Size = New System.Drawing.Size(54, 17)
        Me.optLaunchShell.TabIndex = 1
        Me.optLaunchShell.TabStop = True
        Me.optLaunchShell.Text = "Shell()"
        Me.optLaunchShell.UseVisualStyleBackColor = True
        '
        'optLaunchProcessDotStart
        '
        Me.optLaunchProcessDotStart.AutoSize = True
        Me.optLaunchProcessDotStart.Location = New System.Drawing.Point(6, 19)
        Me.optLaunchProcessDotStart.Name = "optLaunchProcessDotStart"
        Me.optLaunchProcessDotStart.Size = New System.Drawing.Size(94, 17)
        Me.optLaunchProcessDotStart.TabIndex = 0
        Me.optLaunchProcessDotStart.TabStop = True
        Me.optLaunchProcessDotStart.Text = "Process.Start()"
        Me.optLaunchProcessDotStart.UseVisualStyleBackColor = True
        '
        'grpLocation
        '
        Me.grpLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLocation.Controls.Add(Me.cbxLocation)
        Me.grpLocation.Location = New System.Drawing.Point(12, 189)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(162, 46)
        Me.grpLocation.TabIndex = 8
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Opened window Location"
        Me.grpLocation.Visible = False
        '
        'cbxLocation
        '
        Me.cbxLocation.AccessibleName = "/c"
        Me.cbxLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLocation.FormattingEnabled = True
        Me.cbxLocation.Items.AddRange(New Object() {"Normal (focused)", "Normal (not focused)", "Maximised (focused)", "Minimised (focused)", "Minimised (not focused)", "Hidden (focused)"})
        Me.cbxLocation.Location = New System.Drawing.Point(6, 19)
        Me.cbxLocation.Name = "cbxLocation"
        Me.cbxLocation.Size = New System.Drawing.Size(150, 21)
        Me.cbxLocation.TabIndex = 0
        '
        'grpLaunch
        '
        Me.grpLaunch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLaunch.Controls.Add(Me.btnLaunchBrowse)
        Me.grpLaunch.Controls.Add(Me.txtLaunchFile)
        Me.grpLaunch.Controls.Add(Me.optLaunchFile)
        Me.grpLaunch.Controls.Add(Me.txtLaunchVar)
        Me.grpLaunch.Controls.Add(Me.optLaunchVar)
        Me.grpLaunch.Location = New System.Drawing.Point(12, 241)
        Me.grpLaunch.Name = "grpLaunch"
        Me.grpLaunch.Size = New System.Drawing.Size(162, 68)
        Me.grpLaunch.TabIndex = 9
        Me.grpLaunch.TabStop = False
        Me.grpLaunch.Text = "What to use to launch"
        Me.grpLaunch.Visible = False
        '
        'optLaunchVar
        '
        Me.optLaunchVar.AutoSize = True
        Me.optLaunchVar.Location = New System.Drawing.Point(6, 19)
        Me.optLaunchVar.Name = "optLaunchVar"
        Me.optLaunchVar.Size = New System.Drawing.Size(66, 17)
        Me.optLaunchVar.TabIndex = 0
        Me.optLaunchVar.TabStop = True
        Me.optLaunchVar.Text = "Variable:"
        Me.optLaunchVar.UseVisualStyleBackColor = True
        '
        'txtLaunchVar
        '
        Me.txtLaunchVar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLaunchVar.Location = New System.Drawing.Point(68, 18)
        Me.txtLaunchVar.Name = "txtLaunchVar"
        Me.txtLaunchVar.Size = New System.Drawing.Size(88, 20)
        Me.txtLaunchVar.TabIndex = 1
        '
        'optLaunchFile
        '
        Me.optLaunchFile.AutoSize = True
        Me.optLaunchFile.Location = New System.Drawing.Point(6, 42)
        Me.optLaunchFile.Name = "optLaunchFile"
        Me.optLaunchFile.Size = New System.Drawing.Size(44, 17)
        Me.optLaunchFile.TabIndex = 2
        Me.optLaunchFile.TabStop = True
        Me.optLaunchFile.Text = "File:"
        Me.optLaunchFile.UseVisualStyleBackColor = True
        '
        'txtLaunchFile
        '
        Me.txtLaunchFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLaunchFile.Location = New System.Drawing.Point(48, 41)
        Me.txtLaunchFile.Name = "txtLaunchFile"
        Me.txtLaunchFile.Size = New System.Drawing.Size(58, 20)
        Me.txtLaunchFile.TabIndex = 3
        '
        'btnLaunchBrowse
        '
        Me.btnLaunchBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLaunchBrowse.Location = New System.Drawing.Point(106, 39)
        Me.btnLaunchBrowse.Name = "btnLaunchBrowse"
        Me.btnLaunchBrowse.Size = New System.Drawing.Size(50, 23)
        Me.btnLaunchBrowse.TabIndex = 4
        Me.btnLaunchBrowse.Text = "Browse"
        Me.btnLaunchBrowse.UseVisualStyleBackColor = True
        '
        'selectProgram
        '
        Me.selectProgram.FileName = "cmd.exe"
        Me.selectProgram.Filter = "Executable files (*.exe, *.com)|*.exe; *.com|All files|*.*"
        Me.selectProgram.InitialDirectory = "C:\Windows\System32"
        Me.selectProgram.ReadOnlyChecked = True
        Me.selectProgram.Title = "Select an executable:"
        '
        'CMDLauncher
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(186, 128)
        Me.Controls.Add(Me.grpLaunch)
        Me.Controls.Add(Me.grpLocation)
        Me.Controls.Add(Me.grpLaunchMethod)
        Me.Controls.Add(Me.btnResetIgnore)
        Me.Controls.Add(Me.btnAdvanced)
        Me.Controls.Add(Me.btnOpenWith)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnFlags)
        Me.Controls.Add(Me.grpFlag)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CMDLauncher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CMDLauncher Settings"
        Me.grpFlag.ResumeLayout(False)
        Me.grpFlag.PerformLayout()
        Me.grpLaunchMethod.ResumeLayout(False)
        Me.grpLaunchMethod.PerformLayout()
        Me.grpLocation.ResumeLayout(False)
        Me.grpLaunch.ResumeLayout(False)
        Me.grpLaunch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents grpFlag As System.Windows.Forms.GroupBox
    Friend WithEvents lnkFlagHelp As System.Windows.Forms.LinkLabel
    Friend WithEvents optC As System.Windows.Forms.RadioButton
    Friend WithEvents optK As System.Windows.Forms.RadioButton
    Friend WithEvents btnOpenWith As System.Windows.Forms.Button
    Friend WithEvents btnAdvanced As System.Windows.Forms.Button
    Friend WithEvents btnFlags As System.Windows.Forms.Button
    Friend WithEvents btnResetIgnore As System.Windows.Forms.Button
    Friend WithEvents grpLaunchMethod As System.Windows.Forms.GroupBox
    Friend WithEvents lnkLaunchHelp As System.Windows.Forms.LinkLabel
    Friend WithEvents optLaunchShell As System.Windows.Forms.RadioButton
    Friend WithEvents optLaunchProcessDotStart As System.Windows.Forms.RadioButton
    Friend WithEvents grpLocation As System.Windows.Forms.GroupBox
    Friend WithEvents cbxLocation As System.Windows.Forms.ComboBox
    Friend WithEvents grpLaunch As System.Windows.Forms.GroupBox
    Friend WithEvents btnLaunchBrowse As System.Windows.Forms.Button
    Friend WithEvents txtLaunchFile As System.Windows.Forms.TextBox
    Friend WithEvents optLaunchFile As System.Windows.Forms.RadioButton
    Friend WithEvents txtLaunchVar As System.Windows.Forms.TextBox
    Friend WithEvents optLaunchVar As System.Windows.Forms.RadioButton
    Friend WithEvents selectProgram As System.Windows.Forms.OpenFileDialog

End Class
