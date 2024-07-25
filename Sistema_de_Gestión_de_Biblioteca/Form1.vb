Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Aquí puedes inicializar cualquier cosa que necesites al cargar el formulario
    End Sub

    Private Sub btnLibros_Click(sender As Object, e As EventArgs) Handles btnLibros.Click
        ' Abre el formulario de gestión de libros
        Dim librosForm As New LibrosForm()
        librosForm.Show()
    End Sub

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        ' Abre el formulario de gestión de usuarios
        Dim usuariosForm As New UsuariosForm()
        usuariosForm.Show()
    End Sub

    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        ' Abre el formulario de gestión de préstamos
        Dim prestamosForm As New PrestamosForm()
        prestamosForm.Show()
    End Sub

    Private Sub btnDevoluciones_Click(sender As Object, e As EventArgs) Handles btnDevoluciones.Click
        ' Abre el formulario de gestión de devoluciones
        Dim devolucionesForm As New DevolucionesForm()
        devolucionesForm.Show()
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        ' Abre el formulario de generación de reportes
        Dim reportesForm As New ReportesForm()
        reportesForm.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ' Cierra la aplicación
        Me.Close()
    End Sub
End Class
