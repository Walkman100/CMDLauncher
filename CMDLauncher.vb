Public Class CMDLauncher
    Private Sub CMDLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lnkFlag_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkFlag.LinkClicked
        MsgBox("/k: Leave CMD window open after running script; /c: Close CMD after running script.", MsgBoxStyle.Information, "CMD Flag Info")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If optC.Checked = True Then
            My.Settings.Flag = "/c"
        End If
        If optK.Checked = True Then
            My.Settings.Flag = "/k"
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
End Class
