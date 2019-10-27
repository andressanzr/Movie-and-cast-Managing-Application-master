Public Class modificarRelacionesPersonas
    Sub Inicializar()
        'leer todas peliculas'
        ListBoxPeliculas.Items.Clear()
        Dim pel As New Pelicula
        Dim listaPeliculas As Collection
        Dim i As Integer = 1
        listaPeliculas = pel.leerTodos()
        While i <= listaPeliculas.Count
            ListBoxPeliculas.Items.Add(listaPeliculas.Item(i).Titulo)
            i = i + 1
        End While
        'leer todos roles'
        ListBoxRoles.Items.Clear()
        Dim rol As New Rol
        Dim listaRoles As New Collection
        listaRoles = rol.leerTodos()
        Dim p = 1
        While p <= listaRoles.Count
            rol.leerRol(listaRoles.Item(p).IdRol)
            ListBoxRoles.Items.Add(rol.DescRol)
            p = p + 1
        End While

        'leer peliculas del actor'
        Try
            ListBoxPeliculasAñadidas.Items.Clear()
            Dim pel2 As New Pelicula
            Dim perSelect As New Persona
            Dim listaPel As New Collection
            Dim seleccionado As String = gestionarPersonas.ListBoxActores.SelectedItem
            Dim nombreSeleccionado As String = seleccionado.Substring(0, seleccionado.IndexOf(" "))
            Dim apellidoSeleccionado As String = seleccionado.Substring(seleccionado.IndexOf(" ") + 1)
            perSelect.leerNombreApePersona(nombreSeleccionado, apellidoSeleccionado)
            listaPel = perSelect.leerPeliculasPersona(perSelect)
            Dim a = 1
            While a <= listaPel.Count
                pel2.leerPelicula(listaPel.Item(a).IdPelicula)
                ListBoxPeliculasAñadidas.Items.Add(pel2.Titulo)
                a = a + 1
            End While
        Catch ex As ArgumentNullException
            Console.Write("Actor sin peliculas")
        End Try

    End Sub
    Private Sub ModificarRelacionesPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles ButtonAñadir.Click
        If ListBoxPeliculas.SelectedItem IsNot Nothing And ListBoxRoles.SelectedItem IsNot Nothing Then
            Dim newPel As New Pelicula
            Dim newPer As New Persona
            Dim newRol As New Rol
            newPel.leerTitulo(ListBoxPeliculas.SelectedItem)
            Dim seleccionado As String = gestionarPersonas.ListBoxActores.SelectedItem
            Dim nombreSeleccionado As String = seleccionado.Substring(0, seleccionado.IndexOf(" "))
            Dim apellidoSeleccionado As String = seleccionado.Substring(seleccionado.IndexOf(" ") + 1)

            newPer.leerNombreApePersona(nombreSeleccionado, apellidoSeleccionado)

            newRol.leerDescRol(ListBoxRoles.SelectedItem)

            newPer.insertarPelRol(newPel, newPer, newRol)
        Else
            MessageBox.Show("Debes seleccionar una pelicula y un rol")
        End If
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        Inicializar()
    End Sub

    Private Sub ListBoxPeliculasAñadidas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPeliculasAñadidas.SelectedIndexChanged
        'leer roles del actor'
        If ListBoxPeliculasAñadidas.SelectedItem IsNot Nothing Then
            ListBoxRolesAñadidos.Items.Clear()
            Dim perSelect As New Persona
            Dim pel As New Pelicula
            Dim rol As New Rol
            Dim listaRoles As New Collection
            Dim seleccionado As String = gestionarPersonas.ListBoxActores.SelectedItem
            Dim nombreSeleccionado As String = seleccionado.Substring(0, seleccionado.IndexOf(" "))
            Dim apellidoSeleccionado As String = seleccionado.Substring(seleccionado.IndexOf(" ") + 1)
            perSelect.leerNombreApePersona(nombreSeleccionado, apellidoSeleccionado)

            pel.leerTitulo(ListBoxPeliculasAñadidas.SelectedItem)
            listaRoles = pel.leerRoles(perSelect)
            Dim a As Integer = 1
            While a <= listaRoles.Count
                rol.leerRol(listaRoles.Item(a).IdRol)
                ListBoxRolesAñadidos.Items.Add(rol.DescRol)
                a = a + 1
            End While
        End If
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If ListBoxPeliculasAñadidas.SelectedItem IsNot Nothing And ListBoxRolesAñadidos.SelectedItem IsNot Nothing Then
            Dim newPel As New Pelicula
            Dim newPer As New Persona
            Dim newRol As New Rol
            newPel.leerTitulo(ListBoxPeliculas.SelectedItem)
            Dim seleccionado As String = gestionarPersonas.ListBoxActores.SelectedItem
            Dim nombreSeleccionado As String = seleccionado.Substring(0, seleccionado.IndexOf(" "))
            Dim apellidoSeleccionado As String = seleccionado.Substring(seleccionado.IndexOf(" ") + 1)

            newPer.leerNombreApePersona(nombreSeleccionado, apellidoSeleccionado)

            newRol.leerDescRol(ListBoxRoles.SelectedItem)

            newPer.eliminarPelRol(newPel, newPer, newRol)
        Else
            MessageBox.Show("Debes seleccionar una pelicula y un rol")
        End If
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        ListBoxPeliculas.ClearSelected()
        ListBoxPeliculasAñadidas.ClearSelected()
        ListBoxRoles.ClearSelected()
        ListBoxRolesAñadidos.ClearSelected()
    End Sub
End Class