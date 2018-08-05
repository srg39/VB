Imports TodoList.Lists
Imports TodoList.TodoListItems
Imports TodoList.Utilities

Namespace TestData

    Public Class TestTodoItemGenerator

        Public Const ITEM_DESCRIPTION as String = "Something that needs doing"
        Public Const OTHER_ITEM_DESCRIPTION as String = "Something that needs doing"
        Public Const  TEST_FILE_NAME As String = "C:\test\savefile.xml"
        Private _OneWeekToday As Date = DateTime.Today.Add(new TimeSpan(7,0,0))

        Private ReadOnly _FileSystem As IFileSystem
        Private ReadOnly _Log As IlogSystem
        Private ReadOnly _Serializer as ITodoSerializer(Of PersistableTodoList)

        Public Sub New(fileSystem As IFileSystem, logSystem As ILogSystem, serializer as ITodoSerializer(Of PersistableTodoList))
            _FileSystem = fileSystem
            _Log = logSystem
            _Serializer = serializer
        End Sub

        Public Function GetAnytimeTodoItem() As AnytimeTodoItem
            Return new AnytimeTodoItem( ) with {.Description = ITEM_DESCRIPTION}       
        End Function

        Public Function GetOtherAnytimeTodoItem() As AnytimeTodoItem
            Return new AnytimeTodoItem( ) with {.Description = OTHER_ITEM_DESCRIPTION}       
        End Function

        Public Function GetTodoListToSave() As PersistableTodoList

            Dim ListToSave as New PersistableTodoList(_FileSystem, _Log, _Serializer)

            ListToSave.Add(GetAnytimeTodoItem)

            Return ListToSave

        End Function

    End Class
End NameSpace