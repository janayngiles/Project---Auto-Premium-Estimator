Public Class Form1

    '===============================
    ' AUTHOR: Janay Giles 
    ' CREATE DATE: 10/14/2022    
    ' PURPOSE: Auto Premium Estimator     
    '===============================

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerateQuote.Click
        'empties message label and status 
        lblMessage.Text = ""
        lblStatus.Text = ""

        'declaring variables 
        Dim FirstName As String
        Dim LastName As String
        Dim Address As String
        Dim City As String
        Dim State As String
        Dim ZipCode As String
        Dim intYear As Integer
        Dim Bodystyle As String
        Dim Make As String
        Dim Model As String
        Dim VIN As String
        Dim Liability As String
        Dim CompColl As String
        Dim Deductible As String
        Dim dblBASEPREMIUM As Double = 35.0
        Dim dblAutoPremium As Double = 0.0
        Dim PIP As String
        Dim Addons As String
        Dim YearsInsured As String
        Dim notEnteredMessage As String = ""


        FirstName = txtFirstName.Text
        LastName = txtLastName.Text
        Address = txtAddress.Text
        City = txtCity.Text
        State = ComboBoxState.Text

        'numeric validation 
        If Integer.TryParse(txtZipCode.Text, ZipCode) Then

            ZipCode = txtZipCode.Text
        Else
            lblStatus.Visible = True
            Panel.Visible = True
            lblStatus.Text = "Zip Code: Numeric Values Only" & vbNewLine
        End If

        'entered name validation 
        If FirstName = "First Name" Or LastName = "Last Name" Then
            lblMessage.Text = "UNKNOWN" & vbNewLine
        Else
            lblMessage.Text = "Hello " & FirstName & " " & LastName & "!" & vbNewLine
        End If

        'validating years insured has been entered
        YearsInsured = ComboBoxYearsInsured.Text
        If YearsInsured = "Years Insured" Then
            lblStatus.Visible = True
            Panel.Visible = True
            lblStatus.Text += "Years Insured Not Selected" & vbNewLine
        Else
        End If

        ' converts yearcombobox to an int 
        If Integer.TryParse(ComboBoxYear.Text, intYear) Then
            intYear = ComboBoxYear.Text
        Else
        End If

        'validates vehicle year is selected 
        If intYear = 0 Then

            lblStatus.Visible = True
            Panel.Visible = True
            lblStatus.Text += "Vehicle Year not selected" & vbNewLine
            notEnteredMessage = "Year N/A"
            lblMessage.Text += notEnteredMessage
        Else
            lblMessage.Text += "" & intYear
        End If

        'bodystyle assigned 
        Bodystyle = ComboBoxBodyStyle.Text

        'validates make info is entered 
        If txtMake.Text = "Make" Then
            lblStatus.Visible = True
            Panel.Visible = True
            lblStatus.Text += "Vehicle Make not entered" & vbNewLine
            notEnteredMessage = " Make N/A"
            lblMessage.Text += notEnteredMessage
        Else
            Make = txtMake.Text
            lblMessage.Text += " " & Make
        End If

        'validates model info is entered 
        If txtModel.Text = "Model" Then
            lblStatus.Visible = True
            Panel.Visible = True
            lblStatus.Text += "Vehicle Model not entered" & vbNewLine
            notEnteredMessage = " Model N/A" & vbNewLine
            lblMessage.Text += notEnteredMessage
        Else
            Model = txtModel.Text
            lblMessage.Text += " " & Model & vbNewLine
        End If

        'validates VIN length is 17
        VIN = txtVIN.Text
        If VIN.Length <> 17 Then
            lblStatus.Visible = True
            Panel.Visible = True
            lblStatus.Text += "VIN Not 17 digits" & vbNewLine
            notEnteredMessage = "VIN N/A" & vbNewLine
            lblMessage.Text += notEnteredMessage
        Else
            lblMessage.Text += "VIN: " & VIN & vbNewLine
        End If

        'validates liability coverage is selected
        Liability = ComboBoxLiability.Text
        If ComboBoxLiability.Text = "Liability" Then
            lblStatus.Visible = True
            Panel.Visible = True
            lblStatus.Text += "Liability Coverage Not Selected" & vbNewLine
            notEnteredMessage = "Liability Coverage Not Selected" & vbNewLine
            lblMessage.Text += notEnteredMessage
        Else
            lblMessage.Text += "Liability Coverage: " & Liability & vbNewLine
        End If

        'validates comp/coll coverage is selected
        CompColl = ComboBoxCompColl.Text
        If ComboBoxCompColl.Text = "Comp & Coll" Then
            lblStatus.Visible = True
            Panel.Visible = True
            lblStatus.Text += "Comprehensive/Collison Coverage Not Selected" & vbNewLine
            notEnteredMessage = "Comprehensive/Collison Coverage Not Selected "
            lblMessage.Text += notEnteredMessage
        Else
            lblMessage.Text += CompColl & ": "
        End If

        'validates deductible is selected
        Deductible = ComboBoxDeduct.Text
        If ComboBoxDeduct.Text = "Deductible" Then
            lblStatus.Visible = True
            Panel.Visible = True
            lblStatus.Text += "Deductible Not Selected" & vbNewLine
            notEnteredMessage = " Deductible Not Selected " & vbNewLine
            lblMessage.Text += notEnteredMessage
        Else
            lblMessage.Text += Deductible & " Deductible" & vbNewLine
        End If

        'validates PIP coverage is selected
        PIP = ComboBoxPIP.Text
        If ComboBoxPIP.Text = "Personal Injury Protection" Then
            lblStatus.Visible = True
            Panel.Visible = True
            lblStatus.Text += "Personal Injury Protection Not Selected" & vbNewLine
            notEnteredMessage = "Personal Injury Protection Not Selected " & vbNewLine
            lblMessage.Text += notEnteredMessage
        Else
            lblMessage.Text += "Personal Injury Protection: " & PIP & " " & vbNewLine
        End If


        '-----CALCULATIONS FOR AUTO PREMIUM-----

        'premium adjusted based on vehicle year
        dblAutoPremium = dblAutoPremium + dblBASEPREMIUM

        If intYear < 2000 And intYear > 1 Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.3)

        ElseIf intYear >= 2000 And intYear < 2016 Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.6)

        ElseIf intYear >= 2016 Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.8)
        End If

        'premium adjusted based on vehicle bodystyle
        If Bodystyle = "Truck" Or Bodystyle = "SUV" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.06)

        ElseIf Bodystyle = "Sedan" Or Bodystyle = "Hybrid" Or Bodystyle = "Crossover" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.02)

        ElseIf Bodystyle = "Hatchback" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.03)

        ElseIf Bodystyle = "Station Wagon" Or Bodystyle = "Sport" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.04)

        ElseIf Bodystyle = "Coupe" Or Bodystyle = "Convertible" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.11)
        End If

        'premium adjusted based on liability coverage 
        If Liability = "25,000/50,000/25,000" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.03)

        ElseIf Liability = "50,000/100,000/50,000" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.06)

        ElseIf Liability = "100,000/300,000/100,000" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.13)

        ElseIf Liability = "250,000/500,000/250,000" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.22)
        End If

        'premium adjusted based on compcoll coverage 
        If CompColl = "Only Comp Coverage" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.04)

        ElseIf CompColl = "Only Collision Coverage" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.22)

        ElseIf CompColl = "Comp and Collision Coverage" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.26)
        End If

        'premium adjusted based on deductible 
        If Deductible = "$0" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.53)

        ElseIf Deductible = "$250" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.33)

        ElseIf Deductible = "$500" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.19)

        ElseIf Deductible = "$1000" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.11)
        End If

        ' premium adjusted based on PIP coverage 
        If PIP = "$5,000" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.03)

        ElseIf PIP = "$10,000" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.06)

        ElseIf PIP = "$25,000" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.08)

        ElseIf PIP = "$50,000" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.11)

        ElseIf PIP = "$100,000" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.17)
        End If

        'premium adjusted based on coverage adds on 
        If chkRoadside.Checked And chkRental.Checked Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.05)
            Addons = "Roadside Service and Rental Car Reimbursement Added" & vbNewLine
            lblMessage.Text += Addons

        ElseIf chkRoadside.Checked Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.02)
            Addons = "Roadside Service Added" & vbNewLine
            lblMessage.Text += Addons

        ElseIf chkRental.Checked Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.03)
            Addons = "Rental Car Reimbursement Added" & vbNewLine
            lblMessage.Text += Addons
        End If


        'premium adjusted based on years insured
        If YearsInsured = "0" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.36)

        ElseIf YearsInsured = "1" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.11)

        ElseIf YearsInsured = "2" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * 0.04)

        ElseIf YearsInsured = "3" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * -0.06)

        ElseIf YearsInsured = "4" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * -0.08)

        ElseIf YearsInsured = "5+" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * -0.1)

        ElseIf YearsInsured = "10+" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * -0.15)

        ElseIf YearsInsured = "15+" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * -0.2)

        ElseIf YearsInsured = "20+" Then
            dblAutoPremium = dblAutoPremium + (dblAutoPremium * -0.25)
        End If

        'mitigates if no information is entered by the user
        If dblAutoPremium = 35 Then

            lblMessage.Text = "Your estimated monthly premium cannot be calculated. Please enter information and re-try."
        Else
            lblMessage.Text += "Your monthly premium is: " & dblAutoPremium.ToString("c")
        End If

        lblMessage.Visible = True
    End Sub

    'initializes textbox input 
    Private Sub txtFirstName_Click(sender As Object, e As EventArgs) Handles txtFirstName.MouseClick
        txtFirstName.Text = ""
    End Sub

    Private Sub txtLastName_Click(sender As Object, e As EventArgs) Handles txtLastName.MouseClick
        txtLastName.Text = ""
    End Sub
    Private Sub txtAddress_Click(sender As Object, e As EventArgs) Handles txtAddress.Click
        txtAddress.Text = ""
    End Sub
    Private Sub txtCity_Click(sender As Object, e As EventArgs) Handles txtCity.MouseClick
        txtCity.Text = ""
    End Sub
    Private Sub txtZipCode_Click(sender As Object, e As EventArgs) Handles txtZipCode.MouseClick
        txtZipCode.Text = ""
    End Sub

    Private Sub txtMake_Click(sender As Object, e As EventArgs) Handles txtMake.MouseClick
        txtMake.Text = ""
    End Sub

    Private Sub txtModel_Click(sender As Object, e As EventArgs) Handles txtModel.MouseClick
        txtModel.Text = ""
    End Sub

    Private Sub txtVIN_Click(sender As Object, e As EventArgs) Handles txtVIN.MouseClick
        txtVIN.Text = ""
    End Sub

    'clears txtbox values and checked add ons 
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Text = "First Name"
        txtLastName.Text = "Last Name"
        txtAddress.Text = "Address"
        txtCity.Text = "City"
        txtZipCode.Text = "Zip Code"
        txtMake.Text = "Make"
        txtModel.Text = "Model"
        txtVIN.Text = "VIN"

        chkRoadside.Checked = False
        chkRental.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
