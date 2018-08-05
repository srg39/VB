Imports System.Collections.ObjectModel
Imports TodoList.TodoListItems

Namespace Lists

    Public MustInherit Class TodoListBase

        Private ReadOnly _AllTodoItems As New List(Of TodoListItemBase)
    
        Public Function GetTotalNumberOfTasks() As Integer
            Return _AllTodoItems.Count
        End Function

        Public Sub Add(itemToAdd As TodoListItemBase)
            If _AllTodoItems.Contains(itemToAdd)
                Throw new Exception("Duplicate todo item already present")
            Else 
                _AllTodoItems.Add(itemToAdd)
            End If
        End Sub

    End Class
End NameSpace