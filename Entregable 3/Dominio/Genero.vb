Public Class Genero
    Private mIdGenero As Integer
    Private mDescGenero As String
    Private mListaGeneros As Collection
    Private GestorGeneros As gestorGeneros

    Sub New()
        GestorGeneros = New gestorGeneros()
    End Sub

    Public Sub New(mIdGenero As Integer, mDescGenero As String)
        Me.mIdGenero = mIdGenero
        Me.mDescGenero = mDescGenero

        GestorGeneros = New gestorGeneros()
    End Sub

    Sub leerGenero(IdGenero As Integer)
        GestorGeneros.leerGenero(IdGenero, Me)
    End Sub

    Sub leerDescGenero(DescGenero As String)
        GestorGeneros.leerDescGenero(DescGenero, Me)
    End Sub

    Function leerTodos()
        Dim Generos As Collection
        GestorGeneros.leerTodo()
        Generos = GestorGeneros.listaGeneros
        Return Generos
    End Function

    Sub actualizarPeliGenero(modPelicula As Pelicula, modGenero As Genero)
        GestorGeneros.updatePeliGen(modPelicula, modGenero)
    End Sub

    Sub insertarPeliGenero(modPelicula As Pelicula, modGenero As Genero)
        GestorGeneros.insertarPeliGen(modPelicula, modGenero)
    End Sub

    Sub actualizarGenero(modGenero As Genero)
        GestorGeneros.updateGen(modGenero)
    End Sub

    Sub annadirGen(ByVal nuevoGen As Genero)
        GestorGeneros.annadirGenero(nuevoGen)
    End Sub

    Sub eliminarGen(ByVal eliminarGenero As Genero)
        GestorGeneros.eliminarGenero(eliminarGenero)
    End Sub
    Public Property IdGenero As Integer
        Get
            Return mIdGenero
        End Get
        Set(value As Integer)
            mIdGenero = value
        End Set
    End Property

    Public Property DescGenero As String
        Get
            Return mDescGenero
        End Get
        Set(value As String)
            mDescGenero = value
        End Set
    End Property

    Public Property ListaGeneros As Collection
        Get
            Return mListaGeneros
        End Get
        Set(value As Collection)
            mListaGeneros = value
        End Set
    End Property
End Class
