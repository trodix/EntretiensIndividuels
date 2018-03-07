<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_MonEquipe
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.TLP_Main = New System.Windows.Forms.TableLayoutPanel()
        Me.DGV_Noms = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Noms = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Dates = New System.Windows.Forms.DataGridView()
        Me.Col_idEntretien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_idCollab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_dateEntretien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateEntSuivi = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Btn_Modif = New System.Windows.Forms.Button()
        Me.Btn_VoirFichier = New System.Windows.Forms.Button()
        Me.Btn_Supprimer = New System.Windows.Forms.Button()
        Me.TLP_Main.SuspendLayout()
        CType(Me.DGV_Noms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Dates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Actions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TLP_Main
        '
        Me.TLP_Main.ColumnCount = 8
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TLP_Main.Controls.Add(Me.DGV_Noms, 1, 5)
        Me.TLP_Main.Controls.Add(Me.DGV_Dates, 3, 5)
        Me.TLP_Main.Controls.Add(Me.DGV_Actions, 5, 5)
        Me.TLP_Main.Controls.Add(Me.Label1, 1, 1)
        Me.TLP_Main.Controls.Add(Me.Btn_Modif, 1, 3)
        Me.TLP_Main.Controls.Add(Me.Btn_VoirFichier, 3, 3)
        Me.TLP_Main.Controls.Add(Me.Btn_Supprimer, 5, 3)
        Me.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Main.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Main.Name = "TLP_Main"
        Me.TLP_Main.RowCount = 7
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.Size = New System.Drawing.Size(1222, 701)
        Me.TLP_Main.TabIndex = 2
        '
        'DGV_Noms
        '
        Me.DGV_Noms.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Noms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Noms.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.Col_Noms})
        Me.TLP_Main.SetColumnSpan(Me.DGV_Noms, 2)
        Me.DGV_Noms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Noms.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_Noms.Location = New System.Drawing.Point(23, 163)
        Me.DGV_Noms.MultiSelect = False
        Me.DGV_Noms.Name = "DGV_Noms"
        Me.DGV_Noms.ReadOnly = True
        Me.DGV_Noms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_Noms.RowHeadersVisible = False
        Me.DGV_Noms.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control
        Me.DGV_Noms.RowTemplate.ReadOnly = True
        Me.DGV_Noms.Size = New System.Drawing.Size(289, 515)
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
        Me.DGV_Dates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_idEntretien, Me.Col_idCollab, Me.Col_dateEntretien, Me.Col_DateEntSuivi})
        Me.TLP_Main.SetColumnSpan(Me.DGV_Dates, 2)
        Me.DGV_Dates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Dates.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_Dates.Location = New System.Drawing.Point(318, 163)
        Me.DGV_Dates.Name = "DGV_Dates"
        Me.DGV_Dates.RowHeadersVisible = False
        Me.DGV_Dates.Size = New System.Drawing.Size(171, 515)
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
        'Col_DateEntSuivi
        '
        Me.Col_DateEntSuivi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_DateEntSuivi.HeaderText = "Date entretien suivi"
        Me.Col_DateEntSuivi.Name = "Col_DateEntSuivi"
        Me.Col_DateEntSuivi.ReadOnly = True
        '
        'DGV_Actions
        '
        Me.DGV_Actions.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Actions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Actions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_idEnt, Me.Col_idActions, Me.Col_DateCreation, Me.Col_Objectif, Me.Col_Action, Me.Col_RespAction, Me.Col_Delai, Me.Col_SuiviCom, Me.Col_StatutPDCA, Me.Col_DateSolde})
        Me.TLP_Main.SetColumnSpan(Me.DGV_Actions, 2)
        Me.DGV_Actions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Actions.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_Actions.Location = New System.Drawing.Point(495, 163)
        Me.DGV_Actions.Name = "DGV_Actions"
        Me.DGV_Actions.RowHeadersVisible = False
        Me.DGV_Actions.Size = New System.Drawing.Size(702, 515)
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
        Me.TLP_Main.SetColumnSpan(Me.Label1, 5)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(643, 40)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Mon équipe"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_Modif
        '
        Me.Btn_Modif.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Modif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Modif.FlatAppearance.BorderSize = 0
        Me.Btn_Modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Modif.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modif.ForeColor = System.Drawing.Color.White
        Me.Btn_Modif.Image = Global.EntretiensIndividuels.My.Resources.Resources.icons8_modifier_32
        Me.Btn_Modif.Location = New System.Drawing.Point(23, 83)
        Me.Btn_Modif.Name = "Btn_Modif"
        Me.Btn_Modif.Size = New System.Drawing.Size(171, 54)
        Me.Btn_Modif.TabIndex = 8
        Me.Btn_Modif.Text = "Modifier"
        Me.Btn_Modif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Modif.UseVisualStyleBackColor = False
        Me.Btn_Modif.Visible = False
        '
        'Btn_VoirFichier
        '
        Me.Btn_VoirFichier.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TLP_Main.SetColumnSpan(Me.Btn_VoirFichier, 2)
        Me.Btn_VoirFichier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_VoirFichier.FlatAppearance.BorderSize = 0
        Me.Btn_VoirFichier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_VoirFichier.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_VoirFichier.ForeColor = System.Drawing.Color.White
        Me.Btn_VoirFichier.Image = Global.EntretiensIndividuels.My.Resources.Resources.icons8_visible_32
        Me.Btn_VoirFichier.Location = New System.Drawing.Point(318, 83)
        Me.Btn_VoirFichier.Name = "Btn_VoirFichier"
        Me.Btn_VoirFichier.Size = New System.Drawing.Size(171, 54)
        Me.Btn_VoirFichier.TabIndex = 9
        Me.Btn_VoirFichier.Text = "Ouvrir le fichier"
        Me.Btn_VoirFichier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_VoirFichier.UseVisualStyleBackColor = False
        Me.Btn_VoirFichier.Visible = False
        '
        'Btn_Supprimer
        '
        Me.Btn_Supprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Btn_Supprimer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Supprimer.FlatAppearance.BorderSize = 0
        Me.Btn_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Supprimer.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Supprimer.ForeColor = System.Drawing.Color.White
        Me.Btn_Supprimer.Image = Global.EntretiensIndividuels.My.Resources.Resources.icons8_poubelle_32
        Me.Btn_Supprimer.Location = New System.Drawing.Point(495, 83)
        Me.Btn_Supprimer.Name = "Btn_Supprimer"
        Me.Btn_Supprimer.Size = New System.Drawing.Size(171, 54)
        Me.Btn_Supprimer.TabIndex = 10
        Me.Btn_Supprimer.Text = "Supprimer"
        Me.Btn_Supprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Supprimer.UseVisualStyleBackColor = False
        Me.Btn_Supprimer.Visible = False
        '
        'UI_MonEquipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TLP_Main)
        Me.Name = "UI_MonEquipe"
        Me.Size = New System.Drawing.Size(1222, 701)
        Me.TLP_Main.ResumeLayout(False)
        Me.TLP_Main.PerformLayout()
        CType(Me.DGV_Noms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Dates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Actions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TLP_Main As TableLayoutPanel
    Friend WithEvents DGV_Noms As DataGridView
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents Col_Noms As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Dates As DataGridView
    Friend WithEvents Col_idEntretien As DataGridViewTextBoxColumn
    Friend WithEvents Col_idCollab As DataGridViewTextBoxColumn
    Friend WithEvents Col_dateEntretien As DataGridViewTextBoxColumn
    Friend WithEvents Col_DateEntSuivi As DataGridViewTextBoxColumn
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
    Friend WithEvents Btn_Modif As Button
    Friend WithEvents Btn_VoirFichier As Button
    Friend WithEvents Btn_Supprimer As Button
End Class
