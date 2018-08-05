Namespace Utilities

    Public MustInherit Class SerializerBase(Of T)

        Implements ITodoSerializer(Of T)

        Protected _FileSystem as IFileSystem

        Protected Sub New(fileSystem As IFileSystem)
            _FileSystem = fileSystem
        End Sub

        Public MustOverride Sub SerializeToFile(fileName As String) Implements ITodoSerializer(Of T).SerializeToFile
       
        Public MustOverride Function DeserializeFromFile(fileName As String) As T Implements ITodoSerializer(Of T).DeserializeFromFile

    End Class
End NameSpace