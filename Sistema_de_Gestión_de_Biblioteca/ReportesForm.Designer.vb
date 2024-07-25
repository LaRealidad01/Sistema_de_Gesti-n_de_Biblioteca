<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTipoReporte = New System.Windows.Forms.ComboBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dgvReportes = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Reporte"
        '
        'cmbTipoReporte
        '
        Me.cmbTipoReporte.FormattingEnabled = True
        Me.cmbTipoReporte.Location = New System.Drawing.Point(347, 139)
        Me.cmbTipoReporte.Name = "cmbTipoReporte"
        Me.cmbTipoReporte.Size = New System.Drawing.Size(242, 39)
        Me.cmbTipoReporte.TabIndex = 1
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(50, 229)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(355, 71)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar Reporte"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(411, 229)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(318, 71)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "Exportar a Excel"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(744, 229)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(223, 71)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'dgvReportes
        '
        Me.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReportes.Location = New System.Drawing.Point(50, 338)
        Me.dgvReportes.Name = "dgvReportes"
        Me.dgvReportes.RowHeadersWidth = 102
        Me.dgvReportes.RowTemplate.Height = 40
        Me.dgvReportes.Size = New System.Drawing.Size(1071, 415)
        Me.dgvReportes.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.1!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(422, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(318, 78)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Reportes"
        '
        'ReportesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 775)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvReportes)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.cmbTipoReporte)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReportesForm"
        Me.Text = "ReportesForm"
        CType(Me.dgvReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipoReporte As ComboBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents dgvReportes As DataGridView
    Friend WithEvents Label7 As Label
End Class
