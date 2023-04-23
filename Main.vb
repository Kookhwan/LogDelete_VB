Imports Microsoft.VisualBasic

Public Class Class1

    Public Sub Main()
        If Process.GetProcessesByName("LogDelete").Count = 0 Then
            Application.Run(New frmMain())
        End If
    End Sub

End Class
