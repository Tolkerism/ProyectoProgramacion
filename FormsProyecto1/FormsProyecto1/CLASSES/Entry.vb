Public Class Entry


    Private id As Integer
    Private name As String
    Private description As String
    Private hour As Integer
    Private category As String
    Private time As Date


    Public Property getId() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property


    Public Property getCategory() As String
        Get
            Return category
        End Get
        Set(ByVal value As String)
            category = value
        End Set
    End Property

    Public Property getHours() As String
        Get
            Return hour
        End Get
        Set(ByVal value As String)
            hour = value
        End Set
    End Property
    Public Property getName() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property

    Public Property getDescription() As String
        Get
            Return description
        End Get
        Set(ByVal value As String)
            description = value
        End Set
    End Property


    Public Property getDate() As Date
        Get
            Return time
        End Get
        Set(ByVal value As Date)
            time = value
        End Set
    End Property


End Class
