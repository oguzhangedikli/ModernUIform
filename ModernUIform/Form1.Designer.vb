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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.settings_btn = New FontAwesome.Sharp.IconButton()
        Me.marketing_btn = New FontAwesome.Sharp.IconButton()
        Me.costumers_btn = New FontAwesome.Sharp.IconButton()
        Me.products_btn = New FontAwesome.Sharp.IconButton()
        Me.orders_btn = New FontAwesome.Sharp.IconButton()
        Me.dashboard_btn = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_title_bar = New System.Windows.Forms.Panel()
        Me.formtitle_lbl = New System.Windows.Forms.Label()
        Me.iconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_title_bar.SuspendLayout()
        CType(Me.iconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.settings_btn)
        Me.PanelMenu.Controls.Add(Me.marketing_btn)
        Me.PanelMenu.Controls.Add(Me.costumers_btn)
        Me.PanelMenu.Controls.Add(Me.products_btn)
        Me.PanelMenu.Controls.Add(Me.orders_btn)
        Me.PanelMenu.Controls.Add(Me.dashboard_btn)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 596)
        Me.PanelMenu.TabIndex = 0
        '
        'settings_btn
        '
        Me.settings_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.settings_btn.FlatAppearance.BorderSize = 0
        Me.settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settings_btn.ForeColor = System.Drawing.Color.Gainsboro
        Me.settings_btn.IconChar = FontAwesome.Sharp.IconChar.Tools
        Me.settings_btn.IconColor = System.Drawing.Color.Gainsboro
        Me.settings_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.settings_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settings_btn.Location = New System.Drawing.Point(0, 440)
        Me.settings_btn.Name = "settings_btn"
        Me.settings_btn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.settings_btn.Size = New System.Drawing.Size(220, 60)
        Me.settings_btn.TabIndex = 6
        Me.settings_btn.Text = "Settings"
        Me.settings_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.settings_btn.UseVisualStyleBackColor = True
        '
        'marketing_btn
        '
        Me.marketing_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.marketing_btn.FlatAppearance.BorderSize = 0
        Me.marketing_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.marketing_btn.ForeColor = System.Drawing.Color.Gainsboro
        Me.marketing_btn.IconChar = FontAwesome.Sharp.IconChar.MailBulk
        Me.marketing_btn.IconColor = System.Drawing.Color.Gainsboro
        Me.marketing_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.marketing_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.marketing_btn.Location = New System.Drawing.Point(0, 380)
        Me.marketing_btn.Name = "marketing_btn"
        Me.marketing_btn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.marketing_btn.Size = New System.Drawing.Size(220, 60)
        Me.marketing_btn.TabIndex = 5
        Me.marketing_btn.Text = "Marketing"
        Me.marketing_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.marketing_btn.UseVisualStyleBackColor = True
        '
        'costumers_btn
        '
        Me.costumers_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.costumers_btn.FlatAppearance.BorderSize = 0
        Me.costumers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.costumers_btn.ForeColor = System.Drawing.Color.Gainsboro
        Me.costumers_btn.IconChar = FontAwesome.Sharp.IconChar.User
        Me.costumers_btn.IconColor = System.Drawing.Color.Gainsboro
        Me.costumers_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.costumers_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.costumers_btn.Location = New System.Drawing.Point(0, 320)
        Me.costumers_btn.Name = "costumers_btn"
        Me.costumers_btn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.costumers_btn.Size = New System.Drawing.Size(220, 60)
        Me.costumers_btn.TabIndex = 4
        Me.costumers_btn.Text = "Costumers"
        Me.costumers_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.costumers_btn.UseVisualStyleBackColor = True
        '
        'products_btn
        '
        Me.products_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.products_btn.FlatAppearance.BorderSize = 0
        Me.products_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.products_btn.ForeColor = System.Drawing.Color.Gainsboro
        Me.products_btn.IconChar = FontAwesome.Sharp.IconChar.Tag
        Me.products_btn.IconColor = System.Drawing.Color.Gainsboro
        Me.products_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.products_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.products_btn.Location = New System.Drawing.Point(0, 260)
        Me.products_btn.Name = "products_btn"
        Me.products_btn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.products_btn.Size = New System.Drawing.Size(220, 60)
        Me.products_btn.TabIndex = 3
        Me.products_btn.Text = "Products"
        Me.products_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.products_btn.UseVisualStyleBackColor = True
        '
        'orders_btn
        '
        Me.orders_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.orders_btn.FlatAppearance.BorderSize = 0
        Me.orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.orders_btn.ForeColor = System.Drawing.Color.Gainsboro
        Me.orders_btn.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.orders_btn.IconColor = System.Drawing.Color.Gainsboro
        Me.orders_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.orders_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.orders_btn.Location = New System.Drawing.Point(0, 200)
        Me.orders_btn.Name = "orders_btn"
        Me.orders_btn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.orders_btn.Size = New System.Drawing.Size(220, 60)
        Me.orders_btn.TabIndex = 2
        Me.orders_btn.Text = "Orders"
        Me.orders_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.orders_btn.UseVisualStyleBackColor = True
        '
        'dashboard_btn
        '
        Me.dashboard_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.dashboard_btn.FlatAppearance.BorderSize = 0
        Me.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dashboard_btn.ForeColor = System.Drawing.Color.Gainsboro
        Me.dashboard_btn.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.dashboard_btn.IconColor = System.Drawing.Color.Gainsboro
        Me.dashboard_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboard_btn.Location = New System.Drawing.Point(0, 140)
        Me.dashboard_btn.Name = "dashboard_btn"
        Me.dashboard_btn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.dashboard_btn.Size = New System.Drawing.Size(220, 60)
        Me.dashboard_btn.TabIndex = 1
        Me.dashboard_btn.Text = "Dashboard"
        Me.dashboard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.dashboard_btn.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(43, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panel_title_bar
        '
        Me.panel_title_bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.panel_title_bar.Controls.Add(Me.formtitle_lbl)
        Me.panel_title_bar.Controls.Add(Me.iconCurrentForm)
        Me.panel_title_bar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_title_bar.Location = New System.Drawing.Point(220, 0)
        Me.panel_title_bar.Name = "panel_title_bar"
        Me.panel_title_bar.Size = New System.Drawing.Size(825, 75)
        Me.panel_title_bar.TabIndex = 1
        '
        'formtitle_lbl
        '
        Me.formtitle_lbl.AutoSize = True
        Me.formtitle_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.formtitle_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.formtitle_lbl.Location = New System.Drawing.Point(55, 32)
        Me.formtitle_lbl.Name = "formtitle_lbl"
        Me.formtitle_lbl.Size = New System.Drawing.Size(52, 21)
        Me.formtitle_lbl.TabIndex = 2
        Me.formtitle_lbl.Text = "Home"
        '
        'iconCurrentForm
        '
        Me.iconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.iconCurrentForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.iconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.iconCurrentForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.iconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconCurrentForm.Location = New System.Drawing.Point(17, 27)
        Me.iconCurrentForm.Name = "iconCurrentForm"
        Me.iconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.iconCurrentForm.TabIndex = 0
        Me.iconCurrentForm.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 596)
        Me.Controls.Add(Me.panel_title_bar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Form1"
        Me.Text = "ModernUI"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_title_bar.ResumeLayout(False)
        Me.panel_title_bar.PerformLayout()
        CType(Me.iconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents settings_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents marketing_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents costumers_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents products_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents orders_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents dashboard_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents panel_title_bar As Panel
    Friend WithEvents formtitle_lbl As Label
    Friend WithEvents iconCurrentForm As FontAwesome.Sharp.IconPictureBox
End Class
