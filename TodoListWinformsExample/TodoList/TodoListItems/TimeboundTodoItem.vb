Namespace TodoListItems
    Public Class TimeboundTodoItem
        Inherits TodoListItemBase

        Private _CompleteBy As DateTime

        Public Property CompleteBy As Date
            Get
                Return _CompleteBy
            End Get
            Set
                _CompleteBy = value
            End Set
        End Property
    End Class
End NameSpace