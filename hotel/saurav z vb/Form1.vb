Public Class frmMain
    Dim Chiken As Decimal
    Dim Rice As Decimal
    Dim Meat As Decimal
    Dim Seafood As Decimal
    Dim Veg As Decimal
    Dim Fastfood As Decimal
    Dim Coffee As Decimal
    Dim Juice As Decimal
    Dim Tea As Decimal
    Dim Donut As Decimal
    Dim Cake As Decimal
    Dim Icecream As Decimal
    Dim Total As Integer



    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        pnlOnButtonPosition.Height = btnFoods.Height
        pnlOnButtonPosition.Top = btnFoods.Top
        pnlFoods.Visible = True
        pnlDrinks.Visible = False
        pnlDeserts.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False
    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        pnlOnButtonPosition.Height = btnDrinks.Height
        pnlOnButtonPosition.Top = btnDrinks.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = True
        pnlDeserts.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False
    End Sub

    Private Sub btnDeserts_Click(sender As Object, e As EventArgs) Handles btnDeserts.Click
        pnlOnButtonPosition.Height = btnDeserts.Height
        pnlOnButtonPosition.Top = btnDeserts.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDeserts.Visible = True
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False
    End Sub

    Private Sub btnMyCart_Click(sender As Object, e As EventArgs) Handles btnMyCart.Click
        pnlOnButtonPosition.Height = btnMyCart.Height
        pnlOnButtonPosition.Top = btnMyCart.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDeserts.Visible = False
        pnlMyCart.Visible = True
        pnlAboutUs.Visible = False
    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        pnlOnButtonPosition.Height = btnAboutUs.Height
        pnlOnButtonPosition.Top = btnAboutUs.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDeserts.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = True
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) 
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub picMaximize_Click(sender As Object, e As EventArgs) Handles picMaximize.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Button19_Click(sende As Object, e As EventArgs) Handles Button19.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Chiken = txtChiken.Text * 320.0
        Meat = txtMeat.Text * 400.0
        Seafood = txtFish.Text * 300.0
        Rice = txtRice.Text * 180.0
        Veg = txtVeg.Text * 280.0
        Fastfood = txtFastfood.Text * 120.0
        Coffee = txtCoffee.Text * 350.0
        Juice = txtJuice.Text * 120.0
        Tea = txtTea.Text * 100.0
        Donut = txtDonut.Text * 100.0
        Cake = txtCake.Text * 360.0
        Icecream = txtIcecream.Text * 145.0

        txtTotal.Text = Chiken + Meat + Seafood + Rice + Veg + Fastfood + Coffee + Juice + Tea + Donut + Cake + Icecream




    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click

    End Sub

    Private Sub btnChikenPlus_Click(sender As Object, e As EventArgs) Handles btnChikenPlus.Click
        txtChiken.Text = txtChiken.Text + 1

    End Sub

    Private Sub btnRicePlus_Click(sender As Object, e As EventArgs) Handles btnRicePlus.Click
        txtRice.Text = txtRice.Text + 1
    End Sub

    Private Sub btnMeatPlus_Click(sender As Object, e As EventArgs) Handles btnMeatPlus.Click
        txtMeat.Text = txtMeat.Text + 1
    End Sub

    Private Sub btnVegPlus_Click(sender As Object, e As EventArgs) Handles btnVegPlus.Click
        txtVeg.Text = txtVeg.Text + 1
    End Sub

    Private Sub btnFishPlus_Click(sender As Object, e As EventArgs) Handles btnFishPlus.Click
        txtFish.Text = txtFish.Text + 1
    End Sub

    Private Sub btnFastfoodPlus_Click(sender As Object, e As EventArgs) Handles btnFastfoodPlus.Click
        txtFastfood.Text = txtFastfood.Text + 1
    End Sub

    Private Sub btnChikenMinus_Click(sender As Object, e As EventArgs) Handles btnChikenMinus.Click
        txtChiken.Text = txtChiken.Text - 1
        If txtChiken.Text <= 0 Then
            txtChiken.Text = 0
        End If
    End Sub

    Private Sub btnRiceMinus_Click(sender As Object, e As EventArgs) Handles btnRiceMinus.Click
        txtRice.Text = txtRice.Text - 1
        If txtRice.Text <= 0 Then
            txtRice.Text = 0
        End If
    End Sub

    Private Sub btnMeatMinus_Click(sender As Object, e As EventArgs) Handles btnMeatMinus.Click
        txtMeat.Text = txtMeat.Text - 1
        If txtMeat.Text <= 0 Then
            txtMeat.Text = 0
        End If
    End Sub

    Private Sub btnVegMinus_Click(sender As Object, e As EventArgs) Handles btnVegMinus.Click
        txtVeg.Text = txtVeg.Text - 1
        If txtVeg.Text <= 0 Then
            txtVeg.Text = 0
        End If
    End Sub

    Private Sub btnFishMinus_Click(sender As Object, e As EventArgs) Handles btnFishMinus.Click
        txtFish.Text = txtFish.Text - 1
        If txtFish.Text <= 0 Then
            txtFish.Text = 0
        End If
    End Sub

    Private Sub btnFastfoodMinus_Click(sender As Object, e As EventArgs) Handles btnFastfoodMinus.Click
        txtFastfood.Text = txtFastfood.Text - 1
        If txtFastfood.Text <= 0 Then
            txtFastfood.Text = 0
        End If
    End Sub

    Private Sub btnDonutMinus_Click(sender As Object, e As EventArgs) Handles btnDonutMinus.Click
        txtDonut.Text = txtDonut.Text - 1
        If txtDonut.Text <= 0 Then txtDonut.Text = 0
    End Sub

    Private Sub btnIcecreamMinus_Click(sender As Object, e As EventArgs) Handles btnIcecreamMinus.Click
        txtIcecream.Text = txtIcecream.Text - 1
        If txtIcecream.Text <= 0 Then txtIcecream.Text = 0
    End Sub

    Private Sub btnCakeMinus_Click(sender As Object, e As EventArgs) Handles btnCakeMinus.Click
        txtCake.Text = txtCake.Text - 1
        If txtCake.Text <= 0 Then txtCake.Text = 0
    End Sub

    Private Sub btnDonutPluse_Click(sender As Object, e As EventArgs) Handles btnDonutPluse.Click
        txtDonut.Text = txtDonut.Text + 1
    End Sub

    Private Sub btnIcecreamPluse_Click(sender As Object, e As EventArgs) Handles btnIcecreamPluse.Click
        txtIcecream.Text = txtIcecream.Text + 1
    End Sub

    Private Sub btnCakePluse_Click(sender As Object, e As EventArgs) Handles btnCakePluse.Click
        txtCake.Text = txtCake.Text + 1
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtJuice.TextChanged

    End Sub

    Private Sub btnCoffeePlus_Click(sender As Object, e As EventArgs) Handles btnCoffeePlus.Click
        txtCoffee.Text = txtCoffee.Text + 1
    End Sub

    Private Sub btnTeaPlus_Click(sender As Object, e As EventArgs) Handles btnTeaPlus.Click
        txtTea.Text = txtTea.Text + 1
    End Sub

    Private Sub btnJuicePlus_Click(sender As Object, e As EventArgs) Handles btnJuicePlus.Click
        txtJuice.Text = txtJuice.Text + 1
    End Sub

    Private Sub btnCoffeeMinus_Click(sender As Object, e As EventArgs) Handles btnCoffeeMinus.Click
        txtCoffee.Text = txtCoffee.Text - 1
        If txtCoffee.Text <= 0 Then txtCoffee.Text = 0
    End Sub

    Private Sub btnTeaMinus_Click(sender As Object, e As EventArgs) Handles btnTeaMinus.Click
        txtTea.Text = txtTea.Text - 1
        If txtTea.Text <= 0 Then txtTea.Text = 0
    End Sub

    Private Sub btnJuiceMinus_Click(sender As Object, e As EventArgs) Handles btnJuiceMinus.Click
        txtJuice.Text = txtJuice.Text - 1
        If txtJuice.Text <= 0 Then txtJuice.Text = 0
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtChiken.Text = 0
        txtMeat.Text = 0
        txtFish.Text = 0
        txtRice.Text = 0
        txtVeg.Text = 0
        txtFastfood.Text = 0
        txtCoffee.Text = 0
        txtJuice.Text = 0
        txtTea.Text = 0
        txtDonut.Text = 0
        txtCake.Text = 0
        txtIcecream.Text = 0


        Chiken = 0
        Rice = 0
        Meat = 0
        Seafood = 0
        Veg = 0
        Fastfood = 0
        Coffee = 0
        Juice = 0
        Tea = 0
        Donut = 0
        Cake = 0
        Icecream = 0
        Total = 0




    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Total = txtTotal.Text

        MessageBox.Show("Chiken :Rs." & Chiken & vbCrLf &
"Rice : Rs." & Rice & vbCrLf &
"Meat :Rs." & Meat & vbCrLf &
"Seafood:Rs." & Seafood & vbCrLf &
"Veg  :Rs." & Veg & vbCrLf &
"Fastfood :Rs." & Fastfood & vbCrLf &
"Coffee :Rs." & Coffee & vbCrLf &
"Juice :Rs." & Juice & vbCrLf &
"Tea  :Rs." & Tea & vbCrLf &
"Donut :Rs." & Donut & vbCrLf &
"Cake :Rs." & Cake & vbCrLf &
"Icecream :Rs." & Icecream)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = WindowState.Minimized
    End Sub
End Class
