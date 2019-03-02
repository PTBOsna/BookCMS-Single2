<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setup
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
        Me.lblDataPath = New System.Windows.Forms.Label()
        Me.lblAppPath = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblDataPath
        '
        Me.lblDataPath.AutoSize = True
        Me.lblDataPath.Location = New System.Drawing.Point(38, 59)
        Me.lblDataPath.Name = "lblDataPath"
        Me.lblDataPath.Size = New System.Drawing.Size(57, 13)
        Me.lblDataPath.TabIndex = 0
        Me.lblDataPath.Text = "Datenpfad"
        '
        'lblAppPath
        '
        Me.lblAppPath.AutoSize = True
        Me.lblAppPath.Location = New System.Drawing.Point(38, 33)
        Me.lblAppPath.Name = "lblAppPath"
        Me.lblAppPath.Size = New System.Drawing.Size(75, 13)
        Me.lblAppPath.TabIndex = 1
        Me.lblAppPath.Text = "Programmpfad"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(74, 113)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(574, 134)
        Me.ListBox1.TabIndex = 2
        '
        'setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblAppPath)
        Me.Controls.Add(Me.lblDataPath)
        Me.Name = "setup"
        Me.Text = "setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDataPath As Label
    Friend WithEvents lblAppPath As Label
    Friend WithEvents ListBox1 As ListBox
End Class
