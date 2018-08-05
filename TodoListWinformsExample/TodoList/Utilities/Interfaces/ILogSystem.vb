Namespace Utilities
    Public Interface ILogSystem

        sub WriteInfo(message As String)
        sub WriteDebug(message As String)
        sub WriteWarn(message As String)
        sub WriteError(message As String, ex As Exception)

    End Interface
End NameSpace