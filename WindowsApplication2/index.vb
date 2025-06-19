Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Public Class index
    Private imageList As New List(Of String) ' To store image file paths
    Private currentImageIndex As Integer ' To track the current image
    Private WithEvents backgroundTimer As New Timer ' Timer for changing background

    Private Sub index_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim connection = functions.connection
        Try
            connection.Open()
            If connection.State = ConnectionState.Open Then
                MessageBox.Show("Connection successful.", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As MySqlException
            MsgBox("Connection failed: " & ex.Message)
            Me.Close()
        Finally
            connection.Close()
        End Try


        ' Add images to the image list
        imageList.Add("C:\Users\Michael\Documents\Visual Studio 2010\Projects\AfooTECH_Attendance_Management_System\WindowsApplication2\bg-8.png")
        imageList.Add("C:\Users\Michael\Documents\Visual Studio 2010\Projects\AfooTECH_Attendance_Management_System\WindowsApplication2\bg-9.jpg")
        imageList.Add("C:\Users\Michael\Documents\Visual Studio 2010\Projects\AfooTECH_Attendance_Management_System\WindowsApplication2\bg-10.jpg")
        imageList.Add("C:\Users\Michael\Documents\Visual Studio 2010\Projects\AfooTECH_Attendance_Management_System\WindowsApplication2\bg-11.jpg")
        'imageList.Add("C:\Users\Michael\Documents\Visual Studio 2010\Projects\Candy_Bank_Of_Nigeria\WindowsApplication2\bg-5.jpg")
        'imageList.Add("C:\Users\Michael\Documents\Visual Studio 2010\Projects\Candy_Bank_Of_Nigeria\WindowsApplication2\Resources\bg-6.png")

        ' Set Timer Interval (e.g., every 7 seconds)
        backgroundTimer.Interval = 7000 ' 7000 ms = 7 seconds
        backgroundTimer.Start()

        ' Set the initial background
        SetBlurryBackground()
        main.Show()
    End Sub

    Private Sub SetBlurryBackground()
        Dim imagePath As String = imageList(currentImageIndex)
        If IO.File.Exists(imagePath) Then
            Dim originalImage As Image = Image.FromFile(imagePath)
            Dim blurredImage As Image = ApplyBlur(originalImage, 15) ' Increase blurAmount for more blur
            Dim finalImage As New Bitmap(blurredImage.Width, blurredImage.Height)

            Using g As Graphics = Graphics.FromImage(finalImage)
                ' Draw the blurred image
                g.DrawImage(blurredImage, New Rectangle(0, 0, blurredImage.Width, blurredImage.Height))

                ' Add a semi-transparent overlay
                Dim overlayColor As Color = Color.FromArgb(115, Color.Black) ' 128 for 50% transparency
                Using overlayBrush As New SolidBrush(overlayColor)
                    g.FillRectangle(overlayBrush, 0, 0, blurredImage.Width, blurredImage.Height)
                End Using
            End Using

            Me.BackgroundImage = finalImage
            Me.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub backgroundTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles backgroundTimer.Tick
        ' Increment the current image index
        currentImageIndex += 1

        ' Reset the index if it goes beyond the list count
        If currentImageIndex >= imageList.Count Then
            currentImageIndex = 0
        End If

        SetBlurryBackground()
    End Sub
    Private Sub index_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            ' Minimize the main form
            If main IsNot Nothing Then
                main.WindowState = FormWindowState.Minimized
            End If
        ElseIf Me.WindowState = FormWindowState.Normal Then
            ' Restore the main form
            If main IsNot Nothing Then
                main.WindowState = FormWindowState.Normal
            End If
        End If
    End Sub


End Class
