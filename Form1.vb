Public Class Form1
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        Dim grade As String
        grade = ComboBox1.Text

        Select Case grade
            Case "A"
                txtResults.Text = "High Distinction"
            Case "A-"
                txtResults.Text = "Distinction"
            Case "B"
                txtResults.Text = "Credit"
            Case "C"
                txtResults.Text = "Pass"
            Case "D"
                txtResults.Text = "Fail"
            Case Else
                txtResults.Text = "Fail"
        End Select
    End Sub
End Class
