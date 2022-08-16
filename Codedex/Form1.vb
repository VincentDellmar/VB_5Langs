Public Class Form1
    Private Sub RustB_Click(sender As Object, e As EventArgs) Handles RustB.Click
        LangName.Text = "Language: Rust"
        LangIcon.Image = Image.FromFile("C:\Users\vwdel826\Documents\CODE\repo\SY22-23\VB\Codedex\Codedex\RustLang.png")
        LangYear.Text = "Year: 2010"
        LangDesc.Text = "Description: Rust is a modern systems programming 
language focusing on safety, speed, and concurrency. 
It accomplishes these goals by being memory safe 
without using garbage collection."
        LangCreator.Text = "Creator: Graydon Hoare"
    End Sub
    Private Sub LuaB_Click(sender As Object, e As EventArgs) Handles LuaB.Click
        LangName.Text = "Language: Lua"
        LangIcon.Image = Image.FromFile("C:\Users\vwdel826\Documents\CODE\repo\SY22-23\VB\Codedex\Codedex\LuaLang.png")
        LangYear.Text = "Year: 1993"
        LangDesc.Text = "Description: Lua is a robust, lightweight, and 
embeddable scripting language that supports multiple 
programming methods, including procedural, 
object-oriented, functional, and data-driven 
programming.
"
        LangCreator.Text = "Creator: Roberto Ierusalimschy"
    End Sub
    Private Sub CB_Click(sender As Object, e As EventArgs) Handles CB.Click
        LangName.Text = "Language: C"
        LangIcon.Image = Image.FromFile("C:\Users\vwdel826\Documents\CODE\repo\SY22-23\VB\Codedex\Codedex\CLang.png")
        LangYear.Text = "Year: 1972"
        LangDesc.Text = "Description: C is an imperative procedural language 
supporting structured programming, lexical variable 
scope, and recursion, with a static type system. 
It was designed to be compiled to provide low-level 
access to memory and language constructs that map 
efficiently to machine instructions, all with minimal 
runtime support."
        LangCreator.Text = "Creator: Dennis Ritchie"
    End Sub
    Private Sub JavaScriptB_Click(sender As Object, e As EventArgs) Handles JavaScriptB.Click
        LangName.Text = "Language: JavaScript"
        LangIcon.Image = Image.FromFile("C:\Users\vwdel826\Documents\CODE\repo\SY22-23\VB\Codedex\Codedex\JavaScriptLang.png")
        LangYear.Text = "Year: 1995"
        LangDesc.Text = "Description: JavaScript is a dynamic computer 
programming language. It is lightweight and most 
commonly used as a part of web pages, whose 
implementations allow client-side script to interact 
with the user and make dynamic pages. It is an 
interpreted programming language with 
object-oriented capabilities."
        LangCreator.Text = "Creator: Brendan Eich"
    End Sub
    Private Sub FortranB_Click(sender As Object, e As EventArgs) Handles FortranB.Click
        LangName.Text = "Language: Fortran"
        LangIcon.Image = Image.FromFile("C:\Users\vwdel826\Documents\CODE\repo\SY22-23\VB\Codedex\Codedex\FortranLang.png")
        LangYear.Text = "Year: 1957"
        LangDesc.Text = "Description: FORTRAN, in full Formula Translation, 
computer programming language created in 1957 by 
John Backus that shortened the process of 
programming and made computer programming 
more accessible."
        LangCreator.Text = "Creator: John Backus"
    End Sub
End Class
