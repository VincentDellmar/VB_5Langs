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
        Me.LangIcon = New System.Windows.Forms.PictureBox()
        Me.LangName = New System.Windows.Forms.Label()
        Me.LangYear = New System.Windows.Forms.Label()
        Me.RustB = New System.Windows.Forms.Button()
        Me.CB = New System.Windows.Forms.Button()
        Me.FortranB = New System.Windows.Forms.Button()
        Me.LuaB = New System.Windows.Forms.Button()
        Me.JavaScriptB = New System.Windows.Forms.Button()
        Me.LangDesc = New System.Windows.Forms.Label()
        Me.LangCreator = New System.Windows.Forms.Label()
        CType(Me.LangIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LangIcon
        '
        Me.LangIcon.Image = CType(resources.GetObject("LangIcon.Image"), System.Drawing.Image)
        Me.LangIcon.Location = New System.Drawing.Point(0, 0)
        Me.LangIcon.Name = "LangIcon"
        Me.LangIcon.Size = New System.Drawing.Size(256, 256)
        Me.LangIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LangIcon.TabIndex = 0
        Me.LangIcon.TabStop = False
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
        Me.LangYear.Location = New System.Drawing.Point(262, 73)
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
        'LangDesc
        '
        Me.LangDesc.AutoSize = True
        Me.LangDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LangDesc.Location = New System.Drawing.Point(262, 114)
        Me.LangDesc.Name = "LangDesc"
        Me.LangDesc.Size = New System.Drawing.Size(484, 100)
        Me.LangDesc.TabIndex = 8
        Me.LangDesc.Text = "Description: Rust is a modern systems programming " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "language focusing on safety, " &
    "speed, and concurrency. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It accomplishes these goals by being memory safe " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "wit" &
    "hout using garbage collection."
        '
        'LangCreator
        '
        Me.LangCreator.AutoSize = True
        Me.LangCreator.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LangCreator.Location = New System.Drawing.Point(262, 41)
        Me.LangCreator.Name = "LangCreator"
        Me.LangCreator.Size = New System.Drawing.Size(162, 32)
        Me.LangCreator.TabIndex = 9
        Me.LangCreator.Text = "Creator: Lol"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LangCreator)
        Me.Controls.Add(Me.LangDesc)
        Me.Controls.Add(Me.JavaScriptB)
        Me.Controls.Add(Me.FortranB)
        Me.Controls.Add(Me.LuaB)
        Me.Controls.Add(Me.CB)
        Me.Controls.Add(Me.RustB)
        Me.Controls.Add(Me.LangYear)
        Me.Controls.Add(Me.LangName)
        Me.Controls.Add(Me.LangIcon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LangIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents LangIcon As PictureBox
    Public WithEvents LangName As Label
    Public WithEvents LangYear As Label
    Public WithEvents RustB As Button
    Public WithEvents CB As Button
    Public WithEvents FortranB As Button
    Public WithEvents LuaB As Button
    Public WithEvents JavaScriptB As Button
    Public WithEvents LangDesc As Label
    Public WithEvents LangCreator As Label
End Class
