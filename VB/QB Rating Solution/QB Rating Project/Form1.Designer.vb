<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblAttempts = New System.Windows.Forms.Label()
        Me.txtAttempts = New System.Windows.Forms.TextBox()
        Me.lblCompletions = New System.Windows.Forms.Label()
        Me.txtCompletions = New System.Windows.Forms.TextBox()
        Me.lblYards = New System.Windows.Forms.Label()
        Me.txtYards = New System.Windows.Forms.TextBox()
        Me.lblTDs = New System.Windows.Forms.Label()
        Me.txtTDs = New System.Windows.Forms.TextBox()
        Me.lblINTs = New System.Windows.Forms.Label()
        Me.txtINTs = New System.Windows.Forms.TextBox()
        Me.grpLeague = New System.Windows.Forms.GroupBox()
        Me.rdoNCAA = New System.Windows.Forms.RadioButton()
        Me.rdoNFL = New System.Windows.Forms.RadioButton()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.grpLeague.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAttempts
        '
        Me.lblAttempts.AutoSize = True
        Me.lblAttempts.Location = New System.Drawing.Point(13, 16)
        Me.lblAttempts.Name = "lblAttempts"
        Me.lblAttempts.Size = New System.Drawing.Size(117, 17)
        Me.lblAttempts.TabIndex = 0
        Me.lblAttempts.Text = "Passing Attempts"
        '
        'txtAttempts
        '
        Me.txtAttempts.Location = New System.Drawing.Point(137, 13)
        Me.txtAttempts.Name = "txtAttempts"
        Me.txtAttempts.Size = New System.Drawing.Size(63, 22)
        Me.txtAttempts.TabIndex = 1
        '
        'lblCompletions
        '
        Me.lblCompletions.AutoSize = True
        Me.lblCompletions.Location = New System.Drawing.Point(45, 44)
        Me.lblCompletions.Name = "lblCompletions"
        Me.lblCompletions.Size = New System.Drawing.Size(85, 17)
        Me.lblCompletions.TabIndex = 2
        Me.lblCompletions.Text = "Completions"
        '
        'txtCompletions
        '
        Me.txtCompletions.Location = New System.Drawing.Point(137, 41)
        Me.txtCompletions.Name = "txtCompletions"
        Me.txtCompletions.Size = New System.Drawing.Size(63, 22)
        Me.txtCompletions.TabIndex = 3
        '
        'lblYards
        '
        Me.lblYards.AutoSize = True
        Me.lblYards.Location = New System.Drawing.Point(31, 72)
        Me.lblYards.Name = "lblYards"
        Me.lblYards.Size = New System.Drawing.Size(99, 17)
        Me.lblYards.TabIndex = 4
        Me.lblYards.Text = "Passing Yards"
        '
        'txtYards
        '
        Me.txtYards.Location = New System.Drawing.Point(137, 69)
        Me.txtYards.Name = "txtYards"
        Me.txtYards.Size = New System.Drawing.Size(63, 22)
        Me.txtYards.TabIndex = 5
        '
        'lblTDs
        '
        Me.lblTDs.AutoSize = True
        Me.lblTDs.Location = New System.Drawing.Point(42, 100)
        Me.lblTDs.Name = "lblTDs"
        Me.lblTDs.Size = New System.Drawing.Size(88, 17)
        Me.lblTDs.TabIndex = 6
        Me.lblTDs.Text = "Touchdowns"
        '
        'txtTDs
        '
        Me.txtTDs.Location = New System.Drawing.Point(137, 97)
        Me.txtTDs.Name = "txtTDs"
        Me.txtTDs.Size = New System.Drawing.Size(63, 22)
        Me.txtTDs.TabIndex = 7
        '
        'lblINTs
        '
        Me.lblINTs.AutoSize = True
        Me.lblINTs.Location = New System.Drawing.Point(41, 129)
        Me.lblINTs.Name = "lblINTs"
        Me.lblINTs.Size = New System.Drawing.Size(89, 17)
        Me.lblINTs.TabIndex = 8
        Me.lblINTs.Text = "Interceptions"
        '
        'txtINTs
        '
        Me.txtINTs.Location = New System.Drawing.Point(137, 126)
        Me.txtINTs.Name = "txtINTs"
        Me.txtINTs.Size = New System.Drawing.Size(63, 22)
        Me.txtINTs.TabIndex = 9
        '
        'grpLeague
        '
        Me.grpLeague.Controls.Add(Me.rdoNCAA)
        Me.grpLeague.Controls.Add(Me.rdoNFL)
        Me.grpLeague.Location = New System.Drawing.Point(226, 13)
        Me.grpLeague.Name = "grpLeague"
        Me.grpLeague.Size = New System.Drawing.Size(151, 86)
        Me.grpLeague.TabIndex = 10
        Me.grpLeague.TabStop = False
        Me.grpLeague.Text = "Choose League:"
        '
        'rdoNCAA
        '
        Me.rdoNCAA.AutoSize = True
        Me.rdoNCAA.Location = New System.Drawing.Point(7, 59)
        Me.rdoNCAA.Name = "rdoNCAA"
        Me.rdoNCAA.Size = New System.Drawing.Size(111, 21)
        Me.rdoNCAA.TabIndex = 1
        Me.rdoNCAA.TabStop = True
        Me.rdoNCAA.Text = "NCAA Rating"
        Me.rdoNCAA.UseVisualStyleBackColor = True
        '
        'rdoNFL
        '
        Me.rdoNFL.AutoSize = True
        Me.rdoNFL.Location = New System.Drawing.Point(7, 31)
        Me.rdoNFL.Name = "rdoNFL"
        Me.rdoNFL.Size = New System.Drawing.Size(100, 21)
        Me.rdoNFL.TabIndex = 0
        Me.rdoNFL.TabStop = True
        Me.rdoNFL.Text = "NFL Rating"
        Me.rdoNFL.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(233, 105)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(135, 43)
        Me.btnCalc.TabIndex = 11
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Passer Rating:"
        '
        'lblRating
        '
        Me.lblRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRating.Location = New System.Drawing.Point(202, 173)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(100, 23)
        Me.lblRating.TabIndex = 13
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 216)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpLeague)
        Me.Controls.Add(Me.txtINTs)
        Me.Controls.Add(Me.lblINTs)
        Me.Controls.Add(Me.txtTDs)
        Me.Controls.Add(Me.lblTDs)
        Me.Controls.Add(Me.txtYards)
        Me.Controls.Add(Me.lblYards)
        Me.Controls.Add(Me.txtCompletions)
        Me.Controls.Add(Me.lblCompletions)
        Me.Controls.Add(Me.txtAttempts)
        Me.Controls.Add(Me.lblAttempts)
        Me.Name = "frmMain"
        Me.Text = "QB Rating Calculator"
        Me.grpLeague.ResumeLayout(False)
        Me.grpLeague.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAttempts As System.Windows.Forms.Label
    Friend WithEvents txtAttempts As System.Windows.Forms.TextBox
    Friend WithEvents lblCompletions As System.Windows.Forms.Label
    Friend WithEvents txtCompletions As System.Windows.Forms.TextBox
    Friend WithEvents lblYards As System.Windows.Forms.Label
    Friend WithEvents txtYards As System.Windows.Forms.TextBox
    Friend WithEvents lblTDs As System.Windows.Forms.Label
    Friend WithEvents txtTDs As System.Windows.Forms.TextBox
    Friend WithEvents lblINTs As System.Windows.Forms.Label
    Friend WithEvents txtINTs As System.Windows.Forms.TextBox
    Friend WithEvents grpLeague As System.Windows.Forms.GroupBox
    Friend WithEvents rdoNCAA As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNFL As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRating As System.Windows.Forms.Label

End Class
