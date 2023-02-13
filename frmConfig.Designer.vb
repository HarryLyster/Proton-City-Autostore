<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.pbYearlySales = New System.Windows.Forms.PictureBox()
        Me.pbUpdateUser = New System.Windows.Forms.PictureBox()
        Me.pbNewOrder = New System.Windows.Forms.PictureBox()
        Me.pbNewInvoice = New System.Windows.Forms.PictureBox()
        Me.pbNewUser = New System.Windows.Forms.PictureBox()
        Me.pbNewClient = New System.Windows.Forms.PictureBox()
        CType(Me.pbYearlySales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUpdateUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNewOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNewInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNewClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbYearlySales
        '
        Me.pbYearlySales.Image = CType(resources.GetObject("pbYearlySales.Image"), System.Drawing.Image)
        Me.pbYearlySales.Location = New System.Drawing.Point(547, 199)
        Me.pbYearlySales.Name = "pbYearlySales"
        Me.pbYearlySales.Size = New System.Drawing.Size(169, 84)
        Me.pbYearlySales.TabIndex = 5
        Me.pbYearlySales.TabStop = False
        '
        'pbUpdateUser
        '
        Me.pbUpdateUser.Image = CType(resources.GetObject("pbUpdateUser.Image"), System.Drawing.Image)
        Me.pbUpdateUser.Location = New System.Drawing.Point(25, 199)
        Me.pbUpdateUser.Name = "pbUpdateUser"
        Me.pbUpdateUser.Size = New System.Drawing.Size(169, 84)
        Me.pbUpdateUser.TabIndex = 4
        Me.pbUpdateUser.TabStop = False
        '
        'pbNewOrder
        '
        Me.pbNewOrder.Image = CType(resources.GetObject("pbNewOrder.Image"), System.Drawing.Image)
        Me.pbNewOrder.Location = New System.Drawing.Point(547, 63)
        Me.pbNewOrder.Name = "pbNewOrder"
        Me.pbNewOrder.Size = New System.Drawing.Size(169, 84)
        Me.pbNewOrder.TabIndex = 3
        Me.pbNewOrder.TabStop = False
        '
        'pbNewInvoice
        '
        Me.pbNewInvoice.Image = CType(resources.GetObject("pbNewInvoice.Image"), System.Drawing.Image)
        Me.pbNewInvoice.Location = New System.Drawing.Point(281, 63)
        Me.pbNewInvoice.Name = "pbNewInvoice"
        Me.pbNewInvoice.Size = New System.Drawing.Size(169, 84)
        Me.pbNewInvoice.TabIndex = 2
        Me.pbNewInvoice.TabStop = False
        '
        'pbNewUser
        '
        Me.pbNewUser.Image = CType(resources.GetObject("pbNewUser.Image"), System.Drawing.Image)
        Me.pbNewUser.Location = New System.Drawing.Point(281, 199)
        Me.pbNewUser.Name = "pbNewUser"
        Me.pbNewUser.Size = New System.Drawing.Size(169, 84)
        Me.pbNewUser.TabIndex = 1
        Me.pbNewUser.TabStop = False
        '
        'pbNewClient
        '
        Me.pbNewClient.Image = CType(resources.GetObject("pbNewClient.Image"), System.Drawing.Image)
        Me.pbNewClient.Location = New System.Drawing.Point(25, 63)
        Me.pbNewClient.Name = "pbNewClient"
        Me.pbNewClient.Size = New System.Drawing.Size(169, 84)
        Me.pbNewClient.TabIndex = 0
        Me.pbNewClient.TabStop = False
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 339)
        Me.Controls.Add(Me.pbYearlySales)
        Me.Controls.Add(Me.pbUpdateUser)
        Me.Controls.Add(Me.pbNewOrder)
        Me.Controls.Add(Me.pbNewInvoice)
        Me.Controls.Add(Me.pbNewUser)
        Me.Controls.Add(Me.pbNewClient)
        Me.Name = "frmConfig"
        Me.Text = "frmConfig"
        CType(Me.pbYearlySales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUpdateUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNewOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNewInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNewUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNewClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbNewClient As PictureBox
    Friend WithEvents pbNewUser As PictureBox
    Friend WithEvents pbNewInvoice As PictureBox
    Friend WithEvents pbNewOrder As PictureBox
    Friend WithEvents pbUpdateUser As PictureBox
    Friend WithEvents pbYearlySales As PictureBox
End Class
