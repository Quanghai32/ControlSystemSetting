﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingForm
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
        Me.TabSetting = New System.Windows.Forms.TabControl()
        Me.TabSettingAGV = New System.Windows.Forms.TabPage()
        Me.dgvAGV = New System.Windows.Forms.DataGridView()
        Me.TabSettingPart = New System.Windows.Forms.TabPage()
        Me.dgvPart = New System.Windows.Forms.DataGridView()
        Me.TabSettingEndDevices = New System.Windows.Forms.TabPage()
        Me.dgvEndDevices = New System.Windows.Forms.DataGridView()
        Me.TabSettingHostXbee = New System.Windows.Forms.TabPage()
        Me.dgvHostXbee = New System.Windows.Forms.DataGridView()
        Me.TabSettingLine = New System.Windows.Forms.TabPage()
        Me.dgvLineGroup = New System.Windows.Forms.DataGridView()
        Me.TabSettingStartPoint = New System.Windows.Forms.TabPage()
        Me.dgvStartPoint = New System.Windows.Forms.DataGridView()
        Me.TabSettingCrossPoint = New System.Windows.Forms.TabPage()
        Me.dgvCrossPoint = New System.Windows.Forms.DataGridView()
        Me.TabSettingAGVGroup = New System.Windows.Forms.TabPage()
        Me.dgvAGVGroup = New System.Windows.Forms.DataGridView()
        Me.TabSettingParkPoint = New System.Windows.Forms.TabPage()
        Me.dgvParkPoint = New System.Windows.Forms.DataGridView()
        Me.butSettingOK = New System.Windows.Forms.Button()
        Me.butSettingCancel = New System.Windows.Forms.Button()
        Me.TabWorkingTime = New System.Windows.Forms.TabPage()
        Me.dgvWorkingTime = New System.Windows.Forms.DataGridView()
        Me.TabSetting.SuspendLayout()
        Me.TabSettingAGV.SuspendLayout()
        CType(Me.dgvAGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSettingPart.SuspendLayout()
        CType(Me.dgvPart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSettingEndDevices.SuspendLayout()
        CType(Me.dgvEndDevices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSettingHostXbee.SuspendLayout()
        CType(Me.dgvHostXbee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSettingLine.SuspendLayout()
        CType(Me.dgvLineGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSettingStartPoint.SuspendLayout()
        CType(Me.dgvStartPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSettingCrossPoint.SuspendLayout()
        CType(Me.dgvCrossPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSettingAGVGroup.SuspendLayout()
        CType(Me.dgvAGVGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSettingParkPoint.SuspendLayout()
        CType(Me.dgvParkPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabWorkingTime.SuspendLayout()
        CType(Me.dgvWorkingTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabSetting
        '
        Me.TabSetting.Controls.Add(Me.TabSettingAGV)
        Me.TabSetting.Controls.Add(Me.TabSettingPart)
        Me.TabSetting.Controls.Add(Me.TabSettingEndDevices)
        Me.TabSetting.Controls.Add(Me.TabSettingHostXbee)
        Me.TabSetting.Controls.Add(Me.TabSettingLine)
        Me.TabSetting.Controls.Add(Me.TabSettingStartPoint)
        Me.TabSetting.Controls.Add(Me.TabSettingCrossPoint)
        Me.TabSetting.Controls.Add(Me.TabSettingAGVGroup)
        Me.TabSetting.Controls.Add(Me.TabSettingParkPoint)
        Me.TabSetting.Controls.Add(Me.TabWorkingTime)
        Me.TabSetting.Location = New System.Drawing.Point(13, 13)
        Me.TabSetting.Name = "TabSetting"
        Me.TabSetting.SelectedIndex = 0
        Me.TabSetting.Size = New System.Drawing.Size(752, 471)
        Me.TabSetting.TabIndex = 2
        '
        'TabSettingAGV
        '
        Me.TabSettingAGV.Controls.Add(Me.dgvAGV)
        Me.TabSettingAGV.Location = New System.Drawing.Point(4, 22)
        Me.TabSettingAGV.Name = "TabSettingAGV"
        Me.TabSettingAGV.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSettingAGV.Size = New System.Drawing.Size(744, 445)
        Me.TabSettingAGV.TabIndex = 0
        Me.TabSettingAGV.Text = "AGV"
        Me.TabSettingAGV.UseVisualStyleBackColor = True
        '
        'dgvAGV
        '
        Me.dgvAGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAGV.Location = New System.Drawing.Point(3, 3)
        Me.dgvAGV.Name = "dgvAGV"
        Me.dgvAGV.Size = New System.Drawing.Size(738, 439)
        Me.dgvAGV.TabIndex = 2
        '
        'TabSettingPart
        '
        Me.TabSettingPart.Controls.Add(Me.dgvPart)
        Me.TabSettingPart.Location = New System.Drawing.Point(4, 22)
        Me.TabSettingPart.Name = "TabSettingPart"
        Me.TabSettingPart.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSettingPart.Size = New System.Drawing.Size(744, 445)
        Me.TabSettingPart.TabIndex = 1
        Me.TabSettingPart.Text = "Part"
        Me.TabSettingPart.UseVisualStyleBackColor = True
        '
        'dgvPart
        '
        Me.dgvPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPart.Location = New System.Drawing.Point(3, 3)
        Me.dgvPart.Name = "dgvPart"
        Me.dgvPart.Size = New System.Drawing.Size(738, 439)
        Me.dgvPart.TabIndex = 0
        '
        'TabSettingEndDevices
        '
        Me.TabSettingEndDevices.Controls.Add(Me.dgvEndDevices)
        Me.TabSettingEndDevices.Location = New System.Drawing.Point(4, 22)
        Me.TabSettingEndDevices.Name = "TabSettingEndDevices"
        Me.TabSettingEndDevices.Size = New System.Drawing.Size(744, 445)
        Me.TabSettingEndDevices.TabIndex = 2
        Me.TabSettingEndDevices.Text = "End Devices"
        Me.TabSettingEndDevices.UseVisualStyleBackColor = True
        '
        'dgvEndDevices
        '
        Me.dgvEndDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEndDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEndDevices.Location = New System.Drawing.Point(0, 0)
        Me.dgvEndDevices.Name = "dgvEndDevices"
        Me.dgvEndDevices.Size = New System.Drawing.Size(744, 445)
        Me.dgvEndDevices.TabIndex = 0
        '
        'TabSettingHostXbee
        '
        Me.TabSettingHostXbee.Controls.Add(Me.dgvHostXbee)
        Me.TabSettingHostXbee.Location = New System.Drawing.Point(4, 22)
        Me.TabSettingHostXbee.Name = "TabSettingHostXbee"
        Me.TabSettingHostXbee.Size = New System.Drawing.Size(744, 445)
        Me.TabSettingHostXbee.TabIndex = 3
        Me.TabSettingHostXbee.Text = "Host Xbee"
        Me.TabSettingHostXbee.UseVisualStyleBackColor = True
        '
        'dgvHostXbee
        '
        Me.dgvHostXbee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHostXbee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHostXbee.Location = New System.Drawing.Point(0, 0)
        Me.dgvHostXbee.Name = "dgvHostXbee"
        Me.dgvHostXbee.Size = New System.Drawing.Size(744, 445)
        Me.dgvHostXbee.TabIndex = 0
        '
        'TabSettingLine
        '
        Me.TabSettingLine.Controls.Add(Me.dgvLineGroup)
        Me.TabSettingLine.Location = New System.Drawing.Point(4, 22)
        Me.TabSettingLine.Name = "TabSettingLine"
        Me.TabSettingLine.Size = New System.Drawing.Size(744, 445)
        Me.TabSettingLine.TabIndex = 4
        Me.TabSettingLine.Text = "Line"
        Me.TabSettingLine.UseVisualStyleBackColor = True
        '
        'dgvLineGroup
        '
        Me.dgvLineGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLineGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLineGroup.Location = New System.Drawing.Point(0, 0)
        Me.dgvLineGroup.Name = "dgvLineGroup"
        Me.dgvLineGroup.Size = New System.Drawing.Size(744, 445)
        Me.dgvLineGroup.TabIndex = 0
        '
        'TabSettingStartPoint
        '
        Me.TabSettingStartPoint.Controls.Add(Me.dgvStartPoint)
        Me.TabSettingStartPoint.Location = New System.Drawing.Point(4, 22)
        Me.TabSettingStartPoint.Name = "TabSettingStartPoint"
        Me.TabSettingStartPoint.Size = New System.Drawing.Size(744, 445)
        Me.TabSettingStartPoint.TabIndex = 5
        Me.TabSettingStartPoint.Text = "Start Point"
        Me.TabSettingStartPoint.UseVisualStyleBackColor = True
        '
        'dgvStartPoint
        '
        Me.dgvStartPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStartPoint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStartPoint.Location = New System.Drawing.Point(0, 0)
        Me.dgvStartPoint.Name = "dgvStartPoint"
        Me.dgvStartPoint.Size = New System.Drawing.Size(744, 445)
        Me.dgvStartPoint.TabIndex = 0
        '
        'TabSettingCrossPoint
        '
        Me.TabSettingCrossPoint.Controls.Add(Me.dgvCrossPoint)
        Me.TabSettingCrossPoint.Location = New System.Drawing.Point(4, 22)
        Me.TabSettingCrossPoint.Name = "TabSettingCrossPoint"
        Me.TabSettingCrossPoint.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSettingCrossPoint.Size = New System.Drawing.Size(744, 445)
        Me.TabSettingCrossPoint.TabIndex = 6
        Me.TabSettingCrossPoint.Text = "Cross point"
        Me.TabSettingCrossPoint.UseVisualStyleBackColor = True
        '
        'dgvCrossPoint
        '
        Me.dgvCrossPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCrossPoint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCrossPoint.Location = New System.Drawing.Point(3, 3)
        Me.dgvCrossPoint.Name = "dgvCrossPoint"
        Me.dgvCrossPoint.Size = New System.Drawing.Size(738, 439)
        Me.dgvCrossPoint.TabIndex = 0
        '
        'TabSettingAGVGroup
        '
        Me.TabSettingAGVGroup.Controls.Add(Me.dgvAGVGroup)
        Me.TabSettingAGVGroup.Location = New System.Drawing.Point(4, 22)
        Me.TabSettingAGVGroup.Name = "TabSettingAGVGroup"
        Me.TabSettingAGVGroup.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSettingAGVGroup.Size = New System.Drawing.Size(744, 445)
        Me.TabSettingAGVGroup.TabIndex = 7
        Me.TabSettingAGVGroup.Text = "AGV group"
        Me.TabSettingAGVGroup.UseVisualStyleBackColor = True
        '
        'dgvAGVGroup
        '
        Me.dgvAGVGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAGVGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAGVGroup.Location = New System.Drawing.Point(3, 3)
        Me.dgvAGVGroup.Name = "dgvAGVGroup"
        Me.dgvAGVGroup.Size = New System.Drawing.Size(738, 439)
        Me.dgvAGVGroup.TabIndex = 0
        '
        'TabSettingParkPoint
        '
        Me.TabSettingParkPoint.Controls.Add(Me.dgvParkPoint)
        Me.TabSettingParkPoint.Location = New System.Drawing.Point(4, 22)
        Me.TabSettingParkPoint.Name = "TabSettingParkPoint"
        Me.TabSettingParkPoint.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSettingParkPoint.Size = New System.Drawing.Size(744, 445)
        Me.TabSettingParkPoint.TabIndex = 8
        Me.TabSettingParkPoint.Text = "Park point"
        Me.TabSettingParkPoint.UseVisualStyleBackColor = True
        '
        'dgvParkPoint
        '
        Me.dgvParkPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParkPoint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvParkPoint.Location = New System.Drawing.Point(3, 3)
        Me.dgvParkPoint.Name = "dgvParkPoint"
        Me.dgvParkPoint.Size = New System.Drawing.Size(738, 439)
        Me.dgvParkPoint.TabIndex = 0
        '
        'butSettingOK
        '
        Me.butSettingOK.Location = New System.Drawing.Point(263, 500)
        Me.butSettingOK.Name = "butSettingOK"
        Me.butSettingOK.Size = New System.Drawing.Size(75, 23)
        Me.butSettingOK.TabIndex = 3
        Me.butSettingOK.Text = "OK"
        Me.butSettingOK.UseVisualStyleBackColor = True
        '
        'butSettingCancel
        '
        Me.butSettingCancel.Location = New System.Drawing.Point(344, 500)
        Me.butSettingCancel.Name = "butSettingCancel"
        Me.butSettingCancel.Size = New System.Drawing.Size(75, 23)
        Me.butSettingCancel.TabIndex = 4
        Me.butSettingCancel.Text = "Cancel"
        Me.butSettingCancel.UseVisualStyleBackColor = True
        '
        'TabWorkingTime
        '
        Me.TabWorkingTime.Controls.Add(Me.dgvWorkingTime)
        Me.TabWorkingTime.Location = New System.Drawing.Point(4, 22)
        Me.TabWorkingTime.Name = "TabWorkingTime"
        Me.TabWorkingTime.Padding = New System.Windows.Forms.Padding(3)
        Me.TabWorkingTime.Size = New System.Drawing.Size(744, 445)
        Me.TabWorkingTime.TabIndex = 9
        Me.TabWorkingTime.Text = "Working time"
        Me.TabWorkingTime.UseVisualStyleBackColor = True
        '
        'dgvWorkingTime
        '
        Me.dgvWorkingTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkingTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWorkingTime.Location = New System.Drawing.Point(3, 3)
        Me.dgvWorkingTime.Name = "dgvWorkingTime"
        Me.dgvWorkingTime.Size = New System.Drawing.Size(738, 439)
        Me.dgvWorkingTime.TabIndex = 0
        '
        'SettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 534)
        Me.Controls.Add(Me.butSettingCancel)
        Me.Controls.Add(Me.butSettingOK)
        Me.Controls.Add(Me.TabSetting)
        Me.Name = "SettingForm"
        Me.Text = "Setting"
        Me.TabSetting.ResumeLayout(False)
        Me.TabSettingAGV.ResumeLayout(False)
        CType(Me.dgvAGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSettingPart.ResumeLayout(False)
        CType(Me.dgvPart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSettingEndDevices.ResumeLayout(False)
        CType(Me.dgvEndDevices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSettingHostXbee.ResumeLayout(False)
        CType(Me.dgvHostXbee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSettingLine.ResumeLayout(False)
        CType(Me.dgvLineGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSettingStartPoint.ResumeLayout(False)
        CType(Me.dgvStartPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSettingCrossPoint.ResumeLayout(False)
        CType(Me.dgvCrossPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSettingAGVGroup.ResumeLayout(False)
        CType(Me.dgvAGVGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSettingParkPoint.ResumeLayout(False)
        CType(Me.dgvParkPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabWorkingTime.ResumeLayout(False)
        CType(Me.dgvWorkingTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabSetting As System.Windows.Forms.TabControl
    Friend WithEvents TabSettingAGV As System.Windows.Forms.TabPage
    Friend WithEvents TabSettingPart As System.Windows.Forms.TabPage
    Friend WithEvents butSettingOK As System.Windows.Forms.Button
    Friend WithEvents butSettingCancel As System.Windows.Forms.Button
    Friend WithEvents dgvAGV As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPart As System.Windows.Forms.DataGridView
    Friend WithEvents TabSettingEndDevices As System.Windows.Forms.TabPage
    Friend WithEvents dgvEndDevices As System.Windows.Forms.DataGridView
    Friend WithEvents TabSettingHostXbee As System.Windows.Forms.TabPage
    Friend WithEvents dgvHostXbee As System.Windows.Forms.DataGridView
    Friend WithEvents TabSettingLine As System.Windows.Forms.TabPage
    Friend WithEvents dgvLineGroup As System.Windows.Forms.DataGridView
    Friend WithEvents TabSettingStartPoint As System.Windows.Forms.TabPage
    Friend WithEvents dgvStartPoint As System.Windows.Forms.DataGridView
    Friend WithEvents TabSettingCrossPoint As System.Windows.Forms.TabPage
    Friend WithEvents dgvCrossPoint As System.Windows.Forms.DataGridView
    Friend WithEvents TabSettingAGVGroup As System.Windows.Forms.TabPage
    Friend WithEvents dgvAGVGroup As System.Windows.Forms.DataGridView
    Friend WithEvents TabSettingParkPoint As System.Windows.Forms.TabPage
    Friend WithEvents dgvParkPoint As System.Windows.Forms.DataGridView
    Friend WithEvents TabWorkingTime As System.Windows.Forms.TabPage
    Friend WithEvents dgvWorkingTime As System.Windows.Forms.DataGridView
End Class
