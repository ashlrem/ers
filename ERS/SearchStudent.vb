﻿Imports MySql.Data.MySqlClient

Public Class SearchStudent

    Private Sub SearchStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim str As String = "server= '" & server & "';port= '" & port & "';userid= '" & user & "';password= '" & password & "';database='" & database & "'"
            Dim con As New MySqlConnection(str)
            Dim com As String = "Select Student_ID_No, LastName, GivenName, MiddleName, Birthday, Gender, SchoolYear, GradeLevel, Section, MotherName, OccupationM from student_info"
            Dim Adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()
            Adpt.Fill(ds, "student_info")
        DataGridView1.DataSource = ds.Tables(0)
        Dim studentCount As Integer
        studentCount = DataGridView1.RowCount
            Dim column As DataGridViewColumn = DataGridView1.Columns(0)
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        lblNoOfStudent.Text = studentCount
    End Sub

    Private Sub filterText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filterText.TextChanged
        If (filterBox.SelectedItem = "") Then
        ElseIf filterBox.SelectedItem = "GradeLevel" Or filterBox.SelectedItem = "Section" Then

            Dim selected As String = filterBox.SelectedItem.ToString
            Dim str As String = "server= '" & server & "';port= '" & port & "';userid= '" & user & "';password= '" & password & "';database='" & database & "'"
            Dim con As New MySqlConnection(str)
            'Dim com As String = "select * From student_info where Student_ID_No like'%" & filterText.Text & "%'"
            Dim com As String = "select Student_ID_No, LastName, GivenName, MiddleName, Birthday, Gender, SchoolYear, GradeLevel, Section, MotherName, OccupationM From student_info where " & selected & " like'%" & filterText.Text & "%'"
            Dim Adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()
            Adpt.Fill(ds, "student_info")
            DataGridView1.DataSource = ds.Tables(0)
            Dim studentCount As Integer
            studentCount = DataGridView1.RowCount
            Dim column As DataGridViewColumn = DataGridView1.Columns(0)
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            lblNoOfStudent.Text = studentCount
        Else
            Dim selected As String = filterBox.SelectedItem.ToString
            Dim str As String = "server= '" & server & "';port= '" & port & "';userid= '" & user & "';password= '" & password & "';database='" & database & "'"
            Dim con As New MySqlConnection(str)
            'Dim com As String = "select * From student_info where Student_ID_No like'%" & filterText.Text & "%'"
            Dim com As String = "select Student_ID_No, LastName, GivenName, MiddleName, Birthday, Gender, SchoolYear, GradeLevel, Section, MotherName, OccupationM From student_info where " & selected & " like'%" & filterText.Text & "%'"
            Dim Adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()
            Adpt.Fill(ds, "student_info")
            DataGridView1.DataSource = ds.Tables(0)
            Dim column As DataGridViewColumn = DataGridView1.Columns(0)
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Forms.AdminPanel.empl.Text = "" Then
            RegistrarPanel.Show()
            Screen_Registrar.Show()
            Me.Close()
        ElseIf My.Forms.CashierPanel.empl.Text = "" Then
            AdminPanel.Show()
            Screen_Admin.Show()
            Me.Close()
        End If
    End Sub
End Class