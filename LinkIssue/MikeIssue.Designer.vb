﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MikeIssue
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MikeIssue))
        Me.cmdEnhance = New System.Windows.Forms.Button()
        Me.txtIssue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblThanks = New System.Windows.Forms.Label()
        Me.tmrThanks = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'cmdEnhance
        '
        Me.cmdEnhance.Location = New System.Drawing.Point(229, 33)
        Me.cmdEnhance.Name = "cmdEnhance"
        Me.cmdEnhance.Size = New System.Drawing.Size(87, 31)
        Me.cmdEnhance.TabIndex = 1
        Me.cmdEnhance.Text = "ENHANCE"
        Me.cmdEnhance.UseVisualStyleBackColor = True
        '
        'txtIssue
        '
        Me.txtIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssue.Location = New System.Drawing.Point(12, 33)
        Me.txtIssue.Name = "txtIssue"
        Me.txtIssue.Size = New System.Drawing.Size(211, 31)
        Me.txtIssue.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Issue Number"
        '
        'lblThanks
        '
        Me.lblThanks.AutoSize = True
        Me.lblThanks.Location = New System.Drawing.Point(231, 9)
        Me.lblThanks.Name = "lblThanks"
        Me.lblThanks.Size = New System.Drawing.Size(85, 13)
        Me.lblThanks.TabIndex = 3
        Me.lblThanks.Text = "DONE THANKS"
        Me.lblThanks.Visible = False
        '
        'tmrThanks
        '
        Me.tmrThanks.Interval = 1000
        '
        'MikeIssue
        '
        Me.AcceptButton = Me.cmdEnhance
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 79)
        Me.Controls.Add(Me.lblThanks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIssue)
        Me.Controls.Add(Me.cmdEnhance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MikeIssue"
        Me.Text = "Link Issue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdEnhance As System.Windows.Forms.Button
    Friend WithEvents txtIssue As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblThanks As Label
    Friend WithEvents tmrThanks As Timer
End Class
