Imports System.Data.SqlClient

Public Class Login
    Dim mycon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TravelAdvisor;Integrated Security=True;Pooling=False")
    Public loginemail As String
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ErrorProvider1.SetError(ctl(i), ctl(i).tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtb1.Text = "" And txtb2.Text = "" Then
            MessageBox.Show("Please enter the Email Id and Password")
            txtb1.Focus()
            Exit Sub
        ElseIf vld(txtb1, txtb2) = False Then
            Exit Sub
        End If
        mycon.Open()
        Dim mycmd As New SqlCommand("Select * from register where email= '" & txtb1.Text & "' And pswd = '" & txtb2.Text & "'", mycon)
        Dim myread As SqlDataReader = mycmd.ExecuteReader
        If myread.Read Then
            MsgBox("Welcome Back To TRAVEL ADVISOR")
            CusDetails.txtb3.Text = txtb1.Text
            txtb1.Clear()
            txtb2.Clear()
            Me.Hide()
            userPage.Show()
        Else
            MsgBox("Invalid Email or Password")
            mycon.Close()
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SignUp.Show()
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtb2.UseSystemPasswordChar = False
        Else
            txtb2.UseSystemPasswordChar = True
        End If
    End Sub
End Class
