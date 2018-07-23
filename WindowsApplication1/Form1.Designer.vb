<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.web = New System.Windows.Forms.WebBrowser()
        Me.LgBox = New System.Windows.Forms.GroupBox()
        Me.loginInfo = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.pw = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LgBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'web
        '
        Me.web.Location = New System.Drawing.Point(389, 3)
        Me.web.MinimumSize = New System.Drawing.Size(20, 20)
        Me.web.Name = "web"
        Me.web.Size = New System.Drawing.Size(590, 428)
        Me.web.TabIndex = 17
        '
        'LgBox
        '
        Me.LgBox.Controls.Add(Me.loginInfo)
        Me.LgBox.Controls.Add(Me.RadioButton2)
        Me.LgBox.Controls.Add(Me.RadioButton1)
        Me.LgBox.Controls.Add(Me.pw)
        Me.LgBox.Controls.Add(Me.id)
        Me.LgBox.Controls.Add(Me.Button1)
        Me.LgBox.Location = New System.Drawing.Point(12, 299)
        Me.LgBox.Name = "LgBox"
        Me.LgBox.Size = New System.Drawing.Size(181, 118)
        Me.LgBox.TabIndex = 16
        Me.LgBox.TabStop = False
        '
        'loginInfo
        '
        Me.loginInfo.Location = New System.Drawing.Point(2, 92)
        Me.loginInfo.Name = "loginInfo"
        Me.loginInfo.Size = New System.Drawing.Size(173, 18)
        Me.loginInfo.TabIndex = 13
        Me.loginInfo.Text = "안녕하세요"
        Me.loginInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 17)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(83, 16)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "넥슨로그인"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(92, 17)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(83, 16)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.Text = "던파로그인"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'pw
        '
        Me.pw.Location = New System.Drawing.Point(6, 66)
        Me.pw.Name = "pw"
        Me.pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.pw.Size = New System.Drawing.Size(83, 21)
        Me.pw.TabIndex = 10
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(6, 40)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(83, 21)
        Me.id.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 48)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "로그인"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 100)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "게임시작"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 30000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 98)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "아이디 비밀번호 추가"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 17)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(83, 16)
        Me.RadioButton3.TabIndex = 12
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "넥슨로그인"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(92, 17)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(83, 16)
        Me.RadioButton4.TabIndex = 11
        Me.RadioButton4.Text = "던파로그인"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(98, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 48)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "추가"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(196, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(187, 208)
        Me.ListBox1.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(83, 21)
        Me.TextBox1.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(9, 66)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TextBox2.Size = New System.Drawing.Size(83, 21)
        Me.TextBox2.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 216)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.web)
        Me.Controls.Add(Me.LgBox)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "PC"
        Me.LgBox.ResumeLayout(False)
        Me.LgBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents web As WebBrowser
    Friend WithEvents LgBox As GroupBox
    Friend WithEvents loginInfo As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents pw As TextBox
    Friend WithEvents id As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Button3 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
