<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CusDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtb1 = New TextBox()
        txtb2 = New TextBox()
        txtb3 = New TextBox()
        txtb4 = New TextBox()
        Button1 = New Button()
        Label7 = New Label()
        cmb2 = New ComboBox()
        dtp = New DateTimePicker()
        txtb5 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        cmb1 = New ComboBox()
        Label9 = New Label()
        pintxt = New TextBox()
        Label10 = New Label()
        citycmb = New ComboBox()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(51, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 0
        Label1.Text = "FNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(51, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 15)
        Label2.TabIndex = 1
        Label2.Text = "LNAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(51, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 2
        Label3.Text = "EMAIL"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(51, 260)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 3
        Label4.Text = "MOBNO"
        ' 
        ' txtb1
        ' 
        txtb1.Location = New Point(58, 41)
        txtb1.Name = "txtb1"
        txtb1.Size = New Size(151, 23)
        txtb1.TabIndex = 4
        txtb1.Tag = "Please enter Your First name"
        ' 
        ' txtb2
        ' 
        txtb2.Location = New Point(58, 98)
        txtb2.Name = "txtb2"
        txtb2.Size = New Size(151, 23)
        txtb2.TabIndex = 5
        txtb2.Tag = "Please enter Your Last name"
        ' 
        ' txtb3
        ' 
        txtb3.Enabled = False
        txtb3.Location = New Point(58, 220)
        txtb3.Name = "txtb3"
        txtb3.Size = New Size(151, 23)
        txtb3.TabIndex = 6
        ' 
        ' txtb4
        ' 
        txtb4.Location = New Point(58, 278)
        txtb4.Name = "txtb4"
        txtb4.Size = New Size(151, 23)
        txtb4.TabIndex = 7
        txtb4.Tag = "Please enter Your Mobile Number"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(248, 337)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "PROCEED"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(51, 141)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 15)
        Label7.TabIndex = 13
        Label7.Text = "Gender"
        ' 
        ' cmb2
        ' 
        cmb2.FormattingEnabled = True
        cmb2.Items.AddRange(New Object() {"03:00 AM", "03:15 AM", "03:30 AM", "03:45 AM", "04:00 AM", "04:15 AM", "04:30 AM", "04:45 AM", "05:00 AM", "05:15 AM", "05:30 AM", "05:45 AM", "06:00 AM", "06:15 AM", "06:30 AM", "06:45 AM", "07:00 AM", "07:15 AM", "07:30 AM", "07:45 AM", "08:00 AM", "08:15 AM", "08:30 AM", "08:45 AM", "09:00 AM", "09:15 AM", "09:30 AM", "09:45 AM", "10:00 AM", "10:15 AM", "10:30 AM", "10:45 AM", "11:00 AM", "11:15 AM", "11:30 AM", "11:45 AM", "12:00 PM", "12:15 PM", "12:30 PM", "12:45 PM", "01:00 PM", "01:15 PM", "01:30 PM", "01:45 PM", "02:00 PM", "02:15 PM", "02:30 PM", "02:45 PM", "03:00 PM", "03:15 PM", "03:30 PM", "03:45 PM", "04:00 PM", "04:15 PM", "04:30 PM", "04:45 PM", "05:00 PM", "05:15 PM", "05:30 PM", "05:45 PM", "06:00 PM"})
        cmb2.Location = New Point(450, 278)
        cmb2.Name = "cmb2"
        cmb2.Size = New Size(174, 23)
        cmb2.TabIndex = 27
        cmb2.Tag = "Please select your Pick up Time"
        ' 
        ' dtp
        ' 
        dtp.Location = New Point(450, 220)
        dtp.MinDate = New Date(2024, 3, 13, 0, 0, 0, 0)
        dtp.Name = "dtp"
        dtp.Size = New Size(174, 23)
        dtp.TabIndex = 26
        dtp.Value = New Date(2024, 3, 13, 9, 11, 11, 0)
        ' 
        ' txtb5
        ' 
        txtb5.Location = New Point(450, 41)
        txtb5.Name = "txtb5"
        txtb5.Size = New Size(174, 23)
        txtb5.TabIndex = 25
        txtb5.Tag = "Please enter Your Pick up Location"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(439, 260)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 15)
        Label5.TabIndex = 24
        Label5.Text = "Pick up Time"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(439, 202)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 15)
        Label6.TabIndex = 23
        Label6.Text = "Pick up Date"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(439, 23)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 15)
        Label8.TabIndex = 22
        Label8.Text = "Pick up location"
        ' 
        ' cmb1
        ' 
        cmb1.FormattingEnabled = True
        cmb1.Items.AddRange(New Object() {"Male", "Female", "Other"})
        cmb1.Location = New Point(58, 159)
        cmb1.Name = "cmb1"
        cmb1.Size = New Size(151, 23)
        cmb1.TabIndex = 28
        cmb1.Tag = "Please select your Gender"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(439, 80)
        Label9.Name = "Label9"
        Label9.Size = New Size(28, 15)
        Label9.TabIndex = 29
        Label9.Text = "City"
        ' 
        ' pintxt
        ' 
        pintxt.Location = New Point(450, 159)
        pintxt.Name = "pintxt"
        pintxt.Size = New Size(174, 23)
        pintxt.TabIndex = 30
        pintxt.Tag = "Please enter your City Pincode"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(439, 141)
        Label10.Name = "Label10"
        Label10.Size = New Size(54, 15)
        Label10.TabIndex = 31
        Label10.Text = "Pin code"
        ' 
        ' citycmb
        ' 
        citycmb.FormattingEnabled = True
        citycmb.Items.AddRange(New Object() {"Chennai", "Madurai", "Pondicherry", "Kanyakumari", "Ooty"})
        citycmb.Location = New Point(450, 98)
        citycmb.Name = "citycmb"
        citycmb.Size = New Size(174, 23)
        citycmb.TabIndex = 32
        citycmb.Tag = "Please select your City"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' CusDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(800, 450)
        Controls.Add(citycmb)
        Controls.Add(Label10)
        Controls.Add(pintxt)
        Controls.Add(Label9)
        Controls.Add(cmb1)
        Controls.Add(cmb2)
        Controls.Add(dtp)
        Controls.Add(txtb5)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(txtb4)
        Controls.Add(txtb3)
        Controls.Add(txtb2)
        Controls.Add(txtb1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Name = "CusDetails"
        Text = "Form5"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtb1 As TextBox
    Friend WithEvents txtb2 As TextBox
    Friend WithEvents txtb3 As TextBox
    Friend WithEvents txtb4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb2 As ComboBox
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents txtb5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pintxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents citycmb As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
