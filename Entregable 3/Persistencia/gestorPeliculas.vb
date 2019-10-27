Imports System.Data.OleDb

Public Class gestorPeliculas

    Private mlistaPeliculas As Collection
    Private mlistaGeneros As Collection
    Private mlistaPersonas As Collection
    Private mlistaRoles As Collection
    Private Agente As AgenteBD

    Public Property listaPeliculas As Collection
        Get
            Return mlistaPeliculas
        End Get
        Set(value As Collection)
            mlistaPeliculas = value
        End Set
    End Property

    Public Property listaGeneros As Collection
        Get
            Return mlistaGeneros
        End Get
        Set(value As Collection)
            mlistaGeneros = value
        End Set
    End Property

    Public Property listaPersonas As Collection
        Get
            Return mlistaPersonas
        End Get
        Set(value As Collection)
            mlistaPersonas = value
        End Set
    End Property

    Public Property listaRoles As Collection
        Get
            Return mlistaRoles
        End Get
        Set(value As Collection)
            mlistaRoles = value
        End Set
    End Property

    Sub New()
        listaPeliculas = New Collection
        listaGeneros = New Collection
        listaPersonas = New Collection
        listaRoles = New Collection
    End Sub


    Public Sub leerTodo()
        Me.Agente = AgenteBD.getInstancia()
        Dim reader As OleDbDataReader

        Dim sSql As String = "SELECT * FROM PELICULAS ORDER BY Titulo"
        reader = Me.Agente.read(sSql)
        While reader.Read()
            Me.listaPeliculas.Add(New Pelicula(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5), reader.GetString(6)))
        End While
    End Sub

    Sub leerPelicula(ByVal IdPelicula As Integer, ByRef Pelicula As Pelicula)
        Me.Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "SELECT * FROM Peliculas WHERE IdPelicula=" + IdPelicula.ToString + ""
        Dim reader As OleDbDataReader
        reader = Me.Agente.read(sSQL)
        If reader.HasRows Then
            reader.Read()
            Pelicula.IdPelicula = reader(0)
            Pelicula.Titulo = reader(1)
            Pelicula.TituloOriginal = reader(2)
            Pelicula.AnnoEstreno = reader(3)
            Pelicula.Duracion = reader(4)
            Pelicula.Sinopsis = reader(5)
            Pelicula.RutaFoto = reader(6)
        End If
    End Sub

    Sub leerTitulo(ByVal Titulo As String, ByRef pel As Pelicula)
        Me.Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "SELECT * FROM PELICULAS WHERE Titulo='" + Titulo + "'"
        Dim reader As OleDbDataReader
        reader = Me.Agente.read(sSQL)
        If reader.HasRows Then
            reader.Read()
            pel.IdPelicula = reader(0)
            pel.Titulo = reader(1)
            pel.TituloOriginal = reader(2)
            pel.AnnoEstreno = reader(3)
            pel.Duracion = reader(4)
            pel.Sinopsis = reader(5)
            pel.RutaFoto = reader(6)
        End If
    End Sub

    Sub leerGenero(ByVal pel As Pelicula)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT * FROM Peli_Gen WHERE Pelicula=" + pel.IdPelicula.ToString + "")
        While reader.Read()
            Me.listaGeneros.Add(New Genero(reader.GetInt32(1), vbNull))
        End While
    End Sub

    Sub leerPersonas(ByVal pel As Pelicula)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT DISTINCT Persona FROM Participa WHERE Pelicula= " + pel.IdPelicula.ToString + "")
        While reader.Read()
            Me.listaPersonas.Add(New Persona(reader.GetInt32(0), vbNull, vbNull, vbNull, Nothing, vbNull, vbNull, vbNull))
        End While
    End Sub

    Sub leerPeliculasParticipa(ByVal per As Persona)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT DISTINCT Rol FROM Participa WHERE Persona= " + per.IdPersona.ToString + "")
        Dim listaPeliculas As New Collection
        While reader.Read()
            Me.listaPeliculas.Add(New Pelicula(reader.GetInt32(0), vbNull, vbNull, vbNull, vbNull, vbNull, vbNull))
        End While
    End Sub
    ' Leer el Genero de la Pelicula escogida '
    Sub leerRoles(ByVal pel As Pelicula, ByVal per As Persona)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT * FROM Participa WHERE Pelicula= " + pel.IdPelicula.ToString + " AND Persona= " + per.IdPersona.ToString + "")
        While reader.Read()
            Me.listaRoles.Add(New Rol(reader.GetInt32(2), vbNull))
        End While
    End Sub

    ' Inserta una Pelicula en la base de datos '
    Sub insert(ByVal newPelicula As Pelicula)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Peliculas(Titulo, TituloOriginal, AñoEstreno, Duracion, Sinopsis, RutaCartelPelicula) VALUES ('" + newPelicula.Titulo + "', '" + newPelicula.TituloOriginal + "', '" & newPelicula.AnnoEstreno & "', " + newPelicula.Duracion.ToString + ", '" + newPelicula.Sinopsis + "', '" + newPelicula.RutaFoto + "')"

        Agente.create(sSQL)
    End Sub

    ' Modifica la Pelicula escogida por su IdPelicula de la base de datos '
    Sub update(ByVal modPelicula As Pelicula)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "UPDATE Peliculas SET Titulo= '" + modPelicula.Titulo + "',TituloOriginal= '" + modPelicula.TituloOriginal + "', AñoEstreno=" + modPelicula.Duracion.ToString + ",Duracion=" + modPelicula.Duracion.ToString + ",Sinopsis= '" + modPelicula.Sinopsis + "',RutaCartelPelicula= '" + modPelicula.RutaFoto + "' WHERE IdPelicula=" + modPelicula.IdPelicula.ToString() + ""
        Agente.update(sSQL)
    End Sub

    ' Borra la Pelicula escogida de la base de datos '
    Sub delete(ByVal noPelicula As Pelicula)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Peliculas WHERE IdPelicula=" + noPelicula.IdPelicula.ToString + ""
        Agente.delete(sSQL)
    End Sub

    ' Borra todas las Peliculas de la base de datos '
    Sub deleteAll()
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM Peliculas"
        Dim sSQL2 As String = "DELETE * FROM Participa"
        Dim sSQL3 As String = "DELETE * FROM Peli_Gen"
        Agente.delete(sSQL3)
        Agente.delete(sSQL2)
        Agente.delete(sSQL)
    End Sub

    ' Borra la tupla de la tabla Peli_Gen de la base de datos '
    Sub deleteGen(ByVal noPelicula As Pelicula)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Peli_Gen WHERE Pelicula=" + noPelicula.IdPelicula.ToString + ""
        Agente.delete(sSQL)
    End Sub

    ' Borra todas las Peliculas de la base de datos '
    Sub deleteAllPelGen()
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM Peli_Gen"
        Agente.delete(sSQL)
    End Sub

    ' Borra la tupla de la tabla Participa de la base de datos '
    Sub deletePar(ByVal noPelicula As Pelicula)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Participa WHERE Pelicula=" + noPelicula.IdPelicula.ToString + ""
        Agente.delete(sSQL)
    End Sub

    ' Borra todas las Peliculas de la base de datos '
    Sub deleteAllPar()
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM Participa"
        Agente.delete(sSQL)
    End Sub

    ' Inserta Genero escogida en la tabla Peli_Gen de la base de datos '
    Sub insertGen(ByVal newPelicula As Pelicula, ByVal newGenero As Genero)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Peli_gen VALUES (" + newPelicula.IdPelicula.ToString + ", " + newGenero.IdGenero.ToString + ")"
        Agente.create(sSQL)
    End Sub

    ' Borra el Genero escogida en la tabla Peli_Gen de la base de datos '
    Sub deleteGen(ByVal noPelicula As Pelicula, ByVal noGenero As Genero)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Peli_gen WHERE Pelicula=" + noPelicula.IdPelicula.ToString + " AND Genero=" + noGenero.IdGenero.ToString + ""
        Agente.delete(sSQL)
    End Sub

    ' Inserta Persona y Rol escogida en la tabla Participa de la base de datos '
    Sub insertPerRol(ByVal newPelicula As Pelicula, ByVal newPersona As Persona, ByVal newRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Participa VALUES (" + newPersona.IdPersona.ToString + ", " + newPelicula.IdPelicula.ToString + "," + newRol.IdRol.ToString + ")"
        Agente.create(sSQL)
    End Sub

    ' Borra Persona y Rol escogida en la tabla Participa de la base de datos '
    Sub deletePerRol(ByVal noPelicula As Pelicula, ByVal noPersona As Persona, ByVal noRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Participa WHERE Persona=" + noPersona.IdPersona.ToString + " AND Pelicula=" + noPelicula.IdPelicula.ToString + " AND Rol=" + noRol.IdRol.ToString + ""
        Agente.delete(sSQL)
    End Sub
End Class
