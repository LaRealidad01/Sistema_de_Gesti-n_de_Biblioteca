Imports System.Data.SqlClient
Imports System.IO
Imports OfficeOpenXml

Public Class ReportesForm
    Private Sub ReportesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipoReporte.Items.Add("Libros Prestados")
        cmbTipoReporte.Items.Add("Usuarios Activos")
        cmbTipoReporte.Items.Add("Historial de Préstamos")
        cmbTipoReporte.SelectedIndex = 0
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim query As String = String.Empty

        Select Case cmbTipoReporte.SelectedItem.ToString()
            Case "Libros Prestados"
                query = "SELECT * FROM Prestamos WHERE Estado = 'Prestado'"
            Case "Usuarios Activos"
                query = "SELECT * FROM Usuarios WHERE ID IN (SELECT DISTINCT ID_Usuario FROM Prestamos)"
            Case "Historial de Préstamos"
                query = "SELECT * FROM Prestamos"
                ' Agregar más casos según sea necesario
        End Select

        Using connection As SqlConnection = Database.GetConnection()
            connection.Open()
            Using adapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvReportes.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        If dgvReportes.Rows.Count > 0 Then
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx"
            sfd.FileName = "Reporte.xlsx"
            If sfd.ShowDialog() = DialogResult.OK Then
                ExportarAExcel(sfd.FileName)
            End If
        Else
            MessageBox.Show("No hay datos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ExportarAExcel(fileName As String)
        Using pck As New ExcelPackage()
            Dim ws = pck.Workbook.Worksheets.Add("Reporte")

            ' Agregar encabezados
            For i As Integer = 1 To dgvReportes.Columns.Count
                ws.Cells(1, i).Value = dgvReportes.Columns(i - 1).HeaderText
            Next

            ' Agregar datos
            For i As Integer = 0 To dgvReportes.Rows.Count - 1
                For j As Integer = 0 To dgvReportes.Columns.Count - 1
                    ws.Cells(i + 2, j + 1).Value = dgvReportes.Rows(i).Cells(j).Value
                Next
            Next

            ' Guardar archivo
            Dim file As New FileInfo(fileName)
            pck.SaveAs(file)
        End Using

        MessageBox.Show("Datos exportados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dgvReportes.DataSource = Nothing
        cmbTipoReporte.SelectedIndex = 0
    End Sub
End Class
