Public Class IMSS_SCAN
    Public Shared Sub _IMSS_SCAN(ByVal _IMSS_PATH As String, ByRef _IMSS_TARGETLIST As List(Of String), ByRef _IMSS_LABEL As Label)
        If IO.Directory.Exists(_IMSS_PATH) = True Then
            For Each _IMSS_DIR In My.Computer.FileSystem.GetDirectories(_IMSS_PATH, FileIO.SearchOption.SearchTopLevelOnly)
                Try
                    Application.DoEvents()
                    _IMSS_LABEL.Text = _IMSS_DIR
                    If System.IO.Directory.GetFiles(_IMSS_DIR).Length = 0 Then
                        If System.IO.Directory.GetDirectories(_IMSS_DIR).Length = 0 Then
                            _IMSS_TARGETLIST.Add(_IMSS_DIR)
                        Else
                            _IMSS_SCAN(_IMSS_DIR, _IMSS_TARGETLIST, _IMSS_LABEL)
                        End If
                    End If
                Catch : End Try
            Next _IMSS_DIR
        End If
    End Sub
End Class
