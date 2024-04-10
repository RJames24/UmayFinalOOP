<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.txtun = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpw = New Guna.UI2.WinForms.Guna2TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btblogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.SuspendLayout()
        '
        'txtun
        '
        Me.txtun.BackColor = System.Drawing.Color.Transparent
        Me.txtun.BorderRadius = 10
        Me.txtun.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtun.DefaultText = ""
        Me.txtun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtun.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtun.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtun.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtun.Location = New System.Drawing.Point(67, 254)
        Me.txtun.Name = "txtun"
        Me.txtun.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtun.PlaceholderText = ""
        Me.txtun.SelectedText = ""
        Me.txtun.Size = New System.Drawing.Size(182, 24)
        Me.txtun.TabIndex = 0
        '
        'txtpw
        '
        Me.txtpw.BackColor = System.Drawing.Color.Transparent
        Me.txtpw.BorderRadius = 10
        Me.txtpw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpw.DefaultText = ""
        Me.txtpw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpw.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpw.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpw.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpw.Location = New System.Drawing.Point(67, 300)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpw.PlaceholderText = ""
        Me.txtpw.SelectedText = ""
        Me.txtpw.Size = New System.Drawing.Size(182, 24)
        Me.txtpw.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(69, 238)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(60, 15)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(69, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'btblogin
        '
        Me.btblogin.BorderRadius = 10
        Me.btblogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btblogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btblogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btblogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btblogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btblogin.FillColor = System.Drawing.Color.Gray
        Me.btblogin.FillColor2 = System.Drawing.Color.Black
        Me.btblogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btblogin.ForeColor = System.Drawing.Color.White
        Me.btblogin.Location = New System.Drawing.Point(67, 342)
        Me.btblogin.Name = "btblogin"
        Me.btblogin.Size = New System.Drawing.Size(182, 31)
        Me.btblogin.TabIndex = 2
        Me.btblogin.Text = "Login"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(309, 460)
        Me.Controls.Add(Me.btblogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtpw)
        Me.Controls.Add(Me.txtun)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtun As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpw As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btblogin As Guna.UI2.WinForms.Guna2GradientButton
End Class
