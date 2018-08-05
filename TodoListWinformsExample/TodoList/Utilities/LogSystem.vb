Namespace Utilities

    Public Class LogSystem

        Implements ILogSystem

        Public Sub WriteDebug(message As String) Implements ILogSystem.WriteDebug
            'Integrate with log framework here
        End Sub

        Public Sub WriteError(message As String, ex As Exception) Implements ILogSystem.WriteError
            'Integrate with log framework here
        End Sub

        Public Sub WriteInfo(message As String) Implements ILogSystem.WriteInfo
            'Integrate with log framework here
        End Sub

        Public Sub WriteWarn(message As String) Implements ILogSystem.WriteWarn
            'Integrate with log framework here
        End Sub
    End Class
End NameSpace