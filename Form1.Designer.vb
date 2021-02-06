<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClickableNumberImages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClickableNumberImages))
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.picOne = New System.Windows.Forms.PictureBox()
        Me.picTwo = New System.Windows.Forms.PictureBox()
        Me.picThree = New System.Windows.Forms.PictureBox()
        Me.picFour = New System.Windows.Forms.PictureBox()
        Me.picFive = New System.Windows.Forms.PictureBox()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInstructions.BackColor = System.Drawing.Color.Transparent
        Me.lblInstructions.Font = New System.Drawing.Font("OCR A Extended", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblInstructions.Location = New System.Drawing.Point(95, 18)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(633, 93)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Click each number to display its name in English."
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picOne
        '
        Me.picOne.Image = CType(resources.GetObject("picOne.Image"), System.Drawing.Image)
        Me.picOne.InitialImage = Nothing
        Me.picOne.Location = New System.Drawing.Point(23, 138)
        Me.picOne.Name = "picOne"
        Me.picOne.Size = New System.Drawing.Size(80, 144)
        Me.picOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picOne.TabIndex = 1
        Me.picOne.TabStop = False
        '
        'picTwo
        '
        Me.picTwo.Image = CType(resources.GetObject("picTwo.Image"), System.Drawing.Image)
        Me.picTwo.Location = New System.Drawing.Point(184, 209)
        Me.picTwo.Name = "picTwo"
        Me.picTwo.Size = New System.Drawing.Size(80, 144)
        Me.picTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picTwo.TabIndex = 2
        Me.picTwo.TabStop = False
        '
        'picThree
        '
        Me.picThree.Image = CType(resources.GetObject("picThree.Image"), System.Drawing.Image)
        Me.picThree.Location = New System.Drawing.Point(355, 138)
        Me.picThree.Name = "picThree"
        Me.picThree.Size = New System.Drawing.Size(80, 144)
        Me.picThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picThree.TabIndex = 3
        Me.picThree.TabStop = False
        '
        'picFour
        '
        Me.picFour.Image = CType(resources.GetObject("picFour.Image"), System.Drawing.Image)
        Me.picFour.Location = New System.Drawing.Point(524, 209)
        Me.picFour.Name = "picFour"
        Me.picFour.Size = New System.Drawing.Size(80, 144)
        Me.picFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picFour.TabIndex = 4
        Me.picFour.TabStop = False
        '
        'picFive
        '
        Me.picFive.Image = CType(resources.GetObject("picFive.Image"), System.Drawing.Image)
        Me.picFive.Location = New System.Drawing.Point(696, 138)
        Me.picFive.Name = "picFive"
        Me.picFive.Size = New System.Drawing.Size(80, 144)
        Me.picFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picFive.TabIndex = 5
        Me.picFive.TabStop = False
        '
        'frmClickableNumberImages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 435)
        Me.Controls.Add(Me.picFive)
        Me.Controls.Add(Me.picFour)
        Me.Controls.Add(Me.picThree)
        Me.Controls.Add(Me.picTwo)
        Me.Controls.Add(Me.picOne)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "frmClickableNumberImages"
        Me.Text = "Clickable Number Images"
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstructions As Label
    Friend WithEvents picOne As PictureBox
    Friend WithEvents picTwo As PictureBox
    Friend WithEvents picThree As PictureBox
    Friend WithEvents picFour As PictureBox
    Friend WithEvents picFive As PictureBox
End Class
