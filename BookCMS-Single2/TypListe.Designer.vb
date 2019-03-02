<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypListe
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim MarkedLabel As System.Windows.Forms.Label
        Dim BuchTypLabel As System.Windows.Forms.Label
        Dim SortByLabel As System.Windows.Forms.Label
        Dim Notiz_PlainTextLabel As System.Windows.Forms.Label
        Dim NeuLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TypListe))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BuchTypDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuchTypBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.MarkedCheckBox = New System.Windows.Forms.CheckBox()
        Me.BuchTypTextBox = New System.Windows.Forms.TextBox()
        Me.SortByTextBox = New System.Windows.Forms.TextBox()
        Me.Notiz_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.NeuTextBox = New System.Windows.Forms.TextBox()
        Me.BuchTypTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.BuchTypTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.BuchTypBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.BuchTypBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.LblAnzahlZeichen = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        MarkedLabel = New System.Windows.Forms.Label()
        BuchTypLabel = New System.Windows.Forms.Label()
        SortByLabel = New System.Windows.Forms.Label()
        Notiz_PlainTextLabel = New System.Windows.Forms.Label()
        NeuLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BuchTypDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuchTypBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BuchTypBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BuchTypBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(25, 20)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'MarkedLabel
        '
        MarkedLabel.AutoSize = True
        MarkedLabel.Location = New System.Drawing.Point(25, 286)
        MarkedLabel.Name = "MarkedLabel"
        MarkedLabel.Size = New System.Drawing.Size(48, 13)
        MarkedLabel.TabIndex = 2
        MarkedLabel.Text = "Markiert:"
        '
        'BuchTypLabel
        '
        BuchTypLabel.AutoSize = True
        BuchTypLabel.Location = New System.Drawing.Point(25, 76)
        BuchTypLabel.Name = "BuchTypLabel"
        BuchTypLabel.Size = New System.Drawing.Size(56, 13)
        BuchTypLabel.TabIndex = 4
        BuchTypLabel.Text = "Buch Typ:"
        '
        'SortByLabel
        '
        SortByLabel.AutoSize = True
        SortByLabel.Location = New System.Drawing.Point(25, 102)
        SortByLabel.Name = "SortByLabel"
        SortByLabel.Size = New System.Drawing.Size(43, 13)
        SortByLabel.TabIndex = 6
        SortByLabel.Text = "Sortiert:"
        ' AddHandler SortByLabel.Click, AddressOf Me.SortByLabel_Click
        '
        'Notiz_PlainTextLabel
        '
        Notiz_PlainTextLabel.AutoSize = True
        Notiz_PlainTextLabel.Location = New System.Drawing.Point(25, 128)
        Notiz_PlainTextLabel.Name = "Notiz_PlainTextLabel"
        Notiz_PlainTextLabel.Size = New System.Drawing.Size(34, 13)
        Notiz_PlainTextLabel.TabIndex = 8
        Notiz_PlainTextLabel.Text = "Notiz:"
        '
        'NeuLabel
        '
        NeuLabel.AutoSize = True
        NeuLabel.Location = New System.Drawing.Point(25, 258)
        NeuLabel.Name = "NeuLabel"
        NeuLabel.Size = New System.Drawing.Size(28, 13)
        NeuLabel.TabIndex = 10
        NeuLabel.Text = "neu:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BuchTypDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(595, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BuchTypDataGridView
        '
        Me.BuchTypDataGridView.AutoGenerateColumns = False
        Me.BuchTypDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BuchTypDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.BuchTypDataGridView.DataSource = Me.BuchTypBindingSource
        Me.BuchTypDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BuchTypDataGridView.Location = New System.Drawing.Point(3, 52)
        Me.BuchTypDataGridView.Name = "BuchTypDataGridView"
        Me.BuchTypDataGridView.Size = New System.Drawing.Size(291, 338)
        Me.BuchTypDataGridView.TabIndex = 2
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BuchTyp"
        Me.DataGridViewTextBoxColumn2.HeaderText = "BuchTyp"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'BuchTypBindingSource
        '
        Me.BuchTypBindingSource.DataMember = "BuchTyp"
        Me.BuchTypBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        '_BookCMS_singleDataSet
        '
        Me._BookCMS_singleDataSet.DataSetName = "_BookCMS_singleDataSet"
        Me._BookCMS_singleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.BtClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 396)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(589, 51)
        Me.Panel1.TabIndex = 0
        '
        'BtClose
        '
        Me.BtClose.Location = New System.Drawing.Point(244, 19)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(106, 23)
        Me.BtClose.TabIndex = 0
        Me.BtClose.Text = "Zurück"
        Me.BtClose.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LblAnzahlZeichen)
        Me.Panel2.Controls.Add(IDLabel)
        Me.Panel2.Controls.Add(Me.IDTextBox)
        Me.Panel2.Controls.Add(MarkedLabel)
        Me.Panel2.Controls.Add(Me.MarkedCheckBox)
        Me.Panel2.Controls.Add(BuchTypLabel)
        Me.Panel2.Controls.Add(Me.BuchTypTextBox)
        Me.Panel2.Controls.Add(SortByLabel)
        Me.Panel2.Controls.Add(Me.SortByTextBox)
        Me.Panel2.Controls.Add(Notiz_PlainTextLabel)
        Me.Panel2.Controls.Add(Me.Notiz_PlainTextTextBox)
        Me.Panel2.Controls.Add(NeuLabel)
        Me.Panel2.Controls.Add(Me.NeuTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(300, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 338)
        Me.Panel2.TabIndex = 1
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchTypBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(115, 17)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(45, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'MarkedCheckBox
        '
        Me.MarkedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BuchTypBindingSource, "Marked", True))
        Me.MarkedCheckBox.Location = New System.Drawing.Point(115, 281)
        Me.MarkedCheckBox.Name = "MarkedCheckBox"
        Me.MarkedCheckBox.Size = New System.Drawing.Size(157, 24)
        Me.MarkedCheckBox.TabIndex = 3
        Me.MarkedCheckBox.UseVisualStyleBackColor = True
        '
        'BuchTypTextBox
        '
        Me.BuchTypTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchTypBindingSource, "BuchTyp", True))
        Me.BuchTypTextBox.Location = New System.Drawing.Point(115, 73)
        Me.BuchTypTextBox.Name = "BuchTypTextBox"
        Me.BuchTypTextBox.Size = New System.Drawing.Size(157, 20)
        Me.BuchTypTextBox.TabIndex = 5
        '
        'SortByTextBox
        '
        Me.SortByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchTypBindingSource, "SortBy", True))
        Me.SortByTextBox.Location = New System.Drawing.Point(115, 99)
        Me.SortByTextBox.Name = "SortByTextBox"
        Me.SortByTextBox.Size = New System.Drawing.Size(157, 20)
        Me.SortByTextBox.TabIndex = 7
        '
        'Notiz_PlainTextTextBox
        '
        Me.Notiz_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchTypBindingSource, "Notiz_PlainText", True))
        Me.Notiz_PlainTextTextBox.Location = New System.Drawing.Point(28, 144)
        Me.Notiz_PlainTextTextBox.Multiline = True
        Me.Notiz_PlainTextTextBox.Name = "Notiz_PlainTextTextBox"
        Me.Notiz_PlainTextTextBox.Size = New System.Drawing.Size(244, 66)
        Me.Notiz_PlainTextTextBox.TabIndex = 9
        '
        'NeuTextBox
        '
        Me.NeuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchTypBindingSource, "neu", True))
        Me.NeuTextBox.Location = New System.Drawing.Point(115, 255)
        Me.NeuTextBox.Name = "NeuTextBox"
        Me.NeuTextBox.Size = New System.Drawing.Size(157, 20)
        Me.NeuTextBox.TabIndex = 11
        '
        'BuchTypTableAdapter
        '
        Me.BuchTypTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutorBuchLinkTableAdapter = Nothing
        Me.TableAdapterManager.AutorRolleTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BibliothekTableAdapter = Nothing
        Me.TableAdapterManager.BindungTableAdapter = Nothing
        Me.TableAdapterManager.BuchTableAdapter = Nothing
        Me.TableAdapterManager.BuchTypTableAdapter = Me.BuchTypTableAdapter
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
        Me.TableAdapterManager.VerlagsOrtTableAdapter = Nothing
        Me.TableAdapterManager.VerlagTableAdapter = Nothing
        '
        'BuchTypBindingNavigator
        '
        Me.BuchTypBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BuchTypBindingNavigator.BindingSource = Me.BuchTypBindingSource
        Me.BuchTypBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BuchTypBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BuchTypBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BuchTypBindingNavigatorSaveItem})
        Me.BuchTypBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BuchTypBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BuchTypBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BuchTypBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BuchTypBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BuchTypBindingNavigator.Name = "BuchTypBindingNavigator"
        Me.BuchTypBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BuchTypBindingNavigator.Size = New System.Drawing.Size(595, 25)
        Me.BuchTypBindingNavigator.TabIndex = 1
        Me.BuchTypBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BuchTypBindingNavigatorSaveItem
        '
        Me.BuchTypBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BuchTypBindingNavigatorSaveItem.Image = CType(resources.GetObject("BuchTypBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BuchTypBindingNavigatorSaveItem.Name = "BuchTypBindingNavigatorSaveItem"
        Me.BuchTypBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BuchTypBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'LblAnzahlZeichen
        '
        Me.LblAnzahlZeichen.AutoSize = True
        Me.LblAnzahlZeichen.Location = New System.Drawing.Point(25, 213)
        Me.LblAnzahlZeichen.Name = "LblAnzahlZeichen"
        Me.LblAnzahlZeichen.Size = New System.Drawing.Size(93, 13)
        Me.LblAnzahlZeichen.TabIndex = 12
        Me.LblAnzahlZeichen.Text = "Max. 255 Zeichen"
        '
        'TypListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 450)
        Me.Controls.Add(Me.BuchTypBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "TypListe"
        Me.Text = "TypListe"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.BuchTypDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuchTypBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BuchTypBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BuchTypBindingNavigator.ResumeLayout(False)
        Me.BuchTypBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents BuchTypBindingSource As BindingSource
    Friend WithEvents BuchTypTableAdapter As _BookCMS_singleDataSetTableAdapters.BuchTypTableAdapter
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BuchTypBindingNavigator As BindingNavigator
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
    Friend WithEvents BuchTypBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BuchTypDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents MarkedCheckBox As CheckBox
    Friend WithEvents BuchTypTextBox As TextBox
    Friend WithEvents SortByTextBox As TextBox
    Friend WithEvents Notiz_PlainTextTextBox As TextBox
    Friend WithEvents NeuTextBox As TextBox
    Friend WithEvents BtClose As Button
    Friend WithEvents LblAnzahlZeichen As Label
End Class
