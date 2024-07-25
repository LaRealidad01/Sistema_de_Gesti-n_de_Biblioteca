<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibrosForm
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIDLibro = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtEditorial = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvLibros = New System.Windows.Forms.DataGridView()
        CType(Me.dgvLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Libro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Título"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Autor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(584, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Género"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(584, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Año"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(584, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 32)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Editorial"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(984, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 32)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Estado"
        '
        'txtIDLibro
        '
        Me.txtIDLibro.Location = New System.Drawing.Point(297, 115)
        Me.txtIDLibro.Name = "txtIDLibro"
        Me.txtIDLibro.Size = New System.Drawing.Size(204, 38)
        Me.txtIDLibro.TabIndex = 7
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(297, 167)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(204, 38)
        Me.txtTitulo.TabIndex = 8
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(297, 222)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(204, 38)
        Me.txtAutor.TabIndex = 9
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(717, 216)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(204, 38)
        Me.txtGenero.TabIndex = 12
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(717, 161)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(204, 38)
        Me.txtAno.TabIndex = 11
        '
        'txtEditorial
        '
        Me.txtEditorial.Location = New System.Drawing.Point(717, 109)
        Me.txtEditorial.Name = "txtEditorial"
        Me.txtEditorial.Size = New System.Drawing.Size(204, 38)
        Me.txtEditorial.TabIndex = 10
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(1092, 109)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(204, 38)
        Me.txtEstado.TabIndex = 13
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(1144, 312)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(247, 85)
        Me.btnLimpiar.TabIndex = 18
        Me.btnLimpiar.Text = "Limpiar Campos"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(878, 312)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(247, 85)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "Buscar "
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(613, 312)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(247, 85)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar "
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(351, 312)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(247, 85)
        Me.btnEditar.TabIndex = 15
        Me.btnEditar.Text = "Editar "
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(85, 312)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(247, 85)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Agregar "
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvLibros
        '
        Me.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibros.Location = New System.Drawing.Point(39, 432)
        Me.dgvLibros.Name = "dgvLibros"
        Me.dgvLibros.RowHeadersWidth = 102
        Me.dgvLibros.RowTemplate.Height = 40
        Me.dgvLibros.Size = New System.Drawing.Size(1381, 534)
        Me.dgvLibros.TabIndex = 19
        '
        'LibrosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1478, 1002)
        Me.Controls.Add(Me.dgvLibros)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtGenero)
        Me.Controls.Add(Me.txtAno)
        Me.Controls.Add(Me.txtEditorial)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.txtIDLibro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LibrosForm"
        Me.Text = "LibrosForm"
        CType(Me.dgvLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIDLibro As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtAno As TextBox
    Friend WithEvents txtEditorial As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvLibros As DataGridView
End Class
