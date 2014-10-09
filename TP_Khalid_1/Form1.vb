Public Class Form1

    Private Sub btn_add_data_Click(sender As Object, e As EventArgs) Handles btn_add_data.Click
        ' on  a déclarer 3 Objets : ShapeFile , Grid , Image 
        Dim sf As New MapWinGIS.Shapefile
        Dim grd As New MapWinGIS.Grid
        Dim img As New MapWinGIS.Image

        Dim dlg As New OpenFileDialog
        dlg.Filter = "All Files (*.*)|*.*|" & sf.CdlgFilter & "|" & grd.CdlgFilter & " | " & img.CdlgFilter




        dlg.ShowDialog()








    End Sub
End Class
