Imports System.Data.OleDb
Imports System.Threading
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Text.RegularExpressions

Public Class Form1
    Dim ConnString As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;data source={0}\data\teletape.accdb;", Application.StartupPath) 
    Private _ActiveSalesChannel As String 
    Private _ChannelCollection As New Dictionary(Of String,String) 
    <STAThread()> _
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalesDataSet.tbl_temp' table. You can move, or remove it, as needed.
        ' Me.Tbl_tempTableAdapter.Fill(Me.SalesDataSet.tbl_temp)
        'Me.GridControl1.Refresh  
        GetChannelCollection()
        ListBoxControl1.Items.Clear   
        For Each channel In _ChannelCollection
              ListBoxControl1.Items.Add(channel.Key)     
        Next
        BarStaticItem1.Caption = "Please select a channel prior performing any operation.."
        BarStaticItem1.Appearance.BackColor = color.Red   
    End Sub

    Private Sub LoadCSV(ByVal FileName As String, ByVal ChannelID As String)

        Dim TempLoaderConn As New OleDbConnection(ConnString)
        Try

            Dim TempLoaderCommand As New OleDbCommand()
            Dim DeleteAllRecCommand As New OleDbCommand()
            TempLoaderConn.Open()
            TempLoaderCommand.Connection = TempLoaderConn
            DeleteAllRecCommand.Connection = TempLoaderConn
            Dim soldcontent() As String = IO.File.ReadAllLines(FileName)
            Dim fields() As String
            Dim inc As Integer
            Dim AllTotal As Double =0
            Dim progress As Integer = 0
            ProgressBar1.Invoke(New SetProgressCallback(AddressOf SetProgress), soldcontent.Length)
            DeleteAllRecCommand.CommandText = "delete from tbl_temp"
            DeleteAllRecCommand.ExecuteNonQuery()
            DeleteAllRecCommand.CommandText = "delete from tbl_tempT"
            DeleteAllRecCommand.ExecuteNonQuery()
            For Each line In soldcontent
                BackgroundWorker1.ReportProgress(progress)
                fields = line.Split(",")    
                If Not (fields(0).Equals("Customer Name")) Then
                    If (fields.Length > 43) Then
                        inc = fields.Length - 43
                        TempLoaderCommand.CommandText = String.Format("insert into tbl_temp values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", ChannelID, fields(20).Replace("""", "") , fields(23).Replace("""", ""), fields(28 + inc).Replace("""", ""), fields(26).Replace("""", ""), fields(29 + inc).Replace("""", ""), fields(30 + inc).Replace("""", ""), fields(31 + inc).Replace("""", ""), fields(32 + inc).Replace("""", ""))
                        TempLoaderCommand.ExecuteNonQuery()
                        AllTotal += Double.Parse(fields(32 + inc).Replace("""", ""),Globalization.NumberStyles.Currency)   
                    Else
                        TempLoaderCommand.CommandText = String.Format("insert into tbl_temp values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", ChannelID, fields(20).Replace("""", ""), fields(23).Replace("""", ""), fields(28).Replace("""", ""), fields(26).Replace("""", ""), fields(29).Replace("""", ""), fields(30).Replace("""", ""), fields(31).Replace("""", ""), fields(32).Replace("""", ""))
                        TempLoaderCommand.ExecuteNonQuery()
                        AllTotal += Double.Parse(fields(32).Replace("""", ""),Globalization.NumberStyles.Currency)
                    End If
                        
                End If
                progress += 1
            Next
            TempLoaderCommand.CommandText = String.Format("insert into tbl_tempT values('{0}','{1}')",_ActiveSalesChannel,AllTotal)
            TempLoaderCommand.ExecuteNonQuery  ()
            TempLoaderConn.Close()
            UpdateSalesTotal(_ActiveSalesChannel,AllTotal)   
            'MsgBox ("Complete")
        Catch ex As Exception
            TempLoaderConn.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub WriteObjectsToDB()
        Dim AllRecords As new List(Of Object)
        AllRecords = GetAllRecords()
        Dim InsertCommand As New OleDbCommand 
        Try
            Dim progress As Integer = 0
            ProgressBar1.Invoke(New SetProgressCallback(AddressOf SetProgress),AllRecords.Count )
             Using con As New OleDbConnection(ConnString)
             con.Open 
             InsertCommand.Connection = con
                For Each record In AllRecords 
                    Dim objRec As DataRow  = record
                         InsertCommand.CommandText = String.Format("insert into tbl_sales values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",objRec.Item(0),objRec.Item(1),objRec.Item(2),objRec.Item(3),objRec.Item(4),objRec.Item(5),objRec.Item(6),objRec.Item(7),objRec.Item(8))
                         InsertCommand.ExecuteNonQuery()
                         BackgroundWorker2.ReportProgress(progress)   
                    
                    progress += 1
                Next
            
            con.Close
            MsgBox("The records have been added to Central DB",MsgBoxStyle.Information )
        End Using
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetAllRecords() As List(Of Object) 
        Dim RowObjects As new List(Of Object) 
        For i=0 to GridView1.RowCount 
            Dim rowhandle As Integer = GridView1.GetVisibleRowHandle(i)
            If(GridView1.IsDataRow (rowhandle ))then
                 
                 Dim rowobj As Object = GridView1.GetDataRow(rowhandle)
                 RowObjects.Add (rowobj)  
            End If
        Next
        Return RowObjects 
    End Function 
        Private Sub GetChannelCollection
         Using con As New OleDbConnection(ConnString)
                con.Open
                Dim ChannelReader As OleDbDataReader 
                Dim DeleteAllRecCommand As New OleDbCommand() 
                DeleteAllRecCommand.Connection = con   
                DeleteAllRecCommand.CommandText = "select *  from tbl_Channel"
                ChannelReader = DeleteAllRecCommand.ExecuteReader 
                While(ChannelReader.Read())  
                    _ChannelCollection.Add (ChannelReader.GetString(1).Trim ,ChannelReader.GetString(0).Trim )     
                End While
                con.Close 
            End Using
    End Sub
    Private Sub ConnectToGrid()
        Try
            Dim ConnectSet As New DataSet
            Using con As New OleDbConnection(ConnString)
                Using FillAdapter As New OleDbDataAdapter("SELECT ChannelID, SalesDate, ItemQty, ItemTitle, ItemCode, ItemCost, ItemVATAmount, ItemVATRate, ItemTotal FROM tbl_temp", con)
                    FillAdapter.Fill(ConnectSet, "TempSales")
                    GridControl1.DataSource = ConnectSet.Tables(0)
                    GridControl1.Refresh()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub SetGridSource(ByVal dataset As DataTable)
        GridControl1.DataSource = dataset   
    End Sub
    Public Delegate Sub SetGridSourceCallback(ByVal ds As DataTable)
        Private Sub ConnectToGridAll()
        Try
            Dim ConnectTab As New DataTable 
            Dim ConnectSet As New DataSet 
            Using con As New OleDbConnection(ConnString)
                Using FillAdapter As New OleDbDataAdapter("SELECT ChannelID, SalesDate, ItemQty, ItemTitle, ItemCode, ItemCost, ItemVATAmount, ItemVATRate, ItemTotal FROM tbl_sales", con)
                    FillAdapter.Fill(ConnectSet, "TempSales")
                    ConnectTab = ConnectSet.Tables(0)  
                    GridControl1.Invoke (New SetGridSourceCallback (AddressOf SetGridSource),ConnectSet.Tables(0))
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub DeleteRecord(ByVal ItemID As String)
        Try
            Dim ConnectSet As New DataSet
            If (MsgBox(String.Format("Are you sure you want to delete the record with ItemCode {0} ?", ItemID), MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes) Then
                Using con As New OleDbConnection(ConnString)
                    con.Open()
                    Dim DeleteCommand As New OleDbCommand(String.Format("Delete FROM tbl_temp where ItemCode='{0}'", ItemID))
                    DeleteCommand.Connection = con
                    DeleteCommand.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Selected record has been deleted",MsgBoxStyle.Information )
                    ConnectToGrid()
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub SetProgress(ByVal progressmax As Integer)
        ProgressBar1.Maximum = progressmax
    End Sub
    Public Delegate Sub SetProgressCallback(ByVal mx As Integer)
    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Tbl_tempTableAdapter.Fill(Me.SalesDataSet.tbl_temp)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Function IsRowClickedValid(ByVal view As GridView, ByVal pt As Point) As Boolean
        Dim retval As Boolean 
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRow OrElse info.InRowCell Then
            If info.Column Is Nothing Then
                retval =  False
            Else
                retval = True
            End If
        End If
        Return retval 
    End Function
    Private Sub FillToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Tbl_tempTableAdapter.Fill(Me.SalesDataSet.tbl_temp)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        GridControl1.Width = Me.Width - 10
        GridControl1.Height = Me.Height - 200
        ProgressBar1.Width = Me.Width - 20
    End Sub
    Dim _SelectedFileName As String
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
      '  _TaskType = 0 
        LoadCSVDialog.ShowDialog()
        _SelectedFileName = LoadCSVDialog.FileName
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
   ' If(_TaskType = 0)then
            LoadCSV(_SelectedFileName, _ActiveSalesChannel)
    'End If
    'If(_TaskType = 1) then
           ' ConnectToGridAll 
    'End If
    
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
       ' If(_TaskType =0) then
            ConnectToGrid()
        ProgressBar1.Value = 0
        'End If
        
    End Sub
    Dim _SelectedID As String
    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        Dim view As GridView = CType(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        If (IsRowClickedValid(view, pt) = True) Then
            _SelectedID = Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(4)).ToString()
        End If
    End Sub

    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        'MsgBox ("Selected ItemCode : " & _SelectedID) 
        Dim Adder As ItemAdder = New ItemAdder()
        Adder.ShowDialog()
    End Sub

    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
    If Not (_SelectedID.Trim.Length =0)then
              DeleteRecord(_SelectedID)
            Else
            MsgBox("Please select a row to delete",MsgBoxStyle.Information,"Delete Info") 
    End If
  
    End Sub
Private Sub UpdateSalesTotal(ByVal channelId As String,ByVal total As String)
        
        Try
            Using con As New OleDbConnection(ConnString)
                con.Open 
                Dim DeleteAllRecCommand As New OleDbCommand() 
                DeleteAllRecCommand.Connection = con  
                DeleteAllRecCommand.CommandText = String.Format("insert into tbl_today values('{0}','{1}',{2})",Now.ToString,channelId,Double.Parse(  total,Globalization.NumberStyles.Currency ))    
                DeleteAllRecCommand.ExecuteNonQuery()
                con.Close 
            End Using
        Catch ex As Exception
            MsgBox (ex.ToString )
        End Try
End Sub
Private Sub BarButtonItem5_ItemClick( ByVal sender As System.Object,  ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
       BackgroundWorker2.RunWorkerAsync  
       
End Sub

Private Sub BackgroundWorker2_DoWork( ByVal sender As System.Object,  ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Try
            WriteObjectsToDB 
        Catch ex As Exception
            MsgBox (ex.ToString )
        End Try
        
End Sub

    Private Sub BackgroundWorker2_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
         ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
            
            Using con As New OleDbConnection(ConnString)
                con.Open 
                Dim DeleteAllRecCommand As New OleDbCommand() 
                DeleteAllRecCommand.Connection = con  
                DeleteAllRecCommand.CommandText = "delete from tbl_temp"
                DeleteAllRecCommand.ExecuteNonQuery()
                con.Close 
            End Using
            ConnectToGrid ()
            ProgressBar1.Value = 0
            
    End Sub
    Dim _TaskType As Integer = 0 
Private Sub BarButtonItem13_ItemClick( ByVal sender As System.Object,  ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        '_TaskType = 1
        BackgroundWorker3.RunWorkerAsync  
        GridControl1.Refresh()
End Sub

Private Sub BackgroundWorker3_DoWork( ByVal sender As System.Object,  ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
         ConnectToGridAll()
End Sub
Dim rpt_Sale As New rpt_Sales 
Private Sub BarButtonItem7_ItemClick( ByVal sender As System.Object,  ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        If(MsgBox("You're about to print the reports of currently loaded sales channel,Continue to print reports?",MsgBoxStyle.YesNo,"Confirm Print")=MsgBoxResult.Yes )then
            Dim rpt As new System.Drawing.Printing.PrintDocument
            rpt_Sale.RecordSelectionFormula = "{tbl_temp.ChannelID}='" & _ActiveSalesChannel & "'"
            rpt_Sale.PrintOptions.PrinterName = rpt.PrinterSettings.PrinterName      
            rpt_Sale.Refresh  
            rpt_Sale.PrintToPrinter(1,False,0,0)
            'rpt_Sale.ExportToDisk (CrystalDecisions.Shared.ExportFormatType.CharacterSeparatedValues,"something.csv")             
                    
        End If
           
End Sub
Private Sub ExportToCsv()
        Dim oWrite As System.IO.StreamWriter
        Dim AllRecords As New List(Of Object)
        Dim outpath As String 
        AllRecords = GetAllRecords 
        Try
            outpath = IO.Path.Combine(Application.StartupPath.ToString,"Exports",ListBoxControl1.SelectedValue.ToString & Now.Day.ToString & Now.Month.ToString & Now.Year.ToString &".csv").ToString
            oWrite = System.IO.File.CreateText(outpath)
            oWrite.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}","Channel","SalesDate","ItemQty","ItemCode","ItemTitle","ItemCost","ItemVATAmount","ItemVATRate","ItemTotal"))
            For Each record In AllRecords 
                Dim rowdata As DataRow = record 
                oWrite.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}",rowdata(0).ToString ,rowdata(1).ToString ,rowdata(2).ToString ,rowdata(3).ToString ,rowdata(4).ToString ,rowdata(5).ToString ,rowdata(6).ToString ,rowdata(7).ToString ,rowdata(8).ToString )
            Next
            oWrite.Close  
        Catch ex As Exception
            MsgBox (ex.ToString )
        End Try
End Sub
Private Sub BarButtonItem19_ItemClick( ByVal sender As System.Object,  ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        GroupControl1 .Visible = True  
End Sub

Private Sub SimpleButton1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If(_ChannelCollection.ContainsKey(ListBoxControl1.SelectedValue.ToString))
             _ChannelCollection.TryGetValue(ListBoxControl1.SelectedValue.ToString,_ActiveSalesChannel)       
        End If
        BarStaticItem1.Caption = "Active Channel : " & ListBoxControl1.SelectedValue.ToString  
        BarStaticItem1.Appearance.BackColor = color.Green   
        GroupControl1.Visible = False  
End Sub

Private Sub BarButtonItem6_ItemClick( ByVal sender As System.Object,  ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
 If(MsgBox("You're about to export the reports of currently loaded sales channel,Continue to export reports?",MsgBoxStyle.YesNoCancel,"Confirm Print")=MsgBoxResult.Yes )then
        ExportToCsv
    MsgBox ("Export Succesful..Please find the exported files in 'Exports' folder of the application path")
 End If
 
End Sub

Private Sub SimpleButton2_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SimpleButton2.Click
                Try
             Using con As New OleDbConnection(ConnString)
                con.Open 
                Dim DeleteAllRecCommand As New OleDbCommand() 
                DeleteAllRecCommand.Connection = con  
                DeleteAllRecCommand.CommandText = String.Format ("insert into tbl_Channel values('{0}','{1}')",txt_ChannelId.Text.Trim ,txt_ChName.Text.Trim)     
                DeleteAllRecCommand.ExecuteNonQuery()
                con.Close
                MsgBox ("Added Channel Values",MsgBoxStyle.Information )
                _ChannelCollection.Clear  
                GetChannelCollection() 
                txt_ChannelId.Text = String.Empty 
                txt_ChName.Text = String.Empty  
                PanelControl1.Visible =False  
            End Using
                Catch ex As Exception
            MsgBox (ex.ToString) 
                End Try
            
End Sub

Private Sub BarButtonItem12_ItemClick( ByVal sender As System.Object,  ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        PanelControl1.Visible = True  
End Sub

Private Sub BarButtonItem11_ItemClick( ByVal sender As System.Object,  ByVal e As DevExpress.XtraBars.ItemClickEventArgs) 

End Sub

Private Sub SimpleButton3_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SimpleButton3.Click
        PanelControl1.Visible = False  
End Sub

Private Sub BarButtonItem16_ItemClick( ByVal sender As System.Object,  ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        MsgBox ("Functionaity yet to be discussed,I'm not clear on this",MsgBoxStyle.Exclamation )
End Sub

Private Sub txt_Date_EditValueChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles txt_Date.EditValueChanged

End Sub

Private Sub DateEdit1_EditValueChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles DateEdit1.EditValueChanged

End Sub
Dim _ReportType As Integer = 0
Private Sub BarButtonItem14_ItemClick( ByVal sender As System.Object,  ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        _ReportType = 0
        PanelControl2.Visible = True  
End Sub

Private Sub BarButtonItem15_ItemClick( ByVal sender As System.Object,  ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        _ReportType = 1
End Sub

Private Sub SimpleButton4_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SimpleButton4.Click
        PanelControl2.Visible = False  
End Sub
Private _TodaysTotal As New Dictionary(Of String,Double ) 
Private Sub BarButtonItem11_ItemClick_1( ByVal sender As System.Object,  ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        GroupControl2.Visible = True  
        Dim total As Double = 0 
        Dim TodayReader As OleDbDataReader 
        _TodaysTotal.Clear  
        RichTextBox1.Text = String.Empty  
        Try
            Using con As New OleDbConnection(ConnString)
        For Each channel In _ChannelCollection 
            
                con.Open 
                Dim DeleteAllRecCommand As New OleDbCommand()   
                DeleteAllRecCommand.Connection = con  
                DeleteAllRecCommand.CommandText = String.Format("select sum(total) from tbl_today where processdate='{0}' and channelid='{1}'",Now.ToString.Trim,channel.Value.Trim)
                TodayReader = DeleteAllRecCommand.ExecuteReader 
            If(TodayReader.HasRows) then
                    total = TodayReader.GetDecimal(0)  
            End If
            con.Close
            _TodaysTotal.Add (channel.Key,total)    
        Next
    End Using
        For Each salestotal In _TodaysTotal 
            RichTextBox1.AppendText(String.Format("{0} {1} : {2}",System.Environment.NewLine,salestotal.Key,salestotal.Value))            
        Next
        Catch ex As Exception
            MsgBox (ex.ToString )
        End Try
    
End Sub

Private Sub SimpleButton5_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SimpleButton5.Click
        GroupControl2.Visible = False  
End Sub
End Class
