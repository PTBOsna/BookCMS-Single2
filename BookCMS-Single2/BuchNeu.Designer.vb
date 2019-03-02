<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuchNeu
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
        Dim BuchTypLabel As System.Windows.Forms.Label
        Dim TitleSortLabel As System.Windows.Forms.Label
        Dim TitelIndexLabel As System.Windows.Forms.Label
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
        Dim SachgruppeIDLabel As System.Windows.Forms.Label
        Dim DDCLabel As System.Windows.Forms.Label
        Dim DruckIDLabel As System.Windows.Forms.Label
        Dim AbschnitteLabel As System.Windows.Forms.Label
        Dim ZustandIDLabel As System.Windows.Forms.Label
        Dim ErworbenLabel As System.Windows.Forms.Label
        Dim VerkaufspreisLabel As System.Windows.Forms.Label
        Dim Dim_HeightLabel As System.Windows.Forms.Label
        Dim OriginalTitelLabel As System.Windows.Forms.Label
        Dim OriginalUntertitelLabel As System.Windows.Forms.Label
        Dim OriginaVerlagIDLabel As System.Windows.Forms.Label
        Dim OriginalLandIDLabel As System.Windows.Forms.Label
        Dim OriginalCopyrightLabel As System.Windows.Forms.Label
        Dim LCCNLabel As System.Windows.Forms.Label
        Dim Synopsis_PlainTextLabel As System.Windows.Forms.Label
        Dim Reviews_PlainTextLabel As System.Windows.Forms.Label
        Dim Anmerkungen_PlainTextLabel As System.Windows.Forms.Label
        Dim TitelLabel As System.Windows.Forms.Label
        Dim UntertitelLabel As System.Windows.Forms.Label
        Dim SignaturLabel As System.Windows.Forms.Label
        Dim SeitenLabel As System.Windows.Forms.Label
        Dim DruckIDLabel1 As System.Windows.Forms.Label
        Dim AbschnitteLabel1 As System.Windows.Forms.Label
        Dim ZustandIDLabel1 As System.Windows.Forms.Label
        Dim Dim_HeightLabel1 As System.Windows.Forms.Label
        Dim VerkaufspreisLabel1 As System.Windows.Forms.Label
        Dim ErworbenLabel1 As System.Windows.Forms.Label
        Dim LCCNLabel1 As System.Windows.Forms.Label
        Dim OriginalTitelLabel1 As System.Windows.Forms.Label
        Dim OriginalUntertitelLabel1 As System.Windows.Forms.Label
        Dim OriginaVerlagIDLabel1 As System.Windows.Forms.Label
        Dim OriginalLandIDLabel1 As System.Windows.Forms.Label
        Dim OriginalCopyrightLabel1 As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CopyrightDatumTextBox = New System.Windows.Forms.TextBox()
        Me.BuchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.VeroeffentlichtTextBox = New System.Windows.Forms.TextBox()
        Me.StichworteTextBox = New System.Windows.Forms.TextBox()
        Me.LetzteAenderungDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ASINTextBox = New System.Windows.Forms.TextBox()
        Me.BarCodeTextBox = New System.Windows.Forms.TextBox()
        Me.DNBTextBox = New System.Windows.Forms.TextBox()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.TitleSortTextBox = New System.Windows.Forms.TextBox()
        Me.TitelIndexTextBox = New System.Windows.Forms.TextBox()
        Me.AutorSortTextBox = New System.Windows.Forms.TextBox()
        Me.BtScann = New System.Windows.Forms.Button()
        Me.BtnAddAutor = New System.Windows.Forms.Button()
        Me.CBRolle = New System.Windows.Forms.ComboBox()
        Me.AutorRolleBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBPerson = New System.Windows.Forms.ComboBox()
        Me.PersonBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.BuchTypBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DruckereiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BookIDTextBox = New System.Windows.Forms.TextBox()
        Me.btImageInput = New System.Windows.Forms.Button()
        Me.btPersonNeu = New System.Windows.Forms.Button()
        Me.AutorBuchLinkDataGridView = New System.Windows.Forms.DataGridView()
        Me.BuchIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RolleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AutorRolleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutorBuchLinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbVerlagsOrt = New System.Windows.Forms.ComboBox()
        Me.VerlagsOrtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.SerienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.LanguageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSprache = New System.Windows.Forms.Label()
        Me.AuiflageTextBox = New System.Windows.Forms.TextBox()
        Me.cbBindung = New System.Windows.Forms.ComboBox()
        Me.BindungBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.StandortBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VerliehenCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbVerlag = New System.Windows.Forms.ComboBox()
        Me.VerlagBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.DDCTextBox = New System.Windows.Forms.TextBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ErworbenTextBox = New System.Windows.Forms.TextBox()
        Me.VerkaufspreisTextBox = New System.Windows.Forms.TextBox()
        Me.Dim_HeightTextBox = New System.Windows.Forms.TextBox()
        Me.ZustandIDTextBox = New System.Windows.Forms.TextBox()
        Me.AbschnitteTextBox = New System.Windows.Forms.TextBox()
        Me.DruckIDTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.OriginalCopyrightTextBox = New System.Windows.Forms.TextBox()
        Me.OriginalLandIDTextBox = New System.Windows.Forms.TextBox()
        Me.OriginaVerlagIDTextBox = New System.Windows.Forms.TextBox()
        Me.OriginalUntertitelTextBox = New System.Windows.Forms.TextBox()
        Me.OriginalTitelTextBox = New System.Windows.Forms.TextBox()
        Me.LCCNTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Synopsis_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.Reviews_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.Anmerkungen_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TitelTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.MarkedCheckBox = New System.Windows.Forms.CheckBox()
        Me.UntertitelTextBox = New System.Windows.Forms.TextBox()
        Me.SignaturTextBox = New System.Windows.Forms.TextBox()
        Me.SeitenTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btClose = New System.Windows.Forms.Button()
        Me.AutorBuchLinkTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.AutorBuchLinkTableAdapter()
        Me.PersonTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.PersonTableAdapter()
        Me.AutorRolleTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.AutorRolleTableAdapter()
        Me.BuchTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.BuchTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.BindungTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.BindungTableAdapter()
        Me.BuchTypTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.BuchTypTableAdapter()
        Me.DruckereiTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.DruckereiTableAdapter()
        Me.GenreLinkTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.GenreLinkTableAdapter()
        Me.LanguageTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.LanguageTableAdapter()
        Me.SachgruppeTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.SachgruppeTableAdapter()
        Me.SerienTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.SerienTableAdapter()
        Me.StandortTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.StandortTableAdapter()
        Me.VerlagsOrtTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.VerlagsOrtTableAdapter()
        Me.VerlagTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.VerlagTableAdapter()
        BuchTypLabel = New System.Windows.Forms.Label()
        TitleSortLabel = New System.Windows.Forms.Label()
        TitelIndexLabel = New System.Windows.Forms.Label()
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
        SachgruppeIDLabel = New System.Windows.Forms.Label()
        DDCLabel = New System.Windows.Forms.Label()
        DruckIDLabel = New System.Windows.Forms.Label()
        AbschnitteLabel = New System.Windows.Forms.Label()
        ZustandIDLabel = New System.Windows.Forms.Label()
        ErworbenLabel = New System.Windows.Forms.Label()
        VerkaufspreisLabel = New System.Windows.Forms.Label()
        Dim_HeightLabel = New System.Windows.Forms.Label()
        OriginalTitelLabel = New System.Windows.Forms.Label()
        OriginalUntertitelLabel = New System.Windows.Forms.Label()
        OriginaVerlagIDLabel = New System.Windows.Forms.Label()
        OriginalLandIDLabel = New System.Windows.Forms.Label()
        OriginalCopyrightLabel = New System.Windows.Forms.Label()
        LCCNLabel = New System.Windows.Forms.Label()
        Synopsis_PlainTextLabel = New System.Windows.Forms.Label()
        Reviews_PlainTextLabel = New System.Windows.Forms.Label()
        Anmerkungen_PlainTextLabel = New System.Windows.Forms.Label()
        TitelLabel = New System.Windows.Forms.Label()
        UntertitelLabel = New System.Windows.Forms.Label()
        SignaturLabel = New System.Windows.Forms.Label()
        SeitenLabel = New System.Windows.Forms.Label()
        DruckIDLabel1 = New System.Windows.Forms.Label()
        AbschnitteLabel1 = New System.Windows.Forms.Label()
        ZustandIDLabel1 = New System.Windows.Forms.Label()
        Dim_HeightLabel1 = New System.Windows.Forms.Label()
        VerkaufspreisLabel1 = New System.Windows.Forms.Label()
        ErworbenLabel1 = New System.Windows.Forms.Label()
        LCCNLabel1 = New System.Windows.Forms.Label()
        OriginalTitelLabel1 = New System.Windows.Forms.Label()
        OriginalUntertitelLabel1 = New System.Windows.Forms.Label()
        OriginaVerlagIDLabel1 = New System.Windows.Forms.Label()
        OriginalLandIDLabel1 = New System.Windows.Forms.Label()
        OriginalCopyrightLabel1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.BuchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorRolleBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuchTypBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DruckereiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorBuchLinkDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorRolleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorBuchLinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerlagsOrtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SerienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LanguageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindungBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandortBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerlagBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.GenreLinkDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenreLinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SachgruppeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BuchTypLabel
        '
        BuchTypLabel.AutoSize = True
        BuchTypLabel.Location = New System.Drawing.Point(408, 81)
        BuchTypLabel.Name = "BuchTypLabel"
        BuchTypLabel.Size = New System.Drawing.Size(56, 13)
        BuchTypLabel.TabIndex = 189
        BuchTypLabel.Text = "Buch Typ:"
        '
        'TitleSortLabel
        '
        TitleSortLabel.AutoSize = True
        TitleSortLabel.Location = New System.Drawing.Point(417, 53)
        TitleSortLabel.Name = "TitleSortLabel"
        TitleSortLabel.Size = New System.Drawing.Size(52, 13)
        TitleSortLabel.TabIndex = 177
        TitleSortLabel.Text = "Title Sort:"
        '
        'TitelIndexLabel
        '
        TitelIndexLabel.AutoSize = True
        TitelIndexLabel.Location = New System.Drawing.Point(410, 27)
        TitelIndexLabel.Name = "TitelIndexLabel"
        TitelIndexLabel.Size = New System.Drawing.Size(59, 13)
        TitelIndexLabel.TabIndex = 176
        TitelIndexLabel.Text = "Titel Index:"
        '
        'DNBLabel
        '
        DNBLabel.AutoSize = True
        DNBLabel.Location = New System.Drawing.Point(424, 267)
        DNBLabel.Name = "DNBLabel"
        DNBLabel.Size = New System.Drawing.Size(33, 13)
        DNBLabel.TabIndex = 172
        DNBLabel.Text = "DNB:"
        '
        'StandortIDLabel
        '
        StandortIDLabel.AutoSize = True
        StandortIDLabel.Location = New System.Drawing.Point(43, 374)
        StandortIDLabel.Name = "StandortIDLabel"
        StandortIDLabel.Size = New System.Drawing.Size(50, 13)
        StandortIDLabel.TabIndex = 92
        StandortIDLabel.Text = "Standort:"
        '
        'BarCodeLabel
        '
        BarCodeLabel.AutoSize = True
        BarCodeLabel.Location = New System.Drawing.Point(403, 216)
        BarCodeLabel.Name = "BarCodeLabel"
        BarCodeLabel.Size = New System.Drawing.Size(54, 13)
        BarCodeLabel.TabIndex = 100
        BarCodeLabel.Text = "Bar Code:"
        '
        'ASINLabel
        '
        ASINLabel.AutoSize = True
        ASINLabel.Location = New System.Drawing.Point(422, 242)
        ASINLabel.Name = "ASINLabel"
        ASINLabel.Size = New System.Drawing.Size(35, 13)
        ASINLabel.TabIndex = 114
        ASINLabel.Text = "ASIN:"
        '
        'LetzteAenderungLabel
        '
        LetzteAenderungLabel.AutoSize = True
        LetzteAenderungLabel.Location = New System.Drawing.Point(363, 374)
        LetzteAenderungLabel.Name = "LetzteAenderungLabel"
        LetzteAenderungLabel.Size = New System.Drawing.Size(94, 13)
        LetzteAenderungLabel.TabIndex = 116
        LetzteAenderungLabel.Text = "Letzte Aenderung:"
        '
        'AutorSortLabel
        '
        AutorSortLabel.AutoSize = True
        AutorSortLabel.Location = New System.Drawing.Point(36, 161)
        AutorSortLabel.Name = "AutorSortLabel"
        AutorSortLabel.Size = New System.Drawing.Size(57, 13)
        AutorSortLabel.TabIndex = 124
        AutorSortLabel.Text = "Autor Sort:"
        '
        'VeroeffentlichtLabel
        '
        VeroeffentlichtLabel.AutoSize = True
        VeroeffentlichtLabel.Location = New System.Drawing.Point(15, 321)
        VeroeffentlichtLabel.Name = "VeroeffentlichtLabel"
        VeroeffentlichtLabel.Size = New System.Drawing.Size(78, 13)
        VeroeffentlichtLabel.TabIndex = 126
        VeroeffentlichtLabel.Text = "Veroeffentlicht:"
        '
        'CopyrightDatumLabel
        '
        CopyrightDatumLabel.AutoSize = True
        CopyrightDatumLabel.Location = New System.Drawing.Point(5, 347)
        CopyrightDatumLabel.Name = "CopyrightDatumLabel"
        CopyrightDatumLabel.Size = New System.Drawing.Size(88, 13)
        CopyrightDatumLabel.TabIndex = 128
        CopyrightDatumLabel.Text = "Copyright Datum:"
        '
        'SerienIDLabel
        '
        SerienIDLabel.AutoSize = True
        SerienIDLabel.Location = New System.Drawing.Point(423, 126)
        SerienIDLabel.Name = "SerienIDLabel"
        SerienIDLabel.Size = New System.Drawing.Size(34, 13)
        SerienIDLabel.TabIndex = 136
        SerienIDLabel.Text = "Serie:"
        '
        'VerlagsOrtIDLabel
        '
        VerlagsOrtIDLabel.AutoSize = True
        VerlagsOrtIDLabel.Location = New System.Drawing.Point(31, 215)
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
        PrintingIDLabel.Location = New System.Drawing.Point(37, 244)
        PrintingIDLabel.Name = "PrintingIDLabel"
        PrintingIDLabel.Size = New System.Drawing.Size(56, 13)
        PrintingIDLabel.TabIndex = 36
        PrintingIDLabel.Text = "Druckerei:"
        '
        'AuflageIDLabel
        '
        AuflageIDLabel.AutoSize = True
        AuflageIDLabel.Location = New System.Drawing.Point(411, 151)
        AuflageIDLabel.Name = "AuflageIDLabel"
        AuflageIDLabel.Size = New System.Drawing.Size(46, 13)
        AuflageIDLabel.TabIndex = 34
        AuflageIDLabel.Text = "Auflage:"
        '
        'BindungIDLabel
        '
        BindungIDLabel.AutoSize = True
        BindungIDLabel.Location = New System.Drawing.Point(44, 269)
        BindungIDLabel.Name = "BindungIDLabel"
        BindungIDLabel.Size = New System.Drawing.Size(49, 13)
        BindungIDLabel.TabIndex = 32
        BindungIDLabel.Text = "Bindung:"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(422, 190)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(35, 13)
        ISBNLabel.TabIndex = 18
        ISBNLabel.Text = "ISBN:"
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
        Dim_HeightLabel.Location = New System.Drawing.Point(26, 63)
        Dim_HeightLabel.Name = "Dim_HeightLabel"
        Dim_HeightLabel.Size = New System.Drawing.Size(62, 13)
        Dim_HeightLabel.TabIndex = 112
        Dim_HeightLabel.Text = "Dim Height:"
        '
        'OriginalTitelLabel
        '
        OriginalTitelLabel.AutoSize = True
        OriginalTitelLabel.Location = New System.Drawing.Point(45, 108)
        OriginalTitelLabel.Name = "OriginalTitelLabel"
        OriginalTitelLabel.Size = New System.Drawing.Size(68, 13)
        OriginalTitelLabel.TabIndex = 92
        OriginalTitelLabel.Text = "Original Titel:"
        '
        'OriginalUntertitelLabel
        '
        OriginalUntertitelLabel.AutoSize = True
        OriginalUntertitelLabel.Location = New System.Drawing.Point(45, 134)
        OriginalUntertitelLabel.Name = "OriginalUntertitelLabel"
        OriginalUntertitelLabel.Size = New System.Drawing.Size(90, 13)
        OriginalUntertitelLabel.TabIndex = 94
        OriginalUntertitelLabel.Text = "Original Untertitel:"
        '
        'OriginaVerlagIDLabel
        '
        OriginaVerlagIDLabel.AutoSize = True
        OriginaVerlagIDLabel.Location = New System.Drawing.Point(45, 160)
        OriginaVerlagIDLabel.Name = "OriginaVerlagIDLabel"
        OriginaVerlagIDLabel.Size = New System.Drawing.Size(92, 13)
        OriginaVerlagIDLabel.TabIndex = 96
        OriginaVerlagIDLabel.Text = "Original Verlag ID:"
        '
        'OriginalLandIDLabel
        '
        OriginalLandIDLabel.AutoSize = True
        OriginalLandIDLabel.Location = New System.Drawing.Point(45, 186)
        OriginalLandIDLabel.Name = "OriginalLandIDLabel"
        OriginalLandIDLabel.Size = New System.Drawing.Size(86, 13)
        OriginalLandIDLabel.TabIndex = 98
        OriginalLandIDLabel.Text = "Original Land ID:"
        '
        'OriginalCopyrightLabel
        '
        OriginalCopyrightLabel.AutoSize = True
        OriginalCopyrightLabel.Location = New System.Drawing.Point(45, 238)
        OriginalCopyrightLabel.Name = "OriginalCopyrightLabel"
        OriginalCopyrightLabel.Size = New System.Drawing.Size(92, 13)
        OriginalCopyrightLabel.TabIndex = 102
        OriginalCopyrightLabel.Text = "Original Copyright:"
        '
        'LCCNLabel
        '
        LCCNLabel.AutoSize = True
        LCCNLabel.Location = New System.Drawing.Point(45, 41)
        LCCNLabel.Name = "LCCNLabel"
        LCCNLabel.Size = New System.Drawing.Size(38, 13)
        LCCNLabel.TabIndex = 68
        LCCNLabel.Text = "LCCN:"
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
        SeitenLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        SeitenLabel.Location = New System.Drawing.Point(694, 35)
        SeitenLabel.Name = "SeitenLabel"
        SeitenLabel.Size = New System.Drawing.Size(40, 13)
        SeitenLabel.TabIndex = 40
        SeitenLabel.Text = "Seiten:"
        '
        'DruckIDLabel1
        '
        DruckIDLabel1.AutoSize = True
        DruckIDLabel1.Location = New System.Drawing.Point(118, 162)
        DruckIDLabel1.Name = "DruckIDLabel1"
        DruckIDLabel1.Size = New System.Drawing.Size(53, 13)
        DruckIDLabel1.TabIndex = 154
        DruckIDLabel1.Text = "Druck ID:"
        '
        'AbschnitteLabel1
        '
        AbschnitteLabel1.AutoSize = True
        AbschnitteLabel1.Location = New System.Drawing.Point(114, 215)
        AbschnitteLabel1.Name = "AbschnitteLabel1"
        AbschnitteLabel1.Size = New System.Drawing.Size(60, 13)
        AbschnitteLabel1.TabIndex = 155
        AbschnitteLabel1.Text = "Abschnitte:"
        '
        'ZustandIDLabel1
        '
        ZustandIDLabel1.AutoSize = True
        ZustandIDLabel1.Location = New System.Drawing.Point(113, 241)
        ZustandIDLabel1.Name = "ZustandIDLabel1"
        ZustandIDLabel1.Size = New System.Drawing.Size(63, 13)
        ZustandIDLabel1.TabIndex = 156
        ZustandIDLabel1.Text = "Zustand ID:"
        '
        'Dim_HeightLabel1
        '
        Dim_HeightLabel1.AutoSize = True
        Dim_HeightLabel1.Location = New System.Drawing.Point(130, 64)
        Dim_HeightLabel1.Name = "Dim_HeightLabel1"
        Dim_HeightLabel1.Size = New System.Drawing.Size(62, 13)
        Dim_HeightLabel1.TabIndex = 157
        Dim_HeightLabel1.Text = "Dim Height:"
        '
        'VerkaufspreisLabel1
        '
        VerkaufspreisLabel1.AutoSize = True
        VerkaufspreisLabel1.Location = New System.Drawing.Point(479, 92)
        VerkaufspreisLabel1.Name = "VerkaufspreisLabel1"
        VerkaufspreisLabel1.Size = New System.Drawing.Size(74, 13)
        VerkaufspreisLabel1.TabIndex = 158
        VerkaufspreisLabel1.Text = "Verkaufspreis:"
        '
        'ErworbenLabel1
        '
        ErworbenLabel1.AutoSize = True
        ErworbenLabel1.Location = New System.Drawing.Point(473, 28)
        ErworbenLabel1.Name = "ErworbenLabel1"
        ErworbenLabel1.Size = New System.Drawing.Size(55, 13)
        ErworbenLabel1.TabIndex = 159
        ErworbenLabel1.Text = "Erworben:"
        '
        'LCCNLabel1
        '
        LCCNLabel1.AutoSize = True
        LCCNLabel1.Location = New System.Drawing.Point(116, 44)
        LCCNLabel1.Name = "LCCNLabel1"
        LCCNLabel1.Size = New System.Drawing.Size(38, 13)
        LCCNLabel1.TabIndex = 102
        LCCNLabel1.Text = "LCCN:"
        '
        'OriginalTitelLabel1
        '
        OriginalTitelLabel1.AutoSize = True
        OriginalTitelLabel1.Location = New System.Drawing.Point(156, 112)
        OriginalTitelLabel1.Name = "OriginalTitelLabel1"
        OriginalTitelLabel1.Size = New System.Drawing.Size(68, 13)
        OriginalTitelLabel1.TabIndex = 103
        OriginalTitelLabel1.Text = "Original Titel:"
        '
        'OriginalUntertitelLabel1
        '
        OriginalUntertitelLabel1.AutoSize = True
        OriginalUntertitelLabel1.Location = New System.Drawing.Point(169, 140)
        OriginalUntertitelLabel1.Name = "OriginalUntertitelLabel1"
        OriginalUntertitelLabel1.Size = New System.Drawing.Size(90, 13)
        OriginalUntertitelLabel1.TabIndex = 104
        OriginalUntertitelLabel1.Text = "Original Untertitel:"
        '
        'OriginaVerlagIDLabel1
        '
        OriginaVerlagIDLabel1.AutoSize = True
        OriginaVerlagIDLabel1.Location = New System.Drawing.Point(175, 168)
        OriginaVerlagIDLabel1.Name = "OriginaVerlagIDLabel1"
        OriginaVerlagIDLabel1.Size = New System.Drawing.Size(90, 13)
        OriginaVerlagIDLabel1.TabIndex = 105
        OriginaVerlagIDLabel1.Text = "Origina Verlag ID:"
        '
        'OriginalLandIDLabel1
        '
        OriginalLandIDLabel1.AutoSize = True
        OriginalLandIDLabel1.Location = New System.Drawing.Point(180, 194)
        OriginalLandIDLabel1.Name = "OriginalLandIDLabel1"
        OriginalLandIDLabel1.Size = New System.Drawing.Size(86, 13)
        OriginalLandIDLabel1.TabIndex = 106
        OriginalLandIDLabel1.Text = "Original Land ID:"
        '
        'OriginalCopyrightLabel1
        '
        OriginalCopyrightLabel1.AutoSize = True
        OriginalCopyrightLabel1.Location = New System.Drawing.Point(165, 241)
        OriginalCopyrightLabel1.Name = "OriginalCopyrightLabel1"
        OriginalCopyrightLabel1.Size = New System.Drawing.Size(92, 13)
        OriginalCopyrightLabel1.TabIndex = 107
        OriginalCopyrightLabel1.Text = "Original Copyright:"
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1106, 622)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 84)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1100, 497)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage1.Controls.Add(Me.CopyrightDatumTextBox)
        Me.TabPage1.Controls.Add(Me.VeroeffentlichtTextBox)
        Me.TabPage1.Controls.Add(Me.StichworteTextBox)
        Me.TabPage1.Controls.Add(Me.LetzteAenderungDateTimePicker)
        Me.TabPage1.Controls.Add(Me.ASINTextBox)
        Me.TabPage1.Controls.Add(Me.BarCodeTextBox)
        Me.TabPage1.Controls.Add(Me.DNBTextBox)
        Me.TabPage1.Controls.Add(Me.ISBNTextBox)
        Me.TabPage1.Controls.Add(Me.TitleSortTextBox)
        Me.TabPage1.Controls.Add(Me.TitelIndexTextBox)
        Me.TabPage1.Controls.Add(Me.AutorSortTextBox)
        Me.TabPage1.Controls.Add(Me.BtScann)
        Me.TabPage1.Controls.Add(Me.BtnAddAutor)
        Me.TabPage1.Controls.Add(Me.CBRolle)
        Me.TabPage1.Controls.Add(Me.CBPerson)
        Me.TabPage1.Controls.Add(Me.ComboBox6)
        Me.TabPage1.Controls.Add(BuchTypLabel)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.ImagePictureBox)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.BookIDTextBox)
        Me.TabPage1.Controls.Add(Me.btImageInput)
        Me.TabPage1.Controls.Add(Me.btPersonNeu)
        Me.TabPage1.Controls.Add(TitleSortLabel)
        Me.TabPage1.Controls.Add(TitelIndexLabel)
        Me.TabPage1.Controls.Add(Me.AutorBuchLinkDataGridView)
        Me.TabPage1.Controls.Add(Me.cbVerlagsOrt)
        Me.TabPage1.Controls.Add(DNBLabel)
        Me.TabPage1.Controls.Add(Me.ComboBox12)
        Me.TabPage1.Controls.Add(Me.ComboBox9)
        Me.TabPage1.Controls.Add(Me.lblSprache)
        Me.TabPage1.Controls.Add(Me.AuiflageTextBox)
        Me.TabPage1.Controls.Add(Me.cbBindung)
        Me.TabPage1.Controls.Add(Me.ComboBox7)
        Me.TabPage1.Controls.Add(Me.VerliehenCheckBox)
        Me.TabPage1.Controls.Add(StandortIDLabel)
        Me.TabPage1.Controls.Add(BarCodeLabel)
        Me.TabPage1.Controls.Add(ASINLabel)
        Me.TabPage1.Controls.Add(LetzteAenderungLabel)
        Me.TabPage1.Controls.Add(AutorSortLabel)
        Me.TabPage1.Controls.Add(VeroeffentlichtLabel)
        Me.TabPage1.Controls.Add(CopyrightDatumLabel)
        Me.TabPage1.Controls.Add(SerienIDLabel)
        Me.TabPage1.Controls.Add(VerlagsOrtIDLabel)
        Me.TabPage1.Controls.Add(StichworteLabel)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cbVerlag)
        Me.TabPage1.Controls.Add(PrintingIDLabel)
        Me.TabPage1.Controls.Add(AuflageIDLabel)
        Me.TabPage1.Controls.Add(BindungIDLabel)
        Me.TabPage1.Controls.Add(ISBNLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1092, 471)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Übersicht"
        '
        'CopyrightDatumTextBox
        '
        Me.CopyrightDatumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "CopyrightDatum", True))
        Me.CopyrightDatumTextBox.Location = New System.Drawing.Point(106, 344)
        Me.CopyrightDatumTextBox.Name = "CopyrightDatumTextBox"
        Me.CopyrightDatumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CopyrightDatumTextBox.TabIndex = 205
        '
        'BuchBindingSource
        '
        Me.BuchBindingSource.DataMember = "Buch"
        Me.BuchBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        '_BookCMS_singleDataSet
        '
        Me._BookCMS_singleDataSet.DataSetName = "_BookCMS_singleDataSet"
        Me._BookCMS_singleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VeroeffentlichtTextBox
        '
        Me.VeroeffentlichtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Veroeffentlicht", True))
        Me.VeroeffentlichtTextBox.Location = New System.Drawing.Point(106, 318)
        Me.VeroeffentlichtTextBox.Name = "VeroeffentlichtTextBox"
        Me.VeroeffentlichtTextBox.Size = New System.Drawing.Size(200, 20)
        Me.VeroeffentlichtTextBox.TabIndex = 204
        '
        'StichworteTextBox
        '
        Me.StichworteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Stichworte", True))
        Me.StichworteTextBox.Location = New System.Drawing.Point(106, 405)
        Me.StichworteTextBox.Name = "StichworteTextBox"
        Me.StichworteTextBox.Size = New System.Drawing.Size(566, 20)
        Me.StichworteTextBox.TabIndex = 203
        '
        'LetzteAenderungDateTimePicker
        '
        Me.LetzteAenderungDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BuchBindingSource, "LetzteAenderung", True))
        Me.LetzteAenderungDateTimePicker.Location = New System.Drawing.Point(472, 368)
        Me.LetzteAenderungDateTimePicker.Name = "LetzteAenderungDateTimePicker"
        Me.LetzteAenderungDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LetzteAenderungDateTimePicker.TabIndex = 202
        '
        'ASINTextBox
        '
        Me.ASINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "ASIN", True))
        Me.ASINTextBox.Location = New System.Drawing.Point(472, 239)
        Me.ASINTextBox.Name = "ASINTextBox"
        Me.ASINTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ASINTextBox.TabIndex = 201
        '
        'BarCodeTextBox
        '
        Me.BarCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "BarCode", True))
        Me.BarCodeTextBox.Location = New System.Drawing.Point(472, 215)
        Me.BarCodeTextBox.Name = "BarCodeTextBox"
        Me.BarCodeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BarCodeTextBox.TabIndex = 200
        '
        'DNBTextBox
        '
        Me.DNBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "DNB", True))
        Me.DNBTextBox.Location = New System.Drawing.Point(472, 265)
        Me.DNBTextBox.Name = "DNBTextBox"
        Me.DNBTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DNBTextBox.TabIndex = 199
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(472, 187)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ISBNTextBox.TabIndex = 198
        '
        'TitleSortTextBox
        '
        Me.TitleSortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "TitleSort", True))
        Me.TitleSortTextBox.Location = New System.Drawing.Point(472, 50)
        Me.TitleSortTextBox.Name = "TitleSortTextBox"
        Me.TitleSortTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TitleSortTextBox.TabIndex = 197
        '
        'TitelIndexTextBox
        '
        Me.TitelIndexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "TitelIndex", True))
        Me.TitelIndexTextBox.Location = New System.Drawing.Point(472, 24)
        Me.TitelIndexTextBox.Name = "TitelIndexTextBox"
        Me.TitelIndexTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TitelIndexTextBox.TabIndex = 196
        '
        'AutorSortTextBox
        '
        Me.AutorSortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "AutorSort", True))
        Me.AutorSortTextBox.Location = New System.Drawing.Point(106, 161)
        Me.AutorSortTextBox.Name = "AutorSortTextBox"
        Me.AutorSortTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AutorSortTextBox.TabIndex = 195
        '
        'BtScann
        '
        Me.BtScann.Location = New System.Drawing.Point(898, 247)
        Me.BtScann.Name = "BtScann"
        Me.BtScann.Size = New System.Drawing.Size(88, 23)
        Me.BtScann.TabIndex = 194
        Me.BtScann.Text = "Cover scannen"
        Me.BtScann.UseVisualStyleBackColor = True
        '
        'BtnAddAutor
        '
        Me.BtnAddAutor.Location = New System.Drawing.Point(41, 56)
        Me.BtnAddAutor.Name = "BtnAddAutor"
        Me.BtnAddAutor.Size = New System.Drawing.Size(111, 27)
        Me.BtnAddAutor.TabIndex = 193
        Me.BtnAddAutor.Text = "Übernehmen"
        Me.BtnAddAutor.UseVisualStyleBackColor = True
        '
        'CBRolle
        '
        Me.CBRolle.DataSource = Me.AutorRolleBindingSource1
        Me.CBRolle.DisplayMember = "AutorRolle"
        Me.CBRolle.FormattingEnabled = True
        Me.CBRolle.Location = New System.Drawing.Point(204, 30)
        Me.CBRolle.Name = "CBRolle"
        Me.CBRolle.Size = New System.Drawing.Size(102, 21)
        Me.CBRolle.TabIndex = 192
        Me.CBRolle.ValueMember = "ID"
        '
        'AutorRolleBindingSource1
        '
        Me.AutorRolleBindingSource1.DataMember = "AutorRolle"
        Me.AutorRolleBindingSource1.DataSource = Me._BookCMS_singleDataSet
        '
        'CBPerson
        '
        Me.CBPerson.DataSource = Me.PersonBindingSource1
        Me.CBPerson.DisplayMember = "SortBy"
        Me.CBPerson.FormattingEnabled = True
        Me.CBPerson.Location = New System.Drawing.Point(41, 30)
        Me.CBPerson.Name = "CBPerson"
        Me.CBPerson.Size = New System.Drawing.Size(157, 21)
        Me.CBPerson.TabIndex = 191
        Me.CBPerson.ValueMember = "PersonID"
        '
        'PersonBindingSource1
        '
        Me.PersonBindingSource1.DataMember = "Person"
        Me.PersonBindingSource1.DataSource = Me._BookCMS_singleDataSet
        '
        'ComboBox6
        '
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "TypID", True))
        Me.ComboBox6.DataSource = Me.BuchTypBindingSource
        Me.ComboBox6.DisplayMember = "BuchTyp"
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(475, 76)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(197, 21)
        Me.ComboBox6.TabIndex = 190
        Me.ComboBox6.ValueMember = "ID"
        '
        'BuchTypBindingSource
        '
        Me.BuchTypBindingSource.DataMember = "BuchTyp"
        Me.BuchTypBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "DruckereiID", True))
        Me.ComboBox1.DataSource = Me.DruckereiBindingSource
        Me.ComboBox1.DisplayMember = "Druckerei"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(106, 239)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 188
        Me.ComboBox1.ValueMember = "PrintedByID"
        '
        'DruckereiBindingSource
        '
        Me.DruckereiBindingSource.DataMember = "Druckerei"
        Me.DruckereiBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.Location = New System.Drawing.Point(727, 24)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(141, 177)
        Me.ImagePictureBox.TabIndex = 187
        Me.ImagePictureBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(895, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 122)
        Me.PictureBox1.TabIndex = 186
        Me.PictureBox1.TabStop = False
        '
        'BookIDTextBox
        '
        Me.BookIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BookIDTextBox.Location = New System.Drawing.Point(727, 293)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.ReadOnly = True
        Me.BookIDTextBox.Size = New System.Drawing.Size(67, 20)
        Me.BookIDTextBox.TabIndex = 184
        '
        'btImageInput
        '
        Me.btImageInput.Location = New System.Drawing.Point(727, 237)
        Me.btImageInput.Name = "btImageInput"
        Me.btImageInput.Size = New System.Drawing.Size(142, 43)
        Me.btImageInput.TabIndex = 182
        Me.btImageInput.Text = "Cover aus Zwischenablage"
        Me.btImageInput.UseVisualStyleBackColor = True
        '
        'btPersonNeu
        '
        Me.btPersonNeu.Location = New System.Drawing.Point(319, 21)
        Me.btPersonNeu.Name = "btPersonNeu"
        Me.btPersonNeu.Size = New System.Drawing.Size(75, 37)
        Me.btPersonNeu.TabIndex = 179
        Me.btPersonNeu.Text = "Neue Person"
        Me.btPersonNeu.UseVisualStyleBackColor = True
        '
        'AutorBuchLinkDataGridView
        '
        Me.AutorBuchLinkDataGridView.AllowUserToAddRows = False
        Me.AutorBuchLinkDataGridView.AllowUserToDeleteRows = False
        Me.AutorBuchLinkDataGridView.AutoGenerateColumns = False
        Me.AutorBuchLinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AutorBuchLinkDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BuchIDDataGridViewTextBoxColumn, Me.PersonIDDataGridViewTextBoxColumn, Me.RolleIDDataGridViewTextBoxColumn})
        Me.AutorBuchLinkDataGridView.DataSource = Me.AutorBuchLinkBindingSource
        Me.AutorBuchLinkDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.AutorBuchLinkDataGridView.Location = New System.Drawing.Point(39, 89)
        Me.AutorBuchLinkDataGridView.Name = "AutorBuchLinkDataGridView"
        Me.AutorBuchLinkDataGridView.RowHeadersVisible = False
        Me.AutorBuchLinkDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AutorBuchLinkDataGridView.Size = New System.Drawing.Size(266, 63)
        Me.AutorBuchLinkDataGridView.TabIndex = 176
        '
        'BuchIDDataGridViewTextBoxColumn
        '
        Me.BuchIDDataGridViewTextBoxColumn.DataPropertyName = "BuchID"
        Me.BuchIDDataGridViewTextBoxColumn.HeaderText = "BuchID"
        Me.BuchIDDataGridViewTextBoxColumn.Name = "BuchIDDataGridViewTextBoxColumn"
        Me.BuchIDDataGridViewTextBoxColumn.Visible = False
        '
        'PersonIDDataGridViewTextBoxColumn
        '
        Me.PersonIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID"
        Me.PersonIDDataGridViewTextBoxColumn.DataSource = Me.PersonBindingSource
        Me.PersonIDDataGridViewTextBoxColumn.DisplayMember = "SortBy"
        Me.PersonIDDataGridViewTextBoxColumn.HeaderText = "Person"
        Me.PersonIDDataGridViewTextBoxColumn.Name = "PersonIDDataGridViewTextBoxColumn"
        Me.PersonIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PersonIDDataGridViewTextBoxColumn.ValueMember = "PersonID"
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'RolleIDDataGridViewTextBoxColumn
        '
        Me.RolleIDDataGridViewTextBoxColumn.DataPropertyName = "RolleID"
        Me.RolleIDDataGridViewTextBoxColumn.DataSource = Me.AutorRolleBindingSource
        Me.RolleIDDataGridViewTextBoxColumn.DisplayMember = "AutorRolle"
        Me.RolleIDDataGridViewTextBoxColumn.HeaderText = "RolleID"
        Me.RolleIDDataGridViewTextBoxColumn.Name = "RolleIDDataGridViewTextBoxColumn"
        Me.RolleIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RolleIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.RolleIDDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'AutorRolleBindingSource
        '
        Me.AutorRolleBindingSource.DataMember = "AutorRolle"
        Me.AutorRolleBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'AutorBuchLinkBindingSource
        '
        Me.AutorBuchLinkBindingSource.DataMember = "AutorBuchLink"
        Me.AutorBuchLinkBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'cbVerlagsOrt
        '
        Me.cbVerlagsOrt.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "VerlagsOrtID", True))
        Me.cbVerlagsOrt.DataSource = Me.VerlagsOrtBindingSource
        Me.cbVerlagsOrt.DisplayMember = "Verlagsort"
        Me.cbVerlagsOrt.FormattingEnabled = True
        Me.cbVerlagsOrt.Location = New System.Drawing.Point(106, 210)
        Me.cbVerlagsOrt.Name = "cbVerlagsOrt"
        Me.cbVerlagsOrt.Size = New System.Drawing.Size(200, 21)
        Me.cbVerlagsOrt.TabIndex = 175
        Me.cbVerlagsOrt.ValueMember = "ID"
        '
        'VerlagsOrtBindingSource
        '
        Me.VerlagsOrtBindingSource.DataMember = "VerlagsOrt"
        Me.VerlagsOrtBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'ComboBox12
        '
        Me.ComboBox12.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "SerienID", True))
        Me.ComboBox12.DataSource = Me.SerienBindingSource
        Me.ComboBox12.DisplayMember = "Serie"
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Location = New System.Drawing.Point(472, 125)
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
        Me.ComboBox9.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "SprachenID", True))
        Me.ComboBox9.DataSource = Me.LanguageBindingSource
        Me.ComboBox9.DisplayMember = "Language"
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Location = New System.Drawing.Point(472, 291)
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
        Me.lblSprache.Location = New System.Drawing.Point(407, 293)
        Me.lblSprache.Name = "lblSprache"
        Me.lblSprache.Size = New System.Drawing.Size(50, 13)
        Me.lblSprache.TabIndex = 168
        Me.lblSprache.Text = "Sprache:"
        '
        'AuiflageTextBox
        '
        Me.AuiflageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Auiflage", True))
        Me.AuiflageTextBox.Location = New System.Drawing.Point(472, 149)
        Me.AuiflageTextBox.Name = "AuiflageTextBox"
        Me.AuiflageTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AuiflageTextBox.TabIndex = 161
        '
        'cbBindung
        '
        Me.cbBindung.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "BindungID", True))
        Me.cbBindung.DataSource = Me.BindungBindingSource
        Me.cbBindung.DisplayMember = "Bindung"
        Me.cbBindung.FormattingEnabled = True
        Me.cbBindung.Location = New System.Drawing.Point(106, 264)
        Me.cbBindung.Name = "cbBindung"
        Me.cbBindung.Size = New System.Drawing.Size(200, 21)
        Me.cbBindung.TabIndex = 160
        Me.cbBindung.ValueMember = "BindingID"
        '
        'BindungBindingSource
        '
        Me.BindungBindingSource.DataMember = "Bindung"
        Me.BindungBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'ComboBox7
        '
        Me.ComboBox7.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "StandortID", True))
        Me.ComboBox7.DataSource = Me.StandortBindingSource
        Me.ComboBox7.DisplayMember = "Standort"
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(106, 370)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(200, 21)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Verlag:"
        '
        'cbVerlag
        '
        Me.cbVerlag.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "VerlagsID", True))
        Me.cbVerlag.DataSource = Me.VerlagBindingSource
        Me.cbVerlag.DisplayMember = "Verlag"
        Me.cbVerlag.FormattingEnabled = True
        Me.cbVerlag.Location = New System.Drawing.Point(106, 184)
        Me.cbVerlag.Name = "cbVerlag"
        Me.cbVerlag.Size = New System.Drawing.Size(200, 21)
        Me.cbVerlag.TabIndex = 42
        Me.cbVerlag.ValueMember = "PublisherID"
        '
        'VerlagBindingSource
        '
        Me.VerlagBindingSource.DataMember = "Verlag"
        Me.VerlagBindingSource.DataSource = Me._BookCMS_singleDataSet
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
        Me.TabPage5.Controls.Add(SachgruppeIDLabel)
        Me.TabPage5.Controls.Add(Me.DDCTextBox)
        Me.TabPage5.Controls.Add(DDCLabel)
        Me.TabPage5.Controls.Add(Me.CheckedListBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1092, 471)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Genre"
        '
        'GenreLinkDataGridView
        '
        Me.GenreLinkDataGridView.AllowUserToAddRows = False
        Me.GenreLinkDataGridView.AutoGenerateColumns = False
        Me.GenreLinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GenreLinkDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BuchIDDataGridViewTextBoxColumn1, Me.SachgruppeIDDataGridViewTextBoxColumn})
        Me.GenreLinkDataGridView.DataSource = Me.GenreLinkBindingSource
        Me.GenreLinkDataGridView.Location = New System.Drawing.Point(665, 64)
        Me.GenreLinkDataGridView.Name = "GenreLinkDataGridView"
        Me.GenreLinkDataGridView.Size = New System.Drawing.Size(202, 90)
        Me.GenreLinkDataGridView.TabIndex = 172
        '
        'BuchIDDataGridViewTextBoxColumn1
        '
        Me.BuchIDDataGridViewTextBoxColumn1.DataPropertyName = "BuchID"
        Me.BuchIDDataGridViewTextBoxColumn1.HeaderText = "BuchID"
        Me.BuchIDDataGridViewTextBoxColumn1.Name = "BuchIDDataGridViewTextBoxColumn1"
        '
        'SachgruppeIDDataGridViewTextBoxColumn
        '
        Me.SachgruppeIDDataGridViewTextBoxColumn.DataPropertyName = "SachgruppeID"
        Me.SachgruppeIDDataGridViewTextBoxColumn.HeaderText = "SachgruppeID"
        Me.SachgruppeIDDataGridViewTextBoxColumn.Name = "SachgruppeIDDataGridViewTextBoxColumn"
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
        'DDCTextBox
        '
        Me.DDCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "DDC", True))
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
        Me.TabPage2.Controls.Add(ErworbenLabel1)
        Me.TabPage2.Controls.Add(Me.ErworbenTextBox)
        Me.TabPage2.Controls.Add(VerkaufspreisLabel1)
        Me.TabPage2.Controls.Add(Me.VerkaufspreisTextBox)
        Me.TabPage2.Controls.Add(Dim_HeightLabel1)
        Me.TabPage2.Controls.Add(Me.Dim_HeightTextBox)
        Me.TabPage2.Controls.Add(ZustandIDLabel1)
        Me.TabPage2.Controls.Add(Me.ZustandIDTextBox)
        Me.TabPage2.Controls.Add(AbschnitteLabel1)
        Me.TabPage2.Controls.Add(Me.AbschnitteTextBox)
        Me.TabPage2.Controls.Add(DruckIDLabel1)
        Me.TabPage2.Controls.Add(Me.DruckIDTextBox)
        Me.TabPage2.Controls.Add(DruckIDLabel)
        Me.TabPage2.Controls.Add(AbschnitteLabel)
        Me.TabPage2.Controls.Add(ZustandIDLabel)
        Me.TabPage2.Controls.Add(ErworbenLabel)
        Me.TabPage2.Controls.Add(VerkaufspreisLabel)
        Me.TabPage2.Controls.Add(Dim_HeightLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1092, 471)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Druckdaten"
        '
        'ErworbenTextBox
        '
        Me.ErworbenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Erworben", True))
        Me.ErworbenTextBox.Location = New System.Drawing.Point(534, 25)
        Me.ErworbenTextBox.Name = "ErworbenTextBox"
        Me.ErworbenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ErworbenTextBox.TabIndex = 160
        '
        'VerkaufspreisTextBox
        '
        Me.VerkaufspreisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Verkaufspreis", True))
        Me.VerkaufspreisTextBox.Location = New System.Drawing.Point(559, 89)
        Me.VerkaufspreisTextBox.Name = "VerkaufspreisTextBox"
        Me.VerkaufspreisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VerkaufspreisTextBox.TabIndex = 159
        '
        'Dim_HeightTextBox
        '
        Me.Dim_HeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Dim_Height", True))
        Me.Dim_HeightTextBox.Location = New System.Drawing.Point(198, 61)
        Me.Dim_HeightTextBox.Name = "Dim_HeightTextBox"
        Me.Dim_HeightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dim_HeightTextBox.TabIndex = 158
        '
        'ZustandIDTextBox
        '
        Me.ZustandIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "ZustandID", True))
        Me.ZustandIDTextBox.Location = New System.Drawing.Point(182, 238)
        Me.ZustandIDTextBox.Name = "ZustandIDTextBox"
        Me.ZustandIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZustandIDTextBox.TabIndex = 157
        '
        'AbschnitteTextBox
        '
        Me.AbschnitteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Abschnitte", True))
        Me.AbschnitteTextBox.Location = New System.Drawing.Point(180, 212)
        Me.AbschnitteTextBox.Name = "AbschnitteTextBox"
        Me.AbschnitteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AbschnitteTextBox.TabIndex = 156
        '
        'DruckIDTextBox
        '
        Me.DruckIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "DruckID", True))
        Me.DruckIDTextBox.Location = New System.Drawing.Point(177, 159)
        Me.DruckIDTextBox.Name = "DruckIDTextBox"
        Me.DruckIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DruckIDTextBox.TabIndex = 155
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage3.Controls.Add(OriginalCopyrightLabel1)
        Me.TabPage3.Controls.Add(Me.OriginalCopyrightTextBox)
        Me.TabPage3.Controls.Add(OriginalLandIDLabel1)
        Me.TabPage3.Controls.Add(Me.OriginalLandIDTextBox)
        Me.TabPage3.Controls.Add(OriginaVerlagIDLabel1)
        Me.TabPage3.Controls.Add(Me.OriginaVerlagIDTextBox)
        Me.TabPage3.Controls.Add(OriginalUntertitelLabel1)
        Me.TabPage3.Controls.Add(Me.OriginalUntertitelTextBox)
        Me.TabPage3.Controls.Add(OriginalTitelLabel1)
        Me.TabPage3.Controls.Add(Me.OriginalTitelTextBox)
        Me.TabPage3.Controls.Add(LCCNLabel1)
        Me.TabPage3.Controls.Add(Me.LCCNTextBox)
        Me.TabPage3.Controls.Add(OriginalTitelLabel)
        Me.TabPage3.Controls.Add(OriginalUntertitelLabel)
        Me.TabPage3.Controls.Add(OriginaVerlagIDLabel)
        Me.TabPage3.Controls.Add(OriginalLandIDLabel)
        Me.TabPage3.Controls.Add(OriginalCopyrightLabel)
        Me.TabPage3.Controls.Add(LCCNLabel)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1092, 471)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Original"
        '
        'OriginalCopyrightTextBox
        '
        Me.OriginalCopyrightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "OriginalCopyright", True))
        Me.OriginalCopyrightTextBox.Location = New System.Drawing.Point(263, 238)
        Me.OriginalCopyrightTextBox.Name = "OriginalCopyrightTextBox"
        Me.OriginalCopyrightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OriginalCopyrightTextBox.TabIndex = 108
        '
        'OriginalLandIDTextBox
        '
        Me.OriginalLandIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "OriginalLandID", True))
        Me.OriginalLandIDTextBox.Location = New System.Drawing.Point(272, 191)
        Me.OriginalLandIDTextBox.Name = "OriginalLandIDTextBox"
        Me.OriginalLandIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OriginalLandIDTextBox.TabIndex = 107
        '
        'OriginaVerlagIDTextBox
        '
        Me.OriginaVerlagIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "OriginaVerlagID", True))
        Me.OriginaVerlagIDTextBox.Location = New System.Drawing.Point(271, 165)
        Me.OriginaVerlagIDTextBox.Name = "OriginaVerlagIDTextBox"
        Me.OriginaVerlagIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OriginaVerlagIDTextBox.TabIndex = 106
        '
        'OriginalUntertitelTextBox
        '
        Me.OriginalUntertitelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "OriginalUntertitel", True))
        Me.OriginalUntertitelTextBox.Location = New System.Drawing.Point(265, 137)
        Me.OriginalUntertitelTextBox.Name = "OriginalUntertitelTextBox"
        Me.OriginalUntertitelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OriginalUntertitelTextBox.TabIndex = 105
        '
        'OriginalTitelTextBox
        '
        Me.OriginalTitelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "OriginalTitel", True))
        Me.OriginalTitelTextBox.Location = New System.Drawing.Point(230, 109)
        Me.OriginalTitelTextBox.Name = "OriginalTitelTextBox"
        Me.OriginalTitelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OriginalTitelTextBox.TabIndex = 104
        '
        'LCCNTextBox
        '
        Me.LCCNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "LCCN", True))
        Me.LCCNTextBox.Location = New System.Drawing.Point(160, 41)
        Me.LCCNTextBox.Name = "LCCNTextBox"
        Me.LCCNTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LCCNTextBox.TabIndex = 103
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
        Me.TabPage4.Size = New System.Drawing.Size(1092, 471)
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
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.TitelTextBox)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(Me.MarkedCheckBox)
        Me.Panel1.Controls.Add(Me.UntertitelTextBox)
        Me.Panel1.Controls.Add(TitelLabel)
        Me.Panel1.Controls.Add(UntertitelLabel)
        Me.Panel1.Controls.Add(Me.SignaturTextBox)
        Me.Panel1.Controls.Add(SignaturLabel)
        Me.Panel1.Controls.Add(Me.SeitenTextBox)
        Me.Panel1.Controls.Add(SeitenLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 75)
        Me.Panel1.TabIndex = 3
        '
        'TitelTextBox
        '
        Me.TitelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Titel", True))
        Me.TitelTextBox.Location = New System.Drawing.Point(77, 10)
        Me.TitelTextBox.Name = "TitelTextBox"
        Me.TitelTextBox.Size = New System.Drawing.Size(570, 20)
        Me.TitelTextBox.TabIndex = 175
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(923, 10)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(67, 20)
        Me.IDTextBox.TabIndex = 174
        '
        'MarkedCheckBox
        '
        Me.MarkedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Marked", True))
        Me.MarkedCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MarkedCheckBox.Location = New System.Drawing.Point(697, 47)
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
        'SignaturTextBox
        '
        Me.SignaturTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Signatur", True))
        Me.SignaturTextBox.Location = New System.Drawing.Point(780, 10)
        Me.SignaturTextBox.Name = "SignaturTextBox"
        Me.SignaturTextBox.Size = New System.Drawing.Size(60, 20)
        Me.SignaturTextBox.TabIndex = 5
        '
        'SeitenTextBox
        '
        Me.SeitenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Seiten", True))
        Me.SeitenTextBox.Location = New System.Drawing.Point(780, 32)
        Me.SeitenTextBox.Name = "SeitenTextBox"
        Me.SeitenTextBox.Size = New System.Drawing.Size(60, 20)
        Me.SeitenTextBox.TabIndex = 41
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 587)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1100, 32)
        Me.Panel2.TabIndex = 4
        '
        'btClose
        '
        Me.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClose.Location = New System.Drawing.Point(479, 6)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 23)
        Me.btClose.TabIndex = 0
        Me.btClose.Text = "Zurück"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'AutorBuchLinkTableAdapter
        '
        Me.AutorBuchLinkTableAdapter.ClearBeforeFill = True
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'AutorRolleTableAdapter
        '
        Me.AutorRolleTableAdapter.ClearBeforeFill = True
        '
        'BuchTableAdapter
        '
        Me.BuchTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutorBuchLinkTableAdapter = Me.AutorBuchLinkTableAdapter
        Me.TableAdapterManager.AutorRolleTableAdapter = Me.AutorRolleTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BibliothekTableAdapter = Nothing
        Me.TableAdapterManager.BindungTableAdapter = Me.BindungTableAdapter
        Me.TableAdapterManager.BuchTableAdapter = Me.BuchTableAdapter
        Me.TableAdapterManager.BuchTypTableAdapter = Me.BuchTypTableAdapter
        Me.TableAdapterManager.DDCTableAdapter = Nothing
        Me.TableAdapterManager.DruckereiTableAdapter = Me.DruckereiTableAdapter
        Me.TableAdapterManager.EditionTableAdapter = Nothing
        Me.TableAdapterManager.GenreLinkTableAdapter = Me.GenreLinkTableAdapter
        Me.TableAdapterManager.LandTableAdapter = Nothing
        Me.TableAdapterManager.LanguageTableAdapter = Me.LanguageTableAdapter
        Me.TableAdapterManager.PersonTableAdapter = Me.PersonTableAdapter
        Me.TableAdapterManager.SachgruppeTableAdapter = Me.SachgruppeTableAdapter
        Me.TableAdapterManager.SerienTableAdapter = Me.SerienTableAdapter
        Me.TableAdapterManager.StandortTableAdapter = Me.StandortTableAdapter
        Me.TableAdapterManager.UpdateOrder = BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VerlagsOrtTableAdapter = Me.VerlagsOrtTableAdapter
        Me.TableAdapterManager.VerlagTableAdapter = Me.VerlagTableAdapter
        '
        'BindungTableAdapter
        '
        Me.BindungTableAdapter.ClearBeforeFill = True
        '
        'BuchTypTableAdapter
        '
        Me.BuchTypTableAdapter.ClearBeforeFill = True
        '
        'DruckereiTableAdapter
        '
        Me.DruckereiTableAdapter.ClearBeforeFill = True
        '
        'GenreLinkTableAdapter
        '
        Me.GenreLinkTableAdapter.ClearBeforeFill = True
        '
        'LanguageTableAdapter
        '
        Me.LanguageTableAdapter.ClearBeforeFill = True
        '
        'SachgruppeTableAdapter
        '
        Me.SachgruppeTableAdapter.ClearBeforeFill = True
        '
        'SerienTableAdapter
        '
        Me.SerienTableAdapter.ClearBeforeFill = True
        '
        'StandortTableAdapter
        '
        Me.StandortTableAdapter.ClearBeforeFill = True
        '
        'VerlagsOrtTableAdapter
        '
        Me.VerlagsOrtTableAdapter.ClearBeforeFill = True
        '
        'VerlagTableAdapter
        '
        Me.VerlagTableAdapter.ClearBeforeFill = True
        '
        'BuchNeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 622)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "BuchNeu"
        Me.Text = "BookCMS - Neues Buch"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.BuchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorRolleBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuchTypBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DruckereiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorBuchLinkDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorRolleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorBuchLinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerlagsOrtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtScann As Button
    Friend WithEvents BtnAddAutor As Button
    Friend WithEvents CBRolle As ComboBox
    Friend WithEvents CBPerson As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BookIDTextBox As TextBox
    Friend WithEvents btImageInput As Button
    Friend WithEvents btPersonNeu As Button
    Friend WithEvents AutorBuchLinkDataGridView As DataGridView
    Friend WithEvents cbVerlagsOrt As ComboBox
    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents lblSprache As Label
    Friend WithEvents AuiflageTextBox As TextBox
    Friend WithEvents cbBindung As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents VerliehenCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbVerlag As ComboBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GenreLinkDataGridView As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents DDCTextBox As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Synopsis_PlainTextTextBox As TextBox
    Friend WithEvents Reviews_PlainTextTextBox As TextBox
    Friend WithEvents Anmerkungen_PlainTextTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TitelTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents MarkedCheckBox As CheckBox
    Friend WithEvents UntertitelTextBox As TextBox
    Friend WithEvents SignaturTextBox As TextBox
    Friend WithEvents SeitenTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btClose As Button
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents AutorBuchLinkBindingSource As BindingSource
    Friend WithEvents AutorBuchLinkTableAdapter As _BookCMS_singleDataSetTableAdapters.AutorBuchLinkTableAdapter
    Friend WithEvents PersonBindingSource As BindingSource
    Friend WithEvents PersonTableAdapter As _BookCMS_singleDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents AutorRolleBindingSource As BindingSource
    Friend WithEvents AutorRolleTableAdapter As _BookCMS_singleDataSetTableAdapters.AutorRolleTableAdapter
    Friend WithEvents AutorRolleBindingSource1 As BindingSource
    Friend WithEvents PersonBindingSource1 As BindingSource
    Friend WithEvents BuchIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonIDDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents RolleIDDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents BuchBindingSource As BindingSource
    Friend WithEvents BuchTableAdapter As _BookCMS_singleDataSetTableAdapters.BuchTableAdapter
    Friend WithEvents CopyrightDatumTextBox As TextBox
    Friend WithEvents VeroeffentlichtTextBox As TextBox
    Friend WithEvents StichworteTextBox As TextBox
    Friend WithEvents LetzteAenderungDateTimePicker As DateTimePicker
    Friend WithEvents ASINTextBox As TextBox
    Friend WithEvents BarCodeTextBox As TextBox
    Friend WithEvents DNBTextBox As TextBox
    Friend WithEvents ISBNTextBox As TextBox
    Friend WithEvents TitleSortTextBox As TextBox
    Friend WithEvents TitelIndexTextBox As TextBox
    Friend WithEvents AutorSortTextBox As TextBox
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VerlagTableAdapter As _BookCMS_singleDataSetTableAdapters.VerlagTableAdapter
    Friend WithEvents VerlagBindingSource As BindingSource
    Friend WithEvents VerlagsOrtTableAdapter As _BookCMS_singleDataSetTableAdapters.VerlagsOrtTableAdapter
    Friend WithEvents VerlagsOrtBindingSource As BindingSource
    Friend WithEvents DruckereiTableAdapter As _BookCMS_singleDataSetTableAdapters.DruckereiTableAdapter
    Friend WithEvents DruckereiBindingSource As BindingSource
    Friend WithEvents BindungTableAdapter As _BookCMS_singleDataSetTableAdapters.BindungTableAdapter
    Friend WithEvents BindungBindingSource As BindingSource
    Friend WithEvents StandortTableAdapter As _BookCMS_singleDataSetTableAdapters.StandortTableAdapter
    Friend WithEvents StandortBindingSource As BindingSource
    Friend WithEvents BuchTypTableAdapter As _BookCMS_singleDataSetTableAdapters.BuchTypTableAdapter
    Friend WithEvents BuchTypBindingSource As BindingSource
    Friend WithEvents SerienTableAdapter As _BookCMS_singleDataSetTableAdapters.SerienTableAdapter
    Friend WithEvents SerienBindingSource As BindingSource
    Friend WithEvents LanguageTableAdapter As _BookCMS_singleDataSetTableAdapters.LanguageTableAdapter
    Friend WithEvents LanguageBindingSource As BindingSource
    Friend WithEvents SachgruppeTableAdapter As _BookCMS_singleDataSetTableAdapters.SachgruppeTableAdapter
    Friend WithEvents SachgruppeBindingSource As BindingSource
    Friend WithEvents GenreLinkTableAdapter As _BookCMS_singleDataSetTableAdapters.GenreLinkTableAdapter
    Friend WithEvents GenreLinkBindingSource As BindingSource
    Friend WithEvents BuchIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SachgruppeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ErworbenTextBox As TextBox
    Friend WithEvents VerkaufspreisTextBox As TextBox
    Friend WithEvents Dim_HeightTextBox As TextBox
    Friend WithEvents ZustandIDTextBox As TextBox
    Friend WithEvents AbschnitteTextBox As TextBox
    Friend WithEvents DruckIDTextBox As TextBox
    Friend WithEvents OriginalCopyrightTextBox As TextBox
    Friend WithEvents OriginalLandIDTextBox As TextBox
    Friend WithEvents OriginaVerlagIDTextBox As TextBox
    Friend WithEvents OriginalUntertitelTextBox As TextBox
    Friend WithEvents OriginalTitelTextBox As TextBox
    Friend WithEvents LCCNTextBox As TextBox
End Class
