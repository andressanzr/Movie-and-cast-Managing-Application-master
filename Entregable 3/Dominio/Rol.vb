Public Class Rol
    Private mIdRol As Integer
    Private mDescRol As String
    Private gestorRoles As gestorRoles

    Sub New()
        gestorRoles = New gestorRoles()

    End Sub
    Public Sub New(mIdRol As Integer, mDescRol As String)
        Me.mIdRol = mIdRol
        Me.mDescRol = mDescRol

        gestorRoles = New gestorRoles()
    End Sub
    Sub annadirRol()
        gestorRoles.annadir(Me)
    End Sub
    Sub actualizarRol()
        gestorRoles.update(Me)
    End Sub

    Sub leerRol(IdRol As Integer)
        gestorRoles.leerRol(IdRol, Me)
    End Sub

    Sub leerDescRol(DescRol As String)
        gestorRoles.leerDescRol(DescRol, Me)
    End Sub
    Sub eliminarRol()
        gestorRoles.eliminar(Me)
    End Sub
    Function leerTodos()
        Dim listaRoles As Collection
        gestorRoles.leerTodos()
        listaRoles = gestorRoles.listaRoles
        Return listaRoles
    End Function

    Public Property IdRol As Integer
        Get
            Return mIdRol
        End Get
        Set(value As Integer)
            mIdRol = value
        End Set
    End Property

    Public Property DescRol As String
        Get
            Return mDescRol
        End Get
        Set(value As String)
            mDescRol = value
        End Set
    End Property


End Class
