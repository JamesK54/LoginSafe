Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.IO
Imports System.ComponentModel

Public Class FormLogin

    Private wrapper As Simple3Des
    Private TabRegEx As New Regex(vbTab)
    Private PItems(), ReadFile(), part() As String
    Private SelectIndex As Integer
    Private KeyPathName As String = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory, "test.txt")
    Private TextFilePathName As String = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory, "cipherText.txt")
    ''' <summary>
    ''' True if decription worked using the entered password
    ''' </summary>
    Private Loggedin As Boolean
    Private edited, Skip, controlBypass As Boolean
    Private response = ""
    Private prmptTxt = "Click a list item "
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
        Dim automatic = vbTrue
        Dim fileReader As String
        Try
            fileReader = My.Computer.FileSystem.ReadAllText(KeyPathName)
        Catch
            automatic = vbFalse
        End Try
        wrapper = New Simple3Des(fileReader)
        FindAll()
        ListBox_Names.Select()
    End Sub


    Private Sub Form1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            If ListBox_Names.SelectedIndex > 0 Then ListBox_Names.SelectedIndex -= 1
        Else
            If (ListBox_Names.Items.Count - 1) > ListBox_Names.SelectedIndex Then ListBox_Names.SelectedIndex += 1
        End If
    End Sub

    Sub FindAll()
        Dim n = 0
        Dim part() As String
        If File.Exists(TextFilePathName) = True Then
            ReadFile = System.IO.File.ReadAllLines(TextFilePathName)
            ReDim PItems(ReadFile.Count - 1)
            ListBox_Names.Items.Clear()
            Do
                If ReadFile(n).Length > 0 Then
                    Try
                        PItems(n) = wrapper.DecryptData(ReadFile(n))
                        part = TabRegEx.Split(PItems(n))
                        PItems(n) &= vbTab & n.ToString
                        n += 1
                    Catch ex As System.Security.Cryptography.CryptographicException
                        MsgBox("The data could not be decrypted with the password.")
                        System.Environment.Exit(0)
                    End Try
                End If
            Loop While n < ReadFile.Count
            Array.Sort(PItems)
            Dim first = 0
            Dim current = 1
            For Each s As String In PItems
                part = TabRegEx.Split(s)
                ListBox_Names.Items.Add(part(0))
                current += 1
            Next
            If ListBox_Names.Items.Count > 0 Then
                ListBox_Names.Visible = True
                lblPrompt.Visible = True
                AccessButton.Visible = True
                lblInstruct.Text = "Mouse wheel or arrow key to scroll. Click or Enter to select."
            End If
            lblName.Visible = True
            lblURL.Visible = False
            lblLogin.Visible = False
            LblPasswd.Visible = False
            TextBoxName.Visible = False
            TextBoxLogin.Visible = False
            'TextBoxPassWrd.Select()
            ListBox_Names.SelectedIndex = 0
            ListBox_Names.Select()
            TextBoxPassWrd.Visible = False
            TextBox_URL.Visible = False
            lblPrompt.Text = prmptTxt
            LblPasswd.Visible = False
            'LblPasswd.Text = "or hit a letter key"
        Else
            MsgBox("File: " & TextFilePathName & " not found.")
            Environment.Exit(0)
        End If
    End Sub

    ''' <summary>
    ''' Add, delete or modifies an entry
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>


    Private Sub ListBox_Names_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListBox_Names.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then ListBox_Names_SelectedIndexChanged()
    End Sub
    Private Sub ListBox_Names_Click() Handles ListBox_Names.Click
        ListBox_Names_SelectedIndexChanged()
    End Sub

    Private Sub ListBox_Names_DoubleClick(sender As Object, e As EventArgs) Handles ListBox_Names.DoubleClick
        ListBox_Names_SelectedIndexChanged()
    End Sub
    Private Sub ListBox_Names_SelectedIndexChanged()
        part = TabRegEx.Split(PItems(ListBox_Names.SelectedIndex))
        ClearAll()
        TextBoxName.Text = part(0)
        TextBox_URL.Text = part(1)
        TextBoxLogin.Text = part(2)
        TextBoxPassWrd.Text = part(3)
        SelectIndex = part(4)
        If Not Clip("password") Then
            If Not Clip("login") Then
                Clip("URL")
            End If
        End If
        If part(1) <> "" And Not Skip Then
            Try
                System.Diagnostics.Process.Start(part(1))
            Catch
            End Try
        End If
        lblInstruct.Text = "Password is in the clipboard. Paste into login form then copy user name if needed"
        lblName.Visible = True
        lblURL.Visible = True
        lblLogin.Visible = True
        LblPasswd.Visible = True
        LblPasswd.Text = "Password"
        TextBoxLogin.Visible = True
        TextBoxPassWrd.Visible = True
        TextBoxName.Visible = True
        TextBox_URL.Visible = True
    End Sub



    Private Sub ClearAll()
        TextBoxName.Text = ""
        TextBox_URL.Text = ""
        TextBoxLogin.Text = ""
        TextBoxPassWrd.Text = ""
        SelectIndex = -1
        edited = False
    End Sub



    ''' <summary>
    ''' puts the named data into the clipboard
    ''' </summary>
    ''' <param name="ch"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Clip(ByVal ch As String) As Boolean
        If ch = "URL" AndAlso TextBox_URL.Text.Length > 0 Then
            Clipboard.SetDataObject(TextBox_URL.Text, False)
            lblPrompt.Text = "URL is in the clipboard"
            Return True
        ElseIf ch = "login" AndAlso TextBoxLogin.Text.Length > 0 Then
            Clipboard.SetDataObject(TextBoxLogin.Text, False)
            lblPrompt.Text = "Login is in the clipboard"
            Return True
        ElseIf ch = "password" AndAlso TextBoxPassWrd.Text.Length > 0 Then
            Clipboard.SetDataObject(TextBoxPassWrd.Text, False)
            lblPrompt.Text = "Password is in the clipboard"
            Return True
        Else
            Return False
        End If
    End Function



    Private Sub AccessButton_Click() Handles AccessButton.Click
        If AccessButton.Text = "Disable Automatic Access" Then
            Skip = True
            AccessButton.Text = "Enable Automatic Access"
        Else
            Skip = False
            AccessButton.Text = "Disable Automatic Access"
        End If
    End Sub



End Class

Public NotInheritable Class Simple3Des
    Private TripleDes As New TripleDESCryptoServiceProvider
    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key.
        Dim keyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function
    Sub New(ByVal key As String)
        ' Initialize the crypto provider.
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    End Sub

    Public Function DecryptData(
    ByVal encryptedtext As String) As String

        ' Convert the encrypted text string to a byte array.
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the decoder to write to the stream.
        Dim decStream As New CryptoStream(ms,
            TripleDes.CreateDecryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        ' Convert the plaintext stream to a string.
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function
End Class
