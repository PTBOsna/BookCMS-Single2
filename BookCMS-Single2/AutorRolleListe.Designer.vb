<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutorRolleListe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutorRolleListe))
        Dim IDLabel As System.Windows.Forms.Label
        Dim MarkedLabel As System.Windows.Forms.Label
        Dim AutorRolleLabel As System.Windows.Forms.Label
        Dim AutorKurzLabel As System.Windows.Forms.Label
        Dim Notiz_PlainTextLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.AutorRolleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutorRolleTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.AutorRolleTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.AutorRolleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AutorRolleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AutorRolleDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.MarkedCheckBox = New System.Windows.Forms.CheckBox()
        Me.AutorRolleTextBox = New System.Windows.Forms.TextBox()
        Me.AutorKurzTextBox = New System.Windows.Forms.TextBox()
        Me.Notiz_PlainTextTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        MarkedLabel = New System.Windows.Forms.Label()
        AutorRolleLabel = New System.Windows.Forms.Label()
        AutorKurzLabel = New System.Windows.Forms.Label()
        Notiz_PlainTextLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorRolleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorRolleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AutorRolleBindingNavigator.SuspendLayout()
        CType(Me.AutorRolleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AutorRolleDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.79021!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.20979!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(692, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 405)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 42)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(IDLabel)
        Me.Panel2.Controls.Add(Me.IDTextBox)
        Me.Panel2.Controls.Add(MarkedLabel)
        Me.Panel2.Controls.Add(Me.MarkedCheckBox)
        Me.Panel2.Controls.Add(AutorRolleLabel)
        Me.Panel2.Controls.Add(Me.AutorRolleTextBox)
        Me.Panel2.Controls.Add(AutorKurzLabel)
        Me.Panel2.Controls.Add(Me.AutorKurzTextBox)
        Me.Panel2.Controls.Add(Notiz_PlainTextLabel)
        Me.Panel2.Controls.Add(Me.Notiz_PlainTextTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(349, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 357)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel3, 2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(686, 33)
        Me.Panel3.TabIndex = 2
        '
        '_BookCMS_singleDataSet
        '
        Me._BookCMS_singleDataSet.DataSetName = "_BookCMS_singleDataSet"
        Me._BookCMS_singleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AutorRolleBindingSource
        '
        Me.AutorRolleBindingSource.DataMember = "AutorRolle"
        Me.AutorRolleBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'AutorRolleTableAdapter
        '
        Me.AutorRolleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutorBuchLinkTableAdapter = Nothing
        Me.TableAdapterManager.AutorRolleTableAdapter = Me.AutorRolleTableAdapter
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
        Me.TableAdapterManager.VerlagTableAdapter = Nothing
        '
        'AutorRolleBindingNavigator
        '
        Me.AutorRolleBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AutorRolleBindingNavigator.BindingSource = Me.AutorRolleBindingSource
        Me.AutorRolleBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AutorRolleBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AutorRolleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AutorRolleBindingNavigatorSaveItem})
        Me.AutorRolleBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AutorRolleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AutorRolleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AutorRolleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AutorRolleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AutorRolleBindingNavigator.Name = "AutorRolleBindingNavigator"
        Me.AutorRolleBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AutorRolleBindingNavigator.Size = New System.Drawing.Size(692, 25)
        Me.AutorRolleBindingNavigator.TabIndex = 1
        Me.AutorRolleBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
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
        'AutorRolleBindingNavigatorSaveItem
        '
        Me.AutorRolleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AutorRolleBindingNavigatorSaveItem.Image = CType(resources.GetObject("AutorRolleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AutorRolleBindingNavigatorSaveItem.Name = "AutorRolleBindingNavigatorSaveItem"
        Me.AutorRolleBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.AutorRolleBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'AutorRolleDataGridView
        '
        Me.AutorRolleDataGridView.AutoGenerateColumns = False
        Me.AutorRolleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AutorRolleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.AutorRolleDataGridView.DataSource = Me.AutorRolleBindingSource
        Me.AutorRolleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AutorRolleDataGridView.Location = New System.Drawing.Point(3, 42)
        Me.AutorRolleDataGridView.Name = "AutorRolleDataGridView"
        Me.AutorRolleDataGridView.Size = New System.Drawing.Size(340, 357)
        Me.AutorRolleDataGridView.TabIndex = 3
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(19, 14)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutorRolleBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(109, 11)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(62, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'MarkedLabel
        '
        MarkedLabel.AutoSize = True
        MarkedLabel.Location = New System.Drawing.Point(19, 239)
        MarkedLabel.Name = "MarkedLabel"
        MarkedLabel.Size = New System.Drawing.Size(46, 13)
        MarkedLabel.TabIndex = 2
        MarkedLabel.Text = "Marked:"
        '
        'MarkedCheckBox
        '
        Me.MarkedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AutorRolleBindingSource, "Marked", True))
        Me.MarkedCheckBox.Location = New System.Drawing.Point(109, 234)
        Me.MarkedCheckBox.Name = "MarkedCheckBox"
        Me.MarkedCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.MarkedCheckBox.TabIndex = 3
        Me.MarkedCheckBox.Text = "CheckBox1"
        Me.MarkedCheckBox.UseVisualStyleBackColor = True
        '
        'AutorRolleLabel
        '
        AutorRolleLabel.AutoSize = True
        AutorRolleLabel.Location = New System.Drawing.Point(19, 70)
        AutorRolleLabel.Name = "AutorRolleLabel"
        AutorRolleLabel.Size = New System.Drawing.Size(34, 13)
        AutorRolleLabel.TabIndex = 4
        AutorRolleLabel.Text = "Rolle:"
        '
        'AutorRolleTextBox
        '
        Me.AutorRolleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutorRolleBindingSource, "AutorRolle", True))
        Me.AutorRolleTextBox.Location = New System.Drawing.Point(109, 67)
        Me.AutorRolleTextBox.Name = "AutorRolleTextBox"
        Me.AutorRolleTextBox.Size = New System.Drawing.Size(190, 20)
        Me.AutorRolleTextBox.TabIndex = 5
        '
        'AutorKurzLabel
        '
        AutorKurzLabel.AutoSize = True
        AutorKurzLabel.Location = New System.Drawing.Point(19, 96)
        AutorKurzLabel.Name = "AutorKurzLabel"
        AutorKurzLabel.Size = New System.Drawing.Size(57, 13)
        AutorKurzLabel.TabIndex = 6
        AutorKurzLabel.Text = "Rolle kurz:"
        '
        'AutorKurzTextBox
        '
        Me.AutorKurzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutorRolleBindingSource, "AutorKurz", True))
        Me.AutorKurzTextBox.Location = New System.Drawing.Point(109, 93)
        Me.AutorKurzTextBox.Name = "AutorKurzTextBox"
        Me.AutorKurzTextBox.Size = New System.Drawing.Size(190, 20)
        Me.AutorKurzTextBox.TabIndex = 7
        '
        'Notiz_PlainTextLabel
        '
        Notiz_PlainTextLabel.AutoSize = True
        Notiz_PlainTextLabel.Location = New System.Drawing.Point(19, 122)
        Notiz_PlainTextLabel.Name = "Notiz_PlainTextLabel"
        Notiz_PlainTextLabel.Size = New System.Drawing.Size(34, 13)
        Notiz_PlainTextLabel.TabIndex = 8
        Notiz_PlainTextLabel.Text = "Notiz:"
        '
        'Notiz_PlainTextTextBox
        '
        Me.Notiz_PlainTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutorRolleBindingSource, "Notiz_PlainText", True))
        Me.Notiz_PlainTextTextBox.Location = New System.Drawing.Point(109, 119)
        Me.Notiz_PlainTextTextBox.Multiline = True
        Me.Notiz_PlainTextTextBox.Name = "Notiz_PlainTextTextBox"
        Me.Notiz_PlainTextTextBox.Size = New System.Drawing.Size(190, 70)
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
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AutorRolle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Rolle"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 56
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "AutorKurz"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kurz"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(311, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Zurück"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AutorRolleListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 450)
        Me.Controls.Add(Me.AutorRolleBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AutorRolleListe"
        Me.Text = "AutorRolleListe"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorRolleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorRolleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AutorRolleBindingNavigator.ResumeLayout(False)
        Me.AutorRolleBindingNavigator.PerformLayout()
        CType(Me.AutorRolleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents AutorRolleBindingSource As BindingSource
    Friend WithEvents AutorRolleTableAdapter As _BookCMS_singleDataSetTableAdapters.AutorRolleTableAdapter
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AutorRolleBindingNavigator As BindingNavigator
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
    Friend WithEvents AutorRolleBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AutorRolleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents MarkedCheckBox As CheckBox
    Friend WithEvents AutorRolleTextBox As TextBox
    Friend WithEvents AutorKurzTextBox As TextBox
    Friend WithEvents Notiz_PlainTextTextBox As TextBox
End Class
