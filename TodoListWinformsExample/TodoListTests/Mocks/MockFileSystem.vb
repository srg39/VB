Imports TodoList.Utilities

Namespace Mocks

    Public Class MockFileSystem
        Implements IFileSystem

        Private _fileIsPresent as boolean

        Public Sub WriteFile(contents As String, filename As String) Implements IFileSystem.WriteFile
            _fileIsPresent = true
        End Sub

        Public Function Exists(filename As String) As Boolean Implements IFileSystem.Exists
            Return _fileIsPresent
        End Function

        Public Sub Delete(filename As String) Implements IFileSystem.Delete
            _fileIsPresent = false
        End Sub

    End Class
End NameSpace