﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnDisplayAccountSummary = New System.Windows.Forms.Button()
        Me.lstAccountSummary = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplayAccountSummary
        '
        Me.btnDisplayAccountSummary.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDisplayAccountSummary.Location = New System.Drawing.Point(293, 12)
        Me.btnDisplayAccountSummary.Name = "btnDisplayAccountSummary"
        Me.btnDisplayAccountSummary.Size = New System.Drawing.Size(211, 28)
        Me.btnDisplayAccountSummary.TabIndex = 0
        Me.btnDisplayAccountSummary.Text = "Display Account Summary"
        Me.btnDisplayAccountSummary.UseVisualStyleBackColor = True
        '
        'lstAccountSummary
        '
        Me.lstAccountSummary.FormattingEnabled = True
        Me.lstAccountSummary.Location = New System.Drawing.Point(2, 61)
        Me.lstAccountSummary.Name = "lstAccountSummary"
        Me.lstAccountSummary.Size = New System.Drawing.Size(779, 186)
        Me.lstAccountSummary.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 251)
        Me.Controls.Add(Me.lstAccountSummary)
        Me.Controls.Add(Me.btnDisplayAccountSummary)
        Me.Name = "frmMain"
        Me.Text = "Credit Card Accounts"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDisplayAccountSummary As System.Windows.Forms.Button
    Friend WithEvents lstAccountSummary As System.Windows.Forms.ListBox

End Class
