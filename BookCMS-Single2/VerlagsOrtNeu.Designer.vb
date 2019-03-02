<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerlagsOrtNeu
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
        Dim VerlagsortLabel As System.Windows.Forms.Label
        Dim SortByLabel As System.Windows.Forms.Label
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.VerlagsOrtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VerlagsOrtTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.VerlagsOrtTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.MarkedCheckBox = New System.Windows.Forms.CheckBox()
        Me.VerlagsortTextBox = New System.Windows.Forms.TextBox()
        Me.SortByTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Notiz_PlainTextRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        VerlagsortLabel = New System.Windows.Forms.Label()
        SortByLabel = New System.Windows.Forms.Label()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerlagsOrtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.436725!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.56328!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(567, 450)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(555, 363)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(555, 363)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(IDLabel)
        Me.TabPage1.Controls.Add(Me.IDTextBox)
        Me.TabPage1.Controls.Add(Me.MarkedCheckBox)
        Me.TabPage1.Controls.Add(VerlagsortLabel)
        Me.TabPage1.Controls.Add(Me.VerlagsortTextBox)
        Me.TabPage1.Controls.Add(SortByLabel)
        Me.TabPage1.Controls.Add(Me.SortByTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(547, 337)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(42, 44)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagsOrtBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(132, 41)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(96, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'MarkedCheckBox
        '
        Me.MarkedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VerlagsOrtBindingSource, "Marked", True))
        Me.MarkedCheckBox.Location = New System.Drawing.Point(386, 39)
        Me.MarkedCheckBox.Name = "MarkedCheckBox"
        Me.MarkedCheckBox.Size = New System.Drawing.Size(78, 24)
        Me.MarkedCheckBox.TabIndex = 3
        Me.MarkedCheckBox.Text = "Markiert"
        Me.MarkedCheckBox.UseVisualStyleBackColor = True
        '
        'VerlagsortLabel
        '
        VerlagsortLabel.AutoSize = True
        VerlagsortLabel.Location = New System.Drawing.Point(42, 100)
        VerlagsortLabel.Name = "VerlagsortLabel"
        VerlagsortLabel.Size = New System.Drawing.Size(57, 13)
        VerlagsortLabel.TabIndex = 4
        VerlagsortLabel.Text = "Verlagsort:"
        '
        'VerlagsortTextBox
        '
        Me.VerlagsortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagsOrtBindingSource, "Verlagsort", True))
        Me.VerlagsortTextBox.Location = New System.Drawing.Point(132, 97)
        Me.VerlagsortTextBox.Name = "VerlagsortTextBox"
        Me.VerlagsortTextBox.Size = New System.Drawing.Size(321, 20)
        Me.VerlagsortTextBox.TabIndex = 5
        '
        'SortByLabel
        '
        SortByLabel.AutoSize = True
        SortByLabel.Location = New System.Drawing.Point(42, 148)
        SortByLabel.Name = "SortByLabel"
        SortByLabel.Size = New System.Drawing.Size(43, 13)
        SortByLabel.TabIndex = 6
        SortByLabel.Text = "Sortiert:"
        '
        'SortByTextBox
        '
        Me.SortByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagsOrtBindingSource, "SortBy", True))
        Me.SortByTextBox.Location = New System.Drawing.Point(132, 145)
        Me.SortByTextBox.Name = "SortByTextBox"
        Me.SortByTextBox.Size = New System.Drawing.Size(321, 20)
        Me.SortByTextBox.TabIndex = 7
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Notiz_PlainTextRichTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(547, 337)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Notizen"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Notiz_PlainTextRichTextBox
        '
        Me.Notiz_PlainTextRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VerlagsOrtBindingSource, "Notiz_PlainText", True))
        Me.Notiz_PlainTextRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Notiz_PlainTextRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.Notiz_PlainTextRichTextBox.Name = "Notiz_PlainTextRichTextBox"
        Me.Notiz_PlainTextRichTextBox.Size = New System.Drawing.Size(541, 331)
        Me.Notiz_PlainTextRichTextBox.TabIndex = 1
        Me.Notiz_PlainTextRichTextBox.Text = ""
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 406)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(555, 41)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(244, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VerlagsOrtNeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "VerlagsOrtNeu"
        Me.Text = "VerlagsOrtNeu"
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerlagsOrtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents VerlagsOrtBindingSource As BindingSource
    Friend WithEvents VerlagsOrtTableAdapter As _BookCMS_singleDataSetTableAdapters.VerlagsOrtTableAdapter
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents MarkedCheckBox As CheckBox
    Friend WithEvents VerlagsortTextBox As TextBox
    Friend WithEvents SortByTextBox As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Notiz_PlainTextRichTextBox As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
End Class
