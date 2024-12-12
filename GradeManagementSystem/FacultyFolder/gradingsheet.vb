Imports MySql.Data.MySqlClient

Public Class GradingSheet
    Private connector As New DatabaseConnector
    Private addItemForm As New AddItemForm
    Private term As String = "Midterm"
    Private deleteItemForm As New DeleteItemForm

    'REFRESH STUDENT INFORMATION TABLE--------------------------------
    Private isRefreshed As Boolean = False
    Public Sub refreshForm()
        Try
            connector.connect.Open()
            connector.dataTable.Clear()
            connector.query = "SELECT enrollment.student_id AS 'Student ID', CONCAT(student.lname,' ',student.fname,' ',student.lname) AS 'Student' from enrollment LEFT JOIN student ON enrollment.student_id = student.id  WHERE enrollment.class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            studentInfoDataView.DataSource = connector.dataTable
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("Database Error refresh form")
        End Try
    End Sub

    Private classCode As String = classID

    'PROJECT SETTINGS--------------------------------
    Private Sub refreshProjCol()
        Dim colCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS 'Number of Project' FROM item WHERE item_type = 'Project' AND class_id = '" & classChooseBox.Text & "' AND term = '" & term & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                colCount = Integer.Parse(connector.reader("Number of Project").ToString)
            End While

            For j As Integer = 0 To colCount
                If (projectDataView.Columns.Count > 0) Then
                    projectDataView.Columns.RemoveAt(0)
                End If
            Next
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error refreshProjCol()")
        End Try
        getProjColumnsDB()
    End Sub

    Private Sub getProjColumnsDB()
        Try
            connector.connect.Open()
            connector.query = "SELECT item_name FROM item WHERE item_type = 'Project' AND class_id = '" & classID & "' AND term = '" & term & "' ORDER BY item_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                projectDataView.Columns.Add(connector.reader("item_name").ToString, connector.reader("item_name").ToString)
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            MessageBox.Show("Database Error getProjColumnsDB()")
            connector.reader.Close()
            connector.connect.Close()
        End Try
    End Sub

    Private Sub refreshProjRows()
        Dim studentCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS 'Number of Student' FROM enrollment WHERE class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("Number of Student").ToString.Equals("")) Then
                    studentCount = Integer.Parse(connector.reader("Number of Student").ToString)
                End If
            End While
            projectDataView.Rows.Clear()
            For i As Integer = 1 To studentCount
                projectDataView.Rows.Add()
            Next
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error refreshProjRows()")
        End Try
    End Sub

    Private Sub refreshProjScores()
        isRefreshed = True
        Dim numOfColumn As Integer = projectDataView.ColumnCount
        Dim numOfRow As Integer = projectDataView.RowCount
        Dim projItem(projectDataView.ColumnCount) As String
        Try
            connector.connect.Open()
            connector.query = "SELECT item_name FROM item WHERE item_type = 'Project' AND class_id = '" & classID & "' AND term = '" & term & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            Dim i As Integer = 0
            While connector.reader.Read
                projItem(i) = connector.reader("item_name").ToString
                i += 1
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error refreshProjScores()")
        End Try
        placeProjScores(numOfColumn, projItem)
    End Sub

    Private Sub placeProjScores(numOfColumn As Integer, projItem() As String)
        Try
            connector.connect.Open()
            For i As Integer = 0 To numOfColumn
                connector.query = "SELECT score FROM score_record LEFT JOIN item ON score_record.item_id = item.item_id WHERE item_name = '" & projItem(i) & "' AND class_id = '" & classID & "' AND term = '" & term & "' ORDER BY enrollment_id;"
                connector.command.Connection = connector.connect
                connector.command.CommandText = connector.query
                connector.reader = connector.command.ExecuteReader
                Dim j As Integer = 0
                While connector.reader.Read
                    projectDataView.Rows(j).Cells(i).Value = connector.reader("score").ToString
                    j += 1
                End While
                connector.reader.Close()
            Next
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            connector.reader.Close()
            MessageBox.Show("Database Error placeProjScores()")
        End Try
    End Sub
    Private Sub projectDataView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles projectDataView.CellValueChanged
        If (isRefreshed = False) Then
            Dim rowIndex As Integer = e.RowIndex
            Dim columnIndex As Integer = e.ColumnIndex
            If rowIndex >= 0 And columnIndex >= 0 Then
                setProjectScore(rowIndex, columnIndex)
            End If
            mainRefresh()
        End If
    End Sub

    Private Function getProjectScore(rowIndex As Integer, columnIndex As Integer) As Integer
        Dim newValue As Integer = Integer.Parse(projectDataView.Rows(rowIndex).Cells(columnIndex).Value.ToString)
        Return newValue
    End Function

    Private Function getProjectItemID(columnIndex As Integer) As String
        Dim columnName As String = projectDataView.Columns(columnIndex).Name
        MessageBox.Show(columnName)
        Try
            connector.connect.Open()
            connector.query = "SELECT item_id FROM item WHERE item_name = '" & columnName & "' AND term = '" & term & "' AND class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("item_id").ToString.Equals("")) Then
                    Dim itemID As String = connector.reader("item_id").ToString
                    connector.connect.Close()
                    connector.reader.Close()
                    Return itemID
                End If
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error getProjectItemID")
        End Try
        Return Nothing
    End Function

    Private Sub setProjectScore(rowIndex As Integer, columnIndex As Integer)
        Dim projectScore As Integer = getProjectScore(rowIndex, columnIndex)
        Dim enrollmentID As String = getEnrollmentID(rowIndex)
        Dim itemID As String = getProjectItemID(columnIndex)
        Try
            connector.connect.Open()
            connector.query = "UPDATE score_record SET score = '" & projectScore & "' WHERE enrollment_id = '" & enrollmentID & "' AND item_id = '" & itemID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error setProjectScore")
        End Try
    End Sub

    'QUIZ SETTINGS--------------------------------
    Private Sub refreshQuizCol()
        Dim colCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS 'Number of Quiz' FROM item WHERE item_type = 'Quiz' AND class_id = '" & classChooseBox.Text & "' AND term = '" & term & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                colCount = Integer.Parse(connector.reader("Number of Quiz").ToString)
            End While
            For j As Integer = 0 To colCount
                If (quizDataView.Columns.Count > 0) Then
                    quizDataView.Columns.RemoveAt(0)
                End If
            Next
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error refreshQuizCol()")
        End Try
        getQuizColumnsDB()
    End Sub

    Private Sub getQuizColumnsDB()
        Try
            connector.connect.Open()
            connector.query = "SELECT item_name FROM item WHERE item_type = 'Quiz' AND class_id = '" & classID & "' AND term = '" & term & "' ORDER BY item_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                quizDataView.Columns.Add(connector.reader("item_name").ToString, connector.reader("item_name").ToString)
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            MessageBox.Show("Database Error getQuizColumnsDB()")
            connector.reader.Close()
            connector.connect.Close()
        End Try
    End Sub

    Private Sub refreshQuizRows()
        Dim studentCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS 'Number of Student' FROM enrollment WHERE class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("Number of Student").ToString.Equals("")) Then
                    studentCount = Integer.Parse(connector.reader("Number of Student").ToString)
                End If
            End While
            quizDataView.Rows.Clear()
            For i As Integer = 1 To studentCount
                quizDataView.Rows.Add()
            Next
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error refreshQuizRows()")
        End Try
    End Sub

    Private Sub refreshQuizScores()
        isRefreshed = True
        Dim numOfColumn As Integer = quizDataView.ColumnCount
        Dim numOfRow As Integer = quizDataView.RowCount
        Dim quizItem(quizDataView.ColumnCount) As String
        Try
            connector.connect.Open()
            connector.query = "SELECT item_name FROM item WHERE item_type = 'Quiz' AND class_id = '" & classID & "' AND term = '" & term & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            Dim i As Integer = 0
            While connector.reader.Read
                quizItem(i) = connector.reader("item_name").ToString
                i += 1
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error refreshQuizScores()")
        End Try
        placeQuizScores(numOfColumn, quizItem)
    End Sub

    Private Sub placeQuizScores(numOfColumn As Integer, quizItem() As String)
        Try
            connector.connect.Open()
            For i As Integer = 0 To numOfColumn
                connector.query = "SELECT score FROM score_record LEFT JOIN item ON score_record.item_id = item.item_id WHERE item_name = '" & quizItem(i) & "' AND class_id = '" & classID & "' AND term = '" & term & "' ORDER BY enrollment_id;"
                connector.command.CommandText = connector.query
                connector.reader = connector.command.ExecuteReader
                Dim j As Integer = 0
                While connector.reader.Read
                    quizDataView.Rows(j).Cells(i).Value = connector.reader("score").ToString
                    j += 1
                End While
                connector.reader.Close()
            Next
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            connector.reader.Close()
            MessageBox.Show("Database Error placeQuizScores()")
        End Try
    End Sub

    Private Sub quizDataView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles quizDataView.CellValueChanged
        If (isRefreshed = False) Then
            Dim rowIndex As Integer = e.RowIndex
            Dim columnIndex As Integer = e.ColumnIndex
            If rowIndex >= 0 And columnIndex >= 0 Then
                setQuizScore(rowIndex, columnIndex)
            End If
            mainRefresh()
        End If
    End Sub

    Private Function getQuizScore(rowIndex As Integer, columnIndex As Integer) As Integer
        Dim newValue As Integer = Integer.Parse(quizDataView.Rows(rowIndex).Cells(columnIndex).Value.ToString)
        Return newValue
    End Function

    Private Function getQuizItemID(columnIndex As Integer) As String
        Dim columnName As String = quizDataView.Columns(columnIndex).Name
        MessageBox.Show(columnName)
        Try
            connector.connect.Open()
            connector.query = "SELECT item_id FROM item WHERE item_name = '" & columnName & "' AND term = '" & term & "' AND class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("item_id").ToString.Equals("")) Then
                    Dim itemID As String = connector.reader("item_id").ToString
                    connector.connect.Close()
                    connector.reader.Close()
                    Return itemID
                End If
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error getQuizItemID")
        End Try
        Return Nothing
    End Function

    Private Sub setQuizScore(rowIndex As Integer, columnIndex As Integer)
        Dim quizScore As Integer = getQuizScore(rowIndex, columnIndex)
        Dim enrollmentID As String = getEnrollmentID(rowIndex)
        Dim itemID As String = getQuizItemID(columnIndex)

        Try
            connector.connect.Open()
            connector.query = "UPDATE score_record SET score = '" & quizScore & "' WHERE enrollment_id = '" & enrollmentID & "' AND item_id = '" & itemID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error setQuizScore")
        End Try
    End Sub

    'ATTENDANCE SETTINGS--------------------------------
    Private Sub refreshAttRows()
        Dim studentCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS 'Number of Student' FROM enrollment WHERE class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("Number of Student").ToString.Equals("")) Then
                    studentCount = Integer.Parse(connector.reader("Number of Student").ToString)
                End If
            End While
            attendanceDataView.Rows.Clear()
            For i As Integer = 1 To studentCount
                attendanceDataView.Rows.Add()
            Next
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error refreshAttRows()")
        End Try
    End Sub

    'EXAM SETTINGS--------------------------------
    Private Sub refreshExamRows()
        Dim studentCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS 'Number of Student' FROM enrollment WHERE class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("Number of Student").ToString.Equals("")) Then
                    studentCount = Integer.Parse(connector.reader("Number of Student").ToString)
                End If
            End While
            examDataView.Rows.Clear()
            For i As Integer = 1 To studentCount
                examDataView.Rows.Add()
            Next
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error refreshExamRows()")
        End Try
    End Sub

    'GRADE SETTINGS--------------------------------
    Private Sub refreshGradeRows()
        Dim studentCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS 'Number of Student' FROM enrollment WHERE class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("Number of Student").ToString.Equals("")) Then
                    studentCount = Integer.Parse(connector.reader("Number of Student").ToString)
                End If
            End While
            gradeDataView.Rows.Clear()
            For i As Integer = 1 To studentCount
                gradeDataView.Rows.Add()
            Next
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error refreshAttRows()")
        End Try
    End Sub

    'EQUIVALENT SETTINGS--------------------------------
    Private Sub refreshEquivalentRows()
        Dim studentCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS 'Number of Student' FROM enrollment WHERE class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("Number of Student").ToString.Equals("")) Then
                    studentCount = Integer.Parse(connector.reader("Number of Student").ToString)
                End If
            End While
            equivalentDataView.Rows.Clear()
            For i As Integer = 1 To studentCount
                equivalentDataView.Rows.Add()
            Next
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error refreshAttRows()")
        End Try
    End Sub

    'REMARK SETTINGS--------------------------------
    Private Sub refreshRemarkRows()
        Dim studentCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS 'Number of Student' FROM enrollment WHERE class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("Number of Student").ToString.Equals("")) Then
                    studentCount = Integer.Parse(connector.reader("Number of Student").ToString)
                End If
            End While
            remarkDataView.Rows.Clear()
            For i As Integer = 1 To studentCount
                remarkDataView.Rows.Add()
            Next
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error refreshAttRows()")
        End Try
    End Sub

    'OVERALL SETTINGS--------------------------------
    Public Sub mainRefresh()
        refreshForm()
        refreshProjCol()
        refreshProjRows()
        refreshProjScores()
        refreshQuizCol()
        refreshQuizRows()
        refreshQuizScores()
        refreshAttRows()
        refreshExamRows()
        refreshGradeRows()
        refreshEquivalentRows()
        refreshRemarkRows()
        isRefreshed = False
    End Sub

    Private Function getEnrollmentID(rowIndex As Integer) As String
        Dim studentID As String = studentInfoDataView.Rows(rowIndex).Cells(0).Value.ToString()
        Try
            connector.connect.Open()
            connector.query = "SELECT enrollment_id FROM enrollment WHERE student_id = '" & studentID & "' AND class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("enrollment_id").ToString.Equals("")) Then
                    Dim enrollmentID As String = connector.reader("enrollment_id").ToString
                    connector.connect.Close()
                    connector.reader.Close()
                    Return enrollmentID
                End If
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error getEnrollmentID")
        End Try
        Return Nothing
    End Function

    Public classID As String
    Private Sub loadData(selectedClass As String)
        classID = selectedClass
        Try
            connector.connect.Open()
            connector.query = "SELECT CONCAT(professor.fname,' ',professor.mname,' ',professor.lname) AS Professor, course.course_name AS Course, course.course_id AS 'Course code', CONCAT(DATE_FORMAT(time_start, '%H:%i'), time_history.start_abbreviation,'-',DATE_FORMAT(time_end,'%H:%i'),time_history.end_abbreviation) AS 'Time Period', day AS 'Day' FROM class  LEFT JOIN professor ON class.professor_id = professor.id LEFT JOIN course ON class.course_id = course.course_id LEFT JOIN time_history ON class.class_id = time_history.class_id WHERE class.class_id = '" & classChooseBox.Text & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                courseTextBox.Text = connector.reader("Course").ToString
                timeTextBox.Text = connector.reader("Time Period").ToString
                dayTextBox.Text = connector.reader("Day").ToString
                courseCodeTextBox.Text = connector.reader("Course code").ToString
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub classChooseBox_SelectedItemChanged(sender As Object, e As EventArgs) Handles classChooseBox.SelectedIndexChanged
        '--------------CAUTION ON RUNNING CODE HERE----------------
        'MIGHT INTERCHANGE ALL DATA IN GRADING TABLES FROM DATABASE
        Dim selectedClass As String = classChooseBox.Text
        loadData(selectedClass)
        mainRefresh()
    End Sub

    Private Sub addItemButton_Click(sender As Object, e As EventArgs) Handles addItemButton.Click
        addItemForm.Visible = True
    End Sub

    Private Sub initializeDVS()
        'PROFESSOR CANNOT ADD ROWS
        projectDataView.AllowUserToAddRows = False
        studentInfoDataView.AllowUserToAddRows = False
        attendanceDataView.AllowUserToAddRows = False
        quizDataView.AllowUserToAddRows = False
        examDataView.AllowUserToAddRows = False
        gradeDataView.AllowUserToAddRows = False
        equivalentDataView.AllowUserToAddRows = False
        remarkDataView.AllowUserToAddRows = False

        'PROFESSOR CANNOT DELETE ROWS
        projectDataView.AllowUserToDeleteRows = False
        studentInfoDataView.AllowUserToDeleteRows = False
        attendanceDataView.AllowUserToDeleteRows = False
        quizDataView.AllowUserToDeleteRows = False
        examDataView.AllowUserToDeleteRows = False
        gradeDataView.AllowUserToDeleteRows = False
        equivalentDataView.AllowUserToDeleteRows = False
        remarkDataView.AllowUserToDeleteRows = False

        'PROFESSOR CANNOT ORDER COLUMNS BY ID AND NAMES
        projectDataView.AllowUserToOrderColumns = False
        studentInfoDataView.AllowUserToOrderColumns = False
        attendanceDataView.AllowUserToOrderColumns = False
        quizDataView.AllowUserToOrderColumns = False
        examDataView.AllowUserToOrderColumns = False
        gradeDataView.AllowUserToOrderColumns = False
        equivalentDataView.AllowUserToOrderColumns = False
        remarkDataView.AllowUserToOrderColumns = False

        'PROFESSOR CANNOT RESIZE COLUMNS
        projectDataView.AllowUserToResizeColumns = False
        studentInfoDataView.AllowUserToResizeColumns = False
        attendanceDataView.AllowUserToResizeColumns = False
        quizDataView.AllowUserToResizeColumns = False
        examDataView.AllowUserToResizeColumns = False
        gradeDataView.AllowUserToResizeColumns = False
        equivalentDataView.AllowUserToResizeColumns = False
        remarkDataView.AllowUserToResizeColumns = False
    End Sub

    Private Sub allDataView_Scroll(sender As Object, e As ScrollEventArgs) Handles remarkDataView.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            equivalentDataView.FirstDisplayedScrollingRowIndex = remarkDataView.FirstDisplayedScrollingRowIndex
            gradeDataView.FirstDisplayedScrollingRowIndex = remarkDataView.FirstDisplayedScrollingRowIndex
            examDataView.FirstDisplayedScrollingRowIndex = remarkDataView.FirstDisplayedScrollingRowIndex
            projectDataView.FirstDisplayedScrollingRowIndex = remarkDataView.FirstDisplayedScrollingRowIndex
            quizDataView.FirstDisplayedScrollingRowIndex = remarkDataView.FirstDisplayedScrollingRowIndex
            attendanceDataView.FirstDisplayedScrollingRowIndex = remarkDataView.FirstDisplayedScrollingRowIndex
            studentInfoDataView.FirstDisplayedScrollingRowIndex = remarkDataView.FirstDisplayedScrollingRowIndex
        End If
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        Me.Visible = False
        LoginForgot.Visible = True
    End Sub

    Private Sub midtermButton_Click(sender As Object, e As EventArgs) Handles midtermButton.Click
        term = "Midterm"
        mainRefresh()
    End Sub

    Private Sub finalButton_Click(sender As Object, e As EventArgs) Handles finalButton.Click
        term = "Final"
        mainRefresh()
    End Sub

    Public Function getTerm() As String
        Return term
    End Function

    Private Sub deleteItemButton_Click(sender As Object, e As EventArgs) Handles deleteItemButton.Click
        deleteItemForm.Visible = True
    End Sub

    Private Sub makeAIFChild()
        addItemForm.TopLevel = False
        addItemForm.Parent = Me
        CenterAIF()
        addItemForm.BringToFront()
    End Sub

    Private Sub CenterAIF()
        Dim x As Integer = (Me.ClientSize.Width - addItemForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - addItemForm.Height) \ 2
        addItemForm.Location = New Point(x, y)
    End Sub

    Private Sub GradingSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeDVS()
        makeAIFChild()
        makeSAFChild()
        makeDIFChild()
    End Sub

    Private Sub makeDIFChild()
        deleteItemForm.TopLevel = False
        deleteItemForm.Parent = Me
        CenterDIF()
        deleteItemForm.BringToFront()
    End Sub

    Private Sub CenterDIF()
        Dim x As Integer = (Me.ClientSize.Width - deleteItemForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - deleteItemForm.Height) \ 2
        deleteItemForm.Location = New Point(x, y)
    End Sub

    Private setAttendance As New SetAttendanceForm
    Private Sub attendanceButton_Click(sender As Object, e As EventArgs) Handles attendanceButton.Click
        setAttendance.Visible = True
    End Sub

    Private Sub makeSAFChild()
        setAttendance.TopLevel = False
        setAttendance.Parent = Me
        CenterSAF()
        setAttendance.BringToFront()
    End Sub

    Private Sub CenterSAF()
        Dim x As Integer = (Me.ClientSize.Width - setAttendance.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - setAttendance.Height) \ 2
        setAttendance.Location = New Point(x, y)
    End Sub
End Class