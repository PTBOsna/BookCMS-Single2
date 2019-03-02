<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SachgruppeListe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SachgruppeListe))
        Dim GenreIDLabel As System.Windows.Forms.Label
        Dim MarkedLabel As System.Windows.Forms.Label
        Dim SachgruppeLabel As System.Windows.Forms.Label
        Dim SortByLabel As System.Windows.Forms.Label
        Dim Notiz_PlainTextLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.SachgruppeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SachgruppeTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.SachgruppeTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.SachgruppeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SachgruppeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SachgruppeDataGridView = New System.Windows.Forms.DataGridView()
        Me.GenreIDTextBox = New System.Windows.Forms.TextBox()
        Me.MarkedCheckBox = New System.Windows.Forms.CheckBox()
        Me.SachgruppeTextBox = New System.Windows.Forms.TextBox()
        Me.SortByTextBox = New System.Windows.Forms.TextBox()
        Me.Notiz_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        GenreIDLabel = New System.Windows.Forms.Label()
        MarkedLabel = New System.Windows.Forms.Label()
        SachgruppeLabel = New System.Windows.Forms.Label()
        SortByLabel = New System.Windows.Forms.Label()
        Notiz_PlainTextLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SachgruppeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SachgruppeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SachgruppeBindingNavigator.SuspendLayout()
        CType(Me.SachgruppeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SachgruppeDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(719, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(GenreIDLabel)
        Me.Panel1.Controls.Add(Me.GenreIDTextBox)
        Me.Panel1.Controls.Add(MarkedLabel)
        Me.Panel1.Controls.Add(Me.MarkedCheckBox)
        Me.Panel1.Controls.Add(SachgruppeLabel)
        Me.Panel1.Controls.Add(Me.SachgruppeTextBox)
        Me.Panel1.Controls.Add(SortByLabel)
        Me.Panel1.Controls.Add(Me.SortByTextBox)
        Me.Panel1.Controls.Add(Notiz_PlainTextLabel)
        Me.Panel1.Controls.Add(Me.Notiz_PlainTextTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(362, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 352)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel2, 2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 409)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(713, 38)
        Me.Panel2.TabIndex = 1
        '
        '_BookCMS_singleDataSet
        '
        Me._BookCMS_singleDataSet.DataSetName = "_BookCMS_singleDataSet"
        Me._BookCMS_singleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SachgruppeBindingSource
        '
        Me.SachgruppeBindingSource.DataMember = "Sachgruppe"
        Me.SachgruppeBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'SachgruppeTableAdapter
        '
        Me.SachgruppeTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SachgruppeTableAdapter = Me.SachgruppeTableAdapter
        Me.TableAdapterManager.SerienTableAdapter = Nothing
        Me.TableAdapterManager.StandortTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VerlagsOrtTableAdapter = Nothing
        Me.TableAdapterManager.VerlagTableAdapter = Nothing
        '
        'SachgruppeBindingNavigator
        '
        Me.SachgruppeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SachgruppeBindingNavigator.BindingSource = Me.SachgruppeBindingSource
        Me.SachgruppeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SachgruppeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SachgruppeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SachgruppeBindingNavigatorSaveItem})
        Me.SachgruppeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SachgruppeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SachgruppeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SachgruppeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SachgruppeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SachgruppeBindingNavigator.Name = "SachgruppeBindingNavigator"
        Me.SachgruppeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SachgruppeBindingNavigator.Size = New System.Drawing.Size(719, 25)
        Me.SachgruppeBindingNavigator.TabIndex = 1
        Me.SachgruppeBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 15)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
        '
        'SachgruppeBindingNavigatorSaveItem
        '
        Me.SachgruppeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SachgruppeBindingNavigatorSaveItem.Image = CType(resources.GetObject("SachgruppeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SachgruppeBindingNavigatorSaveItem.Name = "SachgruppeBindingNavigatorSaveItem"
        Me.SachgruppeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.SachgruppeBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'SachgruppeDataGridView
        '
        Me.SachgruppeDataGridView.AutoGenerateColumns = False
        Me.SachgruppeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SachgruppeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.SachgruppeDataGridView.DataSource = Me.SachgruppeBindingSource
        Me.SachgruppeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SachgruppeDataGridView.Location = New System.Drawing.Point(3, 51)
        Me.SachgruppeDataGridView.Name = "SachgruppeDataGridView"
        Me.SachgruppeDataGridView.Size = New System.Drawing.Size(353, 352)
        Me.SachgruppeDataGridView.TabIndex = 2
        '
        'GenreIDLabel
        '
        GenreIDLabel.AutoSize = True
        GenreIDLabel.Location = New System.Drawing.Point(15, 20)
        GenreIDLabel.Name = "GenreIDLabel"
        GenreIDLabel.Size = New System.Drawing.Size(53, 13)
        GenreIDLabel.TabIndex = 0
        GenreIDLabel.Text = "Genre ID:"
        '
        'GenreIDTextBox
        '
        Me.GenreIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachgruppeBindingSource, "GenreID", True))
        Me.GenreIDTextBox.Location = New System.Drawing.Point(105, 17)
        Me.GenreIDTextBox.Name = "GenreIDTextBox"
        Me.GenreIDTextBox.ReadOnly = True
        Me.GenreIDTextBox.Size = New System.Drawing.Size(65, 20)
        Me.GenreIDTextBox.TabIndex = 1
        '
        'MarkedLabel
        '
        MarkedLabel.AutoSize = True
        MarkedLabel.Location = New System.Drawing.Point(15, 48)
        MarkedLabel.Name = "MarkedLabel"
        MarkedLabel.Size = New System.Drawing.Size(46, 13)
        MarkedLabel.TabIndex = 2
        MarkedLabel.Text = "Marked:"
        '
        'MarkedCheckBox
        '
        Me.MarkedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SachgruppeBindingSource, "Marked", True))
        Me.MarkedCheckBox.Location = New System.Drawing.Point(105, 43)
        Me.MarkedCheckBox.Name = "MarkedCheckBox"
        Me.MarkedCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.MarkedCheckBox.TabIndex = 3
        Me.MarkedCheckBox.UseVisualStyleBackColor = True
        '
        'SachgruppeLabel
        '
        SachgruppeLabel.AutoSize = True
        SachgruppeLabel.Location = New System.Drawing.Point(15, 76)
        SachgruppeLabel.Name = "SachgruppeLabel"
        SachgruppeLabel.Size = New System.Drawing.Size(68, 13)
        SachgruppeLabel.TabIndex = 4
        SachgruppeLabel.Text = "Sachgruppe:"
        '
        'SachgruppeTextBox
        '
        Me.SachgruppeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachgruppeBindingSource, "Sachgruppe", True))
        Me.SachgruppeTextBox.Location = New System.Drawing.Point(105, 73)
        Me.SachgruppeTextBox.Name = "SachgruppeTextBox"
        Me.SachgruppeTextBox.Size = New System.Drawing.Size(233, 20)
        Me.SachgruppeTextBox.TabIndex = 5
        '
        'SortByLabel
        '
        SortByLabel.AutoSize = True
        SortByLabel.Location = New System.Drawing.Point(15, 102)
        SortByLabel.Name = "SortByLabel"
        SortByLabel.Size = New System.Drawing.Size(73, 13)
        SortByLabel.TabIndex = 6
        SortByLabel.Text = "Angezeigt als:"
        '
        'SortByTextBox
        '
        Me.SortByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachgruppeBindingSource, "SortBy", True))
        Me.SortByTextBox.Location = New System.Drawing.Point(105, 99)
        Me.SortByTextBox.Name = "SortByTextBox"
        Me.SortByTextBox.Size = New System.Drawing.Size(233, 20)
        Me.SortByTextBox.TabIndex = 7
        '
        'Notiz_PlainTextLabel
        '
        Notiz_PlainTextLabel.AutoSize = True
        Notiz_PlainTextLabel.Location = New System.Drawing.Point(15, 128)
        Notiz_PlainTextLabel.Name = "Notiz_PlainTextLabel"
        Notiz_PlainTextLabel.Size = New System.Drawing.Size(34, 13)
        Notiz_PlainTextLabel.TabIndex = 8
        Notiz_PlainTextLabel.Text = "Notiz:"
        '
        'Notiz_PlainTextTextBox
        '
        Me.Notiz_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachgruppeBindingSource, "Notiz_PlainText", True))
        Me.Notiz_PlainTextTextBox.Location = New System.Drawing.Point(105, 125)
        Me.Notiz_PlainTextTextBox.Multiline = True
        Me.Notiz_PlainTextTextBox.Name = "Notiz_PlainTextTextBox"
        Me.Notiz_PlainTextTextBox.Size = New System.Drawing.Size(233, 105)
        Me.Notiz_PlainTextTextBox.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "GenreID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 43
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Sachgruppe"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sachgruppe"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SortBy"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SortBy"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(319, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Zurück"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SachgruppeListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 450)
        Me.Controls.Add(Me.SachgruppeBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SachgruppeListe"
        Me.Text = "SachgruppeListe"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SachgruppeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SachgruppeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SachgruppeBindingNavigator.ResumeLayout(False)
        Me.SachgruppeBindingNavigator.PerformLayout()
        CType(Me.SachgruppeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents SachgruppeBindingSource As BindingSource
    Friend WithEvents SachgruppeTableAdapter As _BookCMS_singleDataSetTableAdapters.SachgruppeTableAdapter
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SachgruppeBindingNavigator As BindingNavigator
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
    Friend WithEvents SachgruppeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SachgruppeDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents GenreIDTextBox As TextBox
    Friend WithEvents MarkedCheckBox As CheckBox
    Friend WithEvents SachgruppeTextBox As TextBox
    Friend WithEvents SortByTextBox As TextBox
    Friend WithEvents Notiz_PlainTextTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
