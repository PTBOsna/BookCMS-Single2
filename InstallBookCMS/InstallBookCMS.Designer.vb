<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstallBookCMS
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BtInst = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtCoverPath = New System.Windows.Forms.Button()
        Me.txtCoverPath = New System.Windows.Forms.TextBox()
        Me.LblAktDB = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblAktPfad = New System.Windows.Forms.Label()
        Me.BtChangeDataPaht = New System.Windows.Forms.Button()
        Me.BrChangeAppPath = New System.Windows.Forms.Button()
        Me.txtAppPath = New System.Windows.Forms.TextBox()
        Me.txtDBPath = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtInst
        '
        Me.BtInst.Location = New System.Drawing.Point(248, 446)
        Me.BtInst.Name = "BtInst"
        Me.BtInst.Size = New System.Drawing.Size(146, 43)
        Me.BtInst.TabIndex = 9
        Me.BtInst.Text = "Installieren/Verschieben"
        Me.BtInst.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BtCoverPath)
        Me.Panel1.Controls.Add(Me.txtCoverPath)
        Me.Panel1.Controls.Add(Me.LblAktDB)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LblAktPfad)
        Me.Panel1.Controls.Add(Me.BtChangeDataPaht)
        Me.Panel1.Controls.Add(Me.BrChangeAppPath)
        Me.Panel1.Controls.Add(Me.txtAppPath)
        Me.Panel1.Controls.Add(Me.txtDBPath)
        Me.Panel1.Location = New System.Drawing.Point(35, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(581, 432)
        Me.Panel1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Speicherort für Cover-Bilder"
        '
        'BtCoverPath
        '
        Me.BtCoverPath.Location = New System.Drawing.Point(486, 211)
        Me.BtCoverPath.Name = "BtCoverPath"
        Me.BtCoverPath.Size = New System.Drawing.Size(75, 23)
        Me.BtCoverPath.TabIndex = 11
        Me.BtCoverPath.Text = "Ändern"
        Me.BtCoverPath.UseVisualStyleBackColor = True
        '
        'txtCoverPath
        '
        Me.txtCoverPath.Location = New System.Drawing.Point(14, 211)
        Me.txtCoverPath.Name = "txtCoverPath"
        Me.txtCoverPath.Size = New System.Drawing.Size(436, 20)
        Me.txtCoverPath.TabIndex = 9
        '
        'LblAktDB
        '
        Me.LblAktDB.AutoSize = True
        Me.LblAktDB.Location = New System.Drawing.Point(14, 36)
        Me.LblAktDB.Name = "LblAktDB"
        Me.LblAktDB.Size = New System.Drawing.Size(39, 13)
        Me.LblAktDB.TabIndex = 8
        Me.LblAktDB.Text = "Label5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Speicherort BookCMS-Single 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Speicherort Datenbank"
        '
        'LblAktPfad
        '
        Me.LblAktPfad.AutoSize = True
        Me.LblAktPfad.Location = New System.Drawing.Point(14, 11)
        Me.LblAktPfad.Name = "LblAktPfad"
        Me.LblAktPfad.Size = New System.Drawing.Size(76, 13)
        Me.LblAktPfad.TabIndex = 7
        Me.LblAktPfad.Text = "Aktueller Pfad:"
        '
        'BtChangeDataPaht
        '
        Me.BtChangeDataPaht.Location = New System.Drawing.Point(486, 158)
        Me.BtChangeDataPaht.Name = "BtChangeDataPaht"
        Me.BtChangeDataPaht.Size = New System.Drawing.Size(75, 23)
        Me.BtChangeDataPaht.TabIndex = 5
        Me.BtChangeDataPaht.Text = "Ändern"
        Me.BtChangeDataPaht.UseVisualStyleBackColor = True
        '
        'BrChangeAppPath
        '
        Me.BrChangeAppPath.Location = New System.Drawing.Point(486, 114)
        Me.BrChangeAppPath.Name = "BrChangeAppPath"
        Me.BrChangeAppPath.Size = New System.Drawing.Size(75, 23)
        Me.BrChangeAppPath.TabIndex = 6
        Me.BrChangeAppPath.Text = "Ändern"
        Me.BrChangeAppPath.UseVisualStyleBackColor = True
        '
        'txtAppPath
        '
        Me.txtAppPath.Location = New System.Drawing.Point(14, 114)
        Me.txtAppPath.Name = "txtAppPath"
        Me.txtAppPath.Size = New System.Drawing.Size(436, 20)
        Me.txtAppPath.TabIndex = 3
        '
        'txtDBPath
        '
        Me.txtDBPath.Location = New System.Drawing.Point(14, 161)
        Me.txtDBPath.Name = "txtDBPath"
        Me.txtDBPath.Size = New System.Drawing.Size(436, 20)
        Me.txtDBPath.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(14, 264)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(551, 108)
        Me.ListBox1.TabIndex = 12
        '
        'InstallBookCMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 501)
        Me.Controls.Add(Me.BtInst)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "InstallBookCMS"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BtInst As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents BtCoverPath As Button
    Friend WithEvents txtCoverPath As TextBox
    Friend WithEvents LblAktDB As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblAktPfad As Label
    Friend WithEvents BtChangeDataPaht As Button
    Friend WithEvents BrChangeAppPath As Button
    Friend WithEvents txtAppPath As TextBox
    Friend WithEvents txtDBPath As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
