Imports System.Data.SqlClient

Public Class UsuariosForm
    Private Sub UsuariosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuarios()
    End Sub

    Private Sub CargarUsuarios()
        Dim query As String = "SELECT * FROM Usuarios"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using adapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvUsuarios.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim query As String = "INSERT INTO Usuarios (Nombre, Apellido, Direccion, Telefono, Email) VALUES (@Nombre, @Apellido, @Direccion, @Telefono, @Email)"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                command.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                command.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                command.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                command.Parameters.AddWithValue("@Email", txtEmail.Text)
                command.ExecuteNonQuery()
            End Using
        End Using
        CargarUsuarios()
        LimpiarCampos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtID.Text = "" Then
            MessageBox.Show("Seleccione un usuario para editar.")
            Return
        End If

        Dim query As String = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, Telefono = @Telefono, Email = @Email WHERE ID = @ID"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", txtID.Text)
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                command.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                command.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                command.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                command.Parameters.AddWithValue("@Email", txtEmail.Text)
                command.ExecuteNonQuery()
            End Using
        End Using
        CargarUsuarios()
        LimpiarCampos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtID.Text = "" Then
            MessageBox.Show("Seleccione un usuario para eliminar.")
            Return
        End If

        Dim query As String = "DELETE FROM Usuarios WHERE ID = @ID"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", txtID.Text)
                command.ExecuteNonQuery()
            End Using
        End Using
        CargarUsuarios()
        LimpiarCampos()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim query As String = "SELECT * FROM Usuarios WHERE Nombre LIKE @Nombre"
        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using adapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@Nombre", "%" & txtNombre.Text & "%")
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvUsuarios.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtID.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
    End Sub

    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsuarios.Rows(e.RowIndex)
            txtID.Text = row.Cells("ID").Value.ToString()
            txtNombre.Text = row.Cells("Nombre").Value.ToString()
            txtApellido.Text = row.Cells("Apellido").Value.ToString()
            txtDireccion.Text = row.Cells("Direccion").Value.ToString()
            txtTelefono.Text = row.Cells("Telefono").Value.ToString()
            txtEmail.Text = row.Cells("Email").Value.ToString()
        End If
    End Sub
End Class
