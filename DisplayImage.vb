Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Private pictureBox As PictureBox

    Public Sub New()
        pictureBox = New PictureBox()
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox.Dock = DockStyle.Fill
        Controls.Add(pictureBox)
    End Sub

    Public Sub DisplayImage(ByVal imagePath As String)
        Dim image As Image = Image.FromFile(imagePath)
        pictureBox.Image = image
    End Sub

    Public Shared Sub Main()
        Application.Run(New Form1())
    End Sub

End Class

