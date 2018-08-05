Imports TodoList.Utilities

Namespace Lists

    ''' <summary>
    ''' A todo task list that can be serialized to an XML file
    ''' </summary>
    Public Class PersistableTodoList
        Inherits TodoListBase

        Private ReadOnly _FileSystem As IFileSystem
        Private ReadOnly _Log As IlogSystem
        Private ReadOnly _Serializer as ITodoSerializer(Of PersistableTodoList)

        Public Sub New(fileSystem As IFileSystem, logSystem As ILogSystem, serializer as ITodoSerializer(Of PersistableTodoList))
            _FileSystem = fileSystem
            _Log = logSystem
            _Serializer = serializer
        End Sub

        Public Sub SaveToFile(fileName As String)
            Try
                If _FileSystem.Exists(fileName) Then
                    _FileSystem.Delete(fileName)
                End If

                _Serializer.SerializeToFile(fileName)

            Catch ex As Exception
                _Log.WriteError("Error saving list to file", ex)
                Throw
            End Try
        End Sub

        Public Function ReadFromFile(fileName As String) As PersistableTodoList
            Try
                Return _Serializer.DeserializeFromFile(fileName)
            Catch ex As Exception
                _Log.WriteError("Error readint list from file", ex)
                Throw
            End Try
        End Function

    End Class
End NameSpace