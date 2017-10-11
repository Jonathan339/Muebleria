<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Articulos
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
        Me.MuebleriaDataSet = New WindowsApplication1.MuebleriaDataSet
        Me.ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticuloTableAdapter = New WindowsApplication1.MuebleriaDataSetTableAdapters.ArticuloTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.MuebleriaDataSetTableAdapters.TableAdapterManager
        Me.CategoriaTableAdapter = New WindowsApplication1.MuebleriaDataSetTableAdapters.CategoriaTableAdapter
        Me.Tipo_MaterialTableAdapter = New WindowsApplication1.MuebleriaDataSetTableAdapters.Tipo_MaterialTableAdapter
        Me.ArticuloDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_ArticuloTextBox = New System.Windows.Forms.TextBox
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.PrecioTextBox = New System.Windows.Forms.TextBox
        Me.StockTextBox = New System.Windows.Forms.TextBox
        Me.Stock_MinimoTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TipoComboBox = New System.Windows.Forms.ComboBox
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoMaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Id_ArticuloLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        CategoriaLabel = New System.Windows.Forms.Label
        TipoLabel = New System.Windows.Forms.Label
        PrecioLabel = New System.Windows.Forms.Label
        StockLabel = New System.Windows.Forms.Label
        Stock_MinimoLabel = New System.Windows.Forms.Label
        CType(Me.MuebleriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoMaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_ArticuloLabel
        '
        Id_ArticuloLabel.AutoSize = True
        Id_ArticuloLabel.Location = New System.Drawing.Point(18, 76)
        Id_ArticuloLabel.Name = "Id_ArticuloLabel"
        Id_ArticuloLabel.Size = New System.Drawing.Size(57, 13)
        Id_ArticuloLabel.TabIndex = 2
        Id_ArticuloLabel.Text = "Id Articulo:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(18, 102)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(18, 128)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel.TabIndex = 6
        CategoriaLabel.Text = "Categoria:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(18, 154)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 8
        TipoLabel.Text = "Tipo:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(18, 180)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 10
        PrecioLabel.Text = "Precio:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(18, 206)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(38, 13)
        StockLabel.TabIndex = 12
        StockLabel.Text = "Stock:"
        '
        'Stock_MinimoLabel
        '
        Stock_MinimoLabel.AutoSize = True
        Stock_MinimoLabel.Location = New System.Drawing.Point(18, 232)
        Stock_MinimoLabel.Name = "Stock_MinimoLabel"
        Stock_MinimoLabel.Size = New System.Drawing.Size(74, 13)
        Stock_MinimoLabel.TabIndex = 14
        Stock_MinimoLabel.Text = "Stock Minimo:"
        '
        'MuebleriaDataSet
        '
        Me.MuebleriaDataSet.DataSetName = "MuebleriaDataSet"
        Me.MuebleriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticuloBindingSource
        '
        Me.ArticuloBindingSource.DataMember = "Articulo"
        Me.ArticuloBindingSource.DataSource = Me.MuebleriaDataSet
        '
        'ArticuloTableAdapter
        '
        Me.ArticuloTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticuloTableAdapter = Me.ArticuloTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Me.CategoriaTableAdapter
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.SucursalTableAdapter = Nothing
        Me.TableAdapterManager.Tipo_MaterialTableAdapter = Me.Tipo_MaterialTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MuebleriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'Tipo_MaterialTableAdapter
        '
        Me.Tipo_MaterialTableAdapter.ClearBeforeFill = True
        '
        'ArticuloDataGridView
        '
        Me.ArticuloDataGridView.AllowUserToOrderColumns = True
        Me.ArticuloDataGridView.AutoGenerateColumns = False
        Me.ArticuloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticuloDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ArticuloDataGridView.DataSource = Me.ArticuloBindingSource
        Me.ArticuloDataGridView.Location = New System.Drawing.Point(215, 54)
        Me.ArticuloDataGridView.Name = "ArticuloDataGridView"
        Me.ArticuloDataGridView.Size = New System.Drawing.Size(650, 220)
        Me.ArticuloDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Articulo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Articulo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Stock"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Stock_Minimo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Stock_Minimo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Id_ArticuloTextBox
        '
        Me.Id_ArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Id_Articulo", True))
        Me.Id_ArticuloTextBox.Location = New System.Drawing.Point(98, 73)
        Me.Id_ArticuloTextBox.Name = "Id_ArticuloTextBox"
        Me.Id_ArticuloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_ArticuloTextBox.TabIndex = 3
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(98, 99)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(98, 177)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioTextBox.TabIndex = 11
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Stock", True))
        Me.StockTextBox.Location = New System.Drawing.Point(98, 203)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StockTextBox.TabIndex = 13
        '
        'Stock_MinimoTextBox
        '
        Me.Stock_MinimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Stock_Minimo", True))
        Me.Stock_MinimoTextBox.Location = New System.Drawing.Point(98, 229)
        Me.Stock_MinimoTextBox.Name = "Stock_MinimoTextBox"
        Me.Stock_MinimoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Stock_MinimoTextBox.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TipoComboBox)
        Me.GroupBox1.Controls.Add(Me.CategoriaComboBox)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 315)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'TipoComboBox
        '
        Me.TipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Tipo", True))
        Me.TipoComboBox.FormattingEnabled = True
        Me.TipoComboBox.Location = New System.Drawing.Point(86, 106)
        Me.TipoComboBox.Name = "TipoComboBox"
        Me.TipoComboBox.Size = New System.Drawing.Size(100, 21)
        Me.TipoComboBox.TabIndex = 3
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Categoria", True))
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Location = New System.Drawing.Point(86, 80)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(100, 21)
        Me.CategoriaComboBox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(86, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.MuebleriaDataSet
        '
        'TipoMaterialBindingSource
        '
        Me.TipoMaterialBindingSource.DataMember = "Tipo_Material"
        Me.TipoMaterialBindingSource.DataSource = Me.MuebleriaDataSet
        '
        'Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 381)
        Me.Controls.Add(Id_ArticuloLabel)
        Me.Controls.Add(Me.Id_ArticuloTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockTextBox)
        Me.Controls.Add(Stock_MinimoLabel)
        Me.Controls.Add(Me.Stock_MinimoTextBox)
        Me.Controls.Add(Me.ArticuloDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Articulos"
        Me.Text = "Articulos"
        CType(Me.MuebleriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoMaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MuebleriaDataSet As WindowsApplication1.MuebleriaDataSet
    Friend WithEvents ArticuloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticuloTableAdapter As WindowsApplication1.MuebleriaDataSetTableAdapters.ArticuloTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MuebleriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArticuloDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_ArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stock_MinimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TipoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CategoriaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CategoriaTableAdapter As WindowsApplication1.MuebleriaDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents CategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tipo_MaterialTableAdapter As WindowsApplication1.MuebleriaDataSetTableAdapters.Tipo_MaterialTableAdapter
    Friend WithEvents TipoMaterialBindingSource As System.Windows.Forms.BindingSource
End Class
