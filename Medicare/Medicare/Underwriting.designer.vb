<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Underwriting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblProposer_ID = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.LabelL4 = New System.Windows.Forms.Label
        Me.LabelL3 = New System.Windows.Forms.Label
        Me.LabelL2 = New System.Windows.Forms.Label
        Me.LabelL1 = New System.Windows.Forms.Label
        Me.lblUnderWriting_ID = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProposer_ID
        '
        Me.lblProposer_ID.AutoSize = True
        Me.lblProposer_ID.Location = New System.Drawing.Point(9, 18)
        Me.lblProposer_ID.Name = "lblProposer_ID"
        Me.lblProposer_ID.Size = New System.Drawing.Size(66, 13)
        Me.lblProposer_ID.TabIndex = 2
        Me.lblProposer_ID.Text = "Proposer_ID"
        Me.lblProposer_ID.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.CrystalReportViewer1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelL4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelL3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelL2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelL1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblUnderWriting_ID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblProposer_ID)
        Me.SplitContainer1.Size = New System.Drawing.Size(834, 654)
        Me.SplitContainer1.SplitterDistance = 600
        Me.SplitContainer1.TabIndex = 6
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPageNavigateButtons = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.ShowZoomButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(834, 600)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'LabelL4
        '
        Me.LabelL4.AutoSize = True
        Me.LabelL4.Location = New System.Drawing.Point(367, 18)
        Me.LabelL4.Name = "LabelL4"
        Me.LabelL4.Size = New System.Drawing.Size(0, 13)
        Me.LabelL4.TabIndex = 10
        Me.LabelL4.Visible = False
        '
        'LabelL3
        '
        Me.LabelL3.AutoSize = True
        Me.LabelL3.Location = New System.Drawing.Point(275, 18)
        Me.LabelL3.Name = "LabelL3"
        Me.LabelL3.Size = New System.Drawing.Size(82, 13)
        Me.LabelL3.TabIndex = 9
        Me.LabelL3.Text = "Poscode & Town"
        Me.LabelL3.Visible = False
        '
        'LabelL2
        '
        Me.LabelL2.AutoSize = True
        Me.LabelL2.Location = New System.Drawing.Point(236, 18)
        Me.LabelL2.Name = "LabelL2"
        Me.LabelL2.Size = New System.Drawing.Size(19, 13)
        Me.LabelL2.TabIndex = 8
        Me.LabelL2.Text = "L2"
        Me.LabelL2.Visible = False
        '
        'LabelL1
        '
        Me.LabelL1.AutoSize = True
        Me.LabelL1.Location = New System.Drawing.Point(204, 18)
        Me.LabelL1.Name = "LabelL1"
        Me.LabelL1.Size = New System.Drawing.Size(19, 13)
        Me.LabelL1.TabIndex = 7
        Me.LabelL1.Text = "L1"
        Me.LabelL1.Visible = False
        '
        'lblUnderWriting_ID
        '
        Me.lblUnderWriting_ID.AutoSize = True
        Me.lblUnderWriting_ID.Location = New System.Drawing.Point(91, 18)
        Me.lblUnderWriting_ID.Name = "lblUnderWriting_ID"
        Me.lblUnderWriting_ID.Size = New System.Drawing.Size(86, 13)
        Me.lblUnderWriting_ID.TabIndex = 3
        Me.lblUnderWriting_ID.Text = "UnderWriting_ID"
        Me.lblUnderWriting_ID.Visible = False
        '
        'Underwriting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 654)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Underwriting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Underwriting Letter"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblProposer_ID As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblUnderWriting_ID As System.Windows.Forms.Label
    Friend WithEvents LabelL4 As System.Windows.Forms.Label
    Friend WithEvents LabelL3 As System.Windows.Forms.Label
    Friend WithEvents LabelL2 As System.Windows.Forms.Label
    Friend WithEvents LabelL1 As System.Windows.Forms.Label
    'Friend WithEvents rejectLetter1 As Medicare.rejectLetter
End Class
