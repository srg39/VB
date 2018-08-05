Imports System.IO
Imports System.Xml.Serialization

Namespace Utilities
    Public Class TodoSerializer(Of T)
        Inherits SerializerBase(Of T)

        Public Sub New(fileSystem As IFileSystem)
            MyBase.New(fileSystem)
        End Sub

        Public Overrides Sub SerializeToFile(fileName As String) 

            Using FilestreamTempfile = New FileStream(fileName, FileMode.Create)

                Dim Serializer As New XmlSerializer(Me.GetType)
                Serializer.Serialize(FilestreamTempfile, Me)

            End Using

        End Sub

        Public Overrides Function DeserializeFromFile(fileName As String) As T 

            Dim Serializer As New XmlSerializer(GetType(T))

            Using FilestreamTempfile As New FileStream(fileName, FileMode.Open, FileAccess.Read)
                Return Serializer.Deserialize(FilestreamTempfile)
            End Using

        End Function
    End Class
End NameSpace