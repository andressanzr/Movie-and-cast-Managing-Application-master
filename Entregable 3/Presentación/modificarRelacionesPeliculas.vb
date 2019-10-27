Public Class modificarRelacionesPeliculas

    Sub Inicializar()
        'cargar todos los datos'
        'personas'
        Dim per As New Persona()
        Dim listaPersonas As New Collection
        listaPersonas = per.leerTodas()
        ListBoxPersonas.Items.Clear()
        Dim t = 1
        While t <= listaPersonas.Count
            ListBoxPersonas.Items.Add(listaPersonas.Item(t).Nombre + " " + listaPersonas.Item(t).Apellido)
            t = t + 1
        End While
        'roles'
        ListBoxRoles.Items.Clear()
        Dim rol As New Rol()
        Dim listaRoles As Collection
        listaRoles = rol.leerTodos()
        Dim i As Integer = 1
        While i <= listaRoles.Count
            ListBoxRoles.Items.Add(listaRoles.Item(i).DescRol)
            i = i + 1
        End While
        'generos'
        ListBoxGeneros.Items.Clear()
        Dim gen As New Genero()
        Dim listaGeneros As Collection = gen.leerTodos()

        Dim y As Integer = 1

        While y <= listaGeneros.Count
            ListBoxGeneros.Items.Add(listaGeneros.Item(y).DescGenero)
            y = y + 1
        End While
        'cargar datos pelicula'
        'genero'
        Dim pelSelec As New Pelicula()
        Dim genPelSelect As New Genero()
        pelSelec.leerTitulo(gestionarPeliculas.ListBoxPeliculas.SelectedItem)
        pelSelec.leerGenero()

        Dim p As Integer = 1
        While p <= pelSelec.Generos.Count
            genPelSelect.leerGenero(pelSelec.Generos.Item(p).IdGenero)
            ListBoxGenerosAñadidas.Items.Add(genPelSelect.DescGenero)
            p = p + 1
        End While

        'personas'
        pelSelec.leerPersonas()
        Dim a As Integer = 1
        While a <= pelSelec.Personas.Count
            per.leerPersona(pelSelec.Personas.Item(a).IdPersona)
            ListBoxPersonasAñadidas.Items.Add(per.Nombre + " " + per.Apellido)
            a = a + 1
        End While
    End Sub
    Private Sub ModificarRelacionesPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Private Sub ListBoxPersonasAñadidas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPersonasAñadidas.SelectedIndexChanged
        If ListBoxPersonasAñadidas.SelectedItem IsNot Nothing Then
            ListBoxRolesAñadidos.Items.Clear()
            Dim per As New Persona()
            Dim pelSelec As New Pelicula()
            Dim roles As New Collection
            Dim rol As New Rol()
            Dim seleccionado As String = ListBoxPersonasAñadidas.SelectedItem
            Dim nombreSeleccionado As String = seleccionado.Substring(0, seleccionado.IndexOf(" "))
            Dim apellidoSeleccionado As String = seleccionado.Substring(seleccionado.IndexOf(" ") + 1)
            per.leerNombreApePersona(nombreSeleccionado, apellidoSeleccionado)
            pelSelec.leerTitulo(gestionarPeliculas.ListBoxPeliculas.SelectedItem)
            roles = pelSelec.leerRoles(per)

            Dim m As Integer = 1
            While m <= roles.Count
                rol.leerRol(roles.Item(m).IdRol)
                ListBoxRolesAñadidos.Items.Add(rol.DescRol)
                m = m + 1
            End While
        End If
    End Sub

    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles ButtonAñadir.Click
        If ListBoxPersonas.SelectedItem IsNot Nothing And ListBoxRoles.SelectedItem IsNot Nothing Then
            Dim newPelicula As New Pelicula
            Dim newPersona As New Persona
            Dim newRol As New Rol
            Dim seleccionado As String = ListBoxPersonas.SelectedItem
            Dim nombreSeleccionado As String = seleccionado.Substring(0, seleccionado.IndexOf(" "))
            Dim apellidoSeleccionado As String = seleccionado.Substring(seleccionado.IndexOf(" ") + 1)
            newPersona.leerNombreApePersona(nombreSeleccionado, apellidoSeleccionado)
            newPelicula.leerTitulo(gestionarPeliculas.ListBoxPeliculas.SelectedItem)
            newRol.leerDescRol(ListBoxRoles.SelectedItem)
            newPelicula.insertarPersonaRol(newPersona, newRol)
        ElseIf ListBoxGeneros.SelectedItem Is Nothing Then
            MessageBox.Show("No ha seleccionado ninguna Persona y Rol a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If ListBoxGeneros.SelectedItem IsNot Nothing Then
            Dim newPelicula As New Pelicula
            Dim newGenero As New Genero
            newGenero.leerDescGenero(ListBoxGeneros.SelectedItem)
            newPelicula.leerTitulo(gestionarPeliculas.ListBoxPeliculas.SelectedItem)
            newPelicula.insertarGenero(newGenero)
        ElseIf ListBoxPersonas.SelectedItem Is Nothing And ListBoxRoles.SelectedItem Is Nothing Then
            MessageBox.Show("No ha seleccionado ningun Genero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ListBoxPersonasAñadidas.Items.Clear()
        ListBoxPersonas.Items.Clear()
        ListBoxRoles.Items.Clear()
        ListBoxGeneros.Items.Clear()
        ListBoxRolesAñadidos.Items.Clear()
        ListBoxGenerosAñadidas.Items.Clear()
        Inicializar()
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If ListBoxPersonas.SelectedItem() IsNot Nothing And ListBoxRoles.SelectedItem IsNot Nothing Then
            Dim messageText As String = ("¿Estás seguro de querer eliminar la relacion con " + ListBoxPersonas.SelectedItem().ToString + " y " + ListBoxRoles.SelectedItem().ToString + " de la lista?")
            Dim responseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim popupCaption As String = "Advertencia"
            Dim popupResult As DialogResult
            popupResult = MessageBox.Show(messageText, popupCaption, responseButtons, MessageBoxIcon.Information)
            If popupResult = System.Windows.Forms.DialogResult.Yes Then
                Dim newPelicula As New Pelicula
                Dim newPersona As New Persona
                Dim newRol As New Rol
                Dim seleccionado As String = ListBoxPersonasAñadidas.SelectedItem
                Dim nombreSeleccionado As String = seleccionado.Substring(0, seleccionado.IndexOf(" "))
                Dim apellidoSeleccionado As String = seleccionado.Substring(seleccionado.IndexOf(" ") + 1)
                newPersona.leerNombreApePersona(nombreSeleccionado, apellidoSeleccionado)
                newPelicula.leerTitulo(gestionarPeliculas.ListBoxPeliculas.SelectedItem)
                newRol.leerDescRol(ListBoxRoles.SelectedItem)
                newPelicula.eliminarPersonaRol(newPersona, newRol)
            End If
        ElseIf ListBoxPersonas.SelectedItem Is Nothing And ListBoxRoles.SelectedItem IsNot Nothing Then
            MessageBox.Show("No ha seleccionado ninguna Persona y Rol a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If ListBoxGeneros.SelectedItem() IsNot Nothing Then
            Dim messageText As String = ("¿Estás seguro de querer eliminar la relacion con " + ListBoxGeneros.SelectedItem().ToString + " de la lista?")
            Dim responseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim popupCaption As String = "Advertencia"
            Dim popupResult As DialogResult
            popupResult = MessageBox.Show(messageText, popupCaption, responseButtons, MessageBoxIcon.Information)
            If popupResult = System.Windows.Forms.DialogResult.Yes Then
                Dim newPelicula As New Pelicula
                Dim newGenero As New Genero
                newPelicula.leerTitulo(gestionarPeliculas.ListBoxPeliculas.SelectedItem)
                newGenero.leerDescGenero(ListBoxGeneros.SelectedItem)
                newPelicula.eliminarGenero(newGenero)
            End If
        ElseIf ListBoxPersonas.SelectedItem Is Nothing And ListBoxRoles.SelectedItem Is Nothing Then
            MessageBox.Show("No ha seleccionado ningun Genero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ListBoxPersonasAñadidas.Items.Clear()
        ListBoxPersonas.Items.Clear()
        ListBoxRoles.Items.Clear()
        ListBoxGeneros.Items.Clear()
        ListBoxRolesAñadidos.Items.Clear()
        ListBoxGenerosAñadidas.Items.Clear()
        Inicializar()

    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        ListBoxGeneros.ClearSelected()
        ListBoxPersonas.ClearSelected()
        ListBoxRoles.ClearSelected()
        ListBoxGenerosAñadidas.ClearSelected()
        ListBoxRolesAñadidos.Items.Clear()
        ListBoxPersonasAñadidas.ClearSelected()
    End Sub
End Class