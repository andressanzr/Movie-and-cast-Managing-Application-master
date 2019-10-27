Public Class gestionarGeneros
    Private Sub ListBoxGeneros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxGeneros.SelectedIndexChanged
        TextBoxDescGenero.Text = ListBoxGeneros.SelectedItem

    End Sub
    Sub Inicializar()
        ListBoxGeneros.Items.Clear()
        TextBoxDescGenero.Clear()
        Dim gen As New Genero()
        Dim listaGeneros As Collection = gen.leerTodos()

        Dim i As Integer = 1

        While i <= listaGeneros.Count
            ListBoxGeneros.Items.Add(listaGeneros.Item(i).DescGenero)
            i = i + 1
        End While

    End Sub
    Private Sub gestionarGeneros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonActualizarDatos.Click
        Inicializar()
    End Sub

    Function comprobarGeneroExistente(ByVal DescGenero As String, ByVal genTodos As Genero)
        DescGenero = TextBoxDescGenero.Text
        Dim listaGeneros As Collection = genTodos.leerTodos()
        Dim repetido As Boolean = False
        Dim p = 1
        While p < listaGeneros.Count
            If (listaGeneros.Item(p).DescGenero.Equals(DescGenero)) Then
                repetido = True
            End If
            p = p + 1
        End While
        Return repetido
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAñadir.Click
        Dim nuevoDescGen As String = TextBoxDescGenero.Text
        Dim nuevoGen As New Genero()
        Dim genTodos As New Genero()
        Dim listaGeneros As Collection = genTodos.leerTodos()
        Dim repetido As Boolean
        repetido = comprobarGeneroExistente(nuevoDescGen, genTodos)
        If (repetido.Equals(False)) Then
            nuevoGen.DescGenero = nuevoDescGen
            nuevoGen.annadirGen(nuevoGen)
        Else
            MessageBox.Show("Genero repetido")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonActualizarGenero.Click
        Dim nuevoDescGen As String = TextBoxDescGenero.Text
        Dim nuevoGen As New Genero()
        Dim genTodos As New Genero()
        Dim gen2 As New Genero()
        gen2.leerDescGenero(ListBoxGeneros.SelectedItem)
        Dim repetido As Boolean
        repetido = comprobarGeneroExistente(nuevoDescGen, genTodos)
        If (repetido.Equals(False)) Then
            nuevoGen.DescGenero = nuevoDescGen
            nuevoGen.IdGenero = gen2.IdGenero
            nuevoGen.actualizarGenero(nuevoGen)
        Else
            MessageBox.Show("Genero repetido")
        End If
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim genElim As New Genero()
        genElim.leerDescGenero(ListBoxGeneros.SelectedItem)
        genElim.eliminarGen(genElim)
        TextBoxDescGenero.Clear()

    End Sub
End Class