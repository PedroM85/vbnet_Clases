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
        Me.Cliente_get = New System.Windows.Forms.Button()
        Me.Alta = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Cliente_get
        '
        Me.Cliente_get.Location = New System.Drawing.Point(461, 52)
        Me.Cliente_get.Name = "Cliente_get"
        Me.Cliente_get.Size = New System.Drawing.Size(163, 23)
        Me.Cliente_get.TabIndex = 0
        Me.Cliente_get.Text = "Cliente_get"
        Me.Cliente_get.UseVisualStyleBackColor = True
        '
        'Alta
        '
        Me.Alta.Location = New System.Drawing.Point(461, 110)
        Me.Alta.Name = "Alta"
        Me.Alta.Size = New System.Drawing.Size(163, 23)
        Me.Alta.TabIndex = 1
        Me.Alta.Text = "Alta operaciones"
        Me.Alta.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(461, 81)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Operaciones_get(id)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Alta)
        Me.Controls.Add(Me.Cliente_get)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cliente_get As Button
    Friend WithEvents Alta As Button
    Friend WithEvents Button3 As Button
End Class
