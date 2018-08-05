Imports System.IO

Namespace Utilities

    Public Class WindowsFileSystem

        Implements IFileSystem

        Public Sub WriteFile(contents As String, filename As String) Implements IFileSystem.WriteFile
            Throw New NotImplementedException
        End Sub

        Public Function Exists(filename As String) As Boolean Implements IFileSystem.Exists
            Return File.Exists(filename)
        End Function

        Public Sub Delete(filename As String) Implements IFileSystem.Delete
            File.Delete(filename)
        End Sub
    End Class
End NameSpace