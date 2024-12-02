Imports Ninject.Modules
Imports DbLibs


Namespace engine

    Public Class KernelModule
        Inherits NinjectModule

        Public Overrides Sub load()
            Bind(Of DbLibs.ClsDbase).ToSelf().InSingletonScope()
        End Sub

    End Class


End Namespace


