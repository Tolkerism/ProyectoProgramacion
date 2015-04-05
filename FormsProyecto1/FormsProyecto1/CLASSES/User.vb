Public Class User

    'Attributes of the class
    Private nameOfUser As String
    Private userId As Integer
    Private userLastname As String
    Private userName As String
    Private userPassword As String
    Private userStatus As Boolean
    Private userEntryDate As Date
    Private UserIdRole As Integer 'puede que esto tenga que ser otra clase como As idRole


    Public Property name_Of_User() As String
        Get
            Return nameOfUser
        End Get
        Set(ByVal value As String)
            nameOfUser = value
        End Set
    End Property


    Public Property user_Id() As Integer
        Get
            Return userId
        End Get
        Set(ByVal value As Integer)
            userId = value
        End Set
    End Property


    Public Property user_Lastname() As String
        Get
            Return userLastname
        End Get
        Set(ByVal value As String)
            userLastname = value
        End Set
    End Property


    Public Property user_Name() As String
        Get
            Return userName
        End Get
        Set(ByVal value As String)
            userName = value
        End Set
    End Property


    Public Property user_Password() As String
        Get
            Return userPassword
        End Get
        Set(ByVal value As String)
            userPassword = value
        End Set
    End Property


    Public Property user_Status() As Boolean
        Get
            Return userStatus
        End Get
        Set(ByVal value As Boolean)
            userStatus = value
        End Set
    End Property


    Public Property user_EntryDate() As Date
        Get
            Return userEntryDate
        End Get
        Set(ByVal value As Date)
            userEntryDate = value
        End Set
    End Property


    Public Property User_IdRole() As Integer
        Get
            Return UserIdRole
        End Get
        Set(ByVal value As Integer)
            UserIdRole = value
        End Set
    End Property
End Class

