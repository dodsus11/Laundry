Imports Ninject.Modules
Imports DbLibs
Namespace engine
    Public Class PISModule
        Inherits NinjectModule

        Public Overrides Sub Load()
            Bind(Of dao.CustomerDao).ToSelf().InSingletonScope()
        End Sub
    End Class

End Namespace


