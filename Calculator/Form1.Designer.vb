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
        Me.Number1 = New System.Windows.Forms.TextBox()
        Me.Operator1 = New System.Windows.Forms.ComboBox()
        Me.Number2 = New System.Windows.Forms.TextBox()
        Me.Equalation1 = New System.Windows.Forms.Label()
        Me.Result1 = New System.Windows.Forms.Label()
        Me.Calculate_Btn = New System.Windows.Forms.Button()
        Me.Clear_Btn = New System.Windows.Forms.Button()
        Me.AbsInput = New System.Windows.Forms.TextBox()
        Me.NormalOperation = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AbsResult = New System.Windows.Forms.Label()
        Me.NormalOpearationBG = New System.Windows.Forms.Label()
        Me.ExponentialLabel = New System.Windows.Forms.Label()
        Me.ExpInput = New System.Windows.Forms.TextBox()
        Me.ExpResult = New System.Windows.Forms.Label()
        Me.FixLabel = New System.Windows.Forms.Label()
        Me.FixInput = New System.Windows.Forms.TextBox()
        Me.FixResult = New System.Windows.Forms.Label()
        Me.IntLabel = New System.Windows.Forms.Label()
        Me.IntInput = New System.Windows.Forms.TextBox()
        Me.IntResult = New System.Windows.Forms.Label()
        Me.LogLabel = New System.Windows.Forms.Label()
        Me.LogInput = New System.Windows.Forms.TextBox()
        Me.LogResult = New System.Windows.Forms.Label()
        Me.RoundLabel = New System.Windows.Forms.Label()
        Me.RoundInput = New System.Windows.Forms.TextBox()
        Me.RoundResult = New System.Windows.Forms.Label()
        Me.SqrtLabel = New System.Windows.Forms.Label()
        Me.SqrtInput = New System.Windows.Forms.TextBox()
        Me.SqrtResult = New System.Windows.Forms.Label()
        Me.NumberRandomiser = New System.Windows.Forms.Label()
        Me.RndDisplay = New System.Windows.Forms.Label()
        Me.RndBtn = New System.Windows.Forms.Button()
        Me.SinLabel = New System.Windows.Forms.Label()
        Me.SinInput = New System.Windows.Forms.TextBox()
        Me.SinResult = New System.Windows.Forms.Label()
        Me.CosLabel = New System.Windows.Forms.Label()
        Me.CosInput = New System.Windows.Forms.TextBox()
        Me.CosResult = New System.Windows.Forms.Label()
        Me.TanLabel = New System.Windows.Forms.Label()
        Me.TanResult = New System.Windows.Forms.Label()
        Me.TanInput = New System.Windows.Forms.TextBox()
        Me.AsinLabel = New System.Windows.Forms.Label()
        Me.AcosLabel = New System.Windows.Forms.Label()
        Me.AtanLabel = New System.Windows.Forms.Label()
        Me.AsinInput = New System.Windows.Forms.TextBox()
        Me.AcosInput = New System.Windows.Forms.TextBox()
        Me.AtanInput = New System.Windows.Forms.TextBox()
        Me.AsinResult = New System.Windows.Forms.Label()
        Me.AcosResult = New System.Windows.Forms.Label()
        Me.AtanResult = New System.Windows.Forms.Label()
        Me.RandomBG = New System.Windows.Forms.Label()
        Me.RandomBG2 = New System.Windows.Forms.Label()
        Me.NormalOperationBG2 = New System.Windows.Forms.Label()
        Me.FormatBG2 = New System.Windows.Forms.Label()
        Me.FormatBG1 = New System.Windows.Forms.Label()
        Me.FormatBG3 = New System.Windows.Forms.Label()
        Me.FormatLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FormatNumInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gnum = New System.Windows.Forms.Label()
        Me.pnum = New System.Windows.Forms.Label()
        Me.cnum = New System.Windows.Forms.Label()
        Me.snum = New System.Windows.Forms.Label()
        Me.fnum = New System.Windows.Forms.Label()
        Me.FormatNum = New System.Windows.Forms.Button()
        Me.ClearNum = New System.Windows.Forms.Button()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.ldate = New System.Windows.Forms.Label()
        Me.sdate = New System.Windows.Forms.Label()
        Me.ltime = New System.Windows.Forms.Label()
        Me.stime = New System.Windows.Forms.Label()
        Me.gdate = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DisplayDate = New System.Windows.Forms.Button()
        Me.ClearDate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Number1
        '
        Me.Number1.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number1.Location = New System.Drawing.Point(9, 45)
        Me.Number1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Number1.Name = "Number1"
        Me.Number1.Size = New System.Drawing.Size(268, 39)
        Me.Number1.TabIndex = 0
        Me.Number1.Text = "number"
        '
        'Operator1
        '
        Me.Operator1.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Operator1.FormattingEnabled = True
        Me.Operator1.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.Operator1.Location = New System.Drawing.Point(285, 45)
        Me.Operator1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Operator1.Name = "Operator1"
        Me.Operator1.Size = New System.Drawing.Size(68, 40)
        Me.Operator1.TabIndex = 1
        '
        'Number2
        '
        Me.Number2.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number2.Location = New System.Drawing.Point(360, 45)
        Me.Number2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Number2.Name = "Number2"
        Me.Number2.Size = New System.Drawing.Size(258, 39)
        Me.Number2.TabIndex = 2
        Me.Number2.Text = "number"
        '
        'Equalation1
        '
        Me.Equalation1.AutoSize = True
        Me.Equalation1.BackColor = System.Drawing.Color.Brown
        Me.Equalation1.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Equalation1.ForeColor = System.Drawing.SystemColors.Control
        Me.Equalation1.Location = New System.Drawing.Point(636, 50)
        Me.Equalation1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Equalation1.Name = "Equalation1"
        Me.Equalation1.Size = New System.Drawing.Size(30, 33)
        Me.Equalation1.TabIndex = 3
        Me.Equalation1.Text = "="
        '
        'Result1
        '
        Me.Result1.BackColor = System.Drawing.Color.Gray
        Me.Result1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Result1.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result1.ForeColor = System.Drawing.Color.White
        Me.Result1.Location = New System.Drawing.Point(680, 45)
        Me.Result1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Result1.Name = "Result1"
        Me.Result1.Size = New System.Drawing.Size(263, 38)
        Me.Result1.TabIndex = 4
        Me.Result1.Text = "result"
        Me.Result1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Calculate_Btn
        '
        Me.Calculate_Btn.AutoSize = True
        Me.Calculate_Btn.BackColor = System.Drawing.Color.GreenYellow
        Me.Calculate_Btn.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculate_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Calculate_Btn.Location = New System.Drawing.Point(402, 679)
        Me.Calculate_Btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Calculate_Btn.Name = "Calculate_Btn"
        Me.Calculate_Btn.Size = New System.Drawing.Size(216, 60)
        Me.Calculate_Btn.TabIndex = 5
        Me.Calculate_Btn.Text = "Calculate"
        Me.Calculate_Btn.UseVisualStyleBackColor = False
        '
        'Clear_Btn
        '
        Me.Clear_Btn.AutoSize = True
        Me.Clear_Btn.BackColor = System.Drawing.Color.Tomato
        Me.Clear_Btn.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_Btn.ForeColor = System.Drawing.Color.Black
        Me.Clear_Btn.Location = New System.Drawing.Point(676, 679)
        Me.Clear_Btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Clear_Btn.Name = "Clear_Btn"
        Me.Clear_Btn.Size = New System.Drawing.Size(136, 60)
        Me.Clear_Btn.TabIndex = 6
        Me.Clear_Btn.Text = "Clear"
        Me.Clear_Btn.UseVisualStyleBackColor = False
        '
        'AbsInput
        '
        Me.AbsInput.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbsInput.Location = New System.Drawing.Point(9, 157)
        Me.AbsInput.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.AbsInput.Name = "AbsInput"
        Me.AbsInput.Size = New System.Drawing.Size(268, 29)
        Me.AbsInput.TabIndex = 7
        Me.AbsInput.Text = "number"
        '
        'NormalOperation
        '
        Me.NormalOperation.BackColor = System.Drawing.Color.Brown
        Me.NormalOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NormalOperation.ForeColor = System.Drawing.SystemColors.Control
        Me.NormalOperation.Location = New System.Drawing.Point(4, 3)
        Me.NormalOperation.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.NormalOperation.Name = "NormalOperation"
        Me.NormalOperation.Size = New System.Drawing.Size(191, 38)
        Me.NormalOperation.TabIndex = 8
        Me.NormalOperation.Text = "Normal operation"
        Me.NormalOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 126)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 38)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Absolute"
        '
        'AbsResult
        '
        Me.AbsResult.BackColor = System.Drawing.Color.IndianRed
        Me.AbsResult.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbsResult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AbsResult.Location = New System.Drawing.Point(9, 192)
        Me.AbsResult.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.AbsResult.Name = "AbsResult"
        Me.AbsResult.Size = New System.Drawing.Size(268, 29)
        Me.AbsResult.TabIndex = 11
        Me.AbsResult.Text = "absolute value"
        Me.AbsResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NormalOpearationBG
        '
        Me.NormalOpearationBG.BackColor = System.Drawing.Color.Brown
        Me.NormalOpearationBG.Location = New System.Drawing.Point(4, 3)
        Me.NormalOpearationBG.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.NormalOpearationBG.Name = "NormalOpearationBG"
        Me.NormalOpearationBG.Size = New System.Drawing.Size(960, 111)
        Me.NormalOpearationBG.TabIndex = 10
        '
        'ExponentialLabel
        '
        Me.ExponentialLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExponentialLabel.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExponentialLabel.Location = New System.Drawing.Point(345, 117)
        Me.ExponentialLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ExponentialLabel.Name = "ExponentialLabel"
        Me.ExponentialLabel.Size = New System.Drawing.Size(166, 38)
        Me.ExponentialLabel.TabIndex = 12
        Me.ExponentialLabel.Text = "Exponential"
        Me.ExponentialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExpInput
        '
        Me.ExpInput.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpInput.Location = New System.Drawing.Point(348, 157)
        Me.ExpInput.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ExpInput.Name = "ExpInput"
        Me.ExpInput.Size = New System.Drawing.Size(268, 29)
        Me.ExpInput.TabIndex = 13
        Me.ExpInput.Text = "number"
        '
        'ExpResult
        '
        Me.ExpResult.BackColor = System.Drawing.Color.IndianRed
        Me.ExpResult.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpResult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExpResult.Location = New System.Drawing.Point(349, 192)
        Me.ExpResult.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ExpResult.Name = "ExpResult"
        Me.ExpResult.Size = New System.Drawing.Size(268, 29)
        Me.ExpResult.TabIndex = 14
        Me.ExpResult.Text = "exponential value"
        Me.ExpResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FixLabel
        '
        Me.FixLabel.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FixLabel.Location = New System.Drawing.Point(671, 117)
        Me.FixLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.FixLabel.Name = "FixLabel"
        Me.FixLabel.Size = New System.Drawing.Size(166, 38)
        Me.FixLabel.TabIndex = 15
        Me.FixLabel.Text = "Fix (number)"
        Me.FixLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FixInput
        '
        Me.FixInput.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FixInput.Location = New System.Drawing.Point(675, 157)
        Me.FixInput.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.FixInput.Name = "FixInput"
        Me.FixInput.Size = New System.Drawing.Size(268, 29)
        Me.FixInput.TabIndex = 16
        Me.FixInput.Text = "number"
        '
        'FixResult
        '
        Me.FixResult.BackColor = System.Drawing.Color.IndianRed
        Me.FixResult.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FixResult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FixResult.Location = New System.Drawing.Point(675, 192)
        Me.FixResult.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.FixResult.Name = "FixResult"
        Me.FixResult.Size = New System.Drawing.Size(268, 29)
        Me.FixResult.TabIndex = 17
        Me.FixResult.Text = "fix value"
        Me.FixResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IntLabel
        '
        Me.IntLabel.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntLabel.Location = New System.Drawing.Point(4, 221)
        Me.IntLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.IntLabel.Name = "IntLabel"
        Me.IntLabel.Size = New System.Drawing.Size(50, 38)
        Me.IntLabel.TabIndex = 18
        Me.IntLabel.Text = "Int"
        Me.IntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IntInput
        '
        Me.IntInput.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntInput.Location = New System.Drawing.Point(8, 263)
        Me.IntInput.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.IntInput.Name = "IntInput"
        Me.IntInput.Size = New System.Drawing.Size(268, 29)
        Me.IntInput.TabIndex = 19
        Me.IntInput.Text = "number"
        '
        'IntResult
        '
        Me.IntResult.BackColor = System.Drawing.Color.IndianRed
        Me.IntResult.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntResult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IntResult.Location = New System.Drawing.Point(9, 298)
        Me.IntResult.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.IntResult.Name = "IntResult"
        Me.IntResult.Size = New System.Drawing.Size(268, 29)
        Me.IntResult.TabIndex = 20
        Me.IntResult.Text = "int value"
        '
        'LogLabel
        '
        Me.LogLabel.AutoSize = True
        Me.LogLabel.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogLabel.Location = New System.Drawing.Point(344, 230)
        Me.LogLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LogLabel.Name = "LogLabel"
        Me.LogLabel.Size = New System.Drawing.Size(36, 20)
        Me.LogLabel.TabIndex = 21
        Me.LogLabel.Text = "Log"
        Me.LogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogInput
        '
        Me.LogInput.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInput.Location = New System.Drawing.Point(349, 263)
        Me.LogInput.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInput.Name = "LogInput"
        Me.LogInput.Size = New System.Drawing.Size(268, 29)
        Me.LogInput.TabIndex = 22
        Me.LogInput.Text = "number"
        '
        'LogResult
        '
        Me.LogResult.BackColor = System.Drawing.Color.IndianRed
        Me.LogResult.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogResult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LogResult.Location = New System.Drawing.Point(349, 298)
        Me.LogResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LogResult.Name = "LogResult"
        Me.LogResult.Size = New System.Drawing.Size(268, 29)
        Me.LogResult.TabIndex = 23
        Me.LogResult.Text = "log value"
        Me.LogResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RoundLabel
        '
        Me.RoundLabel.AutoSize = True
        Me.RoundLabel.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundLabel.Location = New System.Drawing.Point(671, 239)
        Me.RoundLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RoundLabel.Name = "RoundLabel"
        Me.RoundLabel.Size = New System.Drawing.Size(54, 20)
        Me.RoundLabel.TabIndex = 24
        Me.RoundLabel.Text = "Round"
        Me.RoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RoundInput
        '
        Me.RoundInput.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundInput.Location = New System.Drawing.Point(675, 263)
        Me.RoundInput.Margin = New System.Windows.Forms.Padding(4)
        Me.RoundInput.Name = "RoundInput"
        Me.RoundInput.Size = New System.Drawing.Size(268, 29)
        Me.RoundInput.TabIndex = 25
        Me.RoundInput.Text = "number"
        '
        'RoundResult
        '
        Me.RoundResult.BackColor = System.Drawing.Color.IndianRed
        Me.RoundResult.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundResult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RoundResult.Location = New System.Drawing.Point(676, 298)
        Me.RoundResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RoundResult.Name = "RoundResult"
        Me.RoundResult.Size = New System.Drawing.Size(268, 29)
        Me.RoundResult.TabIndex = 26
        Me.RoundResult.Text = "round value"
        Me.RoundResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SqrtLabel
        '
        Me.SqrtLabel.AutoSize = True
        Me.SqrtLabel.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SqrtLabel.Location = New System.Drawing.Point(5, 341)
        Me.SqrtLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SqrtLabel.Name = "SqrtLabel"
        Me.SqrtLabel.Size = New System.Drawing.Size(108, 20)
        Me.SqrtLabel.TabIndex = 27
        Me.SqrtLabel.Text = "Square root"
        Me.SqrtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SqrtInput
        '
        Me.SqrtInput.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SqrtInput.Location = New System.Drawing.Point(8, 365)
        Me.SqrtInput.Margin = New System.Windows.Forms.Padding(4)
        Me.SqrtInput.Name = "SqrtInput"
        Me.SqrtInput.Size = New System.Drawing.Size(268, 29)
        Me.SqrtInput.TabIndex = 28
        Me.SqrtInput.Text = "number"
        '
        'SqrtResult
        '
        Me.SqrtResult.BackColor = System.Drawing.Color.IndianRed
        Me.SqrtResult.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SqrtResult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SqrtResult.Location = New System.Drawing.Point(9, 398)
        Me.SqrtResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SqrtResult.Name = "SqrtResult"
        Me.SqrtResult.Size = New System.Drawing.Size(268, 29)
        Me.SqrtResult.TabIndex = 29
        Me.SqrtResult.Text = "square root value"
        Me.SqrtResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumberRandomiser
        '
        Me.NumberRandomiser.AutoSize = True
        Me.NumberRandomiser.BackColor = System.Drawing.Color.Indigo
        Me.NumberRandomiser.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.NumberRandomiser.Location = New System.Drawing.Point(86, 489)
        Me.NumberRandomiser.Name = "NumberRandomiser"
        Me.NumberRandomiser.Size = New System.Drawing.Size(140, 22)
        Me.NumberRandomiser.TabIndex = 30
        Me.NumberRandomiser.Text = "Random Number"
        Me.NumberRandomiser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RndDisplay
        '
        Me.RndDisplay.BackColor = System.Drawing.Color.Black
        Me.RndDisplay.Font = New System.Drawing.Font("Consolas", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RndDisplay.ForeColor = System.Drawing.SystemColors.Control
        Me.RndDisplay.Location = New System.Drawing.Point(90, 520)
        Me.RndDisplay.Name = "RndDisplay"
        Me.RndDisplay.Size = New System.Drawing.Size(127, 117)
        Me.RndDisplay.TabIndex = 31
        Me.RndDisplay.Text = "?"
        Me.RndDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RndBtn
        '
        Me.RndBtn.Location = New System.Drawing.Point(107, 655)
        Me.RndBtn.Name = "RndBtn"
        Me.RndBtn.Size = New System.Drawing.Size(90, 36)
        Me.RndBtn.TabIndex = 32
        Me.RndBtn.Text = "Random"
        Me.RndBtn.UseVisualStyleBackColor = True
        '
        'SinLabel
        '
        Me.SinLabel.AutoSize = True
        Me.SinLabel.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SinLabel.Location = New System.Drawing.Point(349, 360)
        Me.SinLabel.Name = "SinLabel"
        Me.SinLabel.Size = New System.Drawing.Size(36, 20)
        Me.SinLabel.TabIndex = 33
        Me.SinLabel.Text = "Sin"
        Me.SinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SinInput
        '
        Me.SinInput.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SinInput.Location = New System.Drawing.Point(349, 384)
        Me.SinInput.Name = "SinInput"
        Me.SinInput.Size = New System.Drawing.Size(268, 29)
        Me.SinInput.TabIndex = 34
        Me.SinInput.Text = "angle (radian)"
        '
        'SinResult
        '
        Me.SinResult.BackColor = System.Drawing.Color.IndianRed
        Me.SinResult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SinResult.Location = New System.Drawing.Point(350, 417)
        Me.SinResult.Name = "SinResult"
        Me.SinResult.Size = New System.Drawing.Size(268, 29)
        Me.SinResult.TabIndex = 35
        Me.SinResult.Text = "sin value"
        Me.SinResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CosLabel
        '
        Me.CosLabel.AutoSize = True
        Me.CosLabel.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CosLabel.Location = New System.Drawing.Point(349, 465)
        Me.CosLabel.Name = "CosLabel"
        Me.CosLabel.Size = New System.Drawing.Size(36, 20)
        Me.CosLabel.TabIndex = 36
        Me.CosLabel.Text = "Cos"
        '
        'CosInput
        '
        Me.CosInput.Location = New System.Drawing.Point(349, 491)
        Me.CosInput.Name = "CosInput"
        Me.CosInput.Size = New System.Drawing.Size(269, 29)
        Me.CosInput.TabIndex = 37
        Me.CosInput.Text = "angle (radian)"
        '
        'CosResult
        '
        Me.CosResult.BackColor = System.Drawing.Color.IndianRed
        Me.CosResult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CosResult.Location = New System.Drawing.Point(350, 527)
        Me.CosResult.Name = "CosResult"
        Me.CosResult.Size = New System.Drawing.Size(268, 29)
        Me.CosResult.TabIndex = 38
        Me.CosResult.Text = "cos value"
        Me.CosResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TanLabel
        '
        Me.TanLabel.AutoSize = True
        Me.TanLabel.Location = New System.Drawing.Point(348, 574)
        Me.TanLabel.Name = "TanLabel"
        Me.TanLabel.Size = New System.Drawing.Size(40, 22)
        Me.TanLabel.TabIndex = 39
        Me.TanLabel.Text = "Tan"
        Me.TanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TanResult
        '
        Me.TanResult.BackColor = System.Drawing.Color.IndianRed
        Me.TanResult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TanResult.Location = New System.Drawing.Point(349, 631)
        Me.TanResult.Name = "TanResult"
        Me.TanResult.Size = New System.Drawing.Size(268, 29)
        Me.TanResult.TabIndex = 40
        Me.TanResult.Text = "tan value"
        Me.TanResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TanInput
        '
        Me.TanInput.Location = New System.Drawing.Point(349, 599)
        Me.TanInput.Name = "TanInput"
        Me.TanInput.Size = New System.Drawing.Size(268, 29)
        Me.TanInput.TabIndex = 41
        Me.TanInput.Text = "angle (radian)"
        '
        'AsinLabel
        '
        Me.AsinLabel.AutoSize = True
        Me.AsinLabel.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AsinLabel.Location = New System.Drawing.Point(676, 360)
        Me.AsinLabel.Name = "AsinLabel"
        Me.AsinLabel.Size = New System.Drawing.Size(45, 20)
        Me.AsinLabel.TabIndex = 42
        Me.AsinLabel.Text = "Asin"
        Me.AsinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AcosLabel
        '
        Me.AcosLabel.AutoSize = True
        Me.AcosLabel.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcosLabel.Location = New System.Drawing.Point(676, 465)
        Me.AcosLabel.Name = "AcosLabel"
        Me.AcosLabel.Size = New System.Drawing.Size(45, 20)
        Me.AcosLabel.TabIndex = 43
        Me.AcosLabel.Text = "Acos"
        Me.AcosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AtanLabel
        '
        Me.AtanLabel.AutoSize = True
        Me.AtanLabel.Location = New System.Drawing.Point(676, 574)
        Me.AtanLabel.Name = "AtanLabel"
        Me.AtanLabel.Size = New System.Drawing.Size(50, 22)
        Me.AtanLabel.TabIndex = 44
        Me.AtanLabel.Text = "Atan"
        Me.AtanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AsinInput
        '
        Me.AsinInput.Location = New System.Drawing.Point(676, 384)
        Me.AsinInput.Name = "AsinInput"
        Me.AsinInput.Size = New System.Drawing.Size(268, 29)
        Me.AsinInput.TabIndex = 45
        Me.AsinInput.Text = "value"
        '
        'AcosInput
        '
        Me.AcosInput.Location = New System.Drawing.Point(676, 491)
        Me.AcosInput.Name = "AcosInput"
        Me.AcosInput.Size = New System.Drawing.Size(268, 29)
        Me.AcosInput.TabIndex = 46
        Me.AcosInput.Text = "value"
        '
        'AtanInput
        '
        Me.AtanInput.Location = New System.Drawing.Point(676, 599)
        Me.AtanInput.Name = "AtanInput"
        Me.AtanInput.Size = New System.Drawing.Size(268, 29)
        Me.AtanInput.TabIndex = 47
        Me.AtanInput.Text = "value"
        '
        'AsinResult
        '
        Me.AsinResult.BackColor = System.Drawing.Color.IndianRed
        Me.AsinResult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AsinResult.Location = New System.Drawing.Point(676, 417)
        Me.AsinResult.Name = "AsinResult"
        Me.AsinResult.Size = New System.Drawing.Size(268, 29)
        Me.AsinResult.TabIndex = 48
        Me.AsinResult.Text = "angle (radian)"
        Me.AsinResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AcosResult
        '
        Me.AcosResult.BackColor = System.Drawing.Color.IndianRed
        Me.AcosResult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AcosResult.Location = New System.Drawing.Point(676, 527)
        Me.AcosResult.Name = "AcosResult"
        Me.AcosResult.Size = New System.Drawing.Size(268, 29)
        Me.AcosResult.TabIndex = 49
        Me.AcosResult.Text = "angle (radian)"
        Me.AcosResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AtanResult
        '
        Me.AtanResult.BackColor = System.Drawing.Color.IndianRed
        Me.AtanResult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AtanResult.Location = New System.Drawing.Point(677, 631)
        Me.AtanResult.Name = "AtanResult"
        Me.AtanResult.Size = New System.Drawing.Size(268, 29)
        Me.AtanResult.TabIndex = 50
        Me.AtanResult.Text = "angle (radian)"
        Me.AtanResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RandomBG
        '
        Me.RandomBG.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RandomBG.Location = New System.Drawing.Point(15, 447)
        Me.RandomBG.Name = "RandomBG"
        Me.RandomBG.Size = New System.Drawing.Size(285, 281)
        Me.RandomBG.TabIndex = 51
        '
        'RandomBG2
        '
        Me.RandomBG2.BackColor = System.Drawing.Color.Purple
        Me.RandomBG2.Location = New System.Drawing.Point(9, 439)
        Me.RandomBG2.Name = "RandomBG2"
        Me.RandomBG2.Size = New System.Drawing.Size(297, 297)
        Me.RandomBG2.TabIndex = 53
        '
        'NormalOperationBG2
        '
        Me.NormalOperationBG2.BackColor = System.Drawing.Color.LightCoral
        Me.NormalOperationBG2.Location = New System.Drawing.Point(-4, -13)
        Me.NormalOperationBG2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.NormalOperationBG2.Name = "NormalOperationBG2"
        Me.NormalOperationBG2.Size = New System.Drawing.Size(966, 130)
        Me.NormalOperationBG2.TabIndex = 54
        '
        'FormatBG2
        '
        Me.FormatBG2.BackColor = System.Drawing.Color.Maroon
        Me.FormatBG2.Location = New System.Drawing.Point(970, -13)
        Me.FormatBG2.Name = "FormatBG2"
        Me.FormatBG2.Size = New System.Drawing.Size(353, 760)
        Me.FormatBG2.TabIndex = 55
        '
        'FormatBG1
        '
        Me.FormatBG1.BackColor = System.Drawing.Color.LightCoral
        Me.FormatBG1.Location = New System.Drawing.Point(958, -13)
        Me.FormatBG1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.FormatBG1.Name = "FormatBG1"
        Me.FormatBG1.Size = New System.Drawing.Size(51, 760)
        Me.FormatBG1.TabIndex = 56
        '
        'FormatBG3
        '
        Me.FormatBG3.BackColor = System.Drawing.Color.IndianRed
        Me.FormatBG3.Location = New System.Drawing.Point(974, -13)
        Me.FormatBG3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.FormatBG3.Name = "FormatBG3"
        Me.FormatBG3.Size = New System.Drawing.Size(349, 54)
        Me.FormatBG3.TabIndex = 57
        '
        'FormatLabel
        '
        Me.FormatLabel.AutoSize = True
        Me.FormatLabel.BackColor = System.Drawing.Color.IndianRed
        Me.FormatLabel.Font = New System.Drawing.Font("Consolas", 16.0!)
        Me.FormatLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.FormatLabel.Location = New System.Drawing.Point(1126, 3)
        Me.FormatLabel.Name = "FormatLabel"
        Me.FormatLabel.Size = New System.Drawing.Size(104, 32)
        Me.FormatLabel.TabIndex = 58
        Me.FormatLabel.Text = "Format"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(1128, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 28)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Number"
        '
        'FormatNumInput
        '
        Me.FormatNumInput.Location = New System.Drawing.Point(1022, 89)
        Me.FormatNumInput.Name = "FormatNumInput"
        Me.FormatNumInput.Size = New System.Drawing.Size(288, 29)
        Me.FormatNumInput.TabIndex = 60
        Me.FormatNumInput.Text = "number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(1017, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 28)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "percent"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(1017, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 28)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "currency"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(1017, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 28)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "standard"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(1017, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 28)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "fixed"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(1017, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 28)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "general"
        '
        'gnum
        '
        Me.gnum.Location = New System.Drawing.Point(1138, 127)
        Me.gnum.Name = "gnum"
        Me.gnum.Size = New System.Drawing.Size(172, 22)
        Me.gnum.TabIndex = 66
        Me.gnum.Text = "value"
        '
        'pnum
        '
        Me.pnum.Location = New System.Drawing.Point(1138, 245)
        Me.pnum.Name = "pnum"
        Me.pnum.Size = New System.Drawing.Size(172, 22)
        Me.pnum.TabIndex = 68
        Me.pnum.Text = "value"
        '
        'cnum
        '
        Me.cnum.Location = New System.Drawing.Point(1138, 215)
        Me.cnum.Name = "cnum"
        Me.cnum.Size = New System.Drawing.Size(172, 22)
        Me.cnum.TabIndex = 69
        Me.cnum.Text = "value"
        '
        'snum
        '
        Me.snum.Location = New System.Drawing.Point(1138, 186)
        Me.snum.Name = "snum"
        Me.snum.Size = New System.Drawing.Size(172, 22)
        Me.snum.TabIndex = 70
        Me.snum.Text = "value"
        '
        'fnum
        '
        Me.fnum.Location = New System.Drawing.Point(1138, 157)
        Me.fnum.Name = "fnum"
        Me.fnum.Size = New System.Drawing.Size(172, 22)
        Me.fnum.TabIndex = 71
        Me.fnum.Text = "value"
        '
        'FormatNum
        '
        Me.FormatNum.Location = New System.Drawing.Point(1035, 281)
        Me.FormatNum.Name = "FormatNum"
        Me.FormatNum.Size = New System.Drawing.Size(98, 46)
        Me.FormatNum.TabIndex = 72
        Me.FormatNum.Text = "Format"
        Me.FormatNum.UseVisualStyleBackColor = True
        '
        'ClearNum
        '
        Me.ClearNum.Location = New System.Drawing.Point(1190, 281)
        Me.ClearNum.Name = "ClearNum"
        Me.ClearNum.Size = New System.Drawing.Size(98, 46)
        Me.ClearNum.TabIndex = 73
        Me.ClearNum.Text = "Clear"
        Me.ClearNum.UseVisualStyleBackColor = True
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.Color.Maroon
        Me.DateLabel.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.DateLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.DateLabel.Location = New System.Drawing.Point(1127, 399)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(64, 28)
        Me.DateLabel.TabIndex = 74
        Me.DateLabel.Text = "Date"
        '
        'ldate
        '
        Me.ldate.Location = New System.Drawing.Point(1018, 501)
        Me.ldate.Name = "ldate"
        Me.ldate.Size = New System.Drawing.Size(292, 22)
        Me.ldate.TabIndex = 84
        Me.ldate.Text = "value"
        '
        'sdate
        '
        Me.sdate.Location = New System.Drawing.Point(1153, 531)
        Me.sdate.Name = "sdate"
        Me.sdate.Size = New System.Drawing.Size(157, 22)
        Me.sdate.TabIndex = 83
        Me.sdate.Text = "value"
        '
        'ltime
        '
        Me.ltime.Location = New System.Drawing.Point(1153, 560)
        Me.ltime.Name = "ltime"
        Me.ltime.Size = New System.Drawing.Size(157, 22)
        Me.ltime.TabIndex = 82
        Me.ltime.Text = "value"
        '
        'stime
        '
        Me.stime.Location = New System.Drawing.Point(1153, 587)
        Me.stime.Name = "stime"
        Me.stime.Size = New System.Drawing.Size(157, 22)
        Me.stime.TabIndex = 81
        Me.stime.Text = "value"
        '
        'gdate
        '
        Me.gdate.Location = New System.Drawing.Point(1153, 447)
        Me.gdate.Name = "gdate"
        Me.gdate.Size = New System.Drawing.Size(157, 22)
        Me.gdate.TabIndex = 80
        Me.gdate.Text = "value"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Maroon
        Me.Label13.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(1017, 447)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 22)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "general date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Maroon
        Me.Label14.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(1108, 476)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 22)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "long date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Maroon
        Me.Label15.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(1017, 531)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 22)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "short date"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Maroon
        Me.Label16.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(1017, 559)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 22)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "long time"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Maroon
        Me.Label17.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(1017, 587)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 22)
        Me.Label17.TabIndex = 75
        Me.Label17.Text = "short time"
        '
        'DisplayDate
        '
        Me.DisplayDate.Location = New System.Drawing.Point(1035, 642)
        Me.DisplayDate.Name = "DisplayDate"
        Me.DisplayDate.Size = New System.Drawing.Size(98, 46)
        Me.DisplayDate.TabIndex = 85
        Me.DisplayDate.Text = "Display"
        Me.DisplayDate.UseVisualStyleBackColor = True
        '
        'ClearDate
        '
        Me.ClearDate.Location = New System.Drawing.Point(1190, 642)
        Me.ClearDate.Name = "ClearDate"
        Me.ClearDate.Size = New System.Drawing.Size(98, 46)
        Me.ClearDate.TabIndex = 86
        Me.ClearDate.Text = "Clear"
        Me.ClearDate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1322, 745)
        Me.Controls.Add(Me.ClearDate)
        Me.Controls.Add(Me.DisplayDate)
        Me.Controls.Add(Me.ldate)
        Me.Controls.Add(Me.sdate)
        Me.Controls.Add(Me.ltime)
        Me.Controls.Add(Me.stime)
        Me.Controls.Add(Me.gdate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.ClearNum)
        Me.Controls.Add(Me.FormatNum)
        Me.Controls.Add(Me.fnum)
        Me.Controls.Add(Me.snum)
        Me.Controls.Add(Me.cnum)
        Me.Controls.Add(Me.pnum)
        Me.Controls.Add(Me.gnum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FormatNumInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FormatLabel)
        Me.Controls.Add(Me.FormatBG1)
        Me.Controls.Add(Me.AtanResult)
        Me.Controls.Add(Me.AcosResult)
        Me.Controls.Add(Me.AsinResult)
        Me.Controls.Add(Me.AtanInput)
        Me.Controls.Add(Me.AcosInput)
        Me.Controls.Add(Me.AsinInput)
        Me.Controls.Add(Me.AtanLabel)
        Me.Controls.Add(Me.AcosLabel)
        Me.Controls.Add(Me.AsinLabel)
        Me.Controls.Add(Me.TanInput)
        Me.Controls.Add(Me.TanResult)
        Me.Controls.Add(Me.TanLabel)
        Me.Controls.Add(Me.CosResult)
        Me.Controls.Add(Me.CosInput)
        Me.Controls.Add(Me.CosLabel)
        Me.Controls.Add(Me.SinResult)
        Me.Controls.Add(Me.SinInput)
        Me.Controls.Add(Me.SinLabel)
        Me.Controls.Add(Me.RndBtn)
        Me.Controls.Add(Me.RndDisplay)
        Me.Controls.Add(Me.NumberRandomiser)
        Me.Controls.Add(Me.SqrtResult)
        Me.Controls.Add(Me.SqrtInput)
        Me.Controls.Add(Me.SqrtLabel)
        Me.Controls.Add(Me.RoundResult)
        Me.Controls.Add(Me.RoundInput)
        Me.Controls.Add(Me.RoundLabel)
        Me.Controls.Add(Me.LogResult)
        Me.Controls.Add(Me.LogInput)
        Me.Controls.Add(Me.LogLabel)
        Me.Controls.Add(Me.IntResult)
        Me.Controls.Add(Me.IntInput)
        Me.Controls.Add(Me.IntLabel)
        Me.Controls.Add(Me.FixResult)
        Me.Controls.Add(Me.FixInput)
        Me.Controls.Add(Me.ExpResult)
        Me.Controls.Add(Me.ExpInput)
        Me.Controls.Add(Me.AbsResult)
        Me.Controls.Add(Me.Equalation1)
        Me.Controls.Add(Me.NormalOperation)
        Me.Controls.Add(Me.AbsInput)
        Me.Controls.Add(Me.Clear_Btn)
        Me.Controls.Add(Me.Calculate_Btn)
        Me.Controls.Add(Me.Result1)
        Me.Controls.Add(Me.Number2)
        Me.Controls.Add(Me.Operator1)
        Me.Controls.Add(Me.Number1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RandomBG)
        Me.Controls.Add(Me.RandomBG2)
        Me.Controls.Add(Me.NormalOpearationBG)
        Me.Controls.Add(Me.NormalOperationBG2)
        Me.Controls.Add(Me.ExponentialLabel)
        Me.Controls.Add(Me.FixLabel)
        Me.Controls.Add(Me.FormatBG3)
        Me.Controls.Add(Me.FormatBG2)
        Me.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "MyCal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Number1 As TextBox
    Friend WithEvents Operator1 As ComboBox
    Friend WithEvents Number2 As TextBox
    Friend WithEvents Equalation1 As Label
    Friend WithEvents Result1 As Label
    Friend WithEvents Calculate_Btn As Button
    Friend WithEvents Clear_Btn As Button
    Friend WithEvents AbsInput As TextBox
    Friend WithEvents NormalOperation As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AbsResult As Label
    Friend WithEvents NormalOpearationBG As Label
    Friend WithEvents ExponentialLabel As Label
    Friend WithEvents ExpInput As TextBox
    Friend WithEvents ExpResult As Label
    Friend WithEvents FixLabel As Label
    Friend WithEvents FixInput As TextBox
    Friend WithEvents FixResult As Label
    Friend WithEvents IntLabel As Label
    Friend WithEvents IntInput As TextBox
    Friend WithEvents IntResult As Label
    Friend WithEvents LogLabel As Label
    Friend WithEvents LogInput As TextBox
    Friend WithEvents LogResult As Label
    Friend WithEvents RoundLabel As Label
    Friend WithEvents RoundInput As TextBox
    Friend WithEvents RoundResult As Label
    Friend WithEvents SqrtLabel As Label
    Friend WithEvents SqrtInput As TextBox
    Friend WithEvents SqrtResult As Label
    Friend WithEvents NumberRandomiser As Label
    Friend WithEvents RndDisplay As Label
    Friend WithEvents RndBtn As Button
    Friend WithEvents SinLabel As Label
    Friend WithEvents SinInput As TextBox
    Friend WithEvents SinResult As Label
    Friend WithEvents CosLabel As Label
    Friend WithEvents CosInput As TextBox
    Friend WithEvents CosResult As Label
    Friend WithEvents TanLabel As Label
    Friend WithEvents TanResult As Label
    Friend WithEvents TanInput As TextBox
    Friend WithEvents AsinLabel As Label
    Friend WithEvents AcosLabel As Label
    Friend WithEvents AtanLabel As Label
    Friend WithEvents AsinInput As TextBox
    Friend WithEvents AcosInput As TextBox
    Friend WithEvents AtanInput As TextBox
    Friend WithEvents AsinResult As Label
    Friend WithEvents AcosResult As Label
    Friend WithEvents AtanResult As Label
    Friend WithEvents RandomBG As Label
    Friend WithEvents RandomBG2 As Label
    Friend WithEvents NormalOperationBG2 As Label
    Friend WithEvents FormatBG2 As Label
    Friend WithEvents FormatBG1 As Label
    Friend WithEvents FormatBG3 As Label
    Friend WithEvents FormatLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FormatNumInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents gnum As Label
    Friend WithEvents pnum As Label
    Friend WithEvents cnum As Label
    Friend WithEvents snum As Label
    Friend WithEvents fnum As Label
    Friend WithEvents FormatNum As Button
    Friend WithEvents ClearNum As Button
    Friend WithEvents DateLabel As Label
    Friend WithEvents ldate As Label
    Friend WithEvents sdate As Label
    Friend WithEvents ltime As Label
    Friend WithEvents stime As Label
    Friend WithEvents gdate As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DisplayDate As Button
    Friend WithEvents ClearDate As Button
End Class
