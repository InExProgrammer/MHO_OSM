<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransaction))
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtStockID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvTransaction = New System.Windows.Forms.DataGridView
        Me.Issuance = New System.Windows.Forms.GroupBox
        Me.lblAS = New System.Windows.Forms.Label
        Me.dtpIssued = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtIssuedBy = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboArea = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtIssuedTo = New System.Windows.Forms.TextBox
        Me.btnIssue = New System.Windows.Forms.Button
        Me.txtRemarks2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtQTY2 = New System.Windows.Forms.TextBox
        Me.cbo = New System.Windows.Forms.ComboBox
        Me.Adding = New System.Windows.Forms.GroupBox
        Me.dtpAdded = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtQTY = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnRemove = New System.Windows.Forms.Button
        CType(Me.dgvTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Issuance.SuspendLayout()
        Me.Adding.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(240, 7)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(473, 23)
        Me.txtDescription.TabIndex = 105
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Description:"
        '
        'txtStockID
        '
        Me.txtStockID.Location = New System.Drawing.Point(89, 7)
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.ReadOnly = True
        Me.txtStockID.Size = New System.Drawing.Size(61, 23)
        Me.txtStockID.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Stock ID:"
        '
        'dgvTransaction
        '
        Me.dgvTransaction.AllowUserToAddRows = False
        Me.dgvTransaction.AllowUserToOrderColumns = True
        Me.dgvTransaction.AllowUserToResizeRows = False
        Me.dgvTransaction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransaction.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransaction.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransaction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTransaction.ColumnHeadersHeight = 30
        Me.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransaction.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTransaction.Location = New System.Drawing.Point(11, 247)
        Me.dgvTransaction.Name = "dgvTransaction"
        Me.dgvTransaction.ReadOnly = True
        Me.dgvTransaction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvTransaction.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvTransaction.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTransaction.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransaction.Size = New System.Drawing.Size(698, 137)
        Me.dgvTransaction.TabIndex = 111
        '
        'Issuance
        '
        Me.Issuance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Issuance.Controls.Add(Me.cbo)
        Me.Issuance.Controls.Add(Me.lblAS)
        Me.Issuance.Controls.Add(Me.dtpIssued)
        Me.Issuance.Controls.Add(Me.Label4)
        Me.Issuance.Controls.Add(Me.txtIssuedBy)
        Me.Issuance.Controls.Add(Me.Label3)
        Me.Issuance.Controls.Add(Me.Label9)
        Me.Issuance.Controls.Add(Me.cboArea)
        Me.Issuance.Controls.Add(Me.Label7)
        Me.Issuance.Controls.Add(Me.Label8)
        Me.Issuance.Controls.Add(Me.txtIssuedTo)
        Me.Issuance.Controls.Add(Me.btnIssue)
        Me.Issuance.Controls.Add(Me.txtRemarks2)
        Me.Issuance.Controls.Add(Me.Label5)
        Me.Issuance.Controls.Add(Me.Label6)
        Me.Issuance.Controls.Add(Me.txtQTY2)
        Me.Issuance.Location = New System.Drawing.Point(10, 131)
        Me.Issuance.Name = "Issuance"
        Me.Issuance.Size = New System.Drawing.Size(698, 91)
        Me.Issuance.TabIndex = 5
        Me.Issuance.TabStop = False
        '
        'lblAS
        '
        Me.lblAS.AutoSize = True
        Me.lblAS.BackColor = System.Drawing.Color.Green
        Me.lblAS.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAS.ForeColor = System.Drawing.Color.White
        Me.lblAS.Location = New System.Drawing.Point(72, 10)
        Me.lblAS.Name = "lblAS"
        Me.lblAS.Size = New System.Drawing.Size(140, 16)
        Me.lblAS.TabIndex = 127
        Me.lblAS.Text = "- Available Stock(s):"
        '
        'dtpIssued
        '
        Me.dtpIssued.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIssued.Location = New System.Drawing.Point(109, 60)
        Me.dtpIssued.Name = "dtpIssued"
        Me.dtpIssued.Size = New System.Drawing.Size(98, 23)
        Me.dtpIssued.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(414, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Issued by:"
        '
        'txtIssuedBy
        '
        Me.txtIssuedBy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIssuedBy.Location = New System.Drawing.Point(483, 61)
        Me.txtIssuedBy.Name = "txtIssuedBy"
        Me.txtIssuedBy.Size = New System.Drawing.Size(115, 23)
        Me.txtIssuedBy.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Date Issued:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Green
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(2, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 16)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "ISSUANCE"
        '
        'cboArea
        '
        Me.cboArea.BackColor = System.Drawing.Color.White
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Items.AddRange(New Object() {"OFFICE", "RECOVERY", "INBOUND", "DESTRUCTION", "SDC", "NPI GUARD", "OTHERS"})
        Me.cboArea.Location = New System.Drawing.Point(278, 33)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(134, 25)
        Me.cboArea.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(236, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Area:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(210, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "Issued to:"
        '
        'txtIssuedTo
        '
        Me.txtIssuedTo.Location = New System.Drawing.Point(277, 61)
        Me.txtIssuedTo.Name = "txtIssuedTo"
        Me.txtIssuedTo.Size = New System.Drawing.Size(135, 23)
        Me.txtIssuedTo.TabIndex = 900
        '
        'btnIssue
        '
        Me.btnIssue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIssue.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssue.ForeColor = System.Drawing.Color.White
        Me.btnIssue.Location = New System.Drawing.Point(605, 60)
        Me.btnIssue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(86, 25)
        Me.btnIssue.TabIndex = 113
        Me.btnIssue.Text = "Ok"
        Me.btnIssue.UseVisualStyleBackColor = False
        '
        'txtRemarks2
        '
        Me.txtRemarks2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemarks2.Location = New System.Drawing.Point(483, 34)
        Me.txtRemarks2.Name = "txtRemarks2"
        Me.txtRemarks2.Size = New System.Drawing.Size(209, 23)
        Me.txtRemarks2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Quantity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(416, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Remarks:"
        '
        'txtQTY2
        '
        Me.txtQTY2.Location = New System.Drawing.Point(109, 34)
        Me.txtQTY2.Name = "txtQTY2"
        Me.txtQTY2.Size = New System.Drawing.Size(98, 23)
        Me.txtQTY2.TabIndex = 5
        '
        'cbo
        '
        Me.cbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo.DropDownHeight = 90
        Me.cbo.DropDownWidth = 230
        Me.cbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbo.ForeColor = System.Drawing.Color.Black
        Me.cbo.FormattingEnabled = True
        Me.cbo.IntegralHeight = False
        Me.cbo.Location = New System.Drawing.Point(277, 61)
        Me.cbo.Name = "cbo"
        Me.cbo.Size = New System.Drawing.Size(135, 25)
        Me.cbo.TabIndex = 8
        '
        'Adding
        '
        Me.Adding.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Adding.Controls.Add(Me.dtpAdded)
        Me.Adding.Controls.Add(Me.Label11)
        Me.Adding.Controls.Add(Me.Label10)
        Me.Adding.Controls.Add(Me.btnAdd)
        Me.Adding.Controls.Add(Me.txtRemarks)
        Me.Adding.Controls.Add(Me.Label13)
        Me.Adding.Controls.Add(Me.Label14)
        Me.Adding.Controls.Add(Me.txtQTY)
        Me.Adding.Location = New System.Drawing.Point(11, 41)
        Me.Adding.Name = "Adding"
        Me.Adding.Size = New System.Drawing.Size(698, 94)
        Me.Adding.TabIndex = 123
        Me.Adding.TabStop = False
        '
        'dtpAdded
        '
        Me.dtpAdded.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAdded.Location = New System.Drawing.Point(109, 60)
        Me.dtpAdded.Name = "dtpAdded"
        Me.dtpAdded.Size = New System.Drawing.Size(98, 23)
        Me.dtpAdded.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 17)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "Date Added:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Green
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(2, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 16)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "ADDING OF STOCKS"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(606, 61)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 25)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Ok"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemarks.Location = New System.Drawing.Point(293, 32)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(399, 23)
        Me.txtRemarks.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(43, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 17)
        Me.Label13.TabIndex = 117
        Me.Label13.Text = "Quantity:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(224, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 17)
        Me.Label14.TabIndex = 114
        Me.Label14.Text = "Remarks:"
        '
        'txtQTY
        '
        Me.txtQTY.Location = New System.Drawing.Point(109, 32)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(98, 23)
        Me.txtQTY.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Green
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(11, 228)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 124
        Me.Label12.Text = "TRANSACTION"
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BackColor = System.Drawing.Color.Red
        Me.btnRemove.Enabled = False
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(629, 386)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 25)
        Me.btnRemove.TabIndex = 125
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'frmTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(721, 412)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStockID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Adding)
        Me.Controls.Add(Me.Issuance)
        Me.Controls.Add(Me.dgvTransaction)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transaction"
        CType(Me.dgvTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Issuance.ResumeLayout(False)
        Me.Issuance.PerformLayout()
        Me.Adding.ResumeLayout(False)
        Me.Adding.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStockID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvTransaction As System.Windows.Forms.DataGridView
    Friend WithEvents Issuance As System.Windows.Forms.GroupBox
    Friend WithEvents cboArea As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIssuedTo As System.Windows.Forms.TextBox
    Friend WithEvents btnIssue As System.Windows.Forms.Button
    Friend WithEvents txtRemarks2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQTY2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Adding As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIssuedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpIssued As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAdded As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblAS As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents cbo As System.Windows.Forms.ComboBox
End Class
