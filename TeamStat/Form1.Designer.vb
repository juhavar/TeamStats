<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblFoul = New System.Windows.Forms.Label()
        Me.lbl_throw = New System.Windows.Forms.Label()
        Me.lbl_reb = New System.Windows.Forms.Label()
        Me.lbl2pM = New System.Windows.Forms.Label()
        Me.lbl2pA = New System.Windows.Forms.Label()
        Me.lbl2pt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_3pA = New System.Windows.Forms.Label()
        Me.lbl_3pM = New System.Windows.Forms.Label()
        Me.lbl_2p = New System.Windows.Forms.Label()
        Me.lbl_3p = New System.Windows.Forms.Label()
        Me.lbl_vaparit = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_levyt = New System.Windows.Forms.Label()
        Me.lbl_rebD = New System.Windows.Forms.Label()
        Me.lbl_rebO = New System.Windows.Forms.Label()
        Me.lbl_ast = New System.Windows.Forms.Label()
        Me.lbl_stl = New System.Windows.Forms.Label()
        Me.lbl_Blk = New System.Windows.Forms.Label()
        Me.lbl_TO = New System.Windows.Forms.Label()
        Me.lbl_totPts = New System.Windows.Forms.Label()
        Me.addPlayerButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(178, 54)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(14, 13)
        Me.lblNumber.TabIndex = 1
        Me.lblNumber.Text = "#"
        Me.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayerName
        '
        Me.lblPlayerName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Location = New System.Drawing.Point(32, 54)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(27, 13)
        Me.lblPlayerName.TabIndex = 2
        Me.lblPlayerName.Text = "Nimi"
        Me.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoul
        '
        Me.lblFoul.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFoul.AutoSize = True
        Me.lblFoul.Location = New System.Drawing.Point(582, 54)
        Me.lblFoul.Name = "lblFoul"
        Me.lblFoul.Size = New System.Drawing.Size(20, 13)
        Me.lblFoul.TabIndex = 5
        Me.lblFoul.Text = "PF"
        Me.lblFoul.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_throw
        '
        Me.lbl_throw.AutoSize = True
        Me.lbl_throw.Location = New System.Drawing.Point(289, 55)
        Me.lbl_throw.Name = "lbl_throw"
        Me.lbl_throw.Size = New System.Drawing.Size(35, 13)
        Me.lbl_throw.TabIndex = 11
        Me.lbl_throw.Text = "Heitot"
        '
        'lbl_reb
        '
        Me.lbl_reb.AutoSize = True
        Me.lbl_reb.Location = New System.Drawing.Point(366, 55)
        Me.lbl_reb.Name = "lbl_reb"
        Me.lbl_reb.Size = New System.Drawing.Size(55, 13)
        Me.lbl_reb.TabIndex = 13
        Me.lbl_reb.Text = "Levypallot"
        '
        'lbl2pM
        '
        Me.lbl2pM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl2pM.AutoSize = True
        Me.lbl2pM.Location = New System.Drawing.Point(614, 54)
        Me.lbl2pM.Name = "lbl2pM"
        Me.lbl2pM.Size = New System.Drawing.Size(16, 13)
        Me.lbl2pM.TabIndex = 14
        Me.lbl2pM.Text = "M"
        Me.lbl2pM.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl2pA
        '
        Me.lbl2pA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl2pA.AutoSize = True
        Me.lbl2pA.Location = New System.Drawing.Point(650, 54)
        Me.lbl2pA.Name = "lbl2pA"
        Me.lbl2pA.Size = New System.Drawing.Size(14, 13)
        Me.lbl2pA.TabIndex = 16
        Me.lbl2pA.Text = "A"
        Me.lbl2pA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl2pt
        '
        Me.lbl2pt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl2pt.AutoSize = True
        Me.lbl2pt.Location = New System.Drawing.Point(684, 54)
        Me.lbl2pt.Name = "lbl2pt"
        Me.lbl2pt.Size = New System.Drawing.Size(15, 13)
        Me.lbl2pt.TabIndex = 20
        Me.lbl2pt.Text = "%"
        Me.lbl2pt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(786, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "%"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_3pA
        '
        Me.lbl_3pA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_3pA.AutoSize = True
        Me.lbl_3pA.Location = New System.Drawing.Point(749, 54)
        Me.lbl_3pA.Name = "lbl_3pA"
        Me.lbl_3pA.Size = New System.Drawing.Size(14, 13)
        Me.lbl_3pA.TabIndex = 24
        Me.lbl_3pA.Text = "A"
        Me.lbl_3pA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_3pM
        '
        Me.lbl_3pM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_3pM.AutoSize = True
        Me.lbl_3pM.Location = New System.Drawing.Point(713, 54)
        Me.lbl_3pM.Name = "lbl_3pM"
        Me.lbl_3pM.Size = New System.Drawing.Size(16, 13)
        Me.lbl_3pM.TabIndex = 22
        Me.lbl_3pM.Text = "M"
        Me.lbl_3pM.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_2p
        '
        Me.lbl_2p.AutoSize = True
        Me.lbl_2p.Location = New System.Drawing.Point(617, 37)
        Me.lbl_2p.Name = "lbl_2p"
        Me.lbl_2p.Size = New System.Drawing.Size(79, 13)
        Me.lbl_2p.TabIndex = 30
        Me.lbl_2p.Text = "2-pisteen heitot"
        '
        'lbl_3p
        '
        Me.lbl_3p.AutoSize = True
        Me.lbl_3p.Location = New System.Drawing.Point(716, 37)
        Me.lbl_3p.Name = "lbl_3p"
        Me.lbl_3p.Size = New System.Drawing.Size(79, 13)
        Me.lbl_3p.TabIndex = 31
        Me.lbl_3p.Text = "3-pisteen heitot"
        '
        'lbl_vaparit
        '
        Me.lbl_vaparit.AutoSize = True
        Me.lbl_vaparit.Location = New System.Drawing.Point(830, 37)
        Me.lbl_vaparit.Name = "lbl_vaparit"
        Me.lbl_vaparit.Size = New System.Drawing.Size(63, 13)
        Me.lbl_vaparit.TabIndex = 40
        Me.lbl_vaparit.Text = "vapaaheitot"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(889, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "%"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(854, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "A"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(818, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "M"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_levyt
        '
        Me.lbl_levyt.AutoSize = True
        Me.lbl_levyt.Location = New System.Drawing.Point(913, 37)
        Me.lbl_levyt.Name = "lbl_levyt"
        Me.lbl_levyt.Size = New System.Drawing.Size(51, 13)
        Me.lbl_levyt.TabIndex = 43
        Me.lbl_levyt.Text = "levypallot"
        '
        'lbl_rebD
        '
        Me.lbl_rebD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rebD.AutoSize = True
        Me.lbl_rebD.Location = New System.Drawing.Point(919, 55)
        Me.lbl_rebD.Name = "lbl_rebD"
        Me.lbl_rebD.Size = New System.Drawing.Size(15, 13)
        Me.lbl_rebD.TabIndex = 44
        Me.lbl_rebD.Text = "D"
        Me.lbl_rebD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_rebO
        '
        Me.lbl_rebO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rebO.AutoSize = True
        Me.lbl_rebO.Location = New System.Drawing.Point(944, 55)
        Me.lbl_rebO.Name = "lbl_rebO"
        Me.lbl_rebO.Size = New System.Drawing.Size(15, 13)
        Me.lbl_rebO.TabIndex = 45
        Me.lbl_rebO.Text = "O"
        Me.lbl_rebO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_ast
        '
        Me.lbl_ast.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ast.AutoSize = True
        Me.lbl_ast.Location = New System.Drawing.Point(966, 55)
        Me.lbl_ast.Name = "lbl_ast"
        Me.lbl_ast.Size = New System.Drawing.Size(22, 13)
        Me.lbl_ast.TabIndex = 50
        Me.lbl_ast.Text = "Ast"
        Me.lbl_ast.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_stl
        '
        Me.lbl_stl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_stl.AutoSize = True
        Me.lbl_stl.Location = New System.Drawing.Point(993, 55)
        Me.lbl_stl.Name = "lbl_stl"
        Me.lbl_stl.Size = New System.Drawing.Size(19, 13)
        Me.lbl_stl.TabIndex = 51
        Me.lbl_stl.Text = "Stl"
        Me.lbl_stl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_Blk
        '
        Me.lbl_Blk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Blk.AutoSize = True
        Me.lbl_Blk.Location = New System.Drawing.Point(1018, 55)
        Me.lbl_Blk.Name = "lbl_Blk"
        Me.lbl_Blk.Size = New System.Drawing.Size(22, 13)
        Me.lbl_Blk.TabIndex = 52
        Me.lbl_Blk.Text = "Blk"
        Me.lbl_Blk.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_TO
        '
        Me.lbl_TO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_TO.AutoSize = True
        Me.lbl_TO.Location = New System.Drawing.Point(1045, 55)
        Me.lbl_TO.Name = "lbl_TO"
        Me.lbl_TO.Size = New System.Drawing.Size(22, 13)
        Me.lbl_TO.TabIndex = 53
        Me.lbl_TO.Text = "TO"
        Me.lbl_TO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_totPts
        '
        Me.lbl_totPts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_totPts.AutoSize = True
        Me.lbl_totPts.Location = New System.Drawing.Point(1074, 54)
        Me.lbl_totPts.Name = "lbl_totPts"
        Me.lbl_totPts.Size = New System.Drawing.Size(22, 13)
        Me.lbl_totPts.TabIndex = 55
        Me.lbl_totPts.Text = "Pts"
        Me.lbl_totPts.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'addPlayerButton
        '
        Me.addPlayerButton.Location = New System.Drawing.Point(28, 10)
        Me.addPlayerButton.Name = "addPlayerButton"
        Me.addPlayerButton.Size = New System.Drawing.Size(111, 27)
        Me.addPlayerButton.TabIndex = 56
        Me.addPlayerButton.Text = "Lisää pelaaja"
        Me.addPlayerButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 315)
        Me.Controls.Add(Me.addPlayerButton)
        Me.Controls.Add(Me.lbl_totPts)
        Me.Controls.Add(Me.lbl_TO)
        Me.Controls.Add(Me.lbl_Blk)
        Me.Controls.Add(Me.lbl_stl)
        Me.Controls.Add(Me.lbl_ast)
        Me.Controls.Add(Me.lbl_rebO)
        Me.Controls.Add(Me.lbl_rebD)
        Me.Controls.Add(Me.lbl_levyt)
        Me.Controls.Add(Me.lbl_vaparit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_3p)
        Me.Controls.Add(Me.lbl_2p)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_3pA)
        Me.Controls.Add(Me.lbl_3pM)
        Me.Controls.Add(Me.lbl2pt)
        Me.Controls.Add(Me.lbl2pA)
        Me.Controls.Add(Me.lbl2pM)
        Me.Controls.Add(Me.lbl_reb)
        Me.Controls.Add(Me.lbl_throw)
        Me.Controls.Add(Me.lblFoul)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.lblNumber)
        Me.Name = "Form1"
        Me.Text = "PyrsäStats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents lblFoul As System.Windows.Forms.Label
    Friend WithEvents lbl_throw As System.Windows.Forms.Label
    Friend WithEvents lbl_reb As System.Windows.Forms.Label
    Friend WithEvents lbl2pM As System.Windows.Forms.Label
    Friend WithEvents lbl2pA As System.Windows.Forms.Label
    Friend WithEvents lbl2pt As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_3pA As System.Windows.Forms.Label
    Friend WithEvents lbl_3pM As System.Windows.Forms.Label
    Friend WithEvents lbl_2p As System.Windows.Forms.Label
    Friend WithEvents lbl_3p As System.Windows.Forms.Label
    Friend WithEvents lbl_vaparit As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_levyt As System.Windows.Forms.Label
    Friend WithEvents lbl_rebD As System.Windows.Forms.Label
    Friend WithEvents lbl_rebO As System.Windows.Forms.Label
    Friend WithEvents lbl_ast As System.Windows.Forms.Label
    Friend WithEvents lbl_stl As System.Windows.Forms.Label
    Friend WithEvents lbl_Blk As System.Windows.Forms.Label
    Friend WithEvents lbl_TO As System.Windows.Forms.Label
    Friend WithEvents lbl_totPts As System.Windows.Forms.Label
    Friend WithEvents addPlayerButton As System.Windows.Forms.Button

End Class
