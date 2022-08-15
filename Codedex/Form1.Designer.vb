<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ProgramIcon = New System.Windows.Forms.PictureBox()
        Me.LangName = New System.Windows.Forms.Label()
        Me.LangYear = New System.Windows.Forms.Label()
        Me.RustB = New System.Windows.Forms.Button()
        Me.CB = New System.Windows.Forms.Button()
        Me.FortranB = New System.Windows.Forms.Button()
        Me.LuaB = New System.Windows.Forms.Button()
        Me.JavaScriptB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ProgramIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgramIcon
        '
        Me.ProgramIcon.Image = CType(resources.GetObject("ProgramIcon.Image"), System.Drawing.Image)
        Me.ProgramIcon.Location = New System.Drawing.Point(0, 0)
        Me.ProgramIcon.Name = "ProgramIcon"
        Me.ProgramIcon.Size = New System.Drawing.Size(256, 256)
        Me.ProgramIcon.TabIndex = 0
        Me.ProgramIcon.TabStop = False
        '
        'LangName
        '
        Me.LangName.AutoSize = True
        Me.LangName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LangName.Location = New System.Drawing.Point(262, 9)
        Me.LangName.Name = "LangName"
        Me.LangName.Size = New System.Drawing.Size(297, 32)
        Me.LangName.TabIndex = 1
        Me.LangName.Text = "Language Name: Rust"
        '
        'LangYear
        '
        Me.LangYear.AutoSize = True
        Me.LangYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LangYear.Location = New System.Drawing.Point(262, 52)
        Me.LangYear.Name = "LangYear"
        Me.LangYear.Size = New System.Drawing.Size(153, 32)
        Me.LangYear.TabIndex = 2
        Me.LangYear.Text = "Year: 2010"
        '
        'RustB
        '
        Me.RustB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RustB.Location = New System.Drawing.Point(0, 262)
        Me.RustB.Name = "RustB"
        Me.RustB.Size = New System.Drawing.Size(122, 35)
        Me.RustB.TabIndex = 3
        Me.RustB.Text = "Rust"
        Me.RustB.UseVisualStyleBackColor = True
        '
        'CB
        '
        Me.CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB.Location = New System.Drawing.Point(134, 262)
        Me.CB.Name = "CB"
        Me.CB.Size = New System.Drawing.Size(122, 35)
        Me.CB.TabIndex = 4
        Me.CB.Text = "C"
        Me.CB.UseVisualStyleBackColor = True
        '
        'FortranB
        '
        Me.FortranB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FortranB.Location = New System.Drawing.Point(134, 303)
        Me.FortranB.Name = "FortranB"
        Me.FortranB.Size = New System.Drawing.Size(122, 35)
        Me.FortranB.TabIndex = 6
        Me.FortranB.Text = "Fortran"
        Me.FortranB.UseVisualStyleBackColor = True
        '
        'LuaB
        '
        Me.LuaB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LuaB.Location = New System.Drawing.Point(0, 303)
        Me.LuaB.Name = "LuaB"
        Me.LuaB.Size = New System.Drawing.Size(122, 35)
        Me.LuaB.TabIndex = 5
        Me.LuaB.Text = "Lua"
        Me.LuaB.UseVisualStyleBackColor = True
        '
        'JavaScriptB
        '
        Me.JavaScriptB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JavaScriptB.Location = New System.Drawing.Point(69, 344)
        Me.JavaScriptB.Name = "JavaScriptB"
        Me.JavaScriptB.Size = New System.Drawing.Size(122, 35)
        Me.JavaScriptB.TabIndex = 7
        Me.JavaScriptB.Text = "JavaScript"
        Me.JavaScriptB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(484, 100)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Description: Rust is a modern systems programming " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "language focusing on safety, " &
    "speed, and concurrency. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It accomplishes these goals by being memory safe " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "wit" &
    "hout using garbage collection."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.JavaScriptB)
        Me.Controls.Add(Me.FortranB)
        Me.Controls.Add(Me.LuaB)
        Me.Controls.Add(Me.CB)
        Me.Controls.Add(Me.RustB)
        Me.Controls.Add(Me.LangYear)
        Me.Controls.Add(Me.LangName)
        Me.Controls.Add(Me.ProgramIcon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ProgramIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents ProgramIcon As PictureBox
    Public WithEvents LangName As Label
    Public WithEvents LangYear As Label
    Public WithEvents RustB As Button
    Public WithEvents CB As Button
    Public WithEvents FortranB As Button
    Public WithEvents LuaB As Button
    Public WithEvents JavaScriptB As Button
    Public WithEvents Label1 As Label
End Class
