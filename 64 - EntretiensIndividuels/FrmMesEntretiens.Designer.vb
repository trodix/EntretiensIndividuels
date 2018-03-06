<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMesEntretiens
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMesEntretiens))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TLP_Menu = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Accueil = New System.Windows.Forms.Button()
        Me.Btn_Entretiens = New System.Windows.Forms.Button()
        Me.Btn_Equipe = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGV_Dates = New System.Windows.Forms.DataGridView()
        Me.Col_idEntretien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_dateEntretien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Actions = New System.Windows.Forms.DataGridView()
        Me.Col_idEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_idActions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateCreation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Objectif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Action = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_RespAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Delai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_SuiviCom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_StatutPDCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateSolde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_VoirFichier = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.TLP_Menu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGV_Dates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Actions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TLP_Menu)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(241, 570)
        Me.Panel2.TabIndex = 5
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
        Me.TLP_Menu.Size = New System.Drawing.Size(241, 570)
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
        Me.Btn_Accueil.TabIndex = 8
        Me.Btn_Accueil.Text = "Accueil"
        Me.Btn_Accueil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Accueil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Accueil.UseVisualStyleBackColor = True
        '
        'Btn_Entretiens
        '
        Me.Btn_Entretiens.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(222, Byte), Integer))
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
        Me.Btn_Entretiens.UseVisualStyleBackColor = False
        '
        'Btn_Equipe
        '
        Me.Btn_Equipe.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(241, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(846, 570)
        Me.Panel1.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_VoirFichier, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DGV_Actions, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.DGV_Dates, 1, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(846, 570)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'DGV_Dates
        '
        Me.DGV_Dates.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Dates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Dates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_idEntretien, Me.Col_dateEntretien})
        Me.DGV_Dates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Dates.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_Dates.Location = New System.Drawing.Point(23, 143)
        Me.DGV_Dates.Name = "DGV_Dates"
        Me.DGV_Dates.RowHeadersVisible = False
        Me.DGV_Dates.Size = New System.Drawing.Size(114, 404)
        Me.DGV_Dates.TabIndex = 7
        '
        'Col_idEntretien
        '
        Me.Col_idEntretien.HeaderText = "idEntretien"
        Me.Col_idEntretien.Name = "Col_idEntretien"
        Me.Col_idEntretien.ReadOnly = True
        Me.Col_idEntretien.Visible = False
        '
        'Col_dateEntretien
        '
        Me.Col_dateEntretien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_dateEntretien.HeaderText = "Date Entretien"
        Me.Col_dateEntretien.Name = "Col_dateEntretien"
        Me.Col_dateEntretien.ReadOnly = True
        '
        'DGV_Actions
        '
        Me.DGV_Actions.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Actions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Actions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_idEnt, Me.Col_idActions, Me.Col_DateCreation, Me.Col_Objectif, Me.Col_Action, Me.Col_RespAction, Me.Col_Delai, Me.Col_SuiviCom, Me.Col_StatutPDCA, Me.Col_DateSolde})
        Me.DGV_Actions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Actions.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_Actions.Location = New System.Drawing.Point(143, 143)
        Me.DGV_Actions.Name = "DGV_Actions"
        Me.DGV_Actions.RowHeadersVisible = False
        Me.DGV_Actions.Size = New System.Drawing.Size(679, 404)
        Me.DGV_Actions.TabIndex = 8
        '
        'Col_idEnt
        '
        Me.Col_idEnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_idEnt.HeaderText = "idEntretien"
        Me.Col_idEnt.Name = "Col_idEnt"
        Me.Col_idEnt.ReadOnly = True
        Me.Col_idEnt.Visible = False
        '
        'Col_idActions
        '
        Me.Col_idActions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_idActions.HeaderText = "idActions"
        Me.Col_idActions.Name = "Col_idActions"
        Me.Col_idActions.ReadOnly = True
        Me.Col_idActions.Visible = False
        '
        'Col_DateCreation
        '
        Me.Col_DateCreation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_DateCreation.HeaderText = "Date creation"
        Me.Col_DateCreation.Name = "Col_DateCreation"
        Me.Col_DateCreation.ReadOnly = True
        '
        'Col_Objectif
        '
        Me.Col_Objectif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_Objectif.HeaderText = "Objectif"
        Me.Col_Objectif.Name = "Col_Objectif"
        '
        'Col_Action
        '
        Me.Col_Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_Action.HeaderText = "Action"
        Me.Col_Action.Name = "Col_Action"
        '
        'Col_RespAction
        '
        Me.Col_RespAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_RespAction.HeaderText = "Resp. action"
        Me.Col_RespAction.Name = "Col_RespAction"
        '
        'Col_Delai
        '
        Me.Col_Delai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_Delai.HeaderText = "Delai"
        Me.Col_Delai.Name = "Col_Delai"
        '
        'Col_SuiviCom
        '
        Me.Col_SuiviCom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_SuiviCom.HeaderText = "Suivi com."
        Me.Col_SuiviCom.Name = "Col_SuiviCom"
        '
        'Col_StatutPDCA
        '
        Me.Col_StatutPDCA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_StatutPDCA.HeaderText = "Statut PDCA"
        Me.Col_StatutPDCA.Name = "Col_StatutPDCA"
        Me.Col_StatutPDCA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Col_DateSolde
        '
        Me.Col_DateSolde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_DateSolde.HeaderText = "Date solde"
        Me.Col_DateSolde.Name = "Col_DateSolde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(799, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Mes entretiens"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_VoirFichier
        '
        Me.Btn_VoirFichier.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_VoirFichier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_VoirFichier.FlatAppearance.BorderSize = 0
        Me.Btn_VoirFichier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_VoirFichier.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_VoirFichier.ForeColor = System.Drawing.Color.White
        Me.Btn_VoirFichier.Location = New System.Drawing.Point(23, 83)
        Me.Btn_VoirFichier.Name = "Btn_VoirFichier"
        Me.Btn_VoirFichier.Size = New System.Drawing.Size(114, 44)
        Me.Btn_VoirFichier.TabIndex = 10
        Me.Btn_VoirFichier.Text = "Voir le fichier"
        Me.Btn_VoirFichier.UseVisualStyleBackColor = False
        Me.Btn_VoirFichier.Visible = False
        '
        'FrmMesEntretiens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 570)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmMesEntretiens"
        Me.Text = "Entretiens Individuels - Mes entretiens"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.TLP_Menu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DGV_Dates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Actions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TLP_Menu As TableLayoutPanel
    Friend WithEvents Btn_Entretiens As Button
    Friend WithEvents Btn_Equipe As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGV_Dates As DataGridView
    Friend WithEvents Col_idEntretien As DataGridViewTextBoxColumn
    Friend WithEvents Col_dateEntretien As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Btn_Accueil As Button
    Friend WithEvents DGV_Actions As DataGridView
    Friend WithEvents Col_idEnt As DataGridViewTextBoxColumn
    Friend WithEvents Col_idActions As DataGridViewTextBoxColumn
    Friend WithEvents Col_DateCreation As DataGridViewTextBoxColumn
    Friend WithEvents Col_Objectif As DataGridViewTextBoxColumn
    Friend WithEvents Col_Action As DataGridViewTextBoxColumn
    Friend WithEvents Col_RespAction As DataGridViewTextBoxColumn
    Friend WithEvents Col_Delai As DataGridViewTextBoxColumn
    Friend WithEvents Col_SuiviCom As DataGridViewTextBoxColumn
    Friend WithEvents Col_StatutPDCA As DataGridViewTextBoxColumn
    Friend WithEvents Col_DateSolde As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_VoirFichier As Button
End Class
