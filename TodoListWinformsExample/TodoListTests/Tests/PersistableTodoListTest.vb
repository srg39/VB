Imports NUnit.Framework
Imports TodoList.Lists
Imports TodoList.TodoListItems
Imports TodoListTests.Mocks
Imports TodoListTests.TestData

Namespace Tests

    <TestFixture()>
    Public Class PersistableTodoListTest

        Private _TestTodoList As PersistableTodoList
        Private _TestDataGenerator as TestTodoItemGenerator
        Private _TestFileSystem as MockFileSystem
        Private _TestLogSystem as MockLogSystem
        Private _TestSerializer As MockSerializer

        <OneTimeSetUp()>
        Public Sub OneTimeSetUp()
            _TestFileSystem = New MockFileSystem()
            _TestLogSystem = New MockLogSystem()
            _TestSerializer = New MockSerializer(_TestFileSystem)
            _TestSerializer.SetupReturnList(_TestFileSystem, _TestLogSystem)
            _TestDataGenerator = New TestTodoItemGenerator(_TestFileSystem, _TestLogSystem, _TestSerializer)
        End Sub

        <SetUp()>
        Public Sub Setup()
            _TestTodoList = New PersistableTodoList(_TestFileSystem, _TestLogSystem, _TestSerializer)
        End Sub

        <Test()>
        Public Sub TestAddItemToList_ItemCountShouldIncrementByOne()

            Dim TestItem As TodoListItemBase = _TestDataGenerator.GetAnytimeTodoItem()

            _TestTodoList.Add(TestItem)

            Assert.AreEqual(1, _TestTodoList.GetTotalNumberOfTasks(), "Total number of tasks in todo list was incorrect")

        End Sub

        <Test()>
        Public Sub TestAddItemToListTwice_ItemCountShouldIncrementByOne_ShouldError()

            Dim TestItem As TodoListItemBase = _TestDataGenerator.GetAnytimeTodoItem()

            _TestTodoList.Add(TestItem)
       
            Assert.Throws(Of Exception)(Sub() _TestTodoList.Add(TestItem))

        End Sub

        <Test()>
        Public Sub TestAddTwoDifferentItemsToList_ItemCountShouldIncrementByTwo()

            Dim TestItem As TodoListItemBase = _TestDataGenerator.GetAnytimeTodoItem()
            Dim OtherTestItem As TodoListItemBase = _TestDataGenerator.GetOtherAnytimeTodoItem()

            _TestTodoList.Add(TestItem)
            _TestTodoList.Add(OtherTestItem)

            Assert.AreEqual(2, _TestTodoList.GetTotalNumberOfTasks(), "Total number of tasks in todo list was incorrect")

        End Sub

        <Test()>
        Public Sub TestSaveToFile_FileShouldExistAtPathOnCompletion()

            Dim ListToSave As PersistableTodoList = _TestDataGenerator.GetTodoListToSave()

            ListToSave.SaveToFile(TestTodoItemGenerator.TEST_FILE_NAME)

            Assert.IsTrue(_TestFileSystem.Exists(TestTodoItemGenerator.TEST_FILE_NAME), "File was not written during save")

        End Sub

        <Test()>
        Public Sub TestReadFromFile_ValidObjectShouldBeReturned()

            Dim ListToSave As PersistableTodoList = _TestDataGenerator.GetTodoListToSave()

            ListToSave.SaveToFile(TestTodoItemGenerator.TEST_FILE_NAME)

            Dim ListReadFromFile As PersistableTodoList = ListToSave.ReadFromFile(TestTodoItemGenerator.TEST_FILE_NAME)

            Assert.AreEqual(1, ListReadFromFile.GetTotalNumberOfTasks(), "Total number of tasks in todo list was incorrect")

        End Sub

    End Class
End NameSpace