<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckBuchAutorLink
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckBuchAutorLink))
        Me.BtDel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtCancel = New System.Windows.Forms.Button()
        Me.BuchDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutorSortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SignaturDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.AutorBuchLinkDataGridView = New System.Windows.Forms.DataGridView()
        Me.AutorBuchLinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.AutorBuchLinkTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.AutorBuchLinkTableAdapter()
        Me.BuchTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.BuchTableAdapter()
        Me.AutorBuchLinkBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AutorBuchLinkBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterManager1 = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.PersonTableAdapter()
        Me.AutorRolleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutorRolleTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.AutorRolleTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuchIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.RolleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.BuchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorBuchLinkDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorBuchLinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorBuchLinkBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AutorBuchLinkBindingNavigator.SuspendLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorRolleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtDel
        '
        Me.BtDel.ForeColor = System.Drawing.Color.DarkRed
        Me.BtDel.Location = New System.Drawing.Point(476, 496)
        Me.BtDel.Name = "BtDel"
        Me.BtDel.Size = New System.Drawing.Size(133, 23)
        Me.BtDel.TabIndex = 18
        Me.BtDel.Text = "Löschen"
        Me.BtDel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(733, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Buch-Liste"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(391, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Link-Liste"
        '
        'BtCancel
        '
        Me.BtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCancel.Location = New System.Drawing.Point(57, 496)
        Me.BtCancel.Name = "BtCancel"
        Me.BtCancel.Size = New System.Drawing.Size(127, 29)
        Me.BtCancel.TabIndex = 15
        Me.BtCancel.Text = "Zurück "
        Me.BtCancel.UseVisualStyleBackColor = True
        '
        'BuchDataGridView
        '
        Me.BuchDataGridView.AutoGenerateColumns = False
        Me.BuchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BuchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.TitelDataGridViewTextBoxColumn, Me.AutorSortDataGridViewTextBoxColumn, Me.SignaturDataGridViewTextBoxColumn})
        Me.BuchDataGridView.DataSource = Me.BuchBindingSource
        Me.BuchDataGridView.Location = New System.Drawing.Point(736, 81)
        Me.BuchDataGridView.Name = "BuchDataGridView"
        Me.BuchDataGridView.Size = New System.Drawing.Size(439, 404)
        Me.BuchDataGridView.TabIndex = 13
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'TitelDataGridViewTextBoxColumn
        '
        Me.TitelDataGridViewTextBoxColumn.DataPropertyName = "Titel"
        Me.TitelDataGridViewTextBoxColumn.HeaderText = "Titel"
        Me.TitelDataGridViewTextBoxColumn.Name = "TitelDataGridViewTextBoxColumn"
        '
        'AutorSortDataGridViewTextBoxColumn
        '
        Me.AutorSortDataGridViewTextBoxColumn.DataPropertyName = "AutorSort"
        Me.AutorSortDataGridViewTextBoxColumn.HeaderText = "AutorSort"
        Me.AutorSortDataGridViewTextBoxColumn.Name = "AutorSortDataGridViewTextBoxColumn"
        '
        'SignaturDataGridViewTextBoxColumn
        '
        Me.SignaturDataGridViewTextBoxColumn.DataPropertyName = "Signatur"
        Me.SignaturDataGridViewTextBoxColumn.HeaderText = "Signatur"
        Me.SignaturDataGridViewTextBoxColumn.Name = "SignaturDataGridViewTextBoxColumn"
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
        'AutorBuchLinkDataGridView
        '
        Me.AutorBuchLinkDataGridView.AutoGenerateColumns = False
        Me.AutorBuchLinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AutorBuchLinkDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.BuchIDDataGridViewTextBoxColumn, Me.PersonIDDataGridViewTextBoxColumn, Me.RolleIDDataGridViewTextBoxColumn})
        Me.AutorBuchLinkDataGridView.DataSource = Me.AutorBuchLinkBindingSource
        Me.AutorBuchLinkDataGridView.Location = New System.Drawing.Point(391, 81)
        Me.AutorBuchLinkDataGridView.Name = "AutorBuchLinkDataGridView"
        Me.AutorBuchLinkDataGridView.Size = New System.Drawing.Size(300, 404)
        Me.AutorBuchLinkDataGridView.TabIndex = 14
        '
        'AutorBuchLinkBindingSource
        '
        Me.AutorBuchLinkBindingSource.DataMember = "AutorBuchLink"
        Me.AutorBuchLinkBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fehlerhafte Verknüpfung:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(57, 78)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(300, 407)
        Me.ListBox1.TabIndex = 11
        '
        'AutorBuchLinkTableAdapter
        '
        Me.AutorBuchLinkTableAdapter.ClearBeforeFill = True
        '
        'BuchTableAdapter
        '
        Me.BuchTableAdapter.ClearBeforeFill = True
        '
        'AutorBuchLinkBindingNavigator
        '
        Me.AutorBuchLinkBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AutorBuchLinkBindingNavigator.BindingSource = Me.AutorBuchLinkBindingSource
        Me.AutorBuchLinkBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AutorBuchLinkBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AutorBuchLinkBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AutorBuchLinkBindingNavigatorSaveItem})
        Me.AutorBuchLinkBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AutorBuchLinkBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AutorBuchLinkBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AutorBuchLinkBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AutorBuchLinkBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AutorBuchLinkBindingNavigator.Name = "AutorBuchLinkBindingNavigator"
        Me.AutorBuchLinkBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AutorBuchLinkBindingNavigator.Size = New System.Drawing.Size(1233, 25)
        Me.AutorBuchLinkBindingNavigator.TabIndex = 19
        Me.AutorBuchLinkBindingNavigator.Text = "BindingNavigator1"
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
        'AutorBuchLinkBindingNavigatorSaveItem
        '
        Me.AutorBuchLinkBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AutorBuchLinkBindingNavigatorSaveItem.Image = CType(resources.GetObject("AutorBuchLinkBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AutorBuchLinkBindingNavigatorSaveItem.Name = "AutorBuchLinkBindingNavigatorSaveItem"
        Me.AutorBuchLinkBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AutorBuchLinkBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AutorBuchLinkTableAdapter = Me.AutorBuchLinkTableAdapter
        Me.TableAdapterManager1.AutorRolleTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BibliothekTableAdapter = Nothing
        Me.TableAdapterManager1.BindungTableAdapter = Nothing
        Me.TableAdapterManager1.BuchTableAdapter = Me.BuchTableAdapter
        Me.TableAdapterManager1.BuchTypTableAdapter = Nothing
        Me.TableAdapterManager1.DDCTableAdapter = Nothing
        Me.TableAdapterManager1.DruckereiTableAdapter = Nothing
        Me.TableAdapterManager1.EditionTableAdapter = Nothing
        Me.TableAdapterManager1.GenreLinkTableAdapter = Nothing
        Me.TableAdapterManager1.LandTableAdapter = Nothing
        Me.TableAdapterManager1.LanguageTableAdapter = Nothing
        Me.TableAdapterManager1.PersonTableAdapter = Nothing
        Me.TableAdapterManager1.SachgruppeTableAdapter = Nothing
        Me.TableAdapterManager1.SerienTableAdapter = Nothing
        Me.TableAdapterManager1.StandortTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.VerlagsOrtTableAdapter = Nothing
        Me.TableAdapterManager1.VerlagTableAdapter = Nothing
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
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
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'BuchIDDataGridViewTextBoxColumn
        '
        Me.BuchIDDataGridViewTextBoxColumn.DataPropertyName = "BuchID"
        Me.BuchIDDataGridViewTextBoxColumn.HeaderText = "BuchID"
        Me.BuchIDDataGridViewTextBoxColumn.Name = "BuchIDDataGridViewTextBoxColumn"
        '
        'PersonIDDataGridViewTextBoxColumn
        '
        Me.PersonIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID"
        Me.PersonIDDataGridViewTextBoxColumn.DataSource = Me.PersonBindingSource
        Me.PersonIDDataGridViewTextBoxColumn.DisplayMember = "SortBy"
        Me.PersonIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.PersonIDDataGridViewTextBoxColumn.HeaderText = "PersonID"
        Me.PersonIDDataGridViewTextBoxColumn.Name = "PersonIDDataGridViewTextBoxColumn"
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
        Me.RolleIDDataGridViewTextBoxColumn.HeaderText = "RolleID"
        Me.RolleIDDataGridViewTextBoxColumn.Name = "RolleIDDataGridViewTextBoxColumn"
        Me.RolleIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RolleIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.RolleIDDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'CheckBuchAutorLink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 586)
        Me.Controls.Add(Me.AutorBuchLinkBindingNavigator)
        Me.Controls.Add(Me.BtDel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtCancel)
        Me.Controls.Add(Me.BuchDataGridView)
        Me.Controls.Add(Me.AutorBuchLinkDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "CheckBuchAutorLink"
        Me.Text = "BookCMS - Prüfe Buch-Autor-Link"
        CType(Me.BuchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorBuchLinkDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorBuchLinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorBuchLinkBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AutorBuchLinkBindingNavigator.ResumeLayout(False)
        Me.AutorBuchLinkBindingNavigator.PerformLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorRolleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtDel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtCancel As Button
    Friend WithEvents BuchDataGridView As DataGridView
    Friend WithEvents AutorBuchLinkDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents AutorBuchLinkBindingSource As BindingSource
    Friend WithEvents AutorBuchLinkTableAdapter As _BookCMS_singleDataSetTableAdapters.AutorBuchLinkTableAdapter
    Friend WithEvents BuchBindingSource As BindingSource
    Friend WithEvents BuchTableAdapter As _BookCMS_singleDataSetTableAdapters.BuchTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TitelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AutorSortDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SignaturDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AutorBuchLinkBindingNavigator As BindingNavigator
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
    Friend WithEvents AutorBuchLinkBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TableAdapterManager1 As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PersonBindingSource As BindingSource
    Friend WithEvents PersonTableAdapter As _BookCMS_singleDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents AutorRolleBindingSource As BindingSource
    Friend WithEvents AutorRolleTableAdapter As _BookCMS_singleDataSetTableAdapters.AutorRolleTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuchIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonIDDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents RolleIDDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
End Class
