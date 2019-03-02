<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DNBConnect
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
        Me.lblAuswahl = New System.Windows.Forms.Label()
        Me.btOK = New System.Windows.Forms.Button()
        Me.txtBuch = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.listBoxErgeb = New System.Windows.Forms.ListBox()
        Me.btnSuche = New System.Windows.Forms.Button()
        Me.txtSuche = New System.Windows.Forms.TextBox()
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.BuchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuchTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.BuchTableAdapter()
        Me.TableAdapterManager = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.TableAdapterManager()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAuswahl
        '
        Me.lblAuswahl.AutoSize = True
        Me.lblAuswahl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuswahl.Location = New System.Drawing.Point(49, 128)
        Me.lblAuswahl.Name = "lblAuswahl"
        Me.lblAuswahl.Size = New System.Drawing.Size(97, 13)
        Me.lblAuswahl.TabIndex = 20
        Me.lblAuswahl.Text = "Bitte auswählen"
        '
        'btOK
        '
        Me.btOK.Location = New System.Drawing.Point(680, 98)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(75, 32)
        Me.btOK.TabIndex = 19
        Me.btOK.Text = "ok"
        Me.btOK.UseVisualStyleBackColor = True
        '
        'txtBuch
        '
        Me.txtBuch.Location = New System.Drawing.Point(49, 105)
        Me.txtBuch.Name = "txtBuch"
        Me.txtBuch.Size = New System.Drawing.Size(614, 20)
        Me.txtBuch.TabIndex = 18
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(46, 77)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(218, 16)
        Me.lblID.TabIndex = 17
        Me.lblID.Text = "Bitte Titel oder ISBN eingeben"
        '
        'listBoxErgeb
        '
        Me.listBoxErgeb.FormattingEnabled = True
        Me.listBoxErgeb.Location = New System.Drawing.Point(49, 148)
        Me.listBoxErgeb.Name = "listBoxErgeb"
        Me.listBoxErgeb.Size = New System.Drawing.Size(614, 69)
        Me.listBoxErgeb.TabIndex = 16
        '
        'btnSuche
        '
        Me.btnSuche.Location = New System.Drawing.Point(588, 41)
        Me.btnSuche.Name = "btnSuche"
        Me.btnSuche.Size = New System.Drawing.Size(75, 23)
        Me.btnSuche.TabIndex = 15
        Me.btnSuche.Text = "Suchen"
        Me.btnSuche.UseVisualStyleBackColor = True
        '
        'txtSuche
        '
        Me.txtSuche.AcceptsReturn = True
        Me.txtSuche.Location = New System.Drawing.Point(49, 44)
        Me.txtSuche.Name = "txtSuche"
        Me.txtSuche.Size = New System.Drawing.Size(533, 20)
        Me.txtSuche.TabIndex = 14
        '
        '_BookCMS_singleDataSet
        '
        Me._BookCMS_singleDataSet.DataSetName = "_BookCMS_singleDataSet"
        Me._BookCMS_singleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuchBindingSource
        '
        Me.BuchBindingSource.DataMember = "Buch"
        Me.BuchBindingSource.DataSource = Me._BookCMS_singleDataSet
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
        'DNBConnect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 258)
        Me.Controls.Add(Me.lblAuswahl)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.txtBuch)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.listBoxErgeb)
        Me.Controls.Add(Me.btnSuche)
        Me.Controls.Add(Me.txtSuche)
        Me.Name = "DNBConnect"
        Me.Text = "Form2"
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAuswahl As Label
    Friend WithEvents btOK As Button
    Friend WithEvents txtBuch As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents listBoxErgeb As ListBox
    Friend WithEvents btnSuche As Button
    Friend WithEvents txtSuche As TextBox
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents BuchBindingSource As BindingSource
    Friend WithEvents BuchTableAdapter As _BookCMS_singleDataSetTableAdapters.BuchTableAdapter
    Friend WithEvents TableAdapterManager As _BookCMS_singleDataSetTableAdapters.TableAdapterManager
End Class
