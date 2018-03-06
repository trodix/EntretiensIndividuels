<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TLP_Menu = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Accueil = New System.Windows.Forms.Button()
        Me.Btn_Entretiens = New System.Windows.Forms.Button()
        Me.Btn_Equipe = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_AjoutAction = New System.Windows.Forms.Button()
        Me.Btn_AjoutEntretien = New System.Windows.Forms.Button()
        Me.Btn_AjoutCollab = New System.Windows.Forms.Button()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.TLP_Menu.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TLP_Menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 671)
        Me.Panel1.TabIndex = 0
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
        Me.TLP_Menu.Size = New System.Drawing.Size(241, 671)
        Me.TLP_Menu.TabIndex = 3
        '
        'Btn_Accueil
        '
        Me.Btn_Accueil.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(222, Byte), Integer))
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
        Me.Btn_Accueil.UseVisualStyleBackColor = False
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
        Me.Btn_Equipe.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(194, 475)
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
        Me.Btn_AjoutCollab.Visible = False
        '
        'Panel_Main
        '
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Main.Location = New System.Drawing.Point(241, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(917, 671)
        Me.Panel_Main.TabIndex = 1
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 671)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entretiens Individuels - Accueil"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.TLP_Menu.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents TLP_Menu As TableLayoutPanel
    Friend WithEvents Btn_Accueil As Button
    Friend WithEvents Btn_Entretiens As Button
    Friend WithEvents Btn_Equipe As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Btn_AjoutAction As Button
    Friend WithEvents Btn_AjoutEntretien As Button
    Friend WithEvents Btn_AjoutCollab As Button
End Class
