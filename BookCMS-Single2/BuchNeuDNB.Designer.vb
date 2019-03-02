<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuchNeuDNB
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
        Dim SignaturLabel As System.Windows.Forms.Label
        Dim UntertitelLabel As System.Windows.Forms.Label
        Dim TitelLabel As System.Windows.Forms.Label
        Dim LetzteAenderungLabel As System.Windows.Forms.Label
        Dim TitelIndexLabel As System.Windows.Forms.Label
        Dim StichworteLabel As System.Windows.Forms.Label
        Dim Anmerkungen_PlainTextLabel As System.Windows.Forms.Label
        Dim Synopsis_PlainTextLabel1 As System.Windows.Forms.Label
        Dim AuiflageLabel As System.Windows.Forms.Label
        Dim SeitenLabel As System.Windows.Forms.Label
        Dim BarCodeLabel As System.Windows.Forms.Label
        Dim Dim_HeightLabel As System.Windows.Forms.Label
        Dim VerlagsIDLabel As System.Windows.Forms.Label
        Dim OriginalTitelLabel As System.Windows.Forms.Label
        Dim OriginalUntertitelLabel As System.Windows.Forms.Label
        Dim VerkaufspreisLabel As System.Windows.Forms.Label
        Dim VeroeffentlichtLabel As System.Windows.Forms.Label
        Dim DruckereiIDLabel1 As System.Windows.Forms.Label
        Dim BindungIDLabel As System.Windows.Forms.Label
        Dim SerienIDLabel As System.Windows.Forms.Label
        Dim LandDLabel As System.Windows.Forms.Label
        Dim CopyrightDatumLabel As System.Windows.Forms.Label
        Dim SprachenIDLabel As System.Windows.Forms.Label
        Dim OriginalSpracheIDLabel As System.Windows.Forms.Label
        Dim LCCNLabel As System.Windows.Forms.Label
        Dim DDCLabel As System.Windows.Forms.Label
        Dim AutorSortLabel As System.Windows.Forms.Label
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim DNBLabel As System.Windows.Forms.Label
        Dim BuchTypLabel As System.Windows.Forms.Label
        Dim SachgruppeIDLabel As System.Windows.Forms.Label
        Dim VerlagsortLabel As System.Windows.Forms.Label
        Dim TitleSortLabel As System.Windows.Forms.Label
        Dim IdLabel2 As System.Windows.Forms.Label
        Dim BookIDLabel1 As System.Windows.Forms.Label
        Dim BibliothekLabel As System.Windows.Forms.Label
        Me.BuchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.VerlagsOrtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VerlagBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenreLinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuchTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.BuchTableAdapter()
        Me.AutorBuchLinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutorBuchLinkTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.AutorBuchLinkTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.AutorRolleTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.AutorRolleTableAdapter()
        Me.BibliothekTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.BibliothekTableAdapter()
        Me.BindungTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.BindungTableAdapter()
        Me.BuchTypTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.BuchTypTableAdapter()
        Me.DruckereiTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.DruckereiTableAdapter()
        Me.GenreLinkTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.GenreLinkTableAdapter()
        Me.LandTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.LandTableAdapter()
        Me.LanguageTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.LanguageTableAdapter()
        Me.PersonTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.PersonTableAdapter()
        Me.SachgruppeTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.SachgruppeTableAdapter()
        Me.VerlagsOrtTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.VerlagsOrtTableAdapter()
        Me.VerlagTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.VerlagTableAdapter()
        Me.NewDataSet = New BookCMS_Single2.NewDataSet()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ListBoxTitel = New System.Windows.Forms.ListBox()
        Me.lblBestand = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.BibliothekBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BibliothekTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LetzteAenderungTextBox = New System.Windows.Forms.TextBox()
        Me.TitelIndexTextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtSignatur = New System.Windows.Forms.TextBox()
        Me.SignaturTextBox = New System.Windows.Forms.TextBox()
        Me.TxtUTitel = New System.Windows.Forms.TextBox()
        Me.TxtTitel = New System.Windows.Forms.TextBox()
        Me.TitelTextBox = New System.Windows.Forms.TextBox()
        Me.UntertitelTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleSortTextBox = New System.Windows.Forms.TextBox()
        Me.OrtIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.StandortIDTextBox = New System.Windows.Forms.TextBox()
        Me.SachgruppeIDTextBox = New System.Windows.Forms.TextBox()
        Me.TypIDTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.SachgruppeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.BuchTypBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.StandortBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AutorBuchLinkDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuchIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RolleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AutorRolleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DNBTextBox = New System.Windows.Forms.TextBox()
        Me.txtDDC = New System.Windows.Forms.TextBox()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtDNB = New System.Windows.Forms.TextBox()
        Me.txtLCCN = New System.Windows.Forms.TextBox()
        Me.AutorSortTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LanguageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DDCTextBox = New System.Windows.Forms.TextBox()
        Me.SprachenIDTextBox = New System.Windows.Forms.TextBox()
        Me.LCCNTextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox23 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox22 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox27 = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.LandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OriginalSpracheIDTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DruckereiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CopyrightDatumTextBox = New System.Windows.Forms.TextBox()
        Me.LandDTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.SerienIDTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.BindungBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindungIDTextBox = New System.Windows.Forms.TextBox()
        Me.DruckereiIDTextBox = New System.Windows.Forms.TextBox()
        Me.VeroeffentlichtTextBox = New System.Windows.Forms.TextBox()
        Me.VerkaufspreisTextBox = New System.Windows.Forms.TextBox()
        Me.OriginalUntertitelTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.OriginalTitelTextBox = New System.Windows.Forms.TextBox()
        Me.txtGroesse = New System.Windows.Forms.TextBox()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.VerlagsIDTextBox = New System.Windows.Forms.TextBox()
        Me.txtPreis = New System.Windows.Forms.TextBox()
        Me.txtOrgLang = New System.Windows.Forms.TextBox()
        Me.txtOrgUT = New System.Windows.Forms.TextBox()
        Me.txtOrgTitel = New System.Windows.Forms.TextBox()
        Me.txtSeiten = New System.Windows.Forms.TextBox()
        Me.Dim_HeightTextBox = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.BarCodeTextBox = New System.Windows.Forms.TextBox()
        Me.txtAuflage = New System.Windows.Forms.TextBox()
        Me.txtAutorArt = New System.Windows.Forms.TextBox()
        Me.txtPersonArt = New System.Windows.Forms.TextBox()
        Me.txtPerson = New System.Windows.Forms.TextBox()
        Me.txtBindung = New System.Windows.Forms.TextBox()
        Me.txtDruckerei = New System.Windows.Forms.TextBox()
        Me.SeitenTextBox = New System.Windows.Forms.TextBox()
        Me.txtSprache = New System.Windows.Forms.TextBox()
        Me.txtLand = New System.Windows.Forms.TextBox()
        Me.AuiflageTextBox = New System.Windows.Forms.TextBox()
        Me.txtVerlagOrt = New System.Windows.Forms.TextBox()
        Me.txtVerlag = New System.Windows.Forms.TextBox()
        Me.txtCopyrDat = New System.Windows.Forms.TextBox()
        Me.txtVeroeff = New System.Windows.Forms.TextBox()
        Me.txtAutorSort = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GenreLinkDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuchIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SachgruppeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxGenre = New System.Windows.Forms.ListBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckBox26 = New System.Windows.Forms.CheckBox()
        Me.CheckBox25 = New System.Windows.Forms.CheckBox()
        Me.CheckBox24 = New System.Windows.Forms.CheckBox()
        Me.txtKurz = New System.Windows.Forms.TextBox()
        Me.Synopsis_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.Anmerkungen_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.StichworteTextBox = New System.Windows.Forms.TextBox()
        Me.txtStWorte = New System.Windows.Forms.TextBox()
        Me.txtAnmerk = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btMarc21 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btSvae = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.CheckBoxCover = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblCoverVorhanden = New System.Windows.Forms.Label()
        Me.BookIDTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.StandortTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.StandortTableAdapter()
        IDLabel = New System.Windows.Forms.Label()
        SignaturLabel = New System.Windows.Forms.Label()
        UntertitelLabel = New System.Windows.Forms.Label()
        TitelLabel = New System.Windows.Forms.Label()
        LetzteAenderungLabel = New System.Windows.Forms.Label()
        TitelIndexLabel = New System.Windows.Forms.Label()
        StichworteLabel = New System.Windows.Forms.Label()
        Anmerkungen_PlainTextLabel = New System.Windows.Forms.Label()
        Synopsis_PlainTextLabel1 = New System.Windows.Forms.Label()
        AuiflageLabel = New System.Windows.Forms.Label()
        SeitenLabel = New System.Windows.Forms.Label()
        BarCodeLabel = New System.Windows.Forms.Label()
        Dim_HeightLabel = New System.Windows.Forms.Label()
        VerlagsIDLabel = New System.Windows.Forms.Label()
        OriginalTitelLabel = New System.Windows.Forms.Label()
        OriginalUntertitelLabel = New System.Windows.Forms.Label()
        VerkaufspreisLabel = New System.Windows.Forms.Label()
        VeroeffentlichtLabel = New System.Windows.Forms.Label()
        DruckereiIDLabel1 = New System.Windows.Forms.Label()
        BindungIDLabel = New System.Windows.Forms.Label()
        SerienIDLabel = New System.Windows.Forms.Label()
        LandDLabel = New System.Windows.Forms.Label()
        CopyrightDatumLabel = New System.Windows.Forms.Label()
        SprachenIDLabel = New System.Windows.Forms.Label()
        OriginalSpracheIDLabel = New System.Windows.Forms.Label()
        LCCNLabel = New System.Windows.Forms.Label()
        DDCLabel = New System.Windows.Forms.Label()
        AutorSortLabel = New System.Windows.Forms.Label()
        ISBNLabel = New System.Windows.Forms.Label()
        DNBLabel = New System.Windows.Forms.Label()
        BuchTypLabel = New System.Windows.Forms.Label()
        SachgruppeIDLabel = New System.Windows.Forms.Label()
        VerlagsortLabel = New System.Windows.Forms.Label()
        TitleSortLabel = New System.Windows.Forms.Label()
        IdLabel2 = New System.Windows.Forms.Label()
        BookIDLabel1 = New System.Windows.Forms.Label()
        BibliothekLabel = New System.Windows.Forms.Label()
        CType(Me.BuchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerlagsOrtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerlagBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenreLinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorBuchLinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.BibliothekBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.SachgruppeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuchTypBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandortBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorBuchLinkDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorRolleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LanguageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DruckereiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindungBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.GenreLinkDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(590, 60)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 20
        IDLabel.Text = "ID:"
        '
        'SignaturLabel
        '
        SignaturLabel.AutoSize = True
        SignaturLabel.Location = New System.Drawing.Point(561, 8)
        SignaturLabel.Name = "SignaturLabel"
        SignaturLabel.Size = New System.Drawing.Size(49, 13)
        SignaturLabel.TabIndex = 22
        SignaturLabel.Text = "Signatur:"
        '
        'UntertitelLabel
        '
        UntertitelLabel.AutoSize = True
        UntertitelLabel.Location = New System.Drawing.Point(4, 84)
        UntertitelLabel.Name = "UntertitelLabel"
        UntertitelLabel.Size = New System.Drawing.Size(52, 13)
        UntertitelLabel.TabIndex = 23
        UntertitelLabel.Text = "Untertitel:"
        '
        'TitelLabel
        '
        TitelLabel.AutoSize = True
        TitelLabel.Location = New System.Drawing.Point(28, 8)
        TitelLabel.Name = "TitelLabel"
        TitelLabel.Size = New System.Drawing.Size(30, 13)
        TitelLabel.TabIndex = 21
        TitelLabel.Text = "Titel:"
        '
        'LetzteAenderungLabel
        '
        LetzteAenderungLabel.AutoSize = True
        LetzteAenderungLabel.Location = New System.Drawing.Point(553, 130)
        LetzteAenderungLabel.Name = "LetzteAenderungLabel"
        LetzteAenderungLabel.Size = New System.Drawing.Size(94, 13)
        LetzteAenderungLabel.TabIndex = 222
        LetzteAenderungLabel.Text = "Letzte Aenderung:"
        '
        'TitelIndexLabel
        '
        TitelIndexLabel.AutoSize = True
        TitelIndexLabel.Location = New System.Drawing.Point(551, 103)
        TitelIndexLabel.Name = "TitelIndexLabel"
        TitelIndexLabel.Size = New System.Drawing.Size(59, 13)
        TitelIndexLabel.TabIndex = 227
        TitelIndexLabel.Text = "Titel Index:"
        '
        'StichworteLabel
        '
        StichworteLabel.AutoSize = True
        StichworteLabel.Location = New System.Drawing.Point(55, 9)
        StichworteLabel.Name = "StichworteLabel"
        StichworteLabel.Size = New System.Drawing.Size(60, 13)
        StichworteLabel.TabIndex = 122
        StichworteLabel.Text = "Stichworte:"
        '
        'Anmerkungen_PlainTextLabel
        '
        Anmerkungen_PlainTextLabel.AutoSize = True
        Anmerkungen_PlainTextLabel.Location = New System.Drawing.Point(55, 72)
        Anmerkungen_PlainTextLabel.Name = "Anmerkungen_PlainTextLabel"
        Anmerkungen_PlainTextLabel.Size = New System.Drawing.Size(73, 13)
        Anmerkungen_PlainTextLabel.TabIndex = 122
        Anmerkungen_PlainTextLabel.Text = "Anmerkungen"
        '
        'Synopsis_PlainTextLabel1
        '
        Synopsis_PlainTextLabel1.AutoSize = True
        Synopsis_PlainTextLabel1.Location = New System.Drawing.Point(55, 210)
        Synopsis_PlainTextLabel1.Name = "Synopsis_PlainTextLabel1"
        Synopsis_PlainTextLabel1.Size = New System.Drawing.Size(48, 13)
        Synopsis_PlainTextLabel1.TabIndex = 125
        Synopsis_PlainTextLabel1.Text = "Synopse"
        '
        'AuiflageLabel
        '
        AuiflageLabel.AutoSize = True
        AuiflageLabel.Location = New System.Drawing.Point(458, 132)
        AuiflageLabel.Name = "AuiflageLabel"
        AuiflageLabel.Size = New System.Drawing.Size(48, 13)
        AuiflageLabel.TabIndex = 25
        AuiflageLabel.Text = "Auiflage:"
        '
        'SeitenLabel
        '
        SeitenLabel.AutoSize = True
        SeitenLabel.Location = New System.Drawing.Point(465, 181)
        SeitenLabel.Name = "SeitenLabel"
        SeitenLabel.Size = New System.Drawing.Size(40, 13)
        SeitenLabel.TabIndex = 26
        SeitenLabel.Text = "Seiten:"
        '
        'BarCodeLabel
        '
        BarCodeLabel.AutoSize = True
        BarCodeLabel.Location = New System.Drawing.Point(452, 385)
        BarCodeLabel.Name = "BarCodeLabel"
        BarCodeLabel.Size = New System.Drawing.Size(54, 13)
        BarCodeLabel.TabIndex = 27
        BarCodeLabel.Text = "Bar Code:"
        '
        'Dim_HeightLabel
        '
        Dim_HeightLabel.AutoSize = True
        Dim_HeightLabel.Location = New System.Drawing.Point(444, 410)
        Dim_HeightLabel.Name = "Dim_HeightLabel"
        Dim_HeightLabel.Size = New System.Drawing.Size(62, 13)
        Dim_HeightLabel.TabIndex = 28
        Dim_HeightLabel.Text = "Dim Height:"
        '
        'VerlagsIDLabel
        '
        VerlagsIDLabel.AutoSize = True
        VerlagsIDLabel.Location = New System.Drawing.Point(59, 208)
        VerlagsIDLabel.Name = "VerlagsIDLabel"
        VerlagsIDLabel.Size = New System.Drawing.Size(40, 13)
        VerlagsIDLabel.TabIndex = 36
        VerlagsIDLabel.Text = "Verlag:"
        '
        'OriginalTitelLabel
        '
        OriginalTitelLabel.AutoSize = True
        OriginalTitelLabel.Location = New System.Drawing.Point(438, 260)
        OriginalTitelLabel.Name = "OriginalTitelLabel"
        OriginalTitelLabel.Size = New System.Drawing.Size(68, 13)
        OriginalTitelLabel.TabIndex = 40
        OriginalTitelLabel.Text = "Original Titel:"
        '
        'OriginalUntertitelLabel
        '
        OriginalUntertitelLabel.AutoSize = True
        OriginalUntertitelLabel.Location = New System.Drawing.Point(416, 289)
        OriginalUntertitelLabel.Name = "OriginalUntertitelLabel"
        OriginalUntertitelLabel.Size = New System.Drawing.Size(90, 13)
        OriginalUntertitelLabel.TabIndex = 222
        OriginalUntertitelLabel.Text = "Original Untertitel:"
        '
        'VerkaufspreisLabel
        '
        VerkaufspreisLabel.AutoSize = True
        VerkaufspreisLabel.Location = New System.Drawing.Point(432, 359)
        VerkaufspreisLabel.Name = "VerkaufspreisLabel"
        VerkaufspreisLabel.Size = New System.Drawing.Size(74, 13)
        VerkaufspreisLabel.TabIndex = 223
        VerkaufspreisLabel.Text = "Verkaufspreis:"
        '
        'VeroeffentlichtLabel
        '
        VeroeffentlichtLabel.AutoSize = True
        VeroeffentlichtLabel.Location = New System.Drawing.Point(21, 159)
        VeroeffentlichtLabel.Name = "VeroeffentlichtLabel"
        VeroeffentlichtLabel.Size = New System.Drawing.Size(78, 13)
        VeroeffentlichtLabel.TabIndex = 224
        VeroeffentlichtLabel.Text = "Veroeffentlicht:"
        '
        'DruckereiIDLabel1
        '
        DruckereiIDLabel1.AutoSize = True
        DruckereiIDLabel1.Location = New System.Drawing.Point(29, 260)
        DruckereiIDLabel1.Name = "DruckereiIDLabel1"
        DruckereiIDLabel1.Size = New System.Drawing.Size(70, 13)
        DruckereiIDLabel1.TabIndex = 225
        DruckereiIDLabel1.Text = "Druckerei ID:"
        '
        'BindungIDLabel
        '
        BindungIDLabel.AutoSize = True
        BindungIDLabel.Location = New System.Drawing.Point(50, 287)
        BindungIDLabel.Name = "BindungIDLabel"
        BindungIDLabel.Size = New System.Drawing.Size(49, 13)
        BindungIDLabel.TabIndex = 226
        BindungIDLabel.Text = "Bindung:"
        '
        'SerienIDLabel
        '
        SerienIDLabel.AutoSize = True
        SerienIDLabel.Location = New System.Drawing.Point(466, 159)
        SerienIDLabel.Name = "SerienIDLabel"
        SerienIDLabel.Size = New System.Drawing.Size(34, 13)
        SerienIDLabel.TabIndex = 228
        SerienIDLabel.Text = "Serie:"
        '
        'LandDLabel
        '
        LandDLabel.AutoSize = True
        LandDLabel.Location = New System.Drawing.Point(468, 208)
        LandDLabel.Name = "LandDLabel"
        LandDLabel.Size = New System.Drawing.Size(37, 13)
        LandDLabel.TabIndex = 32
        LandDLabel.Text = "Land :"
        '
        'CopyrightDatumLabel
        '
        CopyrightDatumLabel.AutoSize = True
        CopyrightDatumLabel.Location = New System.Drawing.Point(11, 179)
        CopyrightDatumLabel.Name = "CopyrightDatumLabel"
        CopyrightDatumLabel.Size = New System.Drawing.Size(88, 13)
        CopyrightDatumLabel.TabIndex = 230
        CopyrightDatumLabel.Text = "Copyright Datum:"
        '
        'SprachenIDLabel
        '
        SprachenIDLabel.AutoSize = True
        SprachenIDLabel.Location = New System.Drawing.Point(455, 234)
        SprachenIDLabel.Name = "SprachenIDLabel"
        SprachenIDLabel.Size = New System.Drawing.Size(50, 13)
        SprachenIDLabel.TabIndex = 33
        SprachenIDLabel.Text = "Sprache:"
        '
        'OriginalSpracheIDLabel
        '
        OriginalSpracheIDLabel.AutoSize = True
        OriginalSpracheIDLabel.Location = New System.Drawing.Point(416, 334)
        OriginalSpracheIDLabel.Name = "OriginalSpracheIDLabel"
        OriginalSpracheIDLabel.Size = New System.Drawing.Size(91, 13)
        OriginalSpracheIDLabel.TabIndex = 231
        OriginalSpracheIDLabel.Text = "Original Sprache :"
        '
        'LCCNLabel
        '
        LCCNLabel.AutoSize = True
        LCCNLabel.Location = New System.Drawing.Point(61, 385)
        LCCNLabel.Name = "LCCNLabel"
        LCCNLabel.Size = New System.Drawing.Size(38, 13)
        LCCNLabel.TabIndex = 31
        LCCNLabel.Text = "LCCN:"
        '
        'DDCLabel
        '
        DDCLabel.AutoSize = True
        DDCLabel.Location = New System.Drawing.Point(66, 359)
        DDCLabel.Name = "DDCLabel"
        DDCLabel.Size = New System.Drawing.Size(33, 13)
        DDCLabel.TabIndex = 30
        DDCLabel.Text = "DDC:"
        '
        'AutorSortLabel
        '
        AutorSortLabel.AutoSize = True
        AutorSortLabel.Location = New System.Drawing.Point(42, 98)
        AutorSortLabel.Name = "AutorSortLabel"
        AutorSortLabel.Size = New System.Drawing.Size(57, 13)
        AutorSortLabel.TabIndex = 235
        AutorSortLabel.Text = "Autor Sort:"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(64, 333)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(35, 13)
        ISBNLabel.TabIndex = 24
        ISBNLabel.Text = "ISBN:"
        '
        'DNBLabel
        '
        DNBLabel.AutoSize = True
        DNBLabel.Location = New System.Drawing.Point(61, 410)
        DNBLabel.Name = "DNBLabel"
        DNBLabel.Size = New System.Drawing.Size(33, 13)
        DNBLabel.TabIndex = 0
        DNBLabel.Text = "DNB:"
        '
        'BuchTypLabel
        '
        BuchTypLabel.AutoSize = True
        BuchTypLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        BuchTypLabel.Location = New System.Drawing.Point(28, 41)
        BuchTypLabel.Name = "BuchTypLabel"
        BuchTypLabel.Size = New System.Drawing.Size(56, 13)
        BuchTypLabel.TabIndex = 241
        BuchTypLabel.Text = "Buch Typ:"
        '
        'SachgruppeIDLabel
        '
        SachgruppeIDLabel.AutoSize = True
        SachgruppeIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        SachgruppeIDLabel.Location = New System.Drawing.Point(13, 67)
        SachgruppeIDLabel.Name = "SachgruppeIDLabel"
        SachgruppeIDLabel.Size = New System.Drawing.Size(71, 13)
        SachgruppeIDLabel.TabIndex = 243
        SachgruppeIDLabel.Text = "Sachgruppe :"
        '
        'VerlagsortLabel
        '
        VerlagsortLabel.AutoSize = True
        VerlagsortLabel.Location = New System.Drawing.Point(42, 233)
        VerlagsortLabel.Name = "VerlagsortLabel"
        VerlagsortLabel.Size = New System.Drawing.Size(57, 13)
        VerlagsortLabel.TabIndex = 245
        VerlagsortLabel.Text = "Verlagsort:"
        '
        'TitleSortLabel
        '
        TitleSortLabel.AutoSize = True
        TitleSortLabel.Location = New System.Drawing.Point(43, 122)
        TitleSortLabel.Name = "TitleSortLabel"
        TitleSortLabel.Size = New System.Drawing.Size(52, 13)
        TitleSortLabel.TabIndex = 245
        TitleSortLabel.Text = "Title Sort:"
        '
        'IdLabel2
        '
        IdLabel2.AutoSize = True
        IdLabel2.Location = New System.Drawing.Point(37, 255)
        IdLabel2.Name = "IdLabel2"
        IdLabel2.Size = New System.Drawing.Size(18, 13)
        IdLabel2.TabIndex = 60
        IdLabel2.Text = "id:"
        '
        'BookIDLabel1
        '
        BookIDLabel1.AutoSize = True
        BookIDLabel1.Location = New System.Drawing.Point(6, 229)
        BookIDLabel1.Name = "BookIDLabel1"
        BookIDLabel1.Size = New System.Drawing.Size(49, 13)
        BookIDLabel1.TabIndex = 61
        BookIDLabel1.Text = "Book ID:"
        '
        'BibliothekLabel
        '
        BibliothekLabel.AutoSize = True
        BibliothekLabel.Location = New System.Drawing.Point(717, 8)
        BibliothekLabel.Name = "BibliothekLabel"
        BibliothekLabel.Size = New System.Drawing.Size(56, 13)
        BibliothekLabel.TabIndex = 230
        BibliothekLabel.Text = "Bibliothek:"
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
        'VerlagsOrtBindingSource
        '
        Me.VerlagsOrtBindingSource.DataMember = "VerlagsOrt"
        Me.VerlagsOrtBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'VerlagBindingSource
        '
        Me.VerlagBindingSource.DataMember = "Verlag"
        Me.VerlagBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'GenreLinkBindingSource
        '
        Me.GenreLinkBindingSource.DataMember = "GenreLink"
        Me.GenreLinkBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'BuchTableAdapter
        '
        Me.BuchTableAdapter.ClearBeforeFill = True
        '
        'AutorBuchLinkBindingSource
        '
        Me.AutorBuchLinkBindingSource.DataMember = "AutorBuchLink"
        Me.AutorBuchLinkBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'AutorBuchLinkTableAdapter
        '
        Me.AutorBuchLinkTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutorBuchLinkTableAdapter = Me.AutorBuchLinkTableAdapter
        Me.TableAdapterManager.AutorRolleTableAdapter = Me.AutorRolleTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BibliothekTableAdapter = Me.BibliothekTableAdapter
        Me.TableAdapterManager.BindungTableAdapter = Me.BindungTableAdapter
        Me.TableAdapterManager.BuchTableAdapter = Me.BuchTableAdapter
        Me.TableAdapterManager.BuchTypTableAdapter = Me.BuchTypTableAdapter
        Me.TableAdapterManager.DDCTableAdapter = Nothing
        Me.TableAdapterManager.DruckereiTableAdapter = Me.DruckereiTableAdapter
        Me.TableAdapterManager.EditionTableAdapter = Nothing
        Me.TableAdapterManager.GenreLinkTableAdapter = Me.GenreLinkTableAdapter
        Me.TableAdapterManager.LandTableAdapter = Me.LandTableAdapter
        Me.TableAdapterManager.LanguageTableAdapter = Me.LanguageTableAdapter
        Me.TableAdapterManager.PersonTableAdapter = Me.PersonTableAdapter
        Me.TableAdapterManager.SachgruppeTableAdapter = Me.SachgruppeTableAdapter
        Me.TableAdapterManager.SerienTableAdapter = Nothing
        Me.TableAdapterManager.StandortTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VerlagsOrtTableAdapter = Me.VerlagsOrtTableAdapter
        Me.TableAdapterManager.VerlagTableAdapter = Me.VerlagTableAdapter
        '
        'AutorRolleTableAdapter
        '
        Me.AutorRolleTableAdapter.ClearBeforeFill = True
        '
        'BibliothekTableAdapter
        '
        Me.BibliothekTableAdapter.ClearBeforeFill = True
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
        'LandTableAdapter
        '
        Me.LandTableAdapter.ClearBeforeFill = True
        '
        'LanguageTableAdapter
        '
        Me.LanguageTableAdapter.ClearBeforeFill = True
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'SachgruppeTableAdapter
        '
        Me.SachgruppeTableAdapter.ClearBeforeFill = True
        '
        'VerlagsOrtTableAdapter
        '
        Me.VerlagsOrtTableAdapter.ClearBeforeFill = True
        '
        'VerlagTableAdapter
        '
        Me.VerlagTableAdapter.ClearBeforeFill = True
        '
        'NewDataSet
        '
        Me.NewDataSet.DataSetName = "NewDataSet"
        Me.NewDataSet.Locale = New System.Globalization.CultureInfo("")
        Me.NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.Controls.Add(Me.ListBoxTitel)
        Me.Panel6.Controls.Add(Me.lblBestand)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(361, 153)
        Me.Panel6.TabIndex = 3
        '
        'ListBoxTitel
        '
        Me.ListBoxTitel.BackColor = System.Drawing.SystemColors.Control
        Me.ListBoxTitel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxTitel.ForeColor = System.Drawing.Color.DarkRed
        Me.ListBoxTitel.FormattingEnabled = True
        Me.ListBoxTitel.Location = New System.Drawing.Point(15, 31)
        Me.ListBoxTitel.Name = "ListBoxTitel"
        Me.ListBoxTitel.Size = New System.Drawing.Size(320, 52)
        Me.ListBoxTitel.TabIndex = 65
        '
        'lblBestand
        '
        Me.lblBestand.AutoSize = True
        Me.lblBestand.Location = New System.Drawing.Point(12, 8)
        Me.lblBestand.Name = "lblBestand"
        Me.lblBestand.Size = New System.Drawing.Size(117, 13)
        Me.lblBestand.TabIndex = 1
        Me.lblBestand.Text = "Im Bestand vorhanden:"
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.Controls.Add(Me.ComboBox12)
        Me.Panel5.Controls.Add(BibliothekLabel)
        Me.Panel5.Controls.Add(Me.BibliothekTextBox)
        Me.Panel5.Controls.Add(Me.DateTimePicker1)
        Me.Panel5.Controls.Add(Me.LetzteAenderungTextBox)
        Me.Panel5.Controls.Add(Me.TitelIndexTextBox)
        Me.Panel5.Controls.Add(TitelIndexLabel)
        Me.Panel5.Controls.Add(Me.CheckBox2)
        Me.Panel5.Controls.Add(Me.CheckBox1)
        Me.Panel5.Controls.Add(Me.txtSignatur)
        Me.Panel5.Controls.Add(Me.SignaturTextBox)
        Me.Panel5.Controls.Add(LetzteAenderungLabel)
        Me.Panel5.Controls.Add(Me.TxtUTitel)
        Me.Panel5.Controls.Add(Me.TxtTitel)
        Me.Panel5.Controls.Add(Me.TitelTextBox)
        Me.Panel5.Controls.Add(TitelLabel)
        Me.Panel5.Controls.Add(Me.UntertitelTextBox)
        Me.Panel5.Controls.Add(UntertitelLabel)
        Me.Panel5.Controls.Add(SignaturLabel)
        Me.Panel5.Controls.Add(Me.IDTextBox)
        Me.Panel5.Controls.Add(IDLabel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(370, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(940, 153)
        Me.Panel5.TabIndex = 2
        '
        'ComboBox12
        '
        Me.ComboBox12.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "Bibliothek", True))
        Me.ComboBox12.DataSource = Me.BibliothekBindingSource
        Me.ComboBox12.DisplayMember = "Bibliothek"
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Location = New System.Drawing.Point(809, 5)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(96, 21)
        Me.ComboBox12.TabIndex = 232
        Me.ComboBox12.ValueMember = "id"
        '
        'BibliothekBindingSource
        '
        Me.BibliothekBindingSource.DataMember = "Bibliothek"
        Me.BibliothekBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'BibliothekTextBox
        '
        Me.BibliothekTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Bibliothek", True))
        Me.BibliothekTextBox.Location = New System.Drawing.Point(779, 5)
        Me.BibliothekTextBox.Name = "BibliothekTextBox"
        Me.BibliothekTextBox.Size = New System.Drawing.Size(24, 20)
        Me.BibliothekTextBox.TabIndex = 231
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(779, 129)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(126, 20)
        Me.DateTimePicker1.TabIndex = 230
        '
        'LetzteAenderungTextBox
        '
        Me.LetzteAenderungTextBox.Location = New System.Drawing.Point(656, 129)
        Me.LetzteAenderungTextBox.Name = "LetzteAenderungTextBox"
        Me.LetzteAenderungTextBox.Size = New System.Drawing.Size(117, 20)
        Me.LetzteAenderungTextBox.TabIndex = 229
        '
        'TitelIndexTextBox
        '
        Me.TitelIndexTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.TitelIndexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "TitelIndex", True))
        Me.TitelIndexTextBox.Location = New System.Drawing.Point(616, 100)
        Me.TitelIndexTextBox.Name = "TitelIndexTextBox"
        Me.TitelIndexTextBox.ReadOnly = True
        Me.TitelIndexTextBox.Size = New System.Drawing.Size(289, 20)
        Me.TitelIndexTextBox.TabIndex = 228
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(535, 83)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 226
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(535, 7)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 226
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtSignatur
        '
        Me.txtSignatur.Location = New System.Drawing.Point(616, 5)
        Me.txtSignatur.Name = "txtSignatur"
        Me.txtSignatur.Size = New System.Drawing.Size(100, 20)
        Me.txtSignatur.TabIndex = 225
        '
        'SignaturTextBox
        '
        Me.SignaturTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.SignaturTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Signatur", True))
        Me.SignaturTextBox.Location = New System.Drawing.Point(617, 31)
        Me.SignaturTextBox.Name = "SignaturTextBox"
        Me.SignaturTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SignaturTextBox.TabIndex = 224
        '
        'TxtUTitel
        '
        Me.TxtUTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUTitel.Location = New System.Drawing.Point(62, 79)
        Me.TxtUTitel.Multiline = True
        Me.TxtUTitel.Name = "TxtUTitel"
        Me.TxtUTitel.Size = New System.Drawing.Size(467, 44)
        Me.TxtUTitel.TabIndex = 222
        '
        'TxtTitel
        '
        Me.TxtTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitel.Location = New System.Drawing.Point(62, 3)
        Me.TxtTitel.Multiline = True
        Me.TxtTitel.Name = "TxtTitel"
        Me.TxtTitel.Size = New System.Drawing.Size(467, 44)
        Me.TxtTitel.TabIndex = 221
        '
        'TitelTextBox
        '
        Me.TitelTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.TitelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Titel", True))
        Me.TitelTextBox.Location = New System.Drawing.Point(62, 53)
        Me.TitelTextBox.Name = "TitelTextBox"
        Me.TitelTextBox.Size = New System.Drawing.Size(467, 20)
        Me.TitelTextBox.TabIndex = 22
        '
        'UntertitelTextBox
        '
        Me.UntertitelTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.UntertitelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Untertitel", True))
        Me.UntertitelTextBox.Location = New System.Drawing.Point(62, 129)
        Me.UntertitelTextBox.Name = "UntertitelTextBox"
        Me.UntertitelTextBox.Size = New System.Drawing.Size(467, 20)
        Me.UntertitelTextBox.TabIndex = 24
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(617, 57)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 21
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(370, 162)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(940, 472)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(932, 446)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Übersicht"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(TitleSortLabel)
        Me.Panel2.Controls.Add(Me.TitleSortTextBox)
        Me.Panel2.Controls.Add(Me.OrtIDTextBox1)
        Me.Panel2.Controls.Add(VerlagsortLabel)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.AutorBuchLinkDataGridView)
        Me.Panel2.Controls.Add(DNBLabel)
        Me.Panel2.Controls.Add(Me.DNBTextBox)
        Me.Panel2.Controls.Add(Me.txtDDC)
        Me.Panel2.Controls.Add(Me.ISBNTextBox)
        Me.Panel2.Controls.Add(ISBNLabel)
        Me.Panel2.Controls.Add(Me.txtISBN)
        Me.Panel2.Controls.Add(AutorSortLabel)
        Me.Panel2.Controls.Add(Me.txtDNB)
        Me.Panel2.Controls.Add(Me.txtLCCN)
        Me.Panel2.Controls.Add(Me.AutorSortTextBox)
        Me.Panel2.Controls.Add(DDCLabel)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.DDCTextBox)
        Me.Panel2.Controls.Add(Me.SprachenIDTextBox)
        Me.Panel2.Controls.Add(Me.LCCNTextBox)
        Me.Panel2.Controls.Add(Me.CheckBox7)
        Me.Panel2.Controls.Add(LCCNLabel)
        Me.Panel2.Controls.Add(Me.CheckBox23)
        Me.Panel2.Controls.Add(Me.CheckBox9)
        Me.Panel2.Controls.Add(Me.CheckBox22)
        Me.Panel2.Controls.Add(Me.CheckBox10)
        Me.Panel2.Controls.Add(Me.CheckBox27)
        Me.Panel2.Controls.Add(Me.CheckBox21)
        Me.Panel2.Controls.Add(Me.CheckBox11)
        Me.Panel2.Controls.Add(Me.CheckBox20)
        Me.Panel2.Controls.Add(Me.CheckBox19)
        Me.Panel2.Controls.Add(Me.CheckBox18)
        Me.Panel2.Controls.Add(Me.CheckBox17)
        Me.Panel2.Controls.Add(Me.CheckBox16)
        Me.Panel2.Controls.Add(Me.CheckBox15)
        Me.Panel2.Controls.Add(Me.CheckBox14)
        Me.Panel2.Controls.Add(Me.CheckBox13)
        Me.Panel2.Controls.Add(Me.CheckBox12)
        Me.Panel2.Controls.Add(Me.CheckBox8)
        Me.Panel2.Controls.Add(Me.CheckBox6)
        Me.Panel2.Controls.Add(Me.CheckBox4)
        Me.Panel2.Controls.Add(Me.CheckBox3)
        Me.Panel2.Controls.Add(Me.ComboBox7)
        Me.Panel2.Controls.Add(Me.ComboBox6)
        Me.Panel2.Controls.Add(OriginalSpracheIDLabel)
        Me.Panel2.Controls.Add(Me.OriginalSpracheIDTextBox)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(SprachenIDLabel)
        Me.Panel2.Controls.Add(CopyrightDatumLabel)
        Me.Panel2.Controls.Add(LandDLabel)
        Me.Panel2.Controls.Add(Me.CopyrightDatumTextBox)
        Me.Panel2.Controls.Add(Me.LandDTextBox)
        Me.Panel2.Controls.Add(Me.ComboBox5)
        Me.Panel2.Controls.Add(SerienIDLabel)
        Me.Panel2.Controls.Add(Me.SerienIDTextBox)
        Me.Panel2.Controls.Add(Me.ComboBox4)
        Me.Panel2.Controls.Add(BindungIDLabel)
        Me.Panel2.Controls.Add(Me.BindungIDTextBox)
        Me.Panel2.Controls.Add(DruckereiIDLabel1)
        Me.Panel2.Controls.Add(Me.DruckereiIDTextBox)
        Me.Panel2.Controls.Add(VeroeffentlichtLabel)
        Me.Panel2.Controls.Add(Me.VeroeffentlichtTextBox)
        Me.Panel2.Controls.Add(VerkaufspreisLabel)
        Me.Panel2.Controls.Add(Me.VerkaufspreisTextBox)
        Me.Panel2.Controls.Add(OriginalUntertitelLabel)
        Me.Panel2.Controls.Add(Me.OriginalUntertitelTextBox)
        Me.Panel2.Controls.Add(OriginalTitelLabel)
        Me.Panel2.Controls.Add(Me.ComboBox8)
        Me.Panel2.Controls.Add(Me.ComboBox3)
        Me.Panel2.Controls.Add(Me.OriginalTitelTextBox)
        Me.Panel2.Controls.Add(Me.txtGroesse)
        Me.Panel2.Controls.Add(VerlagsIDLabel)
        Me.Panel2.Controls.Add(Me.txtBarCode)
        Me.Panel2.Controls.Add(Me.VerlagsIDTextBox)
        Me.Panel2.Controls.Add(Me.txtPreis)
        Me.Panel2.Controls.Add(Me.txtOrgLang)
        Me.Panel2.Controls.Add(Me.txtOrgUT)
        Me.Panel2.Controls.Add(Me.txtOrgTitel)
        Me.Panel2.Controls.Add(Me.txtSeiten)
        Me.Panel2.Controls.Add(Dim_HeightLabel)
        Me.Panel2.Controls.Add(Me.Dim_HeightTextBox)
        Me.Panel2.Controls.Add(Me.txtSerie)
        Me.Panel2.Controls.Add(BarCodeLabel)
        Me.Panel2.Controls.Add(Me.BarCodeTextBox)
        Me.Panel2.Controls.Add(Me.txtAuflage)
        Me.Panel2.Controls.Add(Me.txtAutorArt)
        Me.Panel2.Controls.Add(Me.txtPersonArt)
        Me.Panel2.Controls.Add(Me.txtPerson)
        Me.Panel2.Controls.Add(Me.txtBindung)
        Me.Panel2.Controls.Add(SeitenLabel)
        Me.Panel2.Controls.Add(Me.txtDruckerei)
        Me.Panel2.Controls.Add(Me.SeitenTextBox)
        Me.Panel2.Controls.Add(Me.txtSprache)
        Me.Panel2.Controls.Add(AuiflageLabel)
        Me.Panel2.Controls.Add(Me.txtLand)
        Me.Panel2.Controls.Add(Me.AuiflageTextBox)
        Me.Panel2.Controls.Add(Me.txtVerlagOrt)
        Me.Panel2.Controls.Add(Me.txtVerlag)
        Me.Panel2.Controls.Add(Me.txtCopyrDat)
        Me.Panel2.Controls.Add(Me.txtVeroeff)
        Me.Panel2.Controls.Add(Me.txtAutorSort)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(926, 440)
        Me.Panel2.TabIndex = 0
        '
        'TitleSortTextBox
        '
        Me.TitleSortTextBox.BackColor = System.Drawing.Color.LightGreen
        Me.TitleSortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "TitelIndex", True))
        Me.TitleSortTextBox.Location = New System.Drawing.Point(105, 122)
        Me.TitleSortTextBox.Name = "TitleSortTextBox"
        Me.TitleSortTextBox.Size = New System.Drawing.Size(259, 20)
        Me.TitleSortTextBox.TabIndex = 246
        '
        'OrtIDTextBox1
        '
        Me.OrtIDTextBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.OrtIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "VerlagsOrtID", True))
        Me.OrtIDTextBox1.Location = New System.Drawing.Point(211, 229)
        Me.OrtIDTextBox1.Name = "OrtIDTextBox1"
        Me.OrtIDTextBox1.Size = New System.Drawing.Size(20, 20)
        Me.OrtIDTextBox1.TabIndex = 66
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.StandortIDTextBox)
        Me.Panel7.Controls.Add(Me.SachgruppeIDTextBox)
        Me.Panel7.Controls.Add(Me.TypIDTextBox)
        Me.Panel7.Controls.Add(Me.ComboBox10)
        Me.Panel7.Controls.Add(Me.ComboBox11)
        Me.Panel7.Controls.Add(SachgruppeIDLabel)
        Me.Panel7.Controls.Add(Me.ComboBox9)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(BuchTypLabel)
        Me.Panel7.Location = New System.Drawing.Point(511, 21)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(285, 93)
        Me.Panel7.TabIndex = 245
        '
        'StandortIDTextBox
        '
        Me.StandortIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.StandortIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "StandortID", True))
        Me.StandortIDTextBox.Location = New System.Drawing.Point(102, 10)
        Me.StandortIDTextBox.Name = "StandortIDTextBox"
        Me.StandortIDTextBox.ReadOnly = True
        Me.StandortIDTextBox.Size = New System.Drawing.Size(22, 20)
        Me.StandortIDTextBox.TabIndex = 246
        '
        'SachgruppeIDTextBox
        '
        Me.SachgruppeIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SachgruppeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "SachgruppeID", True))
        Me.SachgruppeIDTextBox.Location = New System.Drawing.Point(102, 64)
        Me.SachgruppeIDTextBox.Name = "SachgruppeIDTextBox"
        Me.SachgruppeIDTextBox.ReadOnly = True
        Me.SachgruppeIDTextBox.Size = New System.Drawing.Size(22, 20)
        Me.SachgruppeIDTextBox.TabIndex = 246
        '
        'TypIDTextBox
        '
        Me.TypIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TypIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "TypID", True))
        Me.TypIDTextBox.Location = New System.Drawing.Point(102, 36)
        Me.TypIDTextBox.Name = "TypIDTextBox"
        Me.TypIDTextBox.ReadOnly = True
        Me.TypIDTextBox.Size = New System.Drawing.Size(22, 20)
        Me.TypIDTextBox.TabIndex = 246
        '
        'ComboBox10
        '
        Me.ComboBox10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ComboBox10.DataSource = Me.SachgruppeBindingSource
        Me.ComboBox10.DisplayMember = "Sachgruppe"
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Location = New System.Drawing.Point(134, 63)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(124, 21)
        Me.ComboBox10.TabIndex = 244
        Me.ComboBox10.ValueMember = "GenreID"
        '
        'SachgruppeBindingSource
        '
        Me.SachgruppeBindingSource.DataMember = "Sachgruppe"
        Me.SachgruppeBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'ComboBox11
        '
        Me.ComboBox11.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox11.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox11.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ComboBox11.DataSource = Me.BuchTypBindingSource
        Me.ComboBox11.DisplayMember = "BuchTyp"
        Me.ComboBox11.FormattingEnabled = True
        Me.ComboBox11.Location = New System.Drawing.Point(134, 36)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(124, 21)
        Me.ComboBox11.TabIndex = 242
        Me.ComboBox11.ValueMember = "ID"
        '
        'BuchTypBindingSource
        '
        Me.BuchTypBindingSource.DataMember = "BuchTyp"
        Me.BuchTypBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'ComboBox9
        '
        Me.ComboBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox9.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ComboBox9.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "StandortID", True))
        Me.ComboBox9.DataSource = Me.StandortBindingSource
        Me.ComboBox9.DisplayMember = "Standort"
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Location = New System.Drawing.Point(134, 9)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(124, 21)
        Me.ComboBox9.TabIndex = 239
        Me.ComboBox9.ValueMember = "ID"
        '
        'StandortBindingSource
        '
        Me.StandortBindingSource.DataMember = "Standort"
        Me.StandortBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(33, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 240
        Me.Label4.Text = "Standort:"
        '
        'AutorBuchLinkDataGridView
        '
        Me.AutorBuchLinkDataGridView.AutoGenerateColumns = False
        Me.AutorBuchLinkDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.AutorBuchLinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AutorBuchLinkDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.BuchIDDataGridViewTextBoxColumn1, Me.PersonIDDataGridViewTextBoxColumn, Me.RolleIDDataGridViewTextBoxColumn})
        Me.AutorBuchLinkDataGridView.DataSource = Me.AutorBuchLinkBindingSource
        Me.AutorBuchLinkDataGridView.Location = New System.Drawing.Point(24, 6)
        Me.AutorBuchLinkDataGridView.Name = "AutorBuchLinkDataGridView"
        Me.AutorBuchLinkDataGridView.RowHeadersVisible = False
        Me.AutorBuchLinkDataGridView.Size = New System.Drawing.Size(181, 83)
        Me.AutorBuchLinkDataGridView.TabIndex = 240
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.Visible = False
        '
        'BuchIDDataGridViewTextBoxColumn1
        '
        Me.BuchIDDataGridViewTextBoxColumn1.DataPropertyName = "BuchID"
        Me.BuchIDDataGridViewTextBoxColumn1.HeaderText = "BuchID"
        Me.BuchIDDataGridViewTextBoxColumn1.Name = "BuchIDDataGridViewTextBoxColumn1"
        Me.BuchIDDataGridViewTextBoxColumn1.Visible = False
        '
        'PersonIDDataGridViewTextBoxColumn
        '
        Me.PersonIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID"
        Me.PersonIDDataGridViewTextBoxColumn.DataSource = Me.PersonBindingSource
        Me.PersonIDDataGridViewTextBoxColumn.DisplayMember = "SortBy"
        Me.PersonIDDataGridViewTextBoxColumn.HeaderText = "PersonID"
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
        'DNBTextBox
        '
        Me.DNBTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DNBTextBox.Location = New System.Drawing.Point(105, 407)
        Me.DNBTextBox.Name = "DNBTextBox"
        Me.DNBTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DNBTextBox.TabIndex = 1
        '
        'txtDDC
        '
        Me.txtDDC.BackColor = System.Drawing.Color.LightGreen
        Me.txtDDC.Location = New System.Drawing.Point(240, 356)
        Me.txtDDC.Name = "txtDDC"
        Me.txtDDC.Size = New System.Drawing.Size(124, 20)
        Me.txtDDC.TabIndex = 201
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(105, 330)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ISBNTextBox.TabIndex = 25
        '
        'txtISBN
        '
        Me.txtISBN.BackColor = System.Drawing.Color.LightGreen
        Me.txtISBN.Location = New System.Drawing.Point(240, 330)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(124, 20)
        Me.txtISBN.TabIndex = 200
        '
        'txtDNB
        '
        Me.txtDNB.BackColor = System.Drawing.Color.LightGreen
        Me.txtDNB.Location = New System.Drawing.Point(240, 407)
        Me.txtDNB.Name = "txtDNB"
        Me.txtDNB.Size = New System.Drawing.Size(124, 20)
        Me.txtDNB.TabIndex = 202
        '
        'txtLCCN
        '
        Me.txtLCCN.BackColor = System.Drawing.Color.LightGreen
        Me.txtLCCN.Location = New System.Drawing.Point(240, 382)
        Me.txtLCCN.Name = "txtLCCN"
        Me.txtLCCN.Size = New System.Drawing.Size(124, 20)
        Me.txtLCCN.TabIndex = 202
        '
        'AutorSortTextBox
        '
        Me.AutorSortTextBox.BackColor = System.Drawing.Color.LightGreen
        Me.AutorSortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "AutorSort", True))
        Me.AutorSortTextBox.Location = New System.Drawing.Point(105, 95)
        Me.AutorSortTextBox.Name = "AutorSortTextBox"
        Me.AutorSortTextBox.Size = New System.Drawing.Size(259, 20)
        Me.AutorSortTextBox.TabIndex = 236
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "SprachenID", True))
        Me.ComboBox1.DataSource = Me.LanguageBindingSource
        Me.ComboBox1.DisplayMember = "Language"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(511, 230)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 234
        Me.ComboBox1.ValueMember = "LanguageID"
        '
        'LanguageBindingSource
        '
        Me.LanguageBindingSource.DataMember = "Language"
        Me.LanguageBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'DDCTextBox
        '
        Me.DDCTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DDCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "DDC", True))
        Me.DDCTextBox.Location = New System.Drawing.Point(105, 356)
        Me.DDCTextBox.Name = "DDCTextBox"
        Me.DDCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DDCTextBox.TabIndex = 31
        '
        'SprachenIDTextBox
        '
        Me.SprachenIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SprachenIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "SprachenID", True))
        Me.SprachenIDTextBox.Location = New System.Drawing.Point(618, 231)
        Me.SprachenIDTextBox.Name = "SprachenIDTextBox"
        Me.SprachenIDTextBox.Size = New System.Drawing.Size(19, 20)
        Me.SprachenIDTextBox.TabIndex = 34
        '
        'LCCNTextBox
        '
        Me.LCCNTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LCCNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "LCCN", True))
        Me.LCCNTextBox.Location = New System.Drawing.Point(105, 382)
        Me.LCCNTextBox.Name = "LCCNTextBox"
        Me.LCCNTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LCCNTextBox.TabIndex = 32
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(370, 234)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox7.TabIndex = 226
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox23
        '
        Me.CheckBox23.AutoSize = True
        Me.CheckBox23.Location = New System.Drawing.Point(781, 410)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox23.TabIndex = 226
        Me.CheckBox23.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(370, 336)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox9.TabIndex = 226
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox22
        '
        Me.CheckBox22.AutoSize = True
        Me.CheckBox22.Location = New System.Drawing.Point(781, 384)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox22.TabIndex = 226
        Me.CheckBox22.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(370, 362)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox10.TabIndex = 226
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox27
        '
        Me.CheckBox27.AutoSize = True
        Me.CheckBox27.Location = New System.Drawing.Point(370, 409)
        Me.CheckBox27.Name = "CheckBox27"
        Me.CheckBox27.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox27.TabIndex = 226
        Me.CheckBox27.UseVisualStyleBackColor = True
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Location = New System.Drawing.Point(781, 358)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox21.TabIndex = 226
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(370, 388)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox11.TabIndex = 226
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.Location = New System.Drawing.Point(781, 332)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox20.TabIndex = 226
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.Location = New System.Drawing.Point(781, 287)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox19.TabIndex = 226
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.Location = New System.Drawing.Point(781, 260)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox18.TabIndex = 226
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Location = New System.Drawing.Point(781, 181)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox17.TabIndex = 226
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Location = New System.Drawing.Point(781, 156)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox16.TabIndex = 226
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Location = New System.Drawing.Point(781, 135)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox15.TabIndex = 226
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(370, 286)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox14.TabIndex = 226
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(781, 234)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox13.TabIndex = 226
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(781, 208)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox12.TabIndex = 226
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(370, 264)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox8.TabIndex = 226
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(370, 208)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox6.TabIndex = 226
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(370, 176)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox4.TabIndex = 226
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(370, 155)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 226
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'ComboBox7
        '
        Me.ComboBox7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ComboBox7.DataSource = Me.LanguageBindingSource
        Me.ComboBox7.DisplayMember = "Language"
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(512, 330)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox7.TabIndex = 233
        Me.ComboBox7.ValueMember = "LanguageID"
        '
        'ComboBox6
        '
        Me.ComboBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "LandD", True))
        Me.ComboBox6.DataSource = Me.LandBindingSource
        Me.ComboBox6.DisplayMember = "Print_Name"
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(511, 203)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox6.TabIndex = 125
        Me.ComboBox6.ValueMember = "id"
        '
        'LandBindingSource
        '
        Me.LandBindingSource.DataMember = "Land"
        Me.LandBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'OriginalSpracheIDTextBox
        '
        Me.OriginalSpracheIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.OriginalSpracheIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "OriginalSpracheID", True))
        Me.OriginalSpracheIDTextBox.Location = New System.Drawing.Point(617, 330)
        Me.OriginalSpracheIDTextBox.Name = "OriginalSpracheIDTextBox"
        Me.OriginalSpracheIDTextBox.Size = New System.Drawing.Size(20, 20)
        Me.OriginalSpracheIDTextBox.TabIndex = 232
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "DruckereiID", True))
        Me.ComboBox2.DataSource = Me.DruckereiBindingSource
        Me.ComboBox2.DisplayMember = "Druckerei"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(105, 257)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.TabIndex = 39
        Me.ComboBox2.ValueMember = "PrintedByID"
        '
        'DruckereiBindingSource
        '
        Me.DruckereiBindingSource.DataMember = "Druckerei"
        Me.DruckereiBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'CopyrightDatumTextBox
        '
        Me.CopyrightDatumTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CopyrightDatumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "CopyrightDatum", True))
        Me.CopyrightDatumTextBox.Location = New System.Drawing.Point(105, 176)
        Me.CopyrightDatumTextBox.Name = "CopyrightDatumTextBox"
        Me.CopyrightDatumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CopyrightDatumTextBox.TabIndex = 231
        '
        'LandDTextBox
        '
        Me.LandDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LandDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "LandD", True))
        Me.LandDTextBox.Location = New System.Drawing.Point(617, 205)
        Me.LandDTextBox.Name = "LandDTextBox"
        Me.LandDTextBox.Size = New System.Drawing.Size(20, 20)
        Me.LandDTextBox.TabIndex = 33
        '
        'ComboBox5
        '
        Me.ComboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ComboBox5.DisplayMember = "Serie"
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(512, 153)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox5.TabIndex = 230
        Me.ComboBox5.ValueMember = "ID"
        '
        'SerienIDTextBox
        '
        Me.SerienIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SerienIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "SerienID", True))
        Me.SerienIDTextBox.Location = New System.Drawing.Point(617, 152)
        Me.SerienIDTextBox.Name = "SerienIDTextBox"
        Me.SerienIDTextBox.Size = New System.Drawing.Size(23, 20)
        Me.SerienIDTextBox.TabIndex = 229
        '
        'ComboBox4
        '
        Me.ComboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "BindungID", True))
        Me.ComboBox4.DataSource = Me.BindungBindingSource
        Me.ComboBox4.DisplayMember = "Bindung"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(105, 283)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox4.TabIndex = 228
        Me.ComboBox4.ValueMember = "BindingID"
        '
        'BindungBindingSource
        '
        Me.BindungBindingSource.DataMember = "Bindung"
        Me.BindungBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'BindungIDTextBox
        '
        Me.BindungIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BindungIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "BindungID", True))
        Me.BindungIDTextBox.Location = New System.Drawing.Point(211, 284)
        Me.BindungIDTextBox.Name = "BindungIDTextBox"
        Me.BindungIDTextBox.Size = New System.Drawing.Size(20, 20)
        Me.BindungIDTextBox.TabIndex = 227
        '
        'DruckereiIDTextBox
        '
        Me.DruckereiIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DruckereiIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "DruckereiID", True))
        Me.DruckereiIDTextBox.Location = New System.Drawing.Point(211, 257)
        Me.DruckereiIDTextBox.Name = "DruckereiIDTextBox"
        Me.DruckereiIDTextBox.Size = New System.Drawing.Size(20, 20)
        Me.DruckereiIDTextBox.TabIndex = 226
        '
        'VeroeffentlichtTextBox
        '
        Me.VeroeffentlichtTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.VeroeffentlichtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Veroeffentlicht", True))
        Me.VeroeffentlichtTextBox.Location = New System.Drawing.Point(105, 152)
        Me.VeroeffentlichtTextBox.MaxLength = 50
        Me.VeroeffentlichtTextBox.Name = "VeroeffentlichtTextBox"
        Me.VeroeffentlichtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VeroeffentlichtTextBox.TabIndex = 225
        '
        'VerkaufspreisTextBox
        '
        Me.VerkaufspreisTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.VerkaufspreisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Verkaufspreis", True))
        Me.VerkaufspreisTextBox.Location = New System.Drawing.Point(512, 356)
        Me.VerkaufspreisTextBox.Name = "VerkaufspreisTextBox"
        Me.VerkaufspreisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VerkaufspreisTextBox.TabIndex = 224
        '
        'OriginalUntertitelTextBox
        '
        Me.OriginalUntertitelTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.OriginalUntertitelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "OriginalUntertitel", True))
        Me.OriginalUntertitelTextBox.Location = New System.Drawing.Point(512, 286)
        Me.OriginalUntertitelTextBox.Name = "OriginalUntertitelTextBox"
        Me.OriginalUntertitelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OriginalUntertitelTextBox.TabIndex = 223
        '
        'ComboBox8
        '
        Me.ComboBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ComboBox8.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "VerlagsOrtID", True))
        Me.ComboBox8.DataSource = Me.VerlagsOrtBindingSource
        Me.ComboBox8.DisplayMember = "Verlagsort"
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(105, 230)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox8.TabIndex = 40
        Me.ComboBox8.ValueMember = "ID"
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuchBindingSource, "VerlagsID", True))
        Me.ComboBox3.DataSource = Me.VerlagBindingSource
        Me.ComboBox3.DisplayMember = "Verlag"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(105, 203)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox3.TabIndex = 40
        Me.ComboBox3.ValueMember = "PublisherID"
        '
        'OriginalTitelTextBox
        '
        Me.OriginalTitelTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.OriginalTitelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "OriginalTitel", True))
        Me.OriginalTitelTextBox.Location = New System.Drawing.Point(512, 257)
        Me.OriginalTitelTextBox.Name = "OriginalTitelTextBox"
        Me.OriginalTitelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OriginalTitelTextBox.TabIndex = 41
        '
        'txtGroesse
        '
        Me.txtGroesse.BackColor = System.Drawing.Color.LightGreen
        Me.txtGroesse.Location = New System.Drawing.Point(646, 407)
        Me.txtGroesse.Name = "txtGroesse"
        Me.txtGroesse.Size = New System.Drawing.Size(124, 20)
        Me.txtGroesse.TabIndex = 220
        '
        'txtBarCode
        '
        Me.txtBarCode.BackColor = System.Drawing.Color.LightGreen
        Me.txtBarCode.Location = New System.Drawing.Point(646, 382)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(124, 20)
        Me.txtBarCode.TabIndex = 210
        '
        'VerlagsIDTextBox
        '
        Me.VerlagsIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.VerlagsIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "VerlagsID", True))
        Me.VerlagsIDTextBox.Location = New System.Drawing.Point(211, 203)
        Me.VerlagsIDTextBox.Name = "VerlagsIDTextBox"
        Me.VerlagsIDTextBox.Size = New System.Drawing.Size(20, 20)
        Me.VerlagsIDTextBox.TabIndex = 37
        '
        'txtPreis
        '
        Me.txtPreis.BackColor = System.Drawing.Color.LightGreen
        Me.txtPreis.Location = New System.Drawing.Point(646, 356)
        Me.txtPreis.Name = "txtPreis"
        Me.txtPreis.Size = New System.Drawing.Size(124, 20)
        Me.txtPreis.TabIndex = 212
        '
        'txtOrgLang
        '
        Me.txtOrgLang.BackColor = System.Drawing.Color.LightGreen
        Me.txtOrgLang.Location = New System.Drawing.Point(646, 330)
        Me.txtOrgLang.Name = "txtOrgLang"
        Me.txtOrgLang.Size = New System.Drawing.Size(124, 20)
        Me.txtOrgLang.TabIndex = 213
        '
        'txtOrgUT
        '
        Me.txtOrgUT.BackColor = System.Drawing.Color.LightGreen
        Me.txtOrgUT.Location = New System.Drawing.Point(646, 284)
        Me.txtOrgUT.Name = "txtOrgUT"
        Me.txtOrgUT.Size = New System.Drawing.Size(124, 20)
        Me.txtOrgUT.TabIndex = 219
        '
        'txtOrgTitel
        '
        Me.txtOrgTitel.BackColor = System.Drawing.Color.LightGreen
        Me.txtOrgTitel.Location = New System.Drawing.Point(646, 257)
        Me.txtOrgTitel.Name = "txtOrgTitel"
        Me.txtOrgTitel.Size = New System.Drawing.Size(124, 20)
        Me.txtOrgTitel.TabIndex = 215
        '
        'txtSeiten
        '
        Me.txtSeiten.BackColor = System.Drawing.Color.LightGreen
        Me.txtSeiten.Location = New System.Drawing.Point(646, 177)
        Me.txtSeiten.Name = "txtSeiten"
        Me.txtSeiten.Size = New System.Drawing.Size(124, 20)
        Me.txtSeiten.TabIndex = 216
        '
        'Dim_HeightTextBox
        '
        Me.Dim_HeightTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Dim_HeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Dim_Height", True))
        Me.Dim_HeightTextBox.Location = New System.Drawing.Point(512, 407)
        Me.Dim_HeightTextBox.Name = "Dim_HeightTextBox"
        Me.Dim_HeightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dim_HeightTextBox.TabIndex = 29
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.Color.LightGreen
        Me.txtSerie.Location = New System.Drawing.Point(646, 153)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(124, 20)
        Me.txtSerie.TabIndex = 217
        '
        'BarCodeTextBox
        '
        Me.BarCodeTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BarCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "BarCode", True))
        Me.BarCodeTextBox.Location = New System.Drawing.Point(512, 382)
        Me.BarCodeTextBox.Name = "BarCodeTextBox"
        Me.BarCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BarCodeTextBox.TabIndex = 28
        '
        'txtAuflage
        '
        Me.txtAuflage.BackColor = System.Drawing.Color.LightGreen
        Me.txtAuflage.Location = New System.Drawing.Point(646, 129)
        Me.txtAuflage.Name = "txtAuflage"
        Me.txtAuflage.Size = New System.Drawing.Size(124, 20)
        Me.txtAuflage.TabIndex = 218
        '
        'txtAutorArt
        '
        Me.txtAutorArt.BackColor = System.Drawing.Color.LightGreen
        Me.txtAutorArt.Location = New System.Drawing.Point(327, 43)
        Me.txtAutorArt.Name = "txtAutorArt"
        Me.txtAutorArt.Size = New System.Drawing.Size(37, 20)
        Me.txtAutorArt.TabIndex = 208
        '
        'txtPersonArt
        '
        Me.txtPersonArt.BackColor = System.Drawing.Color.LightGreen
        Me.txtPersonArt.Location = New System.Drawing.Point(326, 69)
        Me.txtPersonArt.Name = "txtPersonArt"
        Me.txtPersonArt.Size = New System.Drawing.Size(38, 20)
        Me.txtPersonArt.TabIndex = 209
        '
        'txtPerson
        '
        Me.txtPerson.BackColor = System.Drawing.Color.LightGreen
        Me.txtPerson.Location = New System.Drawing.Point(221, 69)
        Me.txtPerson.Name = "txtPerson"
        Me.txtPerson.Size = New System.Drawing.Size(100, 20)
        Me.txtPerson.TabIndex = 207
        '
        'txtBindung
        '
        Me.txtBindung.BackColor = System.Drawing.Color.LightGreen
        Me.txtBindung.Location = New System.Drawing.Point(240, 284)
        Me.txtBindung.Name = "txtBindung"
        Me.txtBindung.Size = New System.Drawing.Size(124, 20)
        Me.txtBindung.TabIndex = 204
        '
        'txtDruckerei
        '
        Me.txtDruckerei.BackColor = System.Drawing.Color.LightGreen
        Me.txtDruckerei.Location = New System.Drawing.Point(240, 257)
        Me.txtDruckerei.Name = "txtDruckerei"
        Me.txtDruckerei.Size = New System.Drawing.Size(124, 20)
        Me.txtDruckerei.TabIndex = 205
        '
        'SeitenTextBox
        '
        Me.SeitenTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SeitenTextBox.Location = New System.Drawing.Point(512, 177)
        Me.SeitenTextBox.Name = "SeitenTextBox"
        Me.SeitenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SeitenTextBox.TabIndex = 27
        '
        'txtSprache
        '
        Me.txtSprache.BackColor = System.Drawing.Color.LightGreen
        Me.txtSprache.Location = New System.Drawing.Point(646, 231)
        Me.txtSprache.Name = "txtSprache"
        Me.txtSprache.Size = New System.Drawing.Size(124, 20)
        Me.txtSprache.TabIndex = 206
        '
        'txtLand
        '
        Me.txtLand.BackColor = System.Drawing.Color.LightGreen
        Me.txtLand.Location = New System.Drawing.Point(646, 203)
        Me.txtLand.Name = "txtLand"
        Me.txtLand.Size = New System.Drawing.Size(124, 20)
        Me.txtLand.TabIndex = 203
        '
        'AuiflageTextBox
        '
        Me.AuiflageTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AuiflageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Auiflage", True))
        Me.AuiflageTextBox.Location = New System.Drawing.Point(512, 129)
        Me.AuiflageTextBox.Name = "AuiflageTextBox"
        Me.AuiflageTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AuiflageTextBox.TabIndex = 26
        '
        'txtVerlagOrt
        '
        Me.txtVerlagOrt.BackColor = System.Drawing.Color.LightGreen
        Me.txtVerlagOrt.Location = New System.Drawing.Point(240, 231)
        Me.txtVerlagOrt.Name = "txtVerlagOrt"
        Me.txtVerlagOrt.Size = New System.Drawing.Size(124, 20)
        Me.txtVerlagOrt.TabIndex = 199
        '
        'txtVerlag
        '
        Me.txtVerlag.BackColor = System.Drawing.Color.LightGreen
        Me.txtVerlag.Location = New System.Drawing.Point(240, 205)
        Me.txtVerlag.Name = "txtVerlag"
        Me.txtVerlag.Size = New System.Drawing.Size(124, 20)
        Me.txtVerlag.TabIndex = 198
        '
        'txtCopyrDat
        '
        Me.txtCopyrDat.BackColor = System.Drawing.Color.LightGreen
        Me.txtCopyrDat.Location = New System.Drawing.Point(240, 176)
        Me.txtCopyrDat.Name = "txtCopyrDat"
        Me.txtCopyrDat.Size = New System.Drawing.Size(124, 20)
        Me.txtCopyrDat.TabIndex = 196
        '
        'txtVeroeff
        '
        Me.txtVeroeff.BackColor = System.Drawing.Color.LightGreen
        Me.txtVeroeff.Location = New System.Drawing.Point(240, 152)
        Me.txtVeroeff.MaxLength = 50
        Me.txtVeroeff.Name = "txtVeroeff"
        Me.txtVeroeff.Size = New System.Drawing.Size(124, 20)
        Me.txtVeroeff.TabIndex = 195
        '
        'txtAutorSort
        '
        Me.txtAutorSort.BackColor = System.Drawing.Color.LightGreen
        Me.txtAutorSort.Location = New System.Drawing.Point(221, 43)
        Me.txtAutorSort.Name = "txtAutorSort"
        Me.txtAutorSort.Size = New System.Drawing.Size(100, 20)
        Me.txtAutorSort.TabIndex = 194
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage4.Controls.Add(Me.GenreLinkDataGridView)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.ListBoxGenre)
        Me.TabPage4.Controls.Add(Me.CheckedListBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(932, 446)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Genre"
        '
        'GenreLinkDataGridView
        '
        Me.GenreLinkDataGridView.AllowUserToAddRows = False
        Me.GenreLinkDataGridView.AllowUserToDeleteRows = False
        Me.GenreLinkDataGridView.AllowUserToResizeColumns = False
        Me.GenreLinkDataGridView.AutoGenerateColumns = False
        Me.GenreLinkDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.GenreLinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GenreLinkDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.BuchIDDataGridViewTextBoxColumn, Me.SachgruppeIDDataGridViewTextBoxColumn})
        Me.GenreLinkDataGridView.DataSource = Me.GenreLinkBindingSource
        Me.GenreLinkDataGridView.Location = New System.Drawing.Point(652, 66)
        Me.GenreLinkDataGridView.Name = "GenreLinkDataGridView"
        Me.GenreLinkDataGridView.ReadOnly = True
        Me.GenreLinkDataGridView.RowHeadersVisible = False
        Me.GenreLinkDataGridView.Size = New System.Drawing.Size(200, 82)
        Me.GenreLinkDataGridView.TabIndex = 184
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'BuchIDDataGridViewTextBoxColumn
        '
        Me.BuchIDDataGridViewTextBoxColumn.DataPropertyName = "BuchID"
        Me.BuchIDDataGridViewTextBoxColumn.HeaderText = "BuchID"
        Me.BuchIDDataGridViewTextBoxColumn.Name = "BuchIDDataGridViewTextBoxColumn"
        Me.BuchIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SachgruppeIDDataGridViewTextBoxColumn
        '
        Me.SachgruppeIDDataGridViewTextBoxColumn.DataPropertyName = "SachgruppeID"
        Me.SachgruppeIDDataGridViewTextBoxColumn.HeaderText = "SachgruppeID"
        Me.SachgruppeIDDataGridViewTextBoxColumn.Name = "SachgruppeIDDataGridViewTextBoxColumn"
        Me.SachgruppeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(649, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 184
        Me.Label3.Text = "Aktuell gespeichert:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 182
        Me.Label2.Text = "Genre:"
        '
        'ListBoxGenre
        '
        Me.ListBoxGenre.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ListBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBoxGenre.FormattingEnabled = True
        Me.ListBoxGenre.Location = New System.Drawing.Point(92, 66)
        Me.ListBoxGenre.Name = "ListBoxGenre"
        Me.ListBoxGenre.Size = New System.Drawing.Size(200, 80)
        Me.ListBoxGenre.TabIndex = 174
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(3, 155)
        Me.CheckedListBox1.MultiColumn = True
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(849, 274)
        Me.CheckedListBox1.Sorted = True
        Me.CheckedListBox1.TabIndex = 173
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage2.Controls.Add(Me.CheckBox26)
        Me.TabPage2.Controls.Add(Me.CheckBox25)
        Me.TabPage2.Controls.Add(Me.CheckBox24)
        Me.TabPage2.Controls.Add(Me.txtKurz)
        Me.TabPage2.Controls.Add(Me.Synopsis_PlainTextTextBox)
        Me.TabPage2.Controls.Add(Me.Anmerkungen_PlainTextTextBox)
        Me.TabPage2.Controls.Add(Me.StichworteTextBox)
        Me.TabPage2.Controls.Add(Me.txtStWorte)
        Me.TabPage2.Controls.Add(Me.txtAnmerk)
        Me.TabPage2.Controls.Add(Synopsis_PlainTextLabel1)
        Me.TabPage2.Controls.Add(Anmerkungen_PlainTextLabel)
        Me.TabPage2.Controls.Add(StichworteLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(932, 446)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Memos"
        '
        'CheckBox26
        '
        Me.CheckBox26.AutoSize = True
        Me.CheckBox26.Location = New System.Drawing.Point(675, 224)
        Me.CheckBox26.Name = "CheckBox26"
        Me.CheckBox26.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox26.TabIndex = 130
        Me.CheckBox26.UseVisualStyleBackColor = True
        '
        'CheckBox25
        '
        Me.CheckBox25.AutoSize = True
        Me.CheckBox25.Location = New System.Drawing.Point(675, 88)
        Me.CheckBox25.Name = "CheckBox25"
        Me.CheckBox25.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox25.TabIndex = 130
        Me.CheckBox25.UseVisualStyleBackColor = True
        '
        'CheckBox24
        '
        Me.CheckBox24.AutoSize = True
        Me.CheckBox24.Location = New System.Drawing.Point(675, 27)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox24.TabIndex = 130
        Me.CheckBox24.UseVisualStyleBackColor = True
        '
        'txtKurz
        '
        Me.txtKurz.BackColor = System.Drawing.Color.LightGreen
        Me.txtKurz.Location = New System.Drawing.Point(371, 224)
        Me.txtKurz.Multiline = True
        Me.txtKurz.Name = "txtKurz"
        Me.txtKurz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtKurz.Size = New System.Drawing.Size(298, 110)
        Me.txtKurz.TabIndex = 129
        '
        'Synopsis_PlainTextTextBox
        '
        Me.Synopsis_PlainTextTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Synopsis_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Synopsis_PlainText", True))
        Me.Synopsis_PlainTextTextBox.Location = New System.Drawing.Point(58, 224)
        Me.Synopsis_PlainTextTextBox.Multiline = True
        Me.Synopsis_PlainTextTextBox.Name = "Synopsis_PlainTextTextBox"
        Me.Synopsis_PlainTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Synopsis_PlainTextTextBox.Size = New System.Drawing.Size(298, 110)
        Me.Synopsis_PlainTextTextBox.TabIndex = 128
        '
        'Anmerkungen_PlainTextTextBox
        '
        Me.Anmerkungen_PlainTextTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Anmerkungen_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Anmerkungen_PlainText", True))
        Me.Anmerkungen_PlainTextTextBox.Location = New System.Drawing.Point(58, 88)
        Me.Anmerkungen_PlainTextTextBox.Multiline = True
        Me.Anmerkungen_PlainTextTextBox.Name = "Anmerkungen_PlainTextTextBox"
        Me.Anmerkungen_PlainTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Anmerkungen_PlainTextTextBox.Size = New System.Drawing.Size(298, 113)
        Me.Anmerkungen_PlainTextTextBox.TabIndex = 127
        '
        'StichworteTextBox
        '
        Me.StichworteTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.StichworteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuchBindingSource, "Stichworte", True))
        Me.StichworteTextBox.Location = New System.Drawing.Point(58, 25)
        Me.StichworteTextBox.Multiline = True
        Me.StichworteTextBox.Name = "StichworteTextBox"
        Me.StichworteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.StichworteTextBox.Size = New System.Drawing.Size(298, 44)
        Me.StichworteTextBox.TabIndex = 126
        '
        'txtStWorte
        '
        Me.txtStWorte.BackColor = System.Drawing.Color.LightGreen
        Me.txtStWorte.Location = New System.Drawing.Point(371, 25)
        Me.txtStWorte.Multiline = True
        Me.txtStWorte.Name = "txtStWorte"
        Me.txtStWorte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStWorte.Size = New System.Drawing.Size(298, 44)
        Me.txtStWorte.TabIndex = 124
        '
        'txtAnmerk
        '
        Me.txtAnmerk.BackColor = System.Drawing.Color.LightGreen
        Me.txtAnmerk.Location = New System.Drawing.Point(371, 86)
        Me.txtAnmerk.Multiline = True
        Me.txtAnmerk.Name = "txtAnmerk"
        Me.txtAnmerk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAnmerk.Size = New System.Drawing.Size(298, 113)
        Me.txtAnmerk.TabIndex = 122
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage5.Controls.Add(Me.CheckedListBox2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(932, 446)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "MARK21"
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(58, 28)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(642, 379)
        Me.CheckedListBox2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.btMarc21)
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 640)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(361, 74)
        Me.Panel4.TabIndex = 0
        '
        'btMarc21
        '
        Me.btMarc21.Location = New System.Drawing.Point(54, 30)
        Me.btMarc21.Name = "btMarc21"
        Me.btMarc21.Size = New System.Drawing.Size(75, 23)
        Me.btMarc21.TabIndex = 21
        Me.btMarc21.Text = "MARC21"
        Me.btMarc21.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(224, 28)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 27)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Abbrechen"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.btSvae)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(370, 640)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(940, 74)
        Me.Panel3.TabIndex = 0
        '
        'btSvae
        '
        Me.btSvae.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSvae.Location = New System.Drawing.Point(294, 28)
        Me.btSvae.Name = "btSvae"
        Me.btSvae.Size = New System.Drawing.Size(111, 27)
        Me.btSvae.TabIndex = 20
        Me.btSvae.Text = "Speichern"
        Me.btSvae.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(701, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 26)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "alles abwählen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(700, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "alles auswählen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.ImagePictureBox)
        Me.Panel1.Controls.Add(Me.CheckBoxCover)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LblCoverVorhanden)
        Me.Panel1.Controls.Add(BookIDLabel1)
        Me.Panel1.Controls.Add(Me.BookIDTextBox)
        Me.Panel1.Controls.Add(IdLabel2)
        Me.Panel1.Controls.Add(Me.IdTextBox2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 162)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(361, 472)
        Me.Panel1.TabIndex = 0
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.Location = New System.Drawing.Point(106, 226)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(117, 145)
        Me.ImagePictureBox.TabIndex = 68
        Me.ImagePictureBox.TabStop = False
        '
        'CheckBoxCover
        '
        Me.CheckBoxCover.AutoSize = True
        Me.CheckBoxCover.Checked = True
        Me.CheckBoxCover.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCover.Location = New System.Drawing.Point(239, 34)
        Me.CheckBoxCover.Name = "CheckBoxCover"
        Me.CheckBoxCover.Size = New System.Drawing.Size(87, 17)
        Me.CheckBoxCover.TabIndex = 67
        Me.CheckBoxCover.Text = "Übernehmen"
        Me.CheckBoxCover.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(103, 380)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 52)
        Me.Button6.TabIndex = 66
        Me.Button6.Text = "Bild aus Zwischenablage einfügen"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Cover Online"
        '
        'LblCoverVorhanden
        '
        Me.LblCoverVorhanden.AutoSize = True
        Me.LblCoverVorhanden.Location = New System.Drawing.Point(34, 200)
        Me.LblCoverVorhanden.Name = "LblCoverVorhanden"
        Me.LblCoverVorhanden.Size = New System.Drawing.Size(63, 13)
        Me.LblCoverVorhanden.TabIndex = 64
        Me.LblCoverVorhanden.Text = "Im Bestand:"
        '
        'BookIDTextBox
        '
        Me.BookIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BookIDTextBox.Enabled = False
        Me.BookIDTextBox.Location = New System.Drawing.Point(61, 226)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.Size = New System.Drawing.Size(32, 20)
        Me.BookIDTextBox.TabIndex = 62
        '
        'IdTextBox2
        '
        Me.IdTextBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.IdTextBox2.Enabled = False
        Me.IdTextBox2.Location = New System.Drawing.Point(61, 252)
        Me.IdTextBox2.Name = "IdTextBox2"
        Me.IdTextBox2.Size = New System.Drawing.Size(32, 20)
        Me.IdTextBox2.TabIndex = 61
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(246, 229)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 130)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(106, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.9668!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.0332!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.84229!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.15771!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1313, 717)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'StandortTableAdapter
        '
        Me.StandortTableAdapter.ClearBeforeFill = True
        '
        'BuchNeuDNB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 717)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "BuchNeuDNB"
        Me.Text = "BookCMS - Neues Buch aus der Deutschen Nationalbibliothek"
        CType(Me.BuchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerlagsOrtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerlagBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenreLinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorBuchLinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.BibliothekBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.SachgruppeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuchTypBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandortBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorBuchLinkDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorRolleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LanguageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DruckereiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindungBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.GenreLinkDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents BuchBindingSource As BindingSource
    Friend WithEvents BuchTableAdapter As _BookCMS_singleDataSetTableAdapters.BuchTableAdapter
    Friend WithEvents AutorBuchLinkBindingSource As BindingSource
    Friend WithEvents AutorBuchLinkTableAdapter As _BookCMS_singleDataSetTableAdapters.AutorBuchLinkTableAdapter
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VerlagTableAdapter As _BookCMS_singleDataSetTableAdapters.VerlagTableAdapter
    Friend WithEvents VerlagBindingSource As BindingSource
    Friend WithEvents VerlagsOrtTableAdapter As _BookCMS_singleDataSetTableAdapters.VerlagsOrtTableAdapter
    Friend WithEvents VerlagsOrtBindingSource As BindingSource
    Friend WithEvents GenreLinkTableAdapter As _BookCMS_singleDataSetTableAdapters.GenreLinkTableAdapter
    Friend WithEvents GenreLinkBindingSource As BindingSource
    Friend WithEvents NewDataSet As NewDataSet
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ListBoxTitel As ListBox
    Friend WithEvents lblBestand As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LetzteAenderungTextBox As TextBox
    Friend WithEvents TitelIndexTextBox As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtSignatur As TextBox
    Friend WithEvents SignaturTextBox As TextBox
    Friend WithEvents TxtUTitel As TextBox
    Friend WithEvents TxtTitel As TextBox
    Friend WithEvents TitelTextBox As TextBox
    Friend WithEvents UntertitelTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TitleSortTextBox As TextBox
    Friend WithEvents OrtIDTextBox1 As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents StandortIDTextBox As TextBox
    Friend WithEvents SachgruppeIDTextBox As TextBox
    Friend WithEvents TypIDTextBox As TextBox
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents ComboBox11 As ComboBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AutorBuchLinkDataGridView As DataGridView
    Friend WithEvents DNBTextBox As TextBox
    Friend WithEvents txtDDC As TextBox
    Friend WithEvents ISBNTextBox As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtDNB As TextBox
    Friend WithEvents txtLCCN As TextBox
    Friend WithEvents AutorSortTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DDCTextBox As TextBox
    Friend WithEvents SprachenIDTextBox As TextBox
    Friend WithEvents LCCNTextBox As TextBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox23 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox22 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox27 As CheckBox
    Friend WithEvents CheckBox21 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox20 As CheckBox
    Friend WithEvents CheckBox19 As CheckBox
    Friend WithEvents CheckBox18 As CheckBox
    Friend WithEvents CheckBox17 As CheckBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents OriginalSpracheIDTextBox As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CopyrightDatumTextBox As TextBox
    Friend WithEvents LandDTextBox As TextBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents SerienIDTextBox As TextBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents BindungIDTextBox As TextBox
    Friend WithEvents DruckereiIDTextBox As TextBox
    Friend WithEvents VeroeffentlichtTextBox As TextBox
    Friend WithEvents VerkaufspreisTextBox As TextBox
    Friend WithEvents OriginalUntertitelTextBox As TextBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents OriginalTitelTextBox As TextBox
    Friend WithEvents txtGroesse As TextBox
    Friend WithEvents txtBarCode As TextBox
    Friend WithEvents VerlagsIDTextBox As TextBox
    Friend WithEvents txtPreis As TextBox
    Friend WithEvents txtOrgLang As TextBox
    Friend WithEvents txtOrgUT As TextBox
    Friend WithEvents txtOrgTitel As TextBox
    Friend WithEvents txtSeiten As TextBox
    Friend WithEvents Dim_HeightTextBox As TextBox
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents BarCodeTextBox As TextBox
    Friend WithEvents txtAuflage As TextBox
    Friend WithEvents txtAutorArt As TextBox
    Friend WithEvents txtPersonArt As TextBox
    Friend WithEvents txtPerson As TextBox
    Friend WithEvents txtBindung As TextBox
    Friend WithEvents txtDruckerei As TextBox
    Friend WithEvents SeitenTextBox As TextBox
    Friend WithEvents txtSprache As TextBox
    Friend WithEvents txtLand As TextBox
    Friend WithEvents AuiflageTextBox As TextBox
    Friend WithEvents txtVerlagOrt As TextBox
    Friend WithEvents txtVerlag As TextBox
    Friend WithEvents txtCopyrDat As TextBox
    Friend WithEvents txtVeroeff As TextBox
    Friend WithEvents txtAutorSort As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GenreLinkDataGridView As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuchIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SachgruppeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBoxGenre As ListBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CheckBox26 As CheckBox
    Friend WithEvents CheckBox25 As CheckBox
    Friend WithEvents CheckBox24 As CheckBox
    Friend WithEvents txtKurz As TextBox
    Friend WithEvents Synopsis_PlainTextTextBox As TextBox
    Friend WithEvents Anmerkungen_PlainTextTextBox As TextBox
    Friend WithEvents StichworteTextBox As TextBox
    Friend WithEvents txtStWorte As TextBox
    Friend WithEvents txtAnmerk As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btMarc21 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btSvae As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents CheckBoxCover As CheckBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LblCoverVorhanden As Label
    Friend WithEvents BookIDTextBox As TextBox
    Friend WithEvents IdTextBox2 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PersonBindingSource As BindingSource
    Friend WithEvents PersonTableAdapter As _BookCMS_singleDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents AutorRolleBindingSource As BindingSource
    Friend WithEvents AutorRolleTableAdapter As _BookCMS_singleDataSetTableAdapters.AutorRolleTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BuchIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PersonIDDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents RolleIDDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents StandortBindingSource As BindingSource
    Friend WithEvents StandortTableAdapter As _BookCMS_singleDataSetTableAdapters.StandortTableAdapter
    Friend WithEvents BuchTypBindingSource As BindingSource
    Friend WithEvents BuchTypTableAdapter As _BookCMS_singleDataSetTableAdapters.BuchTypTableAdapter
    Friend WithEvents DruckereiBindingSource As BindingSource
    Friend WithEvents DruckereiTableAdapter As _BookCMS_singleDataSetTableAdapters.DruckereiTableAdapter
    Friend WithEvents BindungBindingSource As BindingSource
    Friend WithEvents BindungTableAdapter As _BookCMS_singleDataSetTableAdapters.BindungTableAdapter
    Friend WithEvents LanguageBindingSource As BindingSource
    Friend WithEvents LanguageTableAdapter As _BookCMS_singleDataSetTableAdapters.LanguageTableAdapter
    Friend WithEvents SachgruppeBindingSource As BindingSource
    Friend WithEvents SachgruppeTableAdapter As _BookCMS_singleDataSetTableAdapters.SachgruppeTableAdapter
    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents BibliothekTextBox As TextBox
    Friend WithEvents BibliothekBindingSource As BindingSource
    Friend WithEvents BibliothekTableAdapter As _BookCMS_singleDataSetTableAdapters.BibliothekTableAdapter
    Friend WithEvents LandBindingSource As BindingSource
    Friend WithEvents LandTableAdapter As _BookCMS_singleDataSetTableAdapters.LandTableAdapter
End Class
