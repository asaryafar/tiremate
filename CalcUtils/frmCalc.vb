Imports System.Math
Public Class frmCalc
    Inherits System.Windows.Forms.Form

    Private MouseOffset As Point
    Private FinalText As String = "0"
    Private mText As String = ""
    Private mOperand As String = ""
    Private mTemp As String = ""

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnMosavi As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnZarb As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnMenha As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnTaghsim As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnJam As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAshar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnPM As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn0 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn3 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn6 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn5 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn4 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn9 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn8 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn7 As Janus.Windows.EditControls.UIButton
    Friend WithEvents ntxt As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnCE As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnDEL As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnC As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnNoAshar As Janus.Windows.GridEX.EditControls.IntegerUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnMosavi = New Janus.Windows.EditControls.UIButton
        Me.btnCE = New Janus.Windows.EditControls.UIButton
        Me.btnDEL = New Janus.Windows.EditControls.UIButton
        Me.btnZarb = New Janus.Windows.EditControls.UIButton
        Me.btnMenha = New Janus.Windows.EditControls.UIButton
        Me.btnTaghsim = New Janus.Windows.EditControls.UIButton
        Me.btnJam = New Janus.Windows.EditControls.UIButton
        Me.btnAshar = New Janus.Windows.EditControls.UIButton
        Me.btnPM = New Janus.Windows.EditControls.UIButton
        Me.btn0 = New Janus.Windows.EditControls.UIButton
        Me.btn3 = New Janus.Windows.EditControls.UIButton
        Me.btn2 = New Janus.Windows.EditControls.UIButton
        Me.btn1 = New Janus.Windows.EditControls.UIButton
        Me.btn6 = New Janus.Windows.EditControls.UIButton
        Me.btn5 = New Janus.Windows.EditControls.UIButton
        Me.btn4 = New Janus.Windows.EditControls.UIButton
        Me.btn9 = New Janus.Windows.EditControls.UIButton
        Me.btn8 = New Janus.Windows.EditControls.UIButton
        Me.btn7 = New Janus.Windows.EditControls.UIButton
        Me.ntxt = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.btnC = New Janus.Windows.EditControls.UIButton
        Me.btnCancel = New Janus.Windows.EditControls.UIButton
        Me.btnOk = New Janus.Windows.EditControls.UIButton
        Me.btnNoAshar = New Janus.Windows.GridEX.EditControls.IntegerUpDown
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnMosavi
        '
        Me.btnMosavi.Location = New System.Drawing.Point(134, 96)
        Me.btnMosavi.Name = "btnMosavi"
        Me.btnMosavi.Size = New System.Drawing.Size(32, 23)
        Me.btnMosavi.TabIndex = 39
        Me.btnMosavi.Text = "="
        '
        'btnCE
        '
        Me.btnCE.Location = New System.Drawing.Point(134, 48)
        Me.btnCE.Name = "btnCE"
        Me.btnCE.Size = New System.Drawing.Size(32, 23)
        Me.btnCE.TabIndex = 38
        Me.btnCE.Text = "CE"
        '
        'btnDEL
        '
        Me.btnDEL.Location = New System.Drawing.Point(134, 24)
        Me.btnDEL.Name = "btnDEL"
        Me.btnDEL.Size = New System.Drawing.Size(32, 23)
        Me.btnDEL.TabIndex = 37
        Me.btnDEL.Text = "DEL"
        '
        'btnZarb
        '
        Me.btnZarb.Location = New System.Drawing.Point(101, 48)
        Me.btnZarb.Name = "btnZarb"
        Me.btnZarb.Size = New System.Drawing.Size(32, 23)
        Me.btnZarb.TabIndex = 36
        Me.btnZarb.Text = "*"
        Me.btnZarb.TextVerticalAlignment = Janus.Windows.EditControls.TextAlignment.Far
        '
        'btnMenha
        '
        Me.btnMenha.Location = New System.Drawing.Point(101, 72)
        Me.btnMenha.Name = "btnMenha"
        Me.btnMenha.Size = New System.Drawing.Size(32, 23)
        Me.btnMenha.TabIndex = 35
        Me.btnMenha.Text = "-"
        '
        'btnTaghsim
        '
        Me.btnTaghsim.Location = New System.Drawing.Point(101, 24)
        Me.btnTaghsim.Name = "btnTaghsim"
        Me.btnTaghsim.Size = New System.Drawing.Size(32, 23)
        Me.btnTaghsim.TabIndex = 34
        Me.btnTaghsim.Text = "/"
        '
        'btnJam
        '
        Me.btnJam.Location = New System.Drawing.Point(101, 96)
        Me.btnJam.Name = "btnJam"
        Me.btnJam.Size = New System.Drawing.Size(32, 23)
        Me.btnJam.TabIndex = 33
        Me.btnJam.Text = "+"
        '
        'btnAshar
        '
        Me.btnAshar.Location = New System.Drawing.Point(68, 96)
        Me.btnAshar.Name = "btnAshar"
        Me.btnAshar.Size = New System.Drawing.Size(32, 23)
        Me.btnAshar.TabIndex = 32
        Me.btnAshar.Text = "."
        '
        'btnPM
        '
        Me.btnPM.Location = New System.Drawing.Point(35, 96)
        Me.btnPM.Name = "btnPM"
        Me.btnPM.Size = New System.Drawing.Size(32, 23)
        Me.btnPM.TabIndex = 31
        Me.btnPM.Text = "-/+"
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(2, 96)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(32, 23)
        Me.btn0.TabIndex = 30
        Me.btn0.Text = "0"
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(68, 72)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(32, 23)
        Me.btn3.TabIndex = 29
        Me.btn3.Text = "3"
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(35, 72)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(32, 23)
        Me.btn2.TabIndex = 28
        Me.btn2.Text = "2"
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(2, 72)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(32, 23)
        Me.btn1.TabIndex = 27
        Me.btn1.Text = "1"
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn6.Location = New System.Drawing.Point(68, 48)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(32, 23)
        Me.btn6.TabIndex = 26
        Me.btn6.Text = "6"
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(35, 48)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(32, 23)
        Me.btn5.TabIndex = 25
        Me.btn5.Text = "5"
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(2, 48)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(32, 23)
        Me.btn4.TabIndex = 24
        Me.btn4.Text = "4"
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(68, 24)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(32, 23)
        Me.btn9.TabIndex = 23
        Me.btn9.Text = "9"
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(35, 24)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(32, 23)
        Me.btn8.TabIndex = 22
        Me.btn8.Text = "8"
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(2, 24)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(32, 23)
        Me.btn7.TabIndex = 21
        Me.btn7.Text = "7"
        '
        'ntxt
        '
        Me.ntxt.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ntxt.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ntxt.Cursor = System.Windows.Forms.Cursors.Default
        Me.ntxt.DecimalDigits = 0
        Me.ntxt.Location = New System.Drawing.Point(2, 1)
        Me.ntxt.MaxLength = 27
        Me.ntxt.Name = "ntxt"
        Me.ntxt.Size = New System.Drawing.Size(165, 21)
        Me.ntxt.TabIndex = 20
        Me.ntxt.Text = "0"
        Me.ntxt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.ntxt.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(134, 72)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(32, 23)
        Me.btnC.TabIndex = 40
        Me.btnC.Text = "C"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(2, 120)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(38, 23)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnOk.Location = New System.Drawing.Point(128, 120)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(38, 23)
        Me.btnOk.TabIndex = 42
        Me.btnOk.Text = "Ok"
        '
        'btnNoAshar
        '
        Me.btnNoAshar.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.btnNoAshar.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.btnNoAshar.Location = New System.Drawing.Point(68, 120)
        Me.btnNoAshar.Maximum = 9
        Me.btnNoAshar.MaxLength = 1
        Me.btnNoAshar.Name = "btnNoAshar"
        Me.btnNoAshar.Size = New System.Drawing.Size(32, 21)
        Me.btnNoAshar.TabIndex = 43
        Me.btnNoAshar.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.ToolTip1.SetToolTip(Me.btnNoAshar, "Precision")
        '
        'frmCalc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(168, 144)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNoAshar)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnMosavi)
        Me.Controls.Add(Me.btnCE)
        Me.Controls.Add(Me.btnDEL)
        Me.Controls.Add(Me.btnZarb)
        Me.Controls.Add(Me.btnMenha)
        Me.Controls.Add(Me.btnTaghsim)
        Me.Controls.Add(Me.btnJam)
        Me.Controls.Add(Me.btnAshar)
        Me.Controls.Add(Me.btnPM)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.ntxt)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmCalc"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCalc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        MouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub frmCalc_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim MousePos As Point = Control.MousePosition
            MousePos.Offset(MouseOffset.X, MouseOffset.Y)
            Location = MousePos
        End If
    End Sub

    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = System.Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn1.DoubleClick
        Try
            mText = mText + btn1.Text
            checkOverflow()
            ntxt.Text = Round(CType(mText, Decimal), 10)
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click, btn0.DoubleClick
        Try
            mText = mText + btn0.Text
            checkOverflow()
            ntxt.Text = Round(CType(mText, Decimal), 10)
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click, btn2.DoubleClick
        Try
            mText = mText + btn2.Text
            checkOverflow()
            ntxt.Text = Round(CType(mText, Decimal), 10)
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click, btn3.DoubleClick
        Try
            mText = mText + btn3.Text
            checkOverflow()
            ntxt.Text = Round(CType(mText, Decimal), 10)
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click, btn4.DoubleClick
        Try
            mText = mText + btn4.Text
            checkOverflow()
            ntxt.Text = Round(CType(mText, Decimal), 10)
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click, btn5.DoubleClick
        Try
            mText = mText + btn5.Text
            checkOverflow()
            ntxt.Text = Round(CType(mText, Decimal), 10)
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click, btn6.DoubleClick
        Try
            mText = mText + btn6.Text
            checkOverflow()
            ntxt.Text = Round(CType(mText, Decimal), 10)
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click, btn7.DoubleClick
        Try
            mText = mText + btn7.Text
            checkOverflow()
            ntxt.Text = Round(CType(mText, Decimal), 10)
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click, btn8.DoubleClick
        Try
            mText = mText + btn8.Text
            checkOverflow()
            ntxt.Text = Round(CType(mText, Decimal), 10)
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click, btn9.DoubleClick
        Try
            mText = mText + btn9.Text
            checkOverflow()
            ntxt.Text = Round(CType(mText, Decimal), 10)
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnAshar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAshar.Click, btnAshar.DoubleClick
        If mText = "" Then
            mText = "0"
        End If
        Try
            mText = mText + btnAshar.Text
            'ntxt.Text = Round(CType(mText, Decimal), 10)
            ntxt.Text = mText
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnJam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJam.Click
        Try
            FillFinaltext()
            mOperand = "+"
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnMenha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenha.Click
        Try
            FillFinaltext()
            mOperand = "-"
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnZarb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZarb.Click
        Try
            FillFinaltext()
            mOperand = "*"
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnTaghsim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaghsim.Click
        Try
            FillFinaltext()
            mOperand = "/"
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnMosavi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMosavi.Click
        If mText <> "" Then
            Try
                Select Case mOperand
                    Case "+"
                        FinalText = (CType(FinalText, Decimal) + CType(mText, Decimal)).ToString
                    Case "-"
                        FinalText = (CType(FinalText, Decimal) - CType(mText, Decimal)).ToString
                    Case "*"
                        FinalText = (CType(FinalText, Decimal) * CType(mText, Decimal)).ToString
                    Case "/"
                        Try
                            FinalText = (CType(FinalText, Decimal) / CType(mText, Decimal)).ToString
                        Catch ex As Exception
                            FinalText = 0
                        End Try
                    Case ""
                        FinalText = mText
                End Select
                checkOverflow()
            Catch ex As System.OverflowException
                MsgBox("⁄œœ »“—ê — «“ Õœ „Ã«“ „Ì»«‘œ", , "«Œÿ«—")
                FinalText = "0"
                mText = "0"
            End Try
        End If
        Try
            ntxt.Text = Round(CType(FinalText, Decimal), 10)
            mOperand = ""
            mText = ""

            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        mText = ""
        mOperand = ""
        FinalText = "0"
        ntxt.Text = 0
        Try
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCE.Click
        Try
            mText = ""
            ntxt.Text = 0
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private oCalc As UcCalcText
    Public Property oCalcText() As UcCalcText
        Get
            Return oCalc
        End Get
        Set(ByVal Value As UcCalcText)
            oCalc = Value
        End Set
    End Property

    Private Sub btnDEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDEL.Click
        If Len(ntxt.Text) <= 1 Then
            mText = "0"
            ntxt.Text = Round(CType(mText, Decimal), 10)
        Else
            mText = ntxt.Text.Remove(ntxt.Text.Length - 1, 1)
            If mText = "-" Then
                mText = "0"
            End If
            ntxt.Text = Round(CType(mText, Decimal), 10)
        End If
        Try
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnPM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPM.Click
        Try
            mText = (-1) * CType(ntxt.Text, Decimal)
            ntxt.Text = Round(CType(mText, Decimal), 10)
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If oCalcText.ReadOnly = False Then
            Try
                btnMosavi_Click(sender, e)
                mTemp = Round(CType(FinalText, Decimal), oCalcText.DecimalDigits)
                If mTemp.Length > oCalcText.Maxlength Then
                    MsgBox("ÿÊ· ⁄œœ »Ì‘ — «“ Õœ „Ã«“ «” ", , "«Œÿ«—")
                Else
                    oCalcText.Text = Round(CType(FinalText, Decimal), oCalcText.DecimalDigits)
                    Me.Close()
                End If
            Catch ex As Exception
                ntxt.Text = "0"
                FinalText = "0"
                mText = "0"
            End Try
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frmCalc_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If oCalcText.DefaultSendValue = True Then
            mTemp = Round(CType(FinalText, Decimal), oCalcText.DecimalDigits)
            If mTemp.Length > oCalcText.Maxlength Then
                FinalText = "0"
            End If
            If FinalText = "0" Or FinalText = "" Then
            Else
                oCalcText.Text = Round(CType(FinalText, Decimal), oCalcText.DecimalDigits)
            End If
        End If
    End Sub

    Private Sub frmCalc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ntxt.Focus()
    End Sub

    Private Sub frmCalc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Try
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    'Private Sub btnAshar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAshar.DoubleClick
    '    Try
    '        ntxt.Focus()
    '        ntxt.Select(ntxt.Text.Length, 0)
    '    Catch ex As Exception
    '        ntxt.Text = "0"
    '        FinalText = "0"
    '        mText = "0"
    '    End Try
    'End Sub

    Private Sub btnC_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnC.DoubleClick
        Try
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnCancel_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.DoubleClick
        Try
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnCE_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCE.DoubleClick
        Try
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnDEL_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDEL.DoubleClick
        Try
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnJam_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnJam.DoubleClick
        Try
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try

    End Sub

    Private Sub btnMenha_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMenha.DoubleClick
        Try
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnMosavi_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMosavi.DoubleClick
        Try
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnPM_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPM.DoubleClick
        Try
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnTaghsim_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTaghsim.DoubleClick
        Try
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub btnZarb_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnZarb.DoubleClick
        Try
            ntxt.Focus()
            ntxt.Select(ntxt.Text.Length, 0)
        Catch ex As Exception
            ntxt.Text = "0"
            FinalText = "0"
            mText = "0"
        End Try
    End Sub

    Private Sub FillFinaltext()
        If mText <> "" Then
            If mOperand = "" Then
                FinalText = mText
            Else
                Try
                    Select Case mOperand
                        Case "+"
                            FinalText = (CType(FinalText, Decimal) + CType(mText, Decimal)).ToString
                        Case "-"
                            FinalText = (CType(FinalText, Decimal) - CType(mText, Decimal)).ToString
                        Case "*"
                            FinalText = (CType(FinalText, Decimal) * CType(mText, Decimal)).ToString
                        Case "/"
                            Try
                                FinalText = (CType(FinalText, Decimal) / CType(mText, Decimal)).ToString
                            Catch ex As Exception
                                FinalText = 0
                            End Try
                        Case ""
                            FinalText = mText
                    End Select
                    checkOverflow()
                Catch ex As System.OverflowException
                    MsgBox("⁄œœ »“—ê — «“ Õœ „Ã«“ „Ì»«‘œ", , "«Œÿ«—")
                    ntxt.Text = "0"
                    FinalText = "0"
                    mText = "0"
                End Try
                ntxt.Text = Round(CType(FinalText, Decimal), 10)
            End If
        End If
        mText = ""
    End Sub

    Private Sub ntxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ntxt.KeyUp
        Select Case e.KeyCode
            Case Keys.Add
                mText = ""
            Case Keys.Subtract
                mText = ""
            Case Keys.Multiply
                mText = ""
            Case Keys.Divide
                mText = ""
            Case Keys.Enter
                mText = ""
            Case Else
                mText = ntxt.Text
        End Select
    End Sub

    Private Sub ntxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ntxt.KeyPress
        Select Case e.KeyChar
            Case "+"
                FillFinaltext()
                mOperand = "+"
                ntxt.SelectAll()
                e.Handled = True
            Case "-"
                FillFinaltext()
                mOperand = "-"
                ntxt.SelectAll()
                e.Handled = True
            Case "*"
                FillFinaltext()
                mOperand = "*"
                ntxt.SelectAll()
                e.Handled = True
            Case "/"
                FillFinaltext()
                mOperand = "/"
                ntxt.SelectAll()
                e.Handled = True
            Case Chr(13)
                If mText <> "" Then
                    Try
                        Select Case mOperand
                            Case "+"
                                FinalText = (CType(FinalText, Decimal) + CType(mText, Decimal)).ToString
                            Case "-"
                                FinalText = (CType(FinalText, Decimal) - CType(mText, Decimal)).ToString
                            Case "*"
                                FinalText = (CType(FinalText, Decimal) * CType(mText, Decimal)).ToString
                            Case "/"
                                Try
                                    FinalText = (CType(FinalText, Decimal) / CType(mText, Decimal)).ToString
                                Catch ex As Exception
                                    FinalText = 0
                                End Try
                            Case ""
                                FinalText = mText
                        End Select
                        checkOverflow()
                    Catch ex As System.OverflowException
                        MsgBox("⁄œœ »“—ê — «“ Õœ „Ã«“ „Ì»«‘œ", , "«Œÿ«—")
                        FinalText = "0"
                        mText = "0"
                    End Try
                End If
                Try
                    ntxt.Text = Round(CType(FinalText, Decimal), 10)
                    mOperand = ""
                    mText = ""
                    ntxt.SelectAll()
                Catch ex As Exception
                    ntxt.Text = "0"
                    FinalText = "0"
                    mText = "0"
                End Try
        End Select
    End Sub

    Private Sub checkOverflow()
        If mText.Length > ntxt.MaxLength Then
            MsgBox("⁄œœ »“—ê — «“ Õœ „Ã«“ „Ì»«‘œ", , "«Œÿ«—")
            mText = "0"
        End If
        If FinalText.Length > ntxt.MaxLength Then
            MsgBox("⁄œœ »“—ê — «“ Õœ „Ã«“ „Ì»«‘œ", , "«Œÿ«—")
            FinalText = "0"
        End If
    End Sub

    Private Sub btnNoAshar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoAshar.ValueChanged
        ntxt.DecimalDigits = btnNoAshar.Text
    End Sub

    Private Sub frmCalc_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub
End Class
