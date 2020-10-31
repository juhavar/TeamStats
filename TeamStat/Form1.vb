Public Class Form1

    Public plCount As Integer = 0
    Public row As Integer = 70

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub addPlayerButton_Click(sender As System.Object, e As System.EventArgs) Handles addPlayerButton.Click
        plCount += 1
        row += 20
        Dim newPlayer As New Player()


    End Sub


End Class
