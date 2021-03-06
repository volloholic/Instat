﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDisplayDaily
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
        Me.chkPrintTables = New System.Windows.Forms.CheckBox()
        Me.chkRemoveNA = New System.Windows.Forms.CheckBox()
        Me.nudDecimalPlaces = New System.Windows.Forms.NumericUpDown()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblDayDisplay = New System.Windows.Forms.Label()
        Me.lblDecimalPlaces = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblSummaryNames = New System.Windows.Forms.Label()
        Me.lblMonth_Summaries = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkMonthAbbreviation = New System.Windows.Forms.CheckBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputMonthSummaries = New instat.ucrInputTextBox()
        Me.ucrInputVariable = New instat.ucrInputTextBox()
        Me.ucrInputDayDisplay = New instat.ucrInputTextBox()
        Me.ucrInputSummaryNames = New instat.ucrInputTextBox()
        CType(Me.nudDecimalPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkPrintTables
        '
        Me.chkPrintTables.AutoSize = True
        Me.chkPrintTables.Location = New System.Drawing.Point(194, 220)
        Me.chkPrintTables.Name = "chkPrintTables"
        Me.chkPrintTables.Size = New System.Drawing.Size(82, 17)
        Me.chkPrintTables.TabIndex = 1
        Me.chkPrintTables.Tag = "Print_Tables"
        Me.chkPrintTables.Text = "Print Tables"
        Me.chkPrintTables.UseVisualStyleBackColor = True
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(301, 220)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(139, 17)
        Me.chkRemoveNA.TabIndex = 2
        Me.chkRemoveNA.Tag = "Remove_Missing_Values"
        Me.chkRemoveNA.Text = "Remove Missing Values"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'nudDecimalPlaces
        '
        Me.nudDecimalPlaces.Location = New System.Drawing.Point(346, 132)
        Me.nudDecimalPlaces.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudDecimalPlaces.Name = "nudDecimalPlaces"
        Me.nudDecimalPlaces.Size = New System.Drawing.Size(67, 20)
        Me.nudDecimalPlaces.TabIndex = 3
        '
        'nudThreshold
        '
        Me.nudThreshold.Location = New System.Drawing.Point(109, 127)
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(76, 20)
        Me.nudThreshold.TabIndex = 4
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(27, 65)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(45, 13)
        Me.lblVariable.TabIndex = 10
        Me.lblVariable.Tag = "Variable"
        Me.lblVariable.Text = "Variable"
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.AutoSize = True
        Me.lblDayDisplay.Location = New System.Drawing.Point(27, 94)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(63, 13)
        Me.lblDayDisplay.TabIndex = 11
        Me.lblDayDisplay.Tag = "Day_Display"
        Me.lblDayDisplay.Text = "Day Display"
        '
        'lblDecimalPlaces
        '
        Me.lblDecimalPlaces.AutoSize = True
        Me.lblDecimalPlaces.Location = New System.Drawing.Point(236, 134)
        Me.lblDecimalPlaces.Name = "lblDecimalPlaces"
        Me.lblDecimalPlaces.Size = New System.Drawing.Size(80, 13)
        Me.lblDecimalPlaces.TabIndex = 12
        Me.lblDecimalPlaces.Tag = "Decimal_Places"
        Me.lblDecimalPlaces.Text = "Decimal Places"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(27, 134)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lblThreshold.TabIndex = 13
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold"
        '
        'lblSummaryNames
        '
        Me.lblSummaryNames.AutoSize = True
        Me.lblSummaryNames.Location = New System.Drawing.Point(27, 177)
        Me.lblSummaryNames.Name = "lblSummaryNames"
        Me.lblSummaryNames.Size = New System.Drawing.Size(86, 13)
        Me.lblSummaryNames.TabIndex = 14
        Me.lblSummaryNames.Tag = "Summary_Names"
        Me.lblSummaryNames.Text = "Summary Names"
        '
        'lblMonth_Summaries
        '
        Me.lblMonth_Summaries.AutoSize = True
        Me.lblMonth_Summaries.Location = New System.Drawing.Point(27, 39)
        Me.lblMonth_Summaries.Name = "lblMonth_Summaries"
        Me.lblMonth_Summaries.Size = New System.Drawing.Size(91, 13)
        Me.lblMonth_Summaries.TabIndex = 16
        Me.lblMonth_Summaries.Tag = "Month_Summaries"
        Me.lblMonth_Summaries.Text = "Month Summaries"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Not implememted"
        '
        'chkMonthAbbreviation
        '
        Me.chkMonthAbbreviation.AutoSize = True
        Me.chkMonthAbbreviation.Location = New System.Drawing.Point(30, 220)
        Me.chkMonthAbbreviation.Name = "chkMonthAbbreviation"
        Me.chkMonthAbbreviation.Size = New System.Drawing.Size(118, 17)
        Me.chkMonthAbbreviation.TabIndex = 18
        Me.chkMonthAbbreviation.Tag = "Month_Abbreviation"
        Me.chkMonthAbbreviation.Text = "Month Abbreviation"
        Me.chkMonthAbbreviation.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(30, 243)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 56)
        Me.ucrBase.TabIndex = 0
        '
        'ucrInputMonthSummaries
        '
        Me.ucrInputMonthSummaries.Location = New System.Drawing.Point(194, 31)
        Me.ucrInputMonthSummaries.Name = "ucrInputMonthSummaries"
        Me.ucrInputMonthSummaries.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputMonthSummaries.TabIndex = 19
        '
        'ucrInputVariable
        '
        Me.ucrInputVariable.Location = New System.Drawing.Point(194, 59)
        Me.ucrInputVariable.Name = "ucrInputVariable"
        Me.ucrInputVariable.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputVariable.TabIndex = 20
        '
        'ucrInputDayDisplay
        '
        Me.ucrInputDayDisplay.Location = New System.Drawing.Point(194, 86)
        Me.ucrInputDayDisplay.Name = "ucrInputDayDisplay"
        Me.ucrInputDayDisplay.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputDayDisplay.TabIndex = 21
        '
        'ucrInputSummaryNames
        '
        Me.ucrInputSummaryNames.Location = New System.Drawing.Point(119, 169)
        Me.ucrInputSummaryNames.Name = "ucrInputSummaryNames"
        Me.ucrInputSummaryNames.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputSummaryNames.TabIndex = 22
        '
        'dlgDisplayDaily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 304)
        Me.Controls.Add(Me.ucrInputSummaryNames)
        Me.Controls.Add(Me.ucrInputDayDisplay)
        Me.Controls.Add(Me.ucrInputVariable)
        Me.Controls.Add(Me.ucrInputMonthSummaries)
        Me.Controls.Add(Me.chkMonthAbbreviation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMonth_Summaries)
        Me.Controls.Add(Me.lblSummaryNames)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblDecimalPlaces)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.nudDecimalPlaces)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.chkPrintTables)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayDaily"
        Me.Tag = "Display_Daily"
        Me.Text = "Display Daily"
        CType(Me.nudDecimalPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkPrintTables As CheckBox
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents nudDecimalPlaces As NumericUpDown
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents lblVariable As Label
    Friend WithEvents lblDayDisplay As Label
    Friend WithEvents lblDecimalPlaces As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblSummaryNames As Label
    Friend WithEvents lblMonth_Summaries As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkMonthAbbreviation As CheckBox
    Friend WithEvents ucrInputMonthSummaries As ucrInputTextBox
    Friend WithEvents ucrInputVariable As ucrInputTextBox
    Friend WithEvents ucrInputDayDisplay As ucrInputTextBox
    Friend WithEvents ucrInputSummaryNames As ucrInputTextBox
End Class
