<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertarPeliculas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(insertarPeliculas))
        Me.TextBoxTitulo = New System.Windows.Forms.TextBox()
        Me.NumericUpDownAnno = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownDuracion = New System.Windows.Forms.NumericUpDown()
        Me.ComboBoxGeneros = New System.Windows.Forms.ComboBox()
        Me.TextBoxSinopsis = New System.Windows.Forms.RichTextBox()
        Me.TextBoxTituloOriginal = New System.Windows.Forms.TextBox()
        Me.PictureBoxFotoPelicula = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownAnno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxFotoPelicula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxTitulo
        '
        Me.TextBoxTitulo.Location = New System.Drawing.Point(136, 53)
        Me.TextBoxTitulo.Name = "TextBoxTitulo"
        Me.TextBoxTitulo.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxTitulo.TabIndex = 53
        '
        'NumericUpDownAnno
        '
        Me.NumericUpDownAnno.Location = New System.Drawing.Point(136, 107)
        Me.NumericUpDownAnno.Name = "NumericUpDownAnno"
        Me.NumericUpDownAnno.Size = New System.Drawing.Size(218, 22)
        Me.NumericUpDownAnno.TabIndex = 51
        '
        'NumericUpDownDuracion
        '
        Me.NumericUpDownDuracion.Location = New System.Drawing.Point(136, 135)
        Me.NumericUpDownDuracion.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.NumericUpDownDuracion.Name = "NumericUpDownDuracion"
        Me.NumericUpDownDuracion.Size = New System.Drawing.Size(218, 22)
        Me.NumericUpDownDuracion.TabIndex = 50
        '
        'ComboBoxGeneros
        '
        Me.ComboBoxGeneros.FormattingEnabled = True
        Me.ComboBoxGeneros.Location = New System.Drawing.Point(136, 168)
        Me.ComboBoxGeneros.Name = "ComboBoxGeneros"
        Me.ComboBoxGeneros.Size = New System.Drawing.Size(218, 24)
        Me.ComboBoxGeneros.TabIndex = 49
        '
        'TextBoxSinopsis
        '
        Me.TextBoxSinopsis.Location = New System.Drawing.Point(136, 204)
        Me.TextBoxSinopsis.Name = "TextBoxSinopsis"
        Me.TextBoxSinopsis.Size = New System.Drawing.Size(218, 141)
        Me.TextBoxSinopsis.TabIndex = 47
        Me.TextBoxSinopsis.Text = ""
        '
        'TextBoxTituloOriginal
        '
        Me.TextBoxTituloOriginal.Location = New System.Drawing.Point(136, 81)
        Me.TextBoxTituloOriginal.Name = "TextBoxTituloOriginal"
        Me.TextBoxTituloOriginal.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxTituloOriginal.TabIndex = 46
        '
        'PictureBoxFotoPelicula
        '
        Me.PictureBoxFotoPelicula.Image = CType(resources.GetObject("PictureBoxFotoPelicula.Image"), System.Drawing.Image)
        Me.PictureBoxFotoPelicula.Location = New System.Drawing.Point(497, 30)
        Me.PictureBoxFotoPelicula.Name = "PictureBoxFotoPelicula"
        Me.PictureBoxFotoPelicula.Size = New System.Drawing.Size(250, 363)
        Me.PictureBoxFotoPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFotoPelicula.TabIndex = 54
        Me.PictureBoxFotoPelicula.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(372, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 52)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Add Photo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(130, 351)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(224, 67)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Add Film"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(131, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 25)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Film"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button3.Location = New System.Drawing.Point(372, 351)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 67)
        Me.Button3.TabIndex = 58
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(89, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 17)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Title:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(78, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Genre"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(64, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 17)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Sinopsis:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(61, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Duration:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 17)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Original Title:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(88, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 17)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Year:"
        '
        'insertarPeliculas
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
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBoxFotoPelicula)
        Me.Controls.Add(Me.TextBoxTitulo)
        Me.Controls.Add(Me.NumericUpDownAnno)
        Me.Controls.Add(Me.NumericUpDownDuracion)
        Me.Controls.Add(Me.ComboBoxGeneros)
        Me.Controls.Add(Me.TextBoxSinopsis)
        Me.Controls.Add(Me.TextBoxTituloOriginal)
        Me.Name = "insertarPeliculas"
        Me.Text = "Insert Films"
        CType(Me.NumericUpDownAnno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxFotoPelicula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxTitulo As TextBox
    Friend WithEvents NumericUpDownAnno As NumericUpDown
    Friend WithEvents NumericUpDownDuracion As NumericUpDown
    Friend WithEvents ComboBoxGeneros As ComboBox
    Friend WithEvents TextBoxSinopsis As RichTextBox
    Friend WithEvents TextBoxTituloOriginal As TextBox
    Friend WithEvents PictureBoxFotoPelicula As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
