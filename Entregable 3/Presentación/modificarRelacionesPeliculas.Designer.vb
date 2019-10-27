<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarRelacionesPeliculas
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
        Me.ListBoxGeneros = New System.Windows.Forms.ListBox()
        Me.ListBoxGenerosAñadidas = New System.Windows.Forms.ListBox()
        Me.ListBoxPersonasAñadidas = New System.Windows.Forms.ListBox()
        Me.ListBoxRolesAñadidos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textb = New System.Windows.Forms.Label()
        Me.ListBoxPersonas = New System.Windows.Forms.ListBox()
        Me.ListBoxRoles = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonAñadir = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxGeneros
        '
        Me.ListBoxGeneros.FormattingEnabled = True
        Me.ListBoxGeneros.ItemHeight = 16
        Me.ListBoxGeneros.Location = New System.Drawing.Point(40, 52)
        Me.ListBoxGeneros.Name = "ListBoxGeneros"
        Me.ListBoxGeneros.Size = New System.Drawing.Size(173, 164)
        Me.ListBoxGeneros.TabIndex = 0
        '
        'ListBoxGenerosAñadidas
        '
        Me.ListBoxGenerosAñadidas.FormattingEnabled = True
        Me.ListBoxGenerosAñadidas.ItemHeight = 16
        Me.ListBoxGenerosAñadidas.Location = New System.Drawing.Point(40, 277)
        Me.ListBoxGenerosAñadidas.Name = "ListBoxGenerosAñadidas"
        Me.ListBoxGenerosAñadidas.Size = New System.Drawing.Size(173, 180)
        Me.ListBoxGenerosAñadidas.TabIndex = 2
        '
        'ListBoxPersonasAñadidas
        '
        Me.ListBoxPersonasAñadidas.FormattingEnabled = True
        Me.ListBoxPersonasAñadidas.ItemHeight = 16
        Me.ListBoxPersonasAñadidas.Location = New System.Drawing.Point(261, 277)
        Me.ListBoxPersonasAñadidas.Name = "ListBoxPersonasAñadidas"
        Me.ListBoxPersonasAñadidas.Size = New System.Drawing.Size(156, 180)
        Me.ListBoxPersonasAñadidas.TabIndex = 3
        '
        'ListBoxRolesAñadidos
        '
        Me.ListBoxRolesAñadidos.FormattingEnabled = True
        Me.ListBoxRolesAñadidos.ItemHeight = 16
        Me.ListBoxRolesAñadidos.Location = New System.Drawing.Point(477, 277)
        Me.ListBoxRolesAñadidos.Name = "ListBoxRolesAñadidos"
        Me.ListBoxRolesAñadidos.Size = New System.Drawing.Size(175, 180)
        Me.ListBoxRolesAñadidos.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(35, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 18)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Added Genres List:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(256, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 18)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Added Actors List:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(472, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Added Roles List:"
        '
        'textb
        '
        Me.textb.AutoSize = True
        Me.textb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.textb.Location = New System.Drawing.Point(37, 25)
        Me.textb.Name = "textb"
        Me.textb.Size = New System.Drawing.Size(80, 18)
        Me.textb.TabIndex = 38
        Me.textb.Text = "Genre List:"
        '
        'ListBoxPersonas
        '
        Me.ListBoxPersonas.FormattingEnabled = True
        Me.ListBoxPersonas.ItemHeight = 16
        Me.ListBoxPersonas.Location = New System.Drawing.Point(249, 50)
        Me.ListBoxPersonas.Name = "ListBoxPersonas"
        Me.ListBoxPersonas.Size = New System.Drawing.Size(168, 164)
        Me.ListBoxPersonas.TabIndex = 39
        '
        'ListBoxRoles
        '
        Me.ListBoxRoles.FormattingEnabled = True
        Me.ListBoxRoles.ItemHeight = 16
        Me.ListBoxRoles.Location = New System.Drawing.Point(475, 47)
        Me.ListBoxRoles.Name = "ListBoxRoles"
        Me.ListBoxRoles.Size = New System.Drawing.Size(177, 164)
        Me.ListBoxRoles.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(246, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Actor List:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(474, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Role List"
        '
        'ButtonAñadir
        '
        Me.ButtonAñadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonAñadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonAñadir.Location = New System.Drawing.Point(695, 168)
        Me.ButtonAñadir.Name = "ButtonAñadir"
        Me.ButtonAñadir.Size = New System.Drawing.Size(78, 29)
        Me.ButtonAñadir.TabIndex = 44
        Me.ButtonAñadir.Text = "Add"
        Me.ButtonAñadir.UseVisualStyleBackColor = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonLimpiar.Location = New System.Drawing.Point(695, 313)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(78, 29)
        Me.ButtonLimpiar.TabIndex = 45
        Me.ButtonLimpiar.Text = "Clear"
        Me.ButtonLimpiar.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonEliminar.Location = New System.Drawing.Point(695, 242)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(78, 29)
        Me.ButtonEliminar.TabIndex = 46
        Me.ButtonEliminar.Text = "Delete"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonActualizar.Location = New System.Drawing.Point(687, 26)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(101, 71)
        Me.ButtonActualizar.TabIndex = 47
        Me.ButtonActualizar.Text = "Update Data"
        Me.ButtonActualizar.UseVisualStyleBackColor = False
        '
        'modificarRelacionesPeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonAñadir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBoxRoles)
        Me.Controls.Add(Me.ListBoxPersonas)
        Me.Controls.Add(Me.textb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxRolesAñadidos)
        Me.Controls.Add(Me.ListBoxPersonasAñadidas)
        Me.Controls.Add(Me.ListBoxGenerosAñadidas)
        Me.Controls.Add(Me.ListBoxGeneros)
        Me.Name = "modificarRelacionesPeliculas"
        Me.Text = "Modify Film relations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxGeneros As ListBox
    Friend WithEvents ListBoxGenerosAñadidas As ListBox
    Friend WithEvents ListBoxPersonasAñadidas As ListBox
    Friend WithEvents ListBoxRolesAñadidos As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textb As Label
    Friend WithEvents ListBoxPersonas As ListBox
    Friend WithEvents ListBoxRoles As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonAñadir As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonActualizar As Button
End Class
