Public Class Player
    Private WithEvents btnFoul As New Button

    Private WithEvents btn_2p As New Button
    Private WithEvents btn_3p As New Button
    Private WithEvents btn_1p As New Button

    Private WithEvents btnRebD As New Button
    Private WithEvents btnRebO As New Button

    Private WithEvents btn_ast As New Button
    Private WithEvents btn_stl As New Button
    Private WithEvents btn_blk As New Button
    Private WithEvents btn_TO As New Button

    Dim txtBox_playerName As New TextBox
    Dim txtBox_playerNumber As New TextBox
    Dim divLbl As New Label
    Dim equalLbl As New Label
    Dim foulBox As New TextBox

    Dim Mbox2p As New TextBox
    Dim Abox2p As New TextBox
    Dim pctBox2p As New TextBox

    Dim Mbox3p As New TextBox
    Dim Abox3p As New TextBox
    Dim pctBox3p As New TextBox

    Dim Mbox1p As New TextBox
    Dim Abox1p As New TextBox
    Dim pctBox1p As New TextBox

    Dim DRebBox As New TextBox
    Dim ORebBox As New TextBox
    Dim totReb As New TextBox

    Dim astBox As New TextBox
    Dim stlBox As New TextBox
    Dim blkBox As New TextBox
    Dim TOBox As New TextBox

    Dim ptsBox As New TextBox


    Public Shared counter As Integer = 0
    Public Shared row As Integer = 50
    Dim playerID As String



    Sub New()
        counter += 1
        row += 20
        playerID = "Player " + counter.ToString
        playerInit()
    End Sub



    Private Sub playerInit()
        
        'pelaajan nimi-kenttä
        txtBox_playerName = New System.Windows.Forms.TextBox()
        txtBox_playerName.Location = New System.Drawing.Point(30, row)
        txtBox_playerName.Name = "txtBox_playerName" + playerID.ToString()
        txtBox_playerName.Size = New System.Drawing.Size(133, 20)
        txtBox_playerName.Text = playerID.ToString
        Form1.Controls.Add(txtBox_playerName)

        'pelaajan numero
        txtBox_playerNumber = New System.Windows.Forms.TextBox()
        txtBox_playerNumber.Location = New System.Drawing.Point(170, row)
        txtBox_playerNumber.Name = "txtBox_playerNumber" + playerID.ToString()
        txtBox_playerNumber.Size = New System.Drawing.Size(20, 20)
        txtBox_playerNumber.Text = " "
        Form1.Controls.Add(txtBox_playerNumber)
        'jakomerkit
        divLbl = New System.Windows.Forms.Label
        divLbl.Text = "/"
        divLbl.Size = New System.Drawing.Size(12, 12)
        divLbl.Location = New System.Drawing.Point(633, row)

        'tehdään napit
        'virhenappi
        AddHandler btnFoul.Click, AddressOf Me.btnFoul_Click
        btnFoul = New System.Windows.Forms.Button()
        btnFoul.Location = New System.Drawing.Point(200, row)
        btnFoul.Name = "btnFoul" + playerID.ToString()
        btnFoul.Size = New System.Drawing.Size(40, 20)
        btnFoul.Text = "Virhe"
        Form1.Controls.Add(btnFoul)

        '2p-nappi
        AddHandler btn_2p.Click, AddressOf Me.btn2p_Click
        btn_2p = New System.Windows.Forms.Button()
        btn_2p.Location = New System.Drawing.Point(250, row)
        btn_2p.Name = "btn2p" + playerID.ToString()
        btn_2p.Size = New System.Drawing.Size(30, 20)
        btn_2p.Text = "2p"
        Form1.Controls.Add(btn_2p)

        '3p-nappi
        AddHandler btn_3p.Click, AddressOf Me.btn3p_Click
        btn_3p = New System.Windows.Forms.Button()
        btn_3p.Location = New System.Drawing.Point(285, row)
        btn_3p.Name = "btn3p" + playerID.ToString()
        btn_3p.Size = New System.Drawing.Size(30, 20)
        btn_3p.Text = "3p"
        Form1.Controls.Add(btn_3p)

        '1p-nappi
        AddHandler btn_1p.Click, AddressOf Me.btn1p_Click
        btn_1p = New System.Windows.Forms.Button()
        btn_1p.Location = New System.Drawing.Point(320, row)
        btn_1p.Name = "btn1p" + playerID.ToString()
        btn_1p.Size = New System.Drawing.Size(30, 20)
        btn_1p.Text = "1p"
        Form1.Controls.Add(btn_1p)

        'puolustuslevy
        AddHandler btnRebD.Click, AddressOf Me.btnRebD_Click
        btnRebD = New System.Windows.Forms.Button()
        btnRebD.Location = New System.Drawing.Point(360, row)
        btnRebD.Name = "btnRebD" + playerID.ToString()
        btnRebD.Size = New System.Drawing.Size(30, 20)
        btnRebD.Text = "D"
        Form1.Controls.Add(btnRebD)
        'hyökkäyslevy
        AddHandler btnRebO.Click, AddressOf Me.btnRebO_Click
        btnRebO = New System.Windows.Forms.Button()
        btnRebO.Location = New System.Drawing.Point(395, row)
        btnRebO.Name = "btnRebO" + playerID.ToString()
        btnRebO.Size = New System.Drawing.Size(30, 20)
        btnRebO.Text = "O"
        Form1.Controls.Add(btnRebO)

        'syöttö
        AddHandler btn_ast.Click, AddressOf Me.btn_ast_Click
        btn_ast = New System.Windows.Forms.Button()
        btn_ast.Location = New System.Drawing.Point(435, row)
        btn_ast.Name = "btn_ast" + playerID.ToString()
        btn_ast.Size = New System.Drawing.Size(30, 20)
        btn_ast.Text = "Ast"
        Form1.Controls.Add(btn_ast)
        'riisto
        AddHandler btn_stl.Click, AddressOf Me.btn_stl_Click
        btn_stl = New System.Windows.Forms.Button()
        btn_stl.Location = New System.Drawing.Point(470, row)
        btn_stl.Name = "btn_stl" + playerID.ToString()
        btn_stl.Size = New System.Drawing.Size(30, 20)
        btn_stl.Text = "Stl"
        Form1.Controls.Add(btn_stl)
        'blokki
        AddHandler btn_blk.Click, AddressOf Me.btn_blk_Click
        btn_blk = New System.Windows.Forms.Button()
        btn_blk.Location = New System.Drawing.Point(505, row)
        btn_blk.Name = "btn_blk" + playerID.ToString()
        btn_blk.Size = New System.Drawing.Size(30, 20)
        btn_blk.Text = "Blk"
        Form1.Controls.Add(btn_blk)
        'menetys
        AddHandler btn_TO.Click, AddressOf Me.btn_TO_Click
        btn_TO = New System.Windows.Forms.Button()
        btn_TO.Location = New System.Drawing.Point(540, row)
        btn_TO.Name = "btn_TO" + playerID.ToString()
        btn_TO.Size = New System.Drawing.Size(30, 20)
        btn_TO.Text = "TO"
        Form1.Controls.Add(btn_TO)

        'tehdään lootat
        'virhe
        foulBox = New System.Windows.Forms.TextBox()
        foulBox.Location = New System.Drawing.Point(581, row)
        foulBox.Name = "foulBox" + playerID.ToString()
        foulBox.Size = New System.Drawing.Size(20, 20)
        foulBox.Text = "0"
        foulBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Form1.Controls.Add(foulBox)

        '2p
        Mbox2p = New System.Windows.Forms.TextBox
        Mbox2p.Location = New System.Drawing.Point(610, row)
        Mbox2p.Name = "Mbox2p" + playerID.ToString
        Mbox2p.Size = New System.Drawing.Size(20, 20)
        Mbox2p.Text = "0"
        Mbox2p.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(Mbox2p)

        Abox2p = New System.Windows.Forms.TextBox
        Abox2p.Location = New System.Drawing.Point(645, row)
        Abox2p.Name = "Abox2p" + playerID.ToString
        Abox2p.Size = New System.Drawing.Size(20, 20)
        Abox2p.Text = "0"
        Abox2p.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(Abox2p)

        pctBox2p = New System.Windows.Forms.TextBox
        pctBox2p.Location = New System.Drawing.Point(680, row)
        pctBox2p.Name = "pctbox2p" + playerID.ToString
        pctBox2p.Size = New System.Drawing.Size(20, 20)
        pctBox2p.Text = "0"
        pctBox2p.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(pctBox2p)

        '3p
        Mbox3p = New System.Windows.Forms.TextBox
        Mbox3p.Location = New System.Drawing.Point(710, row)
        Mbox3p.Name = "Mbox3p" + playerID.ToString
        Mbox3p.Size = New System.Drawing.Size(20, 20)
        Mbox3p.Text = "0"
        Mbox3p.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(Mbox3p)

        Abox3p = New System.Windows.Forms.TextBox
        Abox3p.Location = New System.Drawing.Point(745, row)
        Abox3p.Name = "Abox3p" + playerID.ToString
        Abox3p.Size = New System.Drawing.Size(20, 20)
        Abox3p.Text = "0"
        Abox3p.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(Abox3p)

        pctBox3p = New System.Windows.Forms.TextBox
        pctBox3p.Location = New System.Drawing.Point(785, row)
        pctBox3p.Name = "pctbox3p" + playerID.ToString
        pctBox3p.Size = New System.Drawing.Size(20, 20)
        pctBox3p.Text = "0"
        pctBox3p.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(pctBox3p)

        '1p
        Mbox1p = New System.Windows.Forms.TextBox
        Mbox1p.Location = New System.Drawing.Point(815, row)
        Mbox1p.Name = "Mbox1p" + playerID.ToString
        Mbox1p.Size = New System.Drawing.Size(20, 20)
        Mbox1p.Text = "0"
        Mbox1p.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(Mbox1p)

        Abox1p = New System.Windows.Forms.TextBox
        Abox1p.Location = New System.Drawing.Point(850, row)
        Abox1p.Name = "Abox1p" + playerID.ToString
        Abox1p.Size = New System.Drawing.Size(20, 20)
        Abox1p.Text = "0"
        Abox1p.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(Abox1p)

        pctBox1p = New System.Windows.Forms.TextBox
        pctBox1p.Location = New System.Drawing.Point(885, row)
        pctBox1p.Name = "pctbox1p" + playerID.ToString
        pctBox1p.Size = New System.Drawing.Size(20, 20)
        pctBox1p.Text = "0"
        pctBox1p.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(pctBox1p)

        'puolustuslevyt
        DRebBox = New System.Windows.Forms.TextBox
        DRebBox.Location = New System.Drawing.Point(915, row)
        DRebBox.Name = "DRebBox" + playerID.ToString
        DRebBox.Size = New System.Drawing.Size(20, 20)
        DRebBox.Text = "0"
        DRebBox.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(DRebBox)
        'hyökkäyslevyt
        ORebBox = New System.Windows.Forms.TextBox
        ORebBox.Location = New System.Drawing.Point(940, row)
        ORebBox.Name = "ORebBox" + playerID.ToString
        ORebBox.Size = New System.Drawing.Size(20, 20)
        ORebBox.Text = "0"
        ORebBox.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(ORebBox)
        'levyt yhteensä
        'totReb = New System.Windows.Forms.TextBox
        'totReb.Location = New System.Drawing.Point(915, row)
        'totReb.Name = "totReb" + playerID.ToString
        'totReb.Size = New System.Drawing.Size(20, 20)
        'totReb.Text = "0"
        'totReb.TextAlign = HorizontalAlignment.Center
        'Form1.Controls.Add(totReb)
        'syötöt
        astBox = New System.Windows.Forms.TextBox
        astBox.Location = New System.Drawing.Point(967, row)
        astBox.Name = "astBox" + playerID.ToString
        astBox.Size = New System.Drawing.Size(20, 20)
        astBox.Text = "0"
        astBox.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(astBox)
        'riistot
        stlBox = New System.Windows.Forms.TextBox
        stlBox.Location = New System.Drawing.Point(992, row)
        stlBox.Name = "stlBox" + playerID.ToString
        stlBox.Size = New System.Drawing.Size(20, 20)
        stlBox.Text = "0"
        stlBox.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(stlBox)
        'torjunnat
        blkBox = New System.Windows.Forms.TextBox
        blkBox.Location = New System.Drawing.Point(1020, row)
        blkBox.Name = "blkBox" + playerID.ToString
        blkBox.Size = New System.Drawing.Size(20, 20)
        blkBox.Text = "0"
        blkBox.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(blkBox)
        'menetykset
        TOBox = New System.Windows.Forms.TextBox
        TOBox.Location = New System.Drawing.Point(1045, row)
        TOBox.Name = "TOBox" + playerID.ToString
        TOBox.Size = New System.Drawing.Size(20, 20)
        TOBox.Text = "0"
        TOBox.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(TOBox)

        'pisteet
        ptsBox = New System.Windows.Forms.TextBox
        ptsBox.Location = New System.Drawing.Point(1075, row)
        ptsBox.Name = "ptsBox" + playerID.ToString
        ptsBox.Size = New System.Drawing.Size(20, 20)
        ptsBox.Text = "0"
        ptsBox.TextAlign = HorizontalAlignment.Center
        Form1.Controls.Add(ptsBox)

    End Sub

    Private Sub btnFoul_Click(sender As System.Object, e As System.EventArgs) Handles btnFoul.Click
        Dim i As String
        Dim value As Integer
        i = "foulBox" + playerID.ToString
        value = CInt(Form1.Controls.Item(i).Text)

        value += 1
        Form1.Controls.Item(i).Text = value.ToString
    End Sub

    Private Sub btn2p_Click(sender As System.Object, e As System.EventArgs) Handles btn_2p.Click
        Dim i, j As String
        Dim valueA, valueM, pts As Integer

        'luetaan pelaajan pisteet
        j = "ptsBox" + playerID.ToString
        pts = CInt(Form1.Controls.Item(j).Text)

        'lisätään heittoyritys
        i = "Abox2p" + playerID.ToString
        valueA = CInt(Form1.Controls.Item(i).Text)
        valueA += 1
        Form1.Controls.Item(i).Text = valueA.ToString
        'luetaan onnistuneiden heittojen määrä
        i = "Mbox2p" + playerID.ToString
        valueM = CInt(Form1.Controls.Item(i).Text)
        'kysytään menikö heitto sisään
        If MessageBox.Show("Menikö heitto sisään?", "2-pisteen heitto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            valueM += 1
            Form1.Controls.Item(i).Text = valueM.ToString
            Form1.Controls.Item(j).Text = (pts + 2).ToString
        End If
        i = "pctBox2p" + playerID.ToString
        Form1.Controls.Item(i).Text = CInt(valueM / valueA * 100).ToString

        
    End Sub

    Private Sub btn3p_Click(sender As Object, e As EventArgs) Handles btn_3p.Click
        Dim i, j As String
        Dim valueA, valueM, pts As Integer

        'luetaan pelaajan pisteet
        j = "ptsBox" + playerID.ToString
        pts = CInt(Form1.Controls.Item(j).Text)

        'lisätään heittoyritys
        i = "Abox3p" + playerID.ToString
        valueA = CInt(Form1.Controls.Item(i).Text)
        valueA += 1
        Form1.Controls.Item(i).Text = valueA.ToString
        'luetaan onnistuneiden heittojen määrä
        i = "Mbox3p" + playerID.ToString
        valueM = CInt(Form1.Controls.Item(i).Text)
        'kysytään menikö heitto sisään
        If MessageBox.Show("Menikö heitto sisään?", "3-pisteen heitto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            valueM += 1
            Form1.Controls.Item(i).Text = valueM.ToString
            Form1.Controls.Item(j).Text = (pts + 3).ToString
        End If
        i = "pctBox3p" + playerID.ToString
        Form1.Controls.Item(i).Text = CInt(valueM / valueA * 100).ToString

    End Sub

    Private Sub btn1p_Click(sender As Object, e As EventArgs) Handles btn_1p.Click
        Dim i, j As String
        Dim valueA, valueM, pts As Integer

        'luetaan pelaajan pisteet
        j = "ptsBox" + playerID.ToString
        pts = CInt(Form1.Controls.Item(j).Text)

        'lisätään heittoyritys
        i = "Abox1p" + playerID.ToString
        valueA = CInt(Form1.Controls.Item(i).Text)
        valueA += 1
        Form1.Controls.Item(i).Text = valueA.ToString
        'luetaan onnistuneiden heittojen määrä
        i = "Mbox1p" + playerID.ToString
        valueM = CInt(Form1.Controls.Item(i).Text)
        'kysytään menikö heitto sisään
        If MessageBox.Show("Menikö heitto sisään?", "Vapaaheitto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            valueM += 1
            Form1.Controls.Item(i).Text = valueM.ToString
            Form1.Controls.Item(j).Text = (pts + 1).ToString
        End If
        i = "pctBox1p" + playerID.ToString
        Form1.Controls.Item(i).Text = CInt(valueM / valueA * 100).ToString

    End Sub

    Private Sub btnRebD_Click(sender As Object, e As EventArgs) Handles btnRebD.Click
        Dim i As String
        Dim value As Integer
        i = "DRebBox" + playerID.ToString
        value = CInt(Form1.Controls.Item(i).Text)

        value += 1
        Form1.Controls.Item(i).Text = value.ToString
    End Sub
    Private Sub btnRebO_Click(sender As Object, e As EventArgs) Handles btnRebO.Click
        Dim i As String
        Dim value As Integer
        i = "ORebBox" + playerID.ToString
        value = CInt(Form1.Controls.Item(i).Text)

        value += 1
        Form1.Controls.Item(i).Text = value.ToString
    End Sub

    Private Sub btn_ast_Click(sender As Object, e As EventArgs) Handles btn_ast.Click
        Dim i As String
        Dim value As Integer
        i = "AstBox" + playerID.ToString
        value = CInt(Form1.Controls.Item(i).Text)

        value += 1
        Form1.Controls.Item(i).Text = value.ToString
    End Sub

    Private Sub btn_stl_Click(sender As Object, e As EventArgs) Handles btn_stl.Click
        Dim i As String
        Dim value As Integer
        i = "StlBox" + playerID.ToString
        value = CInt(Form1.Controls.Item(i).Text)

        value += 1
        Form1.Controls.Item(i).Text = value.ToString
    End Sub

    Private Sub btn_blk_Click(sender As Object, e As EventArgs) Handles btn_blk.Click
        Dim i As String
        Dim value As Integer
        i = "BlkBox" + playerID.ToString
        value = CInt(Form1.Controls.Item(i).Text)

        value += 1
        Form1.Controls.Item(i).Text = value.ToString
    End Sub

    Private Sub btn_TO_Click(sender As Object, e As EventArgs) Handles btn_TO.Click
        Dim i As String
        Dim value As Integer
        i = "TOBox" + playerID.ToString
        value = CInt(Form1.Controls.Item(i).Text)

        value += 1
        Form1.Controls.Item(i).Text = value.ToString
    End Sub

    


End Class
