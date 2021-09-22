<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class custbook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PersonIDLabel As System.Windows.Forms.Label
        Dim PersonNameLabel As System.Windows.Forms.Label
        Dim DobLabel As System.Windows.Forms.Label
        Dim PhoneNumLabel As System.Windows.Forms.Label
        Dim PersonAddressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(custbook))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AddressTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AddressTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IsoprimeDBDataSet = New IsoprimeProgram.IsoprimeDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddressTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AddressTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.PersonIDTextBox = New System.Windows.Forms.TextBox()
        Me.PersonNameTextBox = New System.Windows.Forms.TextBox()
        Me.DobDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.PersonAddressTextBox = New System.Windows.Forms.TextBox()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddressTableTableAdapter = New IsoprimeProgram.IsoprimeDBDataSetTableAdapters.addressTableTableAdapter()
        Me.TableAdapterManager = New IsoprimeProgram.IsoprimeDBDataSetTableAdapters.TableAdapterManager()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.searchBox = New System.Windows.Forms.TextBox()
        PersonIDLabel = New System.Windows.Forms.Label()
        PersonNameLabel = New System.Windows.Forms.Label()
        DobLabel = New System.Windows.Forms.Label()
        PhoneNumLabel = New System.Windows.Forms.Label()
        PersonAddressLabel = New System.Windows.Forms.Label()
        CType(Me.AddressTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddressTableBindingNavigator.SuspendLayout()
        CType(Me.AddressTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsoprimeDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PersonIDLabel
        '
        PersonIDLabel.AutoSize = True
        PersonIDLabel.Location = New System.Drawing.Point(18, 22)
        PersonIDLabel.Name = "PersonIDLabel"
        PersonIDLabel.Size = New System.Drawing.Size(56, 13)
        PersonIDLabel.TabIndex = 6
        PersonIDLabel.Text = "person ID:"
        '
        'PersonNameLabel
        '
        PersonNameLabel.AutoSize = True
        PersonNameLabel.Location = New System.Drawing.Point(18, 48)
        PersonNameLabel.Name = "PersonNameLabel"
        PersonNameLabel.Size = New System.Drawing.Size(73, 13)
        PersonNameLabel.TabIndex = 8
        PersonNameLabel.Text = "person Name:"
        '
        'DobLabel
        '
        DobLabel.AutoSize = True
        DobLabel.Location = New System.Drawing.Point(18, 75)
        DobLabel.Name = "DobLabel"
        DobLabel.Size = New System.Drawing.Size(28, 13)
        DobLabel.TabIndex = 10
        DobLabel.Text = "dob:"
        '
        'PhoneNumLabel
        '
        PhoneNumLabel.AutoSize = True
        PhoneNumLabel.Location = New System.Drawing.Point(18, 100)
        PhoneNumLabel.Name = "PhoneNumLabel"
        PhoneNumLabel.Size = New System.Drawing.Size(65, 13)
        PhoneNumLabel.TabIndex = 12
        PhoneNumLabel.Text = "phone Num:"
        '
        'PersonAddressLabel
        '
        PersonAddressLabel.AutoSize = True
        PersonAddressLabel.Location = New System.Drawing.Point(18, 126)
        PersonAddressLabel.Name = "PersonAddressLabel"
        PersonAddressLabel.Size = New System.Drawing.Size(83, 13)
        PersonAddressLabel.TabIndex = 14
        PersonAddressLabel.Text = "person Address:"
        '
        'AddressTableBindingNavigator
        '
        Me.AddressTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AddressTableBindingNavigator.BindingSource = Me.AddressTableBindingSource
        Me.AddressTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AddressTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AddressTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AddressTableBindingNavigatorSaveItem})
        Me.AddressTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AddressTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AddressTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AddressTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AddressTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AddressTableBindingNavigator.Name = "AddressTableBindingNavigator"
        Me.AddressTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AddressTableBindingNavigator.Size = New System.Drawing.Size(879, 25)
        Me.AddressTableBindingNavigator.TabIndex = 0
        Me.AddressTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'AddressTableBindingSource
        '
        Me.AddressTableBindingSource.DataMember = "addressTable"
        Me.AddressTableBindingSource.DataSource = Me.IsoprimeDBDataSet
        '
        'IsoprimeDBDataSet
        '
        Me.IsoprimeDBDataSet.DataSetName = "IsoprimeDBDataSet"
        Me.IsoprimeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AddressTableBindingNavigatorSaveItem
        '
        Me.AddressTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddressTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("AddressTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AddressTableBindingNavigatorSaveItem.Name = "AddressTableBindingNavigatorSaveItem"
        Me.AddressTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AddressTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AddressTableDataGridView
        '
        Me.AddressTableDataGridView.AllowUserToAddRows = False
        Me.AddressTableDataGridView.AllowUserToDeleteRows = False
        Me.AddressTableDataGridView.AutoGenerateColumns = False
        Me.AddressTableDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.AddressTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.AddressTableDataGridView.DataSource = Me.AddressTableBindingSource
        Me.AddressTableDataGridView.GridColor = System.Drawing.Color.SeaGreen
        Me.AddressTableDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.AddressTableDataGridView.Name = "AddressTableDataGridView"
        Me.AddressTableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AddressTableDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AddressTableDataGridView.Size = New System.Drawing.Size(520, 421)
        Me.AddressTableDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "personID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "personID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "personName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "personName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "dob"
        Me.DataGridViewTextBoxColumn3.HeaderText = "dob"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "phoneNum"
        Me.DataGridViewTextBoxColumn4.HeaderText = "phoneNum"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "personAddress"
        Me.DataGridViewTextBoxColumn5.HeaderText = "personAddress"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'addButton
        '
        Me.addButton.ForeColor = System.Drawing.Color.ForestGreen
        Me.addButton.Location = New System.Drawing.Point(612, 204)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(181, 44)
        Me.addButton.TabIndex = 2
        Me.addButton.Text = "Add New"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.ForeColor = System.Drawing.Color.Crimson
        Me.deleteButton.Location = New System.Drawing.Point(611, 304)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(181, 44)
        Me.deleteButton.TabIndex = 3
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'PersonIDTextBox
        '
        Me.PersonIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressTableBindingSource, "personID", True))
        Me.PersonIDTextBox.Location = New System.Drawing.Point(107, 19)
        Me.PersonIDTextBox.Name = "PersonIDTextBox"
        Me.PersonIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PersonIDTextBox.TabIndex = 7
        '
        'PersonNameTextBox
        '
        Me.PersonNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressTableBindingSource, "personName", True))
        Me.PersonNameTextBox.Location = New System.Drawing.Point(107, 45)
        Me.PersonNameTextBox.Name = "PersonNameTextBox"
        Me.PersonNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PersonNameTextBox.TabIndex = 9
        '
        'DobDateTimePicker
        '
        Me.DobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AddressTableBindingSource, "dob", True))
        Me.DobDateTimePicker.Location = New System.Drawing.Point(107, 71)
        Me.DobDateTimePicker.Name = "DobDateTimePicker"
        Me.DobDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DobDateTimePicker.TabIndex = 11
        '
        'PhoneNumTextBox
        '
        Me.PhoneNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressTableBindingSource, "phoneNum", True))
        Me.PhoneNumTextBox.Location = New System.Drawing.Point(107, 97)
        Me.PhoneNumTextBox.Name = "PhoneNumTextBox"
        Me.PhoneNumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneNumTextBox.TabIndex = 13
        '
        'PersonAddressTextBox
        '
        Me.PersonAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressTableBindingSource, "personAddress", True))
        Me.PersonAddressTextBox.Location = New System.Drawing.Point(107, 123)
        Me.PersonAddressTextBox.Name = "PersonAddressTextBox"
        Me.PersonAddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PersonAddressTextBox.TabIndex = 15
        '
        'quitButton
        '
        Me.quitButton.ForeColor = System.Drawing.Color.Magenta
        Me.quitButton.Location = New System.Drawing.Point(611, 354)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(181, 44)
        Me.quitButton.TabIndex = 16
        Me.quitButton.Text = "Quit"
        Me.quitButton.UseVisualStyleBackColor = True
        '
        'updateButton
        '
        Me.updateButton.ForeColor = System.Drawing.Color.Goldenrod
        Me.updateButton.Location = New System.Drawing.Point(611, 254)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(181, 44)
        Me.updateButton.TabIndex = 17
        Me.updateButton.Text = "Update/Save"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PersonIDTextBox)
        Me.GroupBox1.Controls.Add(Me.PersonAddressTextBox)
        Me.GroupBox1.Controls.Add(PersonIDLabel)
        Me.GroupBox1.Controls.Add(PersonAddressLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneNumTextBox)
        Me.GroupBox1.Controls.Add(PersonNameLabel)
        Me.GroupBox1.Controls.Add(PhoneNumLabel)
        Me.GroupBox1.Controls.Add(Me.PersonNameTextBox)
        Me.GroupBox1.Controls.Add(Me.DobDateTimePicker)
        Me.GroupBox1.Controls.Add(DobLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(538, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 158)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create Your Own"
        '
        'AddressTableTableAdapter
        '
        Me.AddressTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.addressTableTableAdapter = Me.AddressTableTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = IsoprimeProgram.IsoprimeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'searchButton
        '
        Me.searchButton.ForeColor = System.Drawing.Color.Blue
        Me.searchButton.Location = New System.Drawing.Point(611, 468)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(181, 44)
        Me.searchButton.TabIndex = 20
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        Me.searchButton.Visible = False
        '
        'searchBox
        '
        Me.searchBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.searchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.Location = New System.Drawing.Point(12, 468)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(520, 44)
        Me.searchBox.TabIndex = 21
        Me.searchBox.Visible = False
        '
        'custbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(879, 524)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.AddressTableDataGridView)
        Me.Controls.Add(Me.AddressTableBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "custbook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Book"
        CType(Me.AddressTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddressTableBindingNavigator.ResumeLayout(False)
        Me.AddressTableBindingNavigator.PerformLayout()
        CType(Me.AddressTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsoprimeDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IsoprimeDBDataSet As IsoprimeDBDataSet
    Friend WithEvents AddressTableBindingSource As BindingSource
    Friend WithEvents AddressTableTableAdapter As IsoprimeDBDataSetTableAdapters.addressTableTableAdapter
    Friend WithEvents TableAdapterManager As IsoprimeDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AddressTableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AddressTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AddressTableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents addButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents PersonIDTextBox As TextBox
    Friend WithEvents PersonNameTextBox As TextBox
    Friend WithEvents DobDateTimePicker As DateTimePicker
    Friend WithEvents PhoneNumTextBox As TextBox
    Friend WithEvents PersonAddressTextBox As TextBox
    Friend WithEvents quitButton As Button
    Friend WithEvents updateButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents searchButton As Button
    Friend WithEvents searchBox As TextBox
End Class
