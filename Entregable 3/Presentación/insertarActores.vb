Public Class insertarActores
    Private Sub ButtonAñadirActor_Click(sender As Object, e As EventArgs) Handles ButtonAñadirActor.Click
        If TextBoxNombre.Text IsNot Nothing Then
            Dim per As New Persona()
            per.Nombre = TextBoxNombre.Text
            per.Apellido = TextBoxApellido.Text
            per.Nacionalidad = TextBoxNacionalidad.Text
            per.FechaNacimiento = DateTimePickerFechaNacimiento.Value
            per.CiudadNacimiento = TextBoxCiudadNacimiento.Text
            per.PaisNacimiento = TextBoxPaisNacimiento.Text
            per.RutaFoto = filename
            If (per.Nombre IsNot "") Then
                per.insertarPersona()
                MessageBox.Show("Actor añadido correctamente")
                limpiarCampos()
            End If
        Else
            MessageBox.Show("Introduzca el nombre del actor")
        End If
    End Sub
    Dim filename As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenfileDialog As New OpenFileDialog

        Dim imagen As String
        OpenfileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        OpenfileDialog.Filter = "Archivos (*.JPG)|*.jpg"
        If (OpenfileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            filename = OpenfileDialog.FileName
            imagen = filename

        End If
        Try
            PictureBoxFotoActor.Image = New Bitmap(imagen)
        Catch ex As ArgumentNullException

        End Try

    End Sub
    Sub limpiarCampos()
        TextBoxNombre.Clear()
        TextBoxApellido.Clear()
        TextBoxNacionalidad.Clear()
        DateTimePickerFechaNacimiento.Value = "01/01/1970"
        TextBoxCiudadNacimiento.Clear()
        TextBoxPaisNacimiento.Clear()
        PictureBoxFotoActor.Image = Image.FromFile("fondo.jpg")
    End Sub
    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        limpiarCampos()
    End Sub

    Private Sub insertarActores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBoxFotoActor.Image = Image.FromFile("fondo.jpg")
    End Sub
End Class