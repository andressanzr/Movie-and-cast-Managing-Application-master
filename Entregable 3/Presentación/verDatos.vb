Public Class verDatos

    Private Sub ListBoxPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPeliculas.SelectedIndexChanged
        PictureBoxFotoPelicula.Image = Image.FromFile("fondo.jpg")
        ListBoxRolesActores.Items.Clear()
        'Imprimir peliculas'
        Dim pel As New Pelicula()
        pel.leerTitulo(ListBoxPeliculas.SelectedItem)
        TextBoxAnno.Text = pel.AnnoEstreno
        TextBoxDuracion.Text = pel.Duracion
        TextBoxTituloOriginal.Text = pel.TituloOriginal
        TextBoxSinopsis.Text = pel.Sinopsis
        Try
            PictureBoxFotoPelicula.Image = Image.FromFile(Application.StartupPath + pel.RutaFoto)
            'Imprimir actores peliculas'
            Dim p As Integer = 1
            pel.leerPersonas()
            ListBoxActoresPelicula.Items.Clear()
            While p <= pel.Personas.Count
                Dim person = New Persona()
                person.leerPersona(pel.Personas.Item(p).IdPersona)
                ListBoxActoresPelicula.Items.Add(person.Nombre + " " + person.Apellido)
                p = p + 1
            End While
        Catch ex As IO.FileNotFoundException
            Console.WriteLine("Fichero no encontrado")
        End Try
        'Imprimir Genero'
        ListBoxGeneros.Items.Clear()
        Dim gen As New Genero()
        pel.leerGenero()
        Dim y As Integer = 1

        While y <= pel.Generos.Count
            gen.leerGenero(pel.Generos.Item(y).IdGenero)
            ListBoxGeneros.Items.Add(gen.DescGenero)
            y = y + 1
        End While
    End Sub


    Private Sub ListBoxActoresPelicula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxActoresPelicula.SelectedIndexChanged

        Dim Pers As New Persona()
        Dim rol As New Rol()
        Dim pel As New Pelicula()
        Dim listaRoles As Collection
        Dim seleccionado As String = ListBoxActoresPelicula.SelectedItem
        Dim nombreSeleccionado As String = seleccionado.Substring(0, seleccionado.IndexOf(" "))
        Dim apellidoSeleccionado As String = seleccionado.Substring(seleccionado.IndexOf(" ") + 1)
        Pers.leerNombreApePersona(nombreSeleccionado, apellidoSeleccionado)
        pel.leerTitulo(ListBoxPeliculas.SelectedItem)
        listaRoles = pel.leerRoles(Pers)

        ListBoxRolesActores.Items.Clear()
        Dim t As Integer = 1
        While t <= listaRoles.Count
            rol.leerRol(listaRoles.Item(t).IdRol)
            ListBoxRolesActores.Items.Add(rol.DescRol)
            t = t + 1
        End While

    End Sub


    Private Sub verDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Sub Inicializar()
        Dim pel As New Pelicula
        Dim listaPeliculas As Collection
        Dim i As Integer = 1
        listaPeliculas = pel.leerTodos()
        While i <= listaPeliculas.Count
            ListBoxPeliculas.Items.Add(listaPeliculas.Item(i).Titulo)
            i = i + 1
        End While
    End Sub


End Class