Public Class MainWindow

    Private Sub MainWindow_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        _IMSS_CurrentProcess_label.Text = "Status : Ready"
        _IMSS_SCAN_CLICK_LOAD()
    End Sub

    Private Sub _IMSS_Scan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Scan.Click
        _IMSS_CurrentProcess_label.Text = "Status : Ready"
        _IMSS_SCAN_CLICK_LOAD()
    End Sub

    Private Sub _IMSS_SCAN_CLICK_LOAD()
        Dim _IMSS_LocalArray As New List(Of String)
        Dim _IMSS_ScanGUI As New IMSS_Scan_GUI(_IMSS_LocalArray)
        _IMSS_ScanGUI.ShowDialog()
        _IMSS_Resulit_ListView.Items.Clear()
        _IMSS_Resulit_ListView.CheckBoxes = ComponentOwl.BetterListView.BetterListViewCheckBoxes.TwoState
        If Not _IMSS_LocalArray.Count() = 0 Then
            For Each _IMSS_ITEM As String In _IMSS_LocalArray
                _IMSS_Resulit_ListView.BeginUpdate()
                With _IMSS_Resulit_ListView.Items.Add(IO.Path.GetFileName(_IMSS_ITEM))
                    .Checked = True
                    .Image = My.Resources._IMSS_FoldersMini_icon_16X16
                    .SubItems.Add(_IMSS_ITEM)
                End With
                _IMSS_Resulit_ListView.EndUpdate()
            Next _IMSS_ITEM
            _IMSS_SetupTotalItemsFound()
            _IMSS_FoundFoldersStatus_Label.Visible = False
        Else
            _IMSS_FoundFoldersStatus_Label.Visible = True
            _IMSS_CurrentProcess_label.Text = "Status : Ready"
        End If
    End Sub
    Private Sub _IMSS_SetupTotalItemsFound()
        _IMSS_CurrentProcess_label.Text = "Total Founds (Empty Folders)  : " & CType(_IMSS_Resulit_ListView.Items.Count(), String) & " Folder(s)"
    End Sub

    Private Sub _IMSS_OpenFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_OpenFolder.Click
        Try
            If _IMSS_Resulit_ListView.SelectedItems.Count > 0 Then
                If _IMSS_Resulit_ListView.SelectedItems(0).Checked = True Then
                    Process.Start(_IMSS_Resulit_ListView.SelectedItems(0).SubItems(1).Text)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while opening (" & _IMSS_Resulit_ListView.SelectedItems(0).SubItems(1).Text & ") :- " & Environment.NewLine & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub _IMSS_DeleteSelectedFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_DeleteSelectedFolder.Click
        Try
            For Each _IMSS_ITEM In _IMSS_Resulit_ListView.Items
                If _IMSS_ITEM.Checked = True Then
                    If IO.Directory.Exists(_IMSS_ITEM.SubItems(1).Text) Then
                        Try : IO.Directory.Delete(_IMSS_ITEM.SubItems(1).Text) : _IMSS_ITEM.Image = My.Resources._IMSS_StatusOn_Icon_16x16 : Catch : _IMSS_ITEM.Image = My.Resources._IMSS_StatusOff_Icon_16x16 : End Try
                    End If
                End If
            Next _IMSS_ITEM
            _IMSS_Resulit_ListView.CheckBoxes = ComponentOwl.BetterListView.BetterListViewCheckBoxes.Hide
        Catch ex As Exception
            MessageBox.Show("Error while deleting (" & _IMSS_Resulit_ListView.SelectedItems(0).SubItems(1).Text & ") :- " & Environment.NewLine & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
End Class
