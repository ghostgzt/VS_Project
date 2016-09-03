Imports System.Windows.Forms
Public Class Add
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If TextBox1.Text.Trim <> "" And TextBox2.Text.Trim <> "" Then
            If fs = False Then
                Settings.ListView1.Items.Add(TextBox1.Text)
                Settings.ListView1.Items.Item(Settings.ListView1.Items.Count - 1).SubItems.Add(TextBox2.Text.Trim)
                Settings.ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                Settings.ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
            Else
                Settings.ListView1.SelectedItems(0).SubItems(0).Text = TextBox1.Text.Trim
                Settings.ListView1.SelectedItems(0).SubItems(1).Text = TextBox2.Text.Trim
            End If
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
        End If
    End Sub
    Dim fs As Boolean = False
    Function aoe(ByVal sf As Boolean)
        On Error Resume Next
        fs = sf
    End Function
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class