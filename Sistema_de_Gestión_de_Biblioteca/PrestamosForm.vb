Imports System.Data.SqlClient

Public Class PrestamosForm
    Private Sub PrestamosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPrestamos()
    End Sub

    Private Sub CargarPrestamos()
        Dim query As String = "SELECT * FROM Prestamos"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using adapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvPrestamos.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim query As String = "INSERT INTO Prestamos (ID_Libro, ID_Usuario, Fecha_Prestamo, Fecha_Devolucion, Estado) VALUES (@ID_Libro, @ID_Usuario, @Fecha_Prestamo, @Fecha_Devolucion, @Estado)"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID_Libro", txtIDLibro.Text)
                command.Parameters.AddWithValue("@ID_Usuario", txtIDUsuario.Text)
                command.Parameters.AddWithValue("@Fecha_Prestamo", dtpFechaPrestamo.Value)
                command.Parameters.AddWithValue("@Fecha_Devolucion", dtpFechaDevolucion.Value)
                command.Parameters.AddWithValue("@Estado", txtEstado.Text)
                command.ExecuteNonQuery()
            End Using
        End Using
        CargarPrestamos()
        LimpiarCampos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtID.Text = "" Then
            MessageBox.Show("Seleccione un préstamo para editar.")
            Return
        End If

        Dim query As String = "UPDATE Prestamos SET ID_Libro = @ID_Libro, ID_Usuario = @ID_Usuario, Fecha_Prestamo = @Fecha_Prestamo, Fecha_Devolucion = @Fecha_Devolucion, Estado = @Estado WHERE ID = @ID"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", txtID.Text)
                command.Parameters.AddWithValue("@ID_Libro", txtIDLibro.Text)
                command.Parameters.AddWithValue("@ID_Usuario", txtIDUsuario.Text)
                command.Parameters.AddWithValue("@Fecha_Prestamo", dtpFechaPrestamo.Value)
                command.Parameters.AddWithValue("@Fecha_Devolucion", dtpFechaDevolucion.Value)
                command.Parameters.AddWithValue("@Estado", txtEstado.Text)
                command.ExecuteNonQuery()
            End Using
        End Using
        CargarPrestamos()
        LimpiarCampos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtID.Text = "" Then
            MessageBox.Show("Seleccione un préstamo para eliminar.")
            Return
        End If

        Dim query As String = "DELETE FROM Prestamos WHERE ID = @ID"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", txtID.Text)
                command.ExecuteNonQuery()
            End Using
        End Using
        CargarPrestamos()
        LimpiarCampos()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim query As String = "SELECT * FROM Prestamos WHERE ID_Usuario LIKE @ID_Usuario"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using adapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@ID_Usuario", "%" & txtIDUsuario.Text & "%")
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvPrestamos.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtID.Clear()
        txtIDLibro.Clear()
        txtIDUsuario.Clear()
        dtpFechaPrestamo.Value = DateTime.Now
        dtpFechaDevolucion.Value = DateTime.Now
        txtEstado.Clear()
    End Sub

    Private Sub dgvPrestamos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrestamos.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPrestamos.Rows(e.RowIndex)
            txtID.Text = row.Cells("ID").Value.ToString()
            txtIDLibro.Text = row.Cells("ID_Libro").Value.ToString()
            txtIDUsuario.Text = row.Cells("ID_Usuario").Value.ToString()
            dtpFechaPrestamo.Value = Convert.ToDateTime(row.Cells("Fecha_Prestamo").Value)
            dtpFechaDevolucion.Value = Convert.ToDateTime(row.Cells("Fecha_Devolucion").Value)
            txtEstado.Text = row.Cells("Estado").Value.ToString()
        End If
    End Sub
End Class
