Imports PowerPoint
Imports Office = Microsoft.Office.Core
Public Class PPT
    Dim oApp As PowerPoint.Application
    Dim oPres As PowerPoint.Presentation
    Dim SF As String
    Dim SP As PowerPoint.PpSaveAsFileType
    Function PPT(ByVal Path As String, ByVal SaveFile As String, ByVal SaveParrent As PowerPoint.PpSaveAsFileType)
        On Error GoTo k
        Dim oPresentations As PowerPoint.Presentations
        Dim sTemplate = Path
        SF = SaveFile
        SP = SaveParrent
        oApp = New PowerPoint.Application
        AddHandler oApp.PresentationClose, AddressOf oApp_PresentationClose
        oApp.Visible = True
        oApp.WindowState = PowerPoint.PpWindowState.ppWindowMinimized
        oPresentations = oApp.Presentations
        oPres = oPresentations.Open(sTemplate, , , True)
        oPres.Saved = True
        oPres.Close()
        NAR(oPres)
        NAR(oPresentations)
        RemoveHandler oApp.PresentationClose, AddressOf oApp_PresentationClose
        oApp.Quit()
        NAR(oApp)
        GC.Collect()
        Exit Function
k:      MsgBox("Failed！！！", MsgBoxStyle.Exclamation)
    End Function
    Private Sub NAR(ByVal o As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(o)
        Catch
        Finally
            o = Nothing
        End Try
    End Sub
    Private Sub oApp_PresentationClose(ByVal Pres As Presentation)
        Pres.SaveAs(SF, SP)
        NAR(Pres)
    End Sub
End Class