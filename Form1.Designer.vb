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
        Me.ElementsBox = New System.Windows.Forms.GroupBox()
        Me.ElementsComboBox = New System.Windows.Forms.ComboBox()
        Me.Element1 = New System.Windows.Forms.Label()
        Me.MassNumber1 = New System.Windows.Forms.Label()
        Me.AtomicNumber1 = New System.Windows.Forms.Label()
        Me.Equal = New System.Windows.Forms.Label()
        Me.Element2 = New System.Windows.Forms.Label()
        Me.MassNumber2 = New System.Windows.Forms.Label()
        Me.AtomicNumber2 = New System.Windows.Forms.Label()
        Me.Plus = New System.Windows.Forms.Label()
        Me.Element3 = New System.Windows.Forms.Label()
        Me.MassNumber3 = New System.Windows.Forms.Label()
        Me.AtomicNumber3 = New System.Windows.Forms.Label()
        Me.DecayComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Excited1 = New System.Windows.Forms.Label()
        Me.DecayBox = New System.Windows.Forms.GroupBox()
        Me.ReactantsMassBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Exponent1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MassReactant1 = New System.Windows.Forms.TextBox()
        Me.GreaterThan = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Exponent3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MassProduct2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Exponent2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MassProduct1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MassDefect = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EnergyReleased = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Compute = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.ElementsBox.SuspendLayout()
        Me.DecayBox.SuspendLayout()
        Me.ReactantsMassBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ElementsBox
        '
        Me.ElementsBox.Controls.Add(Me.ElementsComboBox)
        Me.ElementsBox.Location = New System.Drawing.Point(13, 13)
        Me.ElementsBox.Name = "ElementsBox"
        Me.ElementsBox.Size = New System.Drawing.Size(163, 100)
        Me.ElementsBox.TabIndex = 0
        Me.ElementsBox.TabStop = False
        Me.ElementsBox.Text = "Elements"
        '
        'ElementsComboBox
        '
        Me.ElementsComboBox.FormattingEnabled = True
        Me.ElementsComboBox.Items.AddRange(New Object() {"Plutonium-238", "Plutonium-239", "Plutonium-240", "Plutonium-241", "Plutonium-242", "Thorium-220", "Thorium-227", "Thorium-228", "Thorium-230", "Thorium-232", "Uranium-233", "Uranium-234", "Uranium-235", "Uranium-236", "Uranium-238"})
        Me.ElementsComboBox.Location = New System.Drawing.Point(19, 44)
        Me.ElementsComboBox.Name = "ElementsComboBox"
        Me.ElementsComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ElementsComboBox.TabIndex = 0
        Me.ElementsComboBox.Text = "Choose an Element"
        '
        'Element1
        '
        Me.Element1.AutoSize = True
        Me.Element1.BackColor = System.Drawing.Color.Transparent
        Me.Element1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Element1.ForeColor = System.Drawing.Color.DimGray
        Me.Element1.Location = New System.Drawing.Point(250, 57)
        Me.Element1.Name = "Element1"
        Me.Element1.Size = New System.Drawing.Size(34, 37)
        Me.Element1.TabIndex = 1
        Me.Element1.Text = "?"
        '
        'MassNumber1
        '
        Me.MassNumber1.AutoSize = True
        Me.MassNumber1.BackColor = System.Drawing.Color.Transparent
        Me.MassNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.MassNumber1.ForeColor = System.Drawing.Color.DimGray
        Me.MassNumber1.Location = New System.Drawing.Point(239, 35)
        Me.MassNumber1.Name = "MassNumber1"
        Me.MassNumber1.Size = New System.Drawing.Size(16, 18)
        Me.MassNumber1.TabIndex = 2
        Me.MassNumber1.Text = "0"
        '
        'AtomicNumber1
        '
        Me.AtomicNumber1.AutoSize = True
        Me.AtomicNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.AtomicNumber1.ForeColor = System.Drawing.Color.DimGray
        Me.AtomicNumber1.Location = New System.Drawing.Point(239, 94)
        Me.AtomicNumber1.Name = "AtomicNumber1"
        Me.AtomicNumber1.Size = New System.Drawing.Size(16, 18)
        Me.AtomicNumber1.TabIndex = 3
        Me.AtomicNumber1.Text = "0"
        '
        'Equal
        '
        Me.Equal.AutoSize = True
        Me.Equal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Equal.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Equal.Location = New System.Drawing.Point(331, 57)
        Me.Equal.Name = "Equal"
        Me.Equal.Size = New System.Drawing.Size(36, 37)
        Me.Equal.TabIndex = 4
        Me.Equal.Text = "="
        '
        'Element2
        '
        Me.Element2.AutoSize = True
        Me.Element2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Element2.ForeColor = System.Drawing.Color.DimGray
        Me.Element2.Location = New System.Drawing.Point(444, 57)
        Me.Element2.Name = "Element2"
        Me.Element2.Size = New System.Drawing.Size(34, 37)
        Me.Element2.TabIndex = 5
        Me.Element2.Text = "?"
        '
        'MassNumber2
        '
        Me.MassNumber2.AutoSize = True
        Me.MassNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.MassNumber2.ForeColor = System.Drawing.Color.DimGray
        Me.MassNumber2.Location = New System.Drawing.Point(432, 35)
        Me.MassNumber2.Name = "MassNumber2"
        Me.MassNumber2.Size = New System.Drawing.Size(16, 18)
        Me.MassNumber2.TabIndex = 6
        Me.MassNumber2.Text = "0"
        '
        'AtomicNumber2
        '
        Me.AtomicNumber2.AutoSize = True
        Me.AtomicNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.AtomicNumber2.ForeColor = System.Drawing.Color.DimGray
        Me.AtomicNumber2.Location = New System.Drawing.Point(432, 94)
        Me.AtomicNumber2.Name = "AtomicNumber2"
        Me.AtomicNumber2.Size = New System.Drawing.Size(16, 18)
        Me.AtomicNumber2.TabIndex = 7
        Me.AtomicNumber2.Text = "0"
        '
        'Plus
        '
        Me.Plus.AutoSize = True
        Me.Plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Plus.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Plus.Location = New System.Drawing.Point(560, 57)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(36, 37)
        Me.Plus.TabIndex = 8
        Me.Plus.Text = "+"
        '
        'Element3
        '
        Me.Element3.AutoSize = True
        Me.Element3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Element3.ForeColor = System.Drawing.Color.DimGray
        Me.Element3.Location = New System.Drawing.Point(663, 57)
        Me.Element3.Name = "Element3"
        Me.Element3.Size = New System.Drawing.Size(34, 37)
        Me.Element3.TabIndex = 9
        Me.Element3.Text = "?"
        '
        'MassNumber3
        '
        Me.MassNumber3.AutoSize = True
        Me.MassNumber3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.MassNumber3.ForeColor = System.Drawing.Color.DimGray
        Me.MassNumber3.Location = New System.Drawing.Point(653, 35)
        Me.MassNumber3.Name = "MassNumber3"
        Me.MassNumber3.Size = New System.Drawing.Size(16, 18)
        Me.MassNumber3.TabIndex = 10
        Me.MassNumber3.Text = "0"
        '
        'AtomicNumber3
        '
        Me.AtomicNumber3.AutoSize = True
        Me.AtomicNumber3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.AtomicNumber3.ForeColor = System.Drawing.Color.DimGray
        Me.AtomicNumber3.Location = New System.Drawing.Point(653, 95)
        Me.AtomicNumber3.Name = "AtomicNumber3"
        Me.AtomicNumber3.Size = New System.Drawing.Size(16, 18)
        Me.AtomicNumber3.TabIndex = 11
        Me.AtomicNumber3.Text = "0"
        '
        'DecayComboBox1
        '
        Me.DecayComboBox1.FormattingEnabled = True
        Me.DecayComboBox1.Items.AddRange(New Object() {"Alpha Decay", "Beta Minus Decay", "Beta Plus Decay", "Gamma Decay"})
        Me.DecayComboBox1.Location = New System.Drawing.Point(28, 44)
        Me.DecayComboBox1.Name = "DecayComboBox1"
        Me.DecayComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.DecayComboBox1.TabIndex = 12
        Me.DecayComboBox1.Text = "Choose a Decay"
        '
        'Excited1
        '
        Me.Excited1.AutoSize = True
        Me.Excited1.BackColor = System.Drawing.Color.Transparent
        Me.Excited1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Excited1.ForeColor = System.Drawing.Color.DimGray
        Me.Excited1.Location = New System.Drawing.Point(313, 52)
        Me.Excited1.Name = "Excited1"
        Me.Excited1.Size = New System.Drawing.Size(0, 26)
        Me.Excited1.TabIndex = 13
        '
        'DecayBox
        '
        Me.DecayBox.BackColor = System.Drawing.Color.Transparent
        Me.DecayBox.Controls.Add(Me.DecayComboBox1)
        Me.DecayBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DecayBox.Location = New System.Drawing.Point(787, 13)
        Me.DecayBox.Name = "DecayBox"
        Me.DecayBox.Size = New System.Drawing.Size(174, 100)
        Me.DecayBox.TabIndex = 14
        Me.DecayBox.TabStop = False
        Me.DecayBox.Text = "Decay"
        '
        'ReactantsMassBox
        '
        Me.ReactantsMassBox.Controls.Add(Me.Label2)
        Me.ReactantsMassBox.Controls.Add(Me.Exponent1)
        Me.ReactantsMassBox.Controls.Add(Me.Label1)
        Me.ReactantsMassBox.Controls.Add(Me.MassReactant1)
        Me.ReactantsMassBox.Location = New System.Drawing.Point(13, 166)
        Me.ReactantsMassBox.Name = "ReactantsMassBox"
        Me.ReactantsMassBox.Size = New System.Drawing.Size(294, 100)
        Me.ReactantsMassBox.TabIndex = 15
        Me.ReactantsMassBox.TabStop = False
        Me.ReactantsMassBox.Text = "Mass of Reactants"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(237, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "kg"
        '
        'Exponent1
        '
        Me.Exponent1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Exponent1.Location = New System.Drawing.Point(211, 11)
        Me.Exponent1.Name = "Exponent1"
        Me.Exponent1.Size = New System.Drawing.Size(31, 24)
        Me.Exponent1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(156, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "x 10"
        '
        'MassReactant1
        '
        Me.MassReactant1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.MassReactant1.Location = New System.Drawing.Point(13, 31)
        Me.MassReactant1.Name = "MassReactant1"
        Me.MassReactant1.Size = New System.Drawing.Size(137, 44)
        Me.MassReactant1.TabIndex = 0
        '
        'GreaterThan
        '
        Me.GreaterThan.AutoSize = True
        Me.GreaterThan.BackColor = System.Drawing.Color.Transparent
        Me.GreaterThan.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.GreaterThan.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GreaterThan.Location = New System.Drawing.Point(310, 200)
        Me.GreaterThan.Name = "GreaterThan"
        Me.GreaterThan.Size = New System.Drawing.Size(36, 37)
        Me.GreaterThan.TabIndex = 16
        Me.GreaterThan.Text = ">"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Exponent3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.MassProduct2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Exponent2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.MassProduct1)
        Me.GroupBox1.Location = New System.Drawing.Point(352, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(609, 100)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mass of Products"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(552, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 37)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "kg"
        '
        'Exponent3
        '
        Me.Exponent3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Exponent3.Location = New System.Drawing.Point(516, 11)
        Me.Exponent3.Name = "Exponent3"
        Me.Exponent3.Size = New System.Drawing.Size(30, 24)
        Me.Exponent3.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(471, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 37)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "x 10"
        '
        'MassProduct2
        '
        Me.MassProduct2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.MassProduct2.Location = New System.Drawing.Point(318, 31)
        Me.MassProduct2.Name = "MassProduct2"
        Me.MassProduct2.Size = New System.Drawing.Size(138, 44)
        Me.MassProduct2.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(276, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 37)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "+"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(219, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 37)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "kg"
        '
        'Exponent2
        '
        Me.Exponent2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Exponent2.Location = New System.Drawing.Point(183, 11)
        Me.Exponent2.Name = "Exponent2"
        Me.Exponent2.Size = New System.Drawing.Size(30, 24)
        Me.Exponent2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(138, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 37)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "x 10"
        '
        'MassProduct1
        '
        Me.MassProduct1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.MassProduct1.Location = New System.Drawing.Point(6, 31)
        Me.MassProduct1.Name = "MassProduct1"
        Me.MassProduct1.Size = New System.Drawing.Size(124, 44)
        Me.MassProduct1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(27, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 26)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Mass Defect"
        '
        'MassDefect
        '
        Me.MassDefect.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.MassDefect.Location = New System.Drawing.Point(166, 294)
        Me.MassDefect.Name = "MassDefect"
        Me.MassDefect.Size = New System.Drawing.Size(182, 32)
        Me.MassDefect.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(419, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(274, 26)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Energy Released per Atom"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(348, 300)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 26)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "kg"
        '
        'EnergyReleased
        '
        Me.EnergyReleased.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.EnergyReleased.Location = New System.Drawing.Point(699, 291)
        Me.EnergyReleased.Name = "EnergyReleased"
        Me.EnergyReleased.Size = New System.Drawing.Size(199, 32)
        Me.EnergyReleased.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(906, 300)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 26)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "J"
        '
        'Compute
        '
        Me.Compute.BackColor = System.Drawing.Color.Transparent
        Me.Compute.Font = New System.Drawing.Font("Bebas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compute.ForeColor = System.Drawing.Color.DimGray
        Me.Compute.Location = New System.Drawing.Point(400, 347)
        Me.Compute.Name = "Compute"
        Me.Compute.Size = New System.Drawing.Size(99, 35)
        Me.Compute.TabIndex = 24
        Me.Compute.Text = "Compute"
        Me.Compute.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.Transparent
        Me.ResetButton.Font = New System.Deawing.Font("Bebas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.DimGray
        Me.ResetButton.Location = New System.Drawing.Point(430, 347)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Dewaing.Size(99, 35)
        Me.ResetButton.TabIndex = 24
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(973, 406)
        Mw.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Compute)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.EnergyReleased)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MassDefect)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GreaterThan)
        Me.Controls.Add(Me.ReactantsMassBox)
        Me.Controls.Add(Me.DecayBox)
        Me.Controls.Add(Me.Excited1)
        Me.Controls.Add(Me.AtomicNumber3)
        Me.Controls.Add(Me.MassNumber3)
        Me.Controls.Add(Me.Element3)
        Me.Controls.Add(Me.Plus)
        Me.Controls.Add(Me.AtomicNumber2)
        Me.Controls.Add(Me.MassNumber2)
        Me.Controls.Add(Me.Element2)
        Me.Controls.Add(Me.Equal)
        Me.Controls.Add(Me.AtomicNumber1)
        Me.Controls.Add(Me.MassNumber1)
        Me.Controls.Add(Me.Element1)
        Me.Controls.Add(Me.ElementsBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ElementsBox.ResumeLayout(False)
        Me.DecayBox.ResumeLayout(False)
        Me.ReactantsMassBox.ResumeLayout(False)
        Me.ReactantsMassBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElementsBox As GroupBox
    Friend WithEvents ElementsComboBox As ComboBox
    Friend WithEvents Element1 As Label
    Friend WithEvents MassNumber1 As Label
    Friend WithEvents AtomicNumber1 As Label
    Friend WithEvents Equal As Label
    Friend WithEvents Element2 As Label
    Friend WithEvents MassNumber2 As Label
    Friend WithEvents AtomicNumber2 As Label
    Friend WithEvents Plus As Label
    Friend WithEvents Element3 As Label
    Friend WithEvents MassNumber3 As Label
    Friend WithEvents AtomicNumber3 As Label
    Friend WithEvents DecayComboBox1 As ComboBox
    Friend WithEvents Excited1 As Label
    Friend WithEvents DecayBox As GroupBox
    Friend WithEvents ReactantsMassBox As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Exponent1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MassReactant1 As TextBox
    Friend WithEvents GreaterThan As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Exponent3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MassProduct2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Exponent2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MassProduct1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MassDefect As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents EnergyReleased As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Compute As Button
    Friend WithEvemts ResetButton As Button
End Class
