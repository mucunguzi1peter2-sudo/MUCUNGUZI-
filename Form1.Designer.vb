<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmbCarType = New System.Windows.Forms.ComboBox()
        Me.txtRentalDuration = New System.Windows.Forms.TextBox()
        Me.txtTotalRentalCost = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblRentalDuration = New System.Windows.Forms.Label()
        Me.lblCarType = New System.Windows.Forms.Label()
        Me.lblTotalRentalCost = New System.Windows.Forms.Label()
        Me.lblDailyCharge = New System.Windows.Forms.Label()
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtDailyCharge = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbCarType
        '
        Me.cmbCarType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCarType.FormattingEnabled = True
        Me.cmbCarType.ItemHeight = 20
        Me.cmbCarType.Location = New System.Drawing.Point(316, 89)
        Me.cmbCarType.Name = "cmbCarType"
        Me.cmbCarType.Size = New System.Drawing.Size(266, 28)
        Me.cmbCarType.TabIndex = 0
        '
        'txtRentalDuration
        '
        Me.txtRentalDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentalDuration.Location = New System.Drawing.Point(318, 199)
        Me.txtRentalDuration.Name = "txtRentalDuration"
        Me.txtRentalDuration.Size = New System.Drawing.Size(264, 26)
        Me.txtRentalDuration.TabIndex = 1
        '
        'txtTotalRentalCost
        '
        Me.txtTotalRentalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRentalCost.Location = New System.Drawing.Point(318, 251)
        Me.txtTotalRentalCost.Name = "txtTotalRentalCost"
        Me.txtTotalRentalCost.Size = New System.Drawing.Size(264, 26)
        Me.txtTotalRentalCost.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnCalculate.Location = New System.Drawing.Point(316, 314)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(144, 61)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblRentalDuration
        '
        Me.lblRentalDuration.AutoSize = True
        Me.lblRentalDuration.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalDuration.Location = New System.Drawing.Point(101, 201)
        Me.lblRentalDuration.Name = "lblRentalDuration"
        Me.lblRentalDuration.Size = New System.Drawing.Size(192, 19)
        Me.lblRentalDuration.TabIndex = 4
        Me.lblRentalDuration.Text = "RENTAL DURATION (days)"
        '
        'lblCarType
        '
        Me.lblCarType.AutoSize = True
        Me.lblCarType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarType.Location = New System.Drawing.Point(200, 92)
        Me.lblCarType.Name = "lblCarType"
        Me.lblCarType.Size = New System.Drawing.Size(83, 19)
        Me.lblCarType.TabIndex = 5
        Me.lblCarType.Text = "CAR TYPE"
        '
        'lblTotalRentalCost
        '
        Me.lblTotalRentalCost.AutoSize = True
        Me.lblTotalRentalCost.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRentalCost.Location = New System.Drawing.Point(139, 252)
        Me.lblTotalRentalCost.Name = "lblTotalRentalCost"
        Me.lblTotalRentalCost.Size = New System.Drawing.Size(164, 19)
        Me.lblTotalRentalCost.TabIndex = 6
        Me.lblTotalRentalCost.Text = "TOTAL RENTAL COST"
        '
        'lblDailyCharge
        '
        Me.lblDailyCharge.AutoSize = True
        Me.lblDailyCharge.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDailyCharge.Location = New System.Drawing.Point(179, 147)
        Me.lblDailyCharge.Name = "lblDailyCharge"
        Me.lblDailyCharge.Size = New System.Drawing.Size(120, 19)
        Me.lblDailyCharge.TabIndex = 7
        Me.lblDailyCharge.Text = "DAILY CHARGE"
        '
        'lblFastLogisticsCompanyRentalChargesTrackingSystem
        '
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.AutoSize = True
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Location = New System.Drawing.Point(62, 28)
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Name = "lblFastLogisticsCompanyRentalChargesTrackingSystem"
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Size = New System.Drawing.Size(644, 22)
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.TabIndex = 9
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Text = "FAST LOGISTICS COMPANY RENTAL CHARGES TRACKING SYSTEM"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnClear.Location = New System.Drawing.Point(513, 315)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 61)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtDailyCharge
        '
        Me.txtDailyCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDailyCharge.Location = New System.Drawing.Point(316, 147)
        Me.txtDailyCharge.Name = "txtDailyCharge"
        Me.txtDailyCharge.Size = New System.Drawing.Size(266, 26)
        Me.txtDailyCharge.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDailyCharge)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblFastLogisticsCompanyRentalChargesTrackingSystem)
        Me.Controls.Add(Me.lblDailyCharge)
        Me.Controls.Add(Me.lblTotalRentalCost)
        Me.Controls.Add(Me.lblCarType)
        Me.Controls.Add(Me.lblRentalDuration)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTotalRentalCost)
        Me.Controls.Add(Me.txtRentalDuration)
        Me.Controls.Add(Me.cmbCarType)
        Me.Name = "Form1"
        Me.Text = "Car_rentals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCarType As ComboBox
    Friend WithEvents txtRentalDuration As TextBox
    Friend WithEvents txtTotalRentalCost As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblRentalDuration As Label
    Friend WithEvents lblCarType As Label
    Friend WithEvents lblTotalRentalCost As Label
    Friend WithEvents lblDailyCharge As Label
    Friend WithEvents lblFastLogisticsCompanyRentalChargesTrackingSystem As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtDailyCharge As TextBox
End Class
