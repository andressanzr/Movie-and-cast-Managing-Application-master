Imports System.Data.OleDb

Public Class gestorRoles
    Dim mlistaRoles As Collection
    Private Agente As AgenteBD

    Public Property listaRoles As Collection
        Get
            Return mlistaRoles
        End Get
        Set(value As Collection)
            mlistaRoles = value
        End Set
    End Property
    Sub New()
        listaRoles = New Collection
    End Sub

    Sub update(ByRef modRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "UPDATE Roles SET DescRol= '" + modRol.DescRol + "' WHERE IdRol=" + modRol.IdRol.ToString + ""
        Agente.update(sSQL)
    End Sub

    Sub annadir(ByRef modRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Roles(DescRol) VALUES('" + modRol.DescRol + "')"
        Agente.create(sSQL)
    End Sub

    Sub eliminar(ByRef modRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Roles WHERE IdRol=" + modRol.IdRol.ToString + ""
        Agente.delete(sSQL)
    End Sub
    Sub leerDescRol(ByVal DescRol As String, ByRef Rol As Rol)
        Me.Agente = AgenteBD.getInstancia()
        Dim sSql As String = "SELECT * FROM Roles WHERE DescRol='" + DescRol + "'"
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read(sSql)

        If reader.HasRows Then
            reader.Read()
            Rol.IdRol = reader(0)
            Rol.DescRol = reader(1)
        End If
    End Sub
    Sub leerRol(ByVal IdRol As Integer, ByRef Rol As Rol)
        Me.Agente = AgenteBD.getInstancia()
        Dim sSql As String = "SELECT * FROM Roles WHERE IdRol=" + IdRol.ToString() + ""
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read(sSql)

        If reader.HasRows Then
            reader.Read()
            Rol.IdRol = reader(0)
            Rol.DescRol = reader(1)
        End If
    End Sub
    Sub leerTodos()
        Me.Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "SELECT * FROM Roles ORDER BY DescRol"
        Dim reader As OleDbDataReader = AgenteBD.getInstancia.read(sSQL)
        While reader.Read()
            Me.listaRoles.Add(New Rol(reader.GetInt32(0), reader.GetString(1)))
        End While
    End Sub
End Class
