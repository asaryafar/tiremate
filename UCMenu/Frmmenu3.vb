Public Class Frmmenu3
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
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton3 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton4 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton5 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton6 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton7 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton8 As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnExit As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frmmenu3))
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        Me.UiButton2 = New Janus.Windows.EditControls.UIButton
        Me.UiButton3 = New Janus.Windows.EditControls.UIButton
        Me.UiButton4 = New Janus.Windows.EditControls.UIButton
        Me.UiButton5 = New Janus.Windows.EditControls.UIButton
        Me.UiButton6 = New Janus.Windows.EditControls.UIButton
        Me.UiButton7 = New Janus.Windows.EditControls.UIButton
        Me.UiButton8 = New Janus.Windows.EditControls.UIButton
        Me.BtnExit = New Janus.Windows.EditControls.UIButton
        Me.SuspendLayout()
        '
        'UiButton1
        '
        Me.UiButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton1.Image = CType(resources.GetObject("UiButton1.Image"), System.Drawing.Image)
        Me.UiButton1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton1.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton1.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton1.Location = New System.Drawing.Point(71, 45)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(96, 92)
        Me.UiButton1.TabIndex = 2
        Me.UiButton1.Tag = System.Windows.Forms.Cursors.Hand
        Me.UiButton1.Text = "Products"
        '
        'UiButton2
        '
        Me.UiButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton2.Image = CType(resources.GetObject("UiButton2.Image"), System.Drawing.Image)
        Me.UiButton2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton2.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton2.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton2.Location = New System.Drawing.Point(72, 143)
        Me.UiButton2.Name = "UiButton2"
        Me.UiButton2.Size = New System.Drawing.Size(95, 94)
        Me.UiButton2.TabIndex = 3
        Me.UiButton2.Text = "Recieve Product"
        '
        'UiButton3
        '
        Me.UiButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton3.Image = CType(resources.GetObject("UiButton3.Image"), System.Drawing.Image)
        Me.UiButton3.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton3.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton3.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton3.Location = New System.Drawing.Point(74, 244)
        Me.UiButton3.Name = "UiButton3"
        Me.UiButton3.Size = New System.Drawing.Size(93, 93)
        Me.UiButton3.TabIndex = 4
        Me.UiButton3.Text = "Order Product"
        '
        'UiButton4
        '
        Me.UiButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton4.Image = CType(resources.GetObject("UiButton4.Image"), System.Drawing.Image)
        Me.UiButton4.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton4.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton4.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton4.Location = New System.Drawing.Point(186, 47)
        Me.UiButton4.Name = "UiButton4"
        Me.UiButton4.Size = New System.Drawing.Size(105, 88)
        Me.UiButton4.TabIndex = 5
        Me.UiButton4.Text = "Return Product"
        '
        'UiButton5
        '
        Me.UiButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton5.Image = CType(resources.GetObject("UiButton5.Image"), System.Drawing.Image)
        Me.UiButton5.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton5.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton5.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton5.Location = New System.Drawing.Point(186, 143)
        Me.UiButton5.Name = "UiButton5"
        Me.UiButton5.Size = New System.Drawing.Size(104, 88)
        Me.UiButton5.TabIndex = 6
        Me.UiButton5.Text = "Services And Fees"
        '
        'UiButton6
        '
        Me.UiButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton6.Image = CType(resources.GetObject("UiButton6.Image"), System.Drawing.Image)
        Me.UiButton6.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton6.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton6.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton6.Location = New System.Drawing.Point(185, 247)
        Me.UiButton6.Name = "UiButton6"
        Me.UiButton6.Size = New System.Drawing.Size(105, 90)
        Me.UiButton6.TabIndex = 7
        Me.UiButton6.Text = "Adjust Quantities"
        '
        'UiButton7
        '
        Me.UiButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton7.Image = CType(resources.GetObject("UiButton7.Image"), System.Drawing.Image)
        Me.UiButton7.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton7.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton7.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton7.Location = New System.Drawing.Point(304, 48)
        Me.UiButton7.Name = "UiButton7"
        Me.UiButton7.Size = New System.Drawing.Size(108, 82)
        Me.UiButton7.TabIndex = 8
        Me.UiButton7.Text = "Count Product"
        '
        'UiButton8
        '
        Me.UiButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton8.Image = CType(resources.GetObject("UiButton8.Image"), System.Drawing.Image)
        Me.UiButton8.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton8.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton8.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton8.Location = New System.Drawing.Point(306, 143)
        Me.UiButton8.Name = "UiButton8"
        Me.UiButton8.Size = New System.Drawing.Size(106, 88)
        Me.UiButton8.TabIndex = 9
        Me.UiButton8.Text = "Snapshot Products"
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnExit.Location = New System.Drawing.Point(322, 277)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(64, 43)
        Me.BtnExit.TabIndex = 10
        Me.BtnExit.Text = "Exit"
        '
        'Frmmenu3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(444, 396)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.UiButton8)
        Me.Controls.Add(Me.UiButton7)
        Me.Controls.Add(Me.UiButton6)
        Me.Controls.Add(Me.UiButton5)
        Me.Controls.Add(Me.UiButton4)
        Me.Controls.Add(Me.UiButton3)
        Me.Controls.Add(Me.UiButton2)
        Me.Controls.Add(Me.UiButton1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmmenu3"
        Me.Text = "Product Menu"
        Me.Controls.SetChildIndex(Me.UiButton1, 0)
        Me.Controls.SetChildIndex(Me.UiButton2, 0)
        Me.Controls.SetChildIndex(Me.UiButton3, 0)
        Me.Controls.SetChildIndex(Me.UiButton4, 0)
        Me.Controls.SetChildIndex(Me.UiButton5, 0)
        Me.Controls.SetChildIndex(Me.UiButton6, 0)
        Me.Controls.SetChildIndex(Me.UiButton7, 0)
        Me.Controls.SetChildIndex(Me.UiButton8, 0)
        Me.Controls.SetChildIndex(Me.BtnExit, 0)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub UiButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton5.Click
        Dim ThisFrmName As New UCLabor_Service.FrmLabor_Service
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton2.Click
        Dim ThisFrmName As New UcReceiveReturnProduct.FrmReceiveReturnProduct
        ThisFrmName.BillCredit = "1"
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton4.Click
        Dim ThisFrmName As New UcReceiveReturnProduct.FrmReceiveReturnProduct
        ThisFrmName.BillCredit = "2"
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton3.Click
        Dim ThisFrmName As New UcPurchaseOrder.FrmPurchaseOrder
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        Dim ThisFrmName As New UCInv_Item.FrmItemProduct
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton6.Click
        Dim ThisFrmName As New UCInv_Item.FrmInventoryAdjustment
        SHOWMYFORM(ThisFrmName)
    End Sub
End Class
