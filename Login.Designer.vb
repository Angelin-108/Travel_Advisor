<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtb1 = New TextBox()
        txtb2 = New TextBox()
        Label3 = New Label()
        LinkLabel1 = New LinkLabel()
        CheckBox1 = New CheckBox()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(302, 200)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(208, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 15)
        Label1.TabIndex = 7
        Label1.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(208, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 8
        Label2.Text = "Password"
        ' 
        ' txtb1
        ' 
        txtb1.Location = New Point(302, 60)
        txtb1.Name = "txtb1"
        txtb1.Size = New Size(100, 23)
        txtb1.TabIndex = 9
        txtb1.Tag = "Please enter Your Email"
        ' 
        ' txtb2
        ' 
        txtb2.Location = New Point(302, 107)
        txtb2.Name = "txtb2"
        txtb2.Size = New Size(100, 23)
        txtb2.TabIndex = 10
        txtb2.Tag = "Please enter the Password"
        txtb2.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(246, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 15)
        Label3.TabIndex = 11
        Label3.Text = "Don't have an account?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(383, 244)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(109, 15)
        LinkLabel1.TabIndex = 12
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Create an Account"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(302, 136)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(112, 19)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "Show password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(800, 450)
        Controls.Add(CheckBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(Label3)
        Controls.Add(txtb2)
        Controls.Add(txtb1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Name = "Login"
        Tag = "Please enter your Email Id"
        Text = "Form1"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtb1 As TextBox
    Friend WithEvents txtb2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
