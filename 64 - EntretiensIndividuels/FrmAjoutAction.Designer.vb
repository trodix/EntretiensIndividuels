﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjoutAction
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGV_Action = New System.Windows.Forms.DataGridView()
        Me.Label_Titre = New System.Windows.Forms.Label()
        Me.Label_Collaborateur = New System.Windows.Forms.Label()
        Me.Label_Entretien = New System.Windows.Forms.Label()
        Me.Cmb_Collaborateur = New System.Windows.Forms.ComboBox()
        Me.Cmb_Entretien = New System.Windows.Forms.ComboBox()
        Me.Col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Descriptif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_RespAction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Col_Delai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_SuiviCom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_StatutPDCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_idCollab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_idEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateSolde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Valider = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGV_Action, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DGV_Action, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Titre, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Collaborateur, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Entretien, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Cmb_Collaborateur, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Cmb_Entretien, 2, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1012, 554)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'DGV_Action
        '
        Me.DGV_Action.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Action.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Action.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_id, Me.Col_Descriptif, Me.Col_RespAction, Me.Col_Delai, Me.Col_SuiviCom, Me.Col_StatutPDCA, Me.Col_idCollab, Me.Col_idEnt, Me.Col_DateSolde, Me.Col_Valider})
        Me.TableLayoutPanel1.SetColumnSpan(Me.DGV_Action, 3)
        Me.DGV_Action.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Action.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_Action.Location = New System.Drawing.Point(23, 143)
        Me.DGV_Action.Name = "DGV_Action"
        Me.DGV_Action.RowHeadersVisible = False
        Me.DGV_Action.Size = New System.Drawing.Size(964, 388)
        Me.DGV_Action.TabIndex = 0
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
        Me.Label_Titre.Size = New System.Drawing.Size(390, 40)
        Me.Label_Titre.TabIndex = 1
        Me.Label_Titre.Text = "Créer des actions"
        '
        'Label_Collaborateur
        '
        Me.Label_Collaborateur.AutoSize = True
        Me.Label_Collaborateur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Collaborateur.Location = New System.Drawing.Point(23, 60)
        Me.Label_Collaborateur.Name = "Label_Collaborateur"
        Me.Label_Collaborateur.Size = New System.Drawing.Size(144, 30)
        Me.Label_Collaborateur.TabIndex = 2
        Me.Label_Collaborateur.Text = "Collaborateur"
        Me.Label_Collaborateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Entretien
        '
        Me.Label_Entretien.AutoSize = True
        Me.Label_Entretien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Entretien.Location = New System.Drawing.Point(23, 90)
        Me.Label_Entretien.Name = "Label_Entretien"
        Me.Label_Entretien.Size = New System.Drawing.Size(144, 30)
        Me.Label_Entretien.TabIndex = 3
        Me.Label_Entretien.Text = "Entretien"
        Me.Label_Entretien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cmb_Collaborateur
        '
        Me.Cmb_Collaborateur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_Collaborateur.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Collaborateur.FormattingEnabled = True
        Me.Cmb_Collaborateur.Location = New System.Drawing.Point(173, 63)
        Me.Cmb_Collaborateur.Name = "Cmb_Collaborateur"
        Me.Cmb_Collaborateur.Size = New System.Drawing.Size(240, 26)
        Me.Cmb_Collaborateur.TabIndex = 4
        '
        'Cmb_Entretien
        '
        Me.Cmb_Entretien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_Entretien.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Entretien.FormattingEnabled = True
        Me.Cmb_Entretien.Location = New System.Drawing.Point(173, 93)
        Me.Cmb_Entretien.Name = "Cmb_Entretien"
        Me.Cmb_Entretien.Size = New System.Drawing.Size(240, 26)
        Me.Cmb_Entretien.TabIndex = 5
        '
        'Col_id
        '
        Me.Col_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = "jj/mm/aaaa"
        Me.Col_id.DefaultCellStyle = DataGridViewCellStyle1
        Me.Col_id.HeaderText = "idAction"
        Me.Col_id.Name = "Col_id"
        Me.Col_id.ReadOnly = True
        Me.Col_id.Visible = False
        '
        'Col_Descriptif
        '
        Me.Col_Descriptif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_Descriptif.HeaderText = "Descriptif"
        Me.Col_Descriptif.Name = "Col_Descriptif"
        '
        'Col_RespAction
        '
        Me.Col_RespAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_RespAction.HeaderText = "Resp. action"
        Me.Col_RespAction.Name = "Col_RespAction"
        Me.Col_RespAction.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Col_RespAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Col_Delai
        '
        Me.Col_Delai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = "jj/mm/aaaa"
        Me.Col_Delai.DefaultCellStyle = DataGridViewCellStyle2
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
        Me.Col_StatutPDCA.HeaderText = "Statut PDCA"
        Me.Col_StatutPDCA.Name = "Col_StatutPDCA"
        Me.Col_StatutPDCA.Width = 40
        '
        'Col_idCollab
        '
        Me.Col_idCollab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_idCollab.HeaderText = "idCollab"
        Me.Col_idCollab.Name = "Col_idCollab"
        Me.Col_idCollab.ReadOnly = True
        Me.Col_idCollab.Visible = False
        '
        'Col_idEnt
        '
        Me.Col_idEnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_idEnt.HeaderText = "id entretien"
        Me.Col_idEnt.Name = "Col_idEnt"
        Me.Col_idEnt.ReadOnly = True
        Me.Col_idEnt.Visible = False
        '
        'Col_DateSolde
        '
        Me.Col_DateSolde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = "jj/mm/aaaa"
        Me.Col_DateSolde.DefaultCellStyle = DataGridViewCellStyle3
        Me.Col_DateSolde.HeaderText = "Date solde"
        Me.Col_DateSolde.Name = "Col_DateSolde"
        '
        'Col_Valider
        '
        Me.Col_Valider.HeaderText = "Valider"
        Me.Col_Valider.Name = "Col_Valider"
        Me.Col_Valider.Text = "Valider"
        Me.Col_Valider.Width = 80
        '
        'FrmAjoutAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 554)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmAjoutAction"
        Me.Text = "Entretiens Individuels - Ajouter des actions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DGV_Action, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DGV_Action As DataGridView
    Friend WithEvents Label_Titre As Label
    Friend WithEvents Label_Collaborateur As Label
    Friend WithEvents Label_Entretien As Label
    Friend WithEvents Cmb_Collaborateur As ComboBox
    Friend WithEvents Cmb_Entretien As ComboBox
    Friend WithEvents Col_id As DataGridViewTextBoxColumn
    Friend WithEvents Col_Descriptif As DataGridViewTextBoxColumn
    Friend WithEvents Col_RespAction As DataGridViewComboBoxColumn
    Friend WithEvents Col_Delai As DataGridViewTextBoxColumn
    Friend WithEvents Col_SuiviCom As DataGridViewTextBoxColumn
    Friend WithEvents Col_StatutPDCA As DataGridViewTextBoxColumn
    Friend WithEvents Col_idCollab As DataGridViewTextBoxColumn
    Friend WithEvents Col_idEnt As DataGridViewTextBoxColumn
    Friend WithEvents Col_DateSolde As DataGridViewTextBoxColumn
    Friend WithEvents Col_Valider As DataGridViewButtonColumn
End Class
