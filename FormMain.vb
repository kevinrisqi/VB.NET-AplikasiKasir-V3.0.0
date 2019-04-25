Public Class FormMain

    Private Sub tabExit_Click(sender As Object, e As EventArgs) Handles tabExit.Click
        If MsgBox("Apakah Anda yakin keluar ?", vbInformation + vbYesNo) = vbYes Then
            Me.Dispose()
        End If
    End Sub
End Class