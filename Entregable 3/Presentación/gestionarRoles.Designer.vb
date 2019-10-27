<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestionarRoles
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
        Me.ListBoxRoles = New System.Windows.Forms.ListBox()
        Me.TextBoxDescRol = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonActualizarDatos = New System.Windows.Forms.Button()
        Me.ButtonAnnadir = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 25)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Roles"
        '
        'ListBoxRoles
        '
        Me.ListBoxRoles.FormattingEnabled = True
        Me.ListBoxRoles.ItemHeight = 16
        Me.ListBoxRoles.Location = New System.Drawing.Point(59, 68)
        Me.ListBoxRoles.Name = "ListBoxRoles"
        Me.ListBoxRoles.Size = New System.Drawing.Size(149, 212)
        Me.ListBoxRoles.TabIndex = 36
        '
        'TextBoxDescRol
        '
        Me.TextBoxDescRol.Location = New System.Drawing.Point(355, 68)
        Me.TextBoxDescRol.Name = "TextBoxDescRol"
        Me.TextBoxDescRol.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxDescRol.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(252, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Role description:"
        '
        'ButtonActualizarDatos
        '
        Me.ButtonActualizarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonActualizarDatos.Location = New System.Drawing.Point(59, 304)
        Me.ButtonActualizarDatos.Name = "ButtonActualizarDatos"
        Me.ButtonActualizarDatos.Size = New System.Drawing.Size(88, 46)
        Me.ButtonActualizarDatos.TabIndex = 42
        Me.ButtonActualizarDatos.Text = "Update Data"
        Me.ButtonActualizarDatos.UseVisualStyleBackColor = False
        '
        'ButtonAnnadir
        '
        Me.ButtonAnnadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonAnnadir.Location = New System.Drawing.Point(436, 182)
        Me.ButtonAnnadir.Name = "ButtonAnnadir"
        Me.ButtonAnnadir.Size = New System.Drawing.Size(109, 33)
        Me.ButtonAnnadir.TabIndex = 43
        Me.ButtonAnnadir.Text = "Add"
        Me.ButtonAnnadir.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonEliminar.Location = New System.Drawing.Point(290, 233)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(109, 33)
        Me.ButtonEliminar.TabIndex = 44
        Me.ButtonEliminar.Text = "Delete"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonActualizar.Location = New System.Drawing.Point(290, 182)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(109, 33)
        Me.ButtonActualizar.TabIndex = 45
        Me.ButtonActualizar.Text = "Update"
        Me.ButtonActualizar.UseVisualStyleBackColor = False
        '
        'gestionarRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(618, 377)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonAnnadir)
        Me.Controls.Add(Me.ButtonActualizarDatos)
        Me.Controls.Add(Me.TextBoxDescRol)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBoxRoles)
        Me.Controls.Add(Me.Label1)
        Me.Name = "gestionarRoles"
        Me.Text = "Modify Roles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxRoles As ListBox
    Friend WithEvents TextBoxDescRol As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonActualizarDatos As Button
    Friend WithEvents ButtonAnnadir As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonActualizar As Button
End Class
