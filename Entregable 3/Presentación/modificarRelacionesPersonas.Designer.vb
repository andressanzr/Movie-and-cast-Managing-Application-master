<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarRelacionesPersonas
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBoxPeliculas = New System.Windows.Forms.ListBox()
        Me.ListBoxRoles = New System.Windows.Forms.ListBox()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonAñadir = New System.Windows.Forms.Button()
        Me.ListBoxRolesAñadidos = New System.Windows.Forms.ListBox()
        Me.ListBoxPeliculasAñadidas = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Role"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Films"
        '
        'ListBoxPeliculas
        '
        Me.ListBoxPeliculas.FormattingEnabled = True
        Me.ListBoxPeliculas.ItemHeight = 16
        Me.ListBoxPeliculas.Location = New System.Drawing.Point(63, 59)
        Me.ListBoxPeliculas.Name = "ListBoxPeliculas"
        Me.ListBoxPeliculas.Size = New System.Drawing.Size(165, 180)
        Me.ListBoxPeliculas.TabIndex = 6
        '
        'ListBoxRoles
        '
        Me.ListBoxRoles.FormattingEnabled = True
        Me.ListBoxRoles.ItemHeight = 16
        Me.ListBoxRoles.Location = New System.Drawing.Point(277, 59)
        Me.ListBoxRoles.Name = "ListBoxRoles"
        Me.ListBoxRoles.Size = New System.Drawing.Size(142, 180)
        Me.ListBoxRoles.TabIndex = 37
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonActualizar.Location = New System.Drawing.Point(535, 48)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(118, 71)
        Me.ButtonActualizar.TabIndex = 51
        Me.ButtonActualizar.Text = "Update Data"
        Me.ButtonActualizar.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonEliminar.Location = New System.Drawing.Point(543, 264)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(78, 29)
        Me.ButtonEliminar.TabIndex = 50
        Me.ButtonEliminar.Text = "Delete"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonLimpiar.Location = New System.Drawing.Point(543, 335)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(78, 29)
        Me.ButtonLimpiar.TabIndex = 49
        Me.ButtonLimpiar.Text = "Clear"
        Me.ButtonLimpiar.UseVisualStyleBackColor = False
        '
        'ButtonAñadir
        '
        Me.ButtonAñadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonAñadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonAñadir.Location = New System.Drawing.Point(543, 190)
        Me.ButtonAñadir.Name = "ButtonAñadir"
        Me.ButtonAñadir.Size = New System.Drawing.Size(78, 29)
        Me.ButtonAñadir.TabIndex = 48
        Me.ButtonAñadir.Text = "Add"
        Me.ButtonAñadir.UseVisualStyleBackColor = False
        '
        'ListBoxRolesAñadidos
        '
        Me.ListBoxRolesAñadidos.FormattingEnabled = True
        Me.ListBoxRolesAñadidos.ItemHeight = 16
        Me.ListBoxRolesAñadidos.Location = New System.Drawing.Point(277, 296)
        Me.ListBoxRolesAñadidos.Name = "ListBoxRolesAñadidos"
        Me.ListBoxRolesAñadidos.Size = New System.Drawing.Size(142, 180)
        Me.ListBoxRolesAñadidos.TabIndex = 55
        '
        'ListBoxPeliculasAñadidas
        '
        Me.ListBoxPeliculasAñadidas.FormattingEnabled = True
        Me.ListBoxPeliculasAñadidas.ItemHeight = 16
        Me.ListBoxPeliculasAñadidas.Location = New System.Drawing.Point(63, 296)
        Me.ListBoxPeliculasAñadidas.Name = "ListBoxPeliculasAñadidas"
        Me.ListBoxPeliculasAñadidas.Size = New System.Drawing.Size(165, 180)
        Me.ListBoxPeliculasAñadidas.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(58, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Added Films"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(272, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Added Roles"
        '
        'modificarRelacionesPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(696, 500)
        Me.Controls.Add(Me.ListBoxRolesAñadidos)
        Me.Controls.Add(Me.ListBoxPeliculasAñadidas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonAñadir)
        Me.Controls.Add(Me.ListBoxRoles)
        Me.Controls.Add(Me.ListBoxPeliculas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "modificarRelacionesPersonas"
        Me.Text = "Modify actors´ relations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBoxPeliculas As ListBox
    Friend WithEvents ListBoxRoles As ListBox
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonAñadir As Button
    Friend WithEvents ListBoxRolesAñadidos As ListBox
    Friend WithEvents ListBoxPeliculasAñadidas As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
