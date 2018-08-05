Namespace Utilities
    Public Interface IFileSystem

        Sub WriteFile(contents As String, filename As string)
        Function Exists(filename As string) As Boolean
        Sub Delete(filename As string)

    End Interface
End NameSpace