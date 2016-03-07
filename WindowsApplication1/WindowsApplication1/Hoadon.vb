Imports System.Data
Imports System.Data.SqlClient
Public Class Hoadon
    Dim data As New SqlConnection("workstation id=vietvtpk00407.mssql.somee.com;packet size=4096;user id=vietvtpk00407_SQLLogin_1;pwd=qj6fp3vf1g;data source=vietvtpk00407.mssql.somee.com;persist security info=False;initial catalog=vietvtpk00407")
    Private Sub chaydulieu()
        data.Open()
        Dim load As New SqlCommand("select * from HoaDon", data)
        Dim sqldata As New SqlDataAdapter(load)
        Dim sqldatatabel As New DataTable
        sqldata.Fill(sqldatatabel)
        data.Close()
        lsthd.Items.Clear()
        Dim a As Integer
        For Each Row As DataRow In sqldatatabel.Rows
            lsthd.Items.Add(Row("idhd").ToString())
            lsthd.Items(a).SubItems.Add(Row("idsp").ToString())
            lsthd.Items(a).SubItems.Add(Row("idkh").ToString())
            lsthd.Items(a).SubItems.Add(Row("tongtien").ToString())
            lsthd.Items(a).SubItems.Add(Row("mota").ToString())

            a += 1
        Next
    End Sub

    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        If (KiemTraThongTin() = True) Then
            Try
                data.Open()
                Dim idhd As String = txt_idhd.Text
                Dim idsp As String = txt_idsp.Text
                Dim idkh As String = txt_idkh.Text
                Dim tongtien As String = txt_tongtien.Text
                Dim mota As String = txt_mota.Text
                Dim them As New SqlCommand("Insert into HoaDon(idhd,idsp,idkh,tongtien,mota) values('" + idhd + "' , '" + idsp + "', '" + idkh + "' ,'" + tongtien + "','" + mota + "')", data)
                them.ExecuteNonQuery()
                data.Close()
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chaydulieu()
            Catch ex As Exception
                MessageBox.Show("Thêm Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            ClearBox()
        End If
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chaydulieu()
    End Sub

    Private Sub frmhoadon_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Bạn có muốn thoát khỏi chương trình không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "THOÁT") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub


    Private Sub ClearBox()
        txt_idhd.Text = ""
        txt_idsp.Text = ""
        txt_idkh.Text = ""
        txt_mota.Text = ""
        txt_tongtien.Text = ""
    End Sub
    Private Sub lsthd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsthd.SelectedIndexChanged
        If lsthd.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lsthd.SelectedItems
                txt_idhd.Text = lis.SubItems(0).Text
                txt_idsp.Text = lis.SubItems(1).Text
                txt_idkh.Text = lis.SubItems(2).Text
                txt_tongtien.Text = lis.SubItems(3).Text
                txt_mota.Text = lis.SubItems(4).Text
                bntxoa.Enabled = True
                bntsua.Enabled = True
            Next
        End If
    End Sub
    Private Sub bntxoa_Click(sender As Object, e As EventArgs) Handles bntxoa.Click

        Try
            data.Open()
            Dim idhd As String = txt_idhd.Text
            Dim xoa As New SqlCommand("delete from HoaDon where idhd ='" + idhd + "'", data)
            xoa.ExecuteNonQuery()
            data.Close()
            Dim dialogResult As DialogResult = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (dialogResult = DialogResult.Yes) Then
                chaydulieu()
            End If
        Catch ex As Exception
            MessageBox.Show("Xóa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        bntsua.Enabled = False
        bntxoa.Enabled = False

    End Sub

    Private Sub bntsua_Click(sender As Object, e As EventArgs) Handles bntsua.Click
        Try
            data.Open()
            Dim idhd As String = txt_idhd.Text
            Dim idsp As String = txt_idsp.Text
            Dim idkh As String = txt_idkh.Text
            Dim tongtien As String = txt_tongtien.Text
            Dim mota As String = txt_mota.Text
            Dim sua As New SqlCommand("update HoaDon set idsp = '" + idsp + "', idkh= '" + idhd + "' , tongtien= '" + tongtien + "', mota= '" + mota + "'  where idhd = '" + idhd + "'", data)
            sua.ExecuteNonQuery()
            data.Close()
            Dim dialogResult As DialogResult = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (dialogResult = DialogResult.Yes) Then
                chaydulieu()
            End If
        Catch ex As Exception
            MessageBox.Show("Sửa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Hàm ki?m tra thông tin. N?u thông tin d?y d? th́ tr? v? là True, ngu?c l?i False 
    Private Function KiemTraThongTin() As Boolean

        If (txt_idhd.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập mã sp", "Thông báo")
            Return False
        ElseIf (txt_idsp.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập mă công to", "Thông báo")
            Return False
        ElseIf (txt_idkh.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập  (KW)", "Thông báo")
            Return False

            Return False
        ElseIf (txt_tongtien.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập", "Thông báo")
            Return False
        ElseIf (txt_mota.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lònng nhập", "Thông báo")
            Return False
        End If

        Return True
    End Function
    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_idhd.TextChanged, txt_idhd.TextChanged, txt_idhd.TextChanged
        If (txt_idhd.Text.Trim = "") Then
            bntthem.Enabled = False
        Else
            bntthem.Enabled = True
        End If
    End Sub

End Class
