Imports System.Data.OleDb

Public Class verActores
    Private Sub verActores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim per As New Persona()
        Dim listaPersonas As New Collection
        listaPersonas = per.leerTodas()

        Dim t = 1
        While t <= listaPersonas.Count
            ListBoxActores.Items.Add(listaPersonas.Item(t).Nombre + " " + listaPersonas.Item(t).Apellido)
            t = t + 1
        End While

    End Sub

    Private Sub ListBoxActores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxActores.SelectedIndexChanged
        ListBoxPeliculasActor.Items.Clear()
        FotoActor.Image = Image.FromFile("fondo.jpg")
        Dim per As New Persona()
        Dim seleccionado As String = ListBoxActores.SelectedItem
        Dim nombreSeleccionado As String = seleccionado.Substring(0, seleccionado.IndexOf(" "))
        Dim apellidoSeleccionado As String = seleccionado.Substring(seleccionado.IndexOf(" ") + 1)
        per.leerNombreApePersona(nombreSeleccionado, apellidoSeleccionado)
        TextBoxNombre.Text = per.Nombre
        TextBoxApellido.Text = per.Apellido
        TextBoxNacionalidad.Text = per.Nacionalidad
        TextBoxFechaNacimiento.Text = per.FechaNacimiento
        TextBoxCiudadNacimiento.Text = per.CiudadNacimiento
        TextBoxPaisNacimiento.Text = per.PaisNacimiento
        Try
            If (per.RutaFoto.StartsWith("C")) Then
                FotoActor.Image = Image.FromFile(per.RutaFoto)
            Else
                FotoActor.Image = Image.FromFile(Application.StartupPath + per.RutaFoto)
            End If
        Catch ee As Exception
            MessageBox.Show(ControlChars.CrLf + ee.Message)
            MessageBox.Show(Application.StartupPath)
        End Try

        'Leer peliculas de cada actor'
        Dim pel As New Pelicula()

        Dim p = 1
        Dim listaPeliculas As New Collection

        pel.leerPeliculasParticipa(per)
        listaPeliculas = pel.Peliculas
        Try
            While p <= listaPeliculas.Count
                Dim pelicula = New Pelicula()
                pelicula.leerPelicula(listaPeliculas.Item(p).IdPelicula)
                ListBoxPeliculasActor.Items.Add(pelicula.Titulo)
                p = p + 1
            End While

        Catch e1 As System.ArgumentNullException
            Console.WriteLine("Actor sin peliculas")
        End Try
    End Sub


End Class