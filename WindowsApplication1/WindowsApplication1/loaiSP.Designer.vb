<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loaiSP
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
        Me.lstloaisp = New System.Windows.Forms.ListView()
        Me.idloaisp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tenloaisp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_gioitinh = New System.Windows.Forms.Label()
        Me.lbl_tenkh = New System.Windows.Forms.Label()
        Me.lbl_idkh = New System.Windows.Forms.Label()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.txt_mota = New System.Windows.Forms.TextBox()
        Me.txt_tenloaisp = New System.Windows.Forms.TextBox()
        Me.txt_idloaisp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstloaisp
        '
        Me.lstloaisp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idloaisp, Me.tenloaisp, Me.mota})
        Me.lstloaisp.GridLines = True
        Me.lstloaisp.Location = New System.Drawing.Point(346, 3)
        Me.lstloaisp.Name = "lstloaisp"
        Me.lstloaisp.Size = New System.Drawing.Size(405, 192)
        Me.lstloaisp.TabIndex = 45
        Me.lstloaisp.UseCompatibleStateImageBehavior = False
        Me.lstloaisp.View = System.Windows.Forms.View.Details
        '
        'idloaisp
        '
        Me.idloaisp.Text = "ID Loại SP"
        Me.idloaisp.Width = 111
        '
        'tenloaisp
        '
        Me.tenloaisp.Text = "Tên Loại SP"
        Me.tenloaisp.Width = 122
        '
        'mota
        '
        Me.mota.Text = "Mô Tả"
        '
        'lbl_gioitinh
        '
        Me.lbl_gioitinh.AutoSize = True
        Me.lbl_gioitinh.Location = New System.Drawing.Point(51, 148)
        Me.lbl_gioitinh.Name = "lbl_gioitinh"
        Me.lbl_gioitinh.Size = New System.Drawing.Size(38, 13)
        Me.lbl_gioitinh.TabIndex = 42
        Me.lbl_gioitinh.Text = "Mô Tả"
        '
        'lbl_tenkh
        '
        Me.lbl_tenkh.AutoSize = True
        Me.lbl_tenkh.Location = New System.Drawing.Point(51, 84)
        Me.lbl_tenkh.Name = "lbl_tenkh"
        Me.lbl_tenkh.Size = New System.Drawing.Size(66, 13)
        Me.lbl_tenkh.TabIndex = 43
        Me.lbl_tenkh.Text = "Tên Loai SP"
        '
        'lbl_idkh
        '
        Me.lbl_idkh.AutoSize = True
        Me.lbl_idkh.Location = New System.Drawing.Point(52, 30)
        Me.lbl_idkh.Name = "lbl_idkh"
        Me.lbl_idkh.Size = New System.Drawing.Size(58, 13)
        Me.lbl_idkh.TabIndex = 44
        Me.lbl_idkh.Text = "ID Loại SP"
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(284, 216)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 39)
        Me.bntxoa.TabIndex = 39
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(178, 216)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 39)
        Me.bntsua.TabIndex = 40
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(73, 216)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 39)
        Me.bntthem.TabIndex = 41
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'txt_mota
        '
        Me.txt_mota.Location = New System.Drawing.Point(153, 141)
        Me.txt_mota.Name = "txt_mota"
        Me.txt_mota.Size = New System.Drawing.Size(100, 20)
        Me.txt_mota.TabIndex = 36
        '
        'txt_tenloaisp
        '
        Me.txt_tenloaisp.Location = New System.Drawing.Point(153, 81)
        Me.txt_tenloaisp.Name = "txt_tenloaisp"
        Me.txt_tenloaisp.Size = New System.Drawing.Size(100, 20)
        Me.txt_tenloaisp.TabIndex = 37
        '
        'txt_idloaisp
        '
        Me.txt_idloaisp.Location = New System.Drawing.Point(153, 27)
        Me.txt_idloaisp.Name = "txt_idloaisp"
        Me.txt_idloaisp.Size = New System.Drawing.Size(100, 20)
        Me.txt_idloaisp.TabIndex = 38
        '
        'loaiSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 294)
        Me.Controls.Add(Me.lstloaisp)
        Me.Controls.Add(Me.lbl_gioitinh)
        Me.Controls.Add(Me.lbl_tenkh)
        Me.Controls.Add(Me.lbl_idkh)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.txt_mota)
        Me.Controls.Add(Me.txt_tenloaisp)
        Me.Controls.Add(Me.txt_idloaisp)
        Me.Name = "loaiSP"
        Me.Text = "Loại Sản Phẩm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstloaisp As ListView
    Friend WithEvents idloaisp As ColumnHeader
    Friend WithEvents tenloaisp As ColumnHeader
    Friend WithEvents mota As ColumnHeader
    Friend WithEvents lbl_gioitinh As Label
    Friend WithEvents lbl_tenkh As Label
    Friend WithEvents lbl_idkh As Label
    Friend WithEvents bntxoa As Button
    Friend WithEvents bntsua As Button
    Friend WithEvents bntthem As Button
    Friend WithEvents txt_mota As TextBox
    Friend WithEvents txt_tenloaisp As TextBox
    Friend WithEvents txt_idloaisp As TextBox
End Class
