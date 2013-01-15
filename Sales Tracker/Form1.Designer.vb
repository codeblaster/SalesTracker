<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RepositoryItemComboBox5 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.LoadCSVDialog = New System.Windows.Forms.OpenFileDialog()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.TbltempBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesDataSet = New Sales_Tracker.SalesDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChannelID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemVATAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemVATRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TbltempBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_tempTableAdapter = New Sales_Tracker.SalesDataSetTableAdapters.tbl_tempTableAdapter()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ListBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_ChName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ChannelId = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.txt_Date = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.RepositoryItemComboBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltempBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltempBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_ChName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ChannelId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Date.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepositoryItemComboBox5
        '
        Me.RepositoryItemComboBox5.AutoHeight = False
        Me.RepositoryItemComboBox5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox5.Name = "RepositoryItemComboBox5"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.TbltempBindingSource1
        Me.GridControl1.Location = New System.Drawing.Point(2, 147)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(918, 340)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'TbltempBindingSource1
        '
        Me.TbltempBindingSource1.DataMember = "tbl_temp"
        Me.TbltempBindingSource1.DataSource = Me.SalesDataSet
        '
        'SalesDataSet
        '
        Me.SalesDataSet.DataSetName = "SalesDataSet"
        Me.SalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Green
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChannelID, Me.colSalesDate, Me.colItemQty, Me.colItemTitle, Me.colItemCode, Me.colItemCost, Me.colItemVATAmount, Me.colItemVATRate, Me.colItemTotal})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        '
        'colChannelID
        '
        Me.colChannelID.FieldName = "ChannelID"
        Me.colChannelID.Name = "colChannelID"
        Me.colChannelID.OptionsColumn.AllowEdit = False
        '
        'colSalesDate
        '
        Me.colSalesDate.FieldName = "SalesDate"
        Me.colSalesDate.Name = "colSalesDate"
        Me.colSalesDate.OptionsColumn.AllowEdit = False
        Me.colSalesDate.Visible = True
        Me.colSalesDate.VisibleIndex = 0
        '
        'colItemQty
        '
        Me.colItemQty.FieldName = "ItemQty"
        Me.colItemQty.Name = "colItemQty"
        Me.colItemQty.OptionsColumn.AllowEdit = False
        Me.colItemQty.Visible = True
        Me.colItemQty.VisibleIndex = 1
        '
        'colItemTitle
        '
        Me.colItemTitle.FieldName = "ItemTitle"
        Me.colItemTitle.Name = "colItemTitle"
        Me.colItemTitle.OptionsColumn.AllowEdit = False
        Me.colItemTitle.Visible = True
        Me.colItemTitle.VisibleIndex = 2
        '
        'colItemCode
        '
        Me.colItemCode.FieldName = "ItemCode"
        Me.colItemCode.Name = "colItemCode"
        Me.colItemCode.OptionsColumn.AllowEdit = False
        Me.colItemCode.Visible = True
        Me.colItemCode.VisibleIndex = 3
        '
        'colItemCost
        '
        Me.colItemCost.FieldName = "ItemCost"
        Me.colItemCost.Name = "colItemCost"
        Me.colItemCost.OptionsColumn.AllowEdit = False
        Me.colItemCost.Visible = True
        Me.colItemCost.VisibleIndex = 4
        '
        'colItemVATAmount
        '
        Me.colItemVATAmount.FieldName = "ItemVATAmount"
        Me.colItemVATAmount.Name = "colItemVATAmount"
        Me.colItemVATAmount.OptionsColumn.AllowEdit = False
        Me.colItemVATAmount.Visible = True
        Me.colItemVATAmount.VisibleIndex = 5
        '
        'colItemVATRate
        '
        Me.colItemVATRate.FieldName = "ItemVATRate"
        Me.colItemVATRate.Name = "colItemVATRate"
        Me.colItemVATRate.OptionsColumn.AllowEdit = False
        Me.colItemVATRate.Visible = True
        Me.colItemVATRate.VisibleIndex = 6
        '
        'colItemTotal
        '
        Me.colItemTotal.FieldName = "ItemTotal"
        Me.colItemTotal.Name = "colItemTotal"
        Me.colItemTotal.OptionsColumn.AllowEdit = False
        Me.colItemTotal.Visible = True
        Me.colItemTotal.VisibleIndex = 7
        '
        'TbltempBindingSource
        '
        Me.TbltempBindingSource.DataMember = "tbl_temp"
        Me.TbltempBindingSource.DataSource = Me.SalesDataSet
        '
        'Tbl_tempTableAdapter
        '
        Me.Tbl_tempTableAdapter.ClearBeforeFill = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        '
        '
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarButtonItem17, Me.BarEditItem1, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarEditItem2, Me.BarStaticItem1, Me.BarButtonItem11})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 29
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.PageHeaderItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemComboBox3})
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(938, 120)
        Me.RibbonControl1.Toolbar.ItemLinks.Add(Me.BarEditItem1)
        Me.RibbonControl1.Toolbar.ItemLinks.Add(Me.BarButtonItem18)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Load CSV"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.LargeGlyph = CType(resources.GetObject("BarButtonItem4.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Process"
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.LargeGlyph = CType(resources.GetObject("BarButtonItem5.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Export CSV"
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.LargeGlyph = CType(resources.GetObject("BarButtonItem6.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Print Reports"
        Me.BarButtonItem7.Id = 7
        Me.BarButtonItem7.LargeGlyph = CType(resources.GetObject("BarButtonItem7.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Add Sales Channel"
        Me.BarButtonItem8.Id = 8
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Add Record"
        Me.BarButtonItem9.Id = 10
        Me.BarButtonItem9.LargeGlyph = CType(resources.GetObject("BarButtonItem9.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Delete Record"
        Me.BarButtonItem10.Id = 11
        Me.BarButtonItem10.LargeGlyph = CType(resources.GetObject("BarButtonItem10.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Add Channel"
        Me.BarButtonItem12.Id = 14
        Me.BarButtonItem12.LargeGlyph = CType(resources.GetObject("BarButtonItem12.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Load All Sales"
        Me.BarButtonItem13.Id = 15
        Me.BarButtonItem13.LargeGlyph = CType(resources.GetObject("BarButtonItem13.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Weekly Report"
        Me.BarButtonItem14.Id = 16
        Me.BarButtonItem14.LargeGlyph = CType(resources.GetObject("BarButtonItem14.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Sales Summary"
        Me.BarButtonItem15.Id = 17
        Me.BarButtonItem15.LargeGlyph = CType(resources.GetObject("BarButtonItem15.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Refund"
        Me.BarButtonItem16.Id = 18
        Me.BarButtonItem16.LargeGlyph = CType(resources.GetObject("BarButtonItem16.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "BarButtonItem17"
        Me.BarButtonItem17.Id = 20
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "Select channel from here prior attempting any operation"
        Me.BarEditItem1.Edit = Me.RepositoryItemComboBox2
        Me.BarEditItem1.Id = 21
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "BarButtonItem18"
        Me.BarButtonItem18.Glyph = CType(resources.GetObject("BarButtonItem18.Glyph"), System.Drawing.Image)
        Me.BarButtonItem18.Id = 22
        Me.BarButtonItem18.LargeGlyph = CType(resources.GetObject("BarButtonItem18.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Select Channel"
        Me.BarButtonItem19.Glyph = CType(resources.GetObject("BarButtonItem19.Glyph"), System.Drawing.Image)
        Me.BarButtonItem19.Id = 24
        Me.BarButtonItem19.LargeGlyph = CType(resources.GetObject("BarButtonItem19.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarEditItem2
        '
        Me.BarEditItem2.Caption = "BarEditItem2"
        Me.BarEditItem2.Edit = Me.RepositoryItemComboBox5
        Me.BarEditItem2.Id = 26
        Me.BarEditItem2.Name = "BarEditItem2"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem1.Appearance.Options.UseFont = True
        Me.BarStaticItem1.Caption = "<>"
        Me.BarStaticItem1.Id = 27
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Today's Sales"
        Me.BarButtonItem11.Id = 28
        Me.BarButtonItem11.LargeGlyph = CType(resources.GetObject("BarButtonItem11.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6, Me.RibbonPageGroup1, Me.RibbonPageGroup3, Me.RibbonPageGroup4, Me.RibbonPageGroup5})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Sales Tracker"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem19)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "Channel "
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem13)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Sales Tracking Management"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem9)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem10)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem16)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Editing Options"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem12)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Settings"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem11)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem14)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem15)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Custom Reports"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem8)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Settings"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(2, 121)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(914, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 2
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        '
        'BackgroundWorker3
        '
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.ListBoxControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(2, 121)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(164, 202)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Channel Select"
        Me.GroupControl1.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(106, 1)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(50, 20)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "OK"
        '
        'ListBoxControl1
        '
        Me.ListBoxControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxControl1.Appearance.Options.UseFont = True
        Me.ListBoxControl1.Location = New System.Drawing.Point(5, 25)
        Me.ListBoxControl1.Name = "ListBoxControl1"
        Me.ListBoxControl1.Size = New System.Drawing.Size(154, 172)
        Me.ListBoxControl1.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SimpleButton3)
        Me.PanelControl1.Controls.Add(Me.txt_ChName)
        Me.PanelControl1.Controls.Add(Me.txt_ChannelId)
        Me.PanelControl1.Controls.Add(Me.SimpleButton2)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(495, 121)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(200, 112)
        Me.PanelControl1.TabIndex = 6
        Me.PanelControl1.Visible = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(174, 88)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(26, 23)
        Me.SimpleButton3.TabIndex = 5
        '
        'txt_ChName
        '
        Me.txt_ChName.Location = New System.Drawing.Point(64, 43)
        Me.txt_ChName.MenuManager = Me.RibbonControl1
        Me.txt_ChName.Name = "txt_ChName"
        Me.txt_ChName.Size = New System.Drawing.Size(131, 20)
        Me.txt_ChName.TabIndex = 4
        '
        'txt_ChannelId
        '
        Me.txt_ChannelId.Location = New System.Drawing.Point(64, 17)
        Me.txt_ChannelId.MenuManager = Me.RibbonControl1
        Me.txt_ChannelId.Name = "txt_ChannelId"
        Me.txt_ChannelId.Size = New System.Drawing.Size(131, 20)
        Me.txt_ChannelId.TabIndex = 3
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(64, 74)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "Add Channel"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(7, 50)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Channel"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Channel ID"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.DateEdit1)
        Me.PanelControl2.Controls.Add(Me.txt_Date)
        Me.PanelControl2.Location = New System.Drawing.Point(578, 121)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(200, 127)
        Me.PanelControl2.TabIndex = 8
        Me.PanelControl2.Visible = False
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(16, 91)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(162, 23)
        Me.SimpleButton4.TabIndex = 5
        Me.SimpleButton4.Text = "Show Reports"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(19, 47)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "End Date"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(18, 5)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Start Date"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(16, 62)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(162, 22)
        Me.DateEdit1.TabIndex = 2
        '
        'txt_Date
        '
        Me.txt_Date.EditValue = Nothing
        Me.txt_Date.Location = New System.Drawing.Point(16, 21)
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Date.Properties.Appearance.Options.UseFont = True
        Me.txt_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Date.Properties.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.txt_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_Date.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_Date.Size = New System.Drawing.Size(162, 22)
        Me.txt_Date.TabIndex = 1
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.SimpleButton5)
        Me.GroupControl2.Controls.Add(Me.RichTextBox1)
        Me.GroupControl2.Location = New System.Drawing.Point(303, 186)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(387, 218)
        Me.GroupControl2.TabIndex = 10
        Me.GroupControl2.Text = "Today's Sale"
        Me.GroupControl2.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.RichTextBox1.Location = New System.Drawing.Point(5, 23)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(377, 190)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Location = New System.Drawing.Point(324, 0)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(58, 20)
        Me.SimpleButton5.TabIndex = 1
        Me.SimpleButton5.Text = "Close"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 416)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Teletape - Sales Tracker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepositoryItemComboBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltempBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltempBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_ChName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ChannelId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Date.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoadCSVDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SalesDataSet As Sales_Tracker.SalesDataSet
    Friend WithEvents TbltempBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_tempTableAdapter As Sales_Tracker.SalesDataSetTableAdapters.tbl_tempTableAdapter
    Friend WithEvents colChannelID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemVATAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemVATRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TbltempBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListBoxControl1 As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RepositoryItemComboBox5 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txt_ChName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ChannelId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txt_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton

End Class
