<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerlagsortListe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerlagsortListe))
        Dim IDLabel As System.Windows.Forms.Label
        Dim MarkedLabel As System.Windows.Forms.Label
        Dim VerlagsortLabel As System.Windows.Forms.Label
        Dim SortByLabel As System.Windows.Forms.Label
        Dim Notiz_PlainTextLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.VerlagsOrtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VerlagsOrtTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.VerlagsOrtTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.VerlagsOrtBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VerlagsOrtBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VerlagsOrtDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.MarkedCheckBox = New System.Windows.Forms.CheckBox()
        Me.VerlagsortTextBox = New System.Windows.Forms.TextBox()
        Me.SortByTextBox = New System.Windows.Forms.TextBox()
        Me.Notiz_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtClose = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        MarkedLabel = New System.Windows.Forms.Label()
        VerlagsortLabel = New System.Windows.Forms.Label()
        SortByLabel = New System.Windows.Forms.Label()
        Notiz_PlainTextLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerlagsOrtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerlagsOrtBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VerlagsOrtBindingNavigator.SuspendLayout()
        CType(Me.VerlagsOrtDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.VerlagsOrtDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.767123!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.23288!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(631, 386)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(MarkedLabel)
        Me.Panel1.Controls.Add(Me.MarkedCheckBox)
        Me.Panel1.Controls.Add(VerlagsortLabel)
        Me.Panel1.Controls.Add(Me.VerlagsortTextBox)
        Me.Panel1.Controls.Add(SortByLabel)
        Me.Panel1.Controls.Add(Me.SortByTextBox)
        Me.Panel1.Controls.Add(Notiz_PlainTextLabel)
        Me.Panel1.Controls.Add(Me.Notiz_PlainTextTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(318, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 303)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel2, 2)
        Me.Panel2.Controls.Add(Me.BtClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 341)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(625, 42)
        Me.Panel2.TabIndex = 1
        '
        '_BookCMS_singleDataSet
        '
        Me._BookCMS_singleDataSet.DataSetName = "_BookCMS_singleDataSet"
        Me._BookCMS_singleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VerlagsOrtBindingSource
        '
        Me.VerlagsOrtBindingSource.DataMember = "VerlagsOrt"
        Me.VerlagsOrtBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'VerlagsOrtTableAdapter
        '
        Me.VerlagsOrtTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.StandortTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VerlagsOrtTableAdapter = Me.VerlagsOrtTableAdapter
        Me.TableAdapterManager.VerlagTableAdapter = Nothing
        '
        'VerlagsOrtBindingNavigator
        '
        Me.VerlagsOrtBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VerlagsOrtBindingNavigator.BindingSource = Me.VerlagsOrtBindingSource
        Me.VerlagsOrtBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VerlagsOrtBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VerlagsOrtBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VerlagsOrtBindingNavigatorSaveItem})
        Me.VerlagsOrtBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VerlagsOrtBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VerlagsOrtBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VerlagsOrtBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VerlagsOrtBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VerlagsOrtBindingNavigator.Name = "VerlagsOrtBindingNavigator"
        Me.VerlagsOrtBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VerlagsOrtBindingNavigator.Size = New System.Drawing.Size(631, 25)
        Me.VerlagsOrtBindingNavigator.TabIndex = 1
        Me.VerlagsOrtBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'VerlagsOrtBindingNavigatorSaveItem
        '
        Me.VerlagsOrtBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VerlagsOrtBindingNavigatorSaveItem.Image = CType(resources.GetObject("VerlagsOrtBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VerlagsOrtBindingNavigatorSaveItem.Name = "VerlagsOrtBindingNavigatorSaveItem"
        Me.VerlagsOrtBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VerlagsOrtBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'VerlagsOrtDataGridView
        '
        Me.VerlagsOrtDataGridView.AutoGenerateColumns = False
        Me.VerlagsOrtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VerlagsOrtDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.VerlagsOrtDataGridView.DataSource = Me.VerlagsOrtBindingSource
        Me.VerlagsOrtDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerlagsOrtDataGridView.Location = New System.Drawing.Point(3, 32)
        Me.VerlagsOrtDataGridView.Name = "VerlagsOrtDataGridView"
        Me.VerlagsOrtDataGridView.Size = New System.Drawing.Size(309, 303)
        Me.VerlagsOrtDataGridView.TabIndex = 2
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(15, 15)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagsOrtBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(105, 12)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'MarkedLabel
        '
        MarkedLabel.AutoSize = True
        MarkedLabel.Location = New System.Drawing.Point(15, 249)
        MarkedLabel.Name = "MarkedLabel"
        MarkedLabel.Size = New System.Drawing.Size(46, 13)
        MarkedLabel.TabIndex = 2
        MarkedLabel.Text = "Marked:"
        '
        'MarkedCheckBox
        '
        Me.MarkedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VerlagsOrtBindingSource, "Marked", True))
        Me.MarkedCheckBox.Location = New System.Drawing.Point(105, 244)
        Me.MarkedCheckBox.Name = "MarkedCheckBox"
        Me.MarkedCheckBox.Size = New System.Drawing.Size(175, 24)
        Me.MarkedCheckBox.TabIndex = 3
        Me.MarkedCheckBox.Text = "CheckBox1"
        Me.MarkedCheckBox.UseVisualStyleBackColor = True
        '
        'VerlagsortLabel
        '
        VerlagsortLabel.AutoSize = True
        VerlagsortLabel.Location = New System.Drawing.Point(15, 71)
        VerlagsortLabel.Name = "VerlagsortLabel"
        VerlagsortLabel.Size = New System.Drawing.Size(57, 13)
        VerlagsortLabel.TabIndex = 4
        VerlagsortLabel.Text = "Verlagsort:"
        '
        'VerlagsortTextBox
        '
        Me.VerlagsortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagsOrtBindingSource, "Verlagsort", True))
        Me.VerlagsortTextBox.Location = New System.Drawing.Point(105, 68)
        Me.VerlagsortTextBox.Name = "VerlagsortTextBox"
        Me.VerlagsortTextBox.Size = New System.Drawing.Size(175, 20)
        Me.VerlagsortTextBox.TabIndex = 5
        '
        'SortByLabel
        '
        SortByLabel.AutoSize = True
        SortByLabel.Location = New System.Drawing.Point(15, 97)
        SortByLabel.Name = "SortByLabel"
        SortByLabel.Size = New System.Drawing.Size(44, 13)
        SortByLabel.TabIndex = 6
        SortByLabel.Text = "Sort By:"
        '
        'SortByTextBox
        '
        Me.SortByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagsOrtBindingSource, "SortBy", True))
        Me.SortByTextBox.Location = New System.Drawing.Point(105, 94)
        Me.SortByTextBox.Name = "SortByTextBox"
        Me.SortByTextBox.Size = New System.Drawing.Size(175, 20)
        Me.SortByTextBox.TabIndex = 7
        '
        'Notiz_PlainTextLabel
        '
        Notiz_PlainTextLabel.AutoSize = True
        Notiz_PlainTextLabel.Location = New System.Drawing.Point(15, 123)
        Notiz_PlainTextLabel.Name = "Notiz_PlainTextLabel"
        Notiz_PlainTextLabel.Size = New System.Drawing.Size(34, 13)
        Notiz_PlainTextLabel.TabIndex = 8
        Notiz_PlainTextLabel.Text = "Notiz:"
        '
        'Notiz_PlainTextTextBox
        '
        Me.Notiz_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagsOrtBindingSource, "Notiz_PlainText", True))
        Me.Notiz_PlainTextTextBox.Location = New System.Drawing.Point(105, 120)
        Me.Notiz_PlainTextTextBox.Multiline = True
        Me.Notiz_PlainTextTextBox.Name = "Notiz_PlainTextTextBox"
        Me.Notiz_PlainTextTextBox.Size = New System.Drawing.Size(175, 59)
        Me.Notiz_PlainTextTextBox.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 43
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Verlagsort"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Verlagsort"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'BtClose
        '
        Me.BtClose.Location = New System.Drawing.Point(276, 10)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(75, 23)
        Me.BtClose.TabIndex = 0
        Me.BtClose.Text = "Zurück"
        Me.BtClose.UseVisualStyleBackColor = True
        '
        'VerlagsortListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 386)
        Me.Controls.Add(Me.VerlagsOrtBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "VerlagsortListe"
        Me.Text = "BookCMS - Liste Verlagsorte"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerlagsOrtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerlagsOrtBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VerlagsOrtBindingNavigator.ResumeLayout(False)
        Me.VerlagsOrtBindingNavigator.PerformLayout()
        CType(Me.VerlagsOrtDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents VerlagsOrtBindingSource As BindingSource
    Friend WithEvents VerlagsOrtTableAdapter As _BookCMS_singleDataSetTableAdapters.VerlagsOrtTableAdapter
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VerlagsOrtBindingNavigator As BindingNavigator
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
    Friend WithEvents VerlagsOrtBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VerlagsOrtDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents MarkedCheckBox As CheckBox
    Friend WithEvents VerlagsortTextBox As TextBox
    Friend WithEvents SortByTextBox As TextBox
    Friend WithEvents Notiz_PlainTextTextBox As TextBox
    Friend WithEvents BtClose As Button
End Class
