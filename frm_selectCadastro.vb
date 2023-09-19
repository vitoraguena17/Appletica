Imports System.Windows

Public Class frm_selectCadastro
    Private Sub btn_selectLogin_Click(sender As Object, e As EventArgs) Handles btn_selectLogin.Click
        frm_entrar.Visible = True
        Me.Close()
    End Sub

    Private Sub btn_selectAluno_Click(sender As Object, e As EventArgs) Handles btn_selectAluno.Click
        frm_cadastroAluno.Visible = True
        Me.Close()
    End Sub

    Private Sub btn_selectAtletica_Click(sender As Object, e As EventArgs) Handles btn_selectAtletica.Click
        frm_cadastrarAtletica.Visible = True
        Me.Close()
    End Sub

End Class