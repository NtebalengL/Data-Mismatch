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
        btnMis = New Button()
        SuspendLayout()
        ' 
        ' btnMis
        ' 
        btnMis.BackColor = SystemColors.ControlDark
        btnMis.Location = New Point(226, 125)
        btnMis.Name = "btnMis"
        btnMis.Size = New Size(288, 118)
        btnMis.TabIndex = 0
        btnMis.Text = "Is it matching?"
        btnMis.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnMis)
        ForeColor = Color.Coral
        Name = "Form1"
        Text = "Data Mismatch"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnMis As Button
End Class
