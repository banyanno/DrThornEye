﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddInvestigate
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddInvestigate))
        Me.LblWaitingID = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtFree = New System.Windows.Forms.TextBox
        Me.CboInvestigate = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrInvestigage = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrInvestigage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblWaitingID
        '
        Me.LblWaitingID.AutoSize = True
        Me.LblWaitingID.Location = New System.Drawing.Point(13, 124)
        Me.LblWaitingID.Name = "LblWaitingID"
        Me.LblWaitingID.Size = New System.Drawing.Size(13, 13)
        Me.LblWaitingID.TabIndex = 10
        Me.LblWaitingID.Text = "0"
        Me.LblWaitingID.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.HospitalMS.My.Resources.Resources.mZihS
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(305, 115)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 31)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.BackgroundImage = Global.HospitalMS.My.Resources.Resources.mZihS
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(224, 115)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 31)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtFree)
        Me.GroupBox1.Controls.Add(Me.CboInvestigate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 105)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laser Fee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "$"
        '
        'TxtFree
        '
        Me.TxtFree.BackColor = System.Drawing.Color.White
        Me.TxtFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFree.Location = New System.Drawing.Point(121, 66)
        Me.TxtFree.Name = "TxtFree"
        Me.TxtFree.ReadOnly = True
        Me.TxtFree.Size = New System.Drawing.Size(229, 26)
        Me.TxtFree.TabIndex = 1
        '
        'CboInvestigate
        '
        Me.CboInvestigate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboInvestigate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboInvestigate.DropDownHeight = 250
        Me.CboInvestigate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvestigate.FormattingEnabled = True
        Me.CboInvestigate.IntegralHeight = False
        Me.CboInvestigate.Location = New System.Drawing.Point(121, 22)
        Me.CboInvestigate.Name = "CboInvestigate"
        Me.CboInvestigate.Size = New System.Drawing.Size(229, 28)
        Me.CboInvestigate.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Price:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Investage:"
        '
        'ErrInvestigage
        '
        Me.ErrInvestigage.ContainerControl = Me
        '
        'AddInvestigate
        '
        Me.AcceptButton = Me.BtnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(393, 149)
        Me.Controls.Add(Me.LblWaitingID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddInvestigate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Investigate"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrInvestigage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblWaitingID As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtFree As System.Windows.Forms.TextBox
    Friend WithEvents CboInvestigate As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrInvestigage As System.Windows.Forms.ErrorProvider
End Class
