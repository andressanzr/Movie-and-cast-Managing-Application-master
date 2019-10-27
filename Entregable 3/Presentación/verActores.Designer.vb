<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verActores
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
        Me.ListBoxActores = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.TextBoxNacionalidad = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPaisNacimiento = New System.Windows.Forms.TextBox()
        Me.TextBoxCiudadNacimiento = New System.Windows.Forms.TextBox()
        Me.FotoActor = New System.Windows.Forms.PictureBox()
        Me.ListBoxPeliculasActor = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.FotoActor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxActores
        '
        Me.ListBoxActores.FormattingEnabled = True
        Me.ListBoxActores.ItemHeight = 16
        Me.ListBoxActores.Location = New System.Drawing.Point(50, 48)
        Me.ListBoxActores.Name = "ListBoxActores"
        Me.ListBoxActores.Size = New System.Drawing.Size(167, 308)
        Me.ListBoxActores.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Actors"
        '
        'TextBoxFechaNacimiento
        '
        Me.TextBoxFechaNacimiento.Location = New System.Drawing.Point(424, 126)
        Me.TextBoxFechaNacimiento.Name = "TextBoxFechaNacimiento"
        Me.TextBoxFechaNacimiento.ReadOnly = True
        Me.TextBoxFechaNacimiento.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxFechaNacimiento.TabIndex = 25
        '
        'TextBoxNacionalidad
        '
        Me.TextBoxNacionalidad.Location = New System.Drawing.Point(424, 95)
        Me.TextBoxNacionalidad.Name = "TextBoxNacionalidad"
        Me.TextBoxNacionalidad.ReadOnly = True
        Me.TextBoxNacionalidad.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxNacionalidad.TabIndex = 23
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(424, 39)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.ReadOnly = True
        Me.TextBoxNombre.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxNombre.TabIndex = 22
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(424, 67)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.ReadOnly = True
        Me.TextBoxApellido.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxApellido.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(368, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(349, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Surname:"
        '
        'TextBoxPaisNacimiento
        '
        Me.TextBoxPaisNacimiento.Location = New System.Drawing.Point(424, 186)
        Me.TextBoxPaisNacimiento.Name = "TextBoxPaisNacimiento"
        Me.TextBoxPaisNacimiento.ReadOnly = True
        Me.TextBoxPaisNacimiento.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxPaisNacimiento.TabIndex = 29
        '
        'TextBoxCiudadNacimiento
        '
        Me.TextBoxCiudadNacimiento.Location = New System.Drawing.Point(424, 155)
        Me.TextBoxCiudadNacimiento.Name = "TextBoxCiudadNacimiento"
        Me.TextBoxCiudadNacimiento.ReadOnly = True
        Me.TextBoxCiudadNacimiento.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxCiudadNacimiento.TabIndex = 27
        '
        'FotoActor
        '
        Me.FotoActor.Location = New System.Drawing.Point(738, 30)
        Me.FotoActor.Name = "FotoActor"
        Me.FotoActor.Size = New System.Drawing.Size(142, 178)
        Me.FotoActor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoActor.TabIndex = 30
        Me.FotoActor.TabStop = False
        '
        'ListBoxPeliculasActor
        '
        Me.ListBoxPeliculasActor.FormattingEnabled = True
        Me.ListBoxPeliculasActor.ItemHeight = 16
        Me.ListBoxPeliculasActor.Location = New System.Drawing.Point(424, 214)
        Me.ListBoxPeliculasActor.Name = "ListBoxPeliculasActor"
        Me.ListBoxPeliculasActor.Size = New System.Drawing.Size(218, 148)
        Me.ListBoxPeliculasActor.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(360, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Film list:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(324, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 17)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Birth Country:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(338, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Birth Place:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(343, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 17)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Birth Date:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(340, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 17)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Nationality:"
        '
        'verActores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(957, 444)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListBoxPeliculasActor)
        Me.Controls.Add(Me.FotoActor)
        Me.Controls.Add(Me.TextBoxPaisNacimiento)
        Me.Controls.Add(Me.TextBoxCiudadNacimiento)
        Me.Controls.Add(Me.TextBoxFechaNacimiento)
        Me.Controls.Add(Me.TextBoxNacionalidad)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxActores)
        Me.Name = "verActores"
        Me.Text = "Actors"
        CType(Me.FotoActor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxActores As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxFechaNacimiento As TextBox
    Friend WithEvents TextBoxNacionalidad As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPaisNacimiento As TextBox
    Friend WithEvents TextBoxCiudadNacimiento As TextBox
    Friend WithEvents FotoActor As PictureBox
    Friend WithEvents ListBoxPeliculasActor As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
