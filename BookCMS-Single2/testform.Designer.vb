<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class testform
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.PersonBuchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonBuchTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.PersonBuchTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        Me.PersonBuchDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBuchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBuchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_BookCMS_singleDataSet
        '
        Me._BookCMS_singleDataSet.DataSetName = "_BookCMS_singleDataSet"
        Me._BookCMS_singleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonBuchBindingSource
        '
        Me.PersonBuchBindingSource.DataMember = "PersonBuch"
        Me.PersonBuchBindingSource.DataSource = Me._BookCMS_singleDataSet
        '
        'PersonBuchTableAdapter
        '
        Me.PersonBuchTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Connection = Nothing
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
        'PersonBuchDataGridView
        '
        Me.PersonBuchDataGridView.AutoGenerateColumns = False
        Me.PersonBuchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonBuchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.PersonBuchDataGridView.DataSource = Me.PersonBuchBindingSource
        Me.PersonBuchDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.PersonBuchDataGridView.Name = "PersonBuchDataGridView"
        Me.PersonBuchDataGridView.Size = New System.Drawing.Size(908, 588)
        Me.PersonBuchDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Titel"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Titel"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PersonID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PersonID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "AutorRolle"
        Me.DataGridViewTextBoxColumn4.HeaderText = "AutorRolle"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SortBy"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SortBy"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RolleID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "RolleID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "BuchID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "BuchID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Signatur"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Signatur"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Veroeffentlicht"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Veroeffentlicht"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ISBN"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ISBN"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Untertitel"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Untertitel"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Bibliothek"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Bibliothek"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'testform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 655)
        Me.Controls.Add(Me.PersonBuchDataGridView)
        Me.Name = "testform"
        Me.Text = "testform"
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBuchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBuchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents PersonBuchBindingSource As BindingSource
    Friend WithEvents PersonBuchTableAdapter As _BookCMS_singleDataSetTableAdapters.PersonBuchTableAdapter
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PersonBuchDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
End Class
