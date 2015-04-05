Public Class EditEntry

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If IsValid() Then
            DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Function IsValid() As Boolean


        If ((txtHours.Text.Length = 0)) Then
            MsgBox(" You must enter the amount of hours worked!")
            Return False
        ElseIf (txtDescription.Text.Length <= 10) Then

            MsgBox(" Report descriptions must be at least 10 characters long! ")
            Return False

        End If
        Return True

    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub

    Private Sub EditEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class