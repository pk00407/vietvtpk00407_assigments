<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hoadon
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
        Me.mota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idkh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idsp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idhd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tongtien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_gioitinh = New System.Windows.Forms.Label()
        Me.lbl_tenkh = New System.Windows.Forms.Label()
        Me.lbl_diachi = New System.Windows.Forms.Label()
        Me.lbl_idkh = New System.Windows.Forms.Label()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.txt_mota = New System.Windows.Forms.TextBox()
        Me.txt_idkh = New System.Windows.Forms.TextBox()
        Me.txt_idsp = New System.Windows.Forms.TextBox()
        Me.txt_tongtien = New System.Windows.Forms.TextBox()
        Me.txt_idhd = New System.Windows.Forms.TextBox()
        Me.lsthd = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'mota
        '
        Me.mota.Text = "Mô Tả"
        '
        'idkh
        '
        Me.idkh.Text = "ID KH"
        '
        'idsp
        '
        Me.idsp.Text = "ID SP"
        '
        'idhd
        '
        Me.idhd.Text = "ID HĐ"
        '
        'tongtien
        '
        Me.tongtien.Text = "Tổng Tiền"
        Me.tongtien.Width = 64
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(207, 72)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(38, 13)
        Me.lbl_email.TabIndex = 34
        Me.lbl_email.Text = "Mô Tả"
        '
        'lbl_gioitinh
        '
        Me.lbl_gioitinh.AutoSize = True
        Me.lbl_gioitinh.Location = New System.Drawing.Point(23, 133)
        Me.lbl_gioitinh.Name = "lbl_gioitinh"
        Me.lbl_gioitinh.Size = New System.Drawing.Size(36, 13)
        Me.lbl_gioitinh.TabIndex = 33
        Me.lbl_gioitinh.Text = "ID KH"
        '
        'lbl_tenkh
        '
        Me.lbl_tenkh.AutoSize = True
        Me.lbl_tenkh.Location = New System.Drawing.Point(23, 69)
        Me.lbl_tenkh.Name = "lbl_tenkh"
        Me.lbl_tenkh.Size = New System.Drawing.Size(35, 13)
        Me.lbl_tenkh.TabIndex = 32
        Me.lbl_tenkh.Text = "ID SP"
        '
        'lbl_diachi
        '
        Me.lbl_diachi.AutoSize = True
        Me.lbl_diachi.Location = New System.Drawing.Point(207, 15)
        Me.lbl_diachi.Name = "lbl_diachi"
        Me.lbl_diachi.Size = New System.Drawing.Size(56, 13)
        Me.lbl_diachi.TabIndex = 31
        Me.lbl_diachi.Text = "Tổng Tiền"
        '
        'lbl_idkh
        '
        Me.lbl_idkh.AutoSize = True
        Me.lbl_idkh.Location = New System.Drawing.Point(24, 15)
        Me.lbl_idkh.Name = "lbl_idkh"
        Me.lbl_idkh.Size = New System.Drawing.Size(37, 13)
        Me.lbl_idkh.TabIndex = 30
        Me.lbl_idkh.Text = "ID HĐ"
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(317, 371)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 39)
        Me.bntxoa.TabIndex = 29
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(210, 371)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 39)
        Me.bntsua.TabIndex = 28
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(97, 371)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 39)
        Me.bntthem.TabIndex = 27
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'txt_mota
        '
        Me.txt_mota.Location = New System.Drawing.Point(270, 69)
        Me.txt_mota.Name = "txt_mota"
        Me.txt_mota.Size = New System.Drawing.Size(100, 20)
        Me.txt_mota.TabIndex = 25
        '
        'txt_idkh
        '
        Me.txt_idkh.Location = New System.Drawing.Point(75, 126)
        Me.txt_idkh.Name = "txt_idkh"
        Me.txt_idkh.Size = New System.Drawing.Size(100, 20)
        Me.txt_idkh.TabIndex = 24
        '
        'txt_idsp
        '
        Me.txt_idsp.Location = New System.Drawing.Point(75, 69)
        Me.txt_idsp.Name = "txt_idsp"
        Me.txt_idsp.Size = New System.Drawing.Size(100, 20)
        Me.txt_idsp.TabIndex = 23
        '
        'txt_tongtien
        '
        Me.txt_tongtien.Location = New System.Drawing.Point(270, 15)
        Me.txt_tongtien.Name = "txt_tongtien"
        Me.txt_tongtien.Size = New System.Drawing.Size(100, 20)
        Me.txt_tongtien.TabIndex = 22
        '
        'txt_idhd
        '
        Me.txt_idhd.Location = New System.Drawing.Point(75, 15)
        Me.txt_idhd.Name = "txt_idhd"
        Me.txt_idhd.Size = New System.Drawing.Size(100, 20)
        Me.txt_idhd.TabIndex = 26
        '
        'lsthd
        '
        Me.lsthd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idhd, Me.idsp, Me.idkh, Me.tongtien, Me.mota})
        Me.lsthd.FullRowSelect = True
        Me.lsthd.GridLines = True
        Me.lsthd.Location = New System.Drawing.Point(14, 197)
        Me.lsthd.Name = "lsthd"
        Me.lsthd.Size = New System.Drawing.Size(469, 135)
        Me.lsthd.TabIndex = 21
        Me.lsthd.UseCompatibleStateImageBehavior = False
        Me.lsthd.View = System.Windows.Forms.View.Details
        '
        'Hoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 417)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_gioitinh)
        Me.Controls.Add(Me.lbl_tenkh)
        Me.Controls.Add(Me.lbl_diachi)
        Me.Controls.Add(Me.lbl_idkh)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.txt_mota)
        Me.Controls.Add(Me.txt_idkh)
        Me.Controls.Add(Me.txt_idsp)
        Me.Controls.Add(Me.txt_tongtien)
        Me.Controls.Add(Me.txt_idhd)
        Me.Controls.Add(Me.lsthd)
        Me.Name = "Hoadon"
        Me.Text = "Hóa Đơn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mota As ColumnHeader
    Friend WithEvents idkh As ColumnHeader
    Friend WithEvents idsp As ColumnHeader
    Friend WithEvents idhd As ColumnHeader
    Friend WithEvents tongtien As ColumnHeader
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_gioitinh As Label
    Friend WithEvents lbl_tenkh As Label
    Friend WithEvents lbl_diachi As Label
    Friend WithEvents lbl_idkh As Label
    Friend WithEvents bntxoa As Button
    Friend WithEvents bntsua As Button
    Friend WithEvents bntthem As Button
    Friend WithEvents txt_mota As TextBox
    Friend WithEvents txt_idkh As TextBox
    Friend WithEvents txt_idsp As TextBox
    Friend WithEvents txt_tongtien As TextBox
    Friend WithEvents txt_idhd As TextBox
    Friend WithEvents lsthd As ListView
End Class
