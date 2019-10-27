<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestionarPersonas
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
        Me.FotoActor = New System.Windows.Forms.PictureBox()
        Me.TextBoxPaisNacimiento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxCiudadNacimiento = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxNacionalidad = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxActores = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePickerFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.FotoActor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FotoActor
        '
        Me.FotoActor.Location = New System.Drawing.Point(700, 44)
        Me.FotoActor.Name = "FotoActor"
        Me.FotoActor.Size = New System.Drawing.Size(142, 178)
        Me.FotoActor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoActor.TabIndex = 47
        Me.FotoActor.TabStop = False
        '
        'TextBoxPaisNacimiento
        '
        Me.TextBoxPaisNacimiento.Location = New System.Drawing.Point(386, 200)
        Me.TextBoxPaisNacimiento.Name = "TextBoxPaisNacimiento"
        Me.TextBoxPaisNacimiento.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxPaisNacimiento.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 17)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Birth Country:"
        '
        'TextBoxCiudadNacimiento
        '
        Me.TextBoxCiudadNacimiento.Location = New System.Drawing.Point(386, 169)
        Me.TextBoxCiudadNacimiento.Name = "TextBoxCiudadNacimiento"
        Me.TextBoxCiudadNacimiento.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxCiudadNacimiento.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Birth Place:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(305, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Birth Date:"
        '
        'TextBoxNacionalidad
        '
        Me.TextBoxNacionalidad.Location = New System.Drawing.Point(386, 109)
        Me.TextBoxNacionalidad.Name = "TextBoxNacionalidad"
        Me.TextBoxNacionalidad.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxNacionalidad.TabIndex = 40
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(386, 53)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxNombre.TabIndex = 39
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(386, 81)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxApellido.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Nationality:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(311, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Surname:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Actors"
        '
        'ListBoxActores
        '
        Me.ListBoxActores.FormattingEnabled = True
        Me.ListBoxActores.ItemHeight = 16
        Me.ListBoxActores.Location = New System.Drawing.Point(12, 62)
        Me.ListBoxActores.Name = "ListBoxActores"
        Me.ListBoxActores.Size = New System.Drawing.Size(167, 260)
        Me.ListBoxActores.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(386, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 32)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(514, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 32)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DateTimePickerFechaNacimiento
        '
        Me.DateTimePickerFechaNacimiento.Location = New System.Drawing.Point(386, 140)
        Me.DateTimePickerFechaNacimiento.Name = "DateTimePickerFechaNacimiento"
        Me.DateTimePickerFechaNacimiento.Size = New System.Drawing.Size(218, 22)
        Me.DateTimePickerFechaNacimiento.TabIndex = 52
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(386, 310)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(218, 31)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "Update Photo"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(700, 261)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 68)
        Me.Button4.TabIndex = 54
        Me.Button4.Text = "Modify relations"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(386, 276)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(218, 30)
        Me.Button5.TabIndex = 55
        Me.Button5.Text = "Delete Actor"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'gestionarPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(891, 348)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DateTimePickerFechaNacimiento)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FotoActor)
        Me.Controls.Add(Me.TextBoxPaisNacimiento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxCiudadNacimiento)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxNacionalidad)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxApellido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxActores)
        Me.Name = "gestionarPersonas"
        Me.Text = "Modify Actors"
        CType(Me.FotoActor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FotoActor As PictureBox
    Friend WithEvents TextBoxPaisNacimiento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxCiudadNacimiento As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxNacionalidad As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxActores As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePickerFechaNacimiento As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
