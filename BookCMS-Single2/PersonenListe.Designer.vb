<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonenListe
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim SortByLabel As System.Windows.Forms.Label
        Dim GeborenLabel As System.Windows.Forms.Label
        Dim GestorbeLabel As System.Windows.Forms.Label
        Dim LandIDLabel As System.Windows.Forms.Label
        Dim WWWLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Adresse_PlainTextLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim GeburtsnameLabel As System.Windows.Forms.Label
        Dim GeburtzortLabel As System.Windows.Forms.Label
        Dim SterbeortLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersonenListe))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PersonDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PersonIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SortByTextBox = New System.Windows.Forms.TextBox()
        Me.GeborenTextBox = New System.Windows.Forms.TextBox()
        Me.GestorbeTextBox = New System.Windows.Forms.TextBox()
        Me.LandIDTextBox = New System.Windows.Forms.TextBox()
        Me.WWWTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Adresse_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.GeburtsnameTextBox = New System.Windows.Forms.TextBox()
        Me.GeburtzortTextBox = New System.Windows.Forms.TextBox()
        Me.SterbeortTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Biografie_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Notiz_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PersonTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.PersonTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.PersonBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PersonBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.cmsNotiz = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        NameLabel = New System.Windows.Forms.Label()
        SortByLabel = New System.Windows.Forms.Label()
        GeborenLabel = New System.Windows.Forms.Label()
        GestorbeLabel = New System.Windows.Forms.Label()
        LandIDLabel = New System.Windows.Forms.Label()
        WWWLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Adresse_PlainTextLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        GeburtsnameLabel = New System.Windows.Forms.Label()
        GeburtzortLabel = New System.Windows.Forms.Label()
        SterbeortLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PersonDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PersonBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PersonBindingNavigator.SuspendLayout()
        Me.cmsNotiz.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(26, 38)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'SortByLabel
        '
        SortByLabel.AutoSize = True
        SortByLabel.Location = New System.Drawing.Point(26, 64)
        SortByLabel.Name = "SortByLabel"
        SortByLabel.Size = New System.Drawing.Size(73, 13)
        SortByLabel.TabIndex = 6
        SortByLabel.Text = "Sortiert nach:"
        '
        'GeborenLabel
        '
        GeborenLabel.AutoSize = True
        GeborenLabel.Location = New System.Drawing.Point(26, 127)
        GeborenLabel.Name = "GeborenLabel"
        GeborenLabel.Size = New System.Drawing.Size(51, 13)
        GeborenLabel.TabIndex = 8
        GeborenLabel.Text = "Geboren:"
        '
        'GestorbeLabel
        '
        GestorbeLabel.AutoSize = True
        GestorbeLabel.Location = New System.Drawing.Point(26, 386)
        GestorbeLabel.Name = "GestorbeLabel"
        GestorbeLabel.Size = New System.Drawing.Size(59, 13)
        GestorbeLabel.TabIndex = 10
        GestorbeLabel.Text = "Gestorben:"
        '
        'LandIDLabel
        '
        LandIDLabel.AutoSize = True
        LandIDLabel.Location = New System.Drawing.Point(26, 179)
        LandIDLabel.Name = "LandIDLabel"
        LandIDLabel.Size = New System.Drawing.Size(48, 13)
        LandIDLabel.TabIndex = 12
        LandIDLabel.Text = "Land ID:"
        '
        'WWWLabel
        '
        WWWLabel.AutoSize = True
        WWWLabel.Location = New System.Drawing.Point(26, 210)
        WWWLabel.Name = "WWWLabel"
        WWWLabel.Size = New System.Drawing.Size(43, 13)
        WWWLabel.TabIndex = 16
        WWWLabel.Text = "WWW:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(26, 236)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 18
        EmailLabel.Text = "Email:"
        '
        'Adresse_PlainTextLabel
        '
        Adresse_PlainTextLabel.AutoSize = True
        Adresse_PlainTextLabel.Location = New System.Drawing.Point(26, 269)
        Adresse_PlainTextLabel.Name = "Adresse_PlainTextLabel"
        Adresse_PlainTextLabel.Size = New System.Drawing.Size(48, 13)
        Adresse_PlainTextLabel.TabIndex = 20
        Adresse_PlainTextLabel.Text = "Anschrift"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(26, 334)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 22
        PhoneLabel.Text = "Phone:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(26, 360)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(27, 13)
        FaxLabel.TabIndex = 24
        FaxLabel.Text = "Fax:"
        '
        'GeburtsnameLabel
        '
        GeburtsnameLabel.AutoSize = True
        GeburtsnameLabel.Location = New System.Drawing.Point(26, 101)
        GeburtsnameLabel.Name = "GeburtsnameLabel"
        GeburtsnameLabel.Size = New System.Drawing.Size(73, 13)
        GeburtsnameLabel.TabIndex = 26
        GeburtsnameLabel.Text = "Geburtsname:"
        '
        'GeburtzortLabel
        '
        GeburtzortLabel.AutoSize = True
        GeburtzortLabel.Location = New System.Drawing.Point(26, 153)
        GeburtzortLabel.Name = "GeburtzortLabel"
        GeburtzortLabel.Size = New System.Drawing.Size(59, 13)
        GeburtzortLabel.TabIndex = 28
        GeburtzortLabel.Text = "Geburtzort:"
        '
        'SterbeortLabel
        '
        SterbeortLabel.AutoSize = True
        SterbeortLabel.Location = New System.Drawing.Point(26, 412)
        SterbeortLabel.Name = "SterbeortLabel"
        SterbeortLabel.Size = New System.Drawing.Size(53, 13)
        SterbeortLabel.TabIndex = 30
        SterbeortLabel.Text = "Sterbeort:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.94795!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.05205!))
        Me.TableLayoutPanel1.Controls.Add(Me.PersonDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.33334!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(903, 586)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PersonDataGridView
        '
        Me.PersonDataGridView.AutoGenerateColumns = False
        Me.PersonDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PersonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.PersonDataGridView.DataSource = Me.PersonBindingSource
        Me.PersonDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonDataGridView.Location = New System.Drawing.Point(3, 59)
        Me.PersonDataGridView.Name = "PersonDataGridView"
        Me.PersonDataGridView.Size = New System.Drawing.Size(435, 469)
        Me.PersonDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PersonID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PersonID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SortBy"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Angezeigt als"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Geboren"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Geboren"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Geburtsname"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Geburtsname"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Geburtzort"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Geburtsort"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        '_BookCMS_singleDataSet
        '
        Me._BookCMS_singleDataSet.DataSetName = "_BookCMS_singleDataSet"
        Me._BookCMS_singleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel2, 2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 534)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(897, 49)
        Me.Panel2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(374, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.ContextMenuStrip = Me.cmsNotiz
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(444, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(456, 469)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(448, 443)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Übersich"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.PersonIDTextBox)
        Me.Panel1.Controls.Add(NameLabel)
        Me.Panel1.Controls.Add(Me.NameTextBox)
        Me.Panel1.Controls.Add(SortByLabel)
        Me.Panel1.Controls.Add(Me.SortByTextBox)
        Me.Panel1.Controls.Add(GeborenLabel)
        Me.Panel1.Controls.Add(Me.GeborenTextBox)
        Me.Panel1.Controls.Add(GestorbeLabel)
        Me.Panel1.Controls.Add(Me.GestorbeTextBox)
        Me.Panel1.Controls.Add(LandIDLabel)
        Me.Panel1.Controls.Add(Me.LandIDTextBox)
        Me.Panel1.Controls.Add(WWWLabel)
        Me.Panel1.Controls.Add(Me.WWWTextBox)
        Me.Panel1.Controls.Add(EmailLabel)
        Me.Panel1.Controls.Add(Me.EmailTextBox)
        Me.Panel1.Controls.Add(Adresse_PlainTextLabel)
        Me.Panel1.Controls.Add(Me.Adresse_PlainTextTextBox)
        Me.Panel1.Controls.Add(PhoneLabel)
        Me.Panel1.Controls.Add(Me.PhoneTextBox)
        Me.Panel1.Controls.Add(FaxLabel)
        Me.Panel1.Controls.Add(Me.FaxTextBox)
        Me.Panel1.Controls.Add(GeburtsnameLabel)
        Me.Panel1.Controls.Add(Me.GeburtsnameTextBox)
        Me.Panel1.Controls.Add(GeburtzortLabel)
        Me.Panel1.Controls.Add(Me.GeburtzortTextBox)
        Me.Panel1.Controls.Add(SterbeortLabel)
        Me.Panel1.Controls.Add(Me.SterbeortTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 437)
        Me.Panel1.TabIndex = 1
        '
        'PersonIDTextBox
        '
        Me.PersonIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "PersonID", True))
        Me.PersonIDTextBox.Location = New System.Drawing.Point(29, 15)
        Me.PersonIDTextBox.Name = "PersonIDTextBox"
        Me.PersonIDTextBox.Size = New System.Drawing.Size(67, 20)
        Me.PersonIDTextBox.TabIndex = 1
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(133, 35)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(258, 20)
        Me.NameTextBox.TabIndex = 5
        '
        'SortByTextBox
        '
        Me.SortByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "SortBy", True))
        Me.SortByTextBox.Location = New System.Drawing.Point(133, 61)
        Me.SortByTextBox.Name = "SortByTextBox"
        Me.SortByTextBox.Size = New System.Drawing.Size(258, 20)
        Me.SortByTextBox.TabIndex = 7
        '
        'GeborenTextBox
        '
        Me.GeborenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Geboren", True))
        Me.GeborenTextBox.Location = New System.Drawing.Point(133, 124)
        Me.GeborenTextBox.Name = "GeborenTextBox"
        Me.GeborenTextBox.Size = New System.Drawing.Size(258, 20)
        Me.GeborenTextBox.TabIndex = 9
        '
        'GestorbeTextBox
        '
        Me.GestorbeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Gestorbe", True))
        Me.GestorbeTextBox.Location = New System.Drawing.Point(133, 383)
        Me.GestorbeTextBox.Name = "GestorbeTextBox"
        Me.GestorbeTextBox.Size = New System.Drawing.Size(258, 20)
        Me.GestorbeTextBox.TabIndex = 11
        '
        'LandIDTextBox
        '
        Me.LandIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "LandID", True))
        Me.LandIDTextBox.Location = New System.Drawing.Point(133, 176)
        Me.LandIDTextBox.Name = "LandIDTextBox"
        Me.LandIDTextBox.Size = New System.Drawing.Size(258, 20)
        Me.LandIDTextBox.TabIndex = 13
        '
        'WWWTextBox
        '
        Me.WWWTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "WWW", True))
        Me.WWWTextBox.Location = New System.Drawing.Point(133, 207)
        Me.WWWTextBox.Name = "WWWTextBox"
        Me.WWWTextBox.Size = New System.Drawing.Size(258, 20)
        Me.WWWTextBox.TabIndex = 17
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(133, 233)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(258, 20)
        Me.EmailTextBox.TabIndex = 19
        '
        'Adresse_PlainTextTextBox
        '
        Me.Adresse_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Adresse_PlainText", True))
        Me.Adresse_PlainTextTextBox.Location = New System.Drawing.Point(133, 266)
        Me.Adresse_PlainTextTextBox.Multiline = True
        Me.Adresse_PlainTextTextBox.Name = "Adresse_PlainTextTextBox"
        Me.Adresse_PlainTextTextBox.Size = New System.Drawing.Size(258, 59)
        Me.Adresse_PlainTextTextBox.TabIndex = 21
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(133, 331)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(258, 20)
        Me.PhoneTextBox.TabIndex = 23
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(133, 357)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(258, 20)
        Me.FaxTextBox.TabIndex = 25
        '
        'GeburtsnameTextBox
        '
        Me.GeburtsnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Geburtsname", True))
        Me.GeburtsnameTextBox.Location = New System.Drawing.Point(133, 98)
        Me.GeburtsnameTextBox.Name = "GeburtsnameTextBox"
        Me.GeburtsnameTextBox.Size = New System.Drawing.Size(258, 20)
        Me.GeburtsnameTextBox.TabIndex = 27
        '
        'GeburtzortTextBox
        '
        Me.GeburtzortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Geburtzort", True))
        Me.GeburtzortTextBox.Location = New System.Drawing.Point(133, 150)
        Me.GeburtzortTextBox.Name = "GeburtzortTextBox"
        Me.GeburtzortTextBox.Size = New System.Drawing.Size(258, 20)
        Me.GeburtzortTextBox.TabIndex = 29
        '
        'SterbeortTextBox
        '
        Me.SterbeortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Sterbeort", True))
        Me.SterbeortTextBox.Location = New System.Drawing.Point(133, 409)
        Me.SterbeortTextBox.Name = "SterbeortTextBox"
        Me.SterbeortTextBox.Size = New System.Drawing.Size(258, 20)
        Me.SterbeortTextBox.TabIndex = 31
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Biografie_PlainTextTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(448, 443)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Biografie"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Biografie_PlainTextTextBox
        '
        Me.Biografie_PlainTextTextBox.ContextMenuStrip = Me.cmsNotiz
        Me.Biografie_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Biografie_PlainText", True))
        Me.Biografie_PlainTextTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Biografie_PlainTextTextBox.Location = New System.Drawing.Point(3, 3)
        Me.Biografie_PlainTextTextBox.Multiline = True
        Me.Biografie_PlainTextTextBox.Name = "Biografie_PlainTextTextBox"
        Me.Biografie_PlainTextTextBox.Size = New System.Drawing.Size(442, 437)
        Me.Biografie_PlainTextTextBox.TabIndex = 35
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Notiz_PlainTextTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(448, 443)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Notizen"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Notiz_PlainTextTextBox
        '
        Me.Notiz_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Notiz_PlainText", True))
        Me.Notiz_PlainTextTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Notiz_PlainTextTextBox.Location = New System.Drawing.Point(0, 0)
        Me.Notiz_PlainTextTextBox.Multiline = True
        Me.Notiz_PlainTextTextBox.Name = "Notiz_PlainTextTextBox"
        Me.Notiz_PlainTextTextBox.Size = New System.Drawing.Size(448, 443)
        Me.Notiz_PlainTextTextBox.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(435, 50)
        Me.Panel3.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(167, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 19)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(44, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(97, 20)
        Me.TextBox1.TabIndex = 4
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PersonTableAdapter = Me.PersonTableAdapter
        Me.TableAdapterManager.SachgruppeTableAdapter = Nothing
        Me.TableAdapterManager.SerienTableAdapter = Nothing
        Me.TableAdapterManager.StandortTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VerlagsOrtTableAdapter = Nothing
        Me.TableAdapterManager.VerlagTableAdapter = Nothing
        '
        'PersonBindingNavigator
        '
        Me.PersonBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PersonBindingNavigator.BindingSource = Me.PersonBindingSource
        Me.PersonBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PersonBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PersonBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PersonBindingNavigatorSaveItem})
        Me.PersonBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PersonBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PersonBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PersonBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PersonBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PersonBindingNavigator.Name = "PersonBindingNavigator"
        Me.PersonBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PersonBindingNavigator.Size = New System.Drawing.Size(903, 25)
        Me.PersonBindingNavigator.TabIndex = 1
        Me.PersonBindingNavigator.Text = "BindingNavigator1"
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
        'PersonBindingNavigatorSaveItem
        '
        Me.PersonBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PersonBindingNavigatorSaveItem.Image = CType(resources.GetObject("PersonBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PersonBindingNavigatorSaveItem.Name = "PersonBindingNavigatorSaveItem"
        Me.PersonBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PersonBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'cmsNotiz
        '
        Me.cmsNotiz.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinfügenToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.AusschneidenToolStripMenuItem})
        Me.cmsNotiz.Name = "cmsNotiz"
        Me.cmsNotiz.Size = New System.Drawing.Size(149, 70)
        '
        'EinfügenToolStripMenuItem
        '
        Me.EinfügenToolStripMenuItem.Image = CType(resources.GetObject("EinfügenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.EinfügenToolStripMenuItem.Text = "Einfügen"
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.KopierenToolStripMenuItem.Text = "Kopieren"
        '
        'AusschneidenToolStripMenuItem
        '
        Me.AusschneidenToolStripMenuItem.Image = CType(resources.GetObject("AusschneidenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
        Me.AusschneidenToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AusschneidenToolStripMenuItem.Text = "Ausschneiden"
        '
        'PersonenListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 586)
        Me.Controls.Add(Me.PersonBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "PersonenListe"
        Me.Text = "PersonenListe"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PersonDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PersonBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PersonBindingNavigator.ResumeLayout(False)
        Me.PersonBindingNavigator.PerformLayout()
        Me.cmsNotiz.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents PersonBindingSource As BindingSource
    Friend WithEvents PersonTableAdapter As _BookCMS_singleDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PersonBindingNavigator As BindingNavigator
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
    Friend WithEvents PersonBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PersonDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PersonIDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents SortByTextBox As TextBox
    Friend WithEvents GeborenTextBox As TextBox
    Friend WithEvents GestorbeTextBox As TextBox
    Friend WithEvents LandIDTextBox As TextBox
    Friend WithEvents WWWTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Adresse_PlainTextTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents FaxTextBox As TextBox
    Friend WithEvents GeburtsnameTextBox As TextBox
    Friend WithEvents GeburtzortTextBox As TextBox
    Friend WithEvents SterbeortTextBox As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Biografie_PlainTextTextBox As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Notiz_PlainTextTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmsNotiz As ContextMenuStrip
    Friend WithEvents EinfügenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AusschneidenToolStripMenuItem As ToolStripMenuItem
End Class
