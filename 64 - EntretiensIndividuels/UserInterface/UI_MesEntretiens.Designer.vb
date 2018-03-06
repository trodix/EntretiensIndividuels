<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_MesEntretiens
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_VoirFichier = New System.Windows.Forms.Button()
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
        Me.DGV_Dates = New System.Windows.Forms.DataGridView()
        Me.Col_idEntretien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_dateEntretien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateEntSuivi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGV_Actions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Dates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(988, 617)
        Me.TableLayoutPanel1.TabIndex = 10
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
        Me.Label1.Size = New System.Drawing.Size(939, 40)
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
        Me.Btn_VoirFichier.Size = New System.Drawing.Size(135, 44)
        Me.Btn_VoirFichier.TabIndex = 10
        Me.Btn_VoirFichier.Text = "Voir le fichier"
        Me.Btn_VoirFichier.UseVisualStyleBackColor = False
        Me.Btn_VoirFichier.Visible = False
        '
        'DGV_Actions
        '
        Me.DGV_Actions.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Actions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Actions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_idEnt, Me.Col_idActions, Me.Col_DateCreation, Me.Col_Objectif, Me.Col_Action, Me.Col_RespAction, Me.Col_Delai, Me.Col_SuiviCom, Me.Col_StatutPDCA, Me.Col_DateSolde})
        Me.DGV_Actions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Actions.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_Actions.Location = New System.Drawing.Point(164, 143)
        Me.DGV_Actions.Name = "DGV_Actions"
        Me.DGV_Actions.RowHeadersVisible = False
        Me.DGV_Actions.Size = New System.Drawing.Size(798, 451)
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
        'DGV_Dates
        '
        Me.DGV_Dates.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Dates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Dates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_idEntretien, Me.Col_dateEntretien, Me.Col_DateEntSuivi})
        Me.DGV_Dates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Dates.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_Dates.Location = New System.Drawing.Point(23, 143)
        Me.DGV_Dates.Name = "DGV_Dates"
        Me.DGV_Dates.RowHeadersVisible = False
        Me.DGV_Dates.Size = New System.Drawing.Size(135, 451)
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
        'Col_DateEntSuivi
        '
        Me.Col_DateEntSuivi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_DateEntSuivi.HeaderText = "Date entretien suivi"
        Me.Col_DateEntSuivi.Name = "Col_DateEntSuivi"
        Me.Col_DateEntSuivi.ReadOnly = True
        '
        'UC_MesEntretiens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UC_MesEntretiens"
        Me.Size = New System.Drawing.Size(988, 617)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DGV_Actions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Dates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_VoirFichier As Button
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
    Friend WithEvents DGV_Dates As DataGridView
    Friend WithEvents Col_idEntretien As DataGridViewTextBoxColumn
    Friend WithEvents Col_dateEntretien As DataGridViewTextBoxColumn
    Friend WithEvents Col_DateEntSuivi As DataGridViewTextBoxColumn
End Class
