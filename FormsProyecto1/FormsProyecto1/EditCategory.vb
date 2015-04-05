Public Class EditCategory
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim AnchoBorde As Integer = 5
        Dim ColorBorde As Color = Color.Red
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, ColorBorde,
        AnchoBorde, ButtonBorderStyle.Solid, ColorBorde, AnchoBorde,
        ButtonBorderStyle.Solid, ColorBorde, AnchoBorde, ButtonBorderStyle.Solid,
        ColorBorde, AnchoBorde, ButtonBorderStyle.Solid)



    End Sub
    Private Sub EditCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
  
        Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
            If IsValid() Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        End Sub

        Private Function IsValid() As Boolean


        If ((txtName.Text.Length = 0)) Then
            MsgBox(" You must enter the a name for the category!")
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
