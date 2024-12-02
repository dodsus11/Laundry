Imports Ninject


Namespace engine


    Public Class ClsKernel

        Private Shared kernel As IKernel

        Public Shared Function createKernel() As IKernel

            If kernel Is Nothing Then
                kernel = New StandardKernel(New KernelModule(), New PISModule())
            End If

            Return kernel

        End Function


    End Class

End Namespace


