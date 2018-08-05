Namespace Utilities
    Public Interface ITodoSerializer(Of Out T)

        Sub SerializeToFile(fileName As string)
        Function DeserializeFromFile(fileName As String) As T

    End Interface
End NameSpace