Public Class CMDLauncher
    Private Sub CMDLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.InstCheck Then If My.Application.CommandLineArgs.Count > 0 Then If My.Application.CommandLineArgs.Item(0) <> "noCheck" Then CheckInstDir()
        If My.Settings.InstCheck Then If My.Application.CommandLineArgs.Count = 0 Then CheckInstDir()
        RunFiles()
        ' If no arguments given:
        LoadSettings()
    End Sub

    Sub RunFiles()
        For Each s As String In My.Application.CommandLineArgs
            If s <> "noCheck" Then
                If My.Settings.LaunchMethod = 0 Then ' optLaunchProcess_Start.Checked = True
                    Process.Start(Environment.GetEnvironmentVariable("comspec"), My.Settings.Flag & " """ & s & "")
                ElseIf My.Settings.LaunchMethod = 1 Then ' optLaunchShell.Checked = True
                    Shell(Environment.GetEnvironmentVariable("comspec") & " " & My.Settings.Flag & " """ & s & "")
                End If
                Application.Exit()
            End If
        Next
    End Sub

    Sub CheckInstDir()
        If Environment.GetEnvironmentVariable("windir") <> Environment.CurrentDirectory Then
            Dim answer As Integer
            answer = MsgBox("CMDLauncher is not installed to " & Environment.GetEnvironmentVariable("windir") & "! If it is moved, Windows will not know its location and won't be able to launch bat files." _
                            & vbNewLine & "Copy now? (Press cancel to never show this again)", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "Not Installed!")
            If answer = MsgBoxResult.Yes Then
                Try
                    Shell("sudo.cmd xcopy " & _
                          Environment.CurrentDirectory & "\" & Process.GetCurrentProcess.ProcessName & ".exe " & _
                          Environment.GetEnvironmentVariable("windir") & "\", vbMinimizedNoFocus, True)
                Catch
                    Try
                        '                                              Because there's no harm trying.
                        Shell(Environment.GetEnvironmentVariable("windir") & "System32\sudo.cmd xcopy " & _
                              Environment.CurrentDirectory & "\" & Process.GetCurrentProcess.ProcessName & ".exe " & _
                              Environment.GetEnvironmentVariable("windir") & "\", vbMinimizedNoFocus, True)
                    Catch
                        My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/Walkman100/Misc/master/Binaries/sudo.cmd", "sudo.cmd")
                        Shell("sudo.cmd xcopy " & _
                              Environment.CurrentDirectory & "\" & Process.GetCurrentProcess.ProcessName & ".exe " & _
                              Environment.GetEnvironmentVariable("windir") & "\", vbMinimizedNoFocus, True)
                    End Try
                End Try
                Threading.Thread.Sleep(500)
                Shell(Environment.GetEnvironmentVariable("windir") & "\" & Process.GetCurrentProcess.ProcessName & ".exe noCheck", vbNormalFocus, False)
                Application.Exit()
            ElseIf answer = MsgBoxResult.Cancel Then
                My.Settings.InstCheck = False
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SetSettings()
        My.Settings.Save()
        Application.Exit()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Sub LoadSettings()
        If My.Settings.Flag = "/c" Then
            optC.Checked = True
        ElseIf My.Settings.Flag = "/k" Then
            optK.Checked = True
        End If
        If My.Settings.LaunchMethod = 0 Then
            optLaunchProcess_Start.Checked = True
        ElseIf My.Settings.LaunchMethod = 1 Then
            optLaunchShell.Checked = True
        End If
    End Sub

    Sub SetSettings()
        If optC.Checked = True Then
            My.Settings.Flag = "/c"
        ElseIf optK.Checked = True Then
            My.Settings.Flag = "/k"
        End If
        If optLaunchProcess_Start.Checked = True Then
            My.Settings.LaunchMethod = 0
        ElseIf optLaunchShell.Checked = True Then
            My.Settings.LaunchMethod = 1
        End If
    End Sub

    Private Sub btnOpenWith_Click(sender As Object, e As EventArgs) Handles btnOpenWith.Click
        Process.Start("rundll32", "C:\Windows\system32\shell32.dll,OpenAs_RunDLL .bat")
    End Sub

    Private Sub btnAdvanced_Click(sender As Object, e As EventArgs) Handles btnAdvanced.Click
        If Me.Height = 300 Then ' Show Basic
            Me.Height = 166
            btnAdvanced.Text = "Advanced"
            btnFlags.Hide()
            btnResetIgnore.Hide()
            grpLaunch.Hide()
        Else ' Show Advanced
            Me.Height = 300
            btnAdvanced.Text = "Basic"
            btnFlags.Show()
            btnResetIgnore.Show()
            If My.Settings.InstCheck = False Then btnResetIgnore.Enabled = True
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
        btnResetIgnore.Enabled = False
    End Sub

    Private Sub lnkLaunchHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLaunchHelp.LinkClicked
        MsgBox("Shell() allows CMDLauncher to easily specify window info for the CMD window" & vbNewLine & vbNewLine & _
               "Process.Start() is more secure and launches the process seperately", MsgBoxStyle.Information, "Launch Method Info")
    End Sub
End Class
