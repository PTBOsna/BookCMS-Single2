Imports System.Text.RegularExpressions
Public Class DNBConnect
    Dim webSite As String = "https://portal.dnb.de/opac.htm?method=simpleSearch&query="
    Dim htmlText As String = "" '-> ausgelesener Siteninhalt
    Dim sTitel As String = ""
    Dim sID As String = "" 'von OpenArgs übergebene BuchID (wird ggf. weitergegeben), 
    Dim oaID As String = "" 'Link  MARC21-Datensatz
    Dim web As New WebBrowser
    'Dim istText As Boolean = False
    Dim istListe As Boolean = False 'listBoxErgeb zeigt entweder Ergebnis als Liste oder Einzeldokument an. Bei Click-Ereignis erforderlich
    Dim sCurLink As String = "" 'Link aus Ergebnisliste zur Detailseite

    Sub New(openArgs As String)
        'TODO: Mauszeiger ändern
        Cursor.Current = Cursors.WaitCursor
        Dim s() As String
        InitializeComponent()
        If String.IsNullOrEmpty(openArgs) Then Exit Sub
        s = Split(openArgs, "#")
        ' txtISBN.Text = Regex.Replace(s(0), "-", "")
        sID = s(1) 'BuchID zur Weitergabe an BuchNeu
        txtSuche.Text = s(0) 'z.Z. unbelegt

    End Sub
    Private Sub DNBConnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BuchTableAdapter.Fill(Me._BookCMS_singleDataSet.Buch)

        'Allgemein: Der MARC21-Datensatz wird mit http://d-nb.info/<>/about/marcxml an weiterführende Seite übergeben
        txtBuch.Visible = False
        lblAuswahl.Visible = False
        listBoxErgeb.Visible = False
        btOK.Visible = False
        txtBuch.Text = "Kein Eintrag in der DNB gefunden!"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSuche.Click
        TitelSuche()
    End Sub
    Private Sub txtSuche_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSuche.KeyDown
        If e.KeyData = Keys.Enter Then
            TitelSuche()
        End If
    End Sub
    Private Sub TitelSuche()
        txtBuch.Visible = False
        listBoxErgeb.Visible = False
        btOK.Visible = False
        sTitel = txtSuche.Text
        'Eingabetext URL-tauglich machen. Dazu ist Verweis auf System.Web erforderlich!
        sTitel = System.Web.HttpUtility.UrlEncode(sTitel)
        listBoxErgeb.Items.Add(webSite & txtSuche.Text)
        openWebSite(webSite & sTitel)
    End Sub
    Private Sub openWebSite(ByVal webSite As String)
        Dim RecCount As Integer = 0
        listBoxErgeb.Items.Clear()
        'Testseiten
        ' webSite = "E:/peter/Documents/MehrfachSeite_04_17.html"
        'webSite = "E:\peter\Documents\EinzelSeite_04_17.html"
        'Ende Testseiten

        web.Navigate(webSite)
        While web.ReadyState <> WebBrowserReadyState.Complete
            Application.DoEvents()
        End While
        'Auswertung
        ' MsgBox("weiter")
        'Prüfen auf Einzelergebnis oder Liste
        'zuerst Liste
        'Ergebnisseite DNB enthält die Elemente "fullRecordTable" wenn nur ein Dokument gefunden wurde und
        '"searchresult" wenn Liste mit mehreren Titeln als Ergebnis.
        'zunächst Ergebnisliste
        If (web.Document.GetElementById("searchresult") IsNot Nothing) Then
            htmlText = web.Document.GetElementById("searchresult").InnerHtml
            'Im Tag <span class="amount">1 - 2 von 2</span> ist die Anzahl der Treffen zu finden. 
            'Im Tag <link das Attribut 'href' mit u.a. opac.atom enthält den Teilstring für den Detail-Link
            Dim Elems As HtmlElementCollection = web.Document.GetElementsByTagName("span")
            Dim Links As HtmlElementCollection = web.Document.GetElementsByTagName("link")
            'MsgBox("Anzahl Span: " & Elems.Count & " Anzal link: " & Links.Count)
            listBoxErgeb.Items.Clear()
            For Each elem As HtmlElement In Elems
                If elem.InnerText.Contains("von") Then
                    RecCount = CInt(Strings.Right(elem.InnerText, 1))
                    Exit For
                End If
            Next
            For Each slink As HtmlElement In Links
                sCurLink = slink.GetAttribute("href")
                If sCurLink.Contains("opac.atom") Then
                    sCurLink = Replace(sCurLink, "atom", "htm").Replace("search", "showFullRecord")
                    'MsgBox(sCurLink)
                    Exit For
                End If
            Next
            txtBuch.Visible = False
            listBoxErgeb.Items.Clear()
            listBoxErgeb.Visible = True
            lblAuswahl.Visible = True
            lblID.Text = "Ergebnisliste"
            For i = 0 To RecCount - 1
                listBoxErgeb.Items.Add(i & " - " & web.Document.GetElementById("recordLink_" & i.ToString).InnerHtml)
            Next
            istListe = True
        Else
            readDocument(webSite)
        End If

    End Sub
    Private Sub readDocument(ByVal sWeb As String)
        web.Navigate(sWeb)
        While web.ReadyState <> WebBrowserReadyState.Complete
            Application.DoEvents()
        End While

        Dim Links As HtmlElementCollection = web.Document.GetElementsByTagName("a")
        Dim Biblio As HtmlElementCollection = web.Document.GetElementsByTagName("tr")
        ' MsgBox(Links.Count)
        For Each slink As HtmlElement In Links
            sCurLink = slink.GetAttribute("href")
            If sCurLink.Contains("marcxml") Then
                'MsgBox(sCurLink)
                Exit For
            End If
        Next
        'Titel auslesen wenn Einzeldokument
        If istListe = False Then
            For Each el As HtmlElement In Biblio
                If el.InnerText.Contains("Titel") Then
                    'MsgBox(el.InnerText)
                    txtBuch.Text = Replace(el.InnerText, "Titel", "")
                    Exit For
                End If
            Next
        End If
        'wenn nichts gefunden, abbrechen
        If txtBuch.Text.Contains("Kein Eintrag") Then
            MsgBox("Kein Eintrag in der DNB gefunden")
            Exit Sub
        End If
        'MsgBox(htmlText)
        listBoxErgeb.Visible = False
        lblAuswahl.Visible = False
        txtBuch.Visible = True
        lblID.Text = " Einzeldokument"
        checkTitle(txtBuch.Text)
        istListe = False
        btOK.Visible = True

    End Sub
    Private Sub listBoxErgeb_Click(sender As Object, e As EventArgs) Handles listBoxErgeb.Click
        Dim dummy() As String
        If istListe Then
            txtBuch.Text = listBoxErgeb.Text
            dummy = Split(listBoxErgeb.Text, "-")
            'Link zur Detailseite (aus Original-Link zusammengesetzt)
            'Dim temp As String = "https://portal.dnb.de/opac.htm?method=showFullRecord&currentResultId=%22" & sTitel & "%22%26any&currentPosition=" & dummy(0)
            Dim temp As String = "https://portal.dnb.de" & sCurLink & "&currentPosition=" & dummy(0)
            'MsgBox(temp)
            readDocument(temp)
            checkTitle(txtBuch.Text)
        End If
    End Sub
    Private Sub checkTitle(ByVal sTitle As String)

        Dim iLen As Integer = 15
        'Dim orgTitle As String = sTitle
        Dim vorhanden As String = Nothing
        Dim BuchID As String = Nothing
        Dim tmpTitel() As String
        'ggf. vorgestellte Ziffen enfernen
        tmpTitel = Split(sTitle, "-")
        If tmpTitel.Count > 1 Then
            sTitle = UCase(tmpTitel(1))
        Else
            sTitle = UCase(tmpTitel(0))
        End If
        'Umlaute gegen Vokale austauschen
        sTitle = Regex.Replace(sTitle, "Ä", "A")
        sTitle = Regex.Replace(sTitle, "Ö", "O")
        sTitle = Regex.Replace(sTitle, "Ü", "U")
        delChar(sTitle)
        If sTitle.Length < 15 Then iLen = sTitle.Length
        sTitle = sTitle.Substring(0, iLen)
        '' MsgBox(sTitle.Length)
        ''BuchBindingSource.Filter = "TitelIndex like '%" & sTitle & "%'"

        sTitle = sTitle & "*"
        Dim buch = From p In _BookCMS_singleDataSet.Buch Where p.TitelIndex Like sTitle Select p
        If buch.Count > 0 Then
            listBoxErgeb.Items.Clear()
            BuchID = CStr(buch(0).ID)
            ' MsgBox(BuchID)
            'TODO: Erweitern um Feld "Bibliothek"
            BuchBindingSource.Filter = "ID=" & BuchID
            'Wenn  Eintrag vorhanden:
            If buch.Count > 0 Then
                lblAuswahl.Visible = True
                lblAuswahl.Text = "Folgende Titel sind bereits im Bestand:"
                listBoxErgeb.Visible = True
                For Each eintrag In buch
                    listBoxErgeb.Items.Add(eintrag.Signatur & " - " & eintrag.Titel)
                Next
            End If
            ' MsgBox(vorhanden)
        End If


    End Sub
    'Aus Text alle Steuerzeichen entfernen (für IndexTitel)
    Function delChar(ByRef sb As String) As String
        'alle Sonderzeichen entfernen
        For i As Integer = sb.Length - 1 To 0 Step -1
            If Not Char.IsLetterOrDigit(sb(i)) Then
                sb = sb.Remove(i, 1)
                ' MsgBox(i & "-" & sb(i) & "-" & sb)
            End If
        Next
        Return sb
    End Function
    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOK.Click
        Dim id As String = ""
        If Not istListe Then
            oaID = sCurLink '"http://d-nb.info/" & oaID & "/about/marcxml"
            ' MsgBox(oaID)
            'weiter mit Aufruf BuchNeu und übergabe von oaID
            id = oaID & "#" & sID
            Dim f As New BuchNeuDNB(id) 'BuchNeu(openArgs)
            f.Show()
            oaID = ""
            txtSuche.Text = ""
            txtBuch.Text = ""
            txtBuch.Visible = False
            btOK.Visible = False
        Else
            MsgBox("Fehler in der Ergebnisliste, bitte neu versuchen!")
        End If
    End Sub


End Class