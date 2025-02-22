Public Class Frmmenu1
    Inherits FrmBaseMenu
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
    Friend WithEvents UiButton4 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton5 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton6 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton9 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton10 As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnWorkOrder As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnEstimates As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnInvoice As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton8 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton7 As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frmmenu1))
        Me.BtnWorkOrder = New Janus.Windows.EditControls.UIButton
        Me.BtnEstimates = New Janus.Windows.EditControls.UIButton
        Me.BtnInvoice = New Janus.Windows.EditControls.UIButton
        Me.UiButton4 = New Janus.Windows.EditControls.UIButton
        Me.UiButton5 = New Janus.Windows.EditControls.UIButton
        Me.UiButton6 = New Janus.Windows.EditControls.UIButton
        Me.UiButton9 = New Janus.Windows.EditControls.UIButton
        Me.UiButton10 = New Janus.Windows.EditControls.UIButton
        Me.BtnExit = New Janus.Windows.EditControls.UIButton
        Me.UiButton8 = New Janus.Windows.EditControls.UIButton
        Me.UiButton7 = New Janus.Windows.EditControls.UIButton
        Me.SuspendLayout()
        '
        'BtnWorkOrder
        '
        Me.BtnWorkOrder.AllowDrop = True
        Me.BtnWorkOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnWorkOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWorkOrder.Image = CType(resources.GetObject("BtnWorkOrder.Image"), System.Drawing.Image)
        Me.BtnWorkOrder.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.BtnWorkOrder.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnWorkOrder.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.BtnWorkOrder.Location = New System.Drawing.Point(34, 30)
        Me.BtnWorkOrder.Name = "BtnWorkOrder"
        Me.BtnWorkOrder.Size = New System.Drawing.Size(105, 79)
        Me.BtnWorkOrder.TabIndex = 2
        Me.BtnWorkOrder.Text = "Work Order"
        Me.BtnWorkOrder.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near
        Me.BtnWorkOrder.TextVerticalAlignment = Janus.Windows.EditControls.TextAlignment.Far
        '
        'BtnEstimates
        '
        Me.BtnEstimates.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEstimates.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEstimates.Image = CType(resources.GetObject("BtnEstimates.Image"), System.Drawing.Image)
        Me.BtnEstimates.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.BtnEstimates.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnEstimates.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.Far
        Me.BtnEstimates.Location = New System.Drawing.Point(38, 121)
        Me.BtnEstimates.Name = "BtnEstimates"
        Me.BtnEstimates.Size = New System.Drawing.Size(102, 85)
        Me.BtnEstimates.TabIndex = 3
        Me.BtnEstimates.Text = "Estimate"
        Me.BtnEstimates.TextVerticalAlignment = Janus.Windows.EditControls.TextAlignment.Near
        '
        'BtnInvoice
        '
        Me.BtnInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvoice.Image = CType(resources.GetObject("BtnInvoice.Image"), System.Drawing.Image)
        Me.BtnInvoice.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.BtnInvoice.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnInvoice.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.BtnInvoice.Location = New System.Drawing.Point(36, 219)
        Me.BtnInvoice.Name = "BtnInvoice"
        Me.BtnInvoice.Size = New System.Drawing.Size(104, 88)
        Me.BtnInvoice.TabIndex = 4
        Me.BtnInvoice.Text = "Invoice"
        '
        'UiButton4
        '
        Me.UiButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton4.Image = CType(resources.GetObject("UiButton4.Image"), System.Drawing.Image)
        Me.UiButton4.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton4.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton4.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton4.Location = New System.Drawing.Point(148, 31)
        Me.UiButton4.Name = "UiButton4"
        Me.UiButton4.Size = New System.Drawing.Size(121, 80)
        Me.UiButton4.TabIndex = 5
        Me.UiButton4.Text = "Appointment"
        '
        'UiButton5
        '
        Me.UiButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton5.Image = CType(resources.GetObject("UiButton5.Image"), System.Drawing.Image)
        Me.UiButton5.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton5.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton5.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton5.Location = New System.Drawing.Point(146, 122)
        Me.UiButton5.Name = "UiButton5"
        Me.UiButton5.Size = New System.Drawing.Size(123, 85)
        Me.UiButton5.TabIndex = 6
        Me.UiButton5.Text = "Pricing And Avaliability"
        Me.UiButton5.TextVerticalAlignment = Janus.Windows.EditControls.TextAlignment.Near
        '
        'UiButton6
        '
        Me.UiButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton6.Image = CType(resources.GetObject("UiButton6.Image"), System.Drawing.Image)
        Me.UiButton6.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton6.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton6.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton6.Location = New System.Drawing.Point(145, 219)
        Me.UiButton6.Name = "UiButton6"
        Me.UiButton6.Size = New System.Drawing.Size(125, 90)
        Me.UiButton6.TabIndex = 7
        Me.UiButton6.Text = "Recieve Payment"
        '
        'UiButton9
        '
        Me.UiButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton9.Image = CType(resources.GetObject("UiButton9.Image"), System.Drawing.Image)
        Me.UiButton9.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton9.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton9.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton9.Location = New System.Drawing.Point(276, 123)
        Me.UiButton9.Name = "UiButton9"
        Me.UiButton9.Size = New System.Drawing.Size(122, 84)
        Me.UiButton9.TabIndex = 10
        Me.UiButton9.Text = "Sales Audit Summary"
        '
        'UiButton10
        '
        Me.UiButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton10.Image = CType(resources.GetObject("UiButton10.Image"), System.Drawing.Image)
        Me.UiButton10.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton10.ImageSize = New System.Drawing.Size(64, 64)
        Me.UiButton10.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton10.Location = New System.Drawing.Point(420, 32)
        Me.UiButton10.Name = "UiButton10"
        Me.UiButton10.Size = New System.Drawing.Size(91, 211)
        Me.UiButton10.TabIndex = 11
        Me.UiButton10.Text = "Close The Day"
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnExit.Location = New System.Drawing.Point(436, 263)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(64, 43)
        Me.BtnExit.TabIndex = 12
        Me.BtnExit.Text = "Exit"
        '
        'UiButton8
        '
        Me.UiButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton8.Image = CType(resources.GetObject("UiButton8.Image"), System.Drawing.Image)
        Me.UiButton8.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton8.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton8.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton8.Location = New System.Drawing.Point(276, 215)
        Me.UiButton8.Name = "UiButton8"
        Me.UiButton8.Size = New System.Drawing.Size(122, 94)
        Me.UiButton8.TabIndex = 13
        Me.UiButton8.Text = "Recieve Product"
        '
        'UiButton7
        '
        Me.UiButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiButton7.Image = CType(resources.GetObject("UiButton7.Image"), System.Drawing.Image)
        Me.UiButton7.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton7.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton7.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton7.Location = New System.Drawing.Point(276, 31)
        Me.UiButton7.Name = "UiButton7"
        Me.UiButton7.Size = New System.Drawing.Size(122, 83)
        Me.UiButton7.TabIndex = 14
        Me.UiButton7.Text = "Make Deposits"
        '
        'Frmmenu1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(542, 325)
        Me.Controls.Add(Me.UiButton7)
        Me.Controls.Add(Me.UiButton8)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnEstimates)
        Me.Controls.Add(Me.UiButton10)
        Me.Controls.Add(Me.UiButton9)
        Me.Controls.Add(Me.UiButton6)
        Me.Controls.Add(Me.UiButton5)
        Me.Controls.Add(Me.UiButton4)
        Me.Controls.Add(Me.BtnInvoice)
        Me.Controls.Add(Me.BtnWorkOrder)
        Me.Name = "Frmmenu1"
        Me.Controls.SetChildIndex(Me.BtnWorkOrder, 0)
        Me.Controls.SetChildIndex(Me.BtnInvoice, 0)
        Me.Controls.SetChildIndex(Me.UiButton4, 0)
        Me.Controls.SetChildIndex(Me.UiButton5, 0)
        Me.Controls.SetChildIndex(Me.UiButton6, 0)
        Me.Controls.SetChildIndex(Me.UiButton9, 0)
        Me.Controls.SetChildIndex(Me.UiButton10, 0)
        Me.Controls.SetChildIndex(Me.BtnEstimates, 0)
        Me.Controls.SetChildIndex(Me.BtnExit, 0)
        Me.Controls.SetChildIndex(Me.UiButton8, 0)
        Me.Controls.SetChildIndex(Me.UiButton7, 0)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub BtnWorkOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWorkOrder.Click
        Dim ThisFrmName As New ServiceCenterScreen.FrmWorkOrders ' 301010000
        ThisFrmName.TypeOfForm = "WO"
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub BtnEstimates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEstimates.Click
        Dim ThisFrmName As New ServiceCenterScreen.FrmWorkOrders ' 301020000
        ThisFrmName.TypeOfForm = "ES"
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub BtnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoice.Click
        Dim ThisFrmName As New ServiceCenterScreen.FrmWorkOrders ' 301030000
        ThisFrmName.TypeOfForm = "IN"
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton7.Click
        Dim ThisFrmName As New UCBankAccount.FrmBankDeposits
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton6.Click
        Dim ThisFrmName As New UCCustomer.FrmReceivePayment
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton8.Click
        Dim ThisFrmName As New UcReceiveReturnProduct.FrmReceiveReturnProduct
        ThisFrmName.BillCredit = "1"
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton10.Click
        Dim ThisFrmName As New UcAccount.FrmCloseDay
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton9.Click
        Dim ThisFrmName As New UCBankAccount.FrmEndOfDay
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton5.Click
        Dim ThisFrmName As New UCInv_Item.FrmSearchItemCode
        SHOWMYFORM(ThisFrmName)
    End Sub
End Class
