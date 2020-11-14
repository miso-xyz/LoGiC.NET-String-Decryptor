Public Class Form1

    Private Sub RichTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox2.TextChanged
        Dim a_ As String = RichTextBox2.Text
        Try
            Dim array As Char() = "*$,;:!ù^*&é\"" '(-è_çà)".ToCharArray()
            For Each c As Char In array
                a_ = a_.Replace(c.ToString(), String.Empty)
            Next
            RichTextBox1.Text = System.Text.Encoding.UTF32.GetString(Convert.FromBase64String(a_))
            RichTextBox3.Text = BitConverter.ToString(System.Text.Encoding.UTF32.GetBytes(System.Text.Encoding.UTF32.GetString(Convert.FromBase64String(a_)))).Replace("-", " ").Replace("00 00 00", Nothing)
        Catch ex As Exception
            RichTextBox1.Text = "Input is invalid!"
            RichTextBox3.Text = Nothing
            'Throw
        End Try
        RichTextBox4.Text = a_
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        RichTextBox4.Visible = CheckBox3.Checked
        If CheckBox2.Checked AndAlso CheckBox3.Checked Then
            SplitContainer1.Panel2Collapsed = True
        Else
            SplitContainer1.Panel2Collapsed = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        RichTextBox1.Visible = CheckBox2.Checked
        If CheckBox2.Checked Then
            RichTextBox4.Dock = DockStyle.Fill
        Else
            RichTextBox4.Dock = DockStyle.Bottom
        End If
        If CheckBox2.Checked AndAlso CheckBox3.Checked Then
            SplitContainer1.Panel2Collapsed = True
        Else
            SplitContainer1.Panel2Collapsed = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            SplitContainer2.Panel2Collapsed = True
        Else
            SplitContainer2.Panel2Collapsed = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        TopMost = CheckBox4.Checked
    End Sub

    Private Sub Form1_HelpButtonClicked(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        ContextMenu1.Show(Me, New Point(Size.Width - 90, 0))
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Process.Start("https://github.com/AnErrupTion/LoGiC.NET")
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Process.Start("https://github.com/miso-xyz/LoGiC.NET-String-Decryptor")
    End Sub
End Class
