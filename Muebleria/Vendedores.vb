Public Class Vendedores

    Private Sub EmpleadoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)

    End Sub

    Private Sub Vendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.MuebleriaDataSet.Empleado)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'boton agregar y modificar

        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)
        Me.EmpleadoTableAdapter.Fill(Me.MuebleriaDataSet.Empleado)
        Me.EmpleadoBindingSource.MoveLast()
        Me.EmpleadoBindingSource.AddNew()


    End Sub

    Private Sub Id_EmpleadoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_EmpleadoTextBox.TextChanged



    End Sub

    Private Sub NombreTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTextBox.KeyPress

        'VALIDACION LETRAS
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten letras")
        End If

    End Sub

    

    Private Sub PuestoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PuestoTextBox.KeyPress

        'VALIDACION LETRAS
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten letras")
        End If

    End Sub

    Private Sub SectorTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SectorTextBox.KeyPress

        'VALIDACION LETRAS
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten letras")
        End If

    End Sub

    Private Sub ApellidoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ApellidoTextBox.KeyPress
        'VALIDACION LETRAS
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten letras")
        End If
    End Sub
End Class