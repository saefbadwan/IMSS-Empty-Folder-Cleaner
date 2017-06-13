<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_FoundFoldersStatus_Label = New System.Windows.Forms.Label()
        Me._IMSS_Resulit_ListView = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_FolderName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_FolderPath = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.Bar2 = New DevComponents.DotNetBar.Bar()
        Me._IMSS_CurrentProcess_label = New DevComponents.DotNetBar.LabelItem()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me._IMSS_Scan = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_DeleteSelectedFolder = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_OpenFolder = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_ScanButton = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_MainPanel.SuspendLayout()
        CType(Me._IMSS_Resulit_ListView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_FoundFoldersStatus_Label)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Resulit_ListView)
        Me._IMSS_MainPanel.Controls.Add(Me.Bar2)
        Me._IMSS_MainPanel.Controls.Add(Me.Bar1)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(863, 537)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 0
        '
        '_IMSS_FoundFoldersStatus_Label
        '
        Me._IMSS_FoundFoldersStatus_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me._IMSS_FoundFoldersStatus_Label.AutoSize = True
        Me._IMSS_FoundFoldersStatus_Label.BackColor = System.Drawing.Color.White
        Me._IMSS_FoundFoldersStatus_Label.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_FoundFoldersStatus_Label.ForeColor = System.Drawing.Color.Gray
        Me._IMSS_FoundFoldersStatus_Label.Location = New System.Drawing.Point(255, 260)
        Me._IMSS_FoundFoldersStatus_Label.Name = "_IMSS_FoundFoldersStatus_Label"
        Me._IMSS_FoundFoldersStatus_Label.Size = New System.Drawing.Size(353, 16)
        Me._IMSS_FoundFoldersStatus_Label.TabIndex = 3
        Me._IMSS_FoundFoldersStatus_Label.Text = "There is no (Empty Folder\s) found, in the given search path"
        '
        '_IMSS_Resulit_ListView
        '
        Me._IMSS_Resulit_ListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Resulit_ListView.CheckBoxes = ComponentOwl.BetterListView.BetterListViewCheckBoxes.TwoState
        Me._IMSS_Resulit_ListView.Columns.AddRange(New Object() {Me._IMSS_FolderName, Me._IMSS_FolderPath})
        Me._IMSS_Resulit_ListView.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Resulit_ListView.Location = New System.Drawing.Point(3, 39)
        Me._IMSS_Resulit_ListView.Name = "_IMSS_Resulit_ListView"
        Me._IMSS_Resulit_ListView.Size = New System.Drawing.Size(857, 476)
        Me._IMSS_Resulit_ListView.TabIndex = 2
        '
        '_IMSS_FolderName
        '
        Me._IMSS_FolderName.Name = "_IMSS_FolderName"
        Me._IMSS_FolderName.Text = "Folder Name"
        Me._IMSS_FolderName.Width = 185
        '
        '_IMSS_FolderPath
        '
        Me._IMSS_FolderPath.Name = "_IMSS_FolderPath"
        Me._IMSS_FolderPath.Text = "Folder Path"
        Me._IMSS_FolderPath.Width = 668
        '
        'Bar2
        '
        Me.Bar2.AccessibleDescription = "Bar2 (Bar2)"
        Me.Bar2.AccessibleName = "Bar2"
        Me.Bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar2.AntiAlias = True
        Me.Bar2.BarType = DevComponents.DotNetBar.eBarType.StatusBar
        Me.Bar2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bar2.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.Bar2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Bar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_CurrentProcess_label})
        Me.Bar2.Location = New System.Drawing.Point(0, 521)
        Me.Bar2.Name = "Bar2"
        Me.Bar2.Size = New System.Drawing.Size(863, 16)
        Me.Bar2.Stretch = True
        Me.Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar2.TabIndex = 1
        Me.Bar2.TabStop = False
        Me.Bar2.Text = "Bar2"
        '
        '_IMSS_CurrentProcess_label
        '
        Me._IMSS_CurrentProcess_label.Name = "_IMSS_CurrentProcess_label"
        Me._IMSS_CurrentProcess_label.Text = "Status : Ready"
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "Bar1 (Bar1)"
        Me.Bar1.AccessibleName = "Bar1"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar1.AntiAlias = True
        Me.Bar1.BarType = DevComponents.DotNetBar.eBarType.MenuBar
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.Bar1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_Scan, Me._IMSS_DeleteSelectedFolder, Me._IMSS_OpenFolder})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(863, 33)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 0
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        '_IMSS_Scan
        '
        Me._IMSS_Scan.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_Scan.Image = Global.Empty_Folder_Cleaner.My.Resources.Resources._IMSS_SCAN_SELECTED_Icon_24x24
        Me._IMSS_Scan.Name = "_IMSS_Scan"
        Me._IMSS_Scan.Text = "Scan for Empty Folders"
        '
        '_IMSS_DeleteSelectedFolder
        '
        Me._IMSS_DeleteSelectedFolder.BeginGroup = True
        Me._IMSS_DeleteSelectedFolder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_DeleteSelectedFolder.Image = Global.Empty_Folder_Cleaner.My.Resources.Resources._IMSS_X_Icon_24x24
        Me._IMSS_DeleteSelectedFolder.Name = "_IMSS_DeleteSelectedFolder"
        Me._IMSS_DeleteSelectedFolder.Text = "Delete Checked Folders"
        '
        '_IMSS_OpenFolder
        '
        Me._IMSS_OpenFolder.BeginGroup = True
        Me._IMSS_OpenFolder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_OpenFolder.Image = Global.Empty_Folder_Cleaner.My.Resources.Resources._IMSS_ShowSelectedItems_Icon_24x24
        Me._IMSS_OpenFolder.Name = "_IMSS_OpenFolder"
        Me._IMSS_OpenFolder.Text = "Viw Folder"
        '
        '_IMSS_ScanButton
        '
        Me._IMSS_ScanButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_ScanButton.Image = CType(resources.GetObject("_IMSS_ScanButton.Image"), System.Drawing.Image)
        Me._IMSS_ScanButton.Name = "_IMSS_ScanButton"
        Me._IMSS_ScanButton.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1})
        Me._IMSS_ScanButton.Text = "Scan for Empty Folders"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Image = CType(resources.GetObject("ButtonItem1.Image"), System.Drawing.Image)
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Scan for Empty Folders"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 537)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMSS Empty Folder Cleaner"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        CType(Me._IMSS_Resulit_ListView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents Bar2 As DevComponents.DotNetBar.Bar
    Friend WithEvents _IMSS_CurrentProcess_label As DevComponents.DotNetBar.LabelItem
    Friend WithEvents _IMSS_DeleteSelectedFolder As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_OpenFolder As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_ScanButton As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_Scan As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_Resulit_ListView As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_FolderName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_FolderPath As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_FoundFoldersStatus_Label As System.Windows.Forms.Label

End Class
