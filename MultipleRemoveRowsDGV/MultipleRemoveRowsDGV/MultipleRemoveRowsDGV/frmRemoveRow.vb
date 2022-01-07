#Region "ABOUT"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gnet.com/webboard
' / 
' / Purpose: Multiple remove rows in DataGridView.
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region


Public Class frmRemoveRow
    '// Add CheckBox into Column Header at Run-Time.
    Private HeaderCheckBox As CheckBox = New CheckBox()
    '// START HERE
    Private Sub frmRemoveRow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '// ตั้งค่าเริ่มต้นให้กับตารางกริด
        Call SetupDataGridView1(DataGridView1)
        '// ใส่ข้อมูลทดสอบ
        Call SampleData()
    End Sub

    '// ลบแถวรายการที่เลือก Method I
    Private Sub btnMethod1_Click(sender As System.Object, e As System.EventArgs) Handles btnMethod1.Click
        '// Method I ... นับจากบรรทัดล่างสุดขึ้นมา
        For iRow As Integer = DataGridView1.Rows.Count - 1 To 0 Step -1
            '// หรือลองเงื่อนไข For Loop ตัวนี้ เพื่อนโปรแกรมเมอร์ต่างชาติส่งมาให้ ก็ดูแปลกตาดี
            'For iRow As Int32 = DataGridView1.Rows.Count - If(DataGridView1.NewRowIndex = -1, 1, 2) To 0 Step -1
            If CBool(DataGridView1.Rows(iRow).Cells(0).Value) = True Then
                'MsgBox(DataGridView1.Rows(iRow).Cells(1).Value)
                '// ลบรายการออกจากฐานข้อมูล "DELETE FROM TABLE WHERE PrimaryKey = DataGridView1.Rows(iRow).Cells(1).Value"
                '//
                '// ลบแถวออกจากตารางกริด
                DataGridView1.Rows.RemoveAt(iRow)
            End If
        Next
    End Sub

    '// Method II
    Private Sub btnMethod2_Click(sender As System.Object, e As System.EventArgs) Handles btnMethod2.Click
        Dim SelectedItem As List(Of DataGridViewRow) = New List(Of DataGridViewRow)()
        For Each iRow As DataGridViewRow In DataGridView1.Rows
            If CBool(iRow.Cells(0).Value) = True Then SelectedItem.Add(iRow)
        Next
        For Each iRow As DataGridViewRow In SelectedItem
            DataGridView1.Rows.Remove(iRow)
        Next
    End Sub

    '// Method III
    Private Sub btnMethod3_Click(sender As System.Object, e As System.EventArgs) Handles btnMethod3.Click
        Dim ChkRow As List(Of Object) = New List(Of Object)()
        Dim CountDeletedRows As Integer = 0
        For iRow As Integer = 0 To DataGridView1.RowCount - 1
            If CBool(DataGridView1.Rows(iRow).Cells("chkColumn").Value) = True Then ChkRow.Add(iRow)
        Next
        For Each iRow As Integer In ChkRow
            DataGridView1.Rows.RemoveAt(iRow - CountDeletedRows)
            CountDeletedRows += 1
        Next
    End Sub

    '// โหลดค่าตัวอย่างลงใน DataGridView.
    Private Sub btnData_Click(sender As System.Object, e As System.EventArgs) Handles btnData.Click
        Call SampleData()
    End Sub

    '// ตัวอย่างข้อมูล
    Private Sub SampleData()
        DataGridView1.Rows.Clear()
        Try
            Dim RowData As String()
            '// สุ่มว่าให้ Checked/Unchecked.
            Dim rnd As New Random
            For iRow As Byte = 1 To 10
                RowData = New String() {rnd.Next(0, 2) > 0, iRow, "Product " & iRow}
                DataGridView1.Rows.Add(RowData)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '// เหตุการณ์ในการคลิ๊กเมาส์ลงในแต่ละเซลล์ของหลักแรก (Index = 0)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Return
        '// Column Index = 0
        If DataGridView1.Columns(e.ColumnIndex).Name = "chkColumn" Then
            Dim isChecked As Boolean = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            '// Toggle value.
            If Not isChecked Then
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
            Else
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False
            End If
        End If
    End Sub

    ' / --------------------------------------------------------------------------------
    '// Initialize DataGridView @Run Time
    Private Sub SetupDataGridView1(ByRef DGV As DataGridView)
        With DataGridView1
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .Font = New Font("Tahoma", 11)
            '/ Autosize Column
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '// Even-Odd Color
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            '/ Adjust Header Styles
            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.Navy
                .ForeColor = Color.Black
                .Font = New Font("Tahoma", 11, FontStyle.Bold)
            End With
            '// Add Columns Specified.
            .Columns.Add("ProductPK", "ProductPK")
            .Columns.Add("ProductName", "Product Name")

            '/ Add CheckBox at Column Header (Run Time)
            Dim HeaderCellLocation As Point = Me.DataGridView1.GetCellDisplayRectangle(0, -1, True).Location
            '/ กำหนดตำแหน่งของ CheckBox ในส่วนของ Column Header.
            With HeaderCheckBox
                .Location = New Point(HeaderCellLocation.X + 23, HeaderCellLocation.Y + 4)
                .BackColor = Color.White
                .Size = New Size(18, 18)
            End With
            '/ กำหนดเหตุการณ์ในการกดคลิ๊กที่ส่วนหัว Header.
            AddHandler HeaderCheckBox.Click, AddressOf HeaderCheckBox_Clicked
            DataGridView1.Controls.Add(HeaderCheckBox)
            '/ เพิ่มหลัก CheckBox Control.
            Dim CheckBoxColumn As New DataGridViewCheckBoxColumn()
            With CheckBoxColumn
                .HeaderText = ""
                .Width = 60
                .Name = "chkColumn"
            End With
            '// ไปแทรกหลักแรก
            DataGridView1.Columns.Insert(0, CheckBoxColumn)
            '/ กำหนดเหตุการณ์ในการคลิ๊กลงในเซลล์ของ DataGridView.
            AddHandler DataGridView1.CellContentClick, AddressOf DataGridView_CellClick
        End With
        DataGridView1.Columns(0).Resizable = DataGridViewTriState.False
        '// Adjust DataGridView Width.
        With DataGridView1
            .Columns(1).Width = .Width \ 2 - .Columns(0).Width
            .Columns(2).Width = .Width \ 2 - .Columns(0).Width + 40
        End With
    End Sub

    '// Event Handler Click Header CheckBox on DataGridView.
    Private Sub HeaderCheckBox_Clicked(ByVal sender As Object, ByVal e As EventArgs)
        DataGridView1.EndEdit()
        '/ วนรอบในการคลิ๊ก Check/Uncheck ทุกๆแถว เมื่อมีการคลิ๊กบน Header ของ CheckBox.
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim CheckBox As DataGridViewCheckBoxCell = (TryCast(row.Cells("chkColumn"), DataGridViewCheckBoxCell))
            CheckBox.Value = HeaderCheckBox.Checked
        Next
    End Sub

    '// Event Handler Cell Click on DataGridView.
    Private Sub DataGridView_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        '/ Check to ensure that the row CheckBox is clicked.
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then
            '/ Loop to verify whether all row CheckBoxes are checked or not.
            Dim isChecked As Boolean = True
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Convert.ToBoolean(row.Cells("chkColumn").EditedFormattedValue) = False Then
                    isChecked = False
                    Exit For
                End If
            Next
            HeaderCheckBox.Checked = isChecked
        End If
    End Sub

    Private Sub frmRemoveRow_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmRemoveRow_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        If DataGridView1.RowCount = 0 Then Return
        With DataGridView1
            .Columns(1).Width = .Width \ 2 - .Columns(0).Width
            .Columns(2).Width = .Width \ 2 - .Columns(0).Width + 40
        End With
    End Sub

End Class
