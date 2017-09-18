Imports System.Data.SqlClient

Module Module1
    'Public formulario As Form

    Dim sqlConnection1 As New SqlConnection("Your Connection String")
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader

    cmd.CommandText = "SELECT * FROM Customers"
    cmd.CommandType = CommandType.Text
    cmd.Connection = sqlConnection1





    Public Sub limpiar(ByRef f As Form, ByRef control As Control)
        If f.Controls.ContainsKey(control.Name) Then
            If (TypeOf control Is TextBox) Then
                control.Text = " "
            End If
        End If
    End Sub

    Public Sub validacion_eliminar(ByRef e)
        Dim aux As Integer
        If Not IsNumeric(e.KeyChar) Then
            aux = ("¿Desea eliminar este registristro?" & 32 + 1 & "Eliminar")

        End If
    End Sub

End Module
