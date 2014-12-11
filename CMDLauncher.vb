Public Class CMDLauncher
    Private Sub CMDLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.InstCheck Then If My.Application.CommandLineArgs.Count > 0 Then If My.Application.CommandLineArgs.Item(0) <> "noCheck" Then CheckInstDir()
        If My.Settings.InstCheck Then If My.Application.CommandLineArgs.Count = 0 Then CheckInstDir()

        For Each s As String In My.Application.CommandLineArgs
            If s <> "noCheck" Then
                Process.Start(Environment.GetEnvironmentVariable("comspec"), My.Settings.Flag & " """ & s & "")
                Application.Exit()
            End If
        Next

        ' If no arguments given
        If My.Settings.Flag = "/c" Then
            optC.Checked = True
        End If
        If My.Settings.Flag = "/k" Then
            optK.Checked = True
        End If
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
                Threading.Thread.Sleep(100)
                Shell(Environment.GetEnvironmentVariable("windir") & "\" & Process.GetCurrentProcess.ProcessName & ".exe noCheck", vbNormalFocus, False)
                Application.Exit()
            ElseIf answer = MsgBoxResult.Cancel Then
                My.Settings.InstCheck = False
            End If
        End If
    End Sub

    Private Sub lnkFlag_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkFlag.LinkClicked
        MsgBox("/k: Leave CMD window open after running script" & vbNewLine & "/c: Close CMD after running script", MsgBoxStyle.Information, "CMD Flag Info")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If optC.Checked = True Then
            My.Settings.Flag = "/c"
        End If
        If optK.Checked = True Then
            My.Settings.Flag = "/k"
        End If
        Application.Exit()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub btnOpenWith_Click(sender As Object, e As EventArgs) Handles btnOpenWith.Click
        Process.Start("rundll32", "C:\Windows\system32\shell32.dll,OpenAs_RunDLL .bat")
    End Sub
End Class
