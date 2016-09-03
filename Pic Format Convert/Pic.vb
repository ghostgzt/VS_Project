Imports System.Drawing
Public Class Pic
    Dim hh As Integer
    Dim ww As Integer
    Dim gg As System.Drawing.Imaging.ImageFormat
    Dim tmppath As String = ""
    Dim BF As Boolean
    Dim gnn As New GN
    Function save(ByVal GD As Boolean, ByVal XZ As Boolean, ByVal KZM As Boolean, ByVal KZMT As String)
        On Error Resume Next
        Dim PP = mDD()
        If GD = True Then
            Dim hhv = hh
            Dim wwv = ww
            Dim QQ As New Bitmap(Image.FromFile(PP), ww, hh)
            BBFF()
            If XZ = True Then
                QQ.RotateFlip(RotateFlipType.Rotate90FlipNone)
            End If
            If KZM = True Then
                tmppath = gnn.getname(tmppath, ".", True, 0) + "." + KZMT
            End If
            QQ.Save(tmppath, gg)
            QQ.Dispose()
        Else
            Dim QQ As New Bitmap(Image.FromFile(PP))
            BBFF()
            If XZ = True Then
                QQ.RotateFlip(RotateFlipType.Rotate90FlipNone)
            End If
            If KZM = True Then
                tmppath = gnn.getname(tmppath, ".", True, 0) + "." + KZMT
            End If
            QQ.Save(tmppath, gg)
            QQ.Dispose()
        End If
        del()
    End Function
    Function BBFF()
        On Error Resume Next
        If BF = True Then
            Rename(tmppath, tmppath + ".BAK")
        Else
            Kill(tmppath)
        End If
    End Function
    Function mDD()
        del()
        On Error Resume Next
        Dim rand As New Random
        Dim bb As String = Str(rand.Next).Trim
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\%PIC%")
        My.Computer.FileSystem.CopyFile(tmppath, My.Computer.FileSystem.SpecialDirectories.Temp + "\%PIC%\" + bb + ".tmp", True)
        Return My.Computer.FileSystem.SpecialDirectories.Temp + "\%PIC%\" + bb + ".tmp"
    End Function
    Function del()
        On Error Resume Next
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\%PIC%", FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Function
    Function Run(ByVal H As Integer, ByVal W As Integer, ByVal Path As String, ByVal KS As System.Drawing.Imaging.ImageFormat, ByVal Bak As Boolean, ByVal GD As Boolean, ByVal XZ As Boolean, ByVal KZM As Boolean, ByVal KZMT As String)
        On Error Resume Next
        hh = H
        ww = W
        tmppath = Path
        gg = KS
        BF = Bak
        save(GD, XZ, KZM, KZMT)
    End Function
End Class