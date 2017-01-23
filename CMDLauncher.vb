Public Class CMDLauncher
    Private Sub CMDLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
        If My.Settings.InstCheck Then If My.Application.CommandLineArgs.Count > 0 Then If My.Application.CommandLineArgs.Item(0) <> "noCheck" Then CheckInstDir()
        If My.Settings.InstCheck Then If My.Application.CommandLineArgs.Count = 0 Then CheckInstDir()
        RunFiles()
    End Sub

    Sub RunFiles()
        For Each s As String In My.Application.CommandLineArgs
            If s <> "noCheck" Then
                If My.Settings.LaunchMethod = 0 Then ' optLaunchProcess_Start.Checked = True
                    If My.Settings.LaunchOption = 0 Then
                        Process.Start(Environment.GetEnvironmentVariable(My.Settings.LaunchData), My.Settings.Flag & " """ & s & "")
                    ElseIf My.Settings.LaunchOption = 1 Then
                        Process.Start(My.Settings.LaunchData, My.Settings.Flag & " """ & s & "")
                    End If
                ElseIf My.Settings.LaunchMethod = 1 Then ' optLaunchShell.Checked = True
                    If My.Settings.LaunchOption = 0 Then
                        Shell(Environment.GetEnvironmentVariable(My.Settings.LaunchData) & " " & My.Settings.Flag & " """ & s & "", My.Settings.WindowLocation)
                    ElseIf My.Settings.LaunchOption = 1 Then
                        Shell(My.Settings.LaunchData & " " & My.Settings.Flag & " """ & s & "", My.Settings.WindowLocation)
                    End If
                End If
                QuitQuitQuit()
            End If
        Next
    End Sub

    Sub CheckInstDir()
        If Environment.GetEnvironmentVariable("windir") <> Application.StartupPath Then
            If IO.File.Exists(Environment.GetEnvironmentVariable("windir") & "\CMDLauncher.exe") Then
                If My.Application.CommandLineArgs.Count > 0 Then
                    Process.Start(Environment.GetEnvironmentVariable("windir") & "\CMDLauncher.exe", "noCheck " & My.Application.CommandLineArgs.Item(0))
                Else
                    Process.Start(Environment.GetEnvironmentVariable("windir") & "\CMDLauncher.exe", "noCheck")
                End If
                QuitQuitQuit() ' Infinite loop, since it doesn't seem to exit properly
            End If
            Dim answer = MsgBox("CMDLauncher is not installed to " & Environment.GetEnvironmentVariable("windir") & _
                            "! If it is moved, Windows will not know its location and won't be able to launch bat files." _
                            & vbNewLine & "Copy now? (Press cancel to never show this again)", _
                            MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "Not Installed!")
            If answer = MsgBoxResult.Yes Then
                CreateObject("Shell.Application").ShellExecute("xcopy", Application.StartupPath & "\" & Process.GetCurrentProcess.ProcessName & ".exe " _
                                                               & Environment.GetEnvironmentVariable("windir") & "\CMDLauncher.exe", "", "runas")
                If MsgBox("Press OK when finished copying", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
                If My.Application.CommandLineArgs.Count > 0 Then
                    Process.Start(Environment.GetEnvironmentVariable("windir") & "\CMDLauncher.exe", "noCheck " & My.Application.CommandLineArgs.Item(0))
                Else
                    Process.Start(Environment.GetEnvironmentVariable("windir") & "\CMDLauncher.exe", "noCheck")
                End If
                QuitQuitQuit()
            ElseIf answer = MsgBoxResult.Cancel Then
                My.Settings.InstCheck = False
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SetSettings()
        My.Settings.Save()
        QuitQuitQuit()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
        QuitQuitQuit()
    End Sub

    Protected Sub QuitQuitQuit()
        Do Until 0 <> 0
            Application.Exit()
            End
        Loop
    End Sub

    Sub LoadSettings()
        If My.Settings.Flag = "/c" Then
            optC.Checked = True
        ElseIf My.Settings.Flag = "/k" Then
            optK.Checked = True
        Else
            optK.Checked = False
            optC.Checked = False
        End If
        If My.Settings.LaunchMethod = 0 Then
            optLaunchProcessDotStart.Checked = True
        ElseIf My.Settings.LaunchMethod = 1 Then
            optLaunchShell.Checked = True
        End If
        optLaunchShell_CheckedChanged()
        Select Case My.Settings.WindowLocation
            Case AppWinStyle.NormalFocus
                cbxLocation.SelectedIndex = 0
            Case AppWinStyle.NormalNoFocus
                cbxLocation.SelectedIndex = 1
            Case AppWinStyle.MaximizedFocus
                cbxLocation.SelectedIndex = 2
            Case AppWinStyle.MinimizedFocus
                cbxLocation.SelectedIndex = 3
            Case AppWinStyle.MinimizedNoFocus
                cbxLocation.SelectedIndex = 4
            Case AppWinStyle.Hide
                cbxLocation.SelectedIndex = 5
        End Select
        If My.Settings.LaunchOption = 0 Then
            optLaunchVar.Checked = True
            txtLaunchVar.Text = My.Settings.LaunchData
        ElseIf My.Settings.LaunchOption = 1 Then
            optLaunchFile.Checked = True
            txtLaunchFile.Text = My.Settings.LaunchData
        End If
        optLaunchVar_CheckedChanged()
    End Sub

    Sub SetSettings()
        If optC.Checked = True Then
            My.Settings.Flag = "/c"
        ElseIf optK.Checked = True Then
            My.Settings.Flag = "/k"
        End If
        If optLaunchProcessDotStart.Checked = True Then
            My.Settings.LaunchMethod = 0
        ElseIf optLaunchShell.Checked = True Then
            My.Settings.LaunchMethod = 1
        End If
        Select Case cbxLocation.SelectedIndex
            Case 0
                My.Settings.WindowLocation = AppWinStyle.NormalFocus
            Case 1
                My.Settings.WindowLocation = AppWinStyle.NormalNoFocus
            Case 2
                My.Settings.WindowLocation = AppWinStyle.MaximizedFocus
            Case 3
                My.Settings.WindowLocation = AppWinStyle.MinimizedFocus
            Case 4
                My.Settings.WindowLocation = AppWinStyle.MinimizedNoFocus
            Case 5
                My.Settings.WindowLocation = AppWinStyle.Hide
        End Select
        If optLaunchVar.Checked = True Then
            My.Settings.LaunchOption = 0
            My.Settings.LaunchData = txtLaunchVar.Text
        ElseIf optLaunchFile.Checked = True Then
            My.Settings.LaunchOption = 1
            My.Settings.LaunchData = txtLaunchFile.Text
        End If
    End Sub

    Private Sub btnOpenWith_Click(sender As Object, e As EventArgs) Handles btnOpenWith.Click
        Shell("rundll32 shell32.dll,OpenAs_RunDLL .bat", AppWinStyle.NormalFocus, True, 500)
    End Sub

    Private Sub btnAdvanced_Click(sender As Object, e As EventArgs) Handles btnAdvanced.Click
        If Me.Height = 418 Then ' Show Basic
            Me.Height = 166
            btnAdvanced.Text = "Advanced"
            btnFlags.Hide()
            btnResetIgnore.Hide()
            grpLaunchMethod.Hide()
            grpLocation.Hide()
            grpLaunch.Hide()
        Else ' Show Advanced
            Me.Height = 418
            btnAdvanced.Text = "Basic"
            btnFlags.Show()
            btnResetIgnore.Show()
            If My.Settings.InstCheck = False Then btnResetIgnore.Enabled = True
            grpLaunchMethod.Show()
            grpLocation.Show()
            grpLaunch.Show()
        End If
    End Sub

    Private Sub lnkFlag_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkFlagHelp.LinkClicked
        MsgBox("/k: Leave CMD window open after running script" & vbNewLine & "/c: Close CMD after running script", MsgBoxStyle.Information, "CMD Flag Info")
    End Sub

    Private Sub btnFlags_Click(sender As Object, e As EventArgs) Handles btnFlags.Click
        My.Settings.Flag = InputBox("flags:", "", My.Settings.Flag)
        LoadSettings()
    End Sub

    Private Sub btnResetIgnore_Click(sender As Object, e As EventArgs) Handles btnResetIgnore.Click
        My.Settings.InstCheck = True
        btnResetIgnore.Text = "Reset succesfull! Click Save"
        btnResetIgnore.Enabled = False
    End Sub

    Private Sub lnkLaunchHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLaunchHelp.LinkClicked
        MsgBox("Shell() allows CMDLauncher to easily specify window info for the CMD window" & vbNewLine & vbNewLine & _
               "Process.Start() is more secure and launches the process seperately", MsgBoxStyle.Information, "Launch Method Info")
    End Sub

    Private Sub optLaunchShell_CheckedChanged() Handles optLaunchShell.CheckedChanged
        cbxLocation.Enabled = optLaunchShell.Checked
        If optLaunchProcessDotStart.Checked Then cbxLocation.SelectedIndex = 0
    End Sub

    Private Sub optLaunchVar_CheckedChanged() Handles optLaunchVar.CheckedChanged
        txtLaunchVar.Enabled = optLaunchVar.Checked
        If optLaunchVar.Checked And txtLaunchVar.Text.Count = 0 Then txtLaunchVar.Text = "comspec"
        txtLaunchFile.Enabled = optLaunchFile.Checked
        btnLaunchBrowse.Enabled = optLaunchFile.Checked
        If optLaunchFile.Checked And txtLaunchFile.Text.Count = 0 Then btnLaunchBrowse_Click()
    End Sub

    Private Sub btnLaunchBrowse_Click() Handles btnLaunchBrowse.Click
        selectProgram.ShowDialog()
        txtLaunchFile.Text = selectProgram.FileName
    End Sub
End Class