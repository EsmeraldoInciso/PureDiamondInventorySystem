<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homePage
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnBrand = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.line = New System.Windows.Forms.Panel()
        Me.dgvHome = New System.Windows.Forms.DataGridView()
        Me.sidePanel.SuspendLayout()
        CType(Me.dgvHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.sidePanel.Controls.Add(Me.btnInventory)
        Me.sidePanel.Controls.Add(Me.btnBrand)
        Me.sidePanel.Controls.Add(Me.Label3)
        Me.sidePanel.Controls.Add(Me.Label2)
        Me.sidePanel.Controls.Add(Me.label1)
        Me.sidePanel.Location = New System.Drawing.Point(0, 0)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(281, 700)
        Me.sidePanel.TabIndex = 0
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnInventory.Location = New System.Drawing.Point(20, 624)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(240, 52)
        Me.btnInventory.TabIndex = 4
        Me.btnInventory.Text = "Inventory Items Module"
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'btnBrand
        '
        Me.btnBrand.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrand.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnBrand.Location = New System.Drawing.Point(21, 565)
        Me.btnBrand.Name = "btnBrand"
        Me.btnBrand.Size = New System.Drawing.Size(240, 52)
        Me.btnBrand.TabIndex = 3
        Me.btnBrand.Text = "Brand Module"
        Me.btnBrand.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(53, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Inventory System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mistral", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(101, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 48)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diamond"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label1.Location = New System.Drawing.Point(34, 65)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(75, 31)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Pure"
        '
        'line
        '
        Me.line.BackColor = System.Drawing.SystemColors.HighlightText
        Me.line.Location = New System.Drawing.Point(299, 22)
        Me.line.Name = "line"
        Me.line.Size = New System.Drawing.Size(1044, 2)
        Me.line.TabIndex = 1
        '
        'dgvHome
        '
        Me.dgvHome.AllowUserToAddRows = False
        Me.dgvHome.AllowUserToDeleteRows = False
        Me.dgvHome.AllowUserToOrderColumns = True
        Me.dgvHome.AllowUserToResizeColumns = False
        Me.dgvHome.AllowUserToResizeRows = False
        Me.dgvHome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHome.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHome.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHome.Location = New System.Drawing.Point(299, 44)
        Me.dgvHome.MultiSelect = False
        Me.dgvHome.Name = "dgvHome"
        Me.dgvHome.ReadOnly = True
        Me.dgvHome.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvHome.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHome.Size = New System.Drawing.Size(1044, 632)
        Me.dgvHome.TabIndex = 2
        '
        'homePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1362, 699)
        Me.Controls.Add(Me.dgvHome)
        Me.Controls.Add(Me.line)
        Me.Controls.Add(Me.sidePanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1378, 738)
        Me.MinimumSize = New System.Drawing.Size(1378, 738)
        Me.Name = "homePage"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Screen"
        Me.TopMost = True
        Me.sidePanel.ResumeLayout(False)
        Me.sidePanel.PerformLayout()
        CType(Me.dgvHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sidePanel As System.Windows.Forms.Panel
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents line As System.Windows.Forms.Panel
    Friend WithEvents btnBrand As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents dgvHome As System.Windows.Forms.DataGridView

End Class
