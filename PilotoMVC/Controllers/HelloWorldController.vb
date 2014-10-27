Imports System.Web.Mvc

Namespace Controllers
    Public Class HelloWorldController
        Inherits Controller

        ' GET: HelloWorld
        Function Index() As ActionResult
            Return View()
        End Function

        Function Welcome() As String
            Return "This is my <b>welcome</b> action..."
        End Function

    End Class
End Namespace