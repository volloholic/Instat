﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTransposeColumns
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
        Me.lblColumnsToTranspose = New System.Windows.Forms.Label()
        Me.chkNameNewColumns = New System.Windows.Forms.CheckBox()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.ucrInputNewDataFrame = New instat.ucrInputTextBox()
        Me.ucrColumsToTranspose = New instat.ucrReceiverMultiple()
        Me.ucrSelectorTransposeColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblColumnsToTranspose
        '
        Me.lblColumnsToTranspose.AutoSize = True
        Me.lblColumnsToTranspose.Location = New System.Drawing.Point(255, 25)
        Me.lblColumnsToTranspose.Name = "lblColumnsToTranspose"
        Me.lblColumnsToTranspose.Size = New System.Drawing.Size(112, 13)
        Me.lblColumnsToTranspose.TabIndex = 1
        Me.lblColumnsToTranspose.Tag = "Columns_to_Transpose"
        Me.lblColumnsToTranspose.Text = "Columns to Transpose"
        '
        'chkNameNewColumns
        '
        Me.chkNameNewColumns.AutoSize = True
        Me.chkNameNewColumns.Location = New System.Drawing.Point(255, 163)
        Me.chkNameNewColumns.Name = "chkNameNewColumns"
        Me.chkNameNewColumns.Size = New System.Drawing.Size(122, 17)
        Me.chkNameNewColumns.TabIndex = 3
        Me.chkNameNewColumns.Tag = "Name_New_Columns"
        Me.chkNameNewColumns.Text = "Name New Columns"
        Me.chkNameNewColumns.UseVisualStyleBackColor = True
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.AutoSize = True
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(10, 204)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(118, 13)
        Me.lblNewDataFrameName.TabIndex = 4
        Me.lblNewDataFrameName.Tag = "New_Data_Frame_Name"
        Me.lblNewDataFrameName.Text = "New Data Frame Name"
        '
        'ucrInputNewDataFrame
        '
        Me.ucrInputNewDataFrame.Location = New System.Drawing.Point(134, 201)
        Me.ucrInputNewDataFrame.Name = "ucrInputNewDataFrame"
        Me.ucrInputNewDataFrame.Size = New System.Drawing.Size(145, 21)
        Me.ucrInputNewDataFrame.TabIndex = 5
        '
        'ucrColumsToTranspose
        '
        Me.ucrColumsToTranspose.Location = New System.Drawing.Point(255, 39)
        Me.ucrColumsToTranspose.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrColumsToTranspose.Name = "ucrColumsToTranspose"
        Me.ucrColumsToTranspose.Selector = Nothing
        Me.ucrColumsToTranspose.Size = New System.Drawing.Size(120, 100)
        Me.ucrColumsToTranspose.TabIndex = 2
        '
        'ucrSelectorTransposeColumns
        '
        Me.ucrSelectorTransposeColumns.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorTransposeColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTransposeColumns.Name = "ucrSelectorTransposeColumns"
        Me.ucrSelectorTransposeColumns.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorTransposeColumns.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 230)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 6
        '
        'dlgTransposeColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 283)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.ucrInputNewDataFrame)
        Me.Controls.Add(Me.chkNameNewColumns)
        Me.Controls.Add(Me.lblColumnsToTranspose)
        Me.Controls.Add(Me.ucrColumsToTranspose)
        Me.Controls.Add(Me.ucrSelectorTransposeColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgTransposeColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Transpose_Columns"
        Me.Text = "Transpose Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTransposeColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrColumsToTranspose As ucrReceiverMultiple
    Friend WithEvents lblColumnsToTranspose As Label
    Friend WithEvents chkNameNewColumns As CheckBox
    Friend WithEvents ucrInputNewDataFrame As ucrInputTextBox
    Friend WithEvents lblNewDataFrameName As Label
End Class
