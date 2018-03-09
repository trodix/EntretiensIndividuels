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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Titre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmb_Collaborateur = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Dtp_DateEntretien = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_DateEntretienSuivi = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Fichier = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.03922!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.960784!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Titre, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Cmb_Collaborateur, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnValider, 2, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Dtp_DateEntretien, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Dtp_DateEntretienSuivi, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Fichier, 2, 9)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 14
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(563, 412)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'Label_Titre
        '
        Me.Label_Titre.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label_Titre, 3)
        Me.Label_Titre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Titre.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titre.Location = New System.Drawing.Point(23, 20)
        Me.Label_Titre.Name = "Label_Titre"
        Me.Label_Titre.Size = New System.Drawing.Size(507, 40)
        Me.Label_Titre.TabIndex = 0
        Me.Label_Titre.Text = "Créer un entretien"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date entretien"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmb_Collaborateur
        '
        Me.Cmb_Collaborateur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_Collaborateur.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Collaborateur.FormattingEnabled = True
        Me.Cmb_Collaborateur.Location = New System.Drawing.Point(232, 104)
        Me.Cmb_Collaborateur.Name = "Cmb_Collaborateur"
        Me.Cmb_Collaborateur.Size = New System.Drawing.Size(294, 26)
        Me.Cmb_Collaborateur.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date entretien suivi"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Document"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnValider
        '
        Me.BtnValider.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnValider.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValider.Location = New System.Drawing.Point(232, 304)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(294, 44)
        Me.BtnValider.TabIndex = 4
        Me.BtnValider.Text = "Créer"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 30)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Collaborateur"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dtp_DateEntretien
        '
        Me.Dtp_DateEntretien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtp_DateEntretien.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_DateEntretien.Location = New System.Drawing.Point(232, 154)
        Me.Dtp_DateEntretien.Name = "Dtp_DateEntretien"
        Me.Dtp_DateEntretien.Size = New System.Drawing.Size(294, 27)
        Me.Dtp_DateEntretien.TabIndex = 6
        '
        'Dtp_DateEntretienSuivi
        '
        Me.Dtp_DateEntretienSuivi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtp_DateEntretienSuivi.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_DateEntretienSuivi.Location = New System.Drawing.Point(232, 204)
        Me.Dtp_DateEntretienSuivi.Name = "Dtp_DateEntretienSuivi"
        Me.Dtp_DateEntretienSuivi.Size = New System.Drawing.Size(294, 27)
        Me.Dtp_DateEntretienSuivi.TabIndex = 7
        '
        'Btn_Fichier
        '
        Me.Btn_Fichier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Fichier.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Fichier.Location = New System.Drawing.Point(232, 254)
        Me.Btn_Fichier.Name = "Btn_Fichier"
        Me.Btn_Fichier.Size = New System.Drawing.Size(294, 24)
        Me.Btn_Fichier.TabIndex = 8
        Me.Btn_Fichier.Text = "Sélectionner"
        Me.Btn_Fichier.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmAjoutEntretien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 412)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAjoutEntretien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Entretiens Individuels - Ajouter des entretiens"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Cmb_Collaborateur As ComboBox
    Friend WithEvents Label_Titre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnValider As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Dtp_DateEntretien As DateTimePicker
    Friend WithEvents Dtp_DateEntretienSuivi As DateTimePicker
    Friend WithEvents Btn_Fichier As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
