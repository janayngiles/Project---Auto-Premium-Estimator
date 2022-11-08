<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnGenerateQuote = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxYearsInsured = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxState = New System.Windows.Forms.ComboBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkRental = New System.Windows.Forms.CheckBox()
        Me.chkRoadside = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxDeduct = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPIP = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCompColl = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLiability = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxBodyStyle = New System.Windows.Forms.ComboBox()
        Me.txtVIN = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.ComboBoxYear = New System.Windows.Forms.ComboBox()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerateQuote
        '
        Me.btnGenerateQuote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnGenerateQuote.Location = New System.Drawing.Point(183, 676)
        Me.btnGenerateQuote.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGenerateQuote.Name = "btnGenerateQuote"
        Me.btnGenerateQuote.Size = New System.Drawing.Size(115, 59)
        Me.btnGenerateQuote.TabIndex = 3
        Me.btnGenerateQuote.Text = "Generate Quote"
        Me.btnGenerateQuote.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnClear.Location = New System.Drawing.Point(317, 676)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 59)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnExit.Location = New System.Drawing.Point(448, 676)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 59)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.White
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(36, 747)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(675, 140)
        Me.lblMessage.TabIndex = 7
        Me.lblMessage.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ComboBoxYearsInsured)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBoxState)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.txtZipCode)
        Me.Panel1.Controls.Add(Me.txtCity)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Location = New System.Drawing.Point(36, 121)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(673, 239)
        Me.Panel1.TabIndex = 0
        '
        'ComboBoxYearsInsured
        '
        Me.ComboBoxYearsInsured.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ComboBoxYearsInsured.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBoxYearsInsured.FormattingEnabled = True
        Me.ComboBoxYearsInsured.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5+", "10+", "15+", "20+"})
        Me.ComboBoxYearsInsured.Location = New System.Drawing.Point(477, 103)
        Me.ComboBoxYearsInsured.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxYearsInsured.Name = "ComboBoxYearsInsured"
        Me.ComboBoxYearsInsured.Size = New System.Drawing.Size(143, 28)
        Me.ComboBoxYearsInsured.TabIndex = 6
        Me.ComboBoxYearsInsured.Text = "Years Insured"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Personal Information"
        '
        'ComboBoxState
        '
        Me.ComboBoxState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ComboBoxState.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBoxState.FormattingEnabled = True
        Me.ComboBoxState.Items.AddRange(New Object() {"Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"})
        Me.ComboBoxState.Location = New System.Drawing.Point(215, 166)
        Me.ComboBoxState.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxState.Name = "ComboBoxState"
        Me.ComboBoxState.Size = New System.Drawing.Size(167, 28)
        Me.ComboBoxState.TabIndex = 4
        Me.ComboBoxState.Text = "Select State"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLastName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLastName.Location = New System.Drawing.Point(229, 68)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(193, 26)
        Me.txtLastName.TabIndex = 1
        Me.txtLastName.Text = "Last Name"
        '
        'txtZipCode
        '
        Me.txtZipCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtZipCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtZipCode.Location = New System.Drawing.Point(404, 166)
        Me.txtZipCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(117, 26)
        Me.txtZipCode.TabIndex = 5
        Me.txtZipCode.Text = "Zip Code"
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCity.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCity.Location = New System.Drawing.Point(29, 167)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(167, 26)
        Me.txtCity.TabIndex = 3
        Me.txtCity.Text = "City"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddress.Location = New System.Drawing.Point(29, 122)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(399, 26)
        Me.txtAddress.TabIndex = 2
        Me.txtAddress.Text = "Address "
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFirstName.Location = New System.Drawing.Point(27, 68)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(199, 26)
        Me.txtFirstName.TabIndex = 0
        Me.txtFirstName.Text = "First Name"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.chkRental)
        Me.Panel2.Controls.Add(Me.chkRoadside)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ComboBoxDeduct)
        Me.Panel2.Controls.Add(Me.ComboBoxPIP)
        Me.Panel2.Controls.Add(Me.ComboBoxCompColl)
        Me.Panel2.Controls.Add(Me.ComboBoxLiability)
        Me.Panel2.Location = New System.Drawing.Point(383, 378)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 285)
        Me.Panel2.TabIndex = 2
        '
        'chkRental
        '
        Me.chkRental.AutoSize = True
        Me.chkRental.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkRental.Location = New System.Drawing.Point(19, 242)
        Me.chkRental.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkRental.Name = "chkRental"
        Me.chkRental.Size = New System.Drawing.Size(234, 24)
        Me.chkRental.TabIndex = 5
        Me.chkRental.Text = "Rental Car Reimbursement"
        Me.chkRental.UseVisualStyleBackColor = True
        '
        'chkRoadside
        '
        Me.chkRoadside.AutoSize = True
        Me.chkRoadside.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkRoadside.Location = New System.Drawing.Point(19, 217)
        Me.chkRoadside.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkRoadside.Name = "chkRoadside"
        Me.chkRoadside.Size = New System.Drawing.Size(162, 24)
        Me.chkRoadside.TabIndex = 4
        Me.chkRoadside.Text = "Roadside Service"
        Me.chkRoadside.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(13, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 25)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Coverage Add-Ons"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(13, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Coverage"
        '
        'ComboBoxDeduct
        '
        Me.ComboBoxDeduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ComboBoxDeduct.FormattingEnabled = True
        Me.ComboBoxDeduct.Items.AddRange(New Object() {"$0", "$250", "$500", "$1,000"})
        Me.ComboBoxDeduct.Location = New System.Drawing.Point(177, 95)
        Me.ComboBoxDeduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxDeduct.Name = "ComboBoxDeduct"
        Me.ComboBoxDeduct.Size = New System.Drawing.Size(131, 28)
        Me.ComboBoxDeduct.TabIndex = 2
        Me.ComboBoxDeduct.Text = "Deductible"
        '
        'ComboBoxPIP
        '
        Me.ComboBoxPIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ComboBoxPIP.FormattingEnabled = True
        Me.ComboBoxPIP.Items.AddRange(New Object() {"$5,000", "$10,000", "$25,000", "$50,000", "$100,000"})
        Me.ComboBoxPIP.Location = New System.Drawing.Point(15, 143)
        Me.ComboBoxPIP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxPIP.Name = "ComboBoxPIP"
        Me.ComboBoxPIP.Size = New System.Drawing.Size(231, 28)
        Me.ComboBoxPIP.TabIndex = 3
        Me.ComboBoxPIP.Text = "Personal Injury Protection"
        '
        'ComboBoxCompColl
        '
        Me.ComboBoxCompColl.DropDownWidth = 200
        Me.ComboBoxCompColl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ComboBoxCompColl.FormattingEnabled = True
        Me.ComboBoxCompColl.Items.AddRange(New Object() {"Only Comp Coverage", "Only Collision Coverage", "Comp and Collision Coverage"})
        Me.ComboBoxCompColl.Location = New System.Drawing.Point(15, 95)
        Me.ComboBoxCompColl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxCompColl.Name = "ComboBoxCompColl"
        Me.ComboBoxCompColl.Size = New System.Drawing.Size(149, 28)
        Me.ComboBoxCompColl.TabIndex = 1
        Me.ComboBoxCompColl.Text = "Comp & Coll"
        '
        'ComboBoxLiability
        '
        Me.ComboBoxLiability.DropDownWidth = 200
        Me.ComboBoxLiability.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ComboBoxLiability.FormattingEnabled = True
        Me.ComboBoxLiability.Items.AddRange(New Object() {"25,000/50,000/25,000", "50,000/100,000/50,000", "100,000/300,000/100,000", "250,000/500,000/250,000"})
        Me.ComboBoxLiability.Location = New System.Drawing.Point(15, 50)
        Me.ComboBoxLiability.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxLiability.Name = "ComboBoxLiability"
        Me.ComboBoxLiability.Size = New System.Drawing.Size(231, 28)
        Me.ComboBoxLiability.TabIndex = 0
        Me.ComboBoxLiability.Text = "Liability"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.ComboBoxBodyStyle)
        Me.Panel3.Controls.Add(Me.txtVIN)
        Me.Panel3.Controls.Add(Me.txtModel)
        Me.Panel3.Controls.Add(Me.txtMake)
        Me.Panel3.Controls.Add(Me.ComboBoxYear)
        Me.Panel3.Location = New System.Drawing.Point(36, 378)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(321, 285)
        Me.Panel3.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(16, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Vehicle Information"
        '
        'ComboBoxBodyStyle
        '
        Me.ComboBoxBodyStyle.DropDownWidth = 125
        Me.ComboBoxBodyStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ComboBoxBodyStyle.FormattingEnabled = True
        Me.ComboBoxBodyStyle.Items.AddRange(New Object() {"Truck", "SUV", "Sedan", "Coupe", "Sport", "Hybrid", "Crossover", "Station Wagon", "Hatchback", "Convertible"})
        Me.ComboBoxBodyStyle.Location = New System.Drawing.Point(147, 50)
        Me.ComboBoxBodyStyle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxBodyStyle.Name = "ComboBoxBodyStyle"
        Me.ComboBoxBodyStyle.Size = New System.Drawing.Size(153, 28)
        Me.ComboBoxBodyStyle.TabIndex = 1
        Me.ComboBoxBodyStyle.Text = "Bodystyle"
        '
        'txtVIN
        '
        Me.txtVIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtVIN.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtVIN.Location = New System.Drawing.Point(23, 219)
        Me.txtVIN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVIN.Name = "txtVIN"
        Me.txtVIN.Size = New System.Drawing.Size(276, 26)
        Me.txtVIN.TabIndex = 4
        Me.txtVIN.Text = "VIN "
        '
        'txtModel
        '
        Me.txtModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtModel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtModel.Location = New System.Drawing.Point(23, 166)
        Me.txtModel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(276, 26)
        Me.txtModel.TabIndex = 3
        Me.txtModel.Text = "Model"
        '
        'txtMake
        '
        Me.txtMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtMake.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtMake.Location = New System.Drawing.Point(21, 106)
        Me.txtMake.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(276, 26)
        Me.txtMake.TabIndex = 2
        Me.txtMake.Text = "Make"
        '
        'ComboBoxYear
        '
        Me.ComboBoxYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ComboBoxYear.FormattingEnabled = True
        Me.ComboBoxYear.Items.AddRange(New Object() {"1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2022", "2023"})
        Me.ComboBoxYear.Location = New System.Drawing.Point(23, 50)
        Me.ComboBoxYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxYear.Name = "ComboBoxYear"
        Me.ComboBoxYear.Size = New System.Drawing.Size(77, 28)
        Me.ComboBoxYear.TabIndex = 0
        Me.ComboBoxYear.Text = "Year"
        '
        'Panel
        '
        Me.Panel.AutoScroll = True
        Me.Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel.BackColor = System.Drawing.Color.White
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel.Controls.Add(Me.lblStatus)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(749, 107)
        Me.Panel.TabIndex = 26
        Me.Panel.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(16, 11)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(112, 20)
        Me.lblStatus.TabIndex = 27
        Me.lblStatus.Text = "Error Status"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(749, 898)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnGenerateQuote)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Auto Premium Generator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerateQuote As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxState As ComboBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxDeduct As ComboBox
    Friend WithEvents ComboBoxPIP As ComboBox
    Friend WithEvents ComboBoxCompColl As ComboBox
    Friend WithEvents ComboBoxLiability As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxBodyStyle As ComboBox
    Friend WithEvents txtVIN As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtMake As TextBox
    Friend WithEvents ComboBoxYear As ComboBox
    Friend WithEvents ComboBoxYearsInsured As ComboBox
    Friend WithEvents chkRental As CheckBox
    Friend WithEvents chkRoadside As CheckBox
    Friend WithEvents Panel As Panel
    Friend WithEvents lblStatus As Label
End Class
