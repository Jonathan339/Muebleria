Public Class Ventas

    Private Sub VentasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.MuebleriaDataSet.Ventas)


        Id_ArticuloTextBox.Text = ""
        Id_VentasTextBox.Text = ""
        Id_clienteTextBox.Text = ""

    End Sub

    Private Sub Id_VentasTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Id_VentasTextBox.KeyPress

        If Asc(Chr(13)) Then
            Dim vista As New DataView
            vista.Table = Me.MuebleriaDataSet.Ventas
            vista.RowFilter = "Id_Ventas = " & Val(Id_VentasTextBox.Text)
            Me.VentasDataGridView.DataSource = vista

        End If


    End Sub


    Private Sub Id_ArticuloTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Id_ArticuloTextBox.KeyPress

        If Asc(Chr(13)) Then
            Dim vista As New DataView
            vista.Table = Me.MuebleriaDataSet.Articulo
            vista.RowFilter = "Id_Articulo = " & Val(Id_ArticuloTextBox.Text)
            Me.VentasDataGridView.DataSource = vista
        End If


    End Sub

    Private Sub Id_clienteTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Id_clienteTextBox.KeyPress

        If Asc(Chr(13)) Then
            Dim vista As New DataView
            vista.Table = Me.MuebleriaDataSet.Ventas
            vista.RowFilter = "Id_cliente = " & Val(Id_clienteTextBox.Text)
            Me.VentasDataGridView.DataSource = vista

        End If

    End Sub
End Class