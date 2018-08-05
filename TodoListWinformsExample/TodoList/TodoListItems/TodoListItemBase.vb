Namespace TodoListItems
    Public MustInherit Class TodoListItemBase

        Private _Description as String = String.Empty
        Private _CompletionStatus as CompletionStatuses

        Public Enum CompletionStatuses
            Incomplete
            Complete
        End Enum

        Public Property Description As String
            Get
                Return _Description
            End Get
            Set
                _Description = value
            End Set
        End Property

        Public Property CompletionStatus As CompletionStatuses
            Get
                Return _CompletionStatus
            End Get
            Set
                _CompletionStatus = value
            End Set
        End Property
    End Class
End NameSpace