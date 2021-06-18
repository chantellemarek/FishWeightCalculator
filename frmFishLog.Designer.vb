<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFishLog
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
        Me.txtTripDate = New System.Windows.Forms.TextBox()
        Me.cbxTimeDay = New System.Windows.Forms.ComboBox()
        Me.gbxFish = New System.Windows.Forms.GroupBox()
        Me.txtFishID = New System.Windows.Forms.TextBox()
        Me.lblFishID = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtSpecies = New System.Windows.Forms.TextBox()
        Me.lblSpecies = New System.Windows.Forms.Label()
        Me.gbxTrip = New System.Windows.Forms.GroupBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblLocate = New System.Windows.Forms.Label()
        Me.txtTechnique = New System.Windows.Forms.TextBox()
        Me.lblTechnique = New System.Windows.Forms.Label()
        Me.txtClarity = New System.Windows.Forms.TextBox()
        Me.lblClarity = New System.Windows.Forms.Label()
        Me.lblTimeDay = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lbxTripDate = New System.Windows.Forms.ListBox()
        Me.gbxFishLog = New System.Windows.Forms.GroupBox()
        Me.lblSpeciesOutput = New System.Windows.Forms.Label()
        Me.lblLogSpecies = New System.Windows.Forms.Label()
        Me.lblWeightOutput = New System.Windows.Forms.Label()
        Me.lblLogWeight = New System.Windows.Forms.Label()
        Me.lblLengthOutput = New System.Windows.Forms.Label()
        Me.lblIDOutput = New System.Windows.Forms.Label()
        Me.lblLogLength = New System.Windows.Forms.Label()
        Me.lblTechOutput = New System.Windows.Forms.Label()
        Me.lblLogID = New System.Windows.Forms.Label()
        Me.lblLogTechnique = New System.Windows.Forms.Label()
        Me.lblClarityOutput = New System.Windows.Forms.Label()
        Me.lblLogClarity = New System.Windows.Forms.Label()
        Me.lblLocationOutput = New System.Windows.Forms.Label()
        Me.lblLogLocation = New System.Windows.Forms.Label()
        Me.lblTimeOutput = New System.Windows.Forms.Label()
        Me.lblLogTimeDay = New System.Windows.Forms.Label()
        Me.lblDateOutput = New System.Windows.Forms.Label()
        Me.lblLogDate = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.gbxFish.SuspendLayout()
        Me.gbxTrip.SuspendLayout()
        Me.gbxFishLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTripDate
        '
        Me.txtTripDate.Location = New System.Drawing.Point(69, 142)
        Me.txtTripDate.Name = "txtTripDate"
        Me.txtTripDate.Size = New System.Drawing.Size(158, 28)
        Me.txtTripDate.TabIndex = 6
        Me.txtTripDate.Text = "--/--/----"
        '
        'cbxTimeDay
        '
        Me.cbxTimeDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTimeDay.FormattingEnabled = True
        Me.cbxTimeDay.Location = New System.Drawing.Point(69, 213)
        Me.cbxTimeDay.Name = "cbxTimeDay"
        Me.cbxTimeDay.Size = New System.Drawing.Size(158, 29)
        Me.cbxTimeDay.TabIndex = 7
        '
        'gbxFish
        '
        Me.gbxFish.BackColor = System.Drawing.Color.Pink
        Me.gbxFish.Controls.Add(Me.txtFishID)
        Me.gbxFish.Controls.Add(Me.lblFishID)
        Me.gbxFish.Controls.Add(Me.txtLength)
        Me.gbxFish.Controls.Add(Me.lblLength)
        Me.gbxFish.Controls.Add(Me.txtWeight)
        Me.gbxFish.Controls.Add(Me.lblWeight)
        Me.gbxFish.Controls.Add(Me.txtSpecies)
        Me.gbxFish.Controls.Add(Me.lblSpecies)
        Me.gbxFish.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFish.Location = New System.Drawing.Point(12, 35)
        Me.gbxFish.Name = "gbxFish"
        Me.gbxFish.Size = New System.Drawing.Size(309, 397)
        Me.gbxFish.TabIndex = 3
        Me.gbxFish.TabStop = False
        Me.gbxFish.Text = "Fish Information"
        '
        'txtFishID
        '
        Me.txtFishID.Location = New System.Drawing.Point(72, 322)
        Me.txtFishID.Name = "txtFishID"
        Me.txtFishID.Size = New System.Drawing.Size(158, 28)
        Me.txtFishID.TabIndex = 4
        '
        'lblFishID
        '
        Me.lblFishID.AutoSize = True
        Me.lblFishID.Location = New System.Drawing.Point(121, 284)
        Me.lblFishID.Name = "lblFishID"
        Me.lblFishID.Size = New System.Drawing.Size(61, 21)
        Me.lblFishID.TabIndex = 9
        Me.lblFishID.Text = "Fish ID:"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(72, 239)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(158, 28)
        Me.txtLength.TabIndex = 3
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(120, 201)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(62, 21)
        Me.lblLength.TabIndex = 7
        Me.lblLength.Text = "Length:"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(72, 156)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(158, 28)
        Me.txtWeight.TabIndex = 2
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(119, 118)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(64, 21)
        Me.lblWeight.TabIndex = 5
        Me.lblWeight.Text = "Weight:"
        '
        'txtSpecies
        '
        Me.txtSpecies.Location = New System.Drawing.Point(15, 73)
        Me.txtSpecies.Name = "txtSpecies"
        Me.txtSpecies.Size = New System.Drawing.Size(273, 28)
        Me.txtSpecies.TabIndex = 1
        '
        'lblSpecies
        '
        Me.lblSpecies.AutoSize = True
        Me.lblSpecies.Location = New System.Drawing.Point(102, 35)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(98, 21)
        Me.lblSpecies.TabIndex = 4
        Me.lblSpecies.Text = "Fish Species:"
        '
        'gbxTrip
        '
        Me.gbxTrip.BackColor = System.Drawing.Color.SpringGreen
        Me.gbxTrip.Controls.Add(Me.txtLocation)
        Me.gbxTrip.Controls.Add(Me.lblLocate)
        Me.gbxTrip.Controls.Add(Me.txtTechnique)
        Me.gbxTrip.Controls.Add(Me.lblTechnique)
        Me.gbxTrip.Controls.Add(Me.txtClarity)
        Me.gbxTrip.Controls.Add(Me.lblClarity)
        Me.gbxTrip.Controls.Add(Me.lblTimeDay)
        Me.gbxTrip.Controls.Add(Me.lblDate)
        Me.gbxTrip.Controls.Add(Me.cbxTimeDay)
        Me.gbxTrip.Controls.Add(Me.txtTripDate)
        Me.gbxTrip.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTrip.Location = New System.Drawing.Point(353, 12)
        Me.gbxTrip.Name = "gbxTrip"
        Me.gbxTrip.Size = New System.Drawing.Size(309, 436)
        Me.gbxTrip.TabIndex = 4
        Me.gbxTrip.TabStop = False
        Me.gbxTrip.Text = "Trip Information"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(12, 71)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(273, 28)
        Me.txtLocation.TabIndex = 5
        '
        'lblLocate
        '
        Me.lblLocate.AutoSize = True
        Me.lblLocate.Location = New System.Drawing.Point(112, 39)
        Me.lblLocate.Name = "lblLocate"
        Me.lblLocate.Size = New System.Drawing.Size(73, 21)
        Me.lblLocate.TabIndex = 12
        Me.lblLocate.Text = "Location:"
        Me.lblLocate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTechnique
        '
        Me.txtTechnique.Location = New System.Drawing.Point(12, 356)
        Me.txtTechnique.Name = "txtTechnique"
        Me.txtTechnique.Size = New System.Drawing.Size(273, 28)
        Me.txtTechnique.TabIndex = 9
        '
        'lblTechnique
        '
        Me.lblTechnique.AutoSize = True
        Me.lblTechnique.Location = New System.Drawing.Point(106, 324)
        Me.lblTechnique.Name = "lblTechnique"
        Me.lblTechnique.Size = New System.Drawing.Size(84, 21)
        Me.lblTechnique.TabIndex = 10
        Me.lblTechnique.Text = "Technique:"
        '
        'txtClarity
        '
        Me.txtClarity.Location = New System.Drawing.Point(12, 285)
        Me.txtClarity.Name = "txtClarity"
        Me.txtClarity.Size = New System.Drawing.Size(273, 28)
        Me.txtClarity.TabIndex = 8
        '
        'lblClarity
        '
        Me.lblClarity.AutoSize = True
        Me.lblClarity.Location = New System.Drawing.Point(95, 253)
        Me.lblClarity.Name = "lblClarity"
        Me.lblClarity.Size = New System.Drawing.Size(106, 21)
        Me.lblClarity.TabIndex = 6
        Me.lblClarity.Text = "Water Clarity:"
        '
        'lblTimeDay
        '
        Me.lblTimeDay.AutoSize = True
        Me.lblTimeDay.Location = New System.Drawing.Point(100, 181)
        Me.lblTimeDay.Name = "lblTimeDay"
        Me.lblTimeDay.Size = New System.Drawing.Size(97, 21)
        Me.lblTimeDay.TabIndex = 5
        Me.lblTimeDay.Text = "Time of Day:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(125, 110)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(47, 21)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Date:"
        '
        'lbxTripDate
        '
        Me.lbxTripDate.BackColor = System.Drawing.Color.Cornsilk
        Me.lbxTripDate.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxTripDate.FormattingEnabled = True
        Me.lbxTripDate.ItemHeight = 21
        Me.lbxTripDate.Location = New System.Drawing.Point(694, 508)
        Me.lbxTripDate.Name = "lbxTripDate"
        Me.lbxTripDate.Size = New System.Drawing.Size(557, 151)
        Me.lbxTripDate.TabIndex = 5
        '
        'gbxFishLog
        '
        Me.gbxFishLog.BackColor = System.Drawing.Color.Gainsboro
        Me.gbxFishLog.Controls.Add(Me.lblSpeciesOutput)
        Me.gbxFishLog.Controls.Add(Me.lblLogSpecies)
        Me.gbxFishLog.Controls.Add(Me.lblWeightOutput)
        Me.gbxFishLog.Controls.Add(Me.lblLogWeight)
        Me.gbxFishLog.Controls.Add(Me.lblLengthOutput)
        Me.gbxFishLog.Controls.Add(Me.lblIDOutput)
        Me.gbxFishLog.Controls.Add(Me.lblLogLength)
        Me.gbxFishLog.Controls.Add(Me.lblTechOutput)
        Me.gbxFishLog.Controls.Add(Me.lblLogID)
        Me.gbxFishLog.Controls.Add(Me.lblLogTechnique)
        Me.gbxFishLog.Controls.Add(Me.lblClarityOutput)
        Me.gbxFishLog.Controls.Add(Me.lblLogClarity)
        Me.gbxFishLog.Controls.Add(Me.lblLocationOutput)
        Me.gbxFishLog.Controls.Add(Me.lblLogLocation)
        Me.gbxFishLog.Controls.Add(Me.lblTimeOutput)
        Me.gbxFishLog.Controls.Add(Me.lblLogTimeDay)
        Me.gbxFishLog.Controls.Add(Me.lblDateOutput)
        Me.gbxFishLog.Controls.Add(Me.lblLogDate)
        Me.gbxFishLog.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFishLog.Location = New System.Drawing.Point(694, 12)
        Me.gbxFishLog.Name = "gbxFishLog"
        Me.gbxFishLog.Size = New System.Drawing.Size(557, 482)
        Me.gbxFishLog.TabIndex = 7
        Me.gbxFishLog.TabStop = False
        Me.gbxFishLog.Text = "Fish Log"
        '
        'lblSpeciesOutput
        '
        Me.lblSpeciesOutput.AutoSize = True
        Me.lblSpeciesOutput.Location = New System.Drawing.Point(116, 39)
        Me.lblSpeciesOutput.Name = "lblSpeciesOutput"
        Me.lblSpeciesOutput.Size = New System.Drawing.Size(18, 21)
        Me.lblSpeciesOutput.TabIndex = 33
        Me.lblSpeciesOutput.Text = "*"
        '
        'lblLogSpecies
        '
        Me.lblLogSpecies.AutoSize = True
        Me.lblLogSpecies.Location = New System.Drawing.Point(16, 39)
        Me.lblLogSpecies.Name = "lblLogSpecies"
        Me.lblLogSpecies.Size = New System.Drawing.Size(98, 21)
        Me.lblLogSpecies.TabIndex = 32
        Me.lblLogSpecies.Text = "Fish Species:"
        '
        'lblWeightOutput
        '
        Me.lblWeightOutput.AutoSize = True
        Me.lblWeightOutput.Location = New System.Drawing.Point(118, 382)
        Me.lblWeightOutput.Name = "lblWeightOutput"
        Me.lblWeightOutput.Size = New System.Drawing.Size(18, 21)
        Me.lblWeightOutput.TabIndex = 29
        Me.lblWeightOutput.Text = "*"
        '
        'lblLogWeight
        '
        Me.lblLogWeight.AutoSize = True
        Me.lblLogWeight.Location = New System.Drawing.Point(16, 382)
        Me.lblLogWeight.Name = "lblLogWeight"
        Me.lblLogWeight.Size = New System.Drawing.Size(96, 21)
        Me.lblLogWeight.TabIndex = 28
        Me.lblLogWeight.Text = "Fish Weight:"
        '
        'lblLengthOutput
        '
        Me.lblLengthOutput.AutoSize = True
        Me.lblLengthOutput.Location = New System.Drawing.Point(116, 333)
        Me.lblLengthOutput.Name = "lblLengthOutput"
        Me.lblLengthOutput.Size = New System.Drawing.Size(18, 21)
        Me.lblLengthOutput.TabIndex = 27
        Me.lblLengthOutput.Text = "*"
        '
        'lblIDOutput
        '
        Me.lblIDOutput.AutoSize = True
        Me.lblIDOutput.Location = New System.Drawing.Point(83, 431)
        Me.lblIDOutput.Name = "lblIDOutput"
        Me.lblIDOutput.Size = New System.Drawing.Size(18, 21)
        Me.lblIDOutput.TabIndex = 25
        Me.lblIDOutput.Text = "*"
        '
        'lblLogLength
        '
        Me.lblLogLength.AutoSize = True
        Me.lblLogLength.Location = New System.Drawing.Point(16, 333)
        Me.lblLogLength.Name = "lblLogLength"
        Me.lblLogLength.Size = New System.Drawing.Size(94, 21)
        Me.lblLogLength.TabIndex = 26
        Me.lblLogLength.Text = "Fish Length:"
        '
        'lblTechOutput
        '
        Me.lblTechOutput.AutoSize = True
        Me.lblTechOutput.Location = New System.Drawing.Point(145, 284)
        Me.lblTechOutput.Name = "lblTechOutput"
        Me.lblTechOutput.Size = New System.Drawing.Size(18, 21)
        Me.lblTechOutput.TabIndex = 23
        Me.lblTechOutput.Text = "*"
        '
        'lblLogID
        '
        Me.lblLogID.AutoSize = True
        Me.lblLogID.Location = New System.Drawing.Point(16, 431)
        Me.lblLogID.Name = "lblLogID"
        Me.lblLogID.Size = New System.Drawing.Size(61, 21)
        Me.lblLogID.TabIndex = 24
        Me.lblLogID.Text = "Fish ID:"
        '
        'lblLogTechnique
        '
        Me.lblLogTechnique.AutoSize = True
        Me.lblLogTechnique.Location = New System.Drawing.Point(16, 284)
        Me.lblLogTechnique.Name = "lblLogTechnique"
        Me.lblLogTechnique.Size = New System.Drawing.Size(123, 21)
        Me.lblLogTechnique.TabIndex = 22
        Me.lblLogTechnique.Text = "Technique Used:"
        '
        'lblClarityOutput
        '
        Me.lblClarityOutput.AutoSize = True
        Me.lblClarityOutput.Location = New System.Drawing.Point(128, 235)
        Me.lblClarityOutput.Name = "lblClarityOutput"
        Me.lblClarityOutput.Size = New System.Drawing.Size(18, 21)
        Me.lblClarityOutput.TabIndex = 21
        Me.lblClarityOutput.Text = "*"
        '
        'lblLogClarity
        '
        Me.lblLogClarity.AutoSize = True
        Me.lblLogClarity.Location = New System.Drawing.Point(16, 235)
        Me.lblLogClarity.Name = "lblLogClarity"
        Me.lblLogClarity.Size = New System.Drawing.Size(106, 21)
        Me.lblLogClarity.TabIndex = 20
        Me.lblLogClarity.Text = "Water Clarity:"
        '
        'lblLocationOutput
        '
        Me.lblLocationOutput.AutoSize = True
        Me.lblLocationOutput.Location = New System.Drawing.Point(92, 186)
        Me.lblLocationOutput.Name = "lblLocationOutput"
        Me.lblLocationOutput.Size = New System.Drawing.Size(18, 21)
        Me.lblLocationOutput.TabIndex = 19
        Me.lblLocationOutput.Text = "*"
        '
        'lblLogLocation
        '
        Me.lblLogLocation.AutoSize = True
        Me.lblLogLocation.Location = New System.Drawing.Point(16, 186)
        Me.lblLogLocation.Name = "lblLogLocation"
        Me.lblLogLocation.Size = New System.Drawing.Size(73, 21)
        Me.lblLogLocation.TabIndex = 18
        Me.lblLogLocation.Text = "Location:"
        '
        'lblTimeOutput
        '
        Me.lblTimeOutput.AutoSize = True
        Me.lblTimeOutput.Location = New System.Drawing.Point(116, 137)
        Me.lblTimeOutput.Name = "lblTimeOutput"
        Me.lblTimeOutput.Size = New System.Drawing.Size(18, 21)
        Me.lblTimeOutput.TabIndex = 17
        Me.lblTimeOutput.Text = "*"
        '
        'lblLogTimeDay
        '
        Me.lblLogTimeDay.AutoSize = True
        Me.lblLogTimeDay.Location = New System.Drawing.Point(16, 137)
        Me.lblLogTimeDay.Name = "lblLogTimeDay"
        Me.lblLogTimeDay.Size = New System.Drawing.Size(97, 21)
        Me.lblLogTimeDay.TabIndex = 16
        Me.lblLogTimeDay.Text = "Time of Day:"
        '
        'lblDateOutput
        '
        Me.lblDateOutput.AutoSize = True
        Me.lblDateOutput.Location = New System.Drawing.Point(69, 88)
        Me.lblDateOutput.Name = "lblDateOutput"
        Me.lblDateOutput.Size = New System.Drawing.Size(18, 21)
        Me.lblDateOutput.TabIndex = 15
        Me.lblDateOutput.Text = "*"
        '
        'lblLogDate
        '
        Me.lblLogDate.AutoSize = True
        Me.lblLogDate.Location = New System.Drawing.Point(16, 88)
        Me.lblLogDate.Name = "lblLogDate"
        Me.lblLogDate.Size = New System.Drawing.Size(47, 21)
        Me.lblLogDate.TabIndex = 14
        Me.lblLogDate.Text = "Date:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(12, 551)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(205, 62)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Delete.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(462, 551)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(200, 62)
        Me.Delete.TabIndex = 13
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(237, 551)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(205, 62)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmFishLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1263, 681)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbxFishLog)
        Me.Controls.Add(Me.lbxTripDate)
        Me.Controls.Add(Me.gbxTrip)
        Me.Controls.Add(Me.gbxFish)
        Me.Name = "frmFishLog"
        Me.Text = "frmFishLog"
        Me.gbxFish.ResumeLayout(False)
        Me.gbxFish.PerformLayout()
        Me.gbxTrip.ResumeLayout(False)
        Me.gbxTrip.PerformLayout()
        Me.gbxFishLog.ResumeLayout(False)
        Me.gbxFishLog.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTripDate As TextBox
    Friend WithEvents cbxTimeDay As ComboBox
    Friend WithEvents gbxFish As GroupBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents lblLength As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtSpecies As TextBox
    Friend WithEvents lblSpecies As Label
    Friend WithEvents gbxTrip As GroupBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTimeDay As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblLocate As Label
    Friend WithEvents txtTechnique As TextBox
    Friend WithEvents lblTechnique As Label
    Friend WithEvents txtClarity As TextBox
    Friend WithEvents lblClarity As Label
    Friend WithEvents lbxTripDate As ListBox
    Friend WithEvents gbxFishLog As GroupBox
    Friend WithEvents txtFishID As TextBox
    Friend WithEvents lblFishID As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Delete As Button
    Friend WithEvents lblSpeciesOutput As Label
    Friend WithEvents lblLogSpecies As Label
    Friend WithEvents lblWeightOutput As Label
    Friend WithEvents lblLogWeight As Label
    Friend WithEvents lblLengthOutput As Label
    Friend WithEvents lblLogLength As Label
    Friend WithEvents lblIDOutput As Label
    Friend WithEvents lblLogID As Label
    Friend WithEvents lblTechOutput As Label
    Friend WithEvents lblLogTechnique As Label
    Friend WithEvents lblClarityOutput As Label
    Friend WithEvents lblLogClarity As Label
    Friend WithEvents lblLocationOutput As Label
    Friend WithEvents lblLogLocation As Label
    Friend WithEvents lblTimeOutput As Label
    Friend WithEvents lblLogTimeDay As Label
    Friend WithEvents lblDateOutput As Label
    Friend WithEvents lblLogDate As Label
    Friend WithEvents btnClear As Button
End Class
