<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerlagListe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerlagListe))
        Dim PublisherIDLabel As System.Windows.Forms.Label
        Dim MarkedLabel As System.Windows.Forms.Label
        Dim VerlagLabel As System.Windows.Forms.Label
        Dim SortByLabel As System.Windows.Forms.Label
        Dim WWWLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Addresse_PlainTextLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtClose = New System.Windows.Forms.Button()
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.VerlagBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VerlagTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.VerlagTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.VerlagBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VerlagBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VerlagDataGridView = New System.Windows.Forms.DataGridView()
        Me.PublisherIDTextBox = New System.Windows.Forms.TextBox()
        Me.MarkedCheckBox = New System.Windows.Forms.CheckBox()
        Me.VerlagTextBox = New System.Windows.Forms.TextBox()
        Me.SortByTextBox = New System.Windows.Forms.TextBox()
        Me.WWWTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Addresse_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Notiz_PlainTextTextBox = New System.Windows.Forms.TextBox()
        PublisherIDLabel = New System.Windows.Forms.Label()
        MarkedLabel = New System.Windows.Forms.Label()
        VerlagLabel = New System.Windows.Forms.Label()
        SortByLabel = New System.Windows.Forms.Label()
        WWWLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Addresse_PlainTextLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerlagBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerlagBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VerlagBindingNavigator.SuspendLayout()
        CType(Me.VerlagDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.VerlagBindingNavigator, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.VerlagDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.33592!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.66409!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(670, 449)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.BtClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 404)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 42)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(PublisherIDLabel)
        Me.Panel2.Controls.Add(Me.PublisherIDTextBox)
        Me.Panel2.Controls.Add(MarkedLabel)
        Me.Panel2.Controls.Add(Me.MarkedCheckBox)
        Me.Panel2.Controls.Add(VerlagLabel)
        Me.Panel2.Controls.Add(Me.VerlagTextBox)
        Me.Panel2.Controls.Add(SortByLabel)
        Me.Panel2.Controls.Add(Me.SortByTextBox)
        Me.Panel2.Controls.Add(WWWLabel)
        Me.Panel2.Controls.Add(Me.WWWTextBox)
        Me.Panel2.Controls.Add(EmailLabel)
        Me.Panel2.Controls.Add(Me.EmailTextBox)
        Me.Panel2.Controls.Add(Addresse_PlainTextLabel)
        Me.Panel2.Controls.Add(Me.Addresse_PlainTextTextBox)
        Me.Panel2.Controls.Add(PhoneLabel)
        Me.Panel2.Controls.Add(Me.PhoneTextBox)
        Me.Panel2.Controls.Add(FaxLabel)
        Me.Panel2.Controls.Add(Me.FaxTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(315, 322)
        Me.Panel2.TabIndex = 1
        '
        'BtClose
        '
        Me.BtClose.Location = New System.Drawing.Point(291, 10)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(75, 23)
        Me.BtClose.TabIndex = 0
        Me.BtClose.Text = "Zurück"
        Me.BtClose.UseVisualStyleBackColor = True
        '
        '_BookCMS_singleDataSet
        '
        Me._BookCMS_singleDataSet.DataSetName = "_BookCMS_singleDataSet"
        Me._BookCMS_singleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VerlagBindingSource
        '
        Me.VerlagBindingSource.DataMember = "Verlag"
        Me.VerlagBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'VerlagTableAdapter
        '
        Me.VerlagTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.VerlagsOrtTableAdapter = Nothing
        Me.TableAdapterManager.VerlagTableAdapter = Me.VerlagTableAdapter
        '
        'VerlagBindingNavigator
        '
        Me.VerlagBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VerlagBindingNavigator.BindingSource = Me.VerlagBindingSource
        Me.TableLayoutPanel1.SetColumnSpan(Me.VerlagBindingNavigator, 2)
        Me.VerlagBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VerlagBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VerlagBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerlagBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VerlagBindingNavigatorSaveItem})
        Me.VerlagBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VerlagBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VerlagBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VerlagBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VerlagBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VerlagBindingNavigator.Name = "VerlagBindingNavigator"
        Me.VerlagBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VerlagBindingNavigator.Size = New System.Drawing.Size(670, 41)
        Me.VerlagBindingNavigator.TabIndex = 1
        Me.VerlagBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 38)
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
        'VerlagBindingNavigatorSaveItem
        '
        Me.VerlagBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VerlagBindingNavigatorSaveItem.Image = CType(resources.GetObject("VerlagBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VerlagBindingNavigatorSaveItem.Name = "VerlagBindingNavigatorSaveItem"
        Me.VerlagBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.VerlagBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'VerlagDataGridView
        '
        Me.VerlagDataGridView.AutoGenerateColumns = False
        Me.VerlagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VerlagDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5})
        Me.VerlagDataGridView.DataSource = Me.VerlagBindingSource
        Me.VerlagDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerlagDataGridView.Location = New System.Drawing.Point(3, 44)
        Me.VerlagDataGridView.Name = "VerlagDataGridView"
        Me.VerlagDataGridView.Size = New System.Drawing.Size(329, 354)
        Me.VerlagDataGridView.TabIndex = 2
        '
        'PublisherIDLabel
        '
        PublisherIDLabel.AutoSize = True
        PublisherIDLabel.Location = New System.Drawing.Point(21, 20)
        PublisherIDLabel.Name = "PublisherIDLabel"
        PublisherIDLabel.Size = New System.Drawing.Size(67, 13)
        PublisherIDLabel.TabIndex = 0
        PublisherIDLabel.Text = "Publisher ID:"
        '
        'PublisherIDTextBox
        '
        Me.PublisherIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "PublisherID", True))
        Me.PublisherIDTextBox.Location = New System.Drawing.Point(131, 17)
        Me.PublisherIDTextBox.Name = "PublisherIDTextBox"
        Me.PublisherIDTextBox.ReadOnly = True
        Me.PublisherIDTextBox.Size = New System.Drawing.Size(55, 20)
        Me.PublisherIDTextBox.TabIndex = 1
        '
        'MarkedLabel
        '
        MarkedLabel.AutoSize = True
        MarkedLabel.Location = New System.Drawing.Point(21, 286)
        MarkedLabel.Name = "MarkedLabel"
        MarkedLabel.Size = New System.Drawing.Size(48, 13)
        MarkedLabel.TabIndex = 2
        MarkedLabel.Text = "Markiert:"
        '
        'MarkedCheckBox
        '
        Me.MarkedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VerlagBindingSource, "Marked", True))
        Me.MarkedCheckBox.Location = New System.Drawing.Point(131, 281)
        Me.MarkedCheckBox.Name = "MarkedCheckBox"
        Me.MarkedCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.MarkedCheckBox.TabIndex = 3
        Me.MarkedCheckBox.UseVisualStyleBackColor = True
        '
        'VerlagLabel
        '
        VerlagLabel.AutoSize = True
        VerlagLabel.Location = New System.Drawing.Point(21, 76)
        VerlagLabel.Name = "VerlagLabel"
        VerlagLabel.Size = New System.Drawing.Size(40, 13)
        VerlagLabel.TabIndex = 4
        VerlagLabel.Text = "Verlag:"
        '
        'VerlagTextBox
        '
        Me.VerlagTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "Verlag", True))
        Me.VerlagTextBox.Location = New System.Drawing.Point(131, 73)
        Me.VerlagTextBox.Name = "VerlagTextBox"
        Me.VerlagTextBox.Size = New System.Drawing.Size(166, 20)
        Me.VerlagTextBox.TabIndex = 5
        '
        'SortByLabel
        '
        SortByLabel.AutoSize = True
        SortByLabel.Location = New System.Drawing.Point(21, 102)
        SortByLabel.Name = "SortByLabel"
        SortByLabel.Size = New System.Drawing.Size(43, 13)
        SortByLabel.TabIndex = 6
        SortByLabel.Text = "Sortiert:"
        '
        'SortByTextBox
        '
        Me.SortByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "SortBy", True))
        Me.SortByTextBox.Location = New System.Drawing.Point(131, 99)
        Me.SortByTextBox.Name = "SortByTextBox"
        Me.SortByTextBox.Size = New System.Drawing.Size(166, 20)
        Me.SortByTextBox.TabIndex = 7
        '
        'WWWLabel
        '
        WWWLabel.AutoSize = True
        WWWLabel.Location = New System.Drawing.Point(21, 131)
        WWWLabel.Name = "WWWLabel"
        WWWLabel.Size = New System.Drawing.Size(43, 13)
        WWWLabel.TabIndex = 10
        WWWLabel.Text = "WWW:"
        '
        'WWWTextBox
        '
        Me.WWWTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "WWW", True))
        Me.WWWTextBox.Location = New System.Drawing.Point(131, 128)
        Me.WWWTextBox.Name = "WWWTextBox"
        Me.WWWTextBox.Size = New System.Drawing.Size(166, 20)
        Me.WWWTextBox.TabIndex = 11
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(21, 157)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(131, 154)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(166, 20)
        Me.EmailTextBox.TabIndex = 13
        '
        'Addresse_PlainTextLabel
        '
        Addresse_PlainTextLabel.AutoSize = True
        Addresse_PlainTextLabel.Location = New System.Drawing.Point(21, 183)
        Addresse_PlainTextLabel.Name = "Addresse_PlainTextLabel"
        Addresse_PlainTextLabel.Size = New System.Drawing.Size(54, 13)
        Addresse_PlainTextLabel.TabIndex = 14
        Addresse_PlainTextLabel.Text = "Addresse:"
        '
        'Addresse_PlainTextTextBox
        '
        Me.Addresse_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "Addresse_PlainText", True))
        Me.Addresse_PlainTextTextBox.Location = New System.Drawing.Point(131, 180)
        Me.Addresse_PlainTextTextBox.Multiline = True
        Me.Addresse_PlainTextTextBox.Name = "Addresse_PlainTextTextBox"
        Me.Addresse_PlainTextTextBox.Size = New System.Drawing.Size(166, 44)
        Me.Addresse_PlainTextTextBox.TabIndex = 15
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(21, 233)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 16
        PhoneLabel.Text = "Phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(131, 230)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(166, 20)
        Me.PhoneTextBox.TabIndex = 17
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(21, 259)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(27, 13)
        FaxLabel.TabIndex = 18
        FaxLabel.Text = "Fax:"
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(131, 256)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(166, 20)
        Me.FaxTextBox.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PublisherID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PublisherID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Verlag"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Verlag"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 62
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "WWW"
        Me.DataGridViewTextBoxColumn5.HeaderText = "WWW"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(338, 44)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(329, 354)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(321, 328)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Übersicht"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Notiz_PlainTextTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(321, 328)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Notiz"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Notiz_PlainTextTextBox
        '
        Me.Notiz_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "Notiz_PlainText", True))
        Me.Notiz_PlainTextTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Notiz_PlainTextTextBox.Location = New System.Drawing.Point(3, 3)
        Me.Notiz_PlainTextTextBox.Multiline = True
        Me.Notiz_PlainTextTextBox.Name = "Notiz_PlainTextTextBox"
        Me.Notiz_PlainTextTextBox.Size = New System.Drawing.Size(315, 322)
        Me.Notiz_PlainTextTextBox.TabIndex = 1
        '
        'VerlagListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 449)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "VerlagListe"
        Me.Text = "VerlagListe"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerlagBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerlagBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VerlagBindingNavigator.ResumeLayout(False)
        Me.VerlagBindingNavigator.PerformLayout()
        CType(Me.VerlagDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtClose As Button
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents VerlagBindingSource As BindingSource
    Friend WithEvents VerlagTableAdapter As _BookCMS_singleDataSetTableAdapters.VerlagTableAdapter
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VerlagBindingNavigator As BindingNavigator
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
    Friend WithEvents VerlagBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VerlagDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PublisherIDTextBox As TextBox
    Friend WithEvents MarkedCheckBox As CheckBox
    Friend WithEvents VerlagTextBox As TextBox
    Friend WithEvents SortByTextBox As TextBox
    Friend WithEvents WWWTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Addresse_PlainTextTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents FaxTextBox As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Notiz_PlainTextTextBox As TextBox
End Class
