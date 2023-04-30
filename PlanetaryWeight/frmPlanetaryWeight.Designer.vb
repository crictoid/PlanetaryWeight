<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanetaryWeight
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
        Me.grpConvertWeight = New System.Windows.Forms.GroupBox()
        Me.radMars = New System.Windows.Forms.RadioButton()
        Me.radVenus = New System.Windows.Forms.RadioButton()
        Me.txtFootage = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picDeck = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblPlanetChoice = New System.Windows.Forms.Label()
        Me.lblConvertedWeight = New System.Windows.Forms.Label()
        Me.lblConvertedPounds = New System.Windows.Forms.Label()
        Me.lblConvertedKilograms = New System.Windows.Forms.Label()
        Me.grpConvertWeight.SuspendLayout()
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpConvertWeight
        '
        Me.grpConvertWeight.BackColor = System.Drawing.Color.White
        Me.grpConvertWeight.Controls.Add(Me.radMars)
        Me.grpConvertWeight.Controls.Add(Me.radVenus)
        Me.grpConvertWeight.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConvertWeight.ForeColor = System.Drawing.Color.Black
        Me.grpConvertWeight.Location = New System.Drawing.Point(466, 147)
        Me.grpConvertWeight.Name = "grpConvertWeight"
        Me.grpConvertWeight.Size = New System.Drawing.Size(244, 106)
        Me.grpConvertWeight.TabIndex = 13
        Me.grpConvertWeight.TabStop = False
        Me.grpConvertWeight.Text = "Convert Weight"
        '
        'radMars
        '
        Me.radMars.AutoSize = True
        Me.radMars.Location = New System.Drawing.Point(6, 49)
        Me.radMars.Name = "radMars"
        Me.radMars.Size = New System.Drawing.Size(213, 27)
        Me.radMars.TabIndex = 1
        Me.radMars.Text = "Convert to Mars Weight"
        Me.radMars.UseVisualStyleBackColor = True
        '
        'radVenus
        '
        Me.radVenus.AutoSize = True
        Me.radVenus.Checked = True
        Me.radVenus.Location = New System.Drawing.Point(6, 22)
        Me.radVenus.Name = "radVenus"
        Me.radVenus.Size = New System.Drawing.Size(223, 27)
        Me.radVenus.TabIndex = 0
        Me.radVenus.TabStop = True
        Me.radVenus.Text = "Convert to Venus Weight"
        Me.radVenus.UseVisualStyleBackColor = True
        '
        'txtFootage
        '
        Me.txtFootage.BackColor = System.Drawing.Color.White
        Me.txtFootage.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFootage.ForeColor = System.Drawing.Color.Black
        Me.txtFootage.Location = New System.Drawing.Point(649, 98)
        Me.txtFootage.Name = "txtFootage"
        Me.txtFootage.Size = New System.Drawing.Size(47, 33)
        Me.txtFootage.TabIndex = 12
        Me.txtFootage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.BackColor = System.Drawing.Color.Gold
        Me.lblWeight.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.Color.Black
        Me.lblWeight.Location = New System.Drawing.Point(477, 98)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(135, 25)
        Me.lblWeight.TabIndex = 11
        Me.lblWeight.Text = "Enter Weight:"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Gold
        Me.lblHeading.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Black
        Me.lblHeading.Location = New System.Drawing.Point(475, 31)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(220, 37)
        Me.lblHeading.TabIndex = 10
        Me.lblHeading.Text = "Venus or Mars?"
        '
        'picDeck
        '
        Me.picDeck.Image = Global.PlanetaryWeight.My.Resources.Resources.planets
        Me.picDeck.Location = New System.Drawing.Point(3, 3)
        Me.picDeck.Name = "picDeck"
        Me.picDeck.Size = New System.Drawing.Size(331, 453)
        Me.picDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDeck.TabIndex = 18
        Me.picDeck.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gold
        Me.btnClear.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(594, 282)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 41)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.Gold
        Me.btnDisplay.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.Black
        Me.btnDisplay.Location = New System.Drawing.Point(466, 282)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(116, 41)
        Me.btnDisplay.TabIndex = 16
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'lblPlanetChoice
        '
        Me.lblPlanetChoice.AutoSize = True
        Me.lblPlanetChoice.BackColor = System.Drawing.Color.Gold
        Me.lblPlanetChoice.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanetChoice.ForeColor = System.Drawing.Color.Black
        Me.lblPlanetChoice.Location = New System.Drawing.Point(477, 368)
        Me.lblPlanetChoice.Name = "lblPlanetChoice"
        Me.lblPlanetChoice.Size = New System.Drawing.Size(73, 25)
        Me.lblPlanetChoice.TabIndex = 15
        Me.lblPlanetChoice.Text = "Mars is"
        '
        'lblConvertedWeight
        '
        Me.lblConvertedWeight.AutoSize = True
        Me.lblConvertedWeight.BackColor = System.Drawing.Color.Gold
        Me.lblConvertedWeight.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertedWeight.ForeColor = System.Drawing.Color.Black
        Me.lblConvertedWeight.Location = New System.Drawing.Point(340, 368)
        Me.lblConvertedWeight.Name = "lblConvertedWeight"
        Me.lblConvertedWeight.Size = New System.Drawing.Size(146, 25)
        Me.lblConvertedWeight.TabIndex = 14
        Me.lblConvertedWeight.Text = "Your weight on"
        '
        'lblConvertedPounds
        '
        Me.lblConvertedPounds.AutoSize = True
        Me.lblConvertedPounds.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertedPounds.Location = New System.Drawing.Point(556, 370)
        Me.lblConvertedPounds.Name = "lblConvertedPounds"
        Me.lblConvertedPounds.Size = New System.Drawing.Size(81, 23)
        Me.lblConvertedPounds.TabIndex = 19
        Me.lblConvertedPounds.Text = "000.0 lbs"
        '
        'lblConvertedKilograms
        '
        Me.lblConvertedKilograms.AutoSize = True
        Me.lblConvertedKilograms.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertedKilograms.Location = New System.Drawing.Point(645, 370)
        Me.lblConvertedKilograms.Name = "lblConvertedKilograms"
        Me.lblConvertedKilograms.Size = New System.Drawing.Size(84, 23)
        Me.lblConvertedKilograms.TabIndex = 20
        Me.lblConvertedKilograms.Text = "000.0 kgs"
        '
        'frmPlanetaryWeight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblConvertedKilograms)
        Me.Controls.Add(Me.lblConvertedPounds)
        Me.Controls.Add(Me.grpConvertWeight)
        Me.Controls.Add(Me.txtFootage)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picDeck)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblPlanetChoice)
        Me.Controls.Add(Me.lblConvertedWeight)
        Me.Name = "frmPlanetaryWeight"
        Me.Text = "Planetary Weight"
        Me.grpConvertWeight.ResumeLayout(False)
        Me.grpConvertWeight.PerformLayout()
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpConvertWeight As GroupBox
    Friend WithEvents radMars As RadioButton
    Friend WithEvents radVenus As RadioButton
    Friend WithEvents txtFootage As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents picDeck As PictureBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lblPlanetChoice As Label
    Friend WithEvents lblConvertedWeight As Label
    Friend WithEvents lblConvertedPounds As Label
    Friend WithEvents lblConvertedKilograms As Label
End Class
