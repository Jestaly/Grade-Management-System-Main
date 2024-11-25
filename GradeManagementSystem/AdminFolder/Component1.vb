Imports System.Drawing.Drawing2D
Imports System.Drawing

Namespace gerald

    Public Class Gerald
        Inherits Button

        Private borderRadiusValue As Integer = 60
        Private gradientAngleValue As Single = 90
        Private gradientTopColorValue As Color = Color.Green
        Private gradientBottomColorValue As Color = Color.Green

        Public Sub New()
            Me.BackColor = Color.White
            Me.ForeColor = Color.Black
            Me.Size = New Size(350, 200)
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
            graphicsPath.StartFigure()
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90)
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90)
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90)
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90)
            graphicsPath.CloseFigure()
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