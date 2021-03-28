<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visualizer
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
        Me.bttn_nuevo = New System.Windows.Forms.Button()
        Me.bttn_consultar = New System.Windows.Forms.Button()
        Me.bttn_modificar = New System.Windows.Forms.Button()
        Me.bttn_agregar = New System.Windows.Forms.Button()
        Me.bttn_salir = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_faccion = New System.Windows.Forms.Label()
        Me.lbl_poder = New System.Windows.Forms.Label()
        Me.lbl_nacimiento = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_faccion = New System.Windows.Forms.TextBox()
        Me.txt_poder = New System.Windows.Forms.TextBox()
        Me.txt_nacimiento = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bttn_nuevo
        '
        Me.bttn_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bttn_nuevo.Location = New System.Drawing.Point(17, 16)
        Me.bttn_nuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttn_nuevo.Name = "bttn_nuevo"
        Me.bttn_nuevo.Size = New System.Drawing.Size(107, 31)
        Me.bttn_nuevo.TabIndex = 0
        Me.bttn_nuevo.Text = "Nuevo"
        Me.bttn_nuevo.UseVisualStyleBackColor = True
        '
        'bttn_consultar
        '
        Me.bttn_consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bttn_consultar.Location = New System.Drawing.Point(132, 15)
        Me.bttn_consultar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttn_consultar.Name = "bttn_consultar"
        Me.bttn_consultar.Size = New System.Drawing.Size(107, 31)
        Me.bttn_consultar.TabIndex = 1
        Me.bttn_consultar.Text = "Consultar"
        Me.bttn_consultar.UseVisualStyleBackColor = True
        '
        'bttn_modificar
        '
        Me.bttn_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bttn_modificar.Location = New System.Drawing.Point(247, 15)
        Me.bttn_modificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttn_modificar.Name = "bttn_modificar"
        Me.bttn_modificar.Size = New System.Drawing.Size(107, 31)
        Me.bttn_modificar.TabIndex = 2
        Me.bttn_modificar.Text = "Modificar"
        Me.bttn_modificar.UseVisualStyleBackColor = True
        '
        'bttn_agregar
        '
        Me.bttn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bttn_agregar.Location = New System.Drawing.Point(361, 15)
        Me.bttn_agregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttn_agregar.Name = "bttn_agregar"
        Me.bttn_agregar.Size = New System.Drawing.Size(107, 31)
        Me.bttn_agregar.TabIndex = 3
        Me.bttn_agregar.Text = "Agregar"
        Me.bttn_agregar.UseVisualStyleBackColor = True
        '
        'bttn_salir
        '
        Me.bttn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bttn_salir.Location = New System.Drawing.Point(361, 333)
        Me.bttn_salir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttn_salir.Name = "bttn_salir"
        Me.bttn_salir.Size = New System.Drawing.Size(107, 31)
        Me.bttn_salir.TabIndex = 4
        Me.bttn_salir.Text = "Salir"
        Me.bttn_salir.UseVisualStyleBackColor = True
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Location = New System.Drawing.Point(161, 70)
        Me.lbl_titulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(166, 17)
        Me.lbl_titulo.TabIndex = 5
        Me.lbl_titulo.Text = "Personajes de Star Wars"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(39, 123)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(23, 17)
        Me.lbl_id.TabIndex = 6
        Me.lbl_id.Text = "Id:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(39, 151)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(62, 17)
        Me.lbl_nombre.TabIndex = 7
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_faccion
        '
        Me.lbl_faccion.AutoSize = True
        Me.lbl_faccion.Location = New System.Drawing.Point(39, 182)
        Me.lbl_faccion.Name = "lbl_faccion"
        Me.lbl_faccion.Size = New System.Drawing.Size(61, 17)
        Me.lbl_faccion.TabIndex = 8
        Me.lbl_faccion.Text = "Faccion:"
        '
        'lbl_poder
        '
        Me.lbl_poder.AutoSize = True
        Me.lbl_poder.Location = New System.Drawing.Point(39, 214)
        Me.lbl_poder.Name = "lbl_poder"
        Me.lbl_poder.Size = New System.Drawing.Size(50, 17)
        Me.lbl_poder.TabIndex = 9
        Me.lbl_poder.Text = "Poder:"
        '
        'lbl_nacimiento
        '
        Me.lbl_nacimiento.AutoSize = True
        Me.lbl_nacimiento.Location = New System.Drawing.Point(39, 247)
        Me.lbl_nacimiento.Name = "lbl_nacimiento"
        Me.lbl_nacimiento.Size = New System.Drawing.Size(82, 17)
        Me.lbl_nacimiento.TabIndex = 10
        Me.lbl_nacimiento.Text = "Nacimiento:"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(132, 120)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(107, 23)
        Me.txt_id.TabIndex = 11
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(132, 148)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(299, 23)
        Me.txt_nombre.TabIndex = 12
        '
        'txt_faccion
        '
        Me.txt_faccion.Location = New System.Drawing.Point(132, 179)
        Me.txt_faccion.Name = "txt_faccion"
        Me.txt_faccion.Size = New System.Drawing.Size(299, 23)
        Me.txt_faccion.TabIndex = 13
        '
        'txt_poder
        '
        Me.txt_poder.Location = New System.Drawing.Point(132, 211)
        Me.txt_poder.Name = "txt_poder"
        Me.txt_poder.Size = New System.Drawing.Size(299, 23)
        Me.txt_poder.TabIndex = 14
        '
        'txt_nacimiento
        '
        Me.txt_nacimiento.Location = New System.Drawing.Point(132, 244)
        Me.txt_nacimiento.Name = "txt_nacimiento"
        Me.txt_nacimiento.Size = New System.Drawing.Size(299, 23)
        Me.txt_nacimiento.TabIndex = 15
        '
        'Visualizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 372)
        Me.Controls.Add(Me.txt_nacimiento)
        Me.Controls.Add(Me.txt_poder)
        Me.Controls.Add(Me.txt_faccion)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_nacimiento)
        Me.Controls.Add(Me.lbl_poder)
        Me.Controls.Add(Me.lbl_faccion)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.bttn_salir)
        Me.Controls.Add(Me.bttn_agregar)
        Me.Controls.Add(Me.bttn_modificar)
        Me.Controls.Add(Me.bttn_consultar)
        Me.Controls.Add(Me.bttn_nuevo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Visualizer"
        Me.Text = "Personajes de Star Wars"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttn_nuevo As Button
    Friend WithEvents bttn_consultar As Button
    Friend WithEvents bttn_modificar As Button
    Friend WithEvents bttn_agregar As Button
    Friend WithEvents bttn_salir As Button
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_faccion As Label
    Friend WithEvents lbl_poder As Label
    Friend WithEvents lbl_nacimiento As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_faccion As TextBox
    Friend WithEvents txt_poder As TextBox
    Friend WithEvents txt_nacimiento As TextBox
End Class
