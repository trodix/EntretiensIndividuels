Public Class UI_Accueil

    Property _authUser As ClsUtilisateur = Nothing

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Private Sub FrmMenu_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load

        If _authUser Is Nothing Then
            Me.Cursor = Cursors.Default
            End
        End If

        Me.Cursor = Cursors.Default

    End Sub

End Class
