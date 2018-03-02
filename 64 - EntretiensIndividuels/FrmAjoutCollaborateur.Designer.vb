<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjoutCollaborateur
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Titre = New System.Windows.Forms.Label()
        Me.Tbx_LibColl = New System.Windows.Forms.TextBox()
        Me.Cmb_Manager = New System.Windows.Forms.ComboBox()
        Me.Cmb_Service = New System.Windows.Forms.ComboBox()
        Me.Cmb_Statut = New System.Windows.Forms.ComboBox()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Titre, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Tbx_LibColl, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Cmb_Manager, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Cmb_Service, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Cmb_Statut, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnValider, 2, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 9)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(475, 385)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Label_Titre
        '
        Me.Label_Titre.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label_Titre, 3)
        Me.Label_Titre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Titre.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titre.Location = New System.Drawing.Point(23, 20)
        Me.Label_Titre.Name = "Label_Titre"
        Me.Label_Titre.Size = New System.Drawing.Size(427, 40)
        Me.Label_Titre.TabIndex = 1
        Me.Label_Titre.Text = "Créer un collaborateur"
        '
        'Tbx_LibColl
        '
        Me.Tbx_LibColl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbx_LibColl.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_LibColl.Location = New System.Drawing.Point(154, 90)
        Me.Tbx_LibColl.Name = "Tbx_LibColl"
        Me.Tbx_LibColl.Size = New System.Drawing.Size(294, 27)
        Me.Tbx_LibColl.TabIndex = 2
        '
        'Cmb_Manager
        '
        Me.Cmb_Manager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_Manager.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Manager.FormattingEnabled = True
        Me.Cmb_Manager.Location = New System.Drawing.Point(154, 140)
        Me.Cmb_Manager.Name = "Cmb_Manager"
        Me.Cmb_Manager.Size = New System.Drawing.Size(294, 26)
        Me.Cmb_Manager.TabIndex = 3
        '
        'Cmb_Service
        '
        Me.Cmb_Service.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_Service.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Service.FormattingEnabled = True
        Me.Cmb_Service.Location = New System.Drawing.Point(154, 190)
        Me.Cmb_Service.Name = "Cmb_Service"
        Me.Cmb_Service.Size = New System.Drawing.Size(294, 26)
        Me.Cmb_Service.TabIndex = 4
        '
        'Cmb_Statut
        '
        Me.Cmb_Statut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_Statut.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Statut.FormattingEnabled = True
        Me.Cmb_Statut.Location = New System.Drawing.Point(154, 240)
        Me.Cmb_Statut.Name = "Cmb_Statut"
        Me.Cmb_Statut.Size = New System.Drawing.Size(294, 26)
        Me.Cmb_Statut.TabIndex = 5
        '
        'BtnValider
        '
        Me.BtnValider.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnValider.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValider.Location = New System.Drawing.Point(154, 290)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(294, 44)
        Me.BtnValider.TabIndex = 6
        Me.BtnValider.Text = "Créer"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NOM Prénom"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Manager"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Service"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 30)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Statut"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmAjoutCollaborateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 385)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmAjoutCollaborateur"
        Me.Text = "Entretiens Individuels - Ajouter des collaborateurs"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label_Titre As Label
    Friend WithEvents Tbx_LibColl As TextBox
    Friend WithEvents Cmb_Manager As ComboBox
    Friend WithEvents Cmb_Service As ComboBox
    Friend WithEvents Cmb_Statut As ComboBox
    Friend WithEvents BtnValider As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
