<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMonEquipe
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMonEquipe))
        Me.TLP_Main = New System.Windows.Forms.TableLayoutPanel()
        Me.DGV_Noms = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Noms = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Dates = New System.Windows.Forms.DataGridView()
        Me.Col_idEntretien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_idCollab = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Btn_Header = New System.Windows.Forms.Button()
        Me.TLP_Menu = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Accueil = New System.Windows.Forms.Button()
        Me.Btn_Entretiens = New System.Windows.Forms.Button()
        Me.Btn_Equipe = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_AjoutAction = New System.Windows.Forms.Button()
        Me.Btn_AjoutEntretien = New System.Windows.Forms.Button()
        Me.Btn_AjoutCollab = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_VoirFichier = New System.Windows.Forms.Button()
        Me.TLP_Main.SuspendLayout()
        CType(Me.DGV_Noms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Dates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Actions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_Menu.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLP_Main
        '
        Me.TLP_Main.ColumnCount = 5
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TLP_Main.Controls.Add(Me.DGV_Noms, 1, 5)
        Me.TLP_Main.Controls.Add(Me.DGV_Dates, 2, 5)
        Me.TLP_Main.Controls.Add(Me.DGV_Actions, 3, 5)
        Me.TLP_Main.Controls.Add(Me.Label1, 1, 1)
        Me.TLP_Main.Controls.Add(Me.Btn_Header, 1, 3)
        Me.TLP_Main.Controls.Add(Me.Btn_VoirFichier, 2, 3)
        Me.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Main.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Main.Name = "TLP_Main"
        Me.TLP_Main.RowCount = 7
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.Size = New System.Drawing.Size(874, 635)
        Me.TLP_Main.TabIndex = 1
        '
        'DGV_Noms
        '
        Me.DGV_Noms.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Noms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Noms.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.Col_Noms})
        Me.DGV_Noms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Noms.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_Noms.Location = New System.Drawing.Point(23, 153)
        Me.DGV_Noms.MultiSelect = False
        Me.DGV_Noms.Name = "DGV_Noms"
        Me.DGV_Noms.ReadOnly = True
        Me.DGV_Noms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_Noms.RowHeadersVisible = False
        Me.DGV_Noms.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control
        Me.DGV_Noms.RowTemplate.ReadOnly = True
        Me.DGV_Noms.Size = New System.Drawing.Size(197, 459)
        Me.DGV_Noms.TabIndex = 4
        '
        'col_id
        '
        Me.col_id.HeaderText = "idCollab"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Visible = False
        '
        'Col_Noms
        '
        Me.Col_Noms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_Noms.HeaderText = "Nom collaborateurs"
        Me.Col_Noms.Name = "Col_Noms"
        Me.Col_Noms.ReadOnly = True
        '
        'DGV_Dates
        '
        Me.DGV_Dates.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Dates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Dates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_idEntretien, Me.Col_idCollab, Me.Col_dateEntretien})
        Me.DGV_Dates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Dates.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_Dates.Location = New System.Drawing.Point(226, 153)
        Me.DGV_Dates.Name = "DGV_Dates"
        Me.DGV_Dates.RowHeadersVisible = False
        Me.DGV_Dates.Size = New System.Drawing.Size(115, 459)
        Me.DGV_Dates.TabIndex = 5
        '
        'Col_idEntretien
        '
        Me.Col_idEntretien.HeaderText = "idEntretien"
        Me.Col_idEntretien.Name = "Col_idEntretien"
        Me.Col_idEntretien.ReadOnly = True
        Me.Col_idEntretien.Visible = False
        '
        'Col_idCollab
        '
        Me.Col_idCollab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_idCollab.HeaderText = "idCollab"
        Me.Col_idCollab.Name = "Col_idCollab"
        Me.Col_idCollab.ReadOnly = True
        Me.Col_idCollab.Visible = False
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
        Me.DGV_Actions.Location = New System.Drawing.Point(347, 153)
        Me.DGV_Actions.Name = "DGV_Actions"
        Me.DGV_Actions.RowHeadersVisible = False
        Me.DGV_Actions.Size = New System.Drawing.Size(481, 459)
        Me.DGV_Actions.TabIndex = 6
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
        Me.TLP_Main.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(805, 40)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Mon équipe"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_Header
        '
        Me.Btn_Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Header.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Header.FlatAppearance.BorderSize = 0
        Me.Btn_Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Header.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Header.ForeColor = System.Drawing.Color.White
        Me.Btn_Header.Location = New System.Drawing.Point(23, 83)
        Me.Btn_Header.Name = "Btn_Header"
        Me.Btn_Header.Size = New System.Drawing.Size(197, 44)
        Me.Btn_Header.TabIndex = 8
        Me.Btn_Header.Text = "Button1"
        Me.Btn_Header.UseVisualStyleBackColor = False
        Me.Btn_Header.Visible = False
        '
        'TLP_Menu
        '
        Me.TLP_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TLP_Menu.ColumnCount = 4
        Me.TLP_Menu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Menu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Menu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TLP_Menu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TLP_Menu.Controls.Add(Me.Btn_Accueil, 1, 1)
        Me.TLP_Menu.Controls.Add(Me.Btn_Entretiens, 1, 2)
        Me.TLP_Menu.Controls.Add(Me.Btn_Equipe, 1, 3)
        Me.TLP_Menu.Controls.Add(Me.TableLayoutPanel1, 2, 4)
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
        Me.TLP_Menu.Size = New System.Drawing.Size(241, 635)
        Me.TLP_Menu.TabIndex = 2
        '
        'Btn_Accueil
        '
        Me.TLP_Menu.SetColumnSpan(Me.Btn_Accueil, 2)
        Me.Btn_Accueil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Accueil.FlatAppearance.BorderSize = 0
        Me.Btn_Accueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Accueil.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Accueil.ForeColor = System.Drawing.Color.White
        Me.Btn_Accueil.Image = Global.EntretiensIndividuels.My.Resources.Resources.accueil_32
        Me.Btn_Accueil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Accueil.Location = New System.Drawing.Point(23, 23)
        Me.Btn_Accueil.Name = "Btn_Accueil"
        Me.Btn_Accueil.Size = New System.Drawing.Size(214, 44)
        Me.Btn_Accueil.TabIndex = 6
        Me.Btn_Accueil.Text = "Accueil"
        Me.Btn_Accueil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Accueil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Accueil.UseVisualStyleBackColor = True
        '
        'Btn_Entretiens
        '
        Me.TLP_Menu.SetColumnSpan(Me.Btn_Entretiens, 2)
        Me.Btn_Entretiens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Entretiens.FlatAppearance.BorderSize = 0
        Me.Btn_Entretiens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Entretiens.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Entretiens.ForeColor = System.Drawing.Color.White
        Me.Btn_Entretiens.Image = CType(resources.GetObject("Btn_Entretiens.Image"), System.Drawing.Image)
        Me.Btn_Entretiens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Entretiens.Location = New System.Drawing.Point(23, 73)
        Me.Btn_Entretiens.Name = "Btn_Entretiens"
        Me.Btn_Entretiens.Size = New System.Drawing.Size(214, 44)
        Me.Btn_Entretiens.TabIndex = 3
        Me.Btn_Entretiens.Text = "Mes entretiens"
        Me.Btn_Entretiens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Entretiens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Entretiens.UseVisualStyleBackColor = True
        '
        'Btn_Equipe
        '
        Me.Btn_Equipe.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.TLP_Menu.SetColumnSpan(Me.Btn_Equipe, 2)
        Me.Btn_Equipe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Equipe.FlatAppearance.BorderSize = 0
        Me.Btn_Equipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Equipe.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Equipe.ForeColor = System.Drawing.Color.White
        Me.Btn_Equipe.Image = CType(resources.GetObject("Btn_Equipe.Image"), System.Drawing.Image)
        Me.Btn_Equipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Equipe.Location = New System.Drawing.Point(23, 123)
        Me.Btn_Equipe.Name = "Btn_Equipe"
        Me.Btn_Equipe.Size = New System.Drawing.Size(214, 44)
        Me.Btn_Equipe.TabIndex = 4
        Me.Btn_Equipe.Text = "Mon équipe"
        Me.Btn_Equipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Equipe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Equipe.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_AjoutAction, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_AjoutEntretien, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_AjoutCollab, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(43, 173)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TLP_Menu.SetRowSpan(Me.TableLayoutPanel1, 2)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(194, 439)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Btn_AjoutAction
        '
        Me.Btn_AjoutAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_AjoutAction.FlatAppearance.BorderSize = 0
        Me.Btn_AjoutAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AjoutAction.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AjoutAction.ForeColor = System.Drawing.Color.White
        Me.Btn_AjoutAction.Image = CType(resources.GetObject("Btn_AjoutAction.Image"), System.Drawing.Image)
        Me.Btn_AjoutAction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_AjoutAction.Location = New System.Drawing.Point(3, 103)
        Me.Btn_AjoutAction.Name = "Btn_AjoutAction"
        Me.Btn_AjoutAction.Size = New System.Drawing.Size(188, 44)
        Me.Btn_AjoutAction.TabIndex = 2
        Me.Btn_AjoutAction.Text = "Ajouter action"
        Me.Btn_AjoutAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_AjoutAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_AjoutAction.UseVisualStyleBackColor = True
        '
        'Btn_AjoutEntretien
        '
        Me.Btn_AjoutEntretien.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_AjoutEntretien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_AjoutEntretien.FlatAppearance.BorderSize = 0
        Me.Btn_AjoutEntretien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AjoutEntretien.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AjoutEntretien.ForeColor = System.Drawing.Color.White
        Me.Btn_AjoutEntretien.Image = CType(resources.GetObject("Btn_AjoutEntretien.Image"), System.Drawing.Image)
        Me.Btn_AjoutEntretien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_AjoutEntretien.Location = New System.Drawing.Point(3, 53)
        Me.Btn_AjoutEntretien.Name = "Btn_AjoutEntretien"
        Me.Btn_AjoutEntretien.Size = New System.Drawing.Size(188, 44)
        Me.Btn_AjoutEntretien.TabIndex = 1
        Me.Btn_AjoutEntretien.Text = "Ajouter entretien"
        Me.Btn_AjoutEntretien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_AjoutEntretien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_AjoutEntretien.UseVisualStyleBackColor = False
        '
        'Btn_AjoutCollab
        '
        Me.Btn_AjoutCollab.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_AjoutCollab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_AjoutCollab.FlatAppearance.BorderSize = 0
        Me.Btn_AjoutCollab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AjoutCollab.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AjoutCollab.ForeColor = System.Drawing.Color.White
        Me.Btn_AjoutCollab.Image = CType(resources.GetObject("Btn_AjoutCollab.Image"), System.Drawing.Image)
        Me.Btn_AjoutCollab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_AjoutCollab.Location = New System.Drawing.Point(3, 3)
        Me.Btn_AjoutCollab.Name = "Btn_AjoutCollab"
        Me.Btn_AjoutCollab.Size = New System.Drawing.Size(188, 44)
        Me.Btn_AjoutCollab.TabIndex = 0
        Me.Btn_AjoutCollab.Text = "Ajouter collaborateur"
        Me.Btn_AjoutCollab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_AjoutCollab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_AjoutCollab.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TLP_Menu)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(241, 635)
        Me.Panel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TLP_Main)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(241, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 635)
        Me.Panel1.TabIndex = 5
        '
        'Btn_VoirFichier
        '
        Me.Btn_VoirFichier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_VoirFichier.Location = New System.Drawing.Point(226, 83)
        Me.Btn_VoirFichier.Name = "Btn_VoirFichier"
        Me.Btn_VoirFichier.Size = New System.Drawing.Size(115, 44)
        Me.Btn_VoirFichier.TabIndex = 9
        Me.Btn_VoirFichier.Text = "Ouvrir le fichier"
        Me.Btn_VoirFichier.UseVisualStyleBackColor = True
        Me.Btn_VoirFichier.Visible = False
        '
        'FrmMonEquipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 635)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmMonEquipe"
        Me.Text = "Entretiens Individuels - Mon équipe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TLP_Main.ResumeLayout(False)
        Me.TLP_Main.PerformLayout()
        CType(Me.DGV_Noms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Dates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Actions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_Menu.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TLP_Main As TableLayoutPanel
    Friend WithEvents DGV_Noms As DataGridView
    Friend WithEvents DGV_Dates As DataGridView
    Friend WithEvents DGV_Actions As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents Col_Noms As DataGridViewTextBoxColumn
    Friend WithEvents TLP_Menu As TableLayoutPanel
    Friend WithEvents Btn_Entretiens As Button
    Friend WithEvents Btn_Equipe As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Col_idEntretien As DataGridViewTextBoxColumn
    Friend WithEvents Col_idCollab As DataGridViewTextBoxColumn
    Friend WithEvents Col_dateEntretien As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Btn_AjoutAction As Button
    Friend WithEvents Btn_AjoutEntretien As Button
    Friend WithEvents Btn_AjoutCollab As Button
    Friend WithEvents Btn_Accueil As Button
    Friend WithEvents Btn_Header As Button
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
    Friend WithEvents Btn_VoirFichier As Button
End Class
