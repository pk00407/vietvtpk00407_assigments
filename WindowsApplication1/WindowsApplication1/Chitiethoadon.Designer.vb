<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chitiethoadon
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
        Me.idhd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.soluong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tensp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idcthd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_sdt = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_gioitinh = New System.Windows.Forms.Label()
        Me.lbl_tenkh = New System.Windows.Forms.Label()
        Me.lbl_idkh = New System.Windows.Forms.Label()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.txt_idhd = New System.Windows.Forms.TextBox()
        Me.txt_mota = New System.Windows.Forms.TextBox()
        Me.txt_soluong = New System.Windows.Forms.TextBox()
        Me.txt_tensp = New System.Windows.Forms.TextBox()
        Me.txt_idcthd = New System.Windows.Forms.TextBox()
        Me.lstcthd = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'idhd
        '
        Me.idhd.Text = "ID HĐ"
        Me.idhd.Width = 58
        '
        'soluong
        '
        Me.soluong.Text = "Số Lượng"
        Me.soluong.Width = 84
        '
        'tensp
        '
        Me.tensp.Text = "Tên SP"
        Me.tensp.Width = 99
        '
        'idcthd
        '
        Me.idcthd.Text = "ID CTHD"
        '
        'mota
        '
        Me.mota.Text = "Mô Tả"
        Me.mota.Width = 100
        '
        'lbl_sdt
        '
        Me.lbl_sdt.AutoSize = True
        Me.lbl_sdt.Location = New System.Drawing.Point(215, 77)
        Me.lbl_sdt.Name = "lbl_sdt"
        Me.lbl_sdt.Size = New System.Drawing.Size(37, 13)
        Me.lbl_sdt.TabIndex = 44
        Me.lbl_sdt.Text = "ID HĐ"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(215, 16)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(38, 13)
        Me.lbl_email.TabIndex = 45
        Me.lbl_email.Text = "Mô Tả"
        '
        'lbl_gioitinh
        '
        Me.lbl_gioitinh.AutoSize = True
        Me.lbl_gioitinh.Location = New System.Drawing.Point(34, 131)
        Me.lbl_gioitinh.Name = "lbl_gioitinh"
        Me.lbl_gioitinh.Size = New System.Drawing.Size(53, 13)
        Me.lbl_gioitinh.TabIndex = 46
        Me.lbl_gioitinh.Text = "Số Lượng"
        '
        'lbl_tenkh
        '
        Me.lbl_tenkh.AutoSize = True
        Me.lbl_tenkh.Location = New System.Drawing.Point(36, 67)
        Me.lbl_tenkh.Name = "lbl_tenkh"
        Me.lbl_tenkh.Size = New System.Drawing.Size(43, 13)
        Me.lbl_tenkh.TabIndex = 47
        Me.lbl_tenkh.Text = "Tên SP"
        '
        'lbl_idkh
        '
        Me.lbl_idkh.AutoSize = True
        Me.lbl_idkh.Location = New System.Drawing.Point(37, 13)
        Me.lbl_idkh.Name = "lbl_idkh"
        Me.lbl_idkh.Size = New System.Drawing.Size(51, 13)
        Me.lbl_idkh.TabIndex = 48
        Me.lbl_idkh.Text = "ID CTHD"
        '
        'bntxoa
        '
        Me.bntxoa.BackColor = System.Drawing.SystemColors.Control
        Me.bntxoa.Location = New System.Drawing.Point(284, 385)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 39)
        Me.bntxoa.TabIndex = 41
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = False
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(178, 385)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 39)
        Me.bntsua.TabIndex = 42
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(73, 385)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 39)
        Me.bntthem.TabIndex = 43
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'txt_idhd
        '
        Me.txt_idhd.Location = New System.Drawing.Point(278, 70)
        Me.txt_idhd.Name = "txt_idhd"
        Me.txt_idhd.Size = New System.Drawing.Size(100, 20)
        Me.txt_idhd.TabIndex = 36
        '
        'txt_mota
        '
        Me.txt_mota.Location = New System.Drawing.Point(278, 13)
        Me.txt_mota.Name = "txt_mota"
        Me.txt_mota.Size = New System.Drawing.Size(100, 20)
        Me.txt_mota.TabIndex = 37
        '
        'txt_soluong
        '
        Me.txt_soluong.Location = New System.Drawing.Point(88, 124)
        Me.txt_soluong.Name = "txt_soluong"
        Me.txt_soluong.Size = New System.Drawing.Size(100, 20)
        Me.txt_soluong.TabIndex = 38
        '
        'txt_tensp
        '
        Me.txt_tensp.Location = New System.Drawing.Point(88, 67)
        Me.txt_tensp.Name = "txt_tensp"
        Me.txt_tensp.Size = New System.Drawing.Size(100, 20)
        Me.txt_tensp.TabIndex = 39
        '
        'txt_idcthd
        '
        Me.txt_idcthd.Location = New System.Drawing.Point(88, 13)
        Me.txt_idcthd.Name = "txt_idcthd"
        Me.txt_idcthd.Size = New System.Drawing.Size(100, 20)
        Me.txt_idcthd.TabIndex = 40
        '
        'lstcthd
        '
        Me.lstcthd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idcthd, Me.tensp, Me.soluong, Me.mota, Me.idhd})
        Me.lstcthd.FullRowSelect = True
        Me.lstcthd.GridLines = True
        Me.lstcthd.Location = New System.Drawing.Point(37, 173)
        Me.lstcthd.Name = "lstcthd"
        Me.lstcthd.Size = New System.Drawing.Size(408, 182)
        Me.lstcthd.TabIndex = 35
        Me.lstcthd.UseCompatibleStateImageBehavior = False
        Me.lstcthd.View = System.Windows.Forms.View.Details
        '
        'Chitiethoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 452)
        Me.Controls.Add(Me.lbl_sdt)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_gioitinh)
        Me.Controls.Add(Me.lbl_tenkh)
        Me.Controls.Add(Me.lbl_idkh)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.txt_idhd)
        Me.Controls.Add(Me.txt_mota)
        Me.Controls.Add(Me.txt_soluong)
        Me.Controls.Add(Me.txt_tensp)
        Me.Controls.Add(Me.txt_idcthd)
        Me.Controls.Add(Me.lstcthd)
        Me.Name = "Chitiethoadon"
        Me.Text = "Chi Tiết Hóa Đơn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents idhd As ColumnHeader
    Friend WithEvents soluong As ColumnHeader
    Friend WithEvents tensp As ColumnHeader
    Friend WithEvents idcthd As ColumnHeader
    Friend WithEvents mota As ColumnHeader
    Friend WithEvents lbl_sdt As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_gioitinh As Label
    Friend WithEvents lbl_tenkh As Label
    Friend WithEvents lbl_idkh As Label
    Friend WithEvents bntxoa As Button
    Friend WithEvents bntsua As Button
    Friend WithEvents bntthem As Button
    Friend WithEvents txt_idhd As TextBox
    Friend WithEvents txt_mota As TextBox
    Friend WithEvents txt_soluong As TextBox
    Friend WithEvents txt_tensp As TextBox
    Friend WithEvents txt_idcthd As TextBox
    Friend WithEvents lstcthd As ListView
End Class
