Imports System.Data.OleDb


Public Class gestorPersonas

    Private mlistaPeliculas As Collection
    Private mlistaGeneros As Collection
    Private mlistaRoles As Collection
    Private mlistaPersonas As Collection

    Private Agente As AgenteBD

    Sub New()
        listaPeliculas = New Collection
        listaGeneros = New Collection
        listaPersonas = New Collection
        listaRoles = New Collection
    End Sub
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

    Public Property listaRoles As Collection
        Get
            Return mlistaRoles
        End Get
        Set(value As Collection)
            mlistaRoles = value
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

    Public Sub leerTodas()
        Me.Agente = AgenteBD.getInstancia()
        Dim li As Collection

        Dim reader As OleDbDataReader
        Dim per As New Persona()

        Dim sSql As String = "SELECT * FROM Personas ORDER BY Apellido"
        reader = Me.Agente.read(sSql)
        While reader.Read()
            Me.listaPersonas.Add(New Persona(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)))
        End While
    End Sub

    Sub leerPersona(ByVal IdPersona As Integer, ByRef Person As Persona)
        Me.Agente = AgenteBD.getInstancia()
        Dim sSql As String = "SELECT * FROM Personas WHERE IdPersona=" + IdPersona.ToString() + ""
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read(sSql)
        If reader.HasRows Then
            reader.Read()
            Person.IdPersona = reader(0)
            Person.Nombre = reader(1)
            Person.Apellido = reader(2)
            Person.Nacionalidad = reader(3)
            Person.FechaNacimiento = reader(4)
            Person.CiudadNacimiento = reader(5)
            Person.PaisNacimiento = reader(6)
            Person.RutaFoto = reader(7)
        End If
    End Sub

    Sub leerNombreApellidoPersona(ByVal Nombre As String, ByVal Apellido As String, ByRef Person As Persona)
        Me.Agente = AgenteBD.getInstancia()
        Dim sSql As String = "SELECT * FROM Personas WHERE Nombre='" + Nombre + "' AND Apellido='" + Apellido + "'" + ""
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read(sSql)

        If reader.HasRows Then
            reader.Read()
            Person.IdPersona = reader(0)
            Person.Nombre = reader(1)
            Person.Apellido = reader(2)
            Person.Nacionalidad = reader(3)
            Person.FechaNacimiento = reader(4)
            Person.CiudadNacimiento = reader(5)
            Person.PaisNacimiento = reader(6)
            Person.RutaFoto = reader(7)
        End If
    End Sub
    Sub update(ByVal modPersona As Persona)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "UPDATE Personas SET Nombre= '" + modPersona.Nombre + "',Apellido= '" + modPersona.Apellido + "',Nacionalidad='" + modPersona.Nacionalidad + "' ,FechaNacimiento= " + modPersona.FechaNacimiento.ToShortDateString + ",PaisNacimiento= '" + modPersona.PaisNacimiento + "',RutaFotoPersona= '" + modPersona.RutaFoto + "' WHERE IdPersona=" + modPersona.IdPersona.ToString + ""
        Agente.update(sSQL)
    End Sub
    Sub leerPeliculas(ByVal per As Persona)
        Me.Agente = AgenteBD.getInstancia()
        Dim reader As OleDbDataReader

        Dim sSql As String = "SELECT * FROM Participa WHERE Persona=" + per.IdPersona.ToString + ""
        reader = Me.Agente.read(sSql)
        While reader.Read()
            Me.listaPeliculas.Add(New Pelicula(reader.GetInt32(1), vbNull, vbNull, vbNull, vbNull, vbNull, vbNull))
        End While
    End Sub
    Sub insert(ByVal newPersona As Persona)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Personas(Nombre, Apellido, Nacionalidad, FechaNacimiento, CiudadNacimiento, PaisNacimiento, RutaFotoPersona) VALUES ('" + newPersona.Nombre + "', '" + newPersona.Apellido + "', '" + newPersona.Nacionalidad + "', '" & newPersona.FechaNacimiento & "', '" + newPersona.CiudadNacimiento + "', '" + newPersona.PaisNacimiento + "', '" + newPersona.RutaFoto + "')"
        Agente.create(sSQL)
    End Sub
    Sub insertPelRol(ByVal newPelicula As Pelicula, ByVal newPersona As Persona, ByVal newRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Participa VALUES (" + newPersona.IdPersona.ToString + ", " + newPelicula.IdPelicula.ToString + "," + newRol.IdRol.ToString + ")"
        Agente.create(sSQL)
    End Sub
    Sub eliminarPelRol(ByVal newPelicula As Pelicula, ByVal newPersona As Persona, ByVal newRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Participa WHERE Persona=" + newPersona.IdPersona.ToString + " AND Pelicula=" + newPelicula.IdPelicula.ToString + " AND Rol=" + newRol.IdRol.ToString + ""
        Agente.delete(sSQL)
    End Sub
    Sub eliminarPersona(ByVal per As Persona)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Personas WHERE IdPersona=" + per.IdPersona.ToString + ""
        Agente.delete(sSQL)
    End Sub
End Class
