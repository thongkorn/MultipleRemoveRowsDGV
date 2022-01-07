<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemoveRow
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMethod1 = New System.Windows.Forms.Button()
        Me.btnData = New System.Windows.Forms.Button()
        Me.btnMethod2 = New System.Windows.Forms.Button()
        Me.btnMethod3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 26
        Me.DataGridView1.Size = New System.Drawing.Size(686, 366)
        Me.DataGridView1.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(584, 373)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        '
        'btnMethod1
        '
        Me.btnMethod1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMethod1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMethod1.Location = New System.Drawing.Point(254, 373)
        Me.btnMethod1.Name = "btnMethod1"
        Me.btnMethod1.Size = New System.Drawing.Size(104, 30)
        Me.btnMethod1.TabIndex = 2
        Me.btnMethod1.Text = "Remove I"
        '
        'btnData
        '
        Me.btnData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnData.Location = New System.Drawing.Point(144, 373)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(104, 30)
        Me.btnData.TabIndex = 1
        Me.btnData.Text = "Sample Data"
        '
        'btnMethod2
        '
        Me.btnMethod2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMethod2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMethod2.Location = New System.Drawing.Point(364, 373)
        Me.btnMethod2.Name = "btnMethod2"
        Me.btnMethod2.Size = New System.Drawing.Size(104, 30)
        Me.btnMethod2.TabIndex = 3
        Me.btnMethod2.Text = "Remove II"
        '
        'btnMethod3
        '
        Me.btnMethod3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMethod3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMethod3.Location = New System.Drawing.Point(474, 373)
        Me.btnMethod3.Name = "btnMethod3"
        Me.btnMethod3.Size = New System.Drawing.Size(104, 30)
        Me.btnMethod3.TabIndex = 4
        Me.btnMethod3.Text = "Remove III"
        '
        'frmRemoveRow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 408)
        Me.Controls.Add(Me.btnMethod3)
        Me.Controls.Add(Me.btnMethod2)
        Me.Controls.Add(Me.btnData)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMethod1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmRemoveRow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple Remove Rows in DataGridView - coDe bY: Thongkorn Tubtimkrob"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnMethod1 As System.Windows.Forms.Button
    Friend WithEvents btnData As System.Windows.Forms.Button
    Friend WithEvents btnMethod2 As System.Windows.Forms.Button
    Friend WithEvents btnMethod3 As System.Windows.Forms.Button

End Class
