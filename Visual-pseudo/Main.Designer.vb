<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pnlLeftScrim = New System.Windows.Forms.Panel()
        Me.pnlLoadData = New System.Windows.Forms.Panel()
        Me.btnLoadClose = New System.Windows.Forms.Button()
        Me.lblLoadHeader = New System.Windows.Forms.Label()
        Me.btnPreferences = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.pnlControls.SuspendLayout()
        Me.pnlLeftScrim.SuspendLayout()
        Me.pnlLoadData.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlControls
        '
        Me.pnlControls.BackColor = System.Drawing.Color.Transparent
        Me.pnlControls.BackgroundImage = Global.Visual_pseudo.My.Resources.Resources.scrim
        Me.pnlControls.Controls.Add(Me.btnQuit)
        Me.pnlControls.Controls.Add(Me.btnPreferences)
        Me.pnlControls.Controls.Add(Me.btnLoad)
        Me.pnlControls.Controls.Add(Me.btnStart)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControls.Location = New System.Drawing.Point(713, 0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(287, 600)
        Me.pnlControls.TabIndex = 0
        '
        'btnQuit
        '
        Me.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.Location = New System.Drawing.Point(25, 537)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(244, 51)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.TabStop = False
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(25, 246)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(244, 51)
        Me.btnStart.TabIndex = 1
        Me.btnStart.TabStop = False
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'pnlLeftScrim
        '
        Me.pnlLeftScrim.BackColor = System.Drawing.Color.Transparent
        Me.pnlLeftScrim.Controls.Add(Me.pnlLoadData)
        Me.pnlLeftScrim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLeftScrim.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftScrim.Name = "pnlLeftScrim"
        Me.pnlLeftScrim.Size = New System.Drawing.Size(713, 600)
        Me.pnlLeftScrim.TabIndex = 1
        '
        'pnlLoadData
        '
        Me.pnlLoadData.AutoScroll = True
        Me.pnlLoadData.Controls.Add(Me.btnLoadClose)
        Me.pnlLoadData.Controls.Add(Me.lblLoadHeader)
        Me.pnlLoadData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoadData.Enabled = False
        Me.pnlLoadData.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoadData.Name = "pnlLoadData"
        Me.pnlLoadData.Size = New System.Drawing.Size(713, 600)
        Me.pnlLoadData.TabIndex = 0
        Me.pnlLoadData.Visible = False
        '
        'btnLoadClose
        '
        Me.btnLoadClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadClose.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnLoadClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLoadClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLoadClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadClose.ForeColor = System.Drawing.Color.White
        Me.btnLoadClose.Location = New System.Drawing.Point(632, 50)
        Me.btnLoadClose.Name = "btnLoadClose"
        Me.btnLoadClose.Size = New System.Drawing.Size(75, 42)
        Me.btnLoadClose.TabIndex = 2
        Me.btnLoadClose.TabStop = False
        Me.btnLoadClose.Text = "Close"
        Me.btnLoadClose.UseVisualStyleBackColor = True
        '
        'lblLoadHeader
        '
        Me.lblLoadHeader.AutoSize = True
        Me.lblLoadHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadHeader.ForeColor = System.Drawing.Color.White
        Me.lblLoadHeader.Location = New System.Drawing.Point(50, 50)
        Me.lblLoadHeader.Margin = New System.Windows.Forms.Padding(50)
        Me.lblLoadHeader.Name = "lblLoadHeader"
        Me.lblLoadHeader.Size = New System.Drawing.Size(167, 39)
        Me.lblLoadHeader.TabIndex = 0
        Me.lblLoadHeader.Text = "load data"
        Me.lblLoadHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPreferences
        '
        Me.btnPreferences.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreferences.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPreferences.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPreferences.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreferences.ForeColor = System.Drawing.Color.White
        Me.btnPreferences.Location = New System.Drawing.Point(25, 360)
        Me.btnPreferences.Name = "btnPreferences"
        Me.btnPreferences.Size = New System.Drawing.Size(244, 51)
        Me.btnPreferences.TabIndex = 3
        Me.btnPreferences.TabStop = False
        Me.btnPreferences.Text = "Preferences"
        Me.btnPreferences.UseVisualStyleBackColor = True
        Me.btnPreferences.Visible = False
        '
        'btnLoad
        '
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.Location = New System.Drawing.Point(25, 303)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(244, 51)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.TabStop = False
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        Me.btnLoad.Visible = False
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Visual_pseudo.My.Resources.Resources.background_main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlLeftScrim)
        Me.Controls.Add(Me.pnlControls)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.pnlControls.ResumeLayout(False)
        Me.pnlLeftScrim.ResumeLayout(False)
        Me.pnlLoadData.ResumeLayout(False)
        Me.pnlLoadData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlControls As Panel
    Friend WithEvents btnStart As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents pnlLeftScrim As Panel
    Friend WithEvents pnlLoadData As Panel
    Friend WithEvents lblLoadHeader As Label
    Friend WithEvents btnLoadClose As Button
    Friend WithEvents btnPreferences As Button
    Friend WithEvents btnLoad As Button
End Class
