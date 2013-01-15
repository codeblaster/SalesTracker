Imports System.Data.OleDb   
Public Class ItemAdder 
        Dim ConnString As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;data source={0}\data\teletape.accdb;", Application.StartupPath)

Private Sub ItemAdder_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
End Sub

Private Sub SimpleButton1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim CurrentSale As New Sale 
    If(isFilled)then
        CurrentSale.SalesDate = Trim(txt_Date.Text)
        CurrentSale.ItemCode = Trim(txt_Code.Text )
        CurrentSale.ItemCost = Trim(txt_Cost.Text)
        CurrentSale.ItemQty = Trim(txt_Qty.Text)
        CurrentSale.ItemTitle = Trim(txt_Title.Text)
        CurrentSale.ItemVATAmount = "20"
        CurrentSale.ItemVATRate =  ((Double.Parse(txt_Cost.Text,Globalization.NumberStyles.Currency)* Double.Parse(txt_Qty.Text,Globalization.NumberStyles.Currency)) / 100.00) * (20.00)
        CurrentSale.ItemTotal = (Double.Parse(txt_Cost.Text,Globalization.NumberStyles.Currency) * Double.Parse(txt_Qty.Text,Globalization.NumberStyles.Currency)) + CurrentSale.ItemVATRate        
        CurrentSale.ChannelId = "01"
        AddToSales(CurrentSale) 
        End If
         
End Sub

Private Sub AddToSales(currentSale As Sale)
        Try
            
            Using con As New OleDbConnection(ConnString)
             con.Open 
             Dim InsertCommand As New OleDbCommand(String.Format("insert into tbl_temp values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",currentSale.ChannelId,currentSale.SalesDate,currentSale.ItemQty,currentSale.ItemTitle,currentSale.ItemCode,currentSale.ItemCost,currentSale.ItemVATAmount,currentSale.ItemVATRate,currentSale.ItemTotal))
             InsertCommand.Connection = con  
             InsertCommand.ExecuteNonQuery()  
            con.Close
            MsgBox("The record has been added to sales")
                ClearAll()
        End Using
            
        Catch ex As Exception
            MsgBox(ex.ToString ) 
        End Try
End Sub
Private Function isFilled() As Boolean
        Dim retval As Boolean 
        If(txt_Code.Text.Trim.Length   = 0) then
            MsgBox ("Item Code seems to be empty")
            txt_Code.Focus  
            retval =  False 
        ElseIf (txt_Cost.Text.Trim.Length =0)then
            MsgBox("Item Cost seems to be empty")
            txt_Cost.Focus  
            retval =  False
        ElseIf (txt_Date.Text.Trim.Length =0) then
            MsgBox("Sales Date seems to be empty")
            txt_Date.Focus 
            retval =  False
        ElseIf (txt_Qty.Text.Trim.Length =0) then
            MsgBox ("Item Quantity seems to be empty")
            txt_Qty.Focus 
            retval =  False 
        ElseIf (txt_Title.Text .Trim .Length =0) then
            MsgBox ("Item Title seems to be empty")
            txt_Title.Focus 
            retval =  False
        ElseIf (txt_Total.Text.Trim.Length =0)then
            MsgBox ("Item Total seems to be empty")
            txt_Total.Focus 
        Else
            retval =  True 
        End If
        Return retval 
End Function
Private Sub ClearAll()
        txt_Code.Text = String.Empty  
        txt_Cost.Text = String.Empty 
        txt_Date.Text = String.Empty 
        txt_Qty.Text = String.Empty 
        txt_Title.Text = String.Empty 
        txt_Total.Text = String.Empty 
        txt_Date.Focus()  
End Sub

    Private Sub txt_Total_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Total.GotFocus
        Dim VATAmount As Double = ((Double.Parse(txt_Cost.Text)* Double.Parse(txt_Qty.Text)) / 100.0) * (20.00)
        txt_Total.Text =  (Double.Parse(txt_Cost.Text) * Double.Parse(txt_Qty.Text)) + VATAmount  
         
    End Sub
End Class