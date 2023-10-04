Public Class Form1
    Private Sub btnMis_Click(sender As Object, e As EventArgs) Handles btnMis.Click
        Dim text1, text3 As String
        Dim text2 As Integer
        text1 = "Visual"
        text2 = 23
        text3 = text1 & " " & text2
        MsgBox(text3)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
