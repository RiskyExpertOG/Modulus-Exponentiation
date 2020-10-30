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
		Me.base = New System.Windows.Forms.TextBox()
		Me.res = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.exp = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.modu = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'base
		'
		Me.base.Location = New System.Drawing.Point(12, 12)
		Me.base.Name = "base"
		Me.base.Size = New System.Drawing.Size(1253, 20)
		Me.base.TabIndex = 0
		'
		'res
		'
		Me.res.AutoSize = True
		Me.res.Location = New System.Drawing.Point(31, 113)
		Me.res.Name = "res"
		Me.res.Size = New System.Drawing.Size(37, 13)
		Me.res.TabIndex = 1
		Me.res.Text = "Result"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(12, 129)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(1253, 23)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "Go"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'exp
		'
		Me.exp.Location = New System.Drawing.Point(12, 51)
		Me.exp.Name = "exp"
		Me.exp.Size = New System.Drawing.Size(1253, 20)
		Me.exp.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 35)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(13, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "^"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 74)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(27, 13)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "mod"
		'
		'modu
		'
		Me.modu.Location = New System.Drawing.Point(12, 90)
		Me.modu.Name = "modu"
		Me.modu.Size = New System.Drawing.Size(1253, 20)
		Me.modu.TabIndex = 6
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(12, 113)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(13, 13)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "="
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1277, 161)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.modu)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.exp)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.res)
		Me.Controls.Add(Me.base)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents base As TextBox
	Friend WithEvents res As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents exp As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents modu As TextBox
	Friend WithEvents Label4 As Label
End Class
