Public Class User
    Private usuario As String
    Private idUsuario As Integer
    Private idPersona As Integer
    Private tipo As Integer

    Public Sub New(ByVal idUsuario As Integer, ByVal idPersona As Integer, ByVal tipo As Integer)
        Me.usuario = ""
        Me.idUsuario = idUsuario
        Me.idPersona = idPersona
        Me.tipo = tipo
    End Sub

    Public Sub New(ByVal usuario As String, ByVal idPersona As Integer, ByVal tipo As Integer)
        Me.usuario = usuario
        Me.idUsuario = idUsuario
        Me.idPersona = idPersona
        Me.tipo = tipo
    End Sub

    Public Sub New(ByVal usuario As String, ByVal values As ArrayList)
        Me.usuario = usuario
        Me.idUsuario = values.Item(0)
        Me.idPersona = values.Item(1)
        Me.tipo = values.Item(2)
    End Sub

    Public Property User() As String
        Get
            Return Me.usuario
        End Get
        Set(ByVal Value As String)
            Me.usuario = Value
        End Set
    End Property

    Public Property idUser() As String
        Get
            Return Me.idUsuario
        End Get
        Set(ByVal Value As String)
            Me.idUsuario = Value
        End Set
    End Property

    Public Property personaId() As String
        Get
            Return Me.idPersona
        End Get
        Set(ByVal Value As String)
            Me.idPersona = Value
        End Set
    End Property

    Public Property tipoUsuario() As String
        Get
            Return Me.tipo
        End Get
        Set(ByVal Value As String)
            Me.tipo = Value
        End Set
    End Property
End Class
