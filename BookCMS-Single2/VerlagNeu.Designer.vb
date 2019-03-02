<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerlagNeu
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
        Dim Addresse_PlainTextLabel As System.Windows.Forms.Label
        Dim PublisherIDLabel As System.Windows.Forms.Label
        Dim VerlagLabel As System.Windows.Forms.Label
        Dim SortByLabel As System.Windows.Forms.Label
        Dim WWWLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PublisherIDTextBox = New System.Windows.Forms.TextBox()
        Me.MarkedCheckBox = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Notiz_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.VerlagBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VerlagTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.VerlagTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.VerlagTextBox = New System.Windows.Forms.TextBox()
        Me.SortByTextBox = New System.Windows.Forms.TextBox()
        Me.WWWTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Addresse_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Addresse_PlainTextLabel = New System.Windows.Forms.Label()
        PublisherIDLabel = New System.Windows.Forms.Label()
        VerlagLabel = New System.Windows.Forms.Label()
        SortByLabel = New System.Windows.Forms.Label()
        WWWLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerlagBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.16786!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.832134!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(661, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(648, 399)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.VerlagTextBox)
        Me.TabPage1.Controls.Add(Me.SortByTextBox)
        Me.TabPage1.Controls.Add(Me.WWWTextBox)
        Me.TabPage1.Controls.Add(Me.EmailTextBox)
        Me.TabPage1.Controls.Add(Me.Addresse_PlainTextTextBox)
        Me.TabPage1.Controls.Add(Me.PhoneTextBox)
        Me.TabPage1.Controls.Add(Me.FaxTextBox)
        Me.TabPage1.Controls.Add(Addresse_PlainTextLabel)
        Me.TabPage1.Controls.Add(PublisherIDLabel)
        Me.TabPage1.Controls.Add(Me.PublisherIDTextBox)
        Me.TabPage1.Controls.Add(Me.MarkedCheckBox)
        Me.TabPage1.Controls.Add(VerlagLabel)
        Me.TabPage1.Controls.Add(SortByLabel)
        Me.TabPage1.Controls.Add(WWWLabel)
        Me.TabPage1.Controls.Add(EmailLabel)
        Me.TabPage1.Controls.Add(PhoneLabel)
        Me.TabPage1.Controls.Add(FaxLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(640, 373)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Übersicht"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Addresse_PlainTextLabel
        '
        Addresse_PlainTextLabel.AutoSize = True
        Addresse_PlainTextLabel.Location = New System.Drawing.Point(58, 156)
        Addresse_PlainTextLabel.Name = "Addresse_PlainTextLabel"
        Addresse_PlainTextLabel.Size = New System.Drawing.Size(54, 13)
        Addresse_PlainTextLabel.TabIndex = 19
        Addresse_PlainTextLabel.Text = "Addresse:"
        '
        'PublisherIDLabel
        '
        PublisherIDLabel.AutoSize = True
        PublisherIDLabel.Location = New System.Drawing.Point(56, 27)
        PublisherIDLabel.Name = "PublisherIDLabel"
        PublisherIDLabel.Size = New System.Drawing.Size(24, 13)
        PublisherIDLabel.TabIndex = 0
        PublisherIDLabel.Text = " ID:"
        '
        'PublisherIDTextBox
        '
        Me.PublisherIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "PublisherID", True))
        Me.PublisherIDTextBox.Location = New System.Drawing.Point(166, 24)
        Me.PublisherIDTextBox.Name = "PublisherIDTextBox"
        Me.PublisherIDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PublisherIDTextBox.TabIndex = 1
        '
        'MarkedCheckBox
        '
        Me.MarkedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "Marked", True))
        Me.MarkedCheckBox.Location = New System.Drawing.Point(368, 22)
        Me.MarkedCheckBox.Name = "MarkedCheckBox"
        Me.MarkedCheckBox.Size = New System.Drawing.Size(151, 24)
        Me.MarkedCheckBox.TabIndex = 3
        Me.MarkedCheckBox.Text = "aus DNB übernommen"
        Me.MarkedCheckBox.UseVisualStyleBackColor = True
        '
        'VerlagLabel
        '
        VerlagLabel.AutoSize = True
        VerlagLabel.Location = New System.Drawing.Point(56, 83)
        VerlagLabel.Name = "VerlagLabel"
        VerlagLabel.Size = New System.Drawing.Size(40, 13)
        VerlagLabel.TabIndex = 4
        VerlagLabel.Text = "Verlag:"
        '
        'SortByLabel
        '
        SortByLabel.AutoSize = True
        SortByLabel.Location = New System.Drawing.Point(56, 109)
        SortByLabel.Name = "SortByLabel"
        SortByLabel.Size = New System.Drawing.Size(44, 13)
        SortByLabel.TabIndex = 6
        SortByLabel.Text = "Sort By:"
        '
        'WWWLabel
        '
        WWWLabel.AutoSize = True
        WWWLabel.Location = New System.Drawing.Point(58, 238)
        WWWLabel.Name = "WWWLabel"
        WWWLabel.Size = New System.Drawing.Size(43, 13)
        WWWLabel.TabIndex = 10
        WWWLabel.Text = "WWW:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(58, 264)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Email:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(58, 316)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(28, 13)
        PhoneLabel.TabIndex = 16
        PhoneLabel.Text = "Tel.:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(58, 342)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(27, 13)
        FaxLabel.TabIndex = 18
        FaxLabel.Text = "Fax:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Notiz_PlainTextTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(640, 373)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Notizen"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Notiz_PlainTextTextBox
        '
        Me.Notiz_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "Notiz_PlainText", True))
        Me.Notiz_PlainTextTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Notiz_PlainTextTextBox.Location = New System.Drawing.Point(3, 3)
        Me.Notiz_PlainTextTextBox.Multiline = True
        Me.Notiz_PlainTextTextBox.Name = "Notiz_PlainTextTextBox"
        Me.Notiz_PlainTextTextBox.Size = New System.Drawing.Size(634, 367)
        Me.Notiz_PlainTextTextBox.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 408)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 39)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(278, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Zurück"
        Me.Button1.UseVisualStyleBackColor = True
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
        'VerlagTextBox
        '
        Me.VerlagTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "Verlag", True))
        Me.VerlagTextBox.Location = New System.Drawing.Point(166, 78)
        Me.VerlagTextBox.Name = "VerlagTextBox"
        Me.VerlagTextBox.Size = New System.Drawing.Size(226, 20)
        Me.VerlagTextBox.TabIndex = 24
        '
        'SortByTextBox
        '
        Me.SortByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "SortBy", True))
        Me.SortByTextBox.Location = New System.Drawing.Point(166, 104)
        Me.SortByTextBox.Name = "SortByTextBox"
        Me.SortByTextBox.Size = New System.Drawing.Size(226, 20)
        Me.SortByTextBox.TabIndex = 26
        '
        'WWWTextBox
        '
        Me.WWWTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "WWW", True))
        Me.WWWTextBox.Location = New System.Drawing.Point(166, 235)
        Me.WWWTextBox.Name = "WWWTextBox"
        Me.WWWTextBox.Size = New System.Drawing.Size(226, 20)
        Me.WWWTextBox.TabIndex = 30
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(166, 261)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(226, 20)
        Me.EmailTextBox.TabIndex = 32
        '
        'Addresse_PlainTextTextBox
        '
        Me.Addresse_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "Addresse_PlainText", True))
        Me.Addresse_PlainTextTextBox.Location = New System.Drawing.Point(164, 153)
        Me.Addresse_PlainTextTextBox.Multiline = True
        Me.Addresse_PlainTextTextBox.Name = "Addresse_PlainTextTextBox"
        Me.Addresse_PlainTextTextBox.Size = New System.Drawing.Size(228, 64)
        Me.Addresse_PlainTextTextBox.TabIndex = 34
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(166, 313)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(226, 20)
        Me.PhoneTextBox.TabIndex = 36
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(166, 339)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(226, 20)
        Me.FaxTextBox.TabIndex = 38
        '
        'VerlagNeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "VerlagNeu"
        Me.Text = "VerlagNeu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerlagBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PublisherIDTextBox As TextBox
    Friend WithEvents MarkedCheckBox As CheckBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Notiz_PlainTextTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents VerlagBindingSource As BindingSource
    Friend WithEvents VerlagTableAdapter As _BookCMS_singleDataSetTableAdapters.VerlagTableAdapter
    Friend WithEvents VerlagTextBox As TextBox
    Friend WithEvents SortByTextBox As TextBox
    Friend WithEvents WWWTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Addresse_PlainTextTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents FaxTextBox As TextBox
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
End Class
