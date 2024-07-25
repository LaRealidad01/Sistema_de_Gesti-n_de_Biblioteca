<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnLibros = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnPrestamos = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnDevoluciones = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLibros
        '
        Me.btnLibros.Location = New System.Drawing.Point(114, 270)
        Me.btnLibros.Name = "btnLibros"
        Me.btnLibros.Size = New System.Drawing.Size(215, 117)
        Me.btnLibros.TabIndex = 0
        Me.btnLibros.Text = "Gestión de Libros"
        Me.btnLibros.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.Location = New System.Drawing.Point(347, 270)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(215, 117)
        Me.btnUsuario.TabIndex = 1
        Me.btnUsuario.Text = "Gestión de Usuarios"
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'btnPrestamos
        '
        Me.btnPrestamos.Location = New System.Drawing.Point(588, 270)
        Me.btnPrestamos.Name = "btnPrestamos"
        Me.btnPrestamos.Size = New System.Drawing.Size(215, 117)
        Me.btnPrestamos.TabIndex = 2
        Me.btnPrestamos.Text = "Gestión de Préstamos"
        Me.btnPrestamos.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(588, 405)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(215, 117)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnReportes
        '
        Me.btnReportes.Location = New System.Drawing.Point(347, 405)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(215, 117)
        Me.btnReportes.TabIndex = 4
        Me.btnReportes.Text = "Generar Reportes"
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'btnDevoluciones
        '
        Me.btnDevoluciones.Location = New System.Drawing.Point(114, 405)
        Me.btnDevoluciones.Name = "btnDevoluciones"
        Me.btnDevoluciones.Size = New System.Drawing.Size(215, 117)
        Me.btnDevoluciones.TabIndex = 3
        Me.btnDevoluciones.Text = "Registrar Devoluciones"
        Me.btnDevoluciones.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.1!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(876, 78)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Administrador de biblioteca"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 699)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnReportes)
        Me.Controls.Add(Me.btnDevoluciones)
        Me.Controls.Add(Me.btnPrestamos)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.btnLibros)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLibros As Button
    Friend WithEvents btnUsuario As Button
    Friend WithEvents btnPrestamos As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnDevoluciones As Button
    Friend WithEvents Label1 As Label
End Class
