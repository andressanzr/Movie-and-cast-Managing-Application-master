Public Class gestionarPersonas
    Sub Inicializar()
        Dim per As New Persona()
        Dim listaPersonas As New Collection
        listaPersonas = per.leerTodas()
        ListBoxActores.Items.Clear()
        Dim t = 1
        While t <= listaPersonas.Count
            ListBoxActores.Items.Add(listaPersonas.Item(t).Nombre + " " + listaPersonas.Item(t).Apellido)
            t = t + 1
        End While
    End Sub
    Private Sub ListBoxActores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxActores.SelectedIndexChanged
        Dim per As New Persona()
        Dim seleccionado As String = ListBoxActores.SelectedItem
        Dim nombreSeleccionado As String = seleccionado.Substring(0, seleccionado.IndexOf(" "))
        Dim apellidoSeleccionado As String = seleccionado.Substring(seleccionado.IndexOf(" ") + 1)
        per.leerNombreApePersona(nombreSeleccionado, apellidoSeleccionado)
        TextBoxNombre.Text = per.Nombre
        TextBoxApellido.Text = per.Apellido
        TextBoxNacionalidad.Text = per.Nacionalidad
        DateTimePickerFechaNacimiento.Value = per.FechaNacimiento
        TextBoxCiudadNacimiento.Text = per.CiudadNacimiento
        TextBoxPaisNacimiento.Text = per.PaisNacimiento

        Try
            If (per.RutaFoto.StartsWith("C")) Then
                FotoActor.Image = Image.FromFile(per.RutaFoto)
            Else
                FotoActor.Image = Image.FromFile(Application.StartupPath + per.RutaFoto)
            End If
        Catch ee As Exception
            MessageBox.Show("Foto no encontrada")
            MessageBox.Show(ControlChars.CrLf + ee.Message)
            MessageBox.Show(Application.StartupPath)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim per As New Persona()
        Dim seleccionado As String = ListBoxActores.SelectedItem
        Dim nombreSeleccionado As String = seleccionado.Substring(0, seleccionado.IndexOf(" "))
        Dim apellidoSeleccionado As String = seleccionado.Substring(seleccionado.IndexOf(" ") + 1)
        per.leerNombreApePersona(nombreSeleccionado, apellidoSeleccionado)
        per.Nombre = TextBoxNombre.Text
        per.Apellido = TextBoxApellido.Text
        per.Nacionalidad = TextBoxNacionalidad.Text
        per.FechaNacimiento = DateTimePickerFechaNacimiento.Value
        per.CiudadNacimiento = TextBoxCiudadNacimiento.Text
        per.PaisNacimiento = TextBoxPaisNacimiento.Text
        per.RutaFoto = fileName
        per.modificar()
    End Sub

    Private Sub gestionarPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Inicializar()
    End Sub
    Dim fileName As String = vbNull
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OpenfileDialog As New OpenFileDialog

        Dim imagen As String
        OpenfileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        OpenfileDialog.Filter = "Archivos (*.JPG)|*.jpg"
        If (OpenfileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            fileName = OpenfileDialog.FileName
            imagen = fileName

        End If
        Try
            FotoActor.Image = New Bitmap(imagen)
        Catch ex As ArgumentNullException

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBoxActores.SelectedItem IsNot Nothing Then
            modificarRelacionesPersonas.Show()
        Else
            MessageBox.Show("Debes seleccionar un actor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListBoxActores.SelectedItem IsNot Nothing Then
            Dim per As New Persona()
            Dim seleccionado As String = ListBoxActores.SelectedItem
            Dim nombreSeleccionado As String = seleccionado.Substring(0, seleccionado.IndexOf(" "))
            Dim apellidoSeleccionado As String = seleccionado.Substring(seleccionado.IndexOf(" ") + 1)
            per.leerNombreApePersona(nombreSeleccionado, apellidoSeleccionado)
            per.eliminarPersona(per)
        End If
    End Sub
End Class