<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Accueil
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
        Me.Label_Titre = New System.Windows.Forms.Label()
        Me.TLP_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLP_Main
        '
        Me.TLP_Main.BackColor = System.Drawing.Color.Transparent
        Me.TLP_Main.ColumnCount = 3
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.Controls.Add(Me.Label_Titre, 1, 1)
        Me.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Main.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Main.Name = "TLP_Main"
        Me.TLP_Main.RowCount = 3
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.Size = New System.Drawing.Size(875, 618)
        Me.TLP_Main.TabIndex = 3
        '
        'Label_Titre
        '
        Me.Label_Titre.AutoSize = True
        Me.Label_Titre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Titre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Titre.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titre.Location = New System.Drawing.Point(23, 20)
        Me.Label_Titre.Name = "Label_Titre"
        Me.Label_Titre.Size = New System.Drawing.Size(829, 40)
        Me.Label_Titre.TabIndex = 0
        Me.Label_Titre.Text = "Accueil"
        Me.Label_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UC_Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TLP_Main)
        Me.Name = "UC_Accueil"
        Me.Size = New System.Drawing.Size(875, 618)
        Me.TLP_Main.ResumeLayout(False)
        Me.TLP_Main.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TLP_Main As TableLayoutPanel
    Friend WithEvents Label_Titre As Label
End Class
