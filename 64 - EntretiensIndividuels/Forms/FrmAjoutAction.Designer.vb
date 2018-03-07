<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAjoutAction))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Collaborateur = New System.Windows.Forms.Label()
        Me.Label_Entretien = New System.Windows.Forms.Label()
        Me.Cmb_Collaborateur = New System.Windows.Forms.ComboBox()
        Me.Cmb_Entretien = New System.Windows.Forms.ComboBox()
        Me.Label_Titre = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tbx_SuiviCom = New System.Windows.Forms.RichTextBox()
        Me.Tbx_Objectif = New System.Windows.Forms.RichTextBox()
        Me.Tbx_Action = New System.Windows.Forms.RichTextBox()
        Me.Cmb_RespAction = New System.Windows.Forms.ComboBox()
        Me.Dtp_Delai = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cmb_StatutPDCA = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Dtp_DateSolde = New System.Windows.Forms.DateTimePicker()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Collaborateur, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Entretien, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Cmb_Collaborateur, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Cmb_Entretien, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Titre, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Tbx_SuiviCom, 8, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Tbx_Objectif, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Tbx_Action, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Cmb_RespAction, 2, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Dtp_Delai, 2, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 4, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Cmb_StatutPDCA, 8, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 4, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Dtp_DateSolde, 8, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnValider, 5, 14)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 18
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1054, 511)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Label_Collaborateur
        '
        Me.Label_Collaborateur.AutoSize = True
        Me.Label_Collaborateur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Collaborateur.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Collaborateur.Location = New System.Drawing.Point(23, 100)
        Me.Label_Collaborateur.Name = "Label_Collaborateur"
        Me.Label_Collaborateur.Size = New System.Drawing.Size(194, 30)
        Me.Label_Collaborateur.TabIndex = 2
        Me.Label_Collaborateur.Text = "Collaborateur"
        Me.Label_Collaborateur.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Entretien
        '
        Me.Label_Entretien.AutoSize = True
        Me.Label_Entretien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Entretien.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Entretien.Location = New System.Drawing.Point(23, 130)
        Me.Label_Entretien.Name = "Label_Entretien"
        Me.Label_Entretien.Size = New System.Drawing.Size(194, 30)
        Me.Label_Entretien.TabIndex = 3
        Me.Label_Entretien.Text = "Entretien"
        Me.Label_Entretien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmb_Collaborateur
        '
        Me.Cmb_Collaborateur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_Collaborateur.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Collaborateur.FormattingEnabled = True
        Me.Cmb_Collaborateur.Location = New System.Drawing.Point(223, 103)
        Me.Cmb_Collaborateur.Name = "Cmb_Collaborateur"
        Me.Cmb_Collaborateur.Size = New System.Drawing.Size(294, 26)
        Me.Cmb_Collaborateur.TabIndex = 4
        '
        'Cmb_Entretien
        '
        Me.Cmb_Entretien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_Entretien.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Entretien.FormattingEnabled = True
        Me.Cmb_Entretien.Location = New System.Drawing.Point(223, 133)
        Me.Cmb_Entretien.Name = "Cmb_Entretien"
        Me.Cmb_Entretien.Size = New System.Drawing.Size(294, 26)
        Me.Cmb_Entretien.TabIndex = 5
        '
        'Label_Titre
        '
        Me.Label_Titre.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label_Titre, 5)
        Me.Label_Titre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Titre.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titre.Location = New System.Drawing.Point(23, 20)
        Me.Label_Titre.Name = "Label_Titre"
        Me.Label_Titre.Size = New System.Drawing.Size(608, 60)
        Me.Label_Titre.TabIndex = 6
        Me.Label_Titre.Text = "Créer des actions"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label5, 4)
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(537, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 40)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Suivi commentaire"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tbx_SuiviCom
        '
        Me.Tbx_SuiviCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tbx_SuiviCom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbx_SuiviCom.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_SuiviCom.Location = New System.Drawing.Point(737, 183)
        Me.Tbx_SuiviCom.Name = "Tbx_SuiviCom"
        Me.TableLayoutPanel1.SetRowSpan(Me.Tbx_SuiviCom, 2)
        Me.Tbx_SuiviCom.Size = New System.Drawing.Size(294, 64)
        Me.Tbx_SuiviCom.TabIndex = 11
        Me.Tbx_SuiviCom.Text = ""
        '
        'Tbx_Objectif
        '
        Me.Tbx_Objectif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tbx_Objectif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbx_Objectif.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_Objectif.Location = New System.Drawing.Point(223, 183)
        Me.Tbx_Objectif.Name = "Tbx_Objectif"
        Me.TableLayoutPanel1.SetRowSpan(Me.Tbx_Objectif, 2)
        Me.Tbx_Objectif.Size = New System.Drawing.Size(294, 64)
        Me.Tbx_Objectif.TabIndex = 22
        Me.Tbx_Objectif.Text = ""
        '
        'Tbx_Action
        '
        Me.Tbx_Action.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tbx_Action.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbx_Action.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_Action.Location = New System.Drawing.Point(223, 273)
        Me.Tbx_Action.Name = "Tbx_Action"
        Me.TableLayoutPanel1.SetRowSpan(Me.Tbx_Action, 2)
        Me.Tbx_Action.Size = New System.Drawing.Size(294, 84)
        Me.Tbx_Action.TabIndex = 23
        Me.Tbx_Action.Text = ""
        '
        'Cmb_RespAction
        '
        Me.Cmb_RespAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_RespAction.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_RespAction.FormattingEnabled = True
        Me.Cmb_RespAction.Location = New System.Drawing.Point(223, 383)
        Me.Cmb_RespAction.Name = "Cmb_RespAction"
        Me.Cmb_RespAction.Size = New System.Drawing.Size(294, 26)
        Me.Cmb_RespAction.TabIndex = 24
        '
        'Dtp_Delai
        '
        Me.Dtp_Delai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtp_Delai.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Delai.Location = New System.Drawing.Point(223, 433)
        Me.Dtp_Delai.Name = "Dtp_Delai"
        Me.Dtp_Delai.Size = New System.Drawing.Size(294, 27)
        Me.Dtp_Delai.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 40)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Objectif"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 270)
        Me.Label2.Name = "Label2"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label2, 2)
        Me.Label2.Size = New System.Drawing.Size(194, 90)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Action"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 30)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Responsable action"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 430)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 30)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Delai"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label6, 4)
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(537, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 40)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Statut PDCA"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmb_StatutPDCA
        '
        Me.Cmb_StatutPDCA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_StatutPDCA.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_StatutPDCA.FormattingEnabled = True
        Me.Cmb_StatutPDCA.Items.AddRange(New Object() {"P", "D", "C", "A"})
        Me.Cmb_StatutPDCA.Location = New System.Drawing.Point(737, 273)
        Me.Cmb_StatutPDCA.Name = "Cmb_StatutPDCA"
        Me.Cmb_StatutPDCA.Size = New System.Drawing.Size(294, 26)
        Me.Cmb_StatutPDCA.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label7, 4)
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(537, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 50)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Date solde"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dtp_DateSolde
        '
        Me.Dtp_DateSolde.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtp_DateSolde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_DateSolde.Location = New System.Drawing.Point(737, 313)
        Me.Dtp_DateSolde.Name = "Dtp_DateSolde"
        Me.Dtp_DateSolde.Size = New System.Drawing.Size(294, 27)
        Me.Dtp_DateSolde.TabIndex = 13
        '
        'BtnValider
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.BtnValider, 3)
        Me.BtnValider.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnValider.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValider.Location = New System.Drawing.Point(567, 433)
        Me.BtnValider.Name = "BtnValider"
        Me.TableLayoutPanel1.SetRowSpan(Me.BtnValider, 2)
        Me.BtnValider.Size = New System.Drawing.Size(164, 44)
        Me.BtnValider.TabIndex = 30
        Me.BtnValider.Text = "Créer"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'FrmAjoutAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 511)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1070, 550)
        Me.Name = "FrmAjoutAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Entretiens Individuels - Ajouter des actions"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label_Collaborateur As Label
    Friend WithEvents Label_Entretien As Label
    Friend WithEvents Cmb_Collaborateur As ComboBox
    Friend WithEvents Cmb_Entretien As ComboBox
    Friend WithEvents Label_Titre As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Tbx_SuiviCom As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Dtp_DateSolde As DateTimePicker
    Friend WithEvents Cmb_StatutPDCA As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Tbx_Objectif As RichTextBox
    Friend WithEvents Tbx_Action As RichTextBox
    Friend WithEvents Cmb_RespAction As ComboBox
    Friend WithEvents Dtp_Delai As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnValider As Button
End Class
