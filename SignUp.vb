Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Imports System.Text.RegularExpressions
Public Class SignUp
    Dim mycon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TravelAdvisor;Integrated Security=True;Pooling=False")
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
        If txtb1.Text = "" And txtb2.Text = "" And txtb3.Text = "" And txtb4.Text = "" Then
            MessageBox.Show("Please enter all the fields")
            txtb1.Focus()
            Exit Sub
        ElseIf vld(txtb1, txtb2, txtb3, txtb4) = False Then
            Exit Sub
        ElseIf txtb3.Text.Contains("@") And txtb3.Text.Contains(".com") Then
            mycon.Open()
            Dim mycmd As New SqlCommand("Insert into register(fname,lname,email,pswd) Values ('" & txtb1.Text & "','" & txtb2.Text & "','" & txtb3.Text & "','" & txtb4.Text & "')", mycon)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("Your account has been created successfully")
                Me.Hide()
                userPage.Show()
                CusDetails.txtb3.Text = txtb3.Text
            Catch ex As Exception
                MsgBox("This email id already exist !")
                Me.Show()
            End Try
            mycon.Close()
            Exit Sub
        Else
            MsgBox("Please enter a valid email address")
            Me.Show()
            Exit Sub
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtb4.UseSystemPasswordChar = False
        Else
            txtb4.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        Login.Show()
    End Sub
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub txtb1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtb1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            ErrorProvider1.SetError(txtb1, "Please enter only letters")
        End If
    End Sub
    Private Sub txtb2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtb2.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            ErrorProvider1.SetError(txtb2, "Check your name correctly")
        End If
    End Sub
End Class