<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.RComm = New System.Windows.Forms.Button()
        Me.PortNameSet1 = New System.Windows.Forms.TextBox()
        Me.PortName1 = New System.Windows.Forms.Label()
        Me.Rate1 = New System.Windows.Forms.Label()
        Me.RateSet1 = New System.Windows.Forms.TextBox()
        Me.DataBit1 = New System.Windows.Forms.Label()
        Me.DataBitSet1 = New System.Windows.Forms.TextBox()
        Me.StopBit1 = New System.Windows.Forms.Label()
        Me.StopBitSet1 = New System.Windows.Forms.TextBox()
        Me.ReadData = New System.Windows.Forms.TextBox()
        Me.WriteData = New System.Windows.Forms.TextBox()
        Me.PortNameSet2 = New System.Windows.Forms.TextBox()
        Me.PortName2 = New System.Windows.Forms.Label()
        Me.RateSet2 = New System.Windows.Forms.TextBox()
        Me.Rate2 = New System.Windows.Forms.Label()
        Me.DataBitSet2 = New System.Windows.Forms.TextBox()
        Me.DataBit2 = New System.Windows.Forms.Label()
        Me.StopBitSet2 = New System.Windows.Forms.TextBox()
        Me.StopBit2 = New System.Windows.Forms.Label()
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.WComm = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.ExitProg = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.DtrEnable = True
        '
        'RComm
        '
        Me.RComm.Location = New System.Drawing.Point(22, 104)
        Me.RComm.Name = "RComm"
        Me.RComm.Size = New System.Drawing.Size(145, 58)
        Me.RComm.TabIndex = 0
        Me.RComm.Text = "read"
        Me.RComm.UseVisualStyleBackColor = True
        '
        'PortNameSet1
        '
        Me.PortNameSet1.Location = New System.Drawing.Point(704, 28)
        Me.PortNameSet1.Name = "PortNameSet1"
        Me.PortNameSet1.Size = New System.Drawing.Size(89, 21)
        Me.PortNameSet1.TabIndex = 1
        '
        'PortName1
        '
        Me.PortName1.AutoSize = True
        Me.PortName1.Location = New System.Drawing.Point(599, 31)
        Me.PortName1.Name = "PortName1"
        Me.PortName1.Size = New System.Drawing.Size(59, 12)
        Me.PortName1.TabIndex = 2
        Me.PortName1.Text = "PortName1"
        '
        'Rate1
        '
        Me.Rate1.AutoSize = True
        Me.Rate1.Location = New System.Drawing.Point(599, 70)
        Me.Rate1.Name = "Rate1"
        Me.Rate1.Size = New System.Drawing.Size(29, 12)
        Me.Rate1.TabIndex = 4
        Me.Rate1.Text = "Rate"
        '
        'RateSet1
        '
        Me.RateSet1.Location = New System.Drawing.Point(704, 67)
        Me.RateSet1.Name = "RateSet1"
        Me.RateSet1.Size = New System.Drawing.Size(89, 21)
        Me.RateSet1.TabIndex = 3
        '
        'DataBit1
        '
        Me.DataBit1.AutoSize = True
        Me.DataBit1.Location = New System.Drawing.Point(599, 107)
        Me.DataBit1.Name = "DataBit1"
        Me.DataBit1.Size = New System.Drawing.Size(47, 12)
        Me.DataBit1.TabIndex = 6
        Me.DataBit1.Text = "DataBit"
        '
        'DataBitSet1
        '
        Me.DataBitSet1.Location = New System.Drawing.Point(704, 104)
        Me.DataBitSet1.Name = "DataBitSet1"
        Me.DataBitSet1.Size = New System.Drawing.Size(89, 21)
        Me.DataBitSet1.TabIndex = 5
        '
        'StopBit1
        '
        Me.StopBit1.AutoSize = True
        Me.StopBit1.Location = New System.Drawing.Point(599, 152)
        Me.StopBit1.Name = "StopBit1"
        Me.StopBit1.Size = New System.Drawing.Size(47, 12)
        Me.StopBit1.TabIndex = 8
        Me.StopBit1.Text = "StopBit"
        '
        'StopBitSet1
        '
        Me.StopBitSet1.Location = New System.Drawing.Point(704, 149)
        Me.StopBitSet1.Name = "StopBitSet1"
        Me.StopBitSet1.Size = New System.Drawing.Size(89, 21)
        Me.StopBitSet1.TabIndex = 7
        '
        'ReadData
        '
        Me.ReadData.Location = New System.Drawing.Point(22, 198)
        Me.ReadData.Multiline = True
        Me.ReadData.Name = "ReadData"
        Me.ReadData.Size = New System.Drawing.Size(514, 175)
        Me.ReadData.TabIndex = 9
        '
        'WriteData
        '
        Me.WriteData.Location = New System.Drawing.Point(377, 19)
        Me.WriteData.Multiline = True
        Me.WriteData.Name = "WriteData"
        Me.WriteData.Size = New System.Drawing.Size(159, 143)
        Me.WriteData.TabIndex = 1
        '
        'PortNameSet2
        '
        Me.PortNameSet2.Location = New System.Drawing.Point(704, 214)
        Me.PortNameSet2.Name = "PortNameSet2"
        Me.PortNameSet2.Size = New System.Drawing.Size(89, 21)
        Me.PortNameSet2.TabIndex = 1
        '
        'PortName2
        '
        Me.PortName2.AutoSize = True
        Me.PortName2.Location = New System.Drawing.Point(599, 217)
        Me.PortName2.Name = "PortName2"
        Me.PortName2.Size = New System.Drawing.Size(59, 12)
        Me.PortName2.TabIndex = 2
        Me.PortName2.Text = "PortName2"
        '
        'RateSet2
        '
        Me.RateSet2.Location = New System.Drawing.Point(704, 253)
        Me.RateSet2.Name = "RateSet2"
        Me.RateSet2.Size = New System.Drawing.Size(89, 21)
        Me.RateSet2.TabIndex = 3
        '
        'Rate2
        '
        Me.Rate2.AutoSize = True
        Me.Rate2.Location = New System.Drawing.Point(599, 256)
        Me.Rate2.Name = "Rate2"
        Me.Rate2.Size = New System.Drawing.Size(29, 12)
        Me.Rate2.TabIndex = 4
        Me.Rate2.Text = "Rate"
        '
        'DataBitSet2
        '
        Me.DataBitSet2.Location = New System.Drawing.Point(704, 290)
        Me.DataBitSet2.Name = "DataBitSet2"
        Me.DataBitSet2.Size = New System.Drawing.Size(89, 21)
        Me.DataBitSet2.TabIndex = 5
        '
        'DataBit2
        '
        Me.DataBit2.AutoSize = True
        Me.DataBit2.Location = New System.Drawing.Point(599, 293)
        Me.DataBit2.Name = "DataBit2"
        Me.DataBit2.Size = New System.Drawing.Size(47, 12)
        Me.DataBit2.TabIndex = 6
        Me.DataBit2.Text = "DataBit"
        '
        'StopBitSet2
        '
        Me.StopBitSet2.Location = New System.Drawing.Point(704, 335)
        Me.StopBitSet2.Name = "StopBitSet2"
        Me.StopBitSet2.Size = New System.Drawing.Size(89, 21)
        Me.StopBitSet2.TabIndex = 7
        '
        'StopBit2
        '
        Me.StopBit2.AutoSize = True
        Me.StopBit2.Location = New System.Drawing.Point(599, 338)
        Me.StopBit2.Name = "StopBit2"
        Me.StopBit2.Size = New System.Drawing.Size(47, 12)
        Me.StopBit2.TabIndex = 8
        Me.StopBit2.Text = "StopBit"
        '
        'SerialPort2
        '
        Me.SerialPort2.DtrEnable = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Location = New System.Drawing.Point(22, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 51)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Open Port"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.Location = New System.Drawing.Point(100, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 51)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Close Port"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.Location = New System.Drawing.Point(202, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 46)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Open Port"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gray
        Me.Button4.Location = New System.Drawing.Point(286, 24)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 45)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Close Port"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'WComm
        '
        Me.WComm.Location = New System.Drawing.Point(190, 104)
        Me.WComm.Name = "WComm"
        Me.WComm.Size = New System.Drawing.Size(157, 58)
        Me.WComm.TabIndex = 14
        Me.WComm.Text = "write"
        Me.WComm.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(22, 390)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(103, 27)
        Me.Clear.TabIndex = 15
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'ExitProg
        '
        Me.ExitProg.Location = New System.Drawing.Point(461, 392)
        Me.ExitProg.Name = "ExitProg"
        Me.ExitProg.Size = New System.Drawing.Size(75, 23)
        Me.ExitProg.TabIndex = 16
        Me.ExitProg.Text = "Exit"
        Me.ExitProg.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 501)
        Me.Controls.Add(Me.ExitProg)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.WComm)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReadData)
        Me.Controls.Add(Me.StopBit2)
        Me.Controls.Add(Me.StopBit1)
        Me.Controls.Add(Me.StopBitSet2)
        Me.Controls.Add(Me.StopBitSet1)
        Me.Controls.Add(Me.DataBit2)
        Me.Controls.Add(Me.DataBit1)
        Me.Controls.Add(Me.DataBitSet2)
        Me.Controls.Add(Me.DataBitSet1)
        Me.Controls.Add(Me.Rate2)
        Me.Controls.Add(Me.Rate1)
        Me.Controls.Add(Me.RateSet2)
        Me.Controls.Add(Me.PortName2)
        Me.Controls.Add(Me.RateSet1)
        Me.Controls.Add(Me.PortName1)
        Me.Controls.Add(Me.PortNameSet2)
        Me.Controls.Add(Me.WriteData)
        Me.Controls.Add(Me.PortNameSet1)
        Me.Controls.Add(Me.RComm)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents RComm As System.Windows.Forms.Button
    Friend WithEvents PortNameSet1 As System.Windows.Forms.TextBox
    Friend WithEvents PortName1 As System.Windows.Forms.Label
    Friend WithEvents Rate1 As System.Windows.Forms.Label
    Friend WithEvents RateSet1 As System.Windows.Forms.TextBox
    Friend WithEvents DataBit1 As System.Windows.Forms.Label
    Friend WithEvents DataBitSet1 As System.Windows.Forms.TextBox
    Friend WithEvents StopBit1 As System.Windows.Forms.Label
    Friend WithEvents StopBitSet1 As System.Windows.Forms.TextBox
    Friend WithEvents ReadData As System.Windows.Forms.TextBox
    Friend WithEvents WriteData As System.Windows.Forms.TextBox
    Friend WithEvents PortNameSet2 As System.Windows.Forms.TextBox
    Friend WithEvents PortName2 As System.Windows.Forms.Label
    Friend WithEvents RateSet2 As System.Windows.Forms.TextBox
    Friend WithEvents Rate2 As System.Windows.Forms.Label
    Friend WithEvents DataBitSet2 As System.Windows.Forms.TextBox
    Friend WithEvents DataBit2 As System.Windows.Forms.Label
    Friend WithEvents StopBitSet2 As System.Windows.Forms.TextBox
    Friend WithEvents StopBit2 As System.Windows.Forms.Label
    Friend WithEvents SerialPort2 As System.IO.Ports.SerialPort
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents WComm As System.Windows.Forms.Button
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents ExitProg As System.Windows.Forms.Button

End Class
