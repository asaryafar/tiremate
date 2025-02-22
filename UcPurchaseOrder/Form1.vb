Public Class Form1
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents CommentButton1 As UCCommentButton.CommentButton
    Friend WithEvents ItemNo1 As UCInv_Item.ItemNo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.CommentButton1 = New UCCommentButton.CommentButton
        Me.ItemNo1 = New UCInv_Item.ItemNo
        Me.SuspendLayout()
        '
        'CommentButton1
        '
        Me.CommentButton1.Location = New System.Drawing.Point(232, 32)
        Me.CommentButton1.Name = "CommentButton1"
        Me.CommentButton1.Size = New System.Drawing.Size(102, 23)
        Me.CommentButton1.TabIndex = 0
        Me.CommentButton1.ZButtonText = Nothing
        Me.CommentButton1.ZCommentFormheight = 0
        Me.CommentButton1.ZCommentFormWidth = 0
        Me.CommentButton1.ZCommentText = Nothing
        Me.CommentButton1.ZEnabled = True
        Me.CommentButton1.ZMaxCommentLength = 32767
        Me.CommentButton1.ZShowInLeft = False
        Me.CommentButton1.ZShowInTop = False
        '
        'ItemNo1
        '
        Me.ItemNo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemNo1.Connection = Nothing
        Me.ItemNo1.ItemNo = ""
        Me.ItemNo1.ItemNoLen = 20
        Me.ItemNo1.Location = New System.Drawing.Point(224, 80)
        Me.ItemNo1.Name = "ItemNo1"
        Me.ItemNo1.NotExitIfNotFound = False
        Me.ItemNo1.ReleaseIfNotFoundItemNo = False
        Me.ItemNo1.Size = New System.Drawing.Size(101, 20)
        Me.ItemNo1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.ItemNo1)
        Me.Controls.Add(Me.CommentButton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
