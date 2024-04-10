<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
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
        Me.components = New System.ComponentModel.Container()
        Me.btnexit = New Guna.UI2.WinForms.Guna2Button()
        Me.UseraccounttbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OhmysalondbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OhmysalondbDataSet = New UmayFinalOOP.ohmysalondbDataSet()
        Me.UseraccounttbTableAdapter = New UmayFinalOOP.ohmysalondbDataSetTableAdapters.useraccounttbTableAdapter()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.UseraccounttbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OhmysalondbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OhmysalondbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Transparent
        Me.btnexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnexit.FillColor = System.Drawing.Color.Transparent
        Me.btnexit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Location = New System.Drawing.Point(1158, -4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.PressedColor = System.Drawing.Color.Red
        Me.btnexit.Size = New System.Drawing.Size(57, 39)
        Me.btnexit.TabIndex = 0
        Me.btnexit.Text = "X"
        '
        'UseraccounttbBindingSource
        '
        Me.UseraccounttbBindingSource.DataMember = "useraccounttb"
        Me.UseraccounttbBindingSource.DataSource = Me.OhmysalondbDataSetBindingSource
        '
        'OhmysalondbDataSetBindingSource
        '
        Me.OhmysalondbDataSetBindingSource.DataSource = Me.OhmysalondbDataSet
        Me.OhmysalondbDataSetBindingSource.Position = 0
        '
        'OhmysalondbDataSet
        '
        Me.OhmysalondbDataSet.DataSetName = "ohmysalondbDataSet"
        Me.OhmysalondbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UseraccounttbTableAdapter
        '
        Me.UseraccounttbTableAdapter.ClearBeforeFill = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1366, 100)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Guna2Panel2.Location = New System.Drawing.Point(6, 106)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(233, 658)
        Me.Guna2Panel2.TabIndex = 2
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.DimGray
        Me.pnlMain.Location = New System.Drawing.Point(245, 106)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1115, 657)
        Me.pnlMain.TabIndex = 2
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btnexit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UseraccounttbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OhmysalondbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OhmysalondbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnexit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OhmysalondbDataSetBindingSource As BindingSource
    Friend WithEvents OhmysalondbDataSet As ohmysalondbDataSet
    Friend WithEvents UseraccounttbBindingSource As BindingSource
    Friend WithEvents UseraccounttbTableAdapter As ohmysalondbDataSetTableAdapters.useraccounttbTableAdapter
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
End Class
