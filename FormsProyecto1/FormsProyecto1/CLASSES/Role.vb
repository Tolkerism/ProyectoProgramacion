Public Class Role
    'Attributes of the class
    Private roleId As Integer
    Private roleName As String
    Private roleDescription As String
   


    Public Property role_Id() As Integer
        Get
            Return roleId
        End Get
        Set(ByVal value As Integer)
            roleId = value
        End Set
    End Property


    Public Property role_Name() As String
        Get
            Return roleName
        End Get
        Set(ByVal value As String)
            roleName = value
        End Set
    End Property

    Public Property role_Description() As String
        Get
            Return roleDescription
        End Get
        Set(ByVal value As String)
            roleDescription = value
        End Set
    End Property
End Class
