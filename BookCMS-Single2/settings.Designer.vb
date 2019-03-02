<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTSave = New System.Windows.Forms.Button()
        Me.BtCancel = New System.Windows.Forms.Button()
        Me.CbStartRolle = New System.Windows.Forms.ComboBox()
        Me.AutorRolleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BookCMS_singleDataSet = New BookCMS_Single2._BookCMS_singleDataSet()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TxtWebDNB = New System.Windows.Forms.TextBox()
        Me.TxtCover = New System.Windows.Forms.TextBox()
        Me.TxtApplicationPath = New System.Windows.Forms.TextBox()
        Me.BtDaten = New System.Windows.Forms.Button()
        Me.BtCoverDialog = New System.Windows.Forms.Button()
        Me.lblDNB = New System.Windows.Forms.Label()
        Me.lblRolle = New System.Windows.Forms.Label()
        Me.lblCover = New System.Windows.Forms.Label()
        Me.lblPfadDB = New System.Windows.Forms.Label()
        Me.AutorRolleTableAdapter = New BookCMS_Single2._BookCMS_singleDataSetTableAdapters.AutorRolleTableAdapter()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.LblCurrDB = New System.Windows.Forms.Label()
        CType(Me.AutorRolleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Änderungen werden erst ab Neustart wirksam!"
        '
        'BTSave
        '
        Me.BTSave.Location = New System.Drawing.Point(366, 338)
        Me.BTSave.Name = "BTSave"
        Me.BTSave.Size = New System.Drawing.Size(95, 39)
        Me.BTSave.TabIndex = 39
        Me.BTSave.Text = "Speichern und schließen"
        Me.BTSave.UseVisualStyleBackColor = True
        '
        'BtCancel
        '
        Me.BtCancel.Location = New System.Drawing.Point(24, 338)
        Me.BtCancel.Name = "BtCancel"
        Me.BtCancel.Size = New System.Drawing.Size(95, 39)
        Me.BtCancel.TabIndex = 38
        Me.BtCancel.Text = "Abbruch"
        Me.BtCancel.UseVisualStyleBackColor = True
        '
        'CbStartRolle
        '
        Me.CbStartRolle.DataSource = Me.AutorRolleBindingSource
        Me.CbStartRolle.DisplayMember = "AutorRolle"
        Me.CbStartRolle.FormattingEnabled = True
        Me.CbStartRolle.Location = New System.Drawing.Point(168, 235)
        Me.CbStartRolle.Name = "CbStartRolle"
        Me.CbStartRolle.Size = New System.Drawing.Size(231, 21)
        Me.CbStartRolle.TabIndex = 37
        Me.CbStartRolle.ValueMember = "ID"
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(416, 293)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 23)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Test"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TxtWebDNB
        '
        Me.TxtWebDNB.Location = New System.Drawing.Point(24, 296)
        Me.TxtWebDNB.Name = "TxtWebDNB"
        Me.TxtWebDNB.Size = New System.Drawing.Size(375, 20)
        Me.TxtWebDNB.TabIndex = 35
        '
        'TxtCover
        '
        Me.TxtCover.Location = New System.Drawing.Point(24, 177)
        Me.TxtCover.Multiline = True
        Me.TxtCover.Name = "TxtCover"
        Me.TxtCover.Size = New System.Drawing.Size(375, 39)
        Me.TxtCover.TabIndex = 34
        '
        'TxtApplicationPath
        '
        Me.TxtApplicationPath.Location = New System.Drawing.Point(24, 84)
        Me.TxtApplicationPath.Multiline = True
        Me.TxtApplicationPath.Name = "TxtApplicationPath"
        Me.TxtApplicationPath.Size = New System.Drawing.Size(375, 48)
        Me.TxtApplicationPath.TabIndex = 33
        '
        'BtDaten
        '
        Me.BtDaten.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtDaten.Location = New System.Drawing.Point(416, 84)
        Me.BtDaten.Name = "BtDaten"
        Me.BtDaten.Size = New System.Drawing.Size(42, 23)
        Me.BtDaten.TabIndex = 31
        Me.BtDaten.Text = "..."
        Me.BtDaten.UseVisualStyleBackColor = True
        '
        'BtCoverDialog
        '
        Me.BtCoverDialog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCoverDialog.Location = New System.Drawing.Point(416, 177)
        Me.BtCoverDialog.Name = "BtCoverDialog"
        Me.BtCoverDialog.Size = New System.Drawing.Size(42, 23)
        Me.BtCoverDialog.TabIndex = 32
        Me.BtCoverDialog.Text = "..."
        Me.BtCoverDialog.UseVisualStyleBackColor = True
        '
        'lblDNB
        '
        Me.lblDNB.AutoSize = True
        Me.lblDNB.Location = New System.Drawing.Point(24, 280)
        Me.lblDNB.Name = "lblDNB"
        Me.lblDNB.Size = New System.Drawing.Size(216, 13)
        Me.lblDNB.TabIndex = 30
        Me.lblDNB.Text = "Internetadresse Deutsche Nationalbibliothek"
        '
        'lblRolle
        '
        Me.lblRolle.AutoSize = True
        Me.lblRolle.Location = New System.Drawing.Point(24, 238)
        Me.lblRolle.Name = "lblRolle"
        Me.lblRolle.Size = New System.Drawing.Size(138, 13)
        Me.lblRolle.TabIndex = 29
        Me.lblRolle.Text = "Voreinstellung Person/Rolle"
        '
        'lblCover
        '
        Me.lblCover.AutoSize = True
        Me.lblCover.Location = New System.Drawing.Point(24, 161)
        Me.lblCover.Name = "lblCover"
        Me.lblCover.Size = New System.Drawing.Size(92, 13)
        Me.lblCover.TabIndex = 28
        Me.lblCover.Text = "Speicherort Cover"
        '
        'lblPfadDB
        '
        Me.lblPfadDB.AutoSize = True
        Me.lblPfadDB.Location = New System.Drawing.Point(23, 68)
        Me.lblPfadDB.Name = "lblPfadDB"
        Me.lblPfadDB.Size = New System.Drawing.Size(93, 13)
        Me.lblPfadDB.TabIndex = 27
        Me.lblPfadDB.Text = "Speicherort Daten"
        '
        'AutorRolleTableAdapter
        '
        Me.AutorRolleTableAdapter.ClearBeforeFill = True
        '
        'LblCurrDB
        '
        Me.LblCurrDB.AutoSize = True
        Me.LblCurrDB.Location = New System.Drawing.Point(30, 23)
        Me.LblCurrDB.Name = "LblCurrDB"
        Me.LblCurrDB.Size = New System.Drawing.Size(39, 13)
        Me.LblCurrDB.TabIndex = 41
        Me.LblCurrDB.Text = "Label2"
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 422)
        Me.Controls.Add(Me.LblCurrDB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTSave)
        Me.Controls.Add(Me.BtCancel)
        Me.Controls.Add(Me.CbStartRolle)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TxtWebDNB)
        Me.Controls.Add(Me.TxtCover)
        Me.Controls.Add(Me.TxtApplicationPath)
        Me.Controls.Add(Me.BtDaten)
        Me.Controls.Add(Me.BtCoverDialog)
        Me.Controls.Add(Me.lblDNB)
        Me.Controls.Add(Me.lblRolle)
        Me.Controls.Add(Me.lblCover)
        Me.Controls.Add(Me.lblPfadDB)
        Me.Name = "settings"
        Me.Text = "settings"
        CType(Me.AutorRolleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BookCMS_singleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTSave As Button
    Friend WithEvents BtCancel As Button
    Friend WithEvents CbStartRolle As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TxtWebDNB As TextBox
    Friend WithEvents TxtCover As TextBox
    Friend WithEvents TxtApplicationPath As TextBox
    Friend WithEvents BtDaten As Button
    Friend WithEvents BtCoverDialog As Button
    Friend WithEvents lblDNB As Label
    Friend WithEvents lblRolle As Label
    Friend WithEvents lblCover As Label
    Friend WithEvents lblPfadDB As Label
    Friend WithEvents _BookCMS_singleDataSet As _BookCMS_singleDataSet
    Friend WithEvents AutorRolleBindingSource As BindingSource
    Friend WithEvents AutorRolleTableAdapter As _BookCMS_singleDataSetTableAdapters.AutorRolleTableAdapter
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents LblCurrDB As Label
End Class
