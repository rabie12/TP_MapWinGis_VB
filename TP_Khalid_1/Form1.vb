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
                '' on vérifier si le fichier ouvert fini par tiff 
                '' si non on lajoute autant de img et on affiche dans la carte
                If dlg.FileName.ToLower().EndsWith("tiff") Then
                    If Not carte.IsTIFFGrid(dlg.FileName) Then
                        img.Open(dlg.FileName)
                        carte.AddLayer(img, True)
                        'objectif atteind
                        Return
                    End If
                End If
                '' si ce n'est pas un shapefile ni une image
                '' c'est une grid
                grd.Open(dlg.FileName)
                carte.AddLayer(grd, True)






            End If







        End If









    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub rd_zoom_avant_CheckedChanged(sender As Object, e As EventArgs) Handles rd_zoom_avant.CheckedChanged
        Try
            carte.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn
        Catch ex As Exception

        End Try


    End Sub

    Private Sub rd_zoom_arrier_CheckedChanged(sender As Object, e As EventArgs) Handles rd_zoom_arrier.CheckedChanged
        carte.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut

    End Sub

    Private Sub rd_pan_CheckedChanged(sender As Object, e As EventArgs) Handles rd_pan.CheckedChanged
        carte.CursorMode = MapWinGIS.tkCursorMode.cmPan
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Dim f As New Form2
        f.Show()


    End Sub
End Class
