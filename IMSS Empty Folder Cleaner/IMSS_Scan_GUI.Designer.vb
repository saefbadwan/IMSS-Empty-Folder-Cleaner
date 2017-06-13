<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_Scan_GUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_Scan_GUI))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_ClickPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_CURRENT_SCAN_PROCESS = New System.Windows.Forms.Label()
        Me._IMSS_SCAN = New System.Windows.Forms.Button()
        Me._IMSS_Cancel = New System.Windows.Forms.Button()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me._IMSS_BrwoseButton = New System.Windows.Forms.Button()
        Me._IMSS_SelectedPath_TextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me._IMSS_DriversListView = New System.Windows.Forms.ListView()
        Me._IMSS_FoldersReadioButton = New System.Windows.Forms.RadioButton()
        Me._IMSS_DriversReadioButton = New System.Windows.Forms.RadioButton()
        Me._IMSS_AddFolders = New System.Windows.Forms.FolderBrowserDialog()
        Me._IMSS_MainPanel.SuspendLayout()
        Me._IMSS_ClickPanel.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_ClickPanel)
        Me._IMSS_MainPanel.Controls.Add(Me.GroupPanel1)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(438, 237)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 1
        '
        '_IMSS_ClickPanel
        '
        Me._IMSS_ClickPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_ClickPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_ClickPanel.Controls.Add(Me._IMSS_CURRENT_SCAN_PROCESS)
        Me._IMSS_ClickPanel.Controls.Add(Me._IMSS_SCAN)
        Me._IMSS_ClickPanel.Controls.Add(Me._IMSS_Cancel)
        Me._IMSS_ClickPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_ClickPanel.Location = New System.Drawing.Point(0, 196)
        Me._IMSS_ClickPanel.Name = "_IMSS_ClickPanel"
        Me._IMSS_ClickPanel.Size = New System.Drawing.Size(438, 41)
        Me._IMSS_ClickPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_ClickPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_ClickPanel.Style.BackColor2.Color = System.Drawing.Color.LightGray
        Me._IMSS_ClickPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_ClickPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_ClickPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me._IMSS_ClickPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_ClickPanel.Style.GradientAngle = 90
        Me._IMSS_ClickPanel.TabIndex = 1
        '
        '_IMSS_CURRENT_SCAN_PROCESS
        '
        Me._IMSS_CURRENT_SCAN_PROCESS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_CURRENT_SCAN_PROCESS.Location = New System.Drawing.Point(8, 10)
        Me._IMSS_CURRENT_SCAN_PROCESS.Name = "_IMSS_CURRENT_SCAN_PROCESS"
        Me._IMSS_CURRENT_SCAN_PROCESS.Size = New System.Drawing.Size(259, 23)
        Me._IMSS_CURRENT_SCAN_PROCESS.TabIndex = 2
        Me._IMSS_CURRENT_SCAN_PROCESS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_IMSS_SCAN
        '
        Me._IMSS_SCAN.Location = New System.Drawing.Point(354, 10)
        Me._IMSS_SCAN.Name = "_IMSS_SCAN"
        Me._IMSS_SCAN.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_SCAN.TabIndex = 0
        Me._IMSS_SCAN.Text = "&Scan"
        Me._IMSS_SCAN.UseVisualStyleBackColor = True
        '
        '_IMSS_Cancel
        '
        Me._IMSS_Cancel.Location = New System.Drawing.Point(273, 10)
        Me._IMSS_Cancel.Name = "_IMSS_Cancel"
        Me._IMSS_Cancel.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Cancel.TabIndex = 1
        Me._IMSS_Cancel.Text = "&Cancel"
        Me._IMSS_Cancel.UseVisualStyleBackColor = True
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me._IMSS_BrwoseButton)
        Me.GroupPanel1.Controls.Add(Me._IMSS_SelectedPath_TextBox)
        Me.GroupPanel1.Controls.Add(Me._IMSS_DriversListView)
        Me.GroupPanel1.Controls.Add(Me._IMSS_FoldersReadioButton)
        Me.GroupPanel1.Controls.Add(Me._IMSS_DriversReadioButton)
        Me.GroupPanel1.Location = New System.Drawing.Point(8, 9)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(423, 181)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        '
        '_IMSS_BrwoseButton
        '
        Me._IMSS_BrwoseButton.Enabled = False
        Me._IMSS_BrwoseButton.Location = New System.Drawing.Point(364, 138)
        Me._IMSS_BrwoseButton.Name = "_IMSS_BrwoseButton"
        Me._IMSS_BrwoseButton.Size = New System.Drawing.Size(31, 23)
        Me._IMSS_BrwoseButton.TabIndex = 4
        Me._IMSS_BrwoseButton.Text = "..."
        Me._IMSS_BrwoseButton.UseVisualStyleBackColor = True
        '
        '_IMSS_SelectedPath_TextBox
        '
        '
        '
        '
        Me._IMSS_SelectedPath_TextBox.Border.Class = "TextBoxBorder"
        Me._IMSS_SelectedPath_TextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_SelectedPath_TextBox.Enabled = False
        Me._IMSS_SelectedPath_TextBox.Location = New System.Drawing.Point(22, 138)
        Me._IMSS_SelectedPath_TextBox.Multiline = True
        Me._IMSS_SelectedPath_TextBox.Name = "_IMSS_SelectedPath_TextBox"
        Me._IMSS_SelectedPath_TextBox.Size = New System.Drawing.Size(335, 23)
        Me._IMSS_SelectedPath_TextBox.TabIndex = 3
        '
        '_IMSS_DriversListView
        '
        Me._IMSS_DriversListView.CheckBoxes = True
        Me._IMSS_DriversListView.Location = New System.Drawing.Point(22, 31)
        Me._IMSS_DriversListView.MultiSelect = False
        Me._IMSS_DriversListView.Name = "_IMSS_DriversListView"
        Me._IMSS_DriversListView.Size = New System.Drawing.Size(373, 76)
        Me._IMSS_DriversListView.TabIndex = 2
        Me._IMSS_DriversListView.UseCompatibleStateImageBehavior = False
        Me._IMSS_DriversListView.View = System.Windows.Forms.View.List
        '
        '_IMSS_FoldersReadioButton
        '
        Me._IMSS_FoldersReadioButton.AutoSize = True
        Me._IMSS_FoldersReadioButton.Location = New System.Drawing.Point(10, 113)
        Me._IMSS_FoldersReadioButton.Name = "_IMSS_FoldersReadioButton"
        Me._IMSS_FoldersReadioButton.Size = New System.Drawing.Size(65, 17)
        Me._IMSS_FoldersReadioButton.TabIndex = 1
        Me._IMSS_FoldersReadioButton.Text = "A Folder"
        Me._IMSS_FoldersReadioButton.UseVisualStyleBackColor = True
        '
        '_IMSS_DriversReadioButton
        '
        Me._IMSS_DriversReadioButton.AutoSize = True
        Me._IMSS_DriversReadioButton.Checked = True
        Me._IMSS_DriversReadioButton.Location = New System.Drawing.Point(7, 7)
        Me._IMSS_DriversReadioButton.Name = "_IMSS_DriversReadioButton"
        Me._IMSS_DriversReadioButton.Size = New System.Drawing.Size(260, 17)
        Me._IMSS_DriversReadioButton.TabIndex = 0
        Me._IMSS_DriversReadioButton.TabStop = True
        Me._IMSS_DriversReadioButton.Text = "Check the boxes of the drive(s) you wish to scan"
        Me._IMSS_DriversReadioButton.UseVisualStyleBackColor = True
        '
        '_IMSS_AddFolders
        '
        Me._IMSS_AddFolders.Description = "Please select a folder to search it for empty folders"
        '
        'IMSS_Scan_GUI
        '
        Me.AcceptButton = Me._IMSS_SCAN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 237)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(454, 275)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(454, 275)
        Me.Name = "IMSS_Scan_GUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scan for empty folders"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_ClickPanel.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents _IMSS_ClickPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_SCAN As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Cancel As System.Windows.Forms.Button
    Friend WithEvents _IMSS_DriversListView As System.Windows.Forms.ListView
    Friend WithEvents _IMSS_FoldersReadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents _IMSS_DriversReadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents _IMSS_BrwoseButton As System.Windows.Forms.Button
    Friend WithEvents _IMSS_SelectedPath_TextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents _IMSS_AddFolders As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents _IMSS_CURRENT_SCAN_PROCESS As System.Windows.Forms.Label
End Class
