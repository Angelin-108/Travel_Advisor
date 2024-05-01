Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.ComponentModel
Public Class CusDetails
    Public currentIndex As Integer
    Public cdt As String
    Public dts As String
    Public rantm As String
    Public ploc As String
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
        If txtb1.Text = "" And txtb2.Text = "" And txtb3.Text = "" And txtb4.Text = "" And txtb5.Text = "" And pintxt.Text = "" And citycmb.SelectedItem = "" And cmb1.SelectedItem = "" And cmb2.SelectedItem = "" Then
            MessageBox.Show("Please enter all the details")
            Exit Sub
        ElseIf vld(txtb1, txtb2, txtb3, txtb4, txtb5, pintxt, citycmb, cmb1, cmb2) = False Then
            Exit Sub
        End If
        'If txtb1.Text = "" Then
        'MessageBox.Show("Please enter Your First name")
        'txtb1.Focus()
        'Exit Sub
        'End If
        Me.Hide()
        GuideDetails.Show()
        ploc = txtb5.Text + citycmb.Text + pintxt.Text
        cdt = TravelDetails.cmb2.SelectedItem + "|" + dtp.Text + "|" + cmb2.Text
        GuideDetails.Label2.Text = cdt
        dts = dtp.Text + " before 30 minutes from the Pick up Time "
        GuideDetails.Label2.Text = cdt
        GuideDetails.Label10.Text = dts
        GuideDetails.Label5.Text = TravelDetails.cmb3.Text
        GuideDetails.Label3.Text = TravelDetails.cmb4.SelectedItem
        GuideDetails.Label13.Text = TravelDetails.mul
        Cardno.Label6.Text = TravelDetails.mul
        GuideDetails.Label4.Text = TravelDetails.selectedVal
    End Sub
    Private Sub CusDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub txtb4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtb4.KeyPress
        Dim allowednos As String = "0123456789"
        If Not allowednos.Contains(e.KeyChar.ToString.ToLower) And txtb4.TextLength < 10 Then
            MsgBox("Invalid Mobile Number! Check your Mobile Number")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub
    Private Sub txtb2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtb2.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Please check your Last Name")
        End If
    End Sub
    Private Sub txtb1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtb1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Please check your First Name")
        End If
    End Sub
    Private Sub pintxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pintxt.KeyPress
        Dim allowednos As String = "0123456789"
        If Not allowednos.Contains(e.KeyChar.ToString.ToLower) Then
            MsgBox("Invalid Pincode! Check the Pincode")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub dtp_Validating(sender As Object, e As CancelEventArgs) Handles dtp.Validating
        If dtp.Value < DateTime.Now.ToShortDateString Then
            MessageBox.Show("Please check the Expiration Date")
            e.Cancel = True
        End If
    End Sub
End Class