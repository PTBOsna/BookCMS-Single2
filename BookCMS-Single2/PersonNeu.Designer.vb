<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonNeu
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
        Dim PersonIDLabel As System.Windows.Forms.Label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersonNeu))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PersonIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SortByTextBox = New System.Windows.Forms.TextBox()
        Me.GeborenTextBox1 = New System.Windows.Forms.TextBox()
        Me.GestorbeTextBox1 = New System.Windows.Forms.TextBox()
        Me.LandIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.WWWTextBox1 = New System.Windows.Forms.TextBox()
        Me.EmailTextBox1 = New System.Windows.Forms.TextBox()
        Me.Adresse_PlainTextTextBox1 = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox1 = New System.Windows.Forms.TextBox()
        Me.FaxTextBox1 = New System.Windows.Forms.TextBox()
        Me.GeburtsnameTextBox1 = New System.Windows.Forms.TextBox()
        Me.GeburtzortTextBox1 = New System.Windows.Forms.TextBox()
        Me.SterbeortTextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Biografie_PlainTextRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Notiz_PlainTextRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PersonTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.PersonTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.cmsNotiz = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LandTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.LandTableAdapter()
        PersonIDLabel = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.cmsNotiz.SuspendLayout()
        Me.SuspendLayout()
        '
        'PersonIDLabel
        '
        PersonIDLabel.AutoSize = True
        PersonIDLabel.Location = New System.Drawing.Point(23, 15)
        PersonIDLabel.Name = "PersonIDLabel"
        PersonIDLabel.Size = New System.Drawing.Size(57, 13)
        PersonIDLabel.TabIndex = 0
        PersonIDLabel.Text = "Person ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(23, 38)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'SortByLabel
        '
        SortByLabel.AutoSize = True
        SortByLabel.Location = New System.Drawing.Point(23, 64)
        SortByLabel.Name = "SortByLabel"
        SortByLabel.Size = New System.Drawing.Size(44, 13)
        SortByLabel.TabIndex = 6
        SortByLabel.Text = "Sort By:"
        '
        'GeborenLabel
        '
        GeborenLabel.AutoSize = True
        GeborenLabel.Location = New System.Drawing.Point(23, 90)
        GeborenLabel.Name = "GeborenLabel"
        GeborenLabel.Size = New System.Drawing.Size(51, 13)
        GeborenLabel.TabIndex = 8
        GeborenLabel.Text = "Geboren:"
        '
        'GestorbeLabel
        '
        GestorbeLabel.AutoSize = True
        GestorbeLabel.Location = New System.Drawing.Point(23, 116)
        GestorbeLabel.Name = "GestorbeLabel"
        GestorbeLabel.Size = New System.Drawing.Size(59, 13)
        GestorbeLabel.TabIndex = 10
        GestorbeLabel.Text = "Gestorben:"
        '
        'LandIDLabel
        '
        LandIDLabel.AutoSize = True
        LandIDLabel.Location = New System.Drawing.Point(23, 142)
        LandIDLabel.Name = "LandIDLabel"
        LandIDLabel.Size = New System.Drawing.Size(60, 13)
        LandIDLabel.TabIndex = 12
        LandIDLabel.Text = "Nationalität"
        '
        'WWWLabel
        '
        WWWLabel.AutoSize = True
        WWWLabel.Location = New System.Drawing.Point(23, 169)
        WWWLabel.Name = "WWWLabel"
        WWWLabel.Size = New System.Drawing.Size(43, 13)
        WWWLabel.TabIndex = 16
        WWWLabel.Text = "WWW:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(23, 195)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 18
        EmailLabel.Text = "Email:"
        '
        'Adresse_PlainTextLabel
        '
        Adresse_PlainTextLabel.AutoSize = True
        Adresse_PlainTextLabel.Location = New System.Drawing.Point(23, 221)
        Adresse_PlainTextLabel.Name = "Adresse_PlainTextLabel"
        Adresse_PlainTextLabel.Size = New System.Drawing.Size(48, 13)
        Adresse_PlainTextLabel.TabIndex = 20
        Adresse_PlainTextLabel.Text = "Adresse:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(23, 292)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 22
        PhoneLabel.Text = "Phone:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(23, 318)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(27, 13)
        FaxLabel.TabIndex = 24
        FaxLabel.Text = "Fax:"
        '
        'GeburtsnameLabel
        '
        GeburtsnameLabel.AutoSize = True
        GeburtsnameLabel.Location = New System.Drawing.Point(23, 344)
        GeburtsnameLabel.Name = "GeburtsnameLabel"
        GeburtsnameLabel.Size = New System.Drawing.Size(73, 13)
        GeburtsnameLabel.TabIndex = 26
        GeburtsnameLabel.Text = "Geburtsname:"
        '
        'GeburtzortLabel
        '
        GeburtzortLabel.AutoSize = True
        GeburtzortLabel.Location = New System.Drawing.Point(23, 370)
        GeburtzortLabel.Name = "GeburtzortLabel"
        GeburtzortLabel.Size = New System.Drawing.Size(59, 13)
        GeburtzortLabel.TabIndex = 28
        GeburtzortLabel.Text = "Geburtsort:"
        '
        'SterbeortLabel
        '
        SterbeortLabel.AutoSize = True
        SterbeortLabel.Location = New System.Drawing.Point(23, 396)
        SterbeortLabel.Name = "SterbeortLabel"
        SterbeortLabel.Size = New System.Drawing.Size(53, 13)
        SterbeortLabel.TabIndex = 30
        SterbeortLabel.Text = "Sterbeort:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.625!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.375!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.977668!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.02233!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(478, 518)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(465, 451)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.ContextMenuStrip = Me.cmsNotiz
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(465, 451)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.PersonIDTextBox1)
        Me.TabPage1.Controls.Add(Me.NameTextBox)
        Me.TabPage1.Controls.Add(Me.SortByTextBox)
        Me.TabPage1.Controls.Add(Me.GeborenTextBox1)
        Me.TabPage1.Controls.Add(Me.GestorbeTextBox1)
        Me.TabPage1.Controls.Add(Me.LandIDTextBox1)
        Me.TabPage1.Controls.Add(Me.WWWTextBox1)
        Me.TabPage1.Controls.Add(Me.EmailTextBox1)
        Me.TabPage1.Controls.Add(Me.Adresse_PlainTextTextBox1)
        Me.TabPage1.Controls.Add(Me.PhoneTextBox1)
        Me.TabPage1.Controls.Add(Me.FaxTextBox1)
        Me.TabPage1.Controls.Add(Me.GeburtsnameTextBox1)
        Me.TabPage1.Controls.Add(Me.GeburtzortTextBox1)
        Me.TabPage1.Controls.Add(Me.SterbeortTextBox1)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(PersonIDLabel)
        Me.TabPage1.Controls.Add(NameLabel)
        Me.TabPage1.Controls.Add(SortByLabel)
        Me.TabPage1.Controls.Add(GeborenLabel)
        Me.TabPage1.Controls.Add(GestorbeLabel)
        Me.TabPage1.Controls.Add(LandIDLabel)
        Me.TabPage1.Controls.Add(WWWLabel)
        Me.TabPage1.Controls.Add(EmailLabel)
        Me.TabPage1.Controls.Add(Adresse_PlainTextLabel)
        Me.TabPage1.Controls.Add(PhoneLabel)
        Me.TabPage1.Controls.Add(FaxLabel)
        Me.TabPage1.Controls.Add(GeburtsnameLabel)
        Me.TabPage1.Controls.Add(GeburtzortLabel)
        Me.TabPage1.Controls.Add(SterbeortLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(457, 425)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PersonIDTextBox1
        '
        Me.PersonIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "PersonID", True))
        Me.PersonIDTextBox1.Location = New System.Drawing.Point(130, 12)
        Me.PersonIDTextBox1.Name = "PersonIDTextBox1"
        Me.PersonIDTextBox1.ReadOnly = True
        Me.PersonIDTextBox1.Size = New System.Drawing.Size(38, 20)
        Me.PersonIDTextBox1.TabIndex = 33
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
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(130, 38)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(210, 20)
        Me.NameTextBox.TabIndex = 37
        '
        'SortByTextBox
        '
        Me.SortByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "SortBy", True))
        Me.SortByTextBox.Location = New System.Drawing.Point(130, 61)
        Me.SortByTextBox.Name = "SortByTextBox"
        Me.SortByTextBox.Size = New System.Drawing.Size(210, 20)
        Me.SortByTextBox.TabIndex = 39
        '
        'GeborenTextBox1
        '
        Me.GeborenTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Geboren", True))
        Me.GeborenTextBox1.Location = New System.Drawing.Point(130, 87)
        Me.GeborenTextBox1.Name = "GeborenTextBox1"
        Me.GeborenTextBox1.Size = New System.Drawing.Size(210, 20)
        Me.GeborenTextBox1.TabIndex = 41
        '
        'GestorbeTextBox1
        '
        Me.GestorbeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Gestorbe", True))
        Me.GestorbeTextBox1.Location = New System.Drawing.Point(130, 113)
        Me.GestorbeTextBox1.Name = "GestorbeTextBox1"
        Me.GestorbeTextBox1.Size = New System.Drawing.Size(210, 20)
        Me.GestorbeTextBox1.TabIndex = 43
        '
        'LandIDTextBox1
        '
        Me.LandIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "LandID", True))
        Me.LandIDTextBox1.Location = New System.Drawing.Point(130, 139)
        Me.LandIDTextBox1.Name = "LandIDTextBox1"
        Me.LandIDTextBox1.Size = New System.Drawing.Size(38, 20)
        Me.LandIDTextBox1.TabIndex = 45
        '
        'WWWTextBox1
        '
        Me.WWWTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "WWW", True))
        Me.WWWTextBox1.Location = New System.Drawing.Point(130, 166)
        Me.WWWTextBox1.Name = "WWWTextBox1"
        Me.WWWTextBox1.Size = New System.Drawing.Size(210, 20)
        Me.WWWTextBox1.TabIndex = 49
        '
        'EmailTextBox1
        '
        Me.EmailTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Email", True))
        Me.EmailTextBox1.Location = New System.Drawing.Point(130, 192)
        Me.EmailTextBox1.Name = "EmailTextBox1"
        Me.EmailTextBox1.Size = New System.Drawing.Size(210, 20)
        Me.EmailTextBox1.TabIndex = 51
        '
        'Adresse_PlainTextTextBox1
        '
        Me.Adresse_PlainTextTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Adresse_PlainText", True))
        Me.Adresse_PlainTextTextBox1.Location = New System.Drawing.Point(130, 218)
        Me.Adresse_PlainTextTextBox1.Multiline = True
        Me.Adresse_PlainTextTextBox1.Name = "Adresse_PlainTextTextBox1"
        Me.Adresse_PlainTextTextBox1.Size = New System.Drawing.Size(210, 65)
        Me.Adresse_PlainTextTextBox1.TabIndex = 53
        '
        'PhoneTextBox1
        '
        Me.PhoneTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Phone", True))
        Me.PhoneTextBox1.Location = New System.Drawing.Point(130, 289)
        Me.PhoneTextBox1.Name = "PhoneTextBox1"
        Me.PhoneTextBox1.Size = New System.Drawing.Size(210, 20)
        Me.PhoneTextBox1.TabIndex = 55
        '
        'FaxTextBox1
        '
        Me.FaxTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Fax", True))
        Me.FaxTextBox1.Location = New System.Drawing.Point(130, 315)
        Me.FaxTextBox1.Name = "FaxTextBox1"
        Me.FaxTextBox1.Size = New System.Drawing.Size(210, 20)
        Me.FaxTextBox1.TabIndex = 57
        '
        'GeburtsnameTextBox1
        '
        Me.GeburtsnameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Geburtsname", True))
        Me.GeburtsnameTextBox1.Location = New System.Drawing.Point(130, 341)
        Me.GeburtsnameTextBox1.Name = "GeburtsnameTextBox1"
        Me.GeburtsnameTextBox1.Size = New System.Drawing.Size(210, 20)
        Me.GeburtsnameTextBox1.TabIndex = 59
        '
        'GeburtzortTextBox1
        '
        Me.GeburtzortTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Geburtzort", True))
        Me.GeburtzortTextBox1.Location = New System.Drawing.Point(130, 367)
        Me.GeburtzortTextBox1.Name = "GeburtzortTextBox1"
        Me.GeburtzortTextBox1.Size = New System.Drawing.Size(210, 20)
        Me.GeburtzortTextBox1.TabIndex = 61
        '
        'SterbeortTextBox1
        '
        Me.SterbeortTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Sterbeort", True))
        Me.SterbeortTextBox1.Location = New System.Drawing.Point(130, 393)
        Me.SterbeortTextBox1.Name = "SterbeortTextBox1"
        Me.SterbeortTextBox1.Size = New System.Drawing.Size(210, 20)
        Me.SterbeortTextBox1.TabIndex = 63
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PersonBindingSource, "LandID", True))
        Me.ComboBox1.DataSource = Me.LandBindingSource
        Me.ComboBox1.DisplayMember = "Print_Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(174, 138)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox1.TabIndex = 32
        Me.ComboBox1.ValueMember = "id"
        '
        'LandBindingSource
        '
        Me.LandBindingSource.DataMember = "Land"
        Me.LandBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Biografie_PlainTextRichTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(457, 425)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Biografie"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Biografie_PlainTextRichTextBox
        '
        Me.Biografie_PlainTextRichTextBox.ContextMenuStrip = Me.cmsNotiz
        Me.Biografie_PlainTextRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Biografie_PlainText", True))
        Me.Biografie_PlainTextRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Biografie_PlainTextRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.Biografie_PlainTextRichTextBox.Name = "Biografie_PlainTextRichTextBox"
        Me.Biografie_PlainTextRichTextBox.Size = New System.Drawing.Size(451, 419)
        Me.Biografie_PlainTextRichTextBox.TabIndex = 1
        Me.Biografie_PlainTextRichTextBox.Text = ""
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Notiz_PlainTextRichTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(457, 425)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Notizen"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Notiz_PlainTextRichTextBox
        '
        Me.Notiz_PlainTextRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Notiz_PlainText", True))
        Me.Notiz_PlainTextRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Notiz_PlainTextRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.Notiz_PlainTextRichTextBox.Name = "Notiz_PlainTextRichTextBox"
        Me.Notiz_PlainTextRichTextBox.Size = New System.Drawing.Size(451, 419)
        Me.Notiz_PlainTextRichTextBox.TabIndex = 1
        Me.Notiz_PlainTextRichTextBox.Text = ""
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 474)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(465, 41)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(193, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
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
        'LandTableAdapter
        '
        Me.LandTableAdapter.ClearBeforeFill = True
        '
        'PersonNeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 518)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "PersonNeu"
        Me.Text = "PersonNeu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.cmsNotiz.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Biografie_PlainTextRichTextBox As RichTextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Notiz_PlainTextRichTextBox As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents PersonBindingSource As BindingSource
    Friend WithEvents PersonTableAdapter As _BookCMS_singleDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PersonIDTextBox1 As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents SortByTextBox As TextBox
    Friend WithEvents GeborenTextBox1 As TextBox
    Friend WithEvents GestorbeTextBox1 As TextBox
    Friend WithEvents LandIDTextBox1 As TextBox
    Friend WithEvents WWWTextBox1 As TextBox
    Friend WithEvents EmailTextBox1 As TextBox
    Friend WithEvents Adresse_PlainTextTextBox1 As TextBox
    Friend WithEvents PhoneTextBox1 As TextBox
    Friend WithEvents FaxTextBox1 As TextBox
    Friend WithEvents GeburtsnameTextBox1 As TextBox
    Friend WithEvents GeburtzortTextBox1 As TextBox
    Friend WithEvents SterbeortTextBox1 As TextBox
    Friend WithEvents cmsNotiz As ContextMenuStrip
    Friend WithEvents EinfügenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AusschneidenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LandBindingSource As BindingSource
    Friend WithEvents LandTableAdapter As _BookCMS_singleDataSetTableAdapters.LandTableAdapter
End Class
