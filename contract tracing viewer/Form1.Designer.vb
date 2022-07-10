<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl1 = New System.Windows.Forms.ListBox()
        Me.txtmybox = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.FormattingEnabled = True
        Me.lbl1.ItemHeight = 15
        Me.lbl1.Location = New System.Drawing.Point(12, 12)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(303, 289)
        Me.lbl1.TabIndex = 0
        '
        'txtmybox
        '
        Me.txtmybox.Location = New System.Drawing.Point(12, 327)
        Me.txtmybox.Multiline = True
        Me.txtmybox.Name = "txtmybox"
        Me.txtmybox.Size = New System.Drawing.Size(303, 92)
        Me.txtmybox.TabIndex = 1
        '
        'btnsearch
        '
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Location = New System.Drawing.Point(359, 214)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(107, 87)
        Me.btnsearch.TabIndex = 2
        Me.btnsearch.Text = "search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtmybox)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1 As ListBox
    Friend WithEvents txtmybox As TextBox
    Friend WithEvents btnsearch As Button
End Class
