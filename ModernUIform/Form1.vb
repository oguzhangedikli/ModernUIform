Imports FontAwesome.Sharp
Public Class Form1
    Private currentBtn As IconButton
    Private leftborderbtn As Panel

    Public Sub New()
        InitializeComponent()
        leftborderbtn = New Panel()
        leftborderbtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftborderbtn)
    End Sub

    Private Sub ActivateButton(senderBtn As Object, costumColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(45, 45, 48)
            currentBtn.IconColor = costumColor
            currentBtn.ForeColor = costumColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.TextAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            leftborderbtn.BackColor = costumColor
            leftborderbtn.Location = New Point(0, currentBtn.Location.Y)
            leftborderbtn.Visible = True
            leftborderbtn.BringToFront()
            iconCurrentForm.IconChar = currentBtn.IconChar
            iconCurrentForm.IconColor = costumColor
            formtitle_lbl.ForeColor = costumColor
            formtitle_lbl.Text = currentBtn.Text
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(39, 39, 35)
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
            leftborderbtn.Visible = False
            iconCurrentForm.IconChar = IconChar.Icons.Home
            iconCurrentForm.IconColor = Color.FromArgb(0, 113, 197)
            formtitle_lbl.Text = "Home"
            formtitle_lbl.ForeColor = Color.FromArgb(0, 113, 197)

        End If
    End Sub

    Private Sub dashboard_btn_Click(sender As Object, e As EventArgs) Handles dashboard_btn.Click
        ActivateButton(sender, RGBColors.Color1)
    End Sub

    Private Sub orders_btn_Click(sender As Object, e As EventArgs) Handles orders_btn.Click
        ActivateButton(sender, RGBColors.Color2)
    End Sub

    Private Sub products_btn_Click(sender As Object, e As EventArgs) Handles products_btn.Click
        ActivateButton(sender, RGBColors.Color3)
    End Sub

    Private Sub costumers_btn_Click(sender As Object, e As EventArgs) Handles costumers_btn.Click
        ActivateButton(sender, RGBColors.Color4)
    End Sub

    Private Sub marketing_btn_Click(sender As Object, e As EventArgs) Handles marketing_btn.Click
        ActivateButton(sender, RGBColors.Color5)
    End Sub

    Private Sub settings_btn_Click(sender As Object, e As EventArgs) Handles settings_btn.Click
        ActivateButton(sender, RGBColors.Color6)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DisableButton()
    End Sub
End Class
