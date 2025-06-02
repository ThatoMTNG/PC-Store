<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Product_IDLabel As System.Windows.Forms.Label
        Dim StocknameLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim SizeLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim SupplierLabel As System.Windows.Forms.Label
        Dim CampusLabel As System.Windows.Forms.Label
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.BillingFormButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SignoutButton = New System.Windows.Forms.Button()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NewstockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSet = New Richfield_PC_Store.StockDataSet()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.New_stockTableAdapter = New Richfield_PC_Store.StockDataSetTableAdapters.new_stockTableAdapter()
        Me.TableAdapterManager = New Richfield_PC_Store.StockDataSetTableAdapters.TableAdapterManager()
        Me.Product_IDTextBox = New System.Windows.Forms.TextBox()
        Me.StocknameTextBox = New System.Windows.Forms.TextBox()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.SizeTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.CampusTextBox = New System.Windows.Forms.TextBox()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StocknameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CampusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Product_IDLabel = New System.Windows.Forms.Label()
        StocknameLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        SizeLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        SupplierLabel = New System.Windows.Forms.Label()
        CampusLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewstockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Product_IDLabel
        '
        Product_IDLabel.AutoSize = True
        Product_IDLabel.Location = New System.Drawing.Point(505, 69)
        Product_IDLabel.Name = "Product_IDLabel"
        Product_IDLabel.Size = New System.Drawing.Size(61, 13)
        Product_IDLabel.TabIndex = 37
        Product_IDLabel.Text = "Product ID:"
        '
        'StocknameLabel
        '
        StocknameLabel.AutoSize = True
        StocknameLabel.Location = New System.Drawing.Point(505, 95)
        StocknameLabel.Name = "StocknameLabel"
        StocknameLabel.Size = New System.Drawing.Size(69, 13)
        StocknameLabel.TabIndex = 39
        StocknameLabel.Text = "Stock Name:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(505, 121)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(34, 13)
        TypeLabel.TabIndex = 41
        TypeLabel.Text = "Type:"
        '
        'SizeLabel
        '
        SizeLabel.AutoSize = True
        SizeLabel.Location = New System.Drawing.Point(505, 147)
        SizeLabel.Name = "SizeLabel"
        SizeLabel.Size = New System.Drawing.Size(73, 13)
        SizeLabel.TabIndex = 43
        SizeLabel.Text = "Size (GB/TB):"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(505, 173)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(56, 13)
        PriceLabel.TabIndex = 45
        PriceLabel.Text = "Unit Price:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(505, 199)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(49, 13)
        QuantityLabel.TabIndex = 47
        QuantityLabel.Text = "Quantity:"
        '
        'SupplierLabel
        '
        SupplierLabel.AutoSize = True
        SupplierLabel.Location = New System.Drawing.Point(505, 225)
        SupplierLabel.Name = "SupplierLabel"
        SupplierLabel.Size = New System.Drawing.Size(48, 13)
        SupplierLabel.TabIndex = 49
        SupplierLabel.Text = "Supplier:"
        '
        'CampusLabel
        '
        CampusLabel.AutoSize = True
        CampusLabel.Location = New System.Drawing.Point(505, 251)
        CampusLabel.Name = "CampusLabel"
        CampusLabel.Size = New System.Drawing.Size(48, 13)
        CampusLabel.TabIndex = 51
        CampusLabel.Text = "Campus:"
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(728, 409)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(86, 23)
        Me.CloseButton.TabIndex = 35
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'BillingFormButton
        '
        Me.BillingFormButton.Location = New System.Drawing.Point(642, 409)
        Me.BillingFormButton.Name = "BillingFormButton"
        Me.BillingFormButton.Size = New System.Drawing.Size(86, 23)
        Me.BillingFormButton.TabIndex = 34
        Me.BillingFormButton.Text = "Billing Form"
        Me.BillingFormButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        Me.PreviousButton.Location = New System.Drawing.Point(556, 409)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(86, 23)
        Me.PreviousButton.TabIndex = 33
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'FindButton
        '
        Me.FindButton.Location = New System.Drawing.Point(470, 409)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(86, 23)
        Me.FindButton.TabIndex = 32
        Me.FindButton.Text = "Find"
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(384, 409)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(86, 23)
        Me.ResetButton.TabIndex = 31
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'SignoutButton
        '
        Me.SignoutButton.Location = New System.Drawing.Point(298, 409)
        Me.SignoutButton.Name = "SignoutButton"
        Me.SignoutButton.Size = New System.Drawing.Size(86, 23)
        Me.SignoutButton.TabIndex = 30
        Me.SignoutButton.Text = "Signout"
        Me.SignoutButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(212, 409)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(86, 23)
        Me.RemoveButton.TabIndex = 29
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'ChangeButton
        '
        Me.ChangeButton.Location = New System.Drawing.Point(126, 409)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(86, 23)
        Me.ChangeButton.TabIndex = 28
        Me.ChangeButton.Text = "Change"
        Me.ChangeButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(40, 409)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(86, 23)
        Me.SaveButton.TabIndex = 27
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.StocknameDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.SizeDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.SupplierDataGridViewTextBoxColumn, Me.CampusDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.NewstockBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(15, 287)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(828, 116)
        Me.DataGridView2.TabIndex = 26
        '
        'NewstockBindingSource
        '
        Me.NewstockBindingSource.DataMember = "new_stock"
        Me.NewstockBindingSource.DataSource = Me.StockDataSet
        '
        'StockDataSet
        '
        Me.StockDataSet.DataSetName = "StockDataSet"
        Me.StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Find:"
        '
        'New_stockTableAdapter
        '
        Me.New_stockTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.new_stockTableAdapter = Me.New_stockTableAdapter
        Me.TableAdapterManager.UpdateOrder = Richfield_PC_Store.StockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Product_IDTextBox
        '
        Me.Product_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewstockBindingSource, "Product ID", True))
        Me.Product_IDTextBox.Location = New System.Drawing.Point(584, 66)
        Me.Product_IDTextBox.Name = "Product_IDTextBox"
        Me.Product_IDTextBox.Size = New System.Drawing.Size(142, 20)
        Me.Product_IDTextBox.TabIndex = 38
        '
        'StocknameTextBox
        '
        Me.StocknameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewstockBindingSource, "Stockname", True))
        Me.StocknameTextBox.Location = New System.Drawing.Point(584, 92)
        Me.StocknameTextBox.Name = "StocknameTextBox"
        Me.StocknameTextBox.Size = New System.Drawing.Size(142, 20)
        Me.StocknameTextBox.TabIndex = 40
        '
        'TypeTextBox
        '
        Me.TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewstockBindingSource, "Type", True))
        Me.TypeTextBox.Location = New System.Drawing.Point(584, 118)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(142, 20)
        Me.TypeTextBox.TabIndex = 42
        '
        'SizeTextBox
        '
        Me.SizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewstockBindingSource, "Size", True))
        Me.SizeTextBox.Location = New System.Drawing.Point(584, 144)
        Me.SizeTextBox.Name = "SizeTextBox"
        Me.SizeTextBox.Size = New System.Drawing.Size(142, 20)
        Me.SizeTextBox.TabIndex = 44
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewstockBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(584, 170)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(142, 20)
        Me.PriceTextBox.TabIndex = 46
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewstockBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(584, 196)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(142, 20)
        Me.QuantityTextBox.TabIndex = 48
        '
        'SupplierTextBox
        '
        Me.SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewstockBindingSource, "Supplier", True))
        Me.SupplierTextBox.Location = New System.Drawing.Point(584, 222)
        Me.SupplierTextBox.Name = "SupplierTextBox"
        Me.SupplierTextBox.Size = New System.Drawing.Size(142, 20)
        Me.SupplierTextBox.TabIndex = 50
        '
        'CampusTextBox
        '
        Me.CampusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewstockBindingSource, "Campus", True))
        Me.CampusTextBox.Location = New System.Drawing.Point(584, 248)
        Me.CampusTextBox.Name = "CampusTextBox"
        Me.CampusTextBox.Size = New System.Drawing.Size(142, 20)
        Me.CampusTextBox.TabIndex = 52
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'StocknameDataGridViewTextBoxColumn
        '
        Me.StocknameDataGridViewTextBoxColumn.DataPropertyName = "Stockname"
        Me.StocknameDataGridViewTextBoxColumn.HeaderText = "Stockname"
        Me.StocknameDataGridViewTextBoxColumn.Name = "StocknameDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'SizeDataGridViewTextBoxColumn
        '
        Me.SizeDataGridViewTextBoxColumn.DataPropertyName = "Size"
        Me.SizeDataGridViewTextBoxColumn.HeaderText = "Size"
        Me.SizeDataGridViewTextBoxColumn.Name = "SizeDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'SupplierDataGridViewTextBoxColumn
        '
        Me.SupplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier"
        Me.SupplierDataGridViewTextBoxColumn.HeaderText = "Supplier"
        Me.SupplierDataGridViewTextBoxColumn.Name = "SupplierDataGridViewTextBoxColumn"
        '
        'CampusDataGridViewTextBoxColumn
        '
        Me.CampusDataGridViewTextBoxColumn.DataPropertyName = "Campus"
        Me.CampusDataGridViewTextBoxColumn.HeaderText = "Campus"
        Me.CampusDataGridViewTextBoxColumn.Name = "CampusDataGridViewTextBoxColumn"
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(855, 452)
        Me.Controls.Add(Product_IDLabel)
        Me.Controls.Add(Me.Product_IDTextBox)
        Me.Controls.Add(StocknameLabel)
        Me.Controls.Add(Me.StocknameTextBox)
        Me.Controls.Add(TypeLabel)
        Me.Controls.Add(Me.TypeTextBox)
        Me.Controls.Add(SizeLabel)
        Me.Controls.Add(Me.SizeTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(SupplierLabel)
        Me.Controls.Add(Me.SupplierTextBox)
        Me.Controls.Add(CampusLabel)
        Me.Controls.Add(Me.CampusTextBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.BillingFormButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.FindButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.SignoutButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.ChangeButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewstockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents BillingFormButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents FindButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents SignoutButton As Button
    Friend WithEvents RemoveButton As Button
    Friend WithEvents ChangeButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StockDataSet As StockDataSet
    Friend WithEvents NewstockBindingSource As BindingSource
    Friend WithEvents New_stockTableAdapter As StockDataSetTableAdapters.new_stockTableAdapter
    Friend WithEvents TableAdapterManager As StockDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Product_IDTextBox As TextBox
    Friend WithEvents StocknameTextBox As TextBox
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents SizeTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents SupplierTextBox As TextBox
    Friend WithEvents CampusTextBox As TextBox
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StocknameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CampusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
