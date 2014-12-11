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
        Me.lnkFlag = New System.Windows.Forms.LinkLabel()
        Me.optC = New System.Windows.Forms.RadioButton()
        Me.optK = New System.Windows.Forms.RadioButton()
        Me.btnOpenWith = New System.Windows.Forms.Button()
        Me.grpFlag.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(111, 61)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(192, 61)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpFlag
        '
        Me.grpFlag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFlag.Controls.Add(Me.lnkFlag)
        Me.grpFlag.Controls.Add(Me.optC)
        Me.grpFlag.Controls.Add(Me.optK)
        Me.grpFlag.Location = New System.Drawing.Point(12, 12)
        Me.grpFlag.Name = "grpFlag"
        Me.grpFlag.Size = New System.Drawing.Size(255, 42)
        Me.grpFlag.TabIndex = 2
        Me.grpFlag.TabStop = False
        Me.grpFlag.Text = "CMD Flag"
        '
        'lnkFlag
        '
        Me.lnkFlag.AutoSize = True
        Me.lnkFlag.Location = New System.Drawing.Point(90, 21)
        Me.lnkFlag.Name = "lnkFlag"
        Me.lnkFlag.Size = New System.Drawing.Size(29, 13)
        Me.lnkFlag.TabIndex = 2
        Me.lnkFlag.TabStop = True
        Me.lnkFlag.Text = "Help"
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
        Me.btnOpenWith.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOpenWith.Location = New System.Drawing.Point(12, 61)
        Me.btnOpenWith.Name = "btnOpenWith"
        Me.btnOpenWith.Size = New System.Drawing.Size(94, 23)
        Me.btnOpenWith.TabIndex = 3
        Me.btnOpenWith.Text = "Set Open With..."
        Me.btnOpenWith.UseVisualStyleBackColor = True
        '
        'CMDLauncher
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(279, 96)
        Me.Controls.Add(Me.btnOpenWith)
        Me.Controls.Add(Me.grpFlag)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CMDLauncher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CMDLauncher Settings"
        Me.grpFlag.ResumeLayout(False)
        Me.grpFlag.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents grpFlag As System.Windows.Forms.GroupBox
    Friend WithEvents lnkFlag As System.Windows.Forms.LinkLabel
    Friend WithEvents optC As System.Windows.Forms.RadioButton
    Friend WithEvents optK As System.Windows.Forms.RadioButton
    Friend WithEvents btnOpenWith As System.Windows.Forms.Button

End Class
