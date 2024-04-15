Imports System.Runtime.InteropServices

Public Class Internetplusplus
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Tab 1
        If WebView21.CoreWebView2.DocumentTitle = Nothing Then
            TabPage1.Text = "Tab 1"
        Else
            TabPage1.Text = WebView21.CoreWebView2.DocumentTitle
            If TabPage1.Text = "News about Sebs SW and new projects" Then
                TabPage1.Text = "News.."
            End If
        End If
        'Tab 2
        If WebView22.CoreWebView2.DocumentTitle = Nothing Then
            TabPage2.Text = "Tab 2"
        Else
            TabPage2.Text = WebView22.CoreWebView2.DocumentTitle
            If TabPage2.Text = "News about Sebs SW and new projects" Then
                TabPage2.Text = "News.."
            End If
        End If
        'Tab 3
        If WebView23.CoreWebView2.DocumentTitle = Nothing Then
            TabPage3.Text = "Tab 3"
        Else
            TabPage3.Text = WebView23.CoreWebView2.DocumentTitle
            If TabPage3.Text = "News about Sebs SW and new projects" Then
                TabPage3.Text = "News.."
            End If
        End If
        'Tab 4
        If WebView24.CoreWebView2.DocumentTitle = Nothing Then
            TabPage4.Text = "Tab 4"
        Else
            TabPage4.Text = WebView24.CoreWebView2.DocumentTitle
            If TabPage4.Text = "News about Sebs SW and new projects" Then
                TabPage4.Text = "News.."
            End If
        End If
        'Tab 5
        If WebView25.CoreWebView2.DocumentTitle = Nothing Then
            TabPage5.Text = "Tab 5"
        Else
            TabPage5.Text = WebView25.CoreWebView2.DocumentTitle
            If TabPage5.Text = "News about Sebs SW and new projects" Then
                TabPage5.Text = "News.."
            End If
        End If
        'Tab 6
        If WebView26.CoreWebView2.DocumentTitle = Nothing Then
            TabPage6.Text = "Tab 6"
        Else
            TabPage6.Text = WebView26.CoreWebView2.DocumentTitle
            If TabPage6.Text = "News about Sebs SW and new projects" Then
                TabPage6.Text = "News.."
            End If
        End If

        'TabPage1.Text = WebView21.CoreWebView2.DocumentTitle
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebView21.GoBack()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebView21.GoForward()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebView21.Refresh()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub MaxiButton_Click(sender As Object, e As EventArgs) Handles MaxiButton.Click
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub MiniButton_Click(sender As Object, e As EventArgs) Handles MiniButton.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
        Else
            If TextBox1.Text = "cmd" Then
                UI.StartCMD("New")
                'CMD STRING'
            Else
                If TextBox1.Text.Contains("https://") = True Then
                    WebView21.Source = New Uri(TextBox1.Text)
                Else
                    WebView21.Source = New Uri("https://" & TextBox1.Text)
                End If
            End If
        End If
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub Internetplusplus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.internet_world_wide_web_www_globe_communication_website_browser_network_connection_icon_1957101
        If My.Application.Info.ProductName = "Sebs SW CV" Then
            Panel1.Visible = True
            loadweb("1")
            FormBorderStyle = FormBorderStyle.None
        ElseIf My.Application.Info.ProductName = "Internet++" Then
            FormBorderStyle = FormBorderStyle.Sizable
            Panel1.Visible = False
            loadweb("1")
        Else
            MsgBox("Have you changed the Product Name?", MsgBoxStyle.Information)
            Close()
        End If
        Panel1.Visible = True
        FormBorderStyle = FormBorderStyle.None
    End Sub

    Public Sub loadweb(ss As String)
        If ss = "0" Then
        Else
            'Tab 1
            Dim _1_ As Boolean = My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\load1.tabsetting")
            'Tab 2
            Dim _2_ As Boolean = My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\load2.tabsetting")
            'Tab 3
            Dim _3_ As Boolean = My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\load3.tabsetting")
            'Tab 4
            Dim _4_ As Boolean = My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\load4.tabsetting")
            'Tab 5
            Dim _5_ As Boolean = My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\load5.tabsetting")
            'Tab 6
            Dim _6_ As Boolean = My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\load6.tabsetting")
            'if files exists
            If _1_ Then
                Dim ToWeb = TextBox1.Text
                ToWeb = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\load1.tabsetting")
                Try
                    WebView21.Source = New Uri("https://" + ToWeb)
                Catch ex As Exception

                End Try
            End If
            If _2_ Then
                Dim ToWeb = TextBox2.Text
                ToWeb = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\load2.tabsetting")
                Try
                    WebView22.Source = New Uri("https://" + ToWeb)
                Catch ex As Exception

                End Try
            End If
            If _3_ Then
                Dim ToWeb = TextBox3.Text
                ToWeb = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\load3.tabsetting")
                Try
                    WebView23.Source = New Uri("https://" + ToWeb)
                Catch ex As Exception

                End Try
            End If
            If _4_ Then
                Dim ToWeb = TextBox4.Text
                ToWeb = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\load4.tabsetting")
                Try
                    WebView24.Source = New Uri("https://" + ToWeb)
                Catch ex As Exception

                End Try
            End If
            If _5_ Then
                Dim ToWeb = TextBox5.Text
                ToWeb = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\load5.tabsetting")
                Try
                    WebView25.Source = New Uri("https://" + ToWeb)
                Catch ex As Exception

                End Try
            End If
            If _6_ Then
                Dim ToWeb = TextBox6.Text
                ToWeb = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\load6.tabsetting")
                Try
                    WebView26.Source = New Uri("https://" + ToWeb)
                Catch ex As Exception

                End Try
            End If
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        WebView22.GoBack()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebView22.GoForward()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebView22.Refresh()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox2.Text = "" Then
        Else
            If TextBox2.Text = "cmd" Then
                UI.StartCMD("New")
                'CMD STRING'
            Else
                If TextBox2.Text.Contains("https://") = True Then
                    WebView22.Source = New Uri(TextBox2.Text)
                Else
                    WebView22.Source = New Uri("https://" & TextBox2.Text)
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text = "" Then
            Else
                If TextBox1.Text = "cmd" Then
                    UI.StartCMD("New")
                    'CMD STRING'
                Else
                    If TextBox1.Text.Contains("https://") = True Then
                        WebView21.Source = New Uri(TextBox1.Text)
                    Else
                        WebView21.Source = New Uri("https://" & TextBox1.Text)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox2.Text = "" Then
            Else
                If TextBox2.Text = "cmd" Then
                    UI.StartCMD("New")
                    'CMD STRING'
                Else
                    If TextBox2.Text.Contains("https://") = True Then
                        WebView22.Source = New Uri(TextBox2.Text)
                    Else
                        WebView22.Source = New Uri("https://" & TextBox2.Text)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        WebView23.GoBack()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        WebView23.GoForward()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        WebView23.Refresh()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox3.Text = "" Then
        Else
            If TextBox3.Text = "cmd" Then
                UI.StartCMD("New")
                'CMD STRING'
            Else
                If TextBox3.Text.Contains("https://") = True Then
                    WebView23.Source = New Uri(TextBox3.Text)
                Else
                    WebView23.Source = New Uri("https://" & TextBox3.Text)
                End If
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox3.Text = "" Then
            Else
                If TextBox3.Text = "cmd" Then
                    UI.StartCMD("New")
                    'CMD STRING'
                Else
                    If TextBox3.Text.Contains("https://") = True Then
                        WebView23.Source = New Uri(TextBox3.Text)
                    Else
                        WebView23.Source = New Uri("https://" & TextBox3.Text)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        WebView24.GoBack()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        WebView24.GoForward()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        WebView24.Refresh()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox4.Text = "" Then
        Else
            If TextBox4.Text = "cmd" Then
                UI.StartCMD("New")
                'CMD STRING'
            Else
                If TextBox4.Text.Contains("https://") = True Then
                    WebView24.Source = New Uri(TextBox4.Text)
                Else
                    WebView24.Source = New Uri("https://" & TextBox4.Text)
                End If
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox4.Text = "" Then
            Else
                If TextBox4.Text = "cmd" Then
                    UI.StartCMD("New")
                    'CMD STRING'
                Else
                    If TextBox4.Text.Contains("https://") = True Then
                        WebView24.Source = New Uri(TextBox4.Text)
                    Else
                        WebView24.Source = New Uri("https://" & TextBox4.Text)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        WebView25.GoBack()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        WebView25.GoForward()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        WebView25.Refresh()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If TextBox5.Text = "" Then
        Else
            If TextBox5.Text = "cmd" Then
                UI.StartCMD("New")
                'CMD STRING'
            Else
                If TextBox5.Text.Contains("https://") = True Then
                    WebView25.Source = New Uri(TextBox5.Text)
                Else
                    WebView25.Source = New Uri("https://" & TextBox5.Text)
                End If
            End If
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox5.Text = "" Then
            Else
                If TextBox5.Text = "cmd" Then
                    UI.StartCMD("New")
                    'CMD STRING'
                Else
                    If TextBox5.Text.Contains("https://") = True Then
                        WebView25.Source = New Uri(TextBox5.Text)
                    Else
                        WebView25.Source = New Uri("https://" & TextBox5.Text)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        WebView26.GoBack()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        WebView26.GoForward()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        WebView26.Refresh()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If TextBox6.Text = "" Then
        Else
            If TextBox6.Text = "cmd" Then
                UI.StartCMD("New")
                'CMD STRING'
            Else
                If TextBox6.Text.Contains("https://") = True Then
                    WebView26.Source = New Uri(TextBox6.Text)
                Else
                    WebView26.Source = New Uri("https://" & TextBox6.Text)
                End If
            End If
        End If
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox6.Text = "" Then
            Else
                If TextBox6.Text = "cmd" Then
                    UI.StartCMD("New")
                    'CMD STRING'
                Else
                    If TextBox6.Text.Contains("https://") = True Then
                        WebView26.Source = New Uri(TextBox6.Text)
                    Else
                        WebView26.Source = New Uri("https://" & TextBox6.Text)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Internetplusplus_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F11 Then
            load_at_start.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        load_at_start.Show()
    End Sub

    Private Sub WebView21_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView21.NavigationCompleted
        TextBox1.Text = WebView21.Source.AbsoluteUri
    End Sub

    Private Sub WebView22_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView22.NavigationCompleted
        TextBox2.Text = WebView22.Source.AbsoluteUri
    End Sub

    Private Sub WebView23_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView23.NavigationCompleted
        TextBox3.Text = WebView23.Source.AbsoluteUri
    End Sub

    Private Sub WebView24_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView24.NavigationCompleted
        TextBox4.Text = WebView24.Source.AbsoluteUri
    End Sub

    Private Sub WebView25_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView25.NavigationCompleted
        TextBox5.Text = WebView25.Source.AbsoluteUri
    End Sub

    Private Sub WebView26_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView26.NavigationCompleted
        TextBox6.Text = WebView26.Source.AbsoluteUri
    End Sub
End Class
