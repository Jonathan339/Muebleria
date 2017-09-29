Public Class Cliente

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)

    End Sub

    Private Sub Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.MuebleriaDataSet.Cliente)

        Me.ClienteBindingSource.AddNew()






    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'boton agregar y modificar

        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)
        Me.ClienteTableAdapter.Fill(Me.MuebleriaDataSet.Cliente)
        Me.ClienteBindingSource.MoveLast()
        'Me.ClienteBindingSource.AddNew()

        FechaIngresoDateTimePicker.Text = FechaIngresoDateTimePicker.Text

    End Sub

    Private Sub Id_ClienteTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_ClienteTextBox.TextChanged

    End Sub
End Class