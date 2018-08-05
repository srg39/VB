Imports NUnit.Framework
Imports TodoList.Lists
Imports TodoList.Utilities
Imports TodoListTests.TestData

Namespace Mocks

    Public Class MockSerializer
        Inherits SerializerBase(Of PersistableTodoList)

        Private _TestDataGenerator as TestTodoItemGenerator

        Public Sub New(fileSystem As IFileSystem)
            MyBase.New(fileSystem)
        End Sub

        Public Overrides Sub SerializeToFile(fileName As String)
            _FileSystem.WriteFile(String.Empty, string.Empty)
        End Sub

        Public Overrides Function DeserializeFromFile(fileName As String) As PersistableTodoList
            Return _TestDataGenerator.GetTodoListToSave()
        End Function

        Public Sub SetupReturnList(testFileSystem As MockFileSystem, testLogSystem As MockLogSystem)
            _TestDataGenerator = new TestTodoItemGenerator(testFileSystem, testLogSystem, Me)
        End Sub

    End Class
End NameSpace