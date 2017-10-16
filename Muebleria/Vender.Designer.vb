<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vender
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Id_ArticuloLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim Stock_MinimoLabel As System.Windows.Forms.Label
        Dim Id_VentasLabel As System.Windows.Forms.Label
        Dim Id_ArticuloLabel1 As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Id_clienteLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Id_ArticuloTextBox = New System.Windows.Forms.TextBox
        Me.ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuebleriaDataSet = New WindowsApplication1.MuebleriaDataSet
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox
        Me.TipoComboBox = New System.Windows.Forms.ComboBox
        Me.PrecioTextBox = New System.Windows.Forms.TextBox
        Me.StockTextBox = New System.Windows.Forms.TextBox
        Me.Stock_MinimoTextBox = New System.Windows.Forms.TextBox
        Me.ArticuloTableAdapter = New WindowsApplication1.MuebleriaDataSetTableAdapters.ArticuloTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.MuebleriaDataSetTableAdapters.TableAdapterManager
        Me.VentasTableAdapter = New WindowsApplication1.MuebleriaDataSetTableAdapters.VentasTableAdapter
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Id_cliente = New System.Windows.Forms.TextBox
        Me.Cantidad = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Importe = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Id_VentasTextBox = New System.Windows.Forms.TextBox
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Id_ArticuloTextBox1 = New System.Windows.Forms.TextBox
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.VentasDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Id_ArticuloLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        CategoriaLabel = New System.Windows.Forms.Label
        TipoLabel = New System.Windows.Forms.Label
        PrecioLabel = New System.Windows.Forms.Label
        StockLabel = New System.Windows.Forms.Label
        Stock_MinimoLabel = New System.Windows.Forms.Label
        Id_VentasLabel = New System.Windows.Forms.Label
        Id_ArticuloLabel1 = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        Id_clienteLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuebleriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_ArticuloLabel
        '
        Id_ArticuloLabel.AutoSize = True
        Id_ArticuloLabel.Location = New System.Drawing.Point(12, 62)
        Id_ArticuloLabel.Name = "Id_ArticuloLabel"
        Id_ArticuloLabel.Size = New System.Drawing.Size(57, 13)
        Id_ArticuloLabel.TabIndex = 0
        Id_ArticuloLabel.Text = "Id Articulo:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(12, 88)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 2
        DescripcionLabel.Text = "Descripcion:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(12, 114)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel.TabIndex = 4
        CategoriaLabel.Text = "Categoria:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(12, 141)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 6
        TipoLabel.Text = "Tipo:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(12, 168)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 8
        PrecioLabel.Text = "Precio:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(12, 194)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(38, 13)
        StockLabel.TabIndex = 10
        StockLabel.Text = "Stock:"
        '
        'Stock_MinimoLabel
        '
        Stock_MinimoLabel.AutoSize = True
        Stock_MinimoLabel.Location = New System.Drawing.Point(12, 220)
        Stock_MinimoLabel.Name = "Stock_MinimoLabel"
        Stock_MinimoLabel.Size = New System.Drawing.Size(74, 13)
        Stock_MinimoLabel.TabIndex = 12
        Stock_MinimoLabel.Text = "Stock Minimo:"
        '
        'Id_VentasLabel
        '
        Id_VentasLabel.AutoSize = True
        Id_VentasLabel.Location = New System.Drawing.Point(14, 56)
        Id_VentasLabel.Name = "Id_VentasLabel"
        Id_VentasLabel.Size = New System.Drawing.Size(55, 13)
        Id_VentasLabel.TabIndex = 0
        Id_VentasLabel.Text = "Id Ventas:"
        '
        'Id_ArticuloLabel1
        '
        Id_ArticuloLabel1.AutoSize = True
        Id_ArticuloLabel1.Location = New System.Drawing.Point(14, 82)
        Id_ArticuloLabel1.Name = "Id_ArticuloLabel1"
        Id_ArticuloLabel1.Size = New System.Drawing.Size(57, 13)
        Id_ArticuloLabel1.TabIndex = 2
        Id_ArticuloLabel1.Text = "Id Articulo:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(14, 109)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 4
        FechaLabel.Text = "Fecha:"
        '
        'Id_clienteLabel
        '
        Id_clienteLabel.AutoSize = True
        Id_clienteLabel.Location = New System.Drawing.Point(14, 134)
        Id_clienteLabel.Name = "Id_clienteLabel"
        Id_clienteLabel.Size = New System.Drawing.Size(53, 13)
        Id_clienteLabel.TabIndex = 6
        Id_clienteLabel.Text = "Id cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Id_ArticuloLabel)
        Me.GroupBox1.Controls.Add(Me.Id_ArticuloTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(CategoriaLabel)
        Me.GroupBox1.Controls.Add(Me.CategoriaComboBox)
        Me.GroupBox1.Controls.Add(TipoLabel)
        Me.GroupBox1.Controls.Add(Me.TipoComboBox)
        Me.GroupBox1.Controls.Add(PrecioLabel)
        Me.GroupBox1.Controls.Add(Me.PrecioTextBox)
        Me.GroupBox1.Controls.Add(StockLabel)
        Me.GroupBox1.Controls.Add(Me.StockTextBox)
        Me.GroupBox1.Controls.Add(Stock_MinimoLabel)
        Me.GroupBox1.Controls.Add(Me.Stock_MinimoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 296)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Articulo"
        '
        'Id_ArticuloTextBox
        '
        Me.Id_ArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Id_Articulo", True))
        Me.Id_ArticuloTextBox.Location = New System.Drawing.Point(92, 59)
        Me.Id_ArticuloTextBox.Name = "Id_ArticuloTextBox"
        Me.Id_ArticuloTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Id_ArticuloTextBox.TabIndex = 1
        '
        'ArticuloBindingSource
        '
        Me.ArticuloBindingSource.DataMember = "Articulo"
        Me.ArticuloBindingSource.DataSource = Me.MuebleriaDataSet
        '
        'MuebleriaDataSet
        '
        Me.MuebleriaDataSet.DataSetName = "MuebleriaDataSet"
        Me.MuebleriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(92, 85)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DescripcionTextBox.TabIndex = 3
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Categoria", True))
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Location = New System.Drawing.Point(92, 111)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CategoriaComboBox.TabIndex = 5
        '
        'TipoComboBox
        '
        Me.TipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Tipo", True))
        Me.TipoComboBox.FormattingEnabled = True
        Me.TipoComboBox.Location = New System.Drawing.Point(92, 138)
        Me.TipoComboBox.Name = "TipoComboBox"
        Me.TipoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TipoComboBox.TabIndex = 7
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(92, 165)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PrecioTextBox.TabIndex = 9
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Stock", True))
        Me.StockTextBox.Location = New System.Drawing.Point(92, 191)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(121, 20)
        Me.StockTextBox.TabIndex = 11
        '
        'Stock_MinimoTextBox
        '
        Me.Stock_MinimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Stock_Minimo", True))
        Me.Stock_MinimoTextBox.Location = New System.Drawing.Point(92, 217)
        Me.Stock_MinimoTextBox.Name = "Stock_MinimoTextBox"
        Me.Stock_MinimoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Stock_MinimoTextBox.TabIndex = 13
        '
        'ArticuloTableAdapter
        '
        Me.ArticuloTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticuloTableAdapter = Me.ArticuloTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.SucursalTableAdapter = Nothing
        Me.TableAdapterManager.Tipo_MaterialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MuebleriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Me.VentasTableAdapter
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Id_cliente)
        Me.GroupBox2.Controls.Add(Me.Cantidad)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Importe)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Id_VentasLabel)
        Me.GroupBox2.Controls.Add(Me.Id_VentasTextBox)
        Me.GroupBox2.Controls.Add(Id_ArticuloLabel1)
        Me.GroupBox2.Controls.Add(Me.Id_ArticuloTextBox1)
        Me.GroupBox2.Controls.Add(FechaLabel)
        Me.GroupBox2.Controls.Add(Me.FechaDateTimePicker)
        Me.GroupBox2.Controls.Add(Id_clienteLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 296)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la venta"
        '
        'Id_cliente
        '
        Me.Id_cliente.Location = New System.Drawing.Point(77, 131)
        Me.Id_cliente.Name = "Id_cliente"
        Me.Id_cliente.Size = New System.Drawing.Size(100, 20)
        Me.Id_cliente.TabIndex = 12
        '
        'Cantidad
        '
        Me.Cantidad.Location = New System.Drawing.Point(79, 160)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(97, 20)
        Me.Cantidad.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Importe:"
        '
        'Importe
        '
        Me.Importe.Location = New System.Drawing.Point(77, 195)
        Me.Importe.Name = "Importe"
        Me.Importe.Size = New System.Drawing.Size(97, 20)
        Me.Importe.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(44, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Vender"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Id_VentasTextBox
        '
        Me.Id_VentasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Id_Ventas", True))
        Me.Id_VentasTextBox.Location = New System.Drawing.Point(77, 53)
        Me.Id_VentasTextBox.Name = "Id_VentasTextBox"
        Me.Id_VentasTextBox.Size = New System.Drawing.Size(99, 20)
        Me.Id_VentasTextBox.TabIndex = 1
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.MuebleriaDataSet
        '
        'Id_ArticuloTextBox1
        '
        Me.Id_ArticuloTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Id_Articulo", True))
        Me.Id_ArticuloTextBox1.Location = New System.Drawing.Point(77, 79)
        Me.Id_ArticuloTextBox1.Name = "Id_ArticuloTextBox1"
        Me.Id_ArticuloTextBox1.Size = New System.Drawing.Size(99, 20)
        Me.Id_ArticuloTextBox1.TabIndex = 3
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(77, 105)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(99, 20)
        Me.FechaDateTimePicker.TabIndex = 5
        '
        'VentasDataGridView
        '
        Me.VentasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VentasDataGridView.AutoGenerateColumns = False
        Me.VentasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.VentasDataGridView.DataSource = Me.VentasBindingSource
        Me.VentasDataGridView.Location = New System.Drawing.Point(491, 29)
        Me.VentasDataGridView.Name = "VentasDataGridView"
        Me.VentasDataGridView.Size = New System.Drawing.Size(340, 279)
        Me.VentasDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Ventas"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Ventas"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Articulo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_Articulo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Id_cliente"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Id_cliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Vender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 338)
        Me.Controls.Add(Me.VentasDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Vender"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuebleriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MuebleriaDataSet As WindowsApplication1.MuebleriaDataSet
    Friend WithEvents ArticuloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticuloTableAdapter As WindowsApplication1.MuebleriaDataSetTableAdapters.ArticuloTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MuebleriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_ArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TipoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stock_MinimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VentasTableAdapter As WindowsApplication1.MuebleriaDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents VentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Id_VentasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_ArticuloTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents VentasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Id_cliente As System.Windows.Forms.TextBox
End Class
