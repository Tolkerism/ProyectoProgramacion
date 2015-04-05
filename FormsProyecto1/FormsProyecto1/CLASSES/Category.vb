Public Class Category
    Private active As Integer
    Private id As Integer
    Private name As String

    Public Property getName() As String
        Get
            Return Name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property


    Public Property getId() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Public Property getActive() As Integer
        Get
            Return active
        End Get
        Set(ByVal value As Integer)
            active = value
        End Set
    End Property


End Class
