<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Storyboard
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlStoryChoices = New System.Windows.Forms.Panel()
        Me.btnChoiceB = New System.Windows.Forms.Button()
        Me.btnChoiceA = New System.Windows.Forms.Button()
        Me.prgTimer = New System.Windows.Forms.ProgressBar()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.pnlStoryScrim = New System.Windows.Forms.Panel()
        Me.pnlStoryboard = New System.Windows.Forms.Panel()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblStory = New System.Windows.Forms.Label()
        Me.worddisplayer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCharPrint = New System.Windows.Forms.Timer(Me.components)
        Me.pnlStoryChoices.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        Me.pnlStoryScrim.SuspendLayout()
        Me.pnlStoryboard.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlStoryChoices
        '
        Me.pnlStoryChoices.BackColor = System.Drawing.Color.Black
        Me.pnlStoryChoices.Controls.Add(Me.btnChoiceB)
        Me.pnlStoryChoices.Controls.Add(Me.btnChoiceA)
        Me.pnlStoryChoices.Controls.Add(Me.prgTimer)
        Me.pnlStoryChoices.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStoryChoices.Location = New System.Drawing.Point(0, 480)
        Me.pnlStoryChoices.Name = "pnlStoryChoices"
        Me.pnlStoryChoices.Size = New System.Drawing.Size(1000, 120)
        Me.pnlStoryChoices.TabIndex = 0
        '
        'btnChoiceB
        '
        Me.btnChoiceB.BackColor = System.Drawing.Color.Black
        Me.btnChoiceB.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnChoiceB.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnChoiceB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnChoiceB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnChoiceB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoiceB.ForeColor = System.Drawing.Color.White
        Me.btnChoiceB.Location = New System.Drawing.Point(510, 8)
        Me.btnChoiceB.Name = "btnChoiceB"
        Me.btnChoiceB.Size = New System.Drawing.Size(490, 112)
        Me.btnChoiceB.TabIndex = 3
        Me.btnChoiceB.Text = "B"
        Me.btnChoiceB.UseVisualStyleBackColor = False
        '
        'btnChoiceA
        '
        Me.btnChoiceA.BackColor = System.Drawing.Color.Black
        Me.btnChoiceA.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnChoiceA.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnChoiceA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnChoiceA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnChoiceA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoiceA.ForeColor = System.Drawing.Color.White
        Me.btnChoiceA.Location = New System.Drawing.Point(0, 8)
        Me.btnChoiceA.Name = "btnChoiceA"
        Me.btnChoiceA.Size = New System.Drawing.Size(490, 112)
        Me.btnChoiceA.TabIndex = 2
        Me.btnChoiceA.Text = "A"
        Me.btnChoiceA.UseVisualStyleBackColor = False
        '
        'prgTimer
        '
        Me.prgTimer.Dock = System.Windows.Forms.DockStyle.Top
        Me.prgTimer.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.prgTimer.Location = New System.Drawing.Point(0, 0)
        Me.prgTimer.MarqueeAnimationSpeed = 200
        Me.prgTimer.Name = "prgTimer"
        Me.prgTimer.Size = New System.Drawing.Size(1000, 8)
        Me.prgTimer.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgTimer.TabIndex = 1
        '
        'pnlControls
        '
        Me.pnlControls.BackColor = System.Drawing.Color.Transparent
        Me.pnlControls.BackgroundImage = Global.Visual_pseudo.My.Resources.Resources.scrim
        Me.pnlControls.Controls.Add(Me.btnReturn)
        Me.pnlControls.Controls.Add(Me.btnMenu)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(1000, 50)
        Me.pnlControls.TabIndex = 1
        '
        'btnReturn
        '
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(94, 12)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(190, 32)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Return to Main Screen"
        Me.btnReturn.UseVisualStyleBackColor = True
        Me.btnReturn.Visible = False
        '
        'btnMenu
        '
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.Location = New System.Drawing.Point(13, 12)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 32)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'pnlStoryScrim
        '
        Me.pnlStoryScrim.BackColor = System.Drawing.Color.Transparent
        Me.pnlStoryScrim.BackgroundImage = Global.Visual_pseudo.My.Resources.Resources.scrim
        Me.pnlStoryScrim.Controls.Add(Me.pnlStoryboard)
        Me.pnlStoryScrim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStoryScrim.Location = New System.Drawing.Point(0, 0)
        Me.pnlStoryScrim.Name = "pnlStoryScrim"
        Me.pnlStoryScrim.Size = New System.Drawing.Size(1000, 600)
        Me.pnlStoryScrim.TabIndex = 2
        '
        'pnlStoryboard
        '
        Me.pnlStoryboard.Controls.Add(Me.btnNext)
        Me.pnlStoryboard.Controls.Add(Me.lblStory)
        Me.pnlStoryboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStoryboard.Location = New System.Drawing.Point(0, 0)
        Me.pnlStoryboard.Name = "pnlStoryboard"
        Me.pnlStoryboard.Size = New System.Drawing.Size(1000, 600)
        Me.pnlStoryboard.TabIndex = 0
        '
        'btnNext
        '
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(868, 442)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(120, 32)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'lblStory
        '
        Me.lblStory.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStory.ForeColor = System.Drawing.Color.White
        Me.lblStory.Location = New System.Drawing.Point(150, 135)
        Me.lblStory.Name = "lblStory"
        Me.lblStory.Size = New System.Drawing.Size(700, 200)
        Me.lblStory.TabIndex = 0
        Me.lblStory.Text = "Story goes here."
        Me.lblStory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrCharPrint
        '
        Me.tmrCharPrint.Interval = 1
        '
        'Storyboard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Visual_pseudo.My.Resources.Resources.background_main
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.pnlStoryChoices)
        Me.Controls.Add(Me.pnlStoryScrim)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Storyboard"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Storyboard"
        Me.pnlStoryChoices.ResumeLayout(False)
        Me.pnlControls.ResumeLayout(False)
        Me.pnlStoryScrim.ResumeLayout(False)
        Me.pnlStoryboard.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlStoryChoices As Panel
    Friend WithEvents prgTimer As ProgressBar
    Friend WithEvents pnlControls As Panel
    Friend WithEvents pnlStoryScrim As Panel
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents pnlStoryboard As Panel
    Friend WithEvents btnChoiceB As Button
    Friend WithEvents btnChoiceA As Button
    Friend WithEvents lblStory As Label
    Friend WithEvents worddisplayer As Timer
    Friend WithEvents btnNext As Button
    Friend WithEvents tmrCharPrint As Timer
End Class
