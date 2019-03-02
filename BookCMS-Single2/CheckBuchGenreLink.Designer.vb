<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckBuchGenreLink
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckBuchGenreLink))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GenreLinkBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.GenreLinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
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
        Me.GenreLinkBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GenreLinkDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuchIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SachgruppeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtDel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtCancel = New System.Windows.Forms.Button()
        Me.BuchDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutorSortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SignaturDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SachgruppeIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GenreLinkTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.GenreLinkTableAdapter()
        Me.BuchTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.BuchTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        CType(Me.GenreLinkBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GenreLinkBindingNavigator.SuspendLayout()
        CType(Me.GenreLinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenreLinkDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GenreLinkBindingNavigator)
        Me.Panel1.Controls.Add(Me.GenreLinkDataGridView)
        Me.Panel1.Controls.Add(Me.BtDel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtCancel)
        Me.Panel1.Controls.Add(Me.BuchDataGridView)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1158, 591)
        Me.Panel1.TabIndex = 1
        '
        'GenreLinkBindingNavigator
        '
        Me.GenreLinkBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GenreLinkBindingNavigator.BindingSource = Me.GenreLinkBindingSource
        Me.GenreLinkBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GenreLinkBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GenreLinkBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GenreLinkBindingNavigatorSaveItem})
        Me.GenreLinkBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GenreLinkBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GenreLinkBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GenreLinkBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GenreLinkBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GenreLinkBindingNavigator.Name = "GenreLinkBindingNavigator"
        Me.GenreLinkBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GenreLinkBindingNavigator.Size = New System.Drawing.Size(1158, 25)
        Me.GenreLinkBindingNavigator.TabIndex = 19
        Me.GenreLinkBindingNavigator.Text = "BindingNavigator1"
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
        'GenreLinkBindingSource
        '
        Me.GenreLinkBindingSource.DataMember = "GenreLink"
        Me.GenreLinkBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        '_BookCMS_singleDataSet
        '
        Me._BookCMS_singleDataSet.DataSetName = "_BookCMS_singleDataSet"
        Me._BookCMS_singleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'GenreLinkBindingNavigatorSaveItem
        '
        Me.GenreLinkBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GenreLinkBindingNavigatorSaveItem.Image = CType(resources.GetObject("GenreLinkBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GenreLinkBindingNavigatorSaveItem.Name = "GenreLinkBindingNavigatorSaveItem"
        Me.GenreLinkBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GenreLinkBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'GenreLinkDataGridView
        '
        Me.GenreLinkDataGridView.AutoGenerateColumns = False
        Me.GenreLinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GenreLinkDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.BuchIDDataGridViewTextBoxColumn, Me.SachgruppeIDDataGridViewTextBoxColumn})
        Me.GenreLinkDataGridView.DataSource = Me.GenreLinkBindingSource
        Me.GenreLinkDataGridView.Location = New System.Drawing.Point(339, 81)
        Me.GenreLinkDataGridView.Name = "GenreLinkDataGridView"
        Me.GenreLinkDataGridView.Size = New System.Drawing.Size(300, 408)
        Me.GenreLinkDataGridView.TabIndex = 18
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
        'SachgruppeIDDataGridViewTextBoxColumn
        '
        Me.SachgruppeIDDataGridViewTextBoxColumn.DataPropertyName = "SachgruppeID"
        Me.SachgruppeIDDataGridViewTextBoxColumn.HeaderText = "SachgruppeID"
        Me.SachgruppeIDDataGridViewTextBoxColumn.Name = "SachgruppeIDDataGridViewTextBoxColumn"
        '
        'BtDel
        '
        Me.BtDel.ForeColor = System.Drawing.Color.DarkRed
        Me.BtDel.Location = New System.Drawing.Point(421, 500)
        Me.BtDel.Name = "BtDel"
        Me.BtDel.Size = New System.Drawing.Size(133, 23)
        Me.BtDel.TabIndex = 18
        Me.BtDel.Text = "Löschen"
        Me.BtDel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(678, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Buch-Liste"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(336, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Link-Liste"
        '
        'BtCancel
        '
        Me.BtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCancel.Location = New System.Drawing.Point(2, 500)
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
        Me.BuchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.TitelDataGridViewTextBoxColumn, Me.AutorSortDataGridViewTextBoxColumn, Me.SignaturDataGridViewTextBoxColumn, Me.TypIDDataGridViewTextBoxColumn, Me.SachgruppeIDDataGridViewTextBoxColumn1})
        Me.BuchDataGridView.DataSource = Me.BuchBindingSource
        Me.BuchDataGridView.Location = New System.Drawing.Point(690, 85)
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
        'TypIDDataGridViewTextBoxColumn
        '
        Me.TypIDDataGridViewTextBoxColumn.DataPropertyName = "TypID"
        Me.TypIDDataGridViewTextBoxColumn.HeaderText = "TypID"
        Me.TypIDDataGridViewTextBoxColumn.Name = "TypIDDataGridViewTextBoxColumn"
        '
        'SachgruppeIDDataGridViewTextBoxColumn1
        '
        Me.SachgruppeIDDataGridViewTextBoxColumn1.DataPropertyName = "SachgruppeID"
        Me.SachgruppeIDDataGridViewTextBoxColumn1.HeaderText = "SachgruppeID"
        Me.SachgruppeIDDataGridViewTextBoxColumn1.Name = "SachgruppeIDDataGridViewTextBoxColumn1"
        '
        'BuchBindingSource
        '
        Me.BuchBindingSource.DataMember = "Buch"
        Me.BuchBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fehlerhafte Verknüpfung:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(2, 82)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(300, 407)
        Me.ListBox1.TabIndex = 11
        '
        'GenreLinkTableAdapter
        '
        Me.GenreLinkTableAdapter.ClearBeforeFill = True
        '
        'BuchTableAdapter
        '
        Me.BuchTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutorBuchLinkTableAdapter = Nothing
        Me.TableAdapterManager.AutorRolleTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BibliothekTableAdapter = Nothing
        Me.TableAdapterManager.BindungTableAdapter = Nothing
        Me.TableAdapterManager.BuchTableAdapter = Me.BuchTableAdapter
        Me.TableAdapterManager.BuchTypTableAdapter = Nothing
        Me.TableAdapterManager.DDCTableAdapter = Nothing
        Me.TableAdapterManager.DruckereiTableAdapter = Nothing
        Me.TableAdapterManager.EditionTableAdapter = Nothing
        Me.TableAdapterManager.GenreLinkTableAdapter = Me.GenreLinkTableAdapter
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
        'CheckBuchGenreLink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 591)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CheckBuchGenreLink"
        Me.Text = "BookCMS - Prüfe Buch-Genre-Link"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GenreLinkBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GenreLinkBindingNavigator.ResumeLayout(False)
        Me.GenreLinkBindingNavigator.PerformLayout()
        CType(Me.GenreLinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenreLinkDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GenreLinkDataGridView As DataGridView
    Friend WithEvents BtDel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtCancel As Button
    Friend WithEvents BuchDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents GenreLinkBindingSource As BindingSource
    Friend WithEvents GenreLinkTableAdapter As _BookCMS_singleDataSetTableAdapters.GenreLinkTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuchIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SachgruppeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuchBindingSource As BindingSource
    Friend WithEvents BuchTableAdapter As _BookCMS_singleDataSetTableAdapters.BuchTableAdapter
    Friend WithEvents GenreLinkBindingNavigator As BindingNavigator
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
    Friend WithEvents GenreLinkBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TitelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AutorSortDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SignaturDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SachgruppeIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
End Class
