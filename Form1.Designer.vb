<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnInput = New System.Windows.Forms.Button()
        Me.mygrid = New UJGrid.UJGrid()
        Me.btnDis = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.txtDisplay1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(13, 59)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(230, 23)
        Me.btnInput.TabIndex = 0
        Me.btnInput.Text = "Input villain"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'mygrid
        '
        Me.mygrid.FixedCols = 1
        Me.mygrid.FixedRows = 1
        Me.mygrid.Location = New System.Drawing.Point(280, 19)
        Me.mygrid.Name = "mygrid"
        Me.mygrid.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.mygrid.Size = New System.Drawing.Size(497, 150)
        Me.mygrid.TabIndex = 3
        '
        'btnDis
        '
        Me.btnDis.Location = New System.Drawing.Point(16, 100)
        Me.btnDis.Name = "btnDis"
        Me.btnDis.Size = New System.Drawing.Size(227, 23)
        Me.btnDis.TabIndex = 5
        Me.btnDis.Text = "Display Recored data"
        Me.btnDis.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(280, 403)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(497, 20)
        Me.txtDisplay.TabIndex = 6
        '
        'txtDisplay1
        '
        Me.txtDisplay1.Location = New System.Drawing.Point(280, 209)
        Me.txtDisplay1.Multiline = True
        Me.txtDisplay1.Name = "txtDisplay1"
        Me.txtDisplay1.Size = New System.Drawing.Size(497, 188)
        Me.txtDisplay1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDisplay1)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnDis)
        Me.Controls.Add(Me.mygrid)
        Me.Controls.Add(Me.btnInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInput As Button
    Friend WithEvents mygrid As UJGrid.UJGrid
    Friend WithEvents btnDis As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents txtDisplay1 As TextBox
End Class
