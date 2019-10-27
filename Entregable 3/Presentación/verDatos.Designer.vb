<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verDatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(verDatos))
        Me.ListBoxPeliculas = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxActoresPelicula = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBoxFotoPelicula = New System.Windows.Forms.PictureBox()
        Me.TextBoxAnno = New System.Windows.Forms.TextBox()
        Me.TextBoxTituloOriginal = New System.Windows.Forms.TextBox()
        Me.TextBoxDuracion = New System.Windows.Forms.TextBox()
        Me.TextBoxSinopsis = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBoxRolesActores = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListBoxGeneros = New System.Windows.Forms.ListBox()
        CType(Me.PictureBoxFotoPelicula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxPeliculas
        '
        Me.ListBoxPeliculas.FormattingEnabled = True
        Me.ListBoxPeliculas.ItemHeight = 16
        Me.ListBoxPeliculas.Location = New System.Drawing.Point(97, 60)
        Me.ListBoxPeliculas.Name = "ListBoxPeliculas"
        Me.ListBoxPeliculas.Size = New System.Drawing.Size(186, 244)
        Me.ListBoxPeliculas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Films"
        '
        'ListBoxActoresPelicula
        '
        Me.ListBoxActoresPelicula.FormattingEnabled = True
        Me.ListBoxActoresPelicula.ItemHeight = 16
        Me.ListBoxActoresPelicula.Location = New System.Drawing.Point(412, 330)
        Me.ListBoxActoresPelicula.Name = "ListBoxActoresPelicula"
        Me.ListBoxActoresPelicula.Size = New System.Drawing.Size(173, 132)
        Me.ListBoxActoresPelicula.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Year:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Original Title:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(345, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Duration:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(342, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sinopsis:"
        '
        'PictureBoxFotoPelicula
        '
        Me.PictureBoxFotoPelicula.Image = CType(resources.GetObject("PictureBoxFotoPelicula.Image"), System.Drawing.Image)
        Me.PictureBoxFotoPelicula.Location = New System.Drawing.Point(691, 25)
        Me.PictureBoxFotoPelicula.Name = "PictureBoxFotoPelicula"
        Me.PictureBoxFotoPelicula.Size = New System.Drawing.Size(336, 527)
        Me.PictureBoxFotoPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFotoPelicula.TabIndex = 7
        Me.PictureBoxFotoPelicula.TabStop = False
        '
        'TextBoxAnno
        '
        Me.TextBoxAnno.Location = New System.Drawing.Point(412, 88)
        Me.TextBoxAnno.Name = "TextBoxAnno"
        Me.TextBoxAnno.ReadOnly = True
        Me.TextBoxAnno.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxAnno.TabIndex = 8
        '
        'TextBoxTituloOriginal
        '
        Me.TextBoxTituloOriginal.Location = New System.Drawing.Point(412, 60)
        Me.TextBoxTituloOriginal.Name = "TextBoxTituloOriginal"
        Me.TextBoxTituloOriginal.ReadOnly = True
        Me.TextBoxTituloOriginal.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxTituloOriginal.TabIndex = 9
        '
        'TextBoxDuracion
        '
        Me.TextBoxDuracion.Location = New System.Drawing.Point(412, 116)
        Me.TextBoxDuracion.Name = "TextBoxDuracion"
        Me.TextBoxDuracion.ReadOnly = True
        Me.TextBoxDuracion.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxDuracion.TabIndex = 10
        '
        'TextBoxSinopsis
        '
        Me.TextBoxSinopsis.Location = New System.Drawing.Point(412, 221)
        Me.TextBoxSinopsis.Name = "TextBoxSinopsis"
        Me.TextBoxSinopsis.ReadOnly = True
        Me.TextBoxSinopsis.Size = New System.Drawing.Size(218, 103)
        Me.TextBoxSinopsis.TabIndex = 12
        Me.TextBoxSinopsis.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(366, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cast:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(319, 484)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Cast´s roles:"
        '
        'ListBoxRolesActores
        '
        Me.ListBoxRolesActores.FormattingEnabled = True
        Me.ListBoxRolesActores.ItemHeight = 16
        Me.ListBoxRolesActores.Location = New System.Drawing.Point(412, 484)
        Me.ListBoxRolesActores.Name = "ListBoxRolesActores"
        Me.ListBoxRolesActores.Size = New System.Drawing.Size(173, 68)
        Me.ListBoxRolesActores.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(348, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Genres:"
        '
        'ListBoxGeneros
        '
        Me.ListBoxGeneros.FormattingEnabled = True
        Me.ListBoxGeneros.ItemHeight = 16
        Me.ListBoxGeneros.Location = New System.Drawing.Point(413, 147)
        Me.ListBoxGeneros.Name = "ListBoxGeneros"
        Me.ListBoxGeneros.Size = New System.Drawing.Size(217, 68)
        Me.ListBoxGeneros.TabIndex = 18
        '
        'verDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1108, 610)
        Me.Controls.Add(Me.ListBoxGeneros)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ListBoxRolesActores)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxSinopsis)
        Me.Controls.Add(Me.TextBoxDuracion)
        Me.Controls.Add(Me.TextBoxTituloOriginal)
        Me.Controls.Add(Me.TextBoxAnno)
        Me.Controls.Add(Me.PictureBoxFotoPelicula)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBoxActoresPelicula)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxPeliculas)
        Me.Name = "verDatos"
        Me.Text = "Film Data"
        CType(Me.PictureBoxFotoPelicula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxPeliculas As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxActoresPelicula As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBoxFotoPelicula As PictureBox
    Friend WithEvents TextBoxAnno As TextBox
    Friend WithEvents TextBoxTituloOriginal As TextBox
    Friend WithEvents TextBoxDuracion As TextBox
    Friend WithEvents TextBoxSinopsis As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBoxRolesActores As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBoxGeneros As ListBox
End Class
