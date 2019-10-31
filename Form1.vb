Public Class Form1
    Dim A1, A2, A3, M1, M2, M3 As Double
        A1 = AtomicNumber1.Text
        A2 = AtomicNumber2.Text
        A3 = AtomicNumber3.Text
        M1 = MassNumber1.Text
        M2 = MassNumber2.Text
        M3 = MassNumber3.Text
    
    Dim E1, E2, E3, ECB As String
        E1 = Element1.Text
        E2 = Element2.Text
        E3 = Element3.Text
        eBox = ElementsComboBox.Text

    Private Sub Element2_Click(sender As Object, e As EventArgs) Handles Element2.Click

    End Sub

    Private Sub MassNumber1_Click(sender As Object, e As EventArgs) Handles MassNumber1.Click

    End Sub

    Private Sub ElementsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ElementsComboBox.SelectedIndexChanged

        If eBox = "Uranium-233" Then
            E1 = "U"
            M1 = 233
            A1 = 92
        ElseIf eBox = "Uranium-234" Then
            E1 = "U"
            M1 = 234
            A1 = 92
        ElseIf eBox = "Uranium-235" Then
            E1 = "U"
            M1 = 235
            A1 = 92
        ElseIf eBox = "Uranium-236" Then
            E1 = "U"
            M1 = 236
            A1 = 92
        ElseIf eBox = "Uranium-238" Then
            E1 = "U"
            M1 = 238
            A1 = 92
        ElseIf eBox = "Thorium-220" Then
            E1 = "Th"
            M1 = 220
            A1 = 90
        ElseIf eBox = "Thorium-227" Then
            E1 = "Th"
            M1 = 227
            A1 = 90
        ElseIf eBox = "Thorium-228" Then
            E1 = "Th"
            M1 = 228
            A1 = 90
        ElseIf eBox = "Thorium-230" Then
            E1 = "Th"
            M1 = 230
            A1 = 90
        ElseIf eBox = "Thorium-232" Then
            E1 = "Th"
            M1 = 232
            A1 = 90
        ElseIf eBox = "Plutonium=238" Then
            E1 = "Pl"
            M1 = 238
            A1 = 94
        ElseIf eBox = "Plutonium-239" Then
            E1 = "Pl"
            M1 = 239
            A1 = 94
        ElseIf eBox = "Plutonium-240" Then
            E1 = "Pl"
            M1 = 240123
            A1 = 94
        ElseIf eBox = "Plutonium-241" Then
            E1 = "Pl"
            M1 = 241
            A1 = 94
        ElseIf eBox = "Plutonium-242" Then
            E1 = "Pl"
            M1 = 242
            A1 = 94
        End If
        '
        'To change the result when decay has already been chosen
        '
        A3 = differenceFunction(A1, A2)
        M3 = differenceFunction(M1, M2)

        If A3 = 88 Then
            E3 = "Ra"
        ElseIf A3 = 89 Then
            E3 = "Ac"
        ElseIf A3 = 90 Then
            E3 = "Th"
        ElseIf A3 = 91 Then
            E3 = "Pa"
        ElseIf A3 = 92 Then
            E3 = "U"
        ElseIf A3 = 93 Then
            E3 = "Np"
        ElseIf A3 = 94 Then
            E3 = "Pu"
        ElseIf A3 = 95 Then
            E3 = "Am"
        End If
    End Sub

    Private Sub DecayComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DecayComboBox1.SelectedIndexChanged
        If DecayComboBox1.Text = "Alpha Decay" Then
            E2 = "α"
            M2 = 4
            A2 = 2
            Excited1.Text = ""

            'Excited1 is for the asterisk

        ElseIf DecayComboBox1.Text = "Beta Plus Decay" Then
            E2 = "ß"
            M2 = 0
            A2 = 1
            Excited1.Text = ""
        ElseIf DecayComboBox1.Text = "Beta Minus Decay" Then
            Element2.Text = "ß"
            M2 = 0
            A2 = -1
            Excited1.Text = ""
        ElseIf DecayComboBox1.Text = "Gamma Decay" Then
            E2 = "Γ"
            M2 = 0
            A2 = 0
            Excited1.Text = "*"

            'The asterisk is only shown when Gamma Decay is selected in DecayComboBox1

        End If

        Function differenceFunction (x As Double, y As Double) As Double
            Return x - y
        End Function

        A3 = differenceFunction(A1, A2)
        M3 = differenceFunction(M1, M2)

        If A3 = 88 Then
            E3 = "Ra"
        ElseIf A3 = 89 Then
            E3 = "Ac"
        ElseIf A3 = 90 Then
            E3 = "Th"
        ElseIf A3 = 91 Then
            E3 = "Pa"
        ElseIf A3 = 92 Then
            E3 = "U"
        ElseIf A3 = 93 Then
            E3 = "Np"
        ElseIf A3 = 94 Then
            E3 = "Pu"
        ElseIf A3 = 95 Then
            E3 = "Am"
        End If
    End Sub

    Private Sub AtomicNumber3_Click(sender As Object, e As EventArgs) Handles AtomicNumber3.Click

    End Sub

    Private Sub MassNumber3_Click(sender As Object, e As EventArgs) Handles MassNumber3.Click

    End Sub

    Private Sub Compute_Click(sender As Object, e As EventArgs) Handles Compute.Click
        checkIfEmpty()

        Dim A, B, D, M, C, Energy As Double
        A = Val(MassReactant1.Text) * 10 ^ Val(Exponent1.Text)
        B = Val(MassProduct1.Text) * 10 ^ Val(Exponent2.Text)
        D = Val(MassProduct2.Text) * 10 ^ Val(Exponent3.Text)
        C = 3 * 10 ^ 8

        Function massDefectFunction (x As Double, y As Double, z As Double) As Double
            Return x - (y + z)
        End Function

        'M = A - (B + D)
        M = massDefectFunction(A, B, D)

        Function einsteinFunction (x As Double,y As Double) As Double
            Return x * y ^ 2
        End Function

        Energy = einsteinFunction(M, C)

        EnergyReleased.Text = Energy
        MassDefect.Text = M
    
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        clearProcedure()
    End Sub

    Private Sub clearProcedure() 'clear the TextBoxes
        MassReactant1.Text = ""
        MassProduct1.Text = ""
        MassProduct2.Text = ""
        Exponent1.Text = ""
        Exponent2.Text = ""
        Exponent3.Text = ""
    End Sub
    
    Private Sub checkIfEmpty() 'To check if TextBoxes are filled
        If MassReactant1.Text = "" Then
            MsgBox("Put a value for the Reactant")
        ElseIf MassProduct1.Text = "" Then
            MsgBox("Put a value for the First Product")
        ElseIf MassProduct2.Text = "" Then
            MsgBox("Put a value for the Second Product")
        ElseIf Exponent1.Text = "" Then
            MsgBox("Put an exponent for the Reactant")
        ElseIf Exponent2.Text = "" Then
            MsgBox("Put an exponent for the First Product")
        ElseIf Exponent3.Text = "" Then 
            MsgBox("Put an exponent for the Second Product")
        End If
    End Sub

End Class
