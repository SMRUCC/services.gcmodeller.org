﻿Imports Microsoft.VisualBasic.CommandLine.Reflection
Imports SMRUCC.WebCloud.HTTPInternal.AppEngine
Imports SMRUCC.WebCloud.HTTPInternal.AppEngine.APIMethods
Imports SMRUCC.WebCloud.HTTPInternal.AppEngine.APIMethods.Arguments
Imports SMRUCC.WebCloud.HTTPInternal.Platform

<[Namespace]("Application")> Public Class BiostackApp : Inherits WebApp

    Public Sub New(main As PlatformEngine)
        MyBase.New(main)
    End Sub

    <ExportAPI("/Application/tools/COG_myva.vbs")>
    <POST(GetType(String))>
    Public Function COGMyva(request As HttpPOSTRequest, response As HttpResponse) As Boolean

    End Function
End Class