﻿Imports MySql.Data.MySqlClient
Public Class ViewClass
    Private Sub ViewSubject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        insert()
        Dim r As MySqlDataReader
        Dim reg As String = "SELECT Subject_Name FROM subject_tbl"
        cn.Open()
        Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
        r = cmd.ExecuteReader()
        If r.Read Then

            subj.Items.Clear()
            subj.Items.Add(r("Subject_Name").ToString())
            While (r.Read())
                subj.Items.Add(r("Subject_Name").ToString())
            End While
        Else
            MessageBox.Show("No subject Found")
        End If
    End Sub
    Private Sub SearchSubj_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cn.Close()
        SearchSubject_A_View_btn()
    End Sub
    Private Sub ViewClass_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Screen_Admin.Show()
        AdminPanel.Show()
    End Sub

    Private Sub SearchSubj_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSubj_btn.Click
        cn.Close()
        SearchSubject_A_View_btn()
    End Sub
End Class