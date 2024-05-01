<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(325, 211)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(325, 259)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 1
        Button2.Text = "SignUp"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(457, 215)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 15)
        Label1.TabIndex = 2
        Label1.Text = "Already have and Account ?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(125, 263)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 15)
        Label2.TabIndex = 3
        Label2.Text = "Don't have an Account ?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(272, 263)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 4
        Label3.Text = "--->"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(421, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 15)
        Label4.TabIndex = 5
        Label4.Text = "<---"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(279, 69)
        Label5.Name = "Label5"
        Label5.Size = New Size(182, 27)
        Label5.TabIndex = 6
        Label5.Text = "TRAVEL ADVISOR"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(12, 45)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 7
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
End Class
