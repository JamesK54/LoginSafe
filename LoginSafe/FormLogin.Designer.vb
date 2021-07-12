<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBox_Names = New System.Windows.Forms.ListBox()
        Me.TextBox_URL = New System.Windows.Forms.TextBox()
        Me.TextBoxLogin = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblURL = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.TextBoxPassWrd = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.LblPasswd = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.RadioButton_Access = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Skip = New System.Windows.Forms.RadioButton()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.AccessButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox_Names
        '
        Me.ListBox_Names.AllowDrop = True
        Me.ListBox_Names.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox_Names.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox_Names.FormattingEnabled = True
        Me.ListBox_Names.HorizontalScrollbar = True
        Me.ListBox_Names.ItemHeight = 22
        Me.ListBox_Names.Location = New System.Drawing.Point(4, 5)
        Me.ListBox_Names.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox_Names.Name = "ListBox_Names"
        Me.TableLayoutPanel1.SetRowSpan(Me.ListBox_Names, 9)
        Me.ListBox_Names.Size = New System.Drawing.Size(303, 642)
        Me.ListBox_Names.TabIndex = 0
        Me.ListBox_Names.Visible = False
        '
        'TextBox_URL
        '
        Me.TextBox_URL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_URL.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.TextBox_URL.Location = New System.Drawing.Point(493, 242)
        Me.TextBox_URL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_URL.Name = "TextBox_URL"
        Me.TextBox_URL.Size = New System.Drawing.Size(393, 37)
        Me.TextBox_URL.TabIndex = 2
        Me.TextBox_URL.Visible = False
        '
        'TextBoxLogin
        '
        Me.TextBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxLogin.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.TextBoxLogin.Location = New System.Drawing.Point(493, 284)
        Me.TextBoxLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxLogin.Name = "TextBoxLogin"
        Me.TextBoxLogin.Size = New System.Drawing.Size(393, 37)
        Me.TextBoxLogin.TabIndex = 3
        Me.TextBoxLogin.Visible = False
        '
        'lblName
        '
        Me.lblName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(315, 195)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(170, 42)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblName.Visible = False
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblURL.Location = New System.Drawing.Point(315, 237)
        Me.lblURL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(170, 42)
        Me.lblURL.TabIndex = 6
        Me.lblURL.Text = "URL"
        Me.lblURL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblURL.UseWaitCursor = True
        Me.lblURL.Visible = False
        '
        'SaveButton
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.SaveButton, 2)
        Me.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SaveButton.FlatAppearance.BorderSize = 3
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(315, 368)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(571, 45)
        Me.SaveButton.TabIndex = 8
        Me.SaveButton.UseVisualStyleBackColor = True
        Me.SaveButton.Visible = False
        '
        'TextBoxPassWrd
        '
        Me.TextBoxPassWrd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPassWrd.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.TextBoxPassWrd.Location = New System.Drawing.Point(493, 326)
        Me.TextBoxPassWrd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxPassWrd.MaxLength = 40
        Me.TextBoxPassWrd.Name = "TextBoxPassWrd"
        Me.TextBoxPassWrd.Size = New System.Drawing.Size(393, 37)
        Me.TextBoxPassWrd.TabIndex = 4
        '
        'lblLogin
        '
        Me.lblLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(315, 279)
        Me.lblLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(170, 42)
        Me.lblLogin.TabIndex = 7
        Me.lblLogin.Text = "Login"
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLogin.UseWaitCursor = True
        Me.lblLogin.Visible = False
        '
        'LblPasswd
        '
        Me.LblPasswd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPasswd.AutoSize = True
        Me.LblPasswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPasswd.Location = New System.Drawing.Point(315, 321)
        Me.LblPasswd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPasswd.MinimumSize = New System.Drawing.Size(94, 0)
        Me.LblPasswd.Name = "LblPasswd"
        Me.LblPasswd.Size = New System.Drawing.Size(170, 42)
        Me.LblPasswd.TabIndex = 10
        Me.LblPasswd.Text = "Password"
        Me.LblPasswd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblPasswd.UseWaitCursor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.BackColor = System.Drawing.SystemColors.Window
        Me.lblPrompt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblPrompt, 2)
        Me.lblPrompt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.ForeColor = System.Drawing.Color.Transparent
        Me.lblPrompt.Location = New System.Drawing.Point(315, 153)
        Me.lblPrompt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(571, 42)
        Me.lblPrompt.TabIndex = 16
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrompt.Visible = False
        '
        'RadioButton_Access
        '
        Me.RadioButton_Access.AutoSize = True
        Me.RadioButton_Access.Checked = True
        Me.RadioButton_Access.Location = New System.Drawing.Point(152, 17)
        Me.RadioButton_Access.Name = "RadioButton_Access"
        Me.RadioButton_Access.Size = New System.Drawing.Size(105, 17)
        Me.RadioButton_Access.TabIndex = 28
        Me.RadioButton_Access.TabStop = True
        Me.RadioButton_Access.Text = "Access the page"
        Me.RadioButton_Access.UseVisualStyleBackColor = True
        '
        'RadioButton_Skip
        '
        Me.RadioButton_Skip.AutoSize = True
        Me.RadioButton_Skip.Location = New System.Drawing.Point(20, 17)
        Me.RadioButton_Skip.Name = "RadioButton_Skip"
        Me.RadioButton_Skip.Size = New System.Drawing.Size(102, 17)
        Me.RadioButton_Skip.TabIndex = 27
        Me.RadioButton_Skip.Text = "Skip the Access"
        Me.RadioButton_Skip.UseVisualStyleBackColor = True
        '
        'TextBoxName
        '
        Me.TextBoxName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(493, 200)
        Me.TextBoxName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(393, 32)
        Me.TextBoxName.TabIndex = 29
        Me.TextBoxName.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblInstruct, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox_Names, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPrompt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.SaveButton, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPassWrd, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.AccessButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxLogin, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_URL, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxName, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblPasswd, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLogin, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblURL, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblName, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(890, 652)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'lblInstruct
        '
        Me.lblInstruct.AutoSize = True
        Me.lblInstruct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInstruct.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblInstruct.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblInstruct.Location = New System.Drawing.Point(493, 418)
        Me.lblInstruct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(393, 234)
        Me.lblInstruct.TabIndex = 30
        '
        'AccessButton
        '
        Me.AccessButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccessButton.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.AccessButton, 2)
        Me.AccessButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.AccessButton.FlatAppearance.BorderSize = 3
        Me.AccessButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccessButton.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AccessButton.Location = New System.Drawing.Point(315, 5)
        Me.AccessButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AccessButton.Name = "AccessButton"
        Me.AccessButton.Size = New System.Drawing.Size(571, 45)
        Me.AccessButton.TabIndex = 29
        Me.AccessButton.Text = "Disable Automatic Access"
        Me.AccessButton.UseVisualStyleBackColor = True
        Me.AccessButton.Visible = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 652)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormLogin"
        Me.Text = "LoginSafe"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox_Names As ListBox
    Friend WithEvents TextBox_URL As TextBox
    Friend WithEvents TextBoxLogin As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblURL As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents TextBoxPassWrd As TextBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents LblPasswd As Label
    Friend WithEvents lblPrompt As Label
    Friend WithEvents RadioButton_Skip As RadioButton
    Friend WithEvents RadioButton_Access As RadioButton
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents AccessButton As Button
    Friend WithEvents lblInstruct As Label
End Class
