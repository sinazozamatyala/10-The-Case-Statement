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
        btnCompute = New Button()
        ComboBox1 = New ComboBox()
        lblEnterGrade = New Label()
        lblResults = New Label()
        txtResults = New TextBox()
        SuspendLayout()
        ' 
        ' btnCompute
        ' 
        btnCompute.Location = New Point(149, 318)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(94, 29)
        btnCompute.TabIndex = 0
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(432, 46)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 1
        ' 
        ' lblEnterGrade
        ' 
        lblEnterGrade.AutoSize = True
        lblEnterGrade.Location = New Point(266, 57)
        lblEnterGrade.Name = "lblEnterGrade"
        lblEnterGrade.Size = New Size(159, 20)
        lblEnterGrade.TabIndex = 2
        lblEnterGrade.Text = "Enter the Grade Lettter"
        ' 
        ' lblResults
        ' 
        lblResults.AutoSize = True
        lblResults.Location = New Point(297, 146)
        lblResults.Name = "lblResults"
        lblResults.Size = New Size(55, 20)
        lblResults.TabIndex = 3
        lblResults.Text = "Results"
        ' 
        ' txtResults
        ' 
        txtResults.Location = New Point(432, 139)
        txtResults.Name = "txtResults"
        txtResults.Size = New Size(223, 27)
        txtResults.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lime
        ClientSize = New Size(800, 450)
        Controls.Add(txtResults)
        Controls.Add(lblResults)
        Controls.Add(lblEnterGrade)
        Controls.Add(ComboBox1)
        Controls.Add(btnCompute)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCompute As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblEnterGrade As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents txtResults As TextBox

End Class
