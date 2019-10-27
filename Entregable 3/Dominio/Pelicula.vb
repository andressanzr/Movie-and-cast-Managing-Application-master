Imports Entregable_3

Public Class Pelicula
    Private mIdPelicula As Integer
    Private mTitulo As String
    Private mTituloOriginal As String
    Private mAnnoEstreno As Integer
    Private mDuracion As Integer
    Private mSinopsis As String
    Private mRutaFoto As String
    Private mRoles As Collection
    Private mPersonas As Collection
    Private mGeneros As Collection
    Private mPeliculas As Collection
    Private GestorPeliculas As gestorPeliculas

    Sub New()
        GestorPeliculas = New gestorPeliculas()
    End Sub

    Public Sub New(mIdPelicula As Integer, mTitulo As String, mTituloOriginal As String, mAnnoEstreno As Integer, mDuracion As Integer, mSinopsis As String, mRutaFoto As String)
        Me.mIdPelicula = mIdPelicula
        Me.mTitulo = mTitulo
        Me.mTituloOriginal = mTituloOriginal
        Me.mAnnoEstreno = mAnnoEstreno
        Me.mDuracion = mDuracion
        Me.mSinopsis = mSinopsis
        Me.mRutaFoto = mRutaFoto
        Me.mRoles = mRoles
        Me.mPersonas = mPersonas
        Me.mGeneros = mGeneros
        Me.mPeliculas = mPeliculas

        GestorPeliculas = New gestorPeliculas()
    End Sub

    Public Function leerTodos()
        Dim todos As Collection
        Me.GestorPeliculas.leerTodo()
        todos = GestorPeliculas.listaPeliculas
        Return todos
    End Function

    Public Sub leerPelicula(ByVal IdPelicula As Integer)
        GestorPeliculas.leerPelicula(IdPelicula, Me)
    End Sub

    Sub leerTitulo(ByVal Titulo As String)
        GestorPeliculas.leerTitulo(Titulo, Me)
    End Sub

    Sub leerPeliculasParticipa(ByVal per As Persona)
        GestorPeliculas.leerPeliculasParticipa(per)
        Peliculas = GestorPeliculas.listaPeliculas
    End Sub
    Sub leerGenero()
        GestorPeliculas.leerGenero(Me)
        Generos = GestorPeliculas.listaGeneros
    End Sub

    Sub leerPersonas()
        GestorPeliculas.leerPersonas(Me)
        Personas = GestorPeliculas.listaPersonas
    End Sub

    Function leerRoles(ByVal per As Persona)
        GestorPeliculas.leerRoles(Me, per)
        Roles = GestorPeliculas.listaRoles
        Return Roles
    End Function

    Sub insertarPelicula()
        Me.GestorPeliculas.insert(Me)
    End Sub

    Sub modificarPelicula()
        Me.GestorPeliculas.update(Me)
    End Sub

    Sub eliminarPelicula()
        Me.GestorPeliculas.delete(Me)
    End Sub

    Sub eliminarTodo()
        Me.GestorPeliculas.deleteAll()
    End Sub

    Sub eliminarGenero()
        Me.GestorPeliculas.deleteGen(Me)
    End Sub

    Sub elminarTodoGen()
        Me.GestorPeliculas.deleteAllPelGen()
    End Sub

    Sub eliminarParti()
        Me.GestorPeliculas.deletePar(Me)
    End Sub

    Sub eliminarTodoParti()
        Me.GestorPeliculas.deleteAllPar()
    End Sub

    Sub insertarGenero(ByVal gen As Genero)
        Me.GestorPeliculas.insertGen(Me, gen)
    End Sub

    Sub eliminarGenero(ByVal gen As Genero)
        Me.GestorPeliculas.deleteGen(Me, gen)
    End Sub

    Sub insertarPersonaRol(ByVal per As Persona, ByVal rol As Rol)
        Me.GestorPeliculas.insertPerRol(Me, per, rol)
    End Sub

    Sub eliminarPersonaRol(ByVal per As Persona, ByVal ro As Rol)
        Me.GestorPeliculas.deletePerRol(Me, per, ro)
    End Sub

    Public Property IdPelicula As Integer
        Get
            Return mIdPelicula
        End Get
        Set(value As Integer)
            mIdPelicula = value
        End Set
    End Property

    Public Property Titulo As String
        Get
            Return mTitulo
        End Get
        Set(value As String)
            mTitulo = value
        End Set
    End Property

    Public Property TituloOriginal As String
        Get
            Return mTituloOriginal
        End Get
        Set(value As String)
            mTituloOriginal = value
        End Set
    End Property

    Public Property AnnoEstreno As Integer
        Get
            Return mAnnoEstreno
        End Get
        Set(value As Integer)
            mAnnoEstreno = value
        End Set
    End Property

    Public Property Duracion As Integer
        Get
            Return mDuracion
        End Get
        Set(value As Integer)
            mDuracion = value
        End Set
    End Property

    Public Property Sinopsis As String
        Get
            Return mSinopsis
        End Get
        Set(value As String)
            mSinopsis = value
        End Set
    End Property

    Public Property RutaFoto As String
        Get
            Return mRutaFoto
        End Get
        Set(value As String)
            mRutaFoto = value
        End Set
    End Property

    Public Property Roles As Collection
        Get
            Return mRoles
        End Get
        Set(value As Collection)
            mRoles = value
        End Set
    End Property

    Public Property Personas As Collection
        Get
            Return mPersonas
        End Get
        Set(value As Collection)
            mPersonas = value
        End Set
    End Property

    Public Property Generos As Collection
        Get
            Return mGeneros
        End Get
        Set(value As Collection)
            mGeneros = value
        End Set
    End Property

    Public Property Peliculas As Collection
        Get
            Return mPeliculas
        End Get
        Set(value As Collection)
            mPeliculas = value
        End Set
    End Property
End Class
