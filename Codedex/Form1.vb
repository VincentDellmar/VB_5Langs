Public Class Form1
    Private Sub RustB_Click(sender As Object, e As EventArgs) Handles RustB.Click
        LangName.Text = "Language: Rust"
    End Sub
    Private Sub LuaB_Click(sender As Object, e As EventArgs) Handles LuaB.Click
        LangName.Text = "Language: Lua"
    End Sub
    Private Sub CB_Click(sender As Object, e As EventArgs) Handles CB.Click
        LangName.Text = "Language: C"
    End Sub
    Private Sub JavaScriptB_Click(sender As Object, e As EventArgs) Handles JavaScriptB.Click
        LangName.Text = "Language: JavaScript"
    End Sub
    Private Sub FortranB_Click(sender As Object, e As EventArgs) Handles FortranB.Click
        LangName.Text = "Language: Fortran"
    End Sub
End Class
