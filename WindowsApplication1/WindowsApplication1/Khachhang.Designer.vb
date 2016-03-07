<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Khachhang
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
        Me.sdt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ngaysinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gioitinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tenkh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idkh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstkh = New System.Windows.Forms.ListView()
        Me.diachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_ngaysinh = New System.Windows.Forms.TextBox()
        Me.lbl_sdt = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_gioitinh = New System.Windows.Forms.Label()
        Me.lbl_tenkh = New System.Windows.Forms.Label()
        Me.lbl_diachi = New System.Windows.Forms.Label()
        Me.lbl_idkh = New System.Windows.Forms.Label()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.txt_sdt = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_gioitinh = New System.Windows.Forms.TextBox()
        Me.txt_tenkh = New System.Windows.Forms.TextBox()
        Me.txt_diachi = New System.Windows.Forms.TextBox()
        Me.txt_idkh = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'sdt
        '
        Me.sdt.Text = "SDT"
        '
        'email
        '
        Me.email.Text = "Email"
        '
        'ngaysinh
        '
        Me.ngaysinh.Text = "Ngày Sinh"
        Me.ngaysinh.Width = 67
        '
        'gioitinh
        '
        Me.gioitinh.Text = "Giới Tính"
        '
        'tenkh
        '
        Me.tenkh.Text = "Tên KH"
        '
        'idkh
        '
        Me.idkh.Text = "ID KH"
        '
        'lstkh
        '
        Me.lstkh.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idkh, Me.tenkh, Me.gioitinh, Me.ngaysinh, Me.email, Me.diachi, Me.sdt})
        Me.lstkh.GridLines = True
        Me.lstkh.Location = New System.Drawing.Point(433, 39)
        Me.lstkh.Name = "lstkh"
        Me.lstkh.Size = New System.Drawing.Size(443, 235)
        Me.lstkh.TabIndex = 23
        Me.lstkh.UseCompatibleStateImageBehavior = False
        Me.lstkh.View = System.Windows.Forms.View.Details
        '
        'diachi
        '
        Me.diachi.Text = "Địa Chỉ"
        '
        'txt_ngaysinh
        '
        Me.txt_ngaysinh.Location = New System.Drawing.Point(68, 202)
        Me.txt_ngaysinh.Name = "txt_ngaysinh"
        Me.txt_ngaysinh.Size = New System.Drawing.Size(100, 20)
        Me.txt_ngaysinh.TabIndex = 22
        '
        'lbl_sdt
        '
        Me.lbl_sdt.AutoSize = True
        Me.lbl_sdt.Location = New System.Drawing.Point(200, 157)
        Me.lbl_sdt.Name = "lbl_sdt"
        Me.lbl_sdt.Size = New System.Drawing.Size(29, 13)
        Me.lbl_sdt.TabIndex = 20
        Me.lbl_sdt.Text = "SDT"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(200, 96)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(32, 13)
        Me.lbl_email.TabIndex = 19
        Me.lbl_email.Text = "Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Ngay Sinh"
        '
        'lbl_gioitinh
        '
        Me.lbl_gioitinh.AutoSize = True
        Me.lbl_gioitinh.Location = New System.Drawing.Point(16, 157)
        Me.lbl_gioitinh.Name = "lbl_gioitinh"
        Me.lbl_gioitinh.Size = New System.Drawing.Size(51, 13)
        Me.lbl_gioitinh.TabIndex = 17
        Me.lbl_gioitinh.Text = "Giới Tính"
        '
        'lbl_tenkh
        '
        Me.lbl_tenkh.AutoSize = True
        Me.lbl_tenkh.Location = New System.Drawing.Point(16, 93)
        Me.lbl_tenkh.Name = "lbl_tenkh"
        Me.lbl_tenkh.Size = New System.Drawing.Size(44, 13)
        Me.lbl_tenkh.TabIndex = 16
        Me.lbl_tenkh.Text = "Tên KH"
        '
        'lbl_diachi
        '
        Me.lbl_diachi.AutoSize = True
        Me.lbl_diachi.Location = New System.Drawing.Point(200, 39)
        Me.lbl_diachi.Name = "lbl_diachi"
        Me.lbl_diachi.Size = New System.Drawing.Size(41, 13)
        Me.lbl_diachi.TabIndex = 21
        Me.lbl_diachi.Text = "Địa Chỉ"
        '
        'lbl_idkh
        '
        Me.lbl_idkh.AutoSize = True
        Me.lbl_idkh.Location = New System.Drawing.Point(17, 39)
        Me.lbl_idkh.Name = "lbl_idkh"
        Me.lbl_idkh.Size = New System.Drawing.Size(36, 13)
        Me.lbl_idkh.TabIndex = 15
        Me.lbl_idkh.Text = "ID KH"
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(252, 235)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 39)
        Me.bntxoa.TabIndex = 14
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(146, 235)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 39)
        Me.bntsua.TabIndex = 13
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(41, 235)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 39)
        Me.bntthem.TabIndex = 12
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'txt_sdt
        '
        Me.txt_sdt.Location = New System.Drawing.Point(263, 150)
        Me.txt_sdt.Name = "txt_sdt"
        Me.txt_sdt.Size = New System.Drawing.Size(100, 20)
        Me.txt_sdt.TabIndex = 10
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(263, 93)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(100, 20)
        Me.txt_email.TabIndex = 9
        '
        'txt_gioitinh
        '
        Me.txt_gioitinh.Location = New System.Drawing.Point(68, 150)
        Me.txt_gioitinh.Name = "txt_gioitinh"
        Me.txt_gioitinh.Size = New System.Drawing.Size(100, 20)
        Me.txt_gioitinh.TabIndex = 8
        '
        'txt_tenkh
        '
        Me.txt_tenkh.Location = New System.Drawing.Point(68, 93)
        Me.txt_tenkh.Name = "txt_tenkh"
        Me.txt_tenkh.Size = New System.Drawing.Size(100, 20)
        Me.txt_tenkh.TabIndex = 7
        '
        'txt_diachi
        '
        Me.txt_diachi.Location = New System.Drawing.Point(263, 39)
        Me.txt_diachi.Name = "txt_diachi"
        Me.txt_diachi.Size = New System.Drawing.Size(100, 20)
        Me.txt_diachi.TabIndex = 11
        '
        'txt_idkh
        '
        Me.txt_idkh.Location = New System.Drawing.Point(68, 39)
        Me.txt_idkh.Name = "txt_idkh"
        Me.txt_idkh.Size = New System.Drawing.Size(100, 20)
        Me.txt_idkh.TabIndex = 6
        '
        'Khachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 303)
        Me.Controls.Add(Me.lstkh)
        Me.Controls.Add(Me.txt_ngaysinh)
        Me.Controls.Add(Me.lbl_sdt)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_gioitinh)
        Me.Controls.Add(Me.lbl_tenkh)
        Me.Controls.Add(Me.lbl_diachi)
        Me.Controls.Add(Me.lbl_idkh)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.txt_sdt)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_gioitinh)
        Me.Controls.Add(Me.txt_tenkh)
        Me.Controls.Add(Me.txt_diachi)
        Me.Controls.Add(Me.txt_idkh)
        Me.Name = "Khachhang"
        Me.Text = "Khách Hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sdt As ColumnHeader
    Friend WithEvents email As ColumnHeader
    Friend WithEvents ngaysinh As ColumnHeader
    Friend WithEvents gioitinh As ColumnHeader
    Friend WithEvents tenkh As ColumnHeader
    Friend WithEvents idkh As ColumnHeader
    Friend WithEvents lstkh As ListView
    Friend WithEvents diachi As ColumnHeader
    Friend WithEvents txt_ngaysinh As TextBox
    Friend WithEvents lbl_sdt As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_gioitinh As Label
    Friend WithEvents lbl_tenkh As Label
    Friend WithEvents lbl_diachi As Label
    Friend WithEvents lbl_idkh As Label
    Friend WithEvents bntxoa As Button
    Friend WithEvents bntsua As Button
    Friend WithEvents bntthem As Button
    Friend WithEvents txt_sdt As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_gioitinh As TextBox
    Friend WithEvents txt_tenkh As TextBox
    Friend WithEvents txt_diachi As TextBox
    Friend WithEvents txt_idkh As TextBox
End Class
