Public Class Form1
    Public pi As Single = 2 * Math.Asin(1)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calculate_Btn.Click
        ' normal operation'
        If Operator1.SelectedItem = "+" Then
            Result1.Text = Val(Number1.Text) + Val(Number2.Text)
        ElseIf Operator1.SelectedItem = "-" Then
            Result1.Text = Val(Number1.Text) - Val(Number2.Text)
        ElseIf Operator1.SelectedItem = "*" Then
            Result1.Text = Val(Number1.Text) * Val(Number2.Text)
        ElseIf Operator1.SelectedItem = "/" Then
            Result1.Text = Val(Number1.Text) / Val(Number2.Text)
        End If

        ' absolute value'
        If (AbsInput.Text <> "number") Then
            AbsResult.Text = Math.Abs(Val(AbsInput.Text))
        End If

        ' exponential operation'
        If (ExpInput.Text <> "number") Then
            ExpResult.Text = Math.Exp(Val(ExpInput.Text))
        End If

        ' fix value'
        If (FixInput.Text <> "number") Then
            FixResult.Text = Fix(Val(FixInput.Text))
        End If

        ' Int function'
        If (IntInput.Text <> "number") Then
            IntResult.Text = Int(Val(IntInput.Text))
        End If

        ' Log function'
        If (LogInput.Text <> "number") Then
            LogResult.Text = Math.Log(Val(LogInput.Text))
        End If

        ' Round function'
        If (RoundInput.Text <> "number") Then
            RoundResult.Text = Math.Round(Val(RoundInput.Text))
        End If

        ' Square root function'
        If (SqrtInput.Text <> "number") Then
            SqrtResult.Text = Math.Sqrt(Val(SqrtInput.Text))
        End If

        ' Sin function'
        If (SinInput.Text <> "angle (radian)") Then
            SinResult.Text = Math.Round(Math.Sin(Val(SinInput.Text)), 4)
        End If

        ' Cos function'
        If (CosInput.Text <> "angle (radian)") Then
            CosResult.Text = Math.Round(Math.Cos(Val(CosInput.Text)), 4)
        End If

        ' Tan function'
        If (TanInput.Text <> "angle (radian)") Then
            TanResult.Text = Math.Round(Math.Tan(Val(TanInput.Text)), 4)
        End If

        ' Asin function'
        If (AsinInput.Text <> "value") Then
            AsinResult.Text = Math.Round(Math.Asin(Val(AsinInput.Text)), 4) & " rad"
        End If

        ' Acos function'
        If (AcosInput.Text <> "value") Then
            AcosResult.Text = Math.Round(Math.Acos(Val(AcosInput.Text)), 4) & " rad"
        End If

        ' Atan fucntion'
        If (AtanInput.Text <> "value") Then
            AtanResult.Text = Math.Round(Math.Atan(Val(AtanInput.Text)), 4) & " rad"
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear_Btn.Click
        Number1.Text = "number"
        Number2.Text = "number"
        Result1.Text = "result"
        AbsInput.Text = "number"
        AbsResult.Text = "absolute value"
        Operator1.Text = ""
        ExpInput.Text = "number"
        ExpResult.Text = "exponential value"
        FixInput.Text = "number"
        FixResult.Text = "fix value"
        IntInput.Text = "number"
        IntResult.Text = "int value"
        LogInput.Text = "number"
        LogResult.Text = "log value"
        RoundInput.Text = "number"
        RoundResult.Text = "round value"
        SqrtInput.Text = "number"
        SqrtResult.Text = "square root value"
        SinInput.Text = "angle (radian)"
        SinResult.Text = "sin value"
        CosInput.Text = "angle (radian)"
        CosResult.Text = "cos value"
        TanInput.Text = "angle (radian)"
        TanResult.Text = "tan value"
        AsinInput.Text = "value"
        AsinResult.Text = "angle (radian)"
        AcosInput.Text = "value"
        AcosResult.Text = "angle (radian)"
        AtanInput.Text = "value"
        AtanResult.Text = "angle (radian)"
        RndDisplay.Text = "?"
    End Sub

    Private Sub Number1_Click(sender As Object, e As EventArgs) Handles Number1.Click
        Number1.Text = ""
    End Sub

    Private Sub Number2_Click(sender As Object, e As EventArgs) Handles Number2.Click
        Number2.Text = ""
    End Sub

    Private Sub AbsInput_Click(sender As Object, e As EventArgs) Handles AbsInput.Click
        AbsInput.Text = ""
    End Sub

    Private Sub ExpInput_Click(sender As Object, e As EventArgs) Handles ExpInput.Click
        ExpInput.Text = ""
    End Sub

    Private Sub FixInput_Click(sender As Object, e As EventArgs) Handles FixInput.Click
        FixInput.Text = ""
    End Sub

    Private Sub IntInput_Click(sender As Object, e As EventArgs) Handles IntInput.Click
        IntInput.Text = ""
    End Sub

    Private Sub LogInput_Click(sender As Object, e As EventArgs) Handles LogInput.Click
        LogInput.Text = ""
    End Sub

    Private Sub RoundInput_Click(sender As Object, e As EventArgs) Handles RoundInput.Click
        RoundInput.Text = ""
    End Sub

    Private Sub SqrtInput_Click(sender As Object, e As EventArgs) Handles SqrtInput.Click
        SqrtInput.Text = ""
    End Sub

    Private Sub RndBtn_Click(sender As Object, e As EventArgs) Handles RndBtn.Click
        RndDisplay.Text = Int(VBMath.Rnd() * 100) + 1
    End Sub

    Private Sub SinInput_Click(sender As Object, e As EventArgs) Handles SinInput.Click
        SinInput.Text = ""
    End Sub

    Private Sub CosInput_Click(sender As Object, e As EventArgs) Handles CosInput.Click
        CosInput.Text = ""
    End Sub

    Private Sub TanInput_Click(sender As Object, e As EventArgs) Handles TanInput.Click
        TanInput.Text = ""
    End Sub

    Private Sub AsinInput_Click(sender As Object, e As EventArgs) Handles AsinInput.Click
        AsinInput.Text = ""
    End Sub

    Private Sub AcosInput_Click(sender As Object, e As EventArgs) Handles AcosInput.Click
        AcosInput.Text = ""
    End Sub

    Private Sub AtanInput_Click(sender As Object, e As EventArgs) Handles AtanInput.Click
        AtanInput.Text = ""
    End Sub

    Private Sub FormatNum_Click(sender As Object, e As EventArgs) Handles FormatNum.Click
        If (FormatNumInput.Text <> "number") Then
            gnum.Text = Format((Val(FormatNumInput.Text)), "General Number")
            fnum.Text = Format((Val(FormatNumInput.Text)), "Fixed")
            snum.Text = Format((Val(FormatNumInput.Text)), "Standard")
            cnum.Text = Format((Val(FormatNumInput.Text)), "Currency")
            pnum.Text = Format((Val(FormatNumInput.Text)), "Percent")
        End If
    End Sub

    Private Sub FormatNumInput_Click(sender As Object, e As EventArgs) Handles FormatNumInput.Click
        FormatNumInput.Text = ""
    End Sub

    Private Sub ClearNum_Click(sender As Object, e As EventArgs) Handles ClearNum.Click
        gnum.Text = "value"
        fnum.Text = "value"
        snum.Text = "value"
        cnum.Text = "value"
        pnum.Text = "value"
        FormatNumInput.Text = "number"
    End Sub

    Private Sub DisplayDate_Click(sender As Object, e As EventArgs) Handles DisplayDate.Click
        gdate.Text = Format(Now, "General Date")
        ldate.Text = Format(Now, "Long Date")
        sdate.Text = Format(Now, "short Date")
        ltime.Text = Format(Now, "Long Time")
        stime.Text = Format(Now, "Short Time")
    End Sub

    Private Sub ClearDate_Click(sender As Object, e As EventArgs) Handles ClearDate.Click
        If (gdate.Text <> "value") Then
            gdate.Text = "value"
            ldate.Text = "value"
            sdate.Text = "value"
            ltime.Text = "value"
            stime.Text = "value"
        End If
    End Sub
End Class
