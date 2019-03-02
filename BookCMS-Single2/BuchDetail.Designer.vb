<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuchDetail
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
        Dim DNBLabel As System.Windows.Forms.Label
        Dim StandortIDLabel As System.Windows.Forms.Label
        Dim BarCodeLabel As System.Windows.Forms.Label
        Dim ASINLabel As System.Windows.Forms.Label
        Dim LetzteAenderungLabel As System.Windows.Forms.Label
        Dim AutorSortLabel As System.Windows.Forms.Label
        Dim VeroeffentlichtLabel As System.Windows.Forms.Label
        Dim CopyrightDatumLabel As System.Windows.Forms.Label
        Dim SerienIDLabel As System.Windows.Forms.Label
        Dim VerlagsOrtIDLabel As System.Windows.Forms.Label
        Dim StichworteLabel As System.Windows.Forms.Label
        Dim PrintingIDLabel As System.Windows.Forms.Label
        Dim AuflageIDLabel As System.Windows.Forms.Label
        Dim BindungIDLabel As System.Windows.Forms.Label
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim BuchTypLabel As System.Windows.Forms.Label
        Dim SachgruppeIDLabel As System.Windows.Forms.Label
        Dim DDCLabel As System.Windows.Forms.Label
        Dim DruckIDLabel As System.Windows.Forms.Label
        Dim AbschnitteLabel As System.Windows.Forms.Label
        Dim ZustandIDLabel As System.Windows.Forms.Label
        Dim ErworbenLabel As System.Windows.Forms.Label
        Dim VerkaufspreisLabel As System.Windows.Forms.Label
        Dim Dim_HeightLabel As System.Windows.Forms.Label
        Dim Synopsis_PlainTextLabel As System.Windows.Forms.Label
        Dim Reviews_PlainTextLabel As System.Windows.Forms.Label
        Dim Anmerkungen_PlainTextLabel As System.Windows.Forms.Label
        Dim TitelLabel As System.Windows.Forms.Label
        Dim UntertitelLabel As System.Windows.Forms.Label
        Dim SignaturLabel As System.Windows.Forms.Label
        Dim SeitenLabel As System.Windows.Forms.Label
        Dim OriginalTitelLabel As System.Windows.Forms.Label
        Dim OriginalUntertitelLabel As System.Windows.Forms.Label
        Dim OriginalLandIDLabel As System.Windows.Forms.Label
        Dim OriginalSpracheIDLabel As System.Windows.Forms.Label
        Dim OriginalCopyrightLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuchDetail))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.BtnAddAutor = New System.Windows.Forms.Button()
        Me.CBRolle = New System.Windows.Forms.ComboBox()
        Me.AutorRolleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.CBPerson = New System.Windows.Forms.ComboBox()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btPersonNeu = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtScann = New System.Windows.Forms.Button()
        Me.BookIDTextBox = New System.Windows.Forms.TextBox()
        Me.btClipbord = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.BuchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DruckereiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeitenTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.VerlagsOrtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImagePictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DNBTextBox = New System.Windows.Forms.TextBox()
        Me.AutorBuchLinkDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BuchIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.RolleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AutorBuchLinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.SerienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.LanguageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSprache = New System.Windows.Forms.Label()
        Me.AuflageTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.BindungBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.StandortBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VerliehenCheckBox = New System.Windows.Forms.CheckBox()
        Me.BarCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ASINTextBox = New System.Windows.Forms.TextBox()
        Me.LetzteAenderungDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AutorSortTextBox = New System.Windows.Forms.TextBox()
        Me.VeroeffentlichtTextBox = New System.Windows.Forms.TextBox()
        Me.CopyrightDatumTextBox = New System.Windows.Forms.TextBox()
        Me.StichworteTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbVerlag = New System.Windows.Forms.ComboBox()
        Me.VerlagBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GenreLinkDataGridView = New System.Windows.Forms.DataGridView()
        Me.BuchIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SachgruppeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreLinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.SachgruppeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.BuchTypBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DDCTextBox = New System.Windows.Forms.TextBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DruckIDTextBox = New System.Windows.Forms.TextBox()
        Me.AbschnitteTextBox = New System.Windows.Forms.TextBox()
        Me.ErworbenTextBox = New System.Windows.Forms.TextBox()
        Me.VerkaufspreisTextBox = New System.Windows.Forms.TextBox()
        Me.Dim_HeightTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.OriginalCopyrightTextBox = New System.Windows.Forms.TextBox()
        Me.OriginalSpracheIDTextBox = New System.Windows.Forms.TextBox()
        Me.OriginalLandIDTextBox = New System.Windows.Forms.TextBox()
        Me.OriginalUntertitelTextBox = New System.Windows.Forms.TextBox()
        Me.OriginalTitelTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Synopsis_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.Reviews_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.Anmerkungen_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtSaveImage = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblSpeicherOrt = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.MarkedCheckBox = New System.Windows.Forms.CheckBox()
        Me.UntertitelTextBox = New System.Windows.Forms.TextBox()
        Me.TitelTextBox = New System.Windows.Forms.TextBox()
        Me.SignaturTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btClose = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SpeichernToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DruckenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.AusschneidenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.KopierenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EinfügenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HilfeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.BuchTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.BuchTableAdapter()
        Me.AutorBuchLinkTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.AutorBuchLinkTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.BuchTypTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.BuchTypTableAdapter()
        Me.GenreLinkTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.GenreLinkTableAdapter()
        Me.SachgruppeTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.SachgruppeTableAdapter()
        Me.VerlagTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.VerlagTableAdapter()
        Me.VerlagsOrtTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.VerlagsOrtTableAdapter()
        Me.DruckereiTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.DruckereiTableAdapter()
        Me.StandortTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.StandortTableAdapter()
        Me.SerienTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.SerienTableAdapter()
        Me.LanguageTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.LanguageTableAdapter()
        Me.PersonTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.PersonTableAdapter()
        Me.AutorRolleTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.AutorRolleTableAdapter()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BindungTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.BindungTableAdapter()
        DNBLabel = New System.Windows.Forms.Label()
        StandortIDLabel = New System.Windows.Forms.Label()
        BarCodeLabel = New System.Windows.Forms.Label()
        ASINLabel = New System.Windows.Forms.Label()
        LetzteAenderungLabel = New System.Windows.Forms.Label()
        AutorSortLabel = New System.Windows.Forms.Label()
        VeroeffentlichtLabel = New System.Windows.Forms.Label()
        CopyrightDatumLabel = New System.Windows.Forms.Label()
        SerienIDLabel = New System.Windows.Forms.Label()
        VerlagsOrtIDLabel = New System.Windows.Forms.Label()
        StichworteLabel = New System.Windows.Forms.Label()
        PrintingIDLabel = New System.Windows.Forms.Label()
        AuflageIDLabel = New System.Windows.Forms.Label()
        BindungIDLabel = New System.Windows.Forms.Label()
        ISBNLabel = New System.Windows.Forms.Label()
        BuchTypLabel = New System.Windows.Forms.Label()
        SachgruppeIDLabel = New System.Windows.Forms.Label()
        DDCLabel = New System.Windows.Forms.Label()
        DruckIDLabel = New System.Windows.Forms.Label()
        AbschnitteLabel = New System.Windows.Forms.Label()
        ZustandIDLabel = New System.Windows.Forms.Label()
        ErworbenLabel = New System.Windows.Forms.Label()
        VerkaufspreisLabel = New System.Windows.Forms.Label()
        Dim_HeightLabel = New System.Windows.Forms.Label()
        Synopsis_PlainTextLabel = New System.Windows.Forms.Label()
        Reviews_PlainTextLabel = New System.Windows.Forms.Label()
        Anmerkungen_PlainTextLabel = New System.Windows.Forms.Label()
        TitelLabel = New System.Windows.Forms.Label()
        UntertitelLabel = New System.Windows.Forms.Label()
        SignaturLabel = New System.Windows.Forms.Label()
        SeitenLabel = New System.Windows.Forms.Label()
        OriginalTitelLabel = New System.Windows.Forms.Label()
        OriginalUntertitelLabel = New System.Windows.Forms.Label()
        OriginalLandIDLabel = New System.Windows.Forms.Label()
        OriginalSpracheIDLabel = New System.Windows.Forms.Label()
        OriginalCopyrightLabel = New System.Windows.Forms.Label()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.AutorRolleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DruckereiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerlagsOrtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorBuchLinkDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorBuchLinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SerienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LanguageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindungBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandortBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerlagBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.GenreLinkDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenreLinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SachgruppeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuchTypBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DNBLabel
        '
        DNBLabel.AutoSize = True
        DNBLabel.Location = New System.Drawing.Point(424, 202)
        DNBLabel.Name = "DNBLabel"
        DNBLabel.Size = New System.Drawing.Size(33, 13)
        DNBLabel.TabIndex = 172
        DNBLabel.Text = "DNB:"
        '
        'StandortIDLabel
        '
        StandortIDLabel.AutoSize = True
        StandortIDLabel.Location = New System.Drawing.Point(43, 358)
        StandortIDLabel.Name = "StandortIDLabel"
        StandortIDLabel.Size = New System.Drawing.Size(50, 13)
        StandortIDLabel.TabIndex = 92
        StandortIDLabel.Text = "Standort:"
        '
        'BarCodeLabel
        '
        BarCodeLabel.AutoSize = True
        BarCodeLabel.Location = New System.Drawing.Point(403, 151)
        BarCodeLabel.Name = "BarCodeLabel"
        BarCodeLabel.Size = New System.Drawing.Size(54, 13)
        BarCodeLabel.TabIndex = 100
        BarCodeLabel.Text = "Bar Code:"
        '
        'ASINLabel
        '
        ASINLabel.AutoSize = True
        ASINLabel.Location = New System.Drawing.Point(422, 177)
        ASINLabel.Name = "ASINLabel"
        ASINLabel.Size = New System.Drawing.Size(35, 13)
        ASINLabel.TabIndex = 114
        ASINLabel.Text = "ASIN:"
        '
        'LetzteAenderungLabel
        '
        LetzteAenderungLabel.AutoSize = True
        LetzteAenderungLabel.Location = New System.Drawing.Point(363, 309)
        LetzteAenderungLabel.Name = "LetzteAenderungLabel"
        LetzteAenderungLabel.Size = New System.Drawing.Size(94, 13)
        LetzteAenderungLabel.TabIndex = 116
        LetzteAenderungLabel.Text = "Letzte Aenderung:"
        '
        'AutorSortLabel
        '
        AutorSortLabel.AutoSize = True
        AutorSortLabel.Location = New System.Drawing.Point(36, 171)
        AutorSortLabel.Name = "AutorSortLabel"
        AutorSortLabel.Size = New System.Drawing.Size(57, 13)
        AutorSortLabel.TabIndex = 124
        AutorSortLabel.Text = "Autor Sort:"
        '
        'VeroeffentlichtLabel
        '
        VeroeffentlichtLabel.AutoSize = True
        VeroeffentlichtLabel.Location = New System.Drawing.Point(15, 305)
        VeroeffentlichtLabel.Name = "VeroeffentlichtLabel"
        VeroeffentlichtLabel.Size = New System.Drawing.Size(78, 13)
        VeroeffentlichtLabel.TabIndex = 126
        VeroeffentlichtLabel.Text = "Veroeffentlicht:"
        '
        'CopyrightDatumLabel
        '
        CopyrightDatumLabel.AutoSize = True
        CopyrightDatumLabel.Location = New System.Drawing.Point(5, 331)
        CopyrightDatumLabel.Name = "CopyrightDatumLabel"
        CopyrightDatumLabel.Size = New System.Drawing.Size(88, 13)
        CopyrightDatumLabel.TabIndex = 128
        CopyrightDatumLabel.Text = "Copyright Datum:"
        '
        'SerienIDLabel
        '
        SerienIDLabel.AutoSize = True
        SerienIDLabel.Location = New System.Drawing.Point(423, 17)
        SerienIDLabel.Name = "SerienIDLabel"
        SerienIDLabel.Size = New System.Drawing.Size(34, 13)
        SerienIDLabel.TabIndex = 136
        SerienIDLabel.Text = "Serie:"
        '
        'VerlagsOrtIDLabel
        '
        VerlagsOrtIDLabel.AutoSize = True
        VerlagsOrtIDLabel.Location = New System.Drawing.Point(31, 225)
        VerlagsOrtIDLabel.Name = "VerlagsOrtIDLabel"
        VerlagsOrtIDLabel.Size = New System.Drawing.Size(62, 13)
        VerlagsOrtIDLabel.TabIndex = 150
        VerlagsOrtIDLabel.Text = "Verlags Ort:"
        '
        'StichworteLabel
        '
        StichworteLabel.AutoSize = True
        StichworteLabel.Location = New System.Drawing.Point(33, 408)
        StichworteLabel.Name = "StichworteLabel"
        StichworteLabel.Size = New System.Drawing.Size(60, 13)
        StichworteLabel.TabIndex = 152
        StichworteLabel.Text = "Stichworte:"
        '
        'PrintingIDLabel
        '
        PrintingIDLabel.AutoSize = True
        PrintingIDLabel.Location = New System.Drawing.Point(37, 254)
        PrintingIDLabel.Name = "PrintingIDLabel"
        PrintingIDLabel.Size = New System.Drawing.Size(56, 13)
        PrintingIDLabel.TabIndex = 36
        PrintingIDLabel.Text = "Druckerei:"
        '
        'AuflageIDLabel
        '
        AuflageIDLabel.AutoSize = True
        AuflageIDLabel.Location = New System.Drawing.Point(411, 42)
        AuflageIDLabel.Name = "AuflageIDLabel"
        AuflageIDLabel.Size = New System.Drawing.Size(46, 13)
        AuflageIDLabel.TabIndex = 34
        AuflageIDLabel.Text = "Auflage:"
        '
        'BindungIDLabel
        '
        BindungIDLabel.AutoSize = True
        BindungIDLabel.Location = New System.Drawing.Point(44, 279)
        BindungIDLabel.Name = "BindungIDLabel"
        BindungIDLabel.Size = New System.Drawing.Size(49, 13)
        BindungIDLabel.TabIndex = 32
        BindungIDLabel.Text = "Bindung:"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(422, 125)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(35, 13)
        ISBNLabel.TabIndex = 18
        ISBNLabel.Text = "ISBN:"
        '
        'BuchTypLabel
        '
        BuchTypLabel.AutoSize = True
        BuchTypLabel.Location = New System.Drawing.Point(30, 8)
        BuchTypLabel.Name = "BuchTypLabel"
        BuchTypLabel.Size = New System.Drawing.Size(56, 13)
        BuchTypLabel.TabIndex = 47
        BuchTypLabel.Text = "Buch Typ:"
        '
        'SachgruppeIDLabel
        '
        SachgruppeIDLabel.AutoSize = True
        SachgruppeIDLabel.Location = New System.Drawing.Point(15, 34)
        SachgruppeIDLabel.Name = "SachgruppeIDLabel"
        SachgruppeIDLabel.Size = New System.Drawing.Size(71, 13)
        SachgruppeIDLabel.TabIndex = 122
        SachgruppeIDLabel.Text = "Sachgruppe :"
        '
        'DDCLabel
        '
        DDCLabel.AutoSize = True
        DDCLabel.Location = New System.Drawing.Point(353, 6)
        DDCLabel.Name = "DDCLabel"
        DDCLabel.Size = New System.Drawing.Size(33, 13)
        DDCLabel.TabIndex = 132
        DDCLabel.Text = "DDC:"
        '
        'DruckIDLabel
        '
        DruckIDLabel.AutoSize = True
        DruckIDLabel.Location = New System.Drawing.Point(26, 159)
        DruckIDLabel.Name = "DruckIDLabel"
        DruckIDLabel.Size = New System.Drawing.Size(53, 13)
        DruckIDLabel.TabIndex = 150
        DruckIDLabel.Text = "Druck ID:"
        '
        'AbschnitteLabel
        '
        AbschnitteLabel.AutoSize = True
        AbschnitteLabel.Location = New System.Drawing.Point(26, 211)
        AbschnitteLabel.Name = "AbschnitteLabel"
        AbschnitteLabel.Size = New System.Drawing.Size(60, 13)
        AbschnitteLabel.TabIndex = 152
        AbschnitteLabel.Text = "Abschnitte:"
        '
        'ZustandIDLabel
        '
        ZustandIDLabel.AutoSize = True
        ZustandIDLabel.Location = New System.Drawing.Point(26, 237)
        ZustandIDLabel.Name = "ZustandIDLabel"
        ZustandIDLabel.Size = New System.Drawing.Size(63, 13)
        ZustandIDLabel.TabIndex = 154
        ZustandIDLabel.Text = "Zustand ID:"
        '
        'ErworbenLabel
        '
        ErworbenLabel.AutoSize = True
        ErworbenLabel.Location = New System.Drawing.Point(382, 34)
        ErworbenLabel.Name = "ErworbenLabel"
        ErworbenLabel.Size = New System.Drawing.Size(55, 13)
        ErworbenLabel.TabIndex = 146
        ErworbenLabel.Text = "Erworben:"
        '
        'VerkaufspreisLabel
        '
        VerkaufspreisLabel.AutoSize = True
        VerkaufspreisLabel.Location = New System.Drawing.Point(382, 89)
        VerkaufspreisLabel.Name = "VerkaufspreisLabel"
        VerkaufspreisLabel.Size = New System.Drawing.Size(74, 13)
        VerkaufspreisLabel.TabIndex = 116
        VerkaufspreisLabel.Text = "Verkaufspreis:"
        '
        'Dim_HeightLabel
        '
        Dim_HeightLabel.AutoSize = True
        Dim_HeightLabel.Location = New System.Drawing.Point(26, 34)
        Dim_HeightLabel.Name = "Dim_HeightLabel"
        Dim_HeightLabel.Size = New System.Drawing.Size(62, 13)
        Dim_HeightLabel.TabIndex = 112
        Dim_HeightLabel.Text = "Dim Height:"
        '
        'Synopsis_PlainTextLabel
        '
        Synopsis_PlainTextLabel.AutoSize = True
        Synopsis_PlainTextLabel.Location = New System.Drawing.Point(429, 21)
        Synopsis_PlainTextLabel.Name = "Synopsis_PlainTextLabel"
        Synopsis_PlainTextLabel.Size = New System.Drawing.Size(51, 13)
        Synopsis_PlainTextLabel.TabIndex = 103
        Synopsis_PlainTextLabel.Text = "Synopse:"
        '
        'Reviews_PlainTextLabel
        '
        Reviews_PlainTextLabel.AutoSize = True
        Reviews_PlainTextLabel.Location = New System.Drawing.Point(84, 493)
        Reviews_PlainTextLabel.Name = "Reviews_PlainTextLabel"
        Reviews_PlainTextLabel.Size = New System.Drawing.Size(101, 13)
        Reviews_PlainTextLabel.TabIndex = 100
        Reviews_PlainTextLabel.Text = "Reviews Plain Text:"
        '
        'Anmerkungen_PlainTextLabel
        '
        Anmerkungen_PlainTextLabel.AutoSize = True
        Anmerkungen_PlainTextLabel.Location = New System.Drawing.Point(21, 21)
        Anmerkungen_PlainTextLabel.Name = "Anmerkungen_PlainTextLabel"
        Anmerkungen_PlainTextLabel.Size = New System.Drawing.Size(76, 13)
        Anmerkungen_PlainTextLabel.TabIndex = 2
        Anmerkungen_PlainTextLabel.Text = "Anmerkungen:"
        '
        'TitelLabel
        '
        TitelLabel.AutoSize = True
        TitelLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TitelLabel.Location = New System.Drawing.Point(41, 13)
        TitelLabel.Name = "TitelLabel"
        TitelLabel.Size = New System.Drawing.Size(30, 13)
        TitelLabel.TabIndex = 0
        TitelLabel.Text = "Titel:"
        '
        'UntertitelLabel
        '
        UntertitelLabel.AutoSize = True
        UntertitelLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        UntertitelLabel.Location = New System.Drawing.Point(19, 39)
        UntertitelLabel.Name = "UntertitelLabel"
        UntertitelLabel.Size = New System.Drawing.Size(52, 13)
        UntertitelLabel.TabIndex = 12
        UntertitelLabel.Text = "Untertitel:"
        '
        'SignaturLabel
        '
        SignaturLabel.AutoSize = True
        SignaturLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        SignaturLabel.Location = New System.Drawing.Point(685, 13)
        SignaturLabel.Name = "SignaturLabel"
        SignaturLabel.Size = New System.Drawing.Size(49, 13)
        SignaturLabel.TabIndex = 4
        SignaturLabel.Text = "Signatur:"
        '
        'SeitenLabel
        '
        SeitenLabel.AutoSize = True
        SeitenLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        SeitenLabel.Location = New System.Drawing.Point(417, 96)
        SeitenLabel.Name = "SeitenLabel"
        SeitenLabel.Size = New System.Drawing.Size(40, 13)
        SeitenLabel.TabIndex = 40
        SeitenLabel.Text = "Seiten:"
        '
        'OriginalTitelLabel
        '
        OriginalTitelLabel.AutoSize = True
        OriginalTitelLabel.Location = New System.Drawing.Point(48, 40)
        OriginalTitelLabel.Name = "OriginalTitelLabel"
        OriginalTitelLabel.Size = New System.Drawing.Size(68, 13)
        OriginalTitelLabel.TabIndex = 0
        OriginalTitelLabel.Text = "Original Titel:"
        '
        'OriginalUntertitelLabel
        '
        OriginalUntertitelLabel.AutoSize = True
        OriginalUntertitelLabel.Location = New System.Drawing.Point(48, 81)
        OriginalUntertitelLabel.Name = "OriginalUntertitelLabel"
        OriginalUntertitelLabel.Size = New System.Drawing.Size(90, 13)
        OriginalUntertitelLabel.TabIndex = 2
        OriginalUntertitelLabel.Text = "Original Untertitel:"
        '
        'OriginalLandIDLabel
        '
        OriginalLandIDLabel.AutoSize = True
        OriginalLandIDLabel.Location = New System.Drawing.Point(48, 129)
        OriginalLandIDLabel.Name = "OriginalLandIDLabel"
        OriginalLandIDLabel.Size = New System.Drawing.Size(86, 13)
        OriginalLandIDLabel.TabIndex = 4
        OriginalLandIDLabel.Text = "Original Land ID:"
        '
        'OriginalSpracheIDLabel
        '
        OriginalSpracheIDLabel.AutoSize = True
        OriginalSpracheIDLabel.Location = New System.Drawing.Point(48, 184)
        OriginalSpracheIDLabel.Name = "OriginalSpracheIDLabel"
        OriginalSpracheIDLabel.Size = New System.Drawing.Size(102, 13)
        OriginalSpracheIDLabel.TabIndex = 6
        OriginalSpracheIDLabel.Text = "Original Sprache ID:"
        '
        'OriginalCopyrightLabel
        '
        OriginalCopyrightLabel.AutoSize = True
        OriginalCopyrightLabel.Location = New System.Drawing.Point(48, 234)
        OriginalCopyrightLabel.Name = "OriginalCopyrightLabel"
        OriginalCopyrightLabel.Size = New System.Drawing.Size(92, 13)
        OriginalCopyrightLabel.TabIndex = 8
        OriginalCopyrightLabel.Text = "Original Copyright:"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1201, 609)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1201, 648)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.84134!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.94892!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.05108!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1201, 609)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 82)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1195, 486)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage1.Controls.Add(Me.BtnDel)
        Me.TabPage1.Controls.Add(Me.BtnAddAutor)
        Me.TabPage1.Controls.Add(Me.CBRolle)
        Me.TabPage1.Controls.Add(Me.CBPerson)
        Me.TabPage1.Controls.Add(Me.btPersonNeu)
        Me.TabPage1.Controls.Add(Me.ComboBox2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.BtScann)
        Me.TabPage1.Controls.Add(Me.BookIDTextBox)
        Me.TabPage1.Controls.Add(Me.btClipbord)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.ComboBox5)
        Me.TabPage1.Controls.Add(Me.SeitenTextBox)
        Me.TabPage1.Controls.Add(SeitenLabel)
        Me.TabPage1.Controls.Add(Me.ComboBox11)
        Me.TabPage1.Controls.Add(Me.ImagePictureBox1)
        Me.TabPage1.Controls.Add(DNBLabel)
        Me.TabPage1.Controls.Add(Me.DNBTextBox)
        Me.TabPage1.Controls.Add(Me.AutorBuchLinkDataGridView1)
        Me.TabPage1.Controls.Add(Me.ComboBox12)
        Me.TabPage1.Controls.Add(Me.ComboBox9)
        Me.TabPage1.Controls.Add(Me.lblSprache)
        Me.TabPage1.Controls.Add(Me.AuflageTextBox)
        Me.TabPage1.Controls.Add(Me.ComboBox8)
        Me.TabPage1.Controls.Add(Me.ComboBox7)
        Me.TabPage1.Controls.Add(Me.VerliehenCheckBox)
        Me.TabPage1.Controls.Add(StandortIDLabel)
        Me.TabPage1.Controls.Add(BarCodeLabel)
        Me.TabPage1.Controls.Add(Me.BarCodeTextBox)
        Me.TabPage1.Controls.Add(ASINLabel)
        Me.TabPage1.Controls.Add(Me.ASINTextBox)
        Me.TabPage1.Controls.Add(LetzteAenderungLabel)
        Me.TabPage1.Controls.Add(Me.LetzteAenderungDateTimePicker)
        Me.TabPage1.Controls.Add(AutorSortLabel)
        Me.TabPage1.Controls.Add(Me.AutorSortTextBox)
        Me.TabPage1.Controls.Add(VeroeffentlichtLabel)
        Me.TabPage1.Controls.Add(Me.VeroeffentlichtTextBox)
        Me.TabPage1.Controls.Add(CopyrightDatumLabel)
        Me.TabPage1.Controls.Add(Me.CopyrightDatumTextBox)
        Me.TabPage1.Controls.Add(SerienIDLabel)
        Me.TabPage1.Controls.Add(VerlagsOrtIDLabel)
        Me.TabPage1.Controls.Add(StichworteLabel)
        Me.TabPage1.Controls.Add(Me.StichworteTextBox)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.CbVerlag)
        Me.TabPage1.Controls.Add(PrintingIDLabel)
        Me.TabPage1.Controls.Add(AuflageIDLabel)
        Me.TabPage1.Controls.Add(BindungIDLabel)
        Me.TabPage1.Controls.Add(ISBNLabel)
        Me.TabPage1.Controls.Add(Me.ISBNTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1187, 460)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Übersicht"
        '
        'BtnDel
        '
        Me.BtnDel.Location = New System.Drawing.Point(194, 43)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(111, 27)
        Me.BtnDel.TabIndex = 198
        Me.BtnDel.Text = "Entfernen"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnAddAutor
        '
        Me.BtnAddAutor.Location = New System.Drawing.Point(40, 43)
        Me.BtnAddAutor.Name = "BtnAddAutor"
        Me.BtnAddAutor.Size = New System.Drawing.Size(111, 27)
        Me.BtnAddAutor.TabIndex = 197
        Me.BtnAddAutor.Text = "Übernehmen"
        Me.BtnAddAutor.UseVisualStyleBackColor = True
        '
        'CBRolle
        '
        Me.CBRolle.DataSource = Me.AutorRolleBindingSource
        Me.CBRolle.DisplayMember = "AutorRolle"
        Me.CBRolle.FormattingEnabled = True
        Me.CBRolle.Location = New System.Drawing.Point(203, 17)
        Me.CBRolle.Name = "CBRolle"
        Me.CBRolle.Size = New System.Drawing.Size(102, 21)
        Me.CBRolle.TabIndex = 196
        Me.CBRolle.ValueMember = "ID"
        '
        'AutorRolleBindingSource
        '
        Me.AutorRolleBindingSource.DataMember = "AutorRolle"
        Me.AutorRolleBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        '_BookCMS_singleDataSet
        '
        Me._BookCMS_singleDataSet.DataSetName = "_BookCMS_singleDataSet"
        Me._BookCMS_singleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CBPerson
        '
        Me.CBPerson.DataSource = Me.PersonBindingSource
        Me.CBPerson.DisplayMember = "SortBy"
        Me.CBPerson.FormattingEnabled = True
        Me.CBPerson.Location = New System.Drawing.Point(40, 17)
        Me.CBPerson.Name = "CBPerson"
        Me.CBPerson.Size = New System.Drawing.Size(157, 21)
        Me.CBPerson.TabIndex = 195
        Me.CBPerson.ValueMember = "PersonID"
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'btPersonNeu
        '
        Me.btPersonNeu.Location = New System.Drawing.Point(318, 8)
        Me.btPersonNeu.Name = "btPersonNeu"
        Me.btPersonNeu.Size = New System.Drawing.Size(75, 37)
        Me.btPersonNeu.TabIndex = 194
        Me.btPersonNeu.Text = "Neue Person"
        Me.btPersonNeu.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(472, 66)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 183
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(917, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 182
        Me.Label4.Text = "oder"
        '
        'BtScann
        '
        Me.BtScann.Location = New System.Drawing.Point(862, 56)
        Me.BtScann.Name = "BtScann"
        Me.BtScann.Size = New System.Drawing.Size(141, 31)
        Me.BtScann.TabIndex = 180
        Me.BtScann.Text = "Cover scannen"
        Me.BtScann.UseVisualStyleBackColor = True
        '
        'BookIDTextBox
        '
        Me.BookIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BookIDTextBox.Location = New System.Drawing.Point(714, 305)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.ReadOnly = True
        Me.BookIDTextBox.Size = New System.Drawing.Size(72, 20)
        Me.BookIDTextBox.TabIndex = 179
        '
        'btClipbord
        '
        Me.btClipbord.Location = New System.Drawing.Point(862, 105)
        Me.btClipbord.Name = "btClipbord"
        Me.btClipbord.Size = New System.Drawing.Size(141, 31)
        Me.btClipbord.TabIndex = 178
        Me.btClipbord.Text = "Einfügen aus Clippbord"
        Me.btClipbord.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1020, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 177
        Me.PictureBox1.TabStop = False
        '
        'ComboBox5
        '
        Me.ComboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "DruckereiID", True))
        Me.ComboBox5.DataSource = Me.DruckereiBindingSource
        Me.ComboBox5.DisplayMember = "Druckerei"
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(106, 249)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox5.TabIndex = 176
        Me.ComboBox5.ValueMember = "PrintedByID"
        '
        'BuchBindingSource
        '
        Me.BuchBindingSource.DataMember = "Buch"
        Me.BuchBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'DruckereiBindingSource
        '
        Me.DruckereiBindingSource.DataMember = "Druckerei"
        Me.DruckereiBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'SeitenTextBox
        '
        Me.SeitenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Seiten", True))
        Me.SeitenTextBox.Location = New System.Drawing.Point(472, 93)
        Me.SeitenTextBox.Name = "SeitenTextBox"
        Me.SeitenTextBox.Size = New System.Drawing.Size(60, 20)
        Me.SeitenTextBox.TabIndex = 41
        '
        'ComboBox11
        '
        Me.ComboBox11.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox11.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox11.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "VerlagsOrtID", True))
        Me.ComboBox11.DataSource = Me.VerlagsOrtBindingSource
        Me.ComboBox11.DisplayMember = "Verlagsort"
        Me.ComboBox11.FormattingEnabled = True
        Me.ComboBox11.Location = New System.Drawing.Point(106, 220)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox11.TabIndex = 175
        Me.ComboBox11.ValueMember = "ID"
        '
        'VerlagsOrtBindingSource
        '
        Me.VerlagsOrtBindingSource.DataMember = "VerlagsOrt"
        Me.VerlagsOrtBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'ImagePictureBox1
        '
        Me.ImagePictureBox1.Location = New System.Drawing.Point(714, 57)
        Me.ImagePictureBox1.Name = "ImagePictureBox1"
        Me.ImagePictureBox1.Size = New System.Drawing.Size(142, 190)
        Me.ImagePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagePictureBox1.TabIndex = 174
        Me.ImagePictureBox1.TabStop = False
        '
        'DNBTextBox
        '
        Me.DNBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "DNB", True))
        Me.DNBTextBox.Location = New System.Drawing.Point(472, 199)
        Me.DNBTextBox.Name = "DNBTextBox"
        Me.DNBTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DNBTextBox.TabIndex = 173
        '
        'AutorBuchLinkDataGridView1
        '
        Me.AutorBuchLinkDataGridView1.AllowUserToAddRows = False
        Me.AutorBuchLinkDataGridView1.AllowUserToDeleteRows = False
        Me.AutorBuchLinkDataGridView1.AutoGenerateColumns = False
        Me.AutorBuchLinkDataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.AutorBuchLinkDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AutorBuchLinkDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BuchIDDataGridViewTextBoxColumn, Me.PersonIDDataGridViewTextBoxColumn, Me.RolleIDDataGridViewTextBoxColumn})
        Me.AutorBuchLinkDataGridView1.DataSource = Me.AutorBuchLinkBindingSource
        Me.AutorBuchLinkDataGridView1.Location = New System.Drawing.Point(40, 81)
        Me.AutorBuchLinkDataGridView1.Name = "AutorBuchLinkDataGridView1"
        Me.AutorBuchLinkDataGridView1.ReadOnly = True
        Me.AutorBuchLinkDataGridView1.RowHeadersVisible = False
        Me.AutorBuchLinkDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AutorBuchLinkDataGridView1.Size = New System.Drawing.Size(266, 83)
        Me.AutorBuchLinkDataGridView1.TabIndex = 172
        '
        'BuchIDDataGridViewTextBoxColumn
        '
        Me.BuchIDDataGridViewTextBoxColumn.DataPropertyName = "BuchID"
        Me.BuchIDDataGridViewTextBoxColumn.HeaderText = "BuchID"
        Me.BuchIDDataGridViewTextBoxColumn.Name = "BuchIDDataGridViewTextBoxColumn"
        Me.BuchIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.BuchIDDataGridViewTextBoxColumn.Visible = False
        '
        'PersonIDDataGridViewTextBoxColumn
        '
        Me.PersonIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PersonIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID"
        Me.PersonIDDataGridViewTextBoxColumn.DataSource = Me.PersonBindingSource
        Me.PersonIDDataGridViewTextBoxColumn.DisplayMember = "SortBy"
        Me.PersonIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.PersonIDDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.PersonIDDataGridViewTextBoxColumn.Name = "PersonIDDataGridViewTextBoxColumn"
        Me.PersonIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PersonIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PersonIDDataGridViewTextBoxColumn.ValueMember = "PersonID"
        '
        'RolleIDDataGridViewTextBoxColumn
        '
        Me.RolleIDDataGridViewTextBoxColumn.DataPropertyName = "RolleID"
        Me.RolleIDDataGridViewTextBoxColumn.DataSource = Me.AutorRolleBindingSource
        Me.RolleIDDataGridViewTextBoxColumn.DisplayMember = "AutorRolle"
        Me.RolleIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.RolleIDDataGridViewTextBoxColumn.HeaderText = "Rolle"
        Me.RolleIDDataGridViewTextBoxColumn.Name = "RolleIDDataGridViewTextBoxColumn"
        Me.RolleIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.RolleIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RolleIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.RolleIDDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'AutorBuchLinkBindingSource
        '
        Me.AutorBuchLinkBindingSource.DataMember = "AutorBuchLink"
        Me.AutorBuchLinkBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'ComboBox12
        '
        Me.ComboBox12.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox12.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox12.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "SerienID", True))
        Me.ComboBox12.DataSource = Me.SerienBindingSource
        Me.ComboBox12.DisplayMember = "Serie"
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Location = New System.Drawing.Point(472, 16)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox12.TabIndex = 172
        Me.ComboBox12.ValueMember = "ID"
        '
        'SerienBindingSource
        '
        Me.SerienBindingSource.DataMember = "Serien"
        Me.SerienBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'ComboBox9
        '
        Me.ComboBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox9.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "SprachenID", True))
        Me.ComboBox9.DataSource = Me.LanguageBindingSource
        Me.ComboBox9.DisplayMember = "Language"
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Location = New System.Drawing.Point(472, 226)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox9.TabIndex = 169
        Me.ComboBox9.ValueMember = "LanguageID"
        '
        'LanguageBindingSource
        '
        Me.LanguageBindingSource.DataMember = "Language"
        Me.LanguageBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'lblSprache
        '
        Me.lblSprache.AutoSize = True
        Me.lblSprache.Location = New System.Drawing.Point(407, 228)
        Me.lblSprache.Name = "lblSprache"
        Me.lblSprache.Size = New System.Drawing.Size(50, 13)
        Me.lblSprache.TabIndex = 168
        Me.lblSprache.Text = "Sprache:"
        '
        'AuflageTextBox
        '
        Me.AuflageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Auiflage", True))
        Me.AuflageTextBox.Location = New System.Drawing.Point(472, 40)
        Me.AuflageTextBox.Name = "AuflageTextBox"
        Me.AuflageTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AuflageTextBox.TabIndex = 161
        '
        'ComboBox8
        '
        Me.ComboBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox8.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "BindungID", True))
        Me.ComboBox8.DataSource = Me.BindungBindingSource
        Me.ComboBox8.DisplayMember = "Bindung"
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(106, 274)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox8.TabIndex = 160
        Me.ComboBox8.ValueMember = "BindingID"
        '
        'BindungBindingSource
        '
        Me.BindungBindingSource.DataMember = "Bindung"
        Me.BindungBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'ComboBox7
        '
        Me.ComboBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox7.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "StandortID", True))
        Me.ComboBox7.DataSource = Me.StandortBindingSource
        Me.ComboBox7.DisplayMember = "Standort"
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(106, 354)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(201, 21)
        Me.ComboBox7.TabIndex = 159
        Me.ComboBox7.ValueMember = "ID"
        '
        'StandortBindingSource
        '
        Me.StandortBindingSource.DataMember = "Standort"
        Me.StandortBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'VerliehenCheckBox
        '
        Me.VerliehenCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "verliehen", True))
        Me.VerliehenCheckBox.Location = New System.Drawing.Point(682, 401)
        Me.VerliehenCheckBox.Name = "VerliehenCheckBox"
        Me.VerliehenCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.VerliehenCheckBox.TabIndex = 158
        Me.VerliehenCheckBox.Text = " Buch ist verliehen"
        Me.VerliehenCheckBox.UseVisualStyleBackColor = True
        '
        'BarCodeTextBox
        '
        Me.BarCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "BarCode", True))
        Me.BarCodeTextBox.Location = New System.Drawing.Point(472, 148)
        Me.BarCodeTextBox.Name = "BarCodeTextBox"
        Me.BarCodeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BarCodeTextBox.TabIndex = 101
        '
        'ASINTextBox
        '
        Me.ASINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "ASIN", True))
        Me.ASINTextBox.Location = New System.Drawing.Point(472, 174)
        Me.ASINTextBox.Name = "ASINTextBox"
        Me.ASINTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ASINTextBox.TabIndex = 115
        '
        'LetzteAenderungDateTimePicker
        '
        Me.LetzteAenderungDateTimePicker.Location = New System.Drawing.Point(472, 305)
        Me.LetzteAenderungDateTimePicker.Name = "LetzteAenderungDateTimePicker"
        Me.LetzteAenderungDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LetzteAenderungDateTimePicker.TabIndex = 117
        '
        'AutorSortTextBox
        '
        Me.AutorSortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "AutorSort", True))
        Me.AutorSortTextBox.Location = New System.Drawing.Point(106, 168)
        Me.AutorSortTextBox.Name = "AutorSortTextBox"
        Me.AutorSortTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AutorSortTextBox.TabIndex = 125
        '
        'VeroeffentlichtTextBox
        '
        Me.VeroeffentlichtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Veroeffentlicht", True))
        Me.VeroeffentlichtTextBox.Location = New System.Drawing.Point(106, 302)
        Me.VeroeffentlichtTextBox.Name = "VeroeffentlichtTextBox"
        Me.VeroeffentlichtTextBox.Size = New System.Drawing.Size(200, 20)
        Me.VeroeffentlichtTextBox.TabIndex = 127
        '
        'CopyrightDatumTextBox
        '
        Me.CopyrightDatumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "CopyrightDatum", True))
        Me.CopyrightDatumTextBox.Location = New System.Drawing.Point(106, 328)
        Me.CopyrightDatumTextBox.Name = "CopyrightDatumTextBox"
        Me.CopyrightDatumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CopyrightDatumTextBox.TabIndex = 129
        '
        'StichworteTextBox
        '
        Me.StichworteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Stichworte", True))
        Me.StichworteTextBox.Location = New System.Drawing.Point(106, 405)
        Me.StichworteTextBox.Name = "StichworteTextBox"
        Me.StichworteTextBox.Size = New System.Drawing.Size(566, 20)
        Me.StichworteTextBox.TabIndex = 153
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Verlag:"
        '
        'CbVerlag
        '
        Me.CbVerlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbVerlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbVerlag.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "VerlagsID", True))
        Me.CbVerlag.DataSource = Me.VerlagBindingSource
        Me.CbVerlag.DisplayMember = "Verlag"
        Me.CbVerlag.FormattingEnabled = True
        Me.CbVerlag.Location = New System.Drawing.Point(106, 194)
        Me.CbVerlag.Name = "CbVerlag"
        Me.CbVerlag.Size = New System.Drawing.Size(200, 21)
        Me.CbVerlag.TabIndex = 42
        Me.CbVerlag.ValueMember = "PublisherID"
        '
        'VerlagBindingSource
        '
        Me.VerlagBindingSource.DataMember = "Verlag"
        Me.VerlagBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(472, 122)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ISBNTextBox.TabIndex = 19
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage5.Controls.Add(Me.GenreLinkDataGridView)
        Me.TabPage5.Controls.Add(Me.Label3)
        Me.TabPage5.Controls.Add(Me.Label2)
        Me.TabPage5.Controls.Add(Me.ListBox1)
        Me.TabPage5.Controls.Add(Me.ComboBox10)
        Me.TabPage5.Controls.Add(Me.ComboBox6)
        Me.TabPage5.Controls.Add(BuchTypLabel)
        Me.TabPage5.Controls.Add(SachgruppeIDLabel)
        Me.TabPage5.Controls.Add(Me.DDCTextBox)
        Me.TabPage5.Controls.Add(DDCLabel)
        Me.TabPage5.Controls.Add(Me.CheckedListBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1187, 460)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Genre"
        '
        'GenreLinkDataGridView
        '
        Me.GenreLinkDataGridView.AllowUserToAddRows = False
        Me.GenreLinkDataGridView.AutoGenerateColumns = False
        Me.GenreLinkDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.GenreLinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GenreLinkDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BuchIDDataGridViewTextBoxColumn1, Me.SachgruppeIDDataGridViewTextBoxColumn})
        Me.GenreLinkDataGridView.DataSource = Me.GenreLinkBindingSource
        Me.GenreLinkDataGridView.Location = New System.Drawing.Point(667, 57)
        Me.GenreLinkDataGridView.Name = "GenreLinkDataGridView"
        Me.GenreLinkDataGridView.ReadOnly = True
        Me.GenreLinkDataGridView.Size = New System.Drawing.Size(200, 82)
        Me.GenreLinkDataGridView.TabIndex = 172
        '
        'BuchIDDataGridViewTextBoxColumn1
        '
        Me.BuchIDDataGridViewTextBoxColumn1.DataPropertyName = "BuchID"
        Me.BuchIDDataGridViewTextBoxColumn1.HeaderText = "BuchID"
        Me.BuchIDDataGridViewTextBoxColumn1.Name = "BuchIDDataGridViewTextBoxColumn1"
        Me.BuchIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SachgruppeIDDataGridViewTextBoxColumn
        '
        Me.SachgruppeIDDataGridViewTextBoxColumn.DataPropertyName = "SachgruppeID"
        Me.SachgruppeIDDataGridViewTextBoxColumn.HeaderText = "SachgruppeID"
        Me.SachgruppeIDDataGridViewTextBoxColumn.Name = "SachgruppeIDDataGridViewTextBoxColumn"
        Me.SachgruppeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenreLinkBindingSource
        '
        Me.GenreLinkBindingSource.DataMember = "GenreLink"
        Me.GenreLinkBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(664, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Aktuell gespeichert:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "Genre:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(97, 57)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 82)
        Me.ListBox1.TabIndex = 12
        '
        'ComboBox10
        '
        Me.ComboBox10.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "SachgruppeID", True))
        Me.ComboBox10.DataSource = Me.SachgruppeBindingSource
        Me.ComboBox10.DisplayMember = "Sachgruppe"
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Location = New System.Drawing.Point(97, 30)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox10.TabIndex = 170
        Me.ComboBox10.ValueMember = "GenreID"
        '
        'SachgruppeBindingSource
        '
        Me.SachgruppeBindingSource.DataMember = "Sachgruppe"
        Me.SachgruppeBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'ComboBox6
        '
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "TypID", True))
        Me.ComboBox6.DataSource = Me.BuchTypBindingSource
        Me.ComboBox6.DisplayMember = "BuchTyp"
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(97, 3)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox6.TabIndex = 48
        Me.ComboBox6.ValueMember = "ID"
        '
        'BuchTypBindingSource
        '
        Me.BuchTypBindingSource.DataMember = "BuchTyp"
        Me.BuchTypBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'DDCTextBox
        '
        Me.DDCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "DNB", True))
        Me.DDCTextBox.Location = New System.Drawing.Point(401, 3)
        Me.DDCTextBox.Name = "DDCTextBox"
        Me.DDCTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DDCTextBox.TabIndex = 133
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(18, 160)
        Me.CheckedListBox1.MultiColumn = True
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(849, 274)
        Me.CheckedListBox1.Sorted = True
        Me.CheckedListBox1.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(DruckIDLabel)
        Me.TabPage2.Controls.Add(Me.DruckIDTextBox)
        Me.TabPage2.Controls.Add(AbschnitteLabel)
        Me.TabPage2.Controls.Add(Me.AbschnitteTextBox)
        Me.TabPage2.Controls.Add(ZustandIDLabel)
        Me.TabPage2.Controls.Add(ErworbenLabel)
        Me.TabPage2.Controls.Add(Me.ErworbenTextBox)
        Me.TabPage2.Controls.Add(VerkaufspreisLabel)
        Me.TabPage2.Controls.Add(Me.VerkaufspreisTextBox)
        Me.TabPage2.Controls.Add(Dim_HeightLabel)
        Me.TabPage2.Controls.Add(Me.Dim_HeightTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1187, 460)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Druckdaten"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(158, 233)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(199, 21)
        Me.ComboBox1.TabIndex = 155
        '
        'DruckIDTextBox
        '
        Me.DruckIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "DruckID", True))
        Me.DruckIDTextBox.Location = New System.Drawing.Point(158, 156)
        Me.DruckIDTextBox.Name = "DruckIDTextBox"
        Me.DruckIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DruckIDTextBox.TabIndex = 151
        '
        'AbschnitteTextBox
        '
        Me.AbschnitteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Abschnitte", True))
        Me.AbschnitteTextBox.Location = New System.Drawing.Point(158, 208)
        Me.AbschnitteTextBox.Name = "AbschnitteTextBox"
        Me.AbschnitteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AbschnitteTextBox.TabIndex = 153
        '
        'ErworbenTextBox
        '
        Me.ErworbenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Erworben", True))
        Me.ErworbenTextBox.Location = New System.Drawing.Point(514, 31)
        Me.ErworbenTextBox.Name = "ErworbenTextBox"
        Me.ErworbenTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ErworbenTextBox.TabIndex = 147
        '
        'VerkaufspreisTextBox
        '
        Me.VerkaufspreisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Verkaufspreis", True))
        Me.VerkaufspreisTextBox.Location = New System.Drawing.Point(514, 86)
        Me.VerkaufspreisTextBox.Name = "VerkaufspreisTextBox"
        Me.VerkaufspreisTextBox.Size = New System.Drawing.Size(200, 20)
        Me.VerkaufspreisTextBox.TabIndex = 117
        '
        'Dim_HeightTextBox
        '
        Me.Dim_HeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Dim_Height", True))
        Me.Dim_HeightTextBox.Location = New System.Drawing.Point(158, 31)
        Me.Dim_HeightTextBox.Name = "Dim_HeightTextBox"
        Me.Dim_HeightTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Dim_HeightTextBox.TabIndex = 113
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage3.Controls.Add(OriginalCopyrightLabel)
        Me.TabPage3.Controls.Add(Me.OriginalCopyrightTextBox)
        Me.TabPage3.Controls.Add(OriginalSpracheIDLabel)
        Me.TabPage3.Controls.Add(Me.OriginalSpracheIDTextBox)
        Me.TabPage3.Controls.Add(OriginalLandIDLabel)
        Me.TabPage3.Controls.Add(Me.OriginalLandIDTextBox)
        Me.TabPage3.Controls.Add(OriginalUntertitelLabel)
        Me.TabPage3.Controls.Add(Me.OriginalUntertitelTextBox)
        Me.TabPage3.Controls.Add(OriginalTitelLabel)
        Me.TabPage3.Controls.Add(Me.OriginalTitelTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1187, 460)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Original"
        '
        'OriginalCopyrightTextBox
        '
        Me.OriginalCopyrightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "OriginalCopyright", True))
        Me.OriginalCopyrightTextBox.Location = New System.Drawing.Point(156, 231)
        Me.OriginalCopyrightTextBox.Name = "OriginalCopyrightTextBox"
        Me.OriginalCopyrightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OriginalCopyrightTextBox.TabIndex = 9
        '
        'OriginalSpracheIDTextBox
        '
        Me.OriginalSpracheIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "OriginalSpracheID", True))
        Me.OriginalSpracheIDTextBox.Location = New System.Drawing.Point(156, 181)
        Me.OriginalSpracheIDTextBox.Name = "OriginalSpracheIDTextBox"
        Me.OriginalSpracheIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OriginalSpracheIDTextBox.TabIndex = 7
        '
        'OriginalLandIDTextBox
        '
        Me.OriginalLandIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "OriginalLandID", True))
        Me.OriginalLandIDTextBox.Location = New System.Drawing.Point(156, 126)
        Me.OriginalLandIDTextBox.Name = "OriginalLandIDTextBox"
        Me.OriginalLandIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OriginalLandIDTextBox.TabIndex = 5
        '
        'OriginalUntertitelTextBox
        '
        Me.OriginalUntertitelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "OriginalUntertitel", True))
        Me.OriginalUntertitelTextBox.Location = New System.Drawing.Point(156, 78)
        Me.OriginalUntertitelTextBox.Name = "OriginalUntertitelTextBox"
        Me.OriginalUntertitelTextBox.Size = New System.Drawing.Size(514, 20)
        Me.OriginalUntertitelTextBox.TabIndex = 3
        '
        'OriginalTitelTextBox
        '
        Me.OriginalTitelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "OriginalTitel", True))
        Me.OriginalTitelTextBox.Location = New System.Drawing.Point(156, 37)
        Me.OriginalTitelTextBox.Name = "OriginalTitelTextBox"
        Me.OriginalTitelTextBox.Size = New System.Drawing.Size(514, 20)
        Me.OriginalTitelTextBox.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage4.Controls.Add(Synopsis_PlainTextLabel)
        Me.TabPage4.Controls.Add(Me.Synopsis_PlainTextTextBox)
        Me.TabPage4.Controls.Add(Reviews_PlainTextLabel)
        Me.TabPage4.Controls.Add(Me.Reviews_PlainTextTextBox)
        Me.TabPage4.Controls.Add(Anmerkungen_PlainTextLabel)
        Me.TabPage4.Controls.Add(Me.Anmerkungen_PlainTextTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1187, 460)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Hinweise"
        '
        'Synopsis_PlainTextTextBox
        '
        Me.Synopsis_PlainTextTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Synopsis_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Synopsis_PlainText", True))
        Me.Synopsis_PlainTextTextBox.Location = New System.Drawing.Point(432, 37)
        Me.Synopsis_PlainTextTextBox.Multiline = True
        Me.Synopsis_PlainTextTextBox.Name = "Synopsis_PlainTextTextBox"
        Me.Synopsis_PlainTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Synopsis_PlainTextTextBox.Size = New System.Drawing.Size(403, 419)
        Me.Synopsis_PlainTextTextBox.TabIndex = 102
        '
        'Reviews_PlainTextTextBox
        '
        Me.Reviews_PlainTextTextBox.Location = New System.Drawing.Point(216, 490)
        Me.Reviews_PlainTextTextBox.Name = "Reviews_PlainTextTextBox"
        Me.Reviews_PlainTextTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Reviews_PlainTextTextBox.TabIndex = 101
        '
        'Anmerkungen_PlainTextTextBox
        '
        Me.Anmerkungen_PlainTextTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Anmerkungen_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Anmerkungen_PlainText", True))
        Me.Anmerkungen_PlainTextTextBox.Location = New System.Drawing.Point(24, 37)
        Me.Anmerkungen_PlainTextTextBox.Multiline = True
        Me.Anmerkungen_PlainTextTextBox.Name = "Anmerkungen_PlainTextTextBox"
        Me.Anmerkungen_PlainTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Anmerkungen_PlainTextTextBox.Size = New System.Drawing.Size(403, 419)
        Me.Anmerkungen_PlainTextTextBox.TabIndex = 3
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1187, 460)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Export"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.14573!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.85427!))
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox1, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtSaveImage, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.25581!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.74419!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1181, 454)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(347, 63)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(831, 388)
        Me.TextBox1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(3, 63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(284, 368)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'BtSaveImage
        '
        Me.BtSaveImage.Location = New System.Drawing.Point(3, 3)
        Me.BtSaveImage.Name = "BtSaveImage"
        Me.BtSaveImage.Size = New System.Drawing.Size(284, 50)
        Me.BtSaveImage.TabIndex = 2
        Me.BtSaveImage.Text = "Cover für Export Speichern"
        Me.BtSaveImage.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LblSpeicherOrt)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(347, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(831, 54)
        Me.Panel3.TabIndex = 3
        '
        'LblSpeicherOrt
        '
        Me.LblSpeicherOrt.AutoSize = True
        Me.LblSpeicherOrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpeicherOrt.Location = New System.Drawing.Point(13, 19)
        Me.LblSpeicherOrt.Name = "LblSpeicherOrt"
        Me.LblSpeicherOrt.Size = New System.Drawing.Size(77, 16)
        Me.LblSpeicherOrt.TabIndex = 0
        Me.LblSpeicherOrt.Text = "Speicherort"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(Me.MarkedCheckBox)
        Me.Panel1.Controls.Add(Me.UntertitelTextBox)
        Me.Panel1.Controls.Add(Me.TitelTextBox)
        Me.Panel1.Controls.Add(TitelLabel)
        Me.Panel1.Controls.Add(UntertitelLabel)
        Me.Panel1.Controls.Add(Me.SignaturTextBox)
        Me.Panel1.Controls.Add(SignaturLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1195, 73)
        Me.Panel1.TabIndex = 3
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.Color.SteelBlue
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IDTextBox.Location = New System.Drawing.Point(923, 10)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(67, 13)
        Me.IDTextBox.TabIndex = 174
        '
        'MarkedCheckBox
        '
        Me.MarkedCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MarkedCheckBox.Location = New System.Drawing.Point(688, 39)
        Me.MarkedCheckBox.Name = "MarkedCheckBox"
        Me.MarkedCheckBox.Size = New System.Drawing.Size(77, 24)
        Me.MarkedCheckBox.TabIndex = 51
        Me.MarkedCheckBox.Text = "Markiert"
        Me.MarkedCheckBox.UseVisualStyleBackColor = True
        '
        'UntertitelTextBox
        '
        Me.UntertitelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Untertitel", True))
        Me.UntertitelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UntertitelTextBox.Location = New System.Drawing.Point(77, 36)
        Me.UntertitelTextBox.Name = "UntertitelTextBox"
        Me.UntertitelTextBox.Size = New System.Drawing.Size(570, 21)
        Me.UntertitelTextBox.TabIndex = 13
        '
        'TitelTextBox
        '
        Me.TitelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Titel", True))
        Me.TitelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitelTextBox.Location = New System.Drawing.Point(77, 10)
        Me.TitelTextBox.Name = "TitelTextBox"
        Me.TitelTextBox.Size = New System.Drawing.Size(570, 21)
        Me.TitelTextBox.TabIndex = 1
        '
        'SignaturTextBox
        '
        Me.SignaturTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Signatur", True))
        Me.SignaturTextBox.Location = New System.Drawing.Point(780, 10)
        Me.SignaturTextBox.Name = "SignaturTextBox"
        Me.SignaturTextBox.Size = New System.Drawing.Size(60, 20)
        Me.SignaturTextBox.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 574)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1195, 32)
        Me.Panel2.TabIndex = 4
        '
        'btClose
        '
        Me.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClose.Location = New System.Drawing.Point(559, 3)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 23)
        Me.btClose.TabIndex = 0
        Me.btClose.Text = "Zurück"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpeichernToolStripButton, Me.DruckenToolStripButton, Me.toolStripSeparator, Me.AusschneidenToolStripButton, Me.KopierenToolStripButton, Me.EinfügenToolStripButton, Me.toolStripSeparator1, Me.HilfeToolStripButton, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1201, 39)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 2
        '
        'SpeichernToolStripButton
        '
        Me.SpeichernToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SpeichernToolStripButton.Image = CType(resources.GetObject("SpeichernToolStripButton.Image"), System.Drawing.Image)
        Me.SpeichernToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SpeichernToolStripButton.Name = "SpeichernToolStripButton"
        Me.SpeichernToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.SpeichernToolStripButton.Text = "&Speichern"
        '
        'DruckenToolStripButton
        '
        Me.DruckenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DruckenToolStripButton.Enabled = False
        Me.DruckenToolStripButton.Image = CType(resources.GetObject("DruckenToolStripButton.Image"), System.Drawing.Image)
        Me.DruckenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DruckenToolStripButton.Name = "DruckenToolStripButton"
        Me.DruckenToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DruckenToolStripButton.Text = "&Drucken"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 39)
        '
        'AusschneidenToolStripButton
        '
        Me.AusschneidenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AusschneidenToolStripButton.Image = CType(resources.GetObject("AusschneidenToolStripButton.Image"), System.Drawing.Image)
        Me.AusschneidenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AusschneidenToolStripButton.Name = "AusschneidenToolStripButton"
        Me.AusschneidenToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.AusschneidenToolStripButton.Text = "&Ausschneiden"
        '
        'KopierenToolStripButton
        '
        Me.KopierenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KopierenToolStripButton.Image = CType(resources.GetObject("KopierenToolStripButton.Image"), System.Drawing.Image)
        Me.KopierenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KopierenToolStripButton.Name = "KopierenToolStripButton"
        Me.KopierenToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.KopierenToolStripButton.Text = "&Kopieren"
        '
        'EinfügenToolStripButton
        '
        Me.EinfügenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EinfügenToolStripButton.Image = CType(resources.GetObject("EinfügenToolStripButton.Image"), System.Drawing.Image)
        Me.EinfügenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EinfügenToolStripButton.Name = "EinfügenToolStripButton"
        Me.EinfügenToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.EinfügenToolStripButton.Text = "&Einfügen"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'HilfeToolStripButton
        '
        Me.HilfeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HilfeToolStripButton.Enabled = False
        Me.HilfeToolStripButton.Image = CType(resources.GetObject("HilfeToolStripButton.Image"), System.Drawing.Image)
        Me.HilfeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HilfeToolStripButton.Name = "HilfeToolStripButton"
        Me.HilfeToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.HilfeToolStripButton.Text = "Hi&lfe"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'BuchTableAdapter
        '
        Me.BuchTableAdapter.ClearBeforeFill = True
        '
        'AutorBuchLinkTableAdapter
        '
        Me.AutorBuchLinkTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutorBuchLinkTableAdapter = Me.AutorBuchLinkTableAdapter
        Me.TableAdapterManager.AutorRolleTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BibliothekTableAdapter = Nothing
        Me.TableAdapterManager.BindungTableAdapter = Nothing
        Me.TableAdapterManager.BuchTableAdapter = Me.BuchTableAdapter
        Me.TableAdapterManager.BuchTypTableAdapter = Me.BuchTypTableAdapter
        Me.TableAdapterManager.DDCTableAdapter = Nothing
        Me.TableAdapterManager.DruckereiTableAdapter = Nothing
        Me.TableAdapterManager.EditionTableAdapter = Nothing
        Me.TableAdapterManager.GenreLinkTableAdapter = Me.GenreLinkTableAdapter
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
        'BuchTypTableAdapter
        '
        Me.BuchTypTableAdapter.ClearBeforeFill = True
        '
        'GenreLinkTableAdapter
        '
        Me.GenreLinkTableAdapter.ClearBeforeFill = True
        '
        'SachgruppeTableAdapter
        '
        Me.SachgruppeTableAdapter.ClearBeforeFill = True
        '
        'VerlagTableAdapter
        '
        Me.VerlagTableAdapter.ClearBeforeFill = True
        '
        'VerlagsOrtTableAdapter
        '
        Me.VerlagsOrtTableAdapter.ClearBeforeFill = True
        '
        'DruckereiTableAdapter
        '
        Me.DruckereiTableAdapter.ClearBeforeFill = True
        '
        'StandortTableAdapter
        '
        Me.StandortTableAdapter.ClearBeforeFill = True
        '
        'SerienTableAdapter
        '
        Me.SerienTableAdapter.ClearBeforeFill = True
        '
        'LanguageTableAdapter
        '
        Me.LanguageTableAdapter.ClearBeforeFill = True
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'AutorRolleTableAdapter
        '
        Me.AutorRolleTableAdapter.ClearBeforeFill = True
        '
        'BindungTableAdapter
        '
        Me.BindungTableAdapter.ClearBeforeFill = True
        '
        'BuchDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 648)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "BuchDetail"
        Me.Text = "BookCMS - Buch Details"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.AutorRolleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DruckereiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerlagsOrtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorBuchLinkDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorBuchLinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SerienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LanguageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindungBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandortBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerlagBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.GenreLinkDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenreLinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SachgruppeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuchTypBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtScann As Button
    Friend WithEvents BookIDTextBox As TextBox
    Friend WithEvents btClipbord As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox11 As ComboBox
    Friend WithEvents ImagePictureBox1 As PictureBox
    Friend WithEvents DNBTextBox As TextBox
    Friend WithEvents AutorBuchLinkDataGridView1 As DataGridView
    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents lblSprache As Label
    Friend WithEvents AuflageTextBox As TextBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents VerliehenCheckBox As CheckBox
    Friend WithEvents BarCodeTextBox As TextBox
    Friend WithEvents ASINTextBox As TextBox
    Friend WithEvents LetzteAenderungDateTimePicker As DateTimePicker
    Friend WithEvents AutorSortTextBox As TextBox
    Friend WithEvents VeroeffentlichtTextBox As TextBox
    Friend WithEvents CopyrightDatumTextBox As TextBox
    Friend WithEvents StichworteTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbVerlag As ComboBox
    Friend WithEvents ISBNTextBox As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GenreLinkDataGridView As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents DDCTextBox As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DruckIDTextBox As TextBox
    Friend WithEvents AbschnitteTextBox As TextBox
    Friend WithEvents ErworbenTextBox As TextBox
    Friend WithEvents VerkaufspreisTextBox As TextBox
    Friend WithEvents Dim_HeightTextBox As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Synopsis_PlainTextTextBox As TextBox
    Friend WithEvents Reviews_PlainTextTextBox As TextBox
    Friend WithEvents Anmerkungen_PlainTextTextBox As TextBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtSaveImage As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblSpeicherOrt As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents MarkedCheckBox As CheckBox
    Friend WithEvents UntertitelTextBox As TextBox
    Friend WithEvents TitelTextBox As TextBox
    Friend WithEvents SignaturTextBox As TextBox
    Friend WithEvents SeitenTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btClose As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SpeichernToolStripButton As ToolStripButton
    Friend WithEvents DruckenToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents AusschneidenToolStripButton As ToolStripButton
    Friend WithEvents KopierenToolStripButton As ToolStripButton
    Friend WithEvents EinfügenToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HilfeToolStripButton As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents BuchBindingSource As BindingSource
    Friend WithEvents BuchTableAdapter As _BookCMS_singleDataSetTableAdapters.BuchTableAdapter
    Friend WithEvents AutorBuchLinkBindingSource As BindingSource
    Friend WithEvents AutorBuchLinkTableAdapter As _BookCMS_singleDataSetTableAdapters.AutorBuchLinkTableAdapter
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BuchTypTableAdapter As _BookCMS_singleDataSetTableAdapters.BuchTypTableAdapter
    Friend WithEvents BuchTypBindingSource As BindingSource
    Friend WithEvents SachgruppeTableAdapter As _BookCMS_singleDataSetTableAdapters.SachgruppeTableAdapter
    Friend WithEvents SachgruppeBindingSource As BindingSource
    Friend WithEvents GenreLinkTableAdapter As _BookCMS_singleDataSetTableAdapters.GenreLinkTableAdapter
    Friend WithEvents GenreLinkBindingSource As BindingSource
    Friend WithEvents VerlagBindingSource As BindingSource
    Friend WithEvents VerlagTableAdapter As _BookCMS_singleDataSetTableAdapters.VerlagTableAdapter
    Friend WithEvents VerlagsOrtBindingSource As BindingSource
    Friend WithEvents VerlagsOrtTableAdapter As _BookCMS_singleDataSetTableAdapters.VerlagsOrtTableAdapter
    Friend WithEvents DruckereiBindingSource As BindingSource
    Friend WithEvents DruckereiTableAdapter As _BookCMS_singleDataSetTableAdapters.DruckereiTableAdapter
    Friend WithEvents StandortBindingSource As BindingSource
    Friend WithEvents StandortTableAdapter As _BookCMS_singleDataSetTableAdapters.StandortTableAdapter
    Friend WithEvents SerienBindingSource As BindingSource
    Friend WithEvents SerienTableAdapter As _BookCMS_singleDataSetTableAdapters.SerienTableAdapter
    Friend WithEvents LanguageBindingSource As BindingSource
    Friend WithEvents LanguageTableAdapter As _BookCMS_singleDataSetTableAdapters.LanguageTableAdapter
    Friend WithEvents PersonBindingSource As BindingSource
    Friend WithEvents PersonTableAdapter As _BookCMS_singleDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents AutorRolleBindingSource As BindingSource
    Friend WithEvents AutorRolleTableAdapter As _BookCMS_singleDataSetTableAdapters.AutorRolleTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents OriginalCopyrightTextBox As TextBox
    Friend WithEvents OriginalSpracheIDTextBox As TextBox
    Friend WithEvents OriginalLandIDTextBox As TextBox
    Friend WithEvents OriginalUntertitelTextBox As TextBox
    Friend WithEvents OriginalTitelTextBox As TextBox
    Friend WithEvents BtnAddAutor As Button
    Friend WithEvents CBRolle As ComboBox
    Friend WithEvents CBPerson As ComboBox
    Friend WithEvents btPersonNeu As Button
    Friend WithEvents BtnDel As Button
    Friend WithEvents BuchIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonIDDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents RolleIDDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BuchIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SachgruppeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BindungBindingSource As BindingSource
    Friend WithEvents BindungTableAdapter As _BookCMS_singleDataSetTableAdapters.BindungTableAdapter
End Class
