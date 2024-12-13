Imports System.Security.Permissions
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
                If (projectDataView.Columns.Count > 0) Then
                    projectDataView.Rows.Add()
                End If
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

    Private Function computeProject(projectArr() As Double) As Double()
        Dim totalProjectScore As Double
        Dim totalProjectMax As Double
        Dim projectPercentage As Double

        Try
            connector.connect.Open()
            connector.query = "SELECT item_name, item_max_score FROM item WHERE item_type = 'Project' AND class_id = '" & classID & "' AND term = '" & term & "' ;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("item_max_score").ToString.Equals("")) Then
                    totalProjectMax += Double.Parse(connector.reader("item_max_score").ToString)
                End If
            End While
            MessageBox.Show("project max " & totalProjectMax)
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error computeProject()1")
        End Try

        Dim department As String = getDeptID()

        Try
            connector.connect.Open()
            connector.query = "SELECT p_project FROM percentage WHERE dept_id = '" & department & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("p_project").ToString.Equals("")) Then
                    projectPercentage = Double.Parse(connector.reader("p_project").ToString)
                    MessageBox.Show("project perc " & projectPercentage)
                    Exit While
                End If
            End While
            projectPercentage = projectPercentage / 100
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error  computeProject()2")
        End Try

        For i As Integer = 0 To projectArr.Length - 1
            For j As Integer = 0 To projectDataView.ColumnCount - 1
                Dim thisScore As Double = Double.Parse(projectDataView.Rows(i).Cells(j).Value.ToString)
                MessageBox.Show("project this " & thisScore)
                totalProjectScore += thisScore
            Next
            Dim totalProject As Double = (((totalProjectScore / totalProjectMax) * 50) + 50) * projectPercentage
            MessageBox.Show("project total " & totalProject)
            projectArr(i) = totalProject
        Next

        Return projectArr
    End Function

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
                If (quizDataView.Columns.Count > 0) Then
                    quizDataView.Rows.Add()
                End If
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

    Public professorID As String
    Private Function computeQuiz(quizArr() As Double) As Double()
        Dim totalQuizScore As Double
        Dim totalQuizMax As Double
        Dim quizPercentage As Double

        Try
            connector.connect.Open()
            connector.query = "SELECT item_name, item_max_score FROM item WHERE item_type = 'Quiz' AND class_id = '" & classID & "' AND term = '" & term & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("item_max_score").ToString.Equals("")) Then
                    totalQuizMax += Double.Parse(connector.reader("item_max_score").ToString)
                End If
            End While
            MessageBox.Show("quiz max " & totalQuizMax)
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error computeQuiz()1")
        End Try

        Dim department As String = getDeptID()

        Try
            connector.connect.Open()
            connector.query = "SELECT p_quiz FROM percentage WHERE dept_id = '" & department & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("p_quiz").ToString.Equals("")) Then
                    quizPercentage = Double.Parse(connector.reader("p_quiz").ToString)
                    MessageBox.Show("quiz perc " & quizPercentage)
                    Exit While
                End If
            End While
            quizPercentage = quizPercentage / 100
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error  computeQuiz()2")
        End Try

        MessageBox.Show("row quiz" & quizArr.Length)
        For i As Integer = 0 To quizArr.Length - 1
            For j As Integer = 0 To quizDataView.ColumnCount - 1
                Dim thisScore As Double = Double.Parse(quizDataView.Rows(i).Cells(j).Value.ToString)
                MessageBox.Show("quiz this " & thisScore)
                totalQuizScore += thisScore
            Next
            Dim totalQuiz As Double = (((totalQuizScore / totalQuizMax) * 50) + 50) * quizPercentage
            MessageBox.Show("quiz total " & totalQuiz)
            quizArr(i) = totalQuiz
        Next
        Return quizArr
    End Function

    Private Function getDeptID() As String
        Dim department As String = ""
        Try
            connector.connect.Open()
            connector.query = "SELECT dept_id FROM professor WHERE id = '" & professorID & "'; "
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("dept_id").ToString.Equals("")) Then
                    department = connector.reader("dept_id").ToString
                    connector.reader.Close()
                    connector.connect.Close()
                    Return department
                End If
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error getDeptID()")
        End Try
        Return Nothing
    End Function

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

    Private Sub refreshAttScores()
        isRefreshed = True
        Dim numOfRow As Integer = attendanceDataView.RowCount
        Try
            connector.connect.Open()
            connector.query = "SELECT present FROM attendance WHERE class_id = '" & classID & "' AND term = '" & term & "' ORDER BY enrollment_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            Dim i As Integer = 0
            While connector.reader.Read
                If (Not connector.reader("present").ToString.Equals("")) Then
                    attendanceDataView.Rows(i).Cells(0).Value = connector.reader("present").ToString
                    i += 1
                End If
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error refreshAttScores()")
        End Try

        Try
            connector.connect.Open()
            connector.query = "SELECT absent FROM attendance WHERE class_id = '" & classID & "' AND term = '" & term & "' ORDER BY enrollment_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            Dim i As Integer = 0
            While connector.reader.Read
                attendanceDataView.Rows(i).Cells(1).Value = connector.reader("absent").ToString
                i += 1
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error refreshAttScores()")
        End Try
    End Sub

    Private Sub attendanceDataView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles attendanceDataView.CellValueChanged
        If (isRefreshed = False) Then
            Dim rowIndex As Integer = e.RowIndex
            Dim columnIndex As Integer = e.ColumnIndex
            If rowIndex >= 0 And columnIndex >= 0 Then
                setAttendanceScore(rowIndex, columnIndex)
            End If
            mainRefresh()
        End If
    End Sub

    Private Function computeAttendance(attendanceArr() As Double) As Double()
        Dim totalAttendanceScore As Double
        Dim totalAttendanceMax As Double
        Dim attendancePercentage As Double

        Try
            connector.connect.Open()
            connector.query = "SELECT item_name, item_max_score FROM item WHERE item_type = 'Attendance' AND class_id = '" & classID & "' AND term = '" & term & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("item_max_score").ToString.Equals("")) Then
                    totalAttendanceMax += Double.Parse(connector.reader("item_max_score").ToString)
                End If
            End While
            MessageBox.Show(" attendance max " & totalAttendanceMax)
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error computeAttendance()1")
        End Try

        Dim department As String = getDeptID()

        Try
            connector.connect.Open()
            connector.query = "SELECT p_attendance FROM percentage WHERE dept_id = '" & department & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("p_attendance").ToString.Equals("")) Then
                    attendancePercentage = Double.Parse(connector.reader("p_attendance").ToString)
                    MessageBox.Show("attendance perc " & attendancePercentage)
                    Exit While
                End If
            End While
            attendancePercentage = attendancePercentage / 100
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error  computeAttendance()2")
        End Try
        For i As Integer = 0 To attendanceDataView.RowCount - 2
            Dim thisScore As Double = Double.Parse(attendanceDataView.Rows(i).Cells(0).Value.ToString)
            MessageBox.Show("this attendance " & thisScore)
            totalAttendanceScore += thisScore

            Dim totalAttendance As Double = (((totalAttendanceScore / totalAttendanceMax) * 50) + 50) * attendancePercentage
            MessageBox.Show("attendance total " & totalAttendance)
            attendanceArr(i) = totalAttendance
        Next
        Return attendanceArr
    End Function

    Private Function getAttendanceScore(rowIndex As Integer, columnIndex As Integer) As Integer
        Dim newValue As Integer = Integer.Parse(attendanceDataView.Rows(rowIndex).Cells(columnIndex).Value.ToString)
        Return newValue
    End Function

    Private Sub setAttendanceScore(rowIndex As Integer, columnIndex As Integer)
        Dim attendanceScore As Integer = getAttendanceScore(rowIndex, columnIndex)
        Dim enrollmentID As String = getEnrollmentID(rowIndex)
        Dim presOrAbs As String = "present"
        If (columnIndex.ToString.Equals("1")) Then
            presOrAbs = "absent"
        End If
        Try
            connector.connect.Open()
            connector.query = "UPDATE attendance SET " & presOrAbs & " = '" & attendanceScore & "' WHERE enrollment_id = '" & enrollmentID & "' AND class_id = '" & classID & "' AND term = '" & term & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error setAttendanceScore")
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

    Private Sub placeExamScores(numOfColumn As Integer, examItem() As String)
        Try
            connector.connect.Open()
            connector.query = "SELECT score FROM score_record LEFT JOIN item ON score_record.item_id = item.item_id WHERE item_name = '" & examItem(0) & "' AND class_id = '" & classID & "' AND term = '" & term & "' ORDER BY enrollment_id;"
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            Dim i As Integer = 0
            While connector.reader.Read
                examDataView.Rows(i).Cells(0).Value = connector.reader("score").ToString
                i += 1
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            connector.reader.Close()
            MessageBox.Show("Database Error placeExamScores()")
        End Try
    End Sub

    Private Sub refreshExamScores()
        isRefreshed = True
        Dim numOfColumn As Integer = examDataView.ColumnCount
        Dim numOfRow As Integer = examDataView.RowCount
        Dim examItem(examDataView.ColumnCount) As String
        Try
            connector.connect.Open()
            connector.query = "SELECT item_name FROM item WHERE item_type = 'Exam' AND class_id = '" & classID & "' AND term = '" & term & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            Dim i As Integer = 0
            While connector.reader.Read
                examItem(i) = connector.reader("item_name").ToString
                i += 1
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error refreshExamScores()")
        End Try
        placeExamScores(numOfColumn, examItem)
    End Sub

    Private Sub examDataView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles examDataView.CellValueChanged
        If (isRefreshed = False) Then
            Dim rowIndex As Integer = e.RowIndex
            Dim columnIndex As Integer = e.ColumnIndex
            If rowIndex >= 0 And columnIndex >= 0 Then
                setExamScore(rowIndex, columnIndex)
            End If
            mainRefresh()
        End If
    End Sub

    Private Function getExamScore(rowIndex As Integer, columnIndex As Integer) As Integer
        Dim newValue As Integer = Integer.Parse(examDataView.Rows(rowIndex).Cells(columnIndex).Value.ToString)
        Return newValue
    End Function

    Private Function getExamItemID(columnIndex As Integer) As String
        Dim columnName As String = "E1"
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
            MessageBox.Show("Database Error getExamItemID")
        End Try
        Return Nothing
    End Function

    Private Sub setExamScore(rowIndex As Integer, columnIndex As Integer)
        Dim examScore As Integer = getExamScore(rowIndex, columnIndex)
        Dim enrollmentID As String = getEnrollmentID(rowIndex)
        Dim itemID As String = getExamItemID(columnIndex)
        Try
            connector.connect.Open()
            connector.query = "UPDATE score_record SET score = '" & examScore & "' WHERE enrollment_id = '" & enrollmentID & "' AND item_id = '" & itemID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error setExamScore")
        End Try
    End Sub

    Private Function computeExam(examArr() As Double) As Double()
        Dim totalExamScore As Double
        Dim totalExamMax As Double
        Dim ExamPercentage As Double

        Try
            connector.connect.Open()
            connector.query = "SELECT item_name, item_max_score FROM item WHERE item_type = 'Exam' AND class_id = '" & classID & "' AND term = '" & term & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("item_max_score").ToString.Equals("")) Then
                    totalExamMax += Double.Parse(connector.reader("item_max_score").ToString)
                End If
            End While
            MessageBox.Show(" exam max " & totalExamMax)
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error computeExam()1")
        End Try

        Dim department As String = getDeptID()

        Try
            connector.connect.Open()
            connector.query = "SELECT p_exam FROM percentage WHERE dept_id = '" & department & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("p_exam").ToString.Equals("")) Then
                    ExamPercentage = Double.Parse(connector.reader("p_exam").ToString)
                    MessageBox.Show("exam perc " & ExamPercentage)
                    Exit While
                End If
            End While
            ExamPercentage = ExamPercentage / 100
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error  computeexam()2")
        End Try

        For i As Integer = 0 To examDataView.RowCount - 1
            Dim thisScore As Double = Double.Parse(examDataView.Rows(i).Cells(0).Value.ToString)
            MessageBox.Show("this exam " & thisScore)
            totalExamScore += thisScore

            Dim totalExam As Double = (((totalExamScore / totalExamMax) * 50) + 50) * ExamPercentage
            MessageBox.Show("exam total " & totalExam)
            examArr(i) = totalExam
        Next

        Return examArr
    End Function

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
            For i As Integer = 0 To studentCount - 1
                gradeDataView.Rows.Add()
                gradeDataView.Rows(i).Cells(0).Value = 0
            Next
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error refreshAttRows()")
        End Try
    End Sub

    Private Sub placeGradeScores(numOfColumn As Integer, gradeItem() As String)
        Try
            connector.connect.Open()
            connector.query = "SELECT grade FROM grade LEFT JOIN enrollment ON grade.enrollment_id = enrollment.enrollment_id WHERE class_id = '" & classID & "'; "
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            Dim i As Integer = 0
            While connector.reader.Read
                examDataView.Rows(i).Cells(0).Value = connector.reader("grade").ToString
                i += 1
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            connector.reader.Close()
            MessageBox.Show("Database Error placeGradeScores()")
        End Try
    End Sub

    Private Sub refreshGradeScores()
        isRefreshed = True
        Dim numOfColumn As Integer = examDataView.ColumnCount
        Dim numOfRow As Integer = examDataView.RowCount
        Dim examItem(examDataView.ColumnCount) As String
        Try
            connector.connect.Open()
            connector.query = "SELECT item_name FROM item WHERE item_type = 'Exam' AND class_id = '" & classID & "' AND term = '" & term & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            Dim i As Integer = 0
            While connector.reader.Read
                examItem(i) = connector.reader("item_name").ToString
                i += 1
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error refreshExamScores()")
        End Try
        placeExamScores(numOfColumn, examItem)
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
        Dim attendanceArr(attendanceDataView.RowCount) As Double
        Dim projectArr(projectDataView.RowCount) As Double
        Dim quizArr(quizDataView.RowCount) As Double
        Dim examArr(examDataView.RowCount) As Double
        refreshForm()
        refreshProjCol()
        refreshProjRows()
        refreshProjScores()
        refreshQuizCol()
        refreshQuizRows()
        refreshQuizScores()
        refreshAttRows()
        refreshAttScores()
        refreshExamRows()
        refreshExamScores()
        refreshGradeRows()
        refreshEquivalentRows()
        refreshRemarkRows()
        'computeQuiz(quizArr)
        'computeProject(projectArr)
        'computeAttendance(attendanceArr)
        'computeExam(examArr)
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
        makeSEFChild()
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

    Private setExamForm As New SetExamForm
    Private Sub examButton_Click(sender As Object, e As EventArgs) Handles examButton.Click
        setExamForm.Visible = True
    End Sub

    Private Sub makeSEFChild()
        setExamForm.TopLevel = False
        setExamForm.Parent = Me
        CenterSEF()
        setExamForm.BringToFront()
    End Sub

    Private Sub CenterSEF()
        Dim x As Integer = (Me.ClientSize.Width - setExamForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - setExamForm.Height) \ 2
        setExamForm.Location = New Point(x, y)
    End Sub
End Class