<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cardno
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
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label6 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 17)
        Label1.TabIndex = 0
        Label1.Text = "Card Number"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(14, 158)
        TextBox1.MaxLength = 16
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(209, 25)
        TextBox1.TabIndex = 1
        TextBox1.Tag = "Enter the valid Card Number"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(274, 366)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 26)
        Button1.TabIndex = 2
        Button1.Text = "PAY NOW"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 17)
        Label2.TabIndex = 3
        Label2.Text = "Cardholder Name"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(14, 237)
        DateTimePicker1.MinDate = New Date(2024, 3, 13, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(209, 25)
        DateTimePicker1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 17)
        Label3.TabIndex = 5
        Label3.Text = "Expiration Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(381, 45)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 17)
        Label4.TabIndex = 6
        Label4.Text = "Payment Amount"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(381, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 17)
        Label5.TabIndex = 7
        Label5.Text = "CVV"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(14, 66)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(209, 25)
        TextBox2.TabIndex = 8
        TextBox2.Tag = "Enter the Cardholder Name"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(381, 237)
        TextBox3.MaxLength = 3
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(114, 25)
        TextBox3.TabIndex = 9
        TextBox3.Tag = "Enter the CVV Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.Window
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(381, 69)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 20)
        Label6.TabIndex = 10
        Label6.Text = "Label6"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Cardno
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(914, 510)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "Cardno"
        Text = "Form3"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
