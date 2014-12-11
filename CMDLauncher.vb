Public Class CMDLauncher
    Private Sub CMDLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each s As String In My.Application.CommandLineArgs
            Process.Start(Environment.GetEnvironmentVariable("comspec"), My.Settings.Flag & " """ & s & "")
            Application.Exit()
        Next

        ' If no arguments given
        If My.Settings.Flag = "/c" Then
            optC.Checked = True
        End If
        If My.Settings.Flag = "/k" Then
            optK.Checked = True
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
