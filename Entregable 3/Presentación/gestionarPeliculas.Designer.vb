<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestionarPeliculas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestionarPeliculas))
        Me.ListBoxPeliculas = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxSinopsis = New System.Windows.Forms.RichTextBox()
        Me.TextBoxTituloOriginal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBoxFotoPelicula = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxGeneros = New System.Windows.Forms.ComboBox()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NumericUpDownDuracion = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownAnno = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxTitulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBoxFotoPelicula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownAnno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxPeliculas
        '
        Me.ListBoxPeliculas.FormattingEnabled = True
        Me.ListBoxPeliculas.ItemHeight = 16
        Me.ListBoxPeliculas.Location = New System.Drawing.Point(49, 56)
        Me.ListBoxPeliculas.Name = "ListBoxPeliculas"
        Me.ListBoxPeliculas.Size = New System.Drawing.Size(186, 244)
        Me.ListBoxPeliculas.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(281, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Genre"
        '
        'TextBoxSinopsis
        '
        Me.TextBoxSinopsis.Location = New System.Drawing.Point(342, 177)
        Me.TextBoxSinopsis.Name = "TextBoxSinopsis"
        Me.TextBoxSinopsis.Size = New System.Drawing.Size(218, 141)
        Me.TextBoxSinopsis.TabIndex = 26
        Me.TextBoxSinopsis.Text = ""
        '
        'TextBoxTituloOriginal
        '
        Me.TextBoxTituloOriginal.Location = New System.Drawing.Point(342, 54)
        Me.TextBoxTituloOriginal.Name = "TextBoxTituloOriginal"
        Me.TextBoxTituloOriginal.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxTituloOriginal.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(272, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Sinopsis:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Duration:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Original Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Year:"
        '
        'PictureBoxFotoPelicula
        '
        Me.PictureBoxFotoPelicula.Image = CType(resources.GetObject("PictureBoxFotoPelicula.Image"), System.Drawing.Image)
        Me.PictureBoxFotoPelicula.Location = New System.Drawing.Point(706, 24)
        Me.PictureBoxFotoPelicula.Name = "PictureBoxFotoPelicula"
        Me.PictureBoxFotoPelicula.Size = New System.Drawing.Size(250, 363)
        Me.PictureBoxFotoPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFotoPelicula.TabIndex = 30
        Me.PictureBoxFotoPelicula.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(339, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 17)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Write film data here"
        '
        'ComboBoxGeneros
        '
        Me.ComboBoxGeneros.FormattingEnabled = True
        Me.ComboBoxGeneros.Location = New System.Drawing.Point(342, 141)
        Me.ComboBoxGeneros.Name = "ComboBoxGeneros"
        Me.ComboBoxGeneros.Size = New System.Drawing.Size(218, 24)
        Me.ComboBoxGeneros.TabIndex = 35
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ButtonGuardar.Location = New System.Drawing.Point(342, 334)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(109, 33)
        Me.ButtonGuardar.TabIndex = 36
        Me.ButtonGuardar.Text = "Save"
        Me.ButtonGuardar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(453, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 33)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'NumericUpDownDuracion
        '
        Me.NumericUpDownDuracion.Location = New System.Drawing.Point(342, 108)
        Me.NumericUpDownDuracion.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.NumericUpDownDuracion.Name = "NumericUpDownDuracion"
        Me.NumericUpDownDuracion.Size = New System.Drawing.Size(218, 22)
        Me.NumericUpDownDuracion.TabIndex = 38
        '
        'NumericUpDownAnno
        '
        Me.NumericUpDownAnno.Location = New System.Drawing.Point(342, 80)
        Me.NumericUpDownAnno.Maximum = New Decimal(New Integer() {2019, 0, 0, 0})
        Me.NumericUpDownAnno.Name = "NumericUpDownAnno"
        Me.NumericUpDownAnno.Size = New System.Drawing.Size(218, 22)
        Me.NumericUpDownAnno.TabIndex = 39
        '
        'TextBoxTitulo
        '
        Me.TextBoxTitulo.Location = New System.Drawing.Point(342, 26)
        Me.TextBoxTitulo.Name = "TextBoxTitulo"
        Me.TextBoxTitulo.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxTitulo.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Title:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(49, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 67)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Add Picture"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(342, 373)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(218, 40)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "Delete Film"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(99, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 25)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Films"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(134, 320)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 67)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Modify relations"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'gestionarPeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 425)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxTitulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDownAnno)
        Me.Controls.Add(Me.NumericUpDownDuracion)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.ComboBoxGeneros)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBoxFotoPelicula)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxSinopsis)
        Me.Controls.Add(Me.TextBoxTituloOriginal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBoxPeliculas)
        Me.Name = "gestionarPeliculas"
        Me.Text = "Modify Films"
        CType(Me.PictureBoxFotoPelicula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownAnno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxPeliculas As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxSinopsis As RichTextBox
    Friend WithEvents TextBoxTituloOriginal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBoxFotoPelicula As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBoxGeneros As ComboBox
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents NumericUpDownDuracion As NumericUpDown
    Friend WithEvents NumericUpDownAnno As NumericUpDown
    Friend WithEvents TextBoxTitulo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
End Class
