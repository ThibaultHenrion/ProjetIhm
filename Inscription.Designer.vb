<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscription
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inscription))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Suivant = New System.Windows.Forms.Button()
        Me.Annuler = New System.Windows.Forms.Button()
        Me.affichAge = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.scrollAge = New System.Windows.Forms.HScrollBar()
        Me.nomVille = New System.Windows.Forms.TextBox()
        Me.CP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AdresseCandidat = New System.Windows.Forms.TextBox()
        Me.PrenomCandidat = New System.Windows.Forms.TextBox()
        Me.NomCandidat = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Suivant)
        Me.GroupBox1.Controls.Add(Me.Annuler)
        Me.GroupBox1.Controls.Add(Me.affichAge)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.scrollAge)
        Me.GroupBox1.Controls.Add(Me.nomVille)
        Me.GroupBox1.Controls.Add(Me.CP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.AdresseCandidat)
        Me.GroupBox1.Controls.Add(Me.PrenomCandidat)
        Me.GroupBox1.Controls.Add(Me.NomCandidat)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 369)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "coordonées"
        '
        'Suivant
        '
        Me.Suivant.Location = New System.Drawing.Point(325, 282)
        Me.Suivant.Name = "Suivant"
        Me.Suivant.Size = New System.Drawing.Size(106, 49)
        Me.Suivant.TabIndex = 15
        Me.Suivant.Text = "Suivant"
        Me.Suivant.UseVisualStyleBackColor = True
        '
        'Annuler
        '
        Me.Annuler.Location = New System.Drawing.Point(125, 282)
        Me.Annuler.Name = "Annuler"
        Me.Annuler.Size = New System.Drawing.Size(125, 49)
        Me.Annuler.TabIndex = 14
        Me.Annuler.Text = "Abandonner"
        Me.Annuler.UseVisualStyleBackColor = True
        '
        'affichAge
        '
        Me.affichAge.AutoSize = True
        Me.affichAge.Location = New System.Drawing.Point(442, 212)
        Me.affichAge.Name = "affichAge"
        Me.affichAge.Size = New System.Drawing.Size(0, 17)
        Me.affichAge.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(108, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Ville"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Code Postale"
        '
        'scrollAge
        '
        Me.scrollAge.LargeChange = 1
        Me.scrollAge.Location = New System.Drawing.Point(165, 208)
        Me.scrollAge.Maximum = 55
        Me.scrollAge.Minimum = 18
        Me.scrollAge.Name = "scrollAge"
        Me.scrollAge.Size = New System.Drawing.Size(239, 32)
        Me.scrollAge.TabIndex = 9
        Me.scrollAge.Value = 18
        '
        'nomVille
        '
        Me.nomVille.Location = New System.Drawing.Point(166, 168)
        Me.nomVille.MaxLength = 15
        Me.nomVille.Name = "nomVille"
        Me.nomVille.Size = New System.Drawing.Size(238, 22)
        Me.nomVille.TabIndex = 8
        '
        'CP
        '
        Me.CP.Location = New System.Drawing.Point(166, 132)
        Me.CP.MaxLength = 5
        Me.CP.Name = "CP"
        Me.CP.Size = New System.Drawing.Size(238, 22)
        Me.CP.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Adresse"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Prénom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nom"
        '
        'AdresseCandidat
        '
        Me.AdresseCandidat.Location = New System.Drawing.Point(165, 96)
        Me.AdresseCandidat.MaxLength = 30
        Me.AdresseCandidat.Name = "AdresseCandidat"
        Me.AdresseCandidat.Size = New System.Drawing.Size(239, 22)
        Me.AdresseCandidat.TabIndex = 2
        '
        'PrenomCandidat
        '
        Me.PrenomCandidat.Location = New System.Drawing.Point(165, 57)
        Me.PrenomCandidat.MaxLength = 15
        Me.PrenomCandidat.Name = "PrenomCandidat"
        Me.PrenomCandidat.Size = New System.Drawing.Size(239, 22)
        Me.PrenomCandidat.TabIndex = 1
        '
        'NomCandidat
        '
        Me.NomCandidat.Location = New System.Drawing.Point(165, 20)
        Me.NomCandidat.MaxLength = 15
        Me.NomCandidat.Name = "NomCandidat"
        Me.NomCandidat.Size = New System.Drawing.Size(239, 22)
        Me.NomCandidat.TabIndex = 0
        '
        'Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 395)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inscription"
        Me.Text = "Inscription"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AdresseCandidat As TextBox
    Friend WithEvents PrenomCandidat As TextBox
    Friend WithEvents NomCandidat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents scrollAge As HScrollBar
    Friend WithEvents nomVille As TextBox
    Friend WithEvents CP As TextBox
    Friend WithEvents affichAge As Label
    Friend WithEvents Suivant As Button
    Friend WithEvents Annuler As Button
End Class
