Public Class Form1


    Dim RecievedData As String = ""



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RComm.Click
        If SerialPort1.IsOpen = False Then
            MsgBox("请先打开串口！")
            Return
        End If
        ReadData.Text = "接收到数据：" + SerialPort1.ReadLine.ToString       '读取一个新行

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RateSet1.TextChanged, RateSet2.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rate1.Click, Rate2.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        WriteData.Text = "This is a test from COM3"

        PortNameSet1.Text = "com2"
        RateSet1.Text = "19200"
        DataBitSet1.Text = "8"
        StopBitSet1.Text = "1"


        PortNameSet2.Text = "com3"
        RateSet2.Text = "19200"
        DataBitSet2.Text = "8"
        StopBitSet2.Text = "1"

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WriteData.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SerialPort1.PortName = PortNameSet1.Text
        SerialPort1.BaudRate = RateSet1.Text
        SerialPort1.DataBits = DataBitSet1.Text
        SerialPort1.StopBits = StopBitSet1.Text


        SerialPort1.Open()
        If SerialPort1.IsOpen = True Then
            Button1.BackColor = Color.Green
            Button2.BackColor = Color.Gray
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SerialPort1.Close()
        If SerialPort2.IsOpen = False Then
            Button1.BackColor = Color.Gray
            Button2.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SerialPort2.PortName = PortNameSet2.Text
        SerialPort2.BaudRate = RateSet2.Text
        SerialPort2.DataBits = DataBitSet2.Text
        SerialPort2.StopBits = StopBitSet2.Text


        SerialPort2.Open()
        If SerialPort2.IsOpen = True Then
            Button3.BackColor = Color.Green
            Button4.BackColor = Color.Gray
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SerialPort2.Close()
        If SerialPort2.IsOpen = False Then
            Button3.BackColor = Color.Gray
            Button4.BackColor = Color.Red
        End If
    End Sub

    Private Sub WComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WComm.Click
        If SerialPort2.IsOpen = False Then
            MsgBox("请先打开串口！")
            Return
            End
        End If
        SerialPort2.WriteLine(WriteData.Text)
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        RecievedData = SerialPort1.ReadLine.ToString '读取一个新行
        'MsgBox(RecievedData)
        'Call Disp()

        Me.Invoke(Sub() ReadData.AppendText(RecievedData + vbLf))


    End Sub


    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        ReadData.Clear()
    End Sub

    Private Sub ExitProg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitProg.Click
        End
    End Sub
End Class
