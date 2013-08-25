<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReportForm
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
        Me.itemizedLabel = New System.Windows.Forms.Label()
        Me.outputListBox = New System.Windows.Forms.ListBox()
        Me.grossLabel = New System.Windows.Forms.Label()
        Me.grossSalesLabel = New System.Windows.Forms.Label()
        Me.itemLabel = New System.Windows.Forms.Label()
        Me.mondayLabel = New System.Windows.Forms.Label()
        Me.tuesdayLabel = New System.Windows.Forms.Label()
        Me.wednesdayLabel = New System.Windows.Forms.Label()
        Me.thursdayLabel = New System.Windows.Forms.Label()
        Me.fridayLabel = New System.Windows.Forms.Label()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.itemTextBox = New System.Windows.Forms.TextBox()
        Me.mondayTextBox = New System.Windows.Forms.TextBox()
        Me.tuesdayTextBox = New System.Windows.Forms.TextBox()
        Me.wednesdayTextBox = New System.Windows.Forms.TextBox()
        Me.thursdayTextBox = New System.Windows.Forms.TextBox()
        Me.fridayTextBox = New System.Windows.Forms.TextBox()
        Me.inputGroupBox = New System.Windows.Forms.GroupBox()
        Me.inputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'itemizedLabel
        '
        Me.itemizedLabel.AutoSize = True
        Me.itemizedLabel.Location = New System.Drawing.Point(238, 13)
        Me.itemizedLabel.Name = "itemizedLabel"
        Me.itemizedLabel.Size = New System.Drawing.Size(83, 15)
        Me.itemizedLabel.TabIndex = 1
        Me.itemizedLabel.Text = "Itemized sales:"
        '
        'outputListBox
        '
        Me.outputListBox.FormattingEnabled = True
        Me.outputListBox.ItemHeight = 15
        Me.outputListBox.Location = New System.Drawing.Point(241, 31)
        Me.outputListBox.Name = "outputListBox"
        Me.outputListBox.Size = New System.Drawing.Size(467, 214)
        Me.outputListBox.TabIndex = 2
        '
        'grossLabel
        '
        Me.grossLabel.AutoSize = True
        Me.grossLabel.Location = New System.Drawing.Point(550, 266)
        Me.grossLabel.Name = "grossLabel"
        Me.grossLabel.Size = New System.Drawing.Size(67, 15)
        Me.grossLabel.TabIndex = 3
        Me.grossLabel.Text = "Gross sales:"
        '
        'grossSalesLabel
        '
        Me.grossSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grossSalesLabel.Location = New System.Drawing.Point(623, 262)
        Me.grossSalesLabel.Name = "grossSalesLabel"
        Me.grossSalesLabel.Size = New System.Drawing.Size(85, 23)
        Me.grossSalesLabel.TabIndex = 4
        Me.grossSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'itemLabel
        '
        Me.itemLabel.AutoSize = True
        Me.itemLabel.Location = New System.Drawing.Point(12, 32)
        Me.itemLabel.Name = "itemLabel"
        Me.itemLabel.Size = New System.Drawing.Size(34, 15)
        Me.itemLabel.TabIndex = 7
        Me.itemLabel.Text = "Item:"
        '
        'mondayLabel
        '
        Me.mondayLabel.AutoSize = True
        Me.mondayLabel.Location = New System.Drawing.Point(12, 78)
        Me.mondayLabel.Name = "mondayLabel"
        Me.mondayLabel.Size = New System.Drawing.Size(54, 15)
        Me.mondayLabel.TabIndex = 8
        Me.mondayLabel.Text = "Monday:"
        '
        'tuesdayLabel
        '
        Me.tuesdayLabel.AutoSize = True
        Me.tuesdayLabel.Location = New System.Drawing.Point(12, 107)
        Me.tuesdayLabel.Name = "tuesdayLabel"
        Me.tuesdayLabel.Size = New System.Drawing.Size(54, 15)
        Me.tuesdayLabel.TabIndex = 9
        Me.tuesdayLabel.Text = "Tuesday:"
        '
        'wednesdayLabel
        '
        Me.wednesdayLabel.AutoSize = True
        Me.wednesdayLabel.Location = New System.Drawing.Point(12, 136)
        Me.wednesdayLabel.Name = "wednesdayLabel"
        Me.wednesdayLabel.Size = New System.Drawing.Size(71, 15)
        Me.wednesdayLabel.TabIndex = 10
        Me.wednesdayLabel.Text = "Wednesday:"
        '
        'thursdayLabel
        '
        Me.thursdayLabel.AutoSize = True
        Me.thursdayLabel.Location = New System.Drawing.Point(12, 165)
        Me.thursdayLabel.Name = "thursdayLabel"
        Me.thursdayLabel.Size = New System.Drawing.Size(59, 15)
        Me.thursdayLabel.TabIndex = 11
        Me.thursdayLabel.Text = "Thursday:"
        '
        'fridayLabel
        '
        Me.fridayLabel.AutoSize = True
        Me.fridayLabel.Location = New System.Drawing.Point(12, 194)
        Me.fridayLabel.Name = "fridayLabel"
        Me.fridayLabel.Size = New System.Drawing.Size(42, 15)
        Me.fridayLabel.TabIndex = 12
        Me.fridayLabel.Text = "Friday:"
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(109, 237)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(91, 23)
        Me.submitButton.TabIndex = 6
        Me.submitButton.Text = "Submit Item"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'itemTextBox
        '
        Me.itemTextBox.Location = New System.Drawing.Point(52, 29)
        Me.itemTextBox.Name = "itemTextBox"
        Me.itemTextBox.Size = New System.Drawing.Size(148, 23)
        Me.itemTextBox.TabIndex = 0
        '
        'mondayTextBox
        '
        Me.mondayTextBox.Location = New System.Drawing.Point(100, 75)
        Me.mondayTextBox.Name = "mondayTextBox"
        Me.mondayTextBox.Size = New System.Drawing.Size(100, 23)
        Me.mondayTextBox.TabIndex = 1
        Me.mondayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tuesdayTextBox
        '
        Me.tuesdayTextBox.Location = New System.Drawing.Point(100, 104)
        Me.tuesdayTextBox.Name = "tuesdayTextBox"
        Me.tuesdayTextBox.Size = New System.Drawing.Size(100, 23)
        Me.tuesdayTextBox.TabIndex = 2
        Me.tuesdayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'wednesdayTextBox
        '
        Me.wednesdayTextBox.Location = New System.Drawing.Point(100, 133)
        Me.wednesdayTextBox.Name = "wednesdayTextBox"
        Me.wednesdayTextBox.Size = New System.Drawing.Size(100, 23)
        Me.wednesdayTextBox.TabIndex = 3
        Me.wednesdayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'thursdayTextBox
        '
        Me.thursdayTextBox.Location = New System.Drawing.Point(100, 162)
        Me.thursdayTextBox.Name = "thursdayTextBox"
        Me.thursdayTextBox.Size = New System.Drawing.Size(100, 23)
        Me.thursdayTextBox.TabIndex = 4
        Me.thursdayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fridayTextBox
        '
        Me.fridayTextBox.Location = New System.Drawing.Point(100, 191)
        Me.fridayTextBox.Name = "fridayTextBox"
        Me.fridayTextBox.Size = New System.Drawing.Size(100, 23)
        Me.fridayTextBox.TabIndex = 5
        Me.fridayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'inputGroupBox
        '
        Me.inputGroupBox.Controls.Add(Me.fridayTextBox)
        Me.inputGroupBox.Controls.Add(Me.thursdayTextBox)
        Me.inputGroupBox.Controls.Add(Me.wednesdayTextBox)
        Me.inputGroupBox.Controls.Add(Me.tuesdayTextBox)
        Me.inputGroupBox.Controls.Add(Me.mondayTextBox)
        Me.inputGroupBox.Controls.Add(Me.itemTextBox)
        Me.inputGroupBox.Controls.Add(Me.submitButton)
        Me.inputGroupBox.Controls.Add(Me.fridayLabel)
        Me.inputGroupBox.Controls.Add(Me.thursdayLabel)
        Me.inputGroupBox.Controls.Add(Me.wednesdayLabel)
        Me.inputGroupBox.Controls.Add(Me.tuesdayLabel)
        Me.inputGroupBox.Controls.Add(Me.mondayLabel)
        Me.inputGroupBox.Controls.Add(Me.itemLabel)
        Me.inputGroupBox.Location = New System.Drawing.Point(13, 13)
        Me.inputGroupBox.Name = "inputGroupBox"
        Me.inputGroupBox.Size = New System.Drawing.Size(215, 272)
        Me.inputGroupBox.TabIndex = 0
        Me.inputGroupBox.TabStop = False
        Me.inputGroupBox.Text = "Input Item"
        '
        'SalesReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 296)
        Me.Controls.Add(Me.grossSalesLabel)
        Me.Controls.Add(Me.grossLabel)
        Me.Controls.Add(Me.outputListBox)
        Me.Controls.Add(Me.itemizedLabel)
        Me.Controls.Add(Me.inputGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SalesReportForm"
        Me.Text = "Sales Report"
        Me.inputGroupBox.ResumeLayout(False)
        Me.inputGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents itemizedLabel As System.Windows.Forms.Label
   Friend WithEvents outputListBox As System.Windows.Forms.ListBox
   Friend WithEvents grossLabel As System.Windows.Forms.Label
   Friend WithEvents grossSalesLabel As System.Windows.Forms.Label
   Friend WithEvents itemLabel As System.Windows.Forms.Label
   Friend WithEvents mondayLabel As System.Windows.Forms.Label
   Friend WithEvents tuesdayLabel As System.Windows.Forms.Label
   Friend WithEvents wednesdayLabel As System.Windows.Forms.Label
   Friend WithEvents thursdayLabel As System.Windows.Forms.Label
   Friend WithEvents fridayLabel As System.Windows.Forms.Label
   Friend WithEvents submitButton As System.Windows.Forms.Button
   Friend WithEvents itemTextBox As System.Windows.Forms.TextBox
   Friend WithEvents mondayTextBox As System.Windows.Forms.TextBox
   Friend WithEvents tuesdayTextBox As System.Windows.Forms.TextBox
   Friend WithEvents wednesdayTextBox As System.Windows.Forms.TextBox
   Friend WithEvents thursdayTextBox As System.Windows.Forms.TextBox
   Friend WithEvents fridayTextBox As System.Windows.Forms.TextBox
   Friend WithEvents inputGroupBox As System.Windows.Forms.GroupBox

End Class
