Public Class frmMain

    Private Sub CalcNFL()
        ' Declare needed variables
        Dim dblAttempts As Double
        Dim dblCompletions As Double
        Dim dblYards As Double
        Dim dblTDs As Double
        Dim dblINTs As Double
        Dim dblA As Double
        Dim dblB As Double
        Dim dblC As Double
        Dim dblD As Double
        Dim dblRating As Double

        ' Get input from text boxes
        Double.TryParse(txtAttempts.Text, dblAttempts)
        Double.TryParse(txtCompletions.Text, dblCompletions)
        Double.TryParse(txtYards.Text, dblYards)
        Double.TryParse(txtTDs.Text, dblTDs)
        Double.TryParse(txtINTs.Text, dblINTs)

        ' Calculate the sub parts of the formula
        dblA = ((dblCompletions / dblAttempts) - 0.3) * 5.0
        dblB = ((dblYards / dblAttempts) - 3) * 0.25
        dblC = (dblTDs / dblAttempts) * 20.0
        dblD = 2.375 - ((dblINTs / dblAttempts) * 25.0)

        ' Check that sub parts fall in min/max of 0 to 2.375
        If dblA < 0 Then
            dblA = 0.0
        End If
        If dblA > 2.375 Then
            dblA = 2.375
        End If
        If dblB < 0 Then
            dblB = 0.0
        End If
        If dblB > 2.375 Then
            dblB = 2.375
        End If
        If dblC < 0 Then
            dblC = 0.0
        End If
        If dblC > 2.375 Then
            dblC = 2.375
        End If
        If dblD < 0 Then
            dblD = 0.0
        End If
        If dblD > 2.375 Then
            dblD = 2.375
        End If

        ' Calculate the main formula
        dblRating = ((dblA + dblB + dblC + dblD) / 6) * 100

        ' Assign the rating to the rating label
        lblRating.Text = dblRating.ToString("N1")
    End Sub

    Private Sub CalcNCAA()
        ' Declare needed variables
        Dim intAttempts As Integer
        Dim intCompletions As Integer
        Dim intYards As Integer
        Dim intTDs As Integer
        Dim intINTs As Integer
        Dim dblRating As Double

        ' Get input from text boxes
        Integer.TryParse(txtAttempts.Text, intAttempts)
        Integer.TryParse(txtCompletions.Text, intCompletions)
        Integer.TryParse(txtYards.Text, intYards)
        Integer.TryParse(txtTDs.Text, intTDs)
        Integer.TryParse(txtINTs.Text, intINTs)

        ' Calculate the rating
        dblRating = ((8.4 * intYards) + (330 * intTDs) + (100 * intCompletions) - (200 * intINTs)) / intAttempts

        ' Assign the rating to the rating label
        lblRating.Text = dblRating.ToString("N1")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Select NFL Rating as default
        rdoNFL.Select()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Make sure text boxes contain data, set flag to false if input error
        Dim blnValidInput As Boolean = True

        If txtAttempts.Text = String.Empty Then
            blnValidInput = False
        End If
        If txtCompletions.Text = String.Empty Then
            blnValidInput = False
        End If
        If txtYards.Text = String.Empty Then
            blnValidInput = False
        End If
        If txtTDs.Text = String.Empty Then
            blnValidInput = False
        End If
        If txtINTs.Text = String.Empty Then
            blnValidInput = False
        End If

        ' If flag is true, perform the calculation based on which radio button selected
        ' If flag is false, show MessageBox informing user there is invalid input.
        If blnValidInput Then
            If rdoNFL.Checked Then
                CalcNFL()
            Else
                CalcNCAA()
            End If
        Else
            MessageBox.Show("Invalid input in text boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        txtAttempts.Focus()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles rdoNFL.CheckedChanged, rdoNCAA.CheckedChanged
        ' Clear the text boxes and label when league is changed
        txtAttempts.Text = String.Empty
        txtCompletions.Text = String.Empty
        txtYards.Text = String.Empty
        txtTDs.Text = String.Empty
        txtINTs.Text = String.Empty
        lblRating.Text = String.Empty

        txtAttempts.Focus()
    End Sub

    Private Sub txtAttempts_GotFocus(sender As Object, e As EventArgs) Handles txtAttempts.GotFocus, txtCompletions.GotFocus, txtYards.GotFocus, txtTDs.GotFocus, txtINTs.GotFocus
        ' Set the text boxes to automaticall select all when focused on,
        ' making rapid input of stats easier, while retaining input information
        ' after calculation to manually verify input.
        sender.SelectAll()
    End Sub

    Private Sub txtAttempts_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAttempts.KeyPress, txtCompletions.KeyPress, txtYards.KeyPress, txtTDs.KeyPress, txtINTs.KeyPress
        ' Limit input to numbers and backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
