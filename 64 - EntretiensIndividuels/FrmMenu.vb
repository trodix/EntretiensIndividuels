Public Class FrmMenu


    Private Sub FrmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Entretiens_Click(sender As Object, e As EventArgs) Handles Btn_Entretiens.Click
        Dim _f As New FrmMesEntretiens
        _f.Show()
        Close()
    End Sub

    Private Sub Btn_Equipe_Click(sender As Object, e As EventArgs) Handles Btn_Equipe.Click
        Dim _f As New FrmMonEquipe
        _f.Show()
        Close()
    End Sub

    Private Sub BtnAjoutEntretien_Click(sender As Object, e As EventArgs)
        Dim _f As New FrmAjoutEntretien
        _f.Show()
        Close()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    'Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)
    '    'MessageBox.Show(e.Node.Name)
    '    If e.Node.Name = "Node_Ent" Then
    '        Dim _FrmMesEntretiens As New FrmMesEntretiens
    '        _FrmMesEntretiens.ShowDialog()
    '    ElseIf e.Node.Name = "Node_Action" Then
    '        Dim _FrmMonEquipe As New FrmMesEntretiens
    '        _FrmMonEquipe.ShowDialog()
    '    ElseIf e.Node.Name = "Node_CreerEnt" Then
    '        Dim _FrmAjoutEntretien As New FrmAjoutEntretien
    '        FrmAjoutEntretien.ShowDialog()
    '    ElseIf e.Node.Name = "Node_CreerAction" Then
    '        Dim _FrmAjoutEntretien As New FrmAjoutEntretien
    '        FrmAjoutEntretien.ShowDialog()
    '    End If


    'End Sub
End Class
