<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNumbers
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
        lblFrench = New Label()
        btnOne = New Button()
        btnTwo = New Button()
        btnThree = New Button()
        btnFour = New Button()
        btnFive = New Button()
        SuspendLayout()
        ' 
        ' lblFrench
        ' 
        lblFrench.AutoSize = True
        lblFrench.Location = New Point(226, 52)
        lblFrench.Name = "lblFrench"
        lblFrench.Size = New Size(259, 45)
        lblFrench.TabIndex = 0
        lblFrench.Text = "Do you know the French words for the numbers" & vbCrLf & "1 through 5?" & vbCrLf & "Click the buttons below to see them."
        ' 
        ' btnOne
        ' 
        btnOne.Location = New Point(53, 108)
        btnOne.Name = "btnOne"
        btnOne.Size = New Size(75, 23)
        btnOne.TabIndex = 1
        btnOne.Text = "1"
        btnOne.UseVisualStyleBackColor = True
        ' 
        ' btnTwo
        ' 
        btnTwo.Location = New Point(134, 108)
        btnTwo.Name = "btnTwo"
        btnTwo.Size = New Size(75, 23)
        btnTwo.TabIndex = 2
        btnTwo.Text = "2"
        btnTwo.UseVisualStyleBackColor = True
        ' 
        ' btnThree
        ' 
        btnThree.Location = New Point(215, 108)
        btnThree.Name = "btnThree"
        btnThree.Size = New Size(75, 23)
        btnThree.TabIndex = 3
        btnThree.Text = "3"
        btnThree.UseVisualStyleBackColor = True
        ' 
        ' btnFour
        ' 
        btnFour.Location = New Point(296, 108)
        btnFour.Name = "btnFour"
        btnFour.Size = New Size(75, 23)
        btnFour.TabIndex = 4
        btnFour.Text = "4"
        btnFour.UseVisualStyleBackColor = True
        ' 
        ' btnFive
        ' 
        btnFive.Location = New Point(377, 108)
        btnFive.Name = "btnFive"
        btnFive.Size = New Size(75, 23)
        btnFive.TabIndex = 5
        btnFive.Text = "5"
        btnFive.UseVisualStyleBackColor = True
        ' 
        ' frmNumbers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnFive)
        Controls.Add(btnFour)
        Controls.Add(btnThree)
        Controls.Add(btnTwo)
        Controls.Add(btnOne)
        Controls.Add(lblFrench)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmNumbers"
        StartPosition = FormStartPosition.CenterScreen
        Text = "French Numbers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFrench As Label
    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button

End Class
