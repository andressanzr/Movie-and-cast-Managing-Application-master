Public Class Persona
    Private mIdPersona As Integer
    Private mNombre As String
    Private mApellido As String
    Private mNacionalidad As String
    Private mFechaNacimiento As Date
    Private mCiudadNacimiento As String
    Private mPaisNacimiento As String
    Private mRutaFoto As String

    Private GestorPersonas As gestorPersonas

    Sub New()
        GestorPersonas = New gestorPersonas()
    End Sub

    Function leerTodas()
        GestorPersonas.leerTodas()
        Return GestorPersonas.listaPersonas
    End Function

    Sub modificar()
        Me.gestorPersonas.update(Me)

    End Sub
    Public Sub insertarPersona()
        GestorPersonas.insert(Me)
    End Sub
    Public Sub New(mIdPersona As Integer, mNombre As String, mApellido As String, mNacionalidad As String, mFechaNacimiento As Date, mCiudadNacimiento As String, mPaisNacimiento As String, mRutaFoto As String)
        Me.mIdPersona = mIdPersona
        Me.mNombre = mNombre
        Me.mApellido = mApellido
        Me.mNacionalidad = mNacionalidad
        Me.mFechaNacimiento = mFechaNacimiento
        Me.mCiudadNacimiento = mCiudadNacimiento
        Me.mPaisNacimiento = PaisNacimiento
        Me.mRutaFoto = RutaFoto

        GestorPersonas = New gestorPersonas()
    End Sub

    Sub leerPersona(ByVal IdPersona As Integer)
        GestorPersonas.leerPersona(IdPersona, Me)
    End Sub

    Sub leerNombreApePersona(ByVal Nombre As String, ByVal Apellido As String)
        GestorPersonas.leerNombreApellidoPersona(Nombre, Apellido, Me)
    End Sub

    Function leerPeliculasPersona(ByVal per As Persona)
        GestorPersonas.leerPeliculas(Me)
        Return GestorPersonas.listaPeliculas
    End Function

    Sub insertarPelRol(ByVal newPel As Pelicula, ByVal newPer As Persona, ByVal newRol As Rol)
        GestorPersonas.insertPelRol(newPel, Me, newRol)
    End Sub

    Sub eliminarPelRol(ByVal newPel As Pelicula, ByVal newPer As Persona, ByVal newRol As Rol)
        GestorPersonas.eliminarPelRol(newPel, Me, newRol)
    End Sub

    Sub eliminarPersona(ByVal per As Persona)
        GestorPersonas.eliminarPersona(per)
    End Sub
    Public Property IdPersona As Integer
        Get
            Return mIdPersona
        End Get
        Set(value As Integer)
            mIdPersona = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return mNombre
        End Get
        Set(value As String)
            mNombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return mApellido
        End Get
        Set(value As String)
            mApellido = value
        End Set
    End Property

    Public Property Nacionalidad As String
        Get
            Return mNacionalidad
        End Get
        Set(value As String)
            mNacionalidad = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return mFechaNacimiento
        End Get
        Set(value As Date)
            mFechaNacimiento = value
        End Set
    End Property

    Public Property CiudadNacimiento As String
        Get
            Return mCiudadNacimiento
        End Get
        Set(value As String)
            mCiudadNacimiento = value
        End Set
    End Property

    Public Property PaisNacimiento As String
        Get
            Return mPaisNacimiento
        End Get
        Set(value As String)
            mPaisNacimiento = value
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
End Class
