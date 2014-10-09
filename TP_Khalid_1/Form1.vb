Public Class Form1

    Private Sub btn_add_data_Click(sender As Object, e As EventArgs) Handles btn_add_data.Click
        ' on  a déclarer 3 Objets : ShapeFile , Grid , Image 
        Dim sf As New MapWinGIS.Shapefile
        Dim grd As New MapWinGIS.Grid
        Dim img As New MapWinGIS.Image

        ' Création d'une boite de dialogue qui permet d'ouvrir soit :
        ' tout les fichier , image , shapefile , grid 
        '  verifier si elle est  valider grace a un click sur OK
        Dim dlg As New OpenFileDialog
        dlg.Filter = "All Files (*.*)|*.*|" & sf.CdlgFilter & "|" & grd.CdlgFilter & " | " & img.CdlgFilter
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' on affecter l'extention du fichier ouvrir en  miniscule
            Dim extention As String
            extention = IO.Path.GetExtension(dlg.FileName).ToLower()
            ' si lextension du fichier ouvert est dans les extentions de shapefile 
            If sf.CdlgFilter.ToLower().Contains(extention) Then
                'on ouvre le fichier
                ' et on lajoute dans la carte 
                sf.Open(dlg.FileName)
                carte.AddLayer(sf, True)
                carte.ZoomToMaxExtents()
                ' l objectif est eteind
                Return
                ' traitement dune gride 
            ElseIf grd.CdlgFilter.ToLower().Contains(extention) Then
                ' le .tiff est un geotiff donc on le traite comme tiff

                If dlg.FileName.ToLower().EndsWith("tiff") Then
                    If Not carte.IsTIFFGrid(dlg.FileName) Then
                        img.Open(dlg.FileName)
                        carte.AddLayer(img, True)
                        'objectif atteind
                        Return
                    End If
                End If
                grd.Open(dlg.FileName)
                carte.AddLayer(grd, True)




            End If







        End If









    End Sub
End Class
