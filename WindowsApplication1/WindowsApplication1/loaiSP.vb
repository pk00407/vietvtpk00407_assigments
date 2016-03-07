
Imports System.Data
    Imports System.Data.SqlClient
Public Class loaiSP
    Dim abc As New SqlConnection("workstation id=vietvtpk00407.mssql.somee.com;packet size=4096;user id=vietvtpk00407_SQLLogin_1;pwd=qj6fp3vf1g;data source=vietvtpk00407.mssql.somee.com;persist security info=False;initial catalog=vietvtpk00407")
    Private Sub loaddata()
        abc.Open()
        Dim load As New SqlCommand("select * from Loai_SP", abc)
        Dim data As New SqlDataAdapter(load)
        Dim data1 As New DataTable
        data.Fill(data1)
        abc.Close()
        lstloaisp.Items.Clear()
        Dim b As Integer
        For Each Row As DataRow In data1.Rows
            lstloaisp.Items.Add(Row("idloaiSP").ToString())
            lstloaisp.Items(b).SubItems.Add(Row("tenloaisp").ToString())
            lstloaisp.Items(b).SubItems.Add(Row("mota").ToString())

            b += 1
        Next
    End Sub
    Private Sub frmloaisp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub frmloaisp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Bạn có muốn thoát khỏi chương trình không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "THOÁT") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ClearBox()

        txt_idloaisp.Text = ""
        txt_tenloaisp.Text = ""

        txt_mota.Text = ""



    End Sub



    Private Sub lstloaisp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstloaisp.SelectedIndexChanged
        If lstloaisp.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lstloaisp.SelectedItems
                txt_idloaisp.Text = lis.SubItems(0).Text
                txt_tenloaisp.Text = lis.SubItems(1).Text

                txt_mota.Text = lis.SubItems(2).Text


                bntxoa.Enabled = True
                bntsua.Enabled = True
            Next
        End If
    End Sub
    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_idloaisp.TextChanged, txt_idloaisp.TextChanged
        If (txt_idloaisp.Text.Trim = "") Then
            bntthem.Enabled = False


        Else
            bntthem.Enabled = True


        End If
    End Sub

    Private Function KiemTraThongTin() As Boolean

        If (txt_idloaisp.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã loại sp", "Thông báo")
            Return False
        ElseIf (txt_tenloaisp.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập tên loại SP", "Thông báo")
            Return False



        End If

        Return True
    End Function

    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        If (KiemTraThongTin() = True) Then
            Try
                abc.Open()
                Dim idloaisp As String = txt_idloaisp.Text
                Dim tenloaisp As String = txt_tenloaisp.Text

                Dim mota As String = txt_mota.Text

                Dim them As New SqlCommand("Insert into Loai_SP(idloaisp,tenloaisp,mota) values('" + idloaisp + "' , N'" + tenloaisp + "',N'" + mota + "')", abc)
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

    Private Sub bntxoa_Click(sender As Object, e As EventArgs) Handles bntxoa.Click
        Try
            abc.Open()
            Dim idloaisp As String = txt_idloaisp.Text
            Dim xoa As New SqlCommand("delete from Loai_SP where idloaisp ='" + idloaisp + "'", abc)
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

            Dim idloaisp As String = txt_idloaisp.Text
            Dim tenloaisp As String = txt_tenloaisp.Text

            Dim mota As String = txt_mota.Text

            Dim sua As New SqlCommand("update Loai_SP set   tenloaisp = '" + tenloaisp + "',  mota = '" + mota + "' where idloaisp = '" + idloaisp + "' ", abc)
            sua.ExecuteNonQuery()
            abc.Close()
            MessageBox.Show("Bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            loaddata()
        Catch ex As Exception
            MessageBox.Show("Sửa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class