<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Label4 = New Label()
        txtb1 = New TextBox()
        txtb3 = New TextBox()
        txtb4 = New TextBox()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        Label5 = New Label()
        txtb2 = New TextBox()
        Label3 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(329, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 17)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(326, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 17)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(326, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 17)
        Label4.TabIndex = 3
        Label4.Text = "Password"
        ' 
        ' txtb1
        ' 
        txtb1.Location = New Point(352, 42)
        txtb1.Name = "txtb1"
        txtb1.Size = New Size(114, 25)
        txtb1.TabIndex = 4
        txtb1.Tag = "Please enter your First name"
        ' 
        ' txtb3
        ' 
        txtb3.Location = New Point(352, 143)
        txtb3.Name = "txtb3"
        txtb3.Size = New Size(114, 25)
        txtb3.TabIndex = 5
        txtb3.Tag = "Please enter your email address"
        ' 
        ' txtb4
        ' 
        txtb4.Location = New Point(352, 204)
        txtb4.Name = "txtb4"
        txtb4.Size = New Size(114, 25)
        txtb4.TabIndex = 7
        txtb4.Tag = "Please enter the Password"
        txtb4.UseSystemPasswordChar = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.SaddleBrown
        CheckBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = SystemColors.ActiveCaptionText
        CheckBox1.Location = New Point(352, 226)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(118, 21)
        CheckBox1.TabIndex = 8
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(394, 297)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 26)
        Button1.TabIndex = 9
        Button1.Text = "Sign up"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.Lavender
        LinkLabel1.Location = New Point(498, 341)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(43, 15)
        LinkLabel1.TabIndex = 10
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Login" & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(329, 78)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 17)
        Label5.TabIndex = 11
        Label5.Text = "Last Name"
        ' 
        ' txtb2
        ' 
        txtb2.Location = New Point(352, 94)
        txtb2.Name = "txtb2"
        txtb2.Size = New Size(114, 25)
        txtb2.TabIndex = 12
        txtb2.Tag = "Please enter your Last name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(329, 341)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 17)
        Label3.TabIndex = 13
        Label3.Text = "Already have an account?"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(914, 510)
        Controls.Add(Label3)
        Controls.Add(txtb2)
        Controls.Add(Label5)
        Controls.Add(LinkLabel1)
        Controls.Add(Button1)
        Controls.Add(CheckBox1)
        Controls.Add(txtb4)
        Controls.Add(txtb3)
        Controls.Add(txtb1)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "SignUp"
        Text = "SignUp"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtb1 As TextBox
    Friend WithEvents txtb3 As TextBox
    Friend WithEvents txtb4 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtb2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
