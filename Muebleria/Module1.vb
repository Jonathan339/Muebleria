Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlServerCe

Module Module1

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
            aux = ("¿Desea eliminar este registristro?" & 1 + 32 & "Eliminar")

        End If
    End Sub




    Public Sub stock(ByVal articulo As String, ByVal actual As String, ByVal minimo As String)
        If (Int(actual) < Int(minimo)) Then
            MsgBox("Necesita ordenar mas stock de " & articulo)
        End If

    End Sub



End Module
