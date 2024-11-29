Imports System.Drawing.Drawing2D
Imports System.Drawing

Namespace picture

    Public Class CirclePicture
        Inherits PictureBox

        Private borderRadiusValue As Integer = 100
        Private gradientAngleValue As Single = 90
        Private gradientTopColorValue As Color = Color.Green
        Private gradientBottomColorValue As Color = Color.Green

        Public Sub New()
            Me.BackColor = Color.White
            Me.ForeColor = Color.Black
            Me.Size = New Size(200, 200)
        End Sub

        Public Property BorderRadius As Integer
            Get
                Return borderRadiusValue
            End Get
            Set(value As Integer)
                borderRadiusValue = value
                Me.Invalidate()
            End Set
        End Property

        Public Property GradientAngle As Single
            Get
                Return gradientAngleValue
            End Get
            Set(value As Single)
                gradientAngleValue = value
                Me.Invalidate()
            End Set
        End Property

        Public Property GradientTopColor As Color
            Get
                Return gradientTopColorValue
            End Get
            Set(value As Color)
                gradientTopColorValue = value
                Me.Invalidate()
            End Set
        End Property

        Public Property GradientBottomColor As Color
            Get
                Return gradientBottomColorValue
            End Get
            Set(value As Color)
                gradientBottomColorValue = value
                Me.Invalidate()
            End Set
        End Property

        Private Function GetGeraldPath(rectangle As RectangleF, radius As Single) As GraphicsPath

            Dim graphicsPath As New GraphicsPath()
            graphicsPath.AddEllipse(rectangle) ' Create a circle
            Return graphicsPath
        End Function

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

            ' Fill with gradient
            Using brush As New LinearGradientBrush(Me.ClientRectangle, Me.GradientTopColor, Me.GradientBottomColor, Me.GradientAngle)
                e.Graphics.FillRectangle(brush, Me.ClientRectangle)
            End Using

            Dim rectangleF As New RectangleF(0, 0, Me.Width, Me.Height)
            If BorderRadius > 2 Then
                Using graphicsPath As GraphicsPath = GetGeraldPath(rectangleF, BorderRadius)
                    Using pen As New Pen(Me.Parent.BackColor, 0)
                        Me.Region = New Region(graphicsPath)
                        e.Graphics.DrawPath(pen, graphicsPath)
                    End Using
                End Using
            Else
                Me.Region = New Region(rectangleF)
            End If
        End Sub
    End Class

End Namespace