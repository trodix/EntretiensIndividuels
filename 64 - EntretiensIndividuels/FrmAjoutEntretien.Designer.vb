<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjoutEntretien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAjoutEntretien))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TLP_Menu = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Accueil = New System.Windows.Forms.Button()
        Me.Btn_Entretiens = New System.Windows.Forms.Button()
        Me.Btn_Equipe = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGV_Entretien = New System.Windows.Forms.DataGridView()
        Me.Col_idEntretien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateEntretien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateEntSuivi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Document = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Col_Valider = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label_Titre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_Collaborateur = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
        Me.TLP_Menu.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGV_Entretien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TLP_Menu)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(241, 559)
        Me.Panel2.TabIndex = 6
        '
        'TLP_Menu
        '
        Me.TLP_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TLP_Menu.ColumnCount = 3
        Me.TLP_Menu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Menu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TLP_Menu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TLP_Menu.Controls.Add(Me.Btn_Accueil, 1, 1)
        Me.TLP_Menu.Controls.Add(Me.Btn_Entretiens, 1, 2)
        Me.TLP_Menu.Controls.Add(Me.Btn_Equipe, 1, 3)
        Me.TLP_Menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Menu.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Menu.Name = "TLP_Menu"
        Me.TLP_Menu.RowCount = 7
        Me.TLP_Menu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Menu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLP_Menu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLP_Menu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLP_Menu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TLP_Menu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Menu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Menu.Size = New System.Drawing.Size(241, 559)
        Me.TLP_Menu.TabIndex = 2
        '
        'Btn_Accueil
        '
        Me.Btn_Accueil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Accueil.FlatAppearance.BorderSize = 0
        Me.Btn_Accueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Accueil.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Accueil.ForeColor = System.Drawing.Color.White
        Me.Btn_Accueil.Image = Global.EntretiensIndividuels.My.Resources.Resources.accueil_32
        Me.Btn_Accueil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Accueil.Location = New System.Drawing.Point(23, 23)
        Me.Btn_Accueil.Name = "Btn_Accueil"
        Me.Btn_Accueil.Size = New System.Drawing.Size(194, 44)
        Me.Btn_Accueil.TabIndex = 7
        Me.Btn_Accueil.Text = "Accueil"
        Me.Btn_Accueil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Accueil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Accueil.UseVisualStyleBackColor = True
        '
        'Btn_Entretiens
        '
        Me.Btn_Entretiens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Entretiens.FlatAppearance.BorderSize = 0
        Me.Btn_Entretiens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Entretiens.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Entretiens.ForeColor = System.Drawing.Color.White
        Me.Btn_Entretiens.Image = CType(resources.GetObject("Btn_Entretiens.Image"), System.Drawing.Image)
        Me.Btn_Entretiens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Entretiens.Location = New System.Drawing.Point(23, 73)
        Me.Btn_Entretiens.Name = "Btn_Entretiens"
        Me.Btn_Entretiens.Size = New System.Drawing.Size(194, 44)
        Me.Btn_Entretiens.TabIndex = 3
        Me.Btn_Entretiens.Text = "Mes entretiens"
        Me.Btn_Entretiens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Entretiens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Entretiens.UseVisualStyleBackColor = True
        '
        'Btn_Equipe
        '
        Me.Btn_Equipe.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Btn_Equipe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Equipe.FlatAppearance.BorderSize = 0
        Me.Btn_Equipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Equipe.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Equipe.ForeColor = System.Drawing.Color.White
        Me.Btn_Equipe.Image = CType(resources.GetObject("Btn_Equipe.Image"), System.Drawing.Image)
        Me.Btn_Equipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Equipe.Location = New System.Drawing.Point(23, 123)
        Me.Btn_Equipe.Name = "Btn_Equipe"
        Me.Btn_Equipe.Size = New System.Drawing.Size(194, 44)
        Me.Btn_Equipe.TabIndex = 4
        Me.Btn_Equipe.Text = "Mon équipe"
        Me.Btn_Equipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Equipe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Equipe.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DGV_Entretien, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Titre, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Cmb_Collaborateur, 2, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(241, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(832, 559)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'DGV_Entretien
        '
        Me.DGV_Entretien.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Entretien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Entretien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_idEntretien, Me.Col_DateEntretien, Me.Col_DateEntSuivi, Me.Col_Document, Me.Col_Valider})
        Me.TableLayoutPanel1.SetColumnSpan(Me.DGV_Entretien, 3)
        Me.DGV_Entretien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Entretien.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_Entretien.Location = New System.Drawing.Point(23, 143)
        Me.DGV_Entretien.Name = "DGV_Entretien"
        Me.DGV_Entretien.RowHeadersVisible = False
        Me.DGV_Entretien.Size = New System.Drawing.Size(784, 393)
        Me.DGV_Entretien.TabIndex = 0
        '
        'Col_idEntretien
        '
        Me.Col_idEntretien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_idEntretien.HeaderText = "id Entretien"
        Me.Col_idEntretien.Name = "Col_idEntretien"
        Me.Col_idEntretien.ReadOnly = True
        Me.Col_idEntretien.Visible = False
        '
        'Col_DateEntretien
        '
        Me.Col_DateEntretien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = "jj/mm/aaaa"
        Me.Col_DateEntretien.DefaultCellStyle = DataGridViewCellStyle1
        Me.Col_DateEntretien.HeaderText = "Date entretien"
        Me.Col_DateEntretien.Name = "Col_DateEntretien"
        '
        'Col_DateEntSuivi
        '
        Me.Col_DateEntSuivi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = "jj/mm/aaaa"
        Me.Col_DateEntSuivi.DefaultCellStyle = DataGridViewCellStyle2
        Me.Col_DateEntSuivi.HeaderText = "Date ent. suivi"
        Me.Col_DateEntSuivi.Name = "Col_DateEntSuivi"
        '
        'Col_Document
        '
        Me.Col_Document.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_Document.HeaderText = "Document scanné"
        Me.Col_Document.Name = "Col_Document"
        Me.Col_Document.Text = "Ajouter document"
        '
        'Col_Valider
        '
        Me.Col_Valider.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_Valider.HeaderText = "Valider"
        Me.Col_Valider.Name = "Col_Valider"
        Me.Col_Valider.Text = "Valider"
        '
        'Label_Titre
        '
        Me.Label_Titre.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label_Titre, 2)
        Me.Label_Titre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Titre.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titre.Location = New System.Drawing.Point(23, 20)
        Me.Label_Titre.Name = "Label_Titre"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label_Titre, 2)
        Me.Label_Titre.Size = New System.Drawing.Size(336, 40)
        Me.Label_Titre.TabIndex = 1
        Me.Label_Titre.Text = "Créer des Entretiens"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(23, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Collaborateur"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cmb_Collaborateur
        '
        Me.Cmb_Collaborateur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_Collaborateur.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Collaborateur.FormattingEnabled = True
        Me.Cmb_Collaborateur.Location = New System.Drawing.Point(173, 93)
        Me.Cmb_Collaborateur.Name = "Cmb_Collaborateur"
        Me.Cmb_Collaborateur.Size = New System.Drawing.Size(186, 26)
        Me.Cmb_Collaborateur.TabIndex = 3
        '
        'FrmAjoutEntretien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 559)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmAjoutEntretien"
        Me.Text = "Entretiens Individuels - Ajouter des entretiens"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.TLP_Menu.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DGV_Entretien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TLP_Menu As TableLayoutPanel
    Friend WithEvents Btn_Entretiens As Button
    Friend WithEvents Btn_Equipe As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DGV_Entretien As DataGridView
    Friend WithEvents Label_Titre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_Collaborateur As ComboBox
    Friend WithEvents Btn_Accueil As Button
    Friend WithEvents Col_idEntretien As DataGridViewTextBoxColumn
    Friend WithEvents Col_DateEntretien As DataGridViewTextBoxColumn
    Friend WithEvents Col_DateEntSuivi As DataGridViewTextBoxColumn
    Friend WithEvents Col_Document As DataGridViewButtonColumn
    Friend WithEvents Col_Valider As DataGridViewButtonColumn
End Class
