Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        verDatos.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ButtonVerActores_Click(sender As Object, e As EventArgs) Handles ButtonVerActores.Click
        verActores.Show()
    End Sub

    Private Sub ButtonGestionarPersonas_Click(sender As Object, e As EventArgs) Handles ButtonGestionarPersonas.Click
        gestionarPersonas.Show()
    End Sub

    Private Sub ButtonPeliculas_Click(sender As Object, e As EventArgs) Handles ButtonPeliculas.Click
        gestionarPeliculas.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        insertarActores.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        gestionarGeneros.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        insertarPeliculas.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        gestionarRoles.Show()
    End Sub

End Class
