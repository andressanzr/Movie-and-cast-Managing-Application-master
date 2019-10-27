<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertarActores
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
        Me.DateTimePickerFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxPaisNacimiento = New System.Windows.Forms.TextBox()
        Me.TextBoxCiudadNacimiento = New System.Windows.Forms.TextBox()
        Me.TextBoxNacionalidad = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAñadirActor = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBoxFotoActor = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxFotoActor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePickerFechaNacimiento
        '
        Me.DateTimePickerFechaNacimiento.Location = New System.Drawing.Point(168, 135)
        Me.DateTimePickerFechaNacimiento.Name = "DateTimePickerFechaNacimiento"
        Me.DateTimePickerFechaNacimiento.Size = New System.Drawing.Size(218, 22)
        Me.DateTimePickerFechaNacimiento.TabIndex = 64
        '
        'TextBoxPaisNacimiento
        '
        Me.TextBoxPaisNacimiento.Location = New System.Drawing.Point(168, 195)
        Me.TextBoxPaisNacimiento.Name = "TextBoxPaisNacimiento"
        Me.TextBoxPaisNacimiento.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxPaisNacimiento.TabIndex = 63
        '
        'TextBoxCiudadNacimiento
        '
        Me.TextBoxCiudadNacimiento.Location = New System.Drawing.Point(168, 164)
        Me.TextBoxCiudadNacimiento.Name = "TextBoxCiudadNacimiento"
        Me.TextBoxCiudadNacimiento.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxCiudadNacimiento.TabIndex = 61
        '
        'TextBoxNacionalidad
        '
        Me.TextBoxNacionalidad.Location = New System.Drawing.Point(168, 104)
        Me.TextBoxNacionalidad.Name = "TextBoxNacionalidad"
        Me.TextBoxNacionalidad.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxNacionalidad.TabIndex = 58
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(168, 48)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxNombre.TabIndex = 57
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(168, 76)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxApellido.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "New Actor"
        '
        'ButtonAñadirActor
        '
        Me.ButtonAñadirActor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonAñadirActor.Location = New System.Drawing.Point(168, 234)
        Me.ButtonAñadirActor.Name = "ButtonAñadirActor"
        Me.ButtonAñadirActor.Size = New System.Drawing.Size(127, 46)
        Me.ButtonAñadirActor.TabIndex = 66
        Me.ButtonAñadirActor.Text = "Add Actor"
        Me.ButtonAñadirActor.UseVisualStyleBackColor = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonLimpiar.Location = New System.Drawing.Point(301, 234)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(85, 46)
        Me.ButtonLimpiar.TabIndex = 67
        Me.ButtonLimpiar.Text = "Clear"
        Me.ButtonLimpiar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(168, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 53)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Add Photo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBoxFotoActor
        '
        Me.PictureBoxFotoActor.Location = New System.Drawing.Point(472, 48)
        Me.PictureBoxFotoActor.Name = "PictureBoxFotoActor"
        Me.PictureBoxFotoActor.Size = New System.Drawing.Size(188, 263)
        Me.PictureBoxFotoActor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFotoActor.TabIndex = 69
        Me.PictureBoxFotoActor.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(68, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 17)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Birth Country:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(82, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 17)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Birth Place:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(87, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 17)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Birth Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(84, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 17)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Nationality:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(113, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(93, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Surname:"
        '
        'insertarActores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBoxFotoActor)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonAñadirActor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePickerFechaNacimiento)
        Me.Controls.Add(Me.TextBoxPaisNacimiento)
        Me.Controls.Add(Me.TextBoxCiudadNacimiento)
        Me.Controls.Add(Me.TextBoxNacionalidad)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxApellido)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "insertarActores"
        Me.Text = "Insert Actors"
        CType(Me.PictureBoxFotoActor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePickerFechaNacimiento As DateTimePicker
    Friend WithEvents TextBoxPaisNacimiento As TextBox
    Friend WithEvents TextBoxCiudadNacimiento As TextBox
    Friend WithEvents TextBoxNacionalidad As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAñadirActor As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBoxFotoActor As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
