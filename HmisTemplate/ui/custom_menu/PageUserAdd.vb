Imports Ninject

Public Class PageUserAdd

    Private userDao As dao.UserDao

    Public Sub New(ByVal userDao As dao.UserDao)

        Me.userDao = userDao

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

End Class
