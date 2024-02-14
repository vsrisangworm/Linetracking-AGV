Imports System.IO.Ports
Imports Microsoft.Office.Interop.Excel
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Public Class Form1
    Dim Data1 As String
    Dim Data2 As String
    Dim Tag1 As String
    Dim Stus As String
    Dim WithEvents sp As New SerialPort
    Dim TimePoll As Timer
    Private Sub GetSerialPortNames()
        For Each sport As String In My.Computer.Ports.SerialPortNames
            combport.Items.Add(sport)
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim BaudRates() As String = {"300", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200"}
        combbaud.Items.AddRange(BaudRates)
        combbaud.SelectedIndex = 4
        Try
            GetSerialPortNames()
            combport.SelectedIndex = 0
        Catch
            MsgBox("No ports connected.")
        End Try

        Timer1.Start()


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbDate.Text = Date.Now.ToString("MM/dd/yyyy")
        lbTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    'RFID=1030 // AGV_IN
    'AGV_1
    Private Sub btn_AGV1_Click(sender As Object, e As EventArgs) Handles btn_AGV1.Click

        btn_LAM1.BackColor = Color.BlueViolet
        lb_Lanp1.Text = "AGV_1"

    End Sub
    'AGV_2
    Private Sub btn_AGV2_Click(sender As Object, e As EventArgs) Handles btn_AGV2.Click

        btn_LAM1.BackColor = Color.BlueViolet
        lb_Lanp1.Text = "AGV_2"

    End Sub
    'AGV_3
    Private Sub btn_AGV3_Click(sender As Object, e As EventArgs) Handles btn_AGV3.Click

        btn_LAM1.BackColor = Color.BlueViolet
        lb_Lanp1.Text = "AGV_3"


    End Sub
    'AGV_4
    Private Sub btn_AGV4_Click(sender As Object, e As EventArgs) Handles btn_AGV4.Click

        btn_LAM1.BackColor = Color.BlueViolet
        lb_Lanp1.Text = "AGV_4"


    End Sub

    'RFID=1019 // AGV_RUN
    'AGV_1
    Private Sub btn1_AGV1_Click(sender As Object, e As EventArgs) Handles btn1_AGV1.Click

        btn_LAM1.BackColor = Color.White 'Lamp1
        btn_1LAM1.BackColor = Color.BlueViolet 'Lamp2
        lb_Lanp2.Text = "AGV_1"
        lb_Lanp1.Text = ""

    End Sub
    'AGV_2
    Private Sub btn1_AGV2_Click(sender As Object, e As EventArgs) Handles btn1_AGV2.Click

        btn_LAM1.BackColor = Color.White
        btn_1LAM1.BackColor = Color.BlueViolet
        lb_Lanp2.Text = "AGV_2"
        lb_Lanp1.Text = ""

    End Sub
    'AGV_3
    Private Sub btn1_AGV3_Click(sender As Object, e As EventArgs) Handles btn1_AGV3.Click

        btn_LAM1.BackColor = Color.White
        btn_1LAM1.BackColor = Color.BlueViolet
        lb_Lanp2.Text = "AGV_3"
        lb_Lanp1.Text = ""
    End Sub
    'AGV_4
    Private Sub btn1_AGV4_Click(sender As Object, e As EventArgs) Handles btn1_AGV4.Click

        btn_LAM1.BackColor = Color.White
        btn_1LAM1.BackColor = Color.BlueViolet

        lb_Lanp2.Text = "AGV_4"
        lb_Lanp1.Text = ""
    End Sub

    'RFID=1033 // AGV_STOP
    'AGV_1
    Private Sub btn2_AGV1_Click(sender As Object, e As EventArgs) Handles btn2_AGV1.Click

        btn_2LAM1.BackColor = Color.BlueViolet
        btn_1LAM1.BackColor = Color.White

        lb_Lanp3.Text = "AGV_1"
        lb_Lanp2.Text = ""

    End Sub
    'AGV_2
    Private Sub btn2_AGV2_Click(sender As Object, e As EventArgs) Handles btn2_AGV2.Click

        btn_2LAM1.BackColor = Color.BlueViolet
        btn_1LAM1.BackColor = Color.White

        lb_Lanp3.Text = "AGV_2"
        lb_Lanp2.Text = ""


    End Sub
    'AGV_3
    Private Sub btn2_AGV3_Click(sender As Object, e As EventArgs) Handles btn2_AGV3.Click

        btn_2LAM1.BackColor = Color.BlueViolet
        btn_1LAM1.BackColor = Color.White
        lb_Lanp3.Text = "AGV_3"
        lb_Lanp2.Text = ""

    End Sub
    'AGV_4
    Private Sub btn2_AGV4_Click(sender As Object, e As EventArgs) Handles btn2_AGV4.Click
        btn_2LAM1.BackColor = Color.BlueViolet
        btn_1LAM1.BackColor = Color.White

        lb_Lanp3.Text = "AGV_4"
        lb_Lanp2.Text = ""

    End Sub

    'RFID=1040 //AGV_OUT
    'AGV_1
    Private Sub btn3_AGV1_Click(sender As Object, e As EventArgs) Handles btn3_AGV1.Click

        btn_3LAM1.BackColor = Color.BlueViolet
        btn_2LAM1.BackColor = Color.White
        lb_Lanp4.Text = "AGV_1"
        lb_Lanp3.Text = ""

    End Sub
    'AGV_2
    Private Sub btn3_AGV2_Click(sender As Object, e As EventArgs) Handles btn3_AGV2.Click
        btn_3LAM1.BackColor = Color.BlueViolet
        btn_2LAM1.BackColor = Color.White
        lb_Lanp4.Text = "AGV_2"
        lb_Lanp3.Text = ""

    End Sub
    'AGV_3
    Private Sub btn3_AGV3_Click(sender As Object, e As EventArgs) Handles btn3_AGV3.Click
        btn_3LAM1.BackColor = Color.BlueViolet
        btn_2LAM1.BackColor = Color.White
        lb_Lanp4.Text = "AGV_3"
        lb_Lanp3.Text = ""

    End Sub
    'AGV_4
    Private Sub btn3_AGV4_Click(sender As Object, e As EventArgs) Handles btn3_AGV4.Click
        btn_3LAM1.BackColor = Color.BlueViolet
        btn_2LAM1.BackColor = Color.White
        lb_Lanp4.Text = "AGV_4"
        lb_Lanp3.Text = ""

    End Sub

    'TextChanged RFID 1030


    Private Sub lb_Lanp1_TextChanged(sender As Object, e As EventArgs) Handles lb_Lanp1.TextChanged

        If lb_Lanp1.Text = "AGV_1" Then
            lb_Lanp1.Text = "AGV_1"
            Data1 = "AGV_IN"
            DataGridView1.Rows.Insert(0, lbDate.Text, lbTime.Text, lb_Lanp1.Text, Data1)

        End If

        If lb_Lanp1.Text = "AGV_2" Then
            lb_Lanp1.Text = "AGV_2"
            Data1 = "AGV_IN"
            DataGridView1.Rows.Insert(0, lbDate.Text, lbTime.Text, lb_Lanp1.Text, Data1)

        End If

        If lb_Lanp1.Text = "AGV_3" Then
            lb_Lanp1.Text = "AGV_3"
            Data1 = "AGV_IN"
            DataGridView1.Rows.Insert(0, lbDate.Text, lbTime.Text, lb_Lanp1.Text, Data1)

        End If

        If lb_Lanp1.Text = "AGV_4" Then
            lb_Lanp1.Text = "AGV_4"
            Data1 = "AGV_IN"
            DataGridView1.Rows.Insert(0, lbDate.Text, lbTime.Text, lb_Lanp1.Text, Data1)

        End If
    End Sub

    'TextChanged RFID 1032

    Private Sub lb_Lanp3_TextChanged(sender As Object, e As EventArgs) Handles lb_Lanp3.TextChanged

        If lb_Lanp3.Text = "AGV_1" Then

            lb_Lanp3.Text = "AGV_1"
            lb_Lanp2.Text = ""
            Data1 = "AGV_STOP"
            DataGridView1.Rows.Insert(0, lbDate.Text, lbTime.Text, lb_Lanp3.Text, Data1)

        End If


        If lb_Lanp3.Text = "AGV_2" Then

            lb_Lanp3.Text = "AGV_2"
            lb_Lanp2.Text = ""
            Data1 = "AGV_STOP"
            DataGridView1.Rows.Insert(0, lbDate.Text, lbTime.Text, lb_Lanp3.Text, Data1)

        End If


        If lb_Lanp3.Text = "AGV_3" Then

            lb_Lanp3.Text = "AGV_3"
            lb_Lanp2.Text = ""
            Data1 = "AGV_STOP"
            DataGridView1.Rows.Insert(0, lbDate.Text, lbTime.Text, lb_Lanp3.Text, Data1)

        End If

        If lb_Lanp3.Text = "AGV_4" Then

            lb_Lanp3.Text = "AGV_4"
            lb_Lanp2.Text = ""
            Data1 = "AGV_STOP"
            DataGridView1.Rows.Insert(0, lbDate.Text, lbTime.Text, lb_Lanp3.Text, Data1)

        End If

    End Sub

    'TextChanged RFID 1041
    Private Sub lb_Lanp4_TextChanged(sender As Object, e As EventArgs) Handles lb_Lanp4.TextChanged

        If lb_Lanp4.Text = "AGV_1" Then

            lb_Lanp4.Text = "AGV_1"
            lb_Lanp3.Text = ""
            Data1 = "AGV_OUT"
            DataGridView1.Rows.Insert(0, lbDate.Text, lbTime.Text, lb_Lanp4.Text, Data1)

        End If

        If lb_Lanp4.Text = "AGV_2" Then

            lb_Lanp4.Text = "AGV_2"
            lb_Lanp3.Text = ""
            Data1 = "AGV_OUT"
            DataGridView1.Rows.Insert(0, lbDate.Text, lbTime.Text, lb_Lanp4.Text, Data1)

        End If

        If lb_Lanp4.Text = "AGV_3" Then

            lb_Lanp4.Text = "AGV_3"
            lb_Lanp3.Text = ""
            Data1 = "AGV_OUT"
            DataGridView1.Rows.Insert(0, lbDate.Text, lbTime.Text, lb_Lanp4.Text, Data1)

        End If

        If lb_Lanp4.Text = "AGV_4" Then

            lb_Lanp4.Text = "AGV_4"
            lb_Lanp3.Text = ""
            Data1 = "AGV_OUT"
            DataGridView1.Rows.Insert(0, lbDate.Text, lbTime.Text, lb_Lanp4.Text, Data1)

        End If

    End Sub

    Private Sub btnconnector_Click(sender As Object, e As EventArgs) Handles btnconnector.Click
        Try
            sp.BaudRate = combbaud.SelectedItem.ToString
            sp.PortName = combport.SelectedItem.ToString
            sp.Open()
            If sp.IsOpen Then
                btnconnector.Visible = False
                combport.Enabled = False
                combbaud.Enabled = False
                btnDisconnector.Visible = True
                'Timer1.Start()
                TimePoll = New Timer
                TimePoll.Interval = 10
                AddHandler TimePoll.Tick, AddressOf TimePoll_Tick
                TimePoll.Start()
                'Timer2.Start()
            End If
        Catch
            sp.Close()
        End Try
    End Sub

    Private Sub btnDisconnector_Click(sender As Object, e As EventArgs) Handles btnDisconnector.Click
        Try
            sp.Close()
            btnconnector.Visible = True
            btnDisconnector.Visible = False
            combport.Enabled = True
            combbaud.Enabled = True
            TimePoll.Stop()
            TimePoll = Nothing
            'Timer2.Stop()
            Exit Sub
        Catch
            MessageBox.Show("Some kind of problem.")
        End Try
    End Sub
    Private Sub TimePoll_Tick()

        If sp.BytesToRead > 0 Then  ' ตรวจสอบว่าArduino มีการส่งข้อมูลเข้ามาทาง Port ไหม

            Dim NewTemp() As String = Split(sp.ReadLine, ",")   ' เก็บค่าที่ Arduino ส่งมา

            TextBox1.Text = NewTemp(0)  'เอาค่าที่ Arduino ส่งมาแสดงใน Textbox

            'AGV1

            If TextBox1.Text = "1T30" Then  '1030

                btn_AGV1.PerformClick()

            End If

            If TextBox1.Text = "1T19" Then   '1033

                btn1_AGV1.PerformClick()

            End If

            If TextBox1.Text = "1T33" Then   '1033

                btn2_AGV1.PerformClick()

            End If

            If TextBox1.Text = "1T40" Then  '1040

                btn3_AGV1.PerformClick()

            End If

            'AGV2

            If TextBox1.Text = "2T30" Then

                btn_AGV2.PerformClick()

            End If

            If TextBox1.Text = "2T19" Then

                btn1_AGV2.PerformClick()

            End If

            If TextBox1.Text = "2T33" Then

                btn2_AGV2.PerformClick()

            End If

            If TextBox1.Text = "2OUT" Then

                btn3_AGV2.PerformClick()

            End If

            'AGV3

            If TextBox1.Text = "3T30" Then

                btn_AGV3.PerformClick()

            End If

            If TextBox1.Text = "3T19" Then

                btn1_AGV3.PerformClick()

            End If

            If TextBox1.Text = "3T33" Then

                btn2_AGV3.PerformClick()

            End If

            If TextBox1.Text = "3OUT" Then

                btn3_AGV3.PerformClick()

            End If

            'MODE_Picking

            If TextBox1.Text = "TEF1" Then

                btnEf11.BackColor = Color.Green
                btnP01.BackColor = Color.LightGray
                btnP03.BackColor = Color.LightGray

            End If

            If TextBox1.Text = "TA01" Then

                btnEf11.BackColor = Color.LightGray
                btnP01.BackColor = Color.Green
                btnP03.BackColor = Color.LightGray

            End If

            If TextBox1.Text = "TP03" Then

                btnEf11.BackColor = Color.LightGray
                btnP01.BackColor = Color.LightGray
                btnP03.BackColor = Color.Green


            End If

        End If


    End Sub

    Private Sub Btnselect_Click(sender As Object, e As EventArgs) Handles Btnselect.Click

        SaveFileDialog1.Title = "where your save excel file"
        SaveFileDialog1.Filter = "Excel File | *.xls;*.xlsx"
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        If txtFilepath.Text = Nothing Then

            MsgBox("Plase choose where to save Excel File")


        Else
            Dim xlapp As Excel.Application
            Dim xlworkbook As Excel.Workbook
            Dim xlworksheet As Excel.Worksheet

            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Int16, j As Int16
            xlapp = New Excel.ApplicationClass
            xlworkbook = xlapp.Workbooks.Add(misValue)
            xlworksheet = xlworkbook.Sheets(1)


            For s = 0 To DataGridView1.ColumnCount - 1
                xlworksheet.Cells(1, s + 1) = DataGridView1.Columns(s).Name.ToString
            Next


            For i = 0 To DataGridView1.RowCount - 2

                For j = 0 To DataGridView1.ColumnCount - 1
                    xlworksheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString
                Next


            Next



            Try
                xlworksheet.SaveAs(txtFilepath.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            xlworkbook.Close()
            xlapp.Quit()
            releaseOject(xlapp)
            releaseOject(xlworkbook)
            releaseOject(xlworksheet)

            MsgBox("Data Exports Succesfuly", MsgBoxStyle.Information, "Information")


        End If


    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        txtFilepath.Text = SaveFileDialog1.FileName
    End Sub


    Private Sub releaseOject(ByVal obj As Object)

        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing

        Catch ex As Exception
            GC.Collect()
        End Try
    End Sub
End Class
