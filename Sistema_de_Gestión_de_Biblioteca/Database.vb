Imports System.Data.SqlClient

Public Class Database
    Public Shared Function GetConnection() As SqlConnection
        Dim connectionString As String = "Server=DESKTOP-4HF687T;Database=GestionBiblioteca;Integrated Security=True;"
        Return New SqlConnection(connectionString)
    End Function
End Class
