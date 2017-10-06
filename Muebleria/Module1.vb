Module Module1
    Public Sub limpiar(ByVal formx As Form) 'Procedimiento en el formulario al llamarla con la variable
        'Me le mandamos al procedimiento el formulario en el que
        'estamos parado y lo cargamos en la variable formx
        Dim Aux As Control

        For Each Aux In formx.Controls  'busco en el formulario todo los controles

            If TypeOf Aux Is TextBox Then  'consulto si el control es un texbox, si lo es lo limpio
                Aux.Text = ""
            End If

        Next
    End Sub
    Function solo_numeros(ByVal Tecla As System.Windows.Forms.KeyPressEventArgs) 'validacion solo se puede entrar numeros
        Dim tecla_presionada As Integer
        tecla_presionada = AscW(Tecla.KeyChar)
        If tecla_presionada >= 48 And tecla_presionada <= 57 Or tecla_presionada = 8 Or tecla_presionada = 13 Then
            solo_numeros = AscW(Tecla.KeyChar)
        Else
            solo_numeros = 0
        End If

        'ascii 8 se coloca para que podamos borrar con la tecla back space
        'ascii 13 es para que le permitamos al usuario presionar enter
        'si nesecitamos que el usario digite por ejemplo una "," abra que agregar el
        'codigo ascii "44" en la condicion
    End Function
    Function solo_letras(ByVal Tecla As System.Windows.Forms.KeyPressEventArgs) 'validacion para solo letras
        Dim tecla_presionada As Integer
        tecla_presionada = AscW(Tecla.KeyChar)

        If tecla_presionada >= 97 And tecla_presionada <= 122 Or tecla_presionada = 8 Or tecla_presionada = 13 Then
            solo_letras = AscW(Tecla.KeyChar)
        Else
            solo_letras = 0
        End If
        'minusculasa
        ' KeyAscii > 97 Or KeyAscii <122
        'mayusculas:
        ' KeyAscii > 65 Or KeyAscii < 90
        ' KeyAscii = 8 El ASCII que corresponde al 8 es el BackSpace
        ' ascii 13 es para que le permitamos al usuario presionar enter
    End Function
End Module
