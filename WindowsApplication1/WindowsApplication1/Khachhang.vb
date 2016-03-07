
Imports System.Data
    Imports System.Data.SqlClient
Public Class Khachhang

    Dim abc As New SqlConnection("workstation id=vietvtpk00407.mssql.somee.com;packet size=4096;user id=vietvtpk00407_SQLLogin_1;pwd=qj6fp3vf1g;data source=vietvtpk00407.mssql.somee.com;persist security info=False;initial catalog=vietvtpk00407")
    Private Sub loaddata()

        Dim load As New SqlCommand("select * from KhachHang", abc)
        Dim data As New SqlDataAdapter(load)
        Dim data1 As New DataTable
        data.Fill(data1)
        abc.Close()
        lstkh.Items.Clear()
        Dim b As Integer
        For Each Row As DataRow In data1.Rows
            lstkh.Items.Add(Row("idkh").ToString())
            lstkh.Items(b).SubItems.Add(Row("tenkh").ToString())
            lstkh.Items(b).SubItems.Add(Row("gioitinh").ToString())
            lstkh.Items(b).SubItems.Add(Row("ngaysinh").ToString())
            lstkh.Items(b).SubItems.Add(Row("email").ToString())
            lstkh.Items(b).SubItems.Add(Row("diachi").ToString())
            lstkh.Items(b).SubItems.Add(Row("sdt").ToString())
            b += 1
        Next
    End Sub
    Private Sub FrmKhachhang_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub ClearBox()
        txt_idkh.Text = ""
        txt_tenkh.Text = ""
        txt_gioitinh.Text = ""
        txt_ngaysinh.Text = ""
        txt_email.Text = ""
        txt_sdt.Text = ""
        txt_diachi.Text = ""



    End Sub

    Private Sub lstkh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstkh.SelectedIndexChanged
        If lstkh.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lstkh.SelectedItems
                txt_idkh.Text = lis.SubItems(0).Text
                txt_tenkh.Text = lis.SubItems(1).Text
                txt_gioitinh.Text = lis.SubItems(2).Text
                txt_ngaysinh.Text = lis.SubItems(3).Text
                txt_email.Text = lis.SubItems(4).Text
                txt_diachi.Text = lis.SubItems(5).Text
                txt_sdt.Text = lis.SubItems(6).Text


                bntxoa.Enabled = True
                bntsua.Enabled = True
            Next
        End If
    End Sub

    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_idkh.TextChanged, txt_idkh.TextChanged
        If (txt_idkh.Text.Trim = "") Then
            bntthem.Enabled = False

        Else
            bntthem.Enabled = True


        End If
    End Sub
    Private Function KiemTraThongTin() As Boolean

        If (txt_idkh.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã khách hàng", "Thông báo")
            Return False
        ElseIf (txt_tenkh.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập tên khách hàng", "Thông báo")
            Return False
        ElseIf (txt_diachi.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập địa chỉ", "Thông báo")
            Return False
        ElseIf (txt_sdt.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo")
            Return False
        ElseIf (txt_email.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập email", "Thông báo")
            Return False
        ElseIf (txt_ngaysinh.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập ngay sinh", "Thông báo")
            Return False

        End If

        Return True
    End Function
    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        If (KiemTraThongTin() = True) Then
            Try
                abc.Open()
                Dim idkh As String = txt_idkh.Text
                Dim tenkh As String = txt_tenkh.Text
                Dim gioitinh As String = txt_gioitinh.Text
                Dim ngaysinh As String = txt_ngaysinh.Text
                Dim email As String = txt_email.Text
                Dim diachi As String = txt_diachi.Text
                Dim sdt As String = txt_sdt.Text

                Dim them As New SqlCommand("Insert into KhachHang(idkh,tenkh,gioitinh,ngaysinh,email,diachi,sdt) values('" + idkh + "', N'" + tenkh + "','" + gioitinh + "','" + ngaysinh + "', N'" + email + "',N'" + diachi + "','" + sdt + "' )", abc)
                them.ExecuteNonQuery()
                abc.Close()
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loaddata()
            Catch ex As Exception
                MessageBox.Show("Thêm Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            ClearBox()
        End If
    End Sub




    Private Sub frmkhachhang_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Bạn có muốn thoát khỏi chương trình không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "THOÁT") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub bntxoa_Click(sender As Object, e As EventArgs) Handles bntxoa.Click

        Try
            abc.Open()
            Dim idkh As String = txt_idkh.Text
            Dim xoa As New SqlCommand("delete from KhachHang where idkh ='" + idkh + "'", abc)
            xoa.ExecuteNonQuery()
            abc.Close()
            MessageBox.Show("Có chắc là bạn muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            loaddata()
        Catch ex As Exception
            MessageBox.Show("Xóa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        bntsua.Enabled = False
        bntxoa.Enabled = False

    End Sub
    Private Sub bntsua_Click(sender As Object, e As EventArgs) Handles bntsua.Click

        Try
            abc.Open()
            Dim idkh As String = txt_idkh.Text
            Dim tenkh As String = txt_tenkh.Text
            Dim gioitinh As String = txt_gioitinh.Text
            Dim ngaysinh As String = txt_ngaysinh.Text
            Dim email As String = txt_email.Text
            Dim diachi As String = txt_diachi.Text
            Dim sdt As String = txt_sdt.Text

            Dim sua As New SqlCommand("update KhachHang set   tenkh = '" + tenkh + "',  gioitinh = '" + gioitinh + "', ngaysinh = '" + ngaysinh + "', email = '" + email + "',  diachi = '" + diachi + "', sdt = '" + sdt + "' where idkh = '" + idkh + "' ", abc)
            sua.ExecuteNonQuery()
            abc.Close()
            MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            loaddata()
        Catch ex As Exception
            MessageBox.Show("Sửa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub







End Class