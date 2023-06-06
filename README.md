# Visual-Basic-.NET-DisplayImage
Visual Basic语言显示路径图片
Imports System.Drawing：导入System.Drawing命名空间，其中包含了Image类，用于处理图像。
Imports System.Windows.Forms：导入System.Windows.Forms命名空间，其中包含了Form类，用于创建窗体应用程序。
Public Class Form1 Inherits Form：定义一个名为Form1的公共类，它继承自Form类，表示窗体应用程序的主窗体。
Private pictureBox As PictureBox：声明一个私有的名为pictureBox的PictureBox对象，用于显示图像。
Public Sub New()：定义Form1类的构造函数，用于初始化窗体和pictureBox对象。
pictureBox = New PictureBox()：实例化pictureBox对象。
pictureBox.SizeMode = PictureBoxSizeMode.StretchImage：设置pictureBox的SizeMode属性为StrechImage，这样可以自动调整图像的大小以适应pictureBox的大小。
pictureBox.Dock = DockStyle.Fill：设置pictureBox的Dock属性为Fill，使其填充整个窗体。
Controls.Add(pictureBox)：将pictureBox添加到窗体的控件集合中。
Public Sub DisplayImage(ByVal imagePath As String)：定义一个公共的名为DisplayImage的方法，用于显示指定路径的图像。
Dim image As Image = Image.FromFile(imagePath)：使用指定路径的图像文件创建一个Image对象，并将其赋值给image变量。
pictureBox.Image = image：将image赋值给pictureBox的Image属性，从而显示图像。
Public Shared Sub Main()：定义程序的入口点。
Application.Run(New Form1())：创建Form1对象并运行应用程序的消息循环。
