Public Class gestionarPeliculas
    Private Sub gestionarPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
    Sub Inicializar()
        ListBoxPeliculas.Items.Clear()
        Dim pel As New Pelicula
        Dim listaPeliculas As Collection
        Dim i As Integer = 1
        listaPeliculas = pel.leerTodos()
        While i <= listaPeliculas.Count
            ListBoxPeliculas.Items.Add(listaPeliculas.Item(i).Titulo)
            i = i + 1
        End While
        Dim Anno As New Date()
        Anno = DateTime.Today()
        NumericUpDownAnno.Maximum = Anno.Year
    End Sub
    Private Sub ListBoxPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPeliculas.SelectedIndexChanged
        PictureBoxFotoPelicula.Image = Image.FromFile("fondo.jpg")
        'Imprimir peliculas'
        Dim pel As New Pelicula()
        pel.leerTitulo(ListBoxPeliculas.SelectedItem)
        NumericUpDownAnno.Value = pel.AnnoEstreno
        NumericUpDownDuracion.Value = pel.Duracion
        TextBoxTitulo.Text = pel.Titulo
        TextBoxTituloOriginal.Text = pel.TituloOriginal
        TextBoxSinopsis.Text = pel.Sinopsis
        Try
            If (pel.RutaFoto.StartsWith("C")) Then
                PictureBoxFotoPelicula.Image = Image.FromFile(pel.RutaFoto)
            Else
                PictureBoxFotoPelicula.Image = Image.FromFile(Application.StartupPath + pel.RutaFoto)
            End If

        Catch ex As IO.FileNotFoundException
            Console.WriteLine("Fichero no encontrado")
        End Try
        'Imprimir Genero'
        Try
            Dim gen As New Genero()
            pel.leerGenero()

            gen.leerGenero(pel.Generos.Item(1).IdGenero)

            Dim genTodos As New Genero()
            Dim listaGeneros As New Collection()
            listaGeneros = genTodos.leerTodos()
            Dim t = 1

            ComboBoxGeneros.Items.Clear()
            While listaGeneros.Count > t
                ComboBoxGeneros.Items.Add(listaGeneros.Item(t).DescGenero)
                t = t + 1
            End While
            ComboBoxGeneros.SelectedItem = gen.DescGenero
        Catch ex As IndexOutOfRangeException

        End Try
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim pel As New Pelicula()
        Dim gen As New Genero()
        pel.leerTitulo(ListBoxPeliculas.SelectedItem)
        pel.TituloOriginal = TextBoxTituloOriginal.Text
        pel.Titulo = TextBoxTitulo.Text
        pel.AnnoEstreno = Int(NumericUpDownAnno.Value)
        pel.Duracion = Int(NumericUpDownDuracion.Value)
        pel.Sinopsis = TextBoxSinopsis.Text
        pel.RutaFoto = routePic
        gen.leerDescGenero(ComboBoxGeneros.SelectedItem)
        gen.actualizarPeliGenero(pel, gen)
        pel.modificarPelicula()
    End Sub
    Dim fileName As String
    Dim routePic As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenfileDialog As New OpenFileDialog

        Dim imagen As String
        OpenfileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        OpenfileDialog.Filter = "Archivos (*.JPG)|*.jpg"
        If (OpenfileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            fileName = OpenfileDialog.FileName
            imagen = fileName
            Dim fileNameExtension As String = fileName.Substring(fileName.LastIndexOf("\") + 1)
            routePic = "/fotosCaratula/" + fileNameExtension
            FileCopy(fileName, Application.StartupPath + "/fotosCaratula/" + fileNameExtension)

        End If
        Try
            PictureBoxFotoPelicula.Image = New Bitmap(imagen)
        Catch ex As ArgumentNullException

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Inicializar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pel As New Pelicula()
        Dim gen As New Genero()
        pel.leerTitulo(ListBoxPeliculas.SelectedItem)
        pel.eliminarPelicula()
        pel.eliminarParti()
        pel.eliminarGenero()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBoxPeliculas.SelectedItem IsNot Nothing Then
            modificarRelacionesPeliculas.Show()
        Else
            MessageBox.Show("Debes seleccionar una película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class