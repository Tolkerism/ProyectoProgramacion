Public Class Project


    Private id As Integer
    Private name As String
    Private budget As Integer
    Private time As Date


    Public Property getName() As String
        Get
            Return Name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property

    Public Property getBudget() As Integer
        Get
            Return budget
        End Get
        Set(ByVal value As Integer)
            budget = value
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
