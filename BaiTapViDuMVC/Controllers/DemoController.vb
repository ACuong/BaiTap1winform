Imports System.Web.Mvc

Namespace Controllers
    Public Class DemoController
        Inherits Controller

        ' GET: Demo
        Function Index() As ActionResult
            Return View()
        End Function

        Function Hello() As ActionResult
            Return View()
        End Function
    End Class
End Namespace