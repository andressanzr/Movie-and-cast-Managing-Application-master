<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestionarGeneros
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDescGenero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonActualizarDatos = New System.Windows.Forms.Button()
        Me.ButtonAñadir = New System.Windows.Forms.Button()
        Me.ButtonActualizarGenero = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxGeneros
        '
        Me.ListBoxGeneros.FormattingEnabled = True
        Me.ListBoxGeneros.ItemHeight = 16
        Me.ListBoxGeneros.Location = New System.Drawing.Point(52, 49)
        Me.ListBoxGeneros.Name = "ListBoxGeneros"
        Me.ListBoxGeneros.Size = New System.Drawing.Size(182, 260)
        Me.ListBoxGeneros.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(289, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Genre description:"
        '
        'TextBoxDescGenero
        '
        Me.TextBoxDescGenero.Location = New System.Drawing.Point(420, 68)
        Me.TextBoxDescGenero.Name = "TextBoxDescGenero"
        Me.TextBoxDescGenero.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxDescGenero.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Genres"
        '
        'ButtonActualizarDatos
        '
        Me.ButtonActualizarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonActualizarDatos.Location = New System.Drawing.Point(252, 12)
        Me.ButtonActualizarDatos.Name = "ButtonActualizarDatos"
        Me.ButtonActualizarDatos.Size = New System.Drawing.Size(131, 35)
        Me.ButtonActualizarDatos.TabIndex = 36
        Me.ButtonActualizarDatos.Text = "UpdateData"
        Me.ButtonActualizarDatos.UseVisualStyleBackColor = False
        '
        'ButtonAñadir
        '
        Me.ButtonAñadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonAñadir.Location = New System.Drawing.Point(436, 202)
        Me.ButtonAñadir.Name = "ButtonAñadir"
        Me.ButtonAñadir.Size = New System.Drawing.Size(84, 42)
        Me.ButtonAñadir.TabIndex = 37
        Me.ButtonAñadir.Text = "Add"
        Me.ButtonAñadir.UseVisualStyleBackColor = False
        '
        'ButtonActualizarGenero
        '
        Me.ButtonActualizarGenero.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonActualizarGenero.Location = New System.Drawing.Point(329, 202)
        Me.ButtonActualizarGenero.Name = "ButtonActualizarGenero"
        Me.ButtonActualizarGenero.Size = New System.Drawing.Size(84, 42)
        Me.ButtonActualizarGenero.TabIndex = 38
        Me.ButtonActualizarGenero.Text = "Update"
        Me.ButtonActualizarGenero.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonEliminar.Location = New System.Drawing.Point(329, 142)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(84, 42)
        Me.ButtonEliminar.TabIndex = 39
        Me.ButtonEliminar.Text = "Delete"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'gestionarGeneros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(586, 332)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonActualizarGenero)
        Me.Controls.Add(Me.ButtonAñadir)
        Me.Controls.Add(Me.ButtonActualizarDatos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxDescGenero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxGeneros)
        Me.Name = "gestionarGeneros"
        Me.Text = "Modify Genres"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxGeneros As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDescGenero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonActualizarDatos As Button
    Friend WithEvents ButtonAñadir As Button
    Friend WithEvents ButtonActualizarGenero As Button
    Friend WithEvents ButtonEliminar As Button
End Class
