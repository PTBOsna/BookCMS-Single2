<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StandortListe
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StandortListe))
        Dim IDLabel As System.Windows.Forms.Label
        Dim MarkedLabel As System.Windows.Forms.Label
        Dim StandortLabel As System.Windows.Forms.Label
        Dim SortByLabel As System.Windows.Forms.Label
        Dim Notiz_PlainTextLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.StandortBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StandortTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.StandortTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.StandortBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StandortDataGridView = New System.Windows.Forms.DataGridView()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.StandortBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.MarkedCheckBox = New System.Windows.Forms.CheckBox()
        Me.StandortTextBox = New System.Windows.Forms.TextBox()
        Me.SortByTextBox = New System.Windows.Forms.TextBox()
        Me.Notiz_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        MarkedLabel = New System.Windows.Forms.Label()
        StandortLabel = New System.Windows.Forms.Label()
        SortByLabel = New System.Windows.Forms.Label()
        Notiz_PlainTextLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandortBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandortBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StandortBindingNavigator.SuspendLayout()
        CType(Me.StandortDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.46724!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.53276!))
        Me.TableLayoutPanel1.Controls.Add(Me.StandortDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.73486!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.26514!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(592, 401)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 345)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 53)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(IDLabel)
        Me.Panel2.Controls.Add(Me.IDTextBox)
        Me.Panel2.Controls.Add(MarkedLabel)
        Me.Panel2.Controls.Add(Me.MarkedCheckBox)
        Me.Panel2.Controls.Add(StandortLabel)
        Me.Panel2.Controls.Add(Me.StandortTextBox)
        Me.Panel2.Controls.Add(SortByLabel)
        Me.Panel2.Controls.Add(Me.SortByTextBox)
        Me.Panel2.Controls.Add(Notiz_PlainTextLabel)
        Me.Panel2.Controls.Add(Me.Notiz_PlainTextTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(218, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(371, 293)
        Me.Panel2.TabIndex = 1
        '
        '_BookCMS_singleDataSet
        '
        Me._BookCMS_singleDataSet.DataSetName = "_BookCMS_singleDataSet"
        Me._BookCMS_singleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StandortBindingSource
        '
        Me.StandortBindingSource.DataMember = "Standort"
        Me.StandortBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'StandortTableAdapter
        '
        Me.StandortTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutorBuchLinkTableAdapter = Nothing
        Me.TableAdapterManager.AutorRolleTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BibliothekTableAdapter = Nothing
        Me.TableAdapterManager.BindungTableAdapter = Nothing
        Me.TableAdapterManager.BuchTableAdapter = Nothing
        Me.TableAdapterManager.BuchTypTableAdapter = Nothing
        Me.TableAdapterManager.DDCTableAdapter = Nothing
        Me.TableAdapterManager.DruckereiTableAdapter = Nothing
        Me.TableAdapterManager.EditionTableAdapter = Nothing
        Me.TableAdapterManager.GenreLinkTableAdapter = Nothing
        Me.TableAdapterManager.LandTableAdapter = Nothing
        Me.TableAdapterManager.LanguageTableAdapter = Nothing
        Me.TableAdapterManager.PersonTableAdapter = Nothing
        Me.TableAdapterManager.SachgruppeTableAdapter = Nothing
        Me.TableAdapterManager.SerienTableAdapter = Nothing
        Me.TableAdapterManager.StandortTableAdapter = Me.StandortTableAdapter
        Me.TableAdapterManager.UpdateOrder = BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VerlagsOrtTableAdapter = Nothing
        Me.TableAdapterManager.VerlagTableAdapter = Nothing
        '
        'StandortBindingNavigator
        '
        Me.StandortBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StandortBindingNavigator.BindingSource = Me.StandortBindingSource
        Me.StandortBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StandortBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StandortBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StandortBindingNavigatorSaveItem})
        Me.StandortBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StandortBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StandortBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StandortBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StandortBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StandortBindingNavigator.Name = "StandortBindingNavigator"
        Me.StandortBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StandortBindingNavigator.Size = New System.Drawing.Size(592, 25)
        Me.StandortBindingNavigator.TabIndex = 1
        Me.StandortBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Aktuelle Position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'StandortDataGridView
        '
        Me.StandortDataGridView.AutoGenerateColumns = False
        Me.StandortDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StandortDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.StandortDataGridView.DataSource = Me.StandortBindingSource
        Me.StandortDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StandortDataGridView.Location = New System.Drawing.Point(3, 46)
        Me.StandortDataGridView.Name = "StandortDataGridView"
        Me.StandortDataGridView.Size = New System.Drawing.Size(209, 293)
        Me.StandortDataGridView.TabIndex = 2
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Neu hinzufügen"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'StandortBindingNavigatorSaveItem
        '
        Me.StandortBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StandortBindingNavigatorSaveItem.Image = CType(resources.GetObject("StandortBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StandortBindingNavigatorSaveItem.Name = "StandortBindingNavigatorSaveItem"
        Me.StandortBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StandortBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(40, 32)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StandortBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(130, 29)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(72, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'MarkedLabel
        '
        MarkedLabel.AutoSize = True
        MarkedLabel.Location = New System.Drawing.Point(40, 60)
        MarkedLabel.Name = "MarkedLabel"
        MarkedLabel.Size = New System.Drawing.Size(48, 13)
        MarkedLabel.TabIndex = 2
        MarkedLabel.Text = "Markiert:"
        '
        'MarkedCheckBox
        '
        Me.MarkedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.StandortBindingSource, "Marked", True))
        Me.MarkedCheckBox.Location = New System.Drawing.Point(130, 55)
        Me.MarkedCheckBox.Name = "MarkedCheckBox"
        Me.MarkedCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.MarkedCheckBox.TabIndex = 3
        Me.MarkedCheckBox.UseVisualStyleBackColor = True
        '
        'StandortLabel
        '
        StandortLabel.AutoSize = True
        StandortLabel.Location = New System.Drawing.Point(40, 88)
        StandortLabel.Name = "StandortLabel"
        StandortLabel.Size = New System.Drawing.Size(50, 13)
        StandortLabel.TabIndex = 4
        StandortLabel.Text = "Standort:"
        '
        'StandortTextBox
        '
        Me.StandortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StandortBindingSource, "Standort", True))
        Me.StandortTextBox.Location = New System.Drawing.Point(130, 85)
        Me.StandortTextBox.Name = "StandortTextBox"
        Me.StandortTextBox.Size = New System.Drawing.Size(189, 20)
        Me.StandortTextBox.TabIndex = 5
        '
        'SortByLabel
        '
        SortByLabel.AutoSize = True
        SortByLabel.Location = New System.Drawing.Point(40, 114)
        SortByLabel.Name = "SortByLabel"
        SortByLabel.Size = New System.Drawing.Size(76, 13)
        SortByLabel.TabIndex = 6
        SortByLabel.Text = "Angezeigt als::"
        '
        'SortByTextBox
        '
        Me.SortByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StandortBindingSource, "SortBy", True))
        Me.SortByTextBox.Location = New System.Drawing.Point(130, 111)
        Me.SortByTextBox.Name = "SortByTextBox"
        Me.SortByTextBox.Size = New System.Drawing.Size(189, 20)
        Me.SortByTextBox.TabIndex = 7
        '
        'Notiz_PlainTextLabel
        '
        Notiz_PlainTextLabel.AutoSize = True
        Notiz_PlainTextLabel.Location = New System.Drawing.Point(40, 140)
        Notiz_PlainTextLabel.Name = "Notiz_PlainTextLabel"
        Notiz_PlainTextLabel.Size = New System.Drawing.Size(34, 13)
        Notiz_PlainTextLabel.TabIndex = 8
        Notiz_PlainTextLabel.Text = "Notiz:"
        '
        'Notiz_PlainTextTextBox
        '
        Me.Notiz_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StandortBindingSource, "Notiz_PlainText", True))
        Me.Notiz_PlainTextTextBox.Location = New System.Drawing.Point(130, 137)
        Me.Notiz_PlainTextTextBox.Multiline = True
        Me.Notiz_PlainTextTextBox.Name = "Notiz_PlainTextTextBox"
        Me.Notiz_PlainTextTextBox.Size = New System.Drawing.Size(189, 58)
        Me.Notiz_PlainTextTextBox.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Standort"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Standort"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(258, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Zurück"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StandortListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 401)
        Me.Controls.Add(Me.StandortBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "StandortListe"
        Me.Text = "StandortListe"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandortBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandortBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StandortBindingNavigator.ResumeLayout(False)
        Me.StandortBindingNavigator.PerformLayout()
        CType(Me.StandortDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents StandortBindingSource As BindingSource
    Friend WithEvents StandortTableAdapter As _BookCMS_singleDataSetTableAdapters.StandortTableAdapter
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StandortBindingNavigator As BindingNavigator
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
    Friend WithEvents StandortBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StandortDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents MarkedCheckBox As CheckBox
    Friend WithEvents StandortTextBox As TextBox
    Friend WithEvents SortByTextBox As TextBox
    Friend WithEvents Notiz_PlainTextTextBox As TextBox
End Class
