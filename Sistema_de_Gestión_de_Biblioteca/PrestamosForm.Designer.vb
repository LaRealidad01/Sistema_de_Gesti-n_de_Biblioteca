<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrestamosForm
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtIDLibro = New System.Windows.Forms.TextBox()
        Me.txtIDUsuario = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dgvPrestamos = New System.Windows.Forms.DataGridView()
        Me.dtpFechaPrestamo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDevolucion = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Préstamo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Libro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(538, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(538, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(282, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de Devolución"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(538, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(261, 32)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Fecha de Préstamo"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(297, 131)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(186, 38)
        Me.txtID.TabIndex = 6
        '
        'txtIDLibro
        '
        Me.txtIDLibro.Location = New System.Drawing.Point(247, 201)
        Me.txtIDLibro.Name = "txtIDLibro"
        Me.txtIDLibro.Size = New System.Drawing.Size(186, 38)
        Me.txtIDLibro.TabIndex = 7
        '
        'txtIDUsuario
        '
        Me.txtIDUsuario.Location = New System.Drawing.Point(284, 279)
        Me.txtIDUsuario.Name = "txtIDUsuario"
        Me.txtIDUsuario.Size = New System.Drawing.Size(186, 38)
        Me.txtIDUsuario.TabIndex = 8
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(668, 282)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(186, 38)
        Me.txtEstado.TabIndex = 11
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(214, 367)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(198, 80)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar Préstamo"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(431, 367)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(198, 80)
        Me.btnEditar.TabIndex = 13
        Me.btnEditar.Text = "Editar Préstamo"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(864, 367)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(198, 80)
        Me.btnBuscar.TabIndex = 15
        Me.btnBuscar.Text = "Buscar Préstamo"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(647, 367)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(198, 80)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar Préstamo"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(1082, 367)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(198, 80)
        Me.btnLimpiar.TabIndex = 16
        Me.btnLimpiar.Text = "Limpiar Campos"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'dgvPrestamos
        '
        Me.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrestamos.Location = New System.Drawing.Point(53, 467)
        Me.dgvPrestamos.Name = "dgvPrestamos"
        Me.dgvPrestamos.RowHeadersWidth = 102
        Me.dgvPrestamos.RowTemplate.Height = 40
        Me.dgvPrestamos.Size = New System.Drawing.Size(1377, 479)
        Me.dgvPrestamos.TabIndex = 18
        '
        'dtpFechaPrestamo
        '
        Me.dtpFechaPrestamo.Location = New System.Drawing.Point(823, 131)
        Me.dtpFechaPrestamo.Name = "dtpFechaPrestamo"
        Me.dtpFechaPrestamo.Size = New System.Drawing.Size(539, 38)
        Me.dtpFechaPrestamo.TabIndex = 19
        '
        'dtpFechaDevolucion
        '
        Me.dtpFechaDevolucion.Location = New System.Drawing.Point(826, 201)
        Me.dtpFechaDevolucion.Name = "dtpFechaDevolucion"
        Me.dtpFechaDevolucion.Size = New System.Drawing.Size(539, 38)
        Me.dtpFechaDevolucion.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.1!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(432, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(616, 78)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Prestamo de libros"
        '
        'PrestamosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1613, 1004)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpFechaDevolucion)
        Me.Controls.Add(Me.dtpFechaPrestamo)
        Me.Controls.Add(Me.dgvPrestamos)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtIDUsuario)
        Me.Controls.Add(Me.txtIDLibro)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PrestamosForm"
        Me.Text = "PrestamosForm"
        CType(Me.dgvPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtIDLibro As TextBox
    Friend WithEvents txtIDUsuario As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents dgvPrestamos As DataGridView
    Friend WithEvents dtpFechaPrestamo As DateTimePicker
    Friend WithEvents dtpFechaDevolucion As DateTimePicker
    Friend WithEvents Label7 As Label
End Class
