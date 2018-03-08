<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSolde
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSolde))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGV_Solde = New System.Windows.Forms.DataGridView()
        Me.Btn_ValidRecup = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Col_idAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateCreation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Objectif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Delai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_StatutPDCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Recup = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGV_Solde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DGV_Solde, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_ValidRecup, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(674, 463)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DGV_Solde
        '
        Me.DGV_Solde.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Solde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Solde.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_idAction, Me.Col_DateCreation, Me.Col_Objectif, Me.Col_Delai, Me.Col_StatutPDCA, Me.Col_Recup})
        Me.TableLayoutPanel1.SetColumnSpan(Me.DGV_Solde, 2)
        Me.DGV_Solde.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Solde.Location = New System.Drawing.Point(23, 83)
        Me.DGV_Solde.Name = "DGV_Solde"
        Me.DGV_Solde.RowHeadersVisible = False
        Me.DGV_Solde.Size = New System.Drawing.Size(628, 277)
        Me.DGV_Solde.TabIndex = 0
        '
        'Btn_ValidRecup
        '
        Me.Btn_ValidRecup.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Btn_ValidRecup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_ValidRecup.FlatAppearance.BorderSize = 0
        Me.Btn_ValidRecup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ValidRecup.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ValidRecup.ForeColor = System.Drawing.Color.White
        Me.Btn_ValidRecup.Location = New System.Drawing.Point(507, 386)
        Me.Btn_ValidRecup.Name = "Btn_ValidRecup"
        Me.Btn_ValidRecup.Size = New System.Drawing.Size(144, 54)
        Me.Btn_ValidRecup.TabIndex = 1
        Me.Btn_ValidRecup.Text = "Suivant"
        Me.Btn_ValidRecup.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(478, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Récupérer les actions non soldées"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Col_idAction
        '
        Me.Col_idAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_idAction.HeaderText = "idAction"
        Me.Col_idAction.Name = "Col_idAction"
        Me.Col_idAction.ReadOnly = True
        Me.Col_idAction.Visible = False
        '
        'Col_DateCreation
        '
        Me.Col_DateCreation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_DateCreation.HeaderText = "Date création"
        Me.Col_DateCreation.Name = "Col_DateCreation"
        Me.Col_DateCreation.ReadOnly = True
        '
        'Col_Objectif
        '
        Me.Col_Objectif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_Objectif.HeaderText = "Objectif"
        Me.Col_Objectif.Name = "Col_Objectif"
        Me.Col_Objectif.ReadOnly = True
        '
        'Col_Delai
        '
        Me.Col_Delai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_Delai.HeaderText = "Délai"
        Me.Col_Delai.Name = "Col_Delai"
        Me.Col_Delai.ReadOnly = True
        '
        'Col_StatutPDCA
        '
        Me.Col_StatutPDCA.HeaderText = "Statut PDCA"
        Me.Col_StatutPDCA.Name = "Col_StatutPDCA"
        Me.Col_StatutPDCA.ReadOnly = True
        Me.Col_StatutPDCA.Width = 50
        '
        'Col_Recup
        '
        Me.Col_Recup.HeaderText = "Récupérer"
        Me.Col_Recup.Name = "Col_Recup"
        Me.Col_Recup.Width = 65
        '
        'FrmSolde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 463)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSolde"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Entretiens Individuels - Récupérer des actions"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DGV_Solde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DGV_Solde As DataGridView
    Friend WithEvents Btn_ValidRecup As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Col_idAction As DataGridViewTextBoxColumn
    Friend WithEvents Col_DateCreation As DataGridViewTextBoxColumn
    Friend WithEvents Col_Objectif As DataGridViewTextBoxColumn
    Friend WithEvents Col_Delai As DataGridViewTextBoxColumn
    Friend WithEvents Col_StatutPDCA As DataGridViewTextBoxColumn
    Friend WithEvents Col_Recup As DataGridViewCheckBoxColumn
End Class
