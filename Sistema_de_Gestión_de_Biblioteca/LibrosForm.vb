Imports System.Data.SqlClient

Public Class LibrosForm
    Private Sub LibrosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLibros()
    End Sub

    Private Sub CargarLibros()
        Dim query As String = "SELECT * FROM Libros"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using adapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvLibros.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim query As String = "INSERT INTO Libros (Titulo, Autor, Editorial, Año, Genero, Estado) VALUES (@Titulo, @Autor, @Editorial, @Ano, @Genero, @Estado)"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Titulo", txtTitulo.Text)
                command.Parameters.AddWithValue("@Autor", txtAutor.Text)
                command.Parameters.AddWithValue("@Editorial", txtEditorial.Text)
                command.Parameters.AddWithValue("@Ano", txtAno.Text)
                command.Parameters.AddWithValue("@Genero", txtGenero.Text)
                command.Parameters.AddWithValue("@Estado", txtEstado.Text)
                command.ExecuteNonQuery()
            End Using
        End Using
        CargarLibros()
        LimpiarCampos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtIDLibro.Text = "" Then
            MessageBox.Show("Seleccione un libro para editar.")
            Return
        End If

        Dim query As String = "UPDATE Libros SET Titulo = @Titulo, Autor = @Autor, Editorial = @Editorial, Año = @Ano, Genero = @Genero, Estado = @Estado WHERE ID = @ID"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", txtIDLibro.Text)
                command.Parameters.AddWithValue("@Titulo", txtTitulo.Text)
                command.Parameters.AddWithValue("@Autor", txtAutor.Text)
                command.Parameters.AddWithValue("@Editorial", txtEditorial.Text)
                command.Parameters.AddWithValue("@Ano", txtAno.Text)
                command.Parameters.AddWithValue("@Genero", txtGenero.Text)
                command.Parameters.AddWithValue("@Estado", txtEstado.Text)
                command.ExecuteNonQuery()
            End Using
        End Using
        CargarLibros()
        LimpiarCampos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIDLibro.Text = "" Then
            MessageBox.Show("Seleccione un libro para eliminar.")
            Return
        End If

        Dim query As String = "DELETE FROM Libros WHERE ID = @ID"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", txtIDLibro.Text)
                command.ExecuteNonQuery()
            End Using
        End Using
        CargarLibros()
        LimpiarCampos()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim query As String = "SELECT * FROM Libros WHERE Titulo LIKE @Titulo"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using adapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@Titulo", "%" & txtTitulo.Text & "%")
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvLibros.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtIDLibro.Clear()
        txtTitulo.Clear()
        txtAutor.Clear()
        txtEditorial.Clear()
        txtAno.Clear()
        txtGenero.Clear()
        txtEstado.Clear()
    End Sub

    Private Sub dgvLibros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibros.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvLibros.Rows(e.RowIndex)
            txtIDLibro.Text = row.Cells("ID").Value.ToString()
            txtTitulo.Text = row.Cells("Titulo").Value.ToString()
            txtAutor.Text = row.Cells("Autor").Value.ToString()
            txtEditorial.Text = row.Cells("Editorial").Value.ToString()
            txtAno.Text = row.Cells("Año").Value.ToString()
            txtGenero.Text = row.Cells("Genero").Value.ToString()
            txtEstado.Text = row.Cells("Estado").Value.ToString()
        End If
    End Sub
End Class
