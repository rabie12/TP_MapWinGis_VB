Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' remplacer les i par des o 
       







    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim chaine As String = TextBox1.Text
        chaine = chaine.Replace("i", "o")
        TextBox1.Text = chaine
    End Sub
End Class