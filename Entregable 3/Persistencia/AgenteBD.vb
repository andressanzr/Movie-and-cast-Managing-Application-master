Imports System.Data.OleDb

Public Class AgenteBD

    Private Shared CadConexion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../../BBDD_Videoclub.accdb“
    Private Shared mConexion As OleDb.OleDbConnection
    Private Shared instancia As AgenteBD = Nothing

    Public Sub New()
        AgenteBD.mConexion = New OleDbConnection
        AgenteBD.mConexion.ConnectionString = CadConexion
        Try
            AgenteBD.mConexion.Open()
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos" & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source())
        End Try
    End Sub
    Public Shared Function getInstancia() As AgenteBD
        If instancia Is Nothing Then
            instancia = New AgenteBD()
        End If
        Return instancia
    End Function
    Public Function read(ByVal sql As String) As OleDbDataReader
        Dim com As New OleDbCommand()
        com.CommandText = sql
        com.Connection = mConexion
        Return com.ExecuteReader()
    End Function
    Public Function create(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, mConexion)
        Try
            Return com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source())
            Return 0
        End Try
    End Function
    Public Function delete(ByVal sql As String)
        Dim com As New OleDbCommand(sql, mConexion)
        Try
            Return com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source())
            Return 0
        End Try
    End Function
    Public Function update(ByVal sql As String)
        Dim com As New OleDbCommand(sql, mConexion)
        Try
            Return com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source)
            Return 0
        End Try
    End Function
End Class
