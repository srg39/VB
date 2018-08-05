Imports TodoList.Utilities

Namespace Mocks

    Public Class MockLogSystem
        Implements ILogSystem

        Public Sub WriteInfo(message As String) Implements ILogSystem.WriteInfo
            'Do nothing
        End Sub

        Public Sub WriteDebug(message As String) Implements ILogSystem.WriteDebug
            'Do nothing
        End Sub

        Public Sub WriteWarn(message As String) Implements ILogSystem.WriteWarn
            'Do nothing
        End Sub

        Public Sub WriteError(message As String, ex As Exception) Implements ILogSystem.WriteError
            'Do nothing
        End Sub
    End Class
End NameSpace