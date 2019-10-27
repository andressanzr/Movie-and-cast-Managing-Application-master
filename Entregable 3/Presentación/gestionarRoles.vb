Public Class gestionarRoles
    Sub Inicializar()
        ListBoxRoles.Items.Clear()
        Dim rol As New Rol()
        Dim listaRoles As Collection
        listaRoles = rol.leerTodos()
        Dim i As Integer = 1
        While i <= listaRoles.Count
            ListBoxRoles.Items.Add(listaRoles.Item(i).DescRol)
            i = i + 1
        End While

    End Sub
    Private Sub ListBoxRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxRoles.SelectedIndexChanged
        TextBoxDescRol.Text = ListBoxRoles.SelectedItem
    End Sub

    Private Sub gestionarRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonActualizarDatos.Click
        Inicializar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If ListBoxRoles.SelectedItem IsNot "" Then
            Dim rol As New Rol
            rol.leerDescRol(ListBoxRoles.SelectedItem)
            rol.eliminarRol()
            TextBoxDescRol.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        If TextBoxDescRol.Text IsNot "" Then
            Dim rol As New Rol()
            rol.leerDescRol(ListBoxRoles.SelectedItem)
            rol.DescRol = TextBoxDescRol.Text
            rol.actualizarRol()
            TextBoxDescRol.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAnnadir.Click
        If TextBoxDescRol.Text IsNot "" Then
            Dim rol As New Rol()
            rol.DescRol = TextBoxDescRol.Text
            rol.annadirRol()
            TextBoxDescRol.Clear()
        End If
    End Sub
End Class