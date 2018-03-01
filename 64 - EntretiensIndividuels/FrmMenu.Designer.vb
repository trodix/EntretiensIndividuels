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
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TLP_Main = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Titre = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel1.SuspendLayout()
        Me.TLP_Menu.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TLP_Main.SuspendLayout()
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
        Me.TLP_Menu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLP_Menu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Menu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Menu.Size = New System.Drawing.Size(241, 671)
        Me.TLP_Menu.TabIndex = 0
        '
        'Btn_Accueil
        '
        Me.Btn_Accueil.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(222, Byte), Integer))
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
        Me.Btn_Accueil.TabIndex = 7
        Me.Btn_Accueil.Text = "Accueil"
        Me.Btn_Accueil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Accueil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Accueil.UseVisualStyleBackColor = False
        '
        'Btn_Entretiens
        '
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
        Me.Btn_Entretiens.TabIndex = 0
        Me.Btn_Entretiens.Text = "Mes entretiens"
        Me.Btn_Entretiens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Entretiens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Entretiens.UseVisualStyleBackColor = True
        '
        'Btn_Equipe
        '
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
        Me.Btn_Equipe.TabIndex = 1
        Me.Btn_Equipe.Text = "Mon équipe"
        Me.Btn_Equipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Equipe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Equipe.UseVisualStyleBackColor = True
        '
        'Panel_Main
        '
        Me.Panel_Main.Controls.Add(Me.TabControl1)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Main.Location = New System.Drawing.Point(241, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(917, 671)
        Me.Panel_Main.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(917, 671)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TLP_Main)
        Me.TabPage1.Location = New System.Drawing.Point(4, 84)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(909, 583)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Accueil"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TLP_Main
        '
        Me.TLP_Main.ColumnCount = 3
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.Controls.Add(Me.Label_Titre, 1, 1)
        Me.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Main.Location = New System.Drawing.Point(3, 3)
        Me.TLP_Main.Name = "TLP_Main"
        Me.TLP_Main.RowCount = 3
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.Size = New System.Drawing.Size(903, 577)
        Me.TLP_Main.TabIndex = 2
        '
        'Label_Titre
        '
        Me.Label_Titre.AutoSize = True
        Me.Label_Titre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Titre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Titre.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titre.Location = New System.Drawing.Point(23, 20)
        Me.Label_Titre.Name = "Label_Titre"
        Me.Label_Titre.Size = New System.Drawing.Size(857, 40)
        Me.Label_Titre.TabIndex = 0
        Me.Label_Titre.Text = "Accueil"
        Me.Label_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 84)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(909, 583)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mes entretiens"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 84)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(909, 583)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Mon équipe"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 671)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMenu"
        Me.Text = "Entretiens Individuels - Accueil"
        Me.Panel1.ResumeLayout(False)
        Me.TLP_Menu.ResumeLayout(False)
        Me.Panel_Main.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TLP_Main.ResumeLayout(False)
        Me.TLP_Main.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TLP_Menu As TableLayoutPanel
    Friend WithEvents Btn_Entretiens As Button
    Friend WithEvents Btn_Equipe As Button
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Btn_Accueil As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TLP_Main As TableLayoutPanel
    Friend WithEvents Label_Titre As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
End Class
