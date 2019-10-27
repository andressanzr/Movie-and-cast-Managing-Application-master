Imports System.Data.OleDb

Public Class gestorGeneros
    Private Agente As AgenteBD
    Private mlistaGeneros As Collection

    Public Property listaGeneros As Collection
        Get
            Return mlistaGeneros
        End Get
        Set(value As Collection)
            mlistaGeneros = value
        End Set
    End Property
    Sub New()
        listaGeneros = New Collection
    End Sub
    Sub leerTodo()
        Me.Agente = AgenteBD.getInstancia()
        Dim reader As OleDbDataReader

        Dim sSQL As String = "SELECT * FROM GENEROS"
        reader = Me.Agente.read(sSQL)
        While reader.Read()
            Me.listaGeneros.Add(New Genero(reader.GetInt32(0), reader.GetString(1)))
        End While
    End Sub

    Sub leerGenero(ByVal IdGenero As Integer, ByRef gen As Genero)
        Me.Agente = AgenteBD.getInstancia()
        Dim reader As OleDbDataReader

        Dim sSQL As String = "SELECT * FROM GENEROS WHERE IdGenero=" + IdGenero.ToString() + ""
        reader = Me.Agente.read(sSQL)
        If reader.HasRows Then
            reader.Read()
            gen.IdGenero = reader(0)
            gen.DescGenero = reader(1)
        End If
    End Sub
    Sub leerDescGenero(ByVal DescGenero As String, ByRef gen As Genero)
        Me.Agente = AgenteBD.getInstancia()
        Dim reader As OleDbDataReader

        Dim sSQL As String = "SELECT * FROM GENEROS WHERE DescGenero='" + DescGenero + "'"
        reader = Me.Agente.read(sSQL)
        If reader.HasRows Then
            reader.Read()
            gen.IdGenero = reader(0)
            gen.DescGenero = reader(1)
        End If
    End Sub
    Sub updateGen(ByVal modGen As Genero)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "UPDATE Generos SET DescGenero='" + modGen.DescGenero + "' WHERE IdGenero=" + modGen.IdGenero.ToString + ""
        Agente.update(sSQL)
    End Sub

    Sub updatePeliGen(ByVal modPelicula As Pelicula, ByVal modGenero As Genero)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "UPDATE Peli_gen SET Pelicula= '" + modPelicula.IdPelicula.ToString + "',Genero= '" + modGenero.IdGenero.ToString() + "' WHERE Pelicula=" + modPelicula.IdPelicula.ToString() + ""
        Agente.update(sSQL)
    End Sub
    Sub insertarPeliGen(ByVal modPelicula As Pelicula, ByVal modGenero As Genero)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Peli_gen(Pelicula,Genero) VALUES(" + modPelicula.IdPelicula.ToString + "," + modGenero.IdGenero.ToString + ""
        Agente.create(sSQL)
    End Sub

    Sub annadirGenero(ByVal modGenero As Genero)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Generos(DescGenero) VALUES('" + modGenero.DescGenero + "')"
        Agente.create(sSQL)
    End Sub

    Sub eliminarGenero(ByVal eliminarGenero As Genero)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Generos WHERE IdGenero=" + eliminarGenero.IdGenero.ToString + ""
        Dim sSQL2 As String = "DELETE FROM Peli_Gen WHERE Genero=" + eliminarGenero.IdGenero.ToString + ""
        Agente.delete(sSQL2)
        Agente.delete(sSQL)
    End Sub

End Class
