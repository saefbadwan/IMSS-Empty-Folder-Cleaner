Imports System.IO

Public Class IMSS_Scan_GUI
    Dim _IMSS_LocalArray As List(Of String)
    Public Sub New(ByRef _IMSS_ListArray As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _IMSS_LocalArray = _IMSS_ListArray

        _IMSS_LoadDrivestoListView()

    End Sub

    Private Sub _IMSS_LoadDrivestoListView()
        _IMSS_DriversListView.Items.Clear()
        Dim _IMSS_BACKGROUND_COLOR As Short = 0
        For Each _IMSS_Drive As System.IO.DriveInfo In IO.DriveInfo.GetDrives
            If Not _IMSS_Drive.DriveType = DriveType.CDRom Then
                If _IMSS_Drive.IsReady = True Then
                    With _IMSS_DriversListView.Items.Add(_IMSS_Drive.Name & "                                                                                                                    ")
                        .Checked = True
                        If _IMSS_BACKGROUND_COLOR = 0 Then
                            .BackColor = Color.LightSkyBlue
                            _IMSS_BACKGROUND_COLOR = 1
                        Else
                            .BackColor = Color.White
                            _IMSS_BACKGROUND_COLOR = 0
                        End If
                    End With
                End If
            End If
        Next _IMSS_Drive
        If _IMSS_DriversListView.Items.Count = 0 Then _IMSS_SCAN.Enabled = False
    End Sub

    Private Sub _IMSS_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel.Click
        Me.Close()
    End Sub

    Private Sub _IMSS_DriversReadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_DriversReadioButton.CheckedChanged
        _IMSS_DriversListView.Enabled = True

        _IMSS_SelectedPath_TextBox.Enabled = False
        _IMSS_BrwoseButton.Enabled = False
    End Sub

    Private Sub _IMSS_FoldersReadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_FoldersReadioButton.CheckedChanged
        _IMSS_DriversListView.Enabled = False

        _IMSS_SelectedPath_TextBox.Enabled = True
        _IMSS_BrwoseButton.Enabled = True

        If _IMSS_SelectedPath_TextBox.Text.Length = 0 Then _IMSS_SCAN.Enabled = False
    End Sub

    Private Sub _IMSS_SelectedPath_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SelectedPath_TextBox.TextChanged
        If _IMSS_SelectedPath_TextBox.Text.Length = 0 Then
            _IMSS_SCAN.Enabled = False
        Else
            If IO.Directory.Exists(_IMSS_SelectedPath_TextBox.Text) = True Then
                _IMSS_SCAN.Enabled = True
            End If
        End If
    End Sub

    Private Sub _IMSS_DriversListView_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles _IMSS_DriversListView.ItemChecked
        Dim _IMSS_ITEMS_CheckValue As Boolean = False
        For _IMSS_ITEMS_INCURMINT As Integer = 0 To _IMSS_DriversListView.Items.Count - 1 Step 1
            If _IMSS_DriversListView.Items(_IMSS_ITEMS_INCURMINT).Checked = True Then
                _IMSS_ITEMS_CheckValue = True
            End If
        Next _IMSS_ITEMS_INCURMINT
        If Not _IMSS_ITEMS_CheckValue = True Then _IMSS_SCAN.Enabled = False Else _IMSS_SCAN.Enabled = True
    End Sub

    Private Sub _IMSS_BrwoseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_BrwoseButton.Click
        If (_IMSS_AddFolders.ShowDialog() = Windows.Forms.DialogResult.OK) = True Then
            _IMSS_SelectedPath_TextBox.Text = _IMSS_AddFolders.SelectedPath
        End If
    End Sub

    Private Sub _IMSS_SCAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SCAN.Click
        If _IMSS_DriversReadioButton.Checked = True Then
            For _IMSS_ITEMS_INCURMINT As Integer = 0 To _IMSS_DriversListView.Items.Count - 1 Step 1
                If _IMSS_DriversListView.Items(_IMSS_ITEMS_INCURMINT).Checked = True Then
                    IMSS_SCAN._IMSS_SCAN(_IMSS_DriversListView.Items(_IMSS_ITEMS_INCURMINT).Text, _IMSS_LocalArray, _IMSS_CURRENT_SCAN_PROCESS)
                End If
            Next _IMSS_ITEMS_INCURMINT
        Else
            If IO.Directory.Exists(_IMSS_SelectedPath_TextBox.Text) = True Then
                IMSS_SCAN._IMSS_SCAN(_IMSS_SelectedPath_TextBox.Text, _IMSS_LocalArray, _IMSS_CURRENT_SCAN_PROCESS)
            End If
        End If
        Me.Close()
    End Sub
End Class