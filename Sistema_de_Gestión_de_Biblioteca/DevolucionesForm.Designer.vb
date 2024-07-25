<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevolucionesForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIDDevolucion = New System.Windows.Forms.TextBox()
        Me.txtIDPrestamo = New System.Windows.Forms.TextBox()
        Me.txtIDLibro = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtIDUsuario = New System.Windows.Forms.TextBox()
        Me.btnRegistrarDevolucion = New System.Windows.Forms.Button()
        Me.btnBuscarPrestamo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dtpFechaDevolucion = New System.Windows.Forms.DateTimePicker()
        Me.dgvDevoluciones = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvDevoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Devolución"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Préstamo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Libro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(644, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(644, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(243, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Devolución"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(644, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 32)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "ID Usuario"
        '
        'txtIDDevolucion
        '
        Me.txtIDDevolucion.Location = New System.Drawing.Point(398, 173)
        Me.txtIDDevolucion.Name = "txtIDDevolucion"
        Me.txtIDDevolucion.Size = New System.Drawing.Size(227, 38)
        Me.txtIDDevolucion.TabIndex = 6
        '
        'txtIDPrestamo
        '
        Me.txtIDPrestamo.Location = New System.Drawing.Point(398, 238)
        Me.txtIDPrestamo.Name = "txtIDPrestamo"
        Me.txtIDPrestamo.Size = New System.Drawing.Size(227, 38)
        Me.txtIDPrestamo.TabIndex = 7
        '
        'txtIDLibro
        '
        Me.txtIDLibro.Location = New System.Drawing.Point(398, 305)
        Me.txtIDLibro.Name = "txtIDLibro"
        Me.txtIDLibro.Size = New System.Drawing.Size(227, 38)
        Me.txtIDLibro.TabIndex = 8
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(765, 305)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(227, 38)
        Me.txtEstado.TabIndex = 11
        '
        'txtIDUsuario
        '
        Me.txtIDUsuario.Location = New System.Drawing.Point(797, 170)
        Me.txtIDUsuario.Name = "txtIDUsuario"
        Me.txtIDUsuario.Size = New System.Drawing.Size(227, 38)
        Me.txtIDUsuario.TabIndex = 9
        '
        'btnRegistrarDevolucion
        '
        Me.btnRegistrarDevolucion.Location = New System.Drawing.Point(202, 389)
        Me.btnRegistrarDevolucion.Name = "btnRegistrarDevolucion"
        Me.btnRegistrarDevolucion.Size = New System.Drawing.Size(423, 71)
        Me.btnRegistrarDevolucion.TabIndex = 12
        Me.btnRegistrarDevolucion.Text = "Registrar Devolución"
        Me.btnRegistrarDevolucion.UseVisualStyleBackColor = True
        '
        'btnBuscarPrestamo
        '
        Me.btnBuscarPrestamo.Location = New System.Drawing.Point(631, 389)
        Me.btnBuscarPrestamo.Name = "btnBuscarPrestamo"
        Me.btnBuscarPrestamo.Size = New System.Drawing.Size(314, 71)
        Me.btnBuscarPrestamo.TabIndex = 13
        Me.btnBuscarPrestamo.Text = "Buscar Préstamo"
        Me.btnBuscarPrestamo.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(971, 389)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(269, 71)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.Text = "Limpiar Campos"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'dtpFechaDevolucion
        '
        Me.dtpFechaDevolucion.Location = New System.Drawing.Point(893, 244)
        Me.dtpFechaDevolucion.Name = "dtpFechaDevolucion"
        Me.dtpFechaDevolucion.Size = New System.Drawing.Size(541, 38)
        Me.dtpFechaDevolucion.TabIndex = 15
        '
        'dgvDevoluciones
        '
        Me.dgvDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDevoluciones.Location = New System.Drawing.Point(76, 510)
        Me.dgvDevoluciones.Name = "dgvDevoluciones"
        Me.dgvDevoluciones.RowHeadersWidth = 102
        Me.dgvDevoluciones.RowTemplate.Height = 40
        Me.dgvDevoluciones.Size = New System.Drawing.Size(1434, 610)
        Me.dgvDevoluciones.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.1!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(540, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(452, 78)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Devoluciones"
        '
        'DevolucionesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1590, 1179)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvDevoluciones)
        Me.Controls.Add(Me.dtpFechaDevolucion)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscarPrestamo)
        Me.Controls.Add(Me.btnRegistrarDevolucion)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtIDUsuario)
        Me.Controls.Add(Me.txtIDLibro)
        Me.Controls.Add(Me.txtIDPrestamo)
        Me.Controls.Add(Me.txtIDDevolucion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DevolucionesForm"
        Me.Text = "DevolucionesForm"
        CType(Me.dgvDevoluciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIDDevolucion As TextBox
    Friend WithEvents txtIDPrestamo As TextBox
    Friend WithEvents txtIDLibro As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtIDUsuario As TextBox
    Friend WithEvents btnRegistrarDevolucion As Button
    Friend WithEvents btnBuscarPrestamo As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents dtpFechaDevolucion As DateTimePicker
    Friend WithEvents dgvDevoluciones As DataGridView
    Friend WithEvents Label7 As Label
End Class
