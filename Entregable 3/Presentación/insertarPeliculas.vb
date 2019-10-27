Public Class insertarPeliculas
    Private Sub insertarPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Anno As New Date()
        Anno = DateTime.Today()
        NumericUpDownAnno.Maximum = Anno.Year
        Dim genTodos As New Genero()
        Dim listaGeneros As New Collection()
        listaGeneros = genTodos.leerTodos()
        Dim t = 1
        ComboBoxGeneros.Items.Clear()
        While listaGeneros.Count > t
            ComboBoxGeneros.Items.Add(listaGeneros.Item(t).DescGenero)
            t = t + 1
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBoxTitulo.Text IsNot Nothing Then
            Dim pel As New Pelicula()
            Dim gen As New Genero()
            pel.Titulo = TextBoxTitulo.Text
            pel.TituloOriginal = TextBoxTituloOriginal.Text
            pel.AnnoEstreno = Int(NumericUpDownAnno.Value)
            pel.Duracion = Int(NumericUpDownDuracion.Value)
            pel.Sinopsis = TextBoxSinopsis.Text
            pel.RutaFoto = routePic
            pel.insertarPelicula()

            'Leer IdPelicula'
            Dim pelicula As New Pelicula()
            pelicula.leerTitulo(pel.Titulo)
            gen.leerDescGenero(ComboBoxGeneros.SelectedItem)
            gen.insertarPeliGenero(pelicula, gen)
            MessageBox.Show("Pelicula añadida correctamente")
            limpiarCampos()
        Else
            MessageBox.Show("Introduzca el titulo de la pelicula")
        End If
    End Sub
    Sub limpiarCampos()
        TextBoxTitulo.Clear()
        TextBoxTituloOriginal.Clear()
        NumericUpDownAnno.Value = 0
        NumericUpDownDuracion.Value = 0
        TextBoxSinopsis.Clear()
        PictureBoxFotoPelicula.Image = Image.FromFile("fondo.jpg")
    End Sub
    Dim filename As String = ""
    Dim routePic As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenfileDialog As New OpenFileDialog

        Dim imagen As String
        OpenfileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        OpenfileDialog.Filter = "Archivos (*.JPG)|*.jpg"
        If (OpenfileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            fileName = OpenfileDialog.FileName
            imagen = fileName

        End If
        Try
            PictureBoxFotoPelicula.Image = New Bitmap(imagen)
            Dim fileNameExtension As String = filename.Substring(filename.LastIndexOf("\") + 1)
            routePic = "/fotosCaratula/" + fileNameExtension
            FileCopy(filename, Application.StartupPath + "/fotosCaratula/" + fileNameExtension)
        Catch ex As ArgumentNullException

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiarCampos()
    End Sub
End Class