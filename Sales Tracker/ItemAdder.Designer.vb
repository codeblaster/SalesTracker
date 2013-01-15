<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemAdder
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemAdder))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Code = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Title = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Qty = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Cost = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Total = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Date = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Title.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Cost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Date.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.txt_Date)
        Me.GroupControl1.Controls.Add(Me.txt_Total)
        Me.GroupControl1.Controls.Add(Me.txt_Cost)
        Me.GroupControl1.Controls.Add(Me.txt_Qty)
        Me.GroupControl1.Controls.Add(Me.txt_Title)
        Me.GroupControl1.Controls.Add(Me.txt_Code)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(-2, 1)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(300, 278)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Add New Item"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(10, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Sale Date"
        '
        'txt_Code
        '
        Me.txt_Code.Location = New System.Drawing.Point(75, 69)
        Me.txt_Code.Name = "txt_Code"
        Me.txt_Code.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Code.Properties.Appearance.Options.UseFont = True
        Me.txt_Code.Size = New System.Drawing.Size(209, 22)
        Me.txt_Code.StyleController = Me.StyleController1
        Me.txt_Code.TabIndex = 1
        '
        'txt_Title
        '
        Me.txt_Title.Location = New System.Drawing.Point(75, 104)
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Title.Properties.Appearance.Options.UseFont = True
        Me.txt_Title.Size = New System.Drawing.Size(209, 22)
        Me.txt_Title.StyleController = Me.StyleController1
        Me.txt_Title.TabIndex = 2
        '
        'txt_Qty
        '
        Me.txt_Qty.Location = New System.Drawing.Point(75, 136)
        Me.txt_Qty.Name = "txt_Qty"
        Me.txt_Qty.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Qty.Properties.Appearance.Options.UseFont = True
        Me.txt_Qty.Size = New System.Drawing.Size(209, 22)
        Me.txt_Qty.StyleController = Me.StyleController1
        Me.txt_Qty.TabIndex = 3
        '
        'txt_Cost
        '
        Me.txt_Cost.Location = New System.Drawing.Point(75, 168)
        Me.txt_Cost.Name = "txt_Cost"
        Me.txt_Cost.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cost.Properties.Appearance.Options.UseFont = True
        Me.txt_Cost.Size = New System.Drawing.Size(209, 22)
        Me.txt_Cost.StyleController = Me.StyleController1
        Me.txt_Cost.TabIndex = 4
        '
        'txt_Total
        '
        Me.txt_Total.Location = New System.Drawing.Point(75, 203)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Properties.Appearance.Options.UseFont = True
        Me.txt_Total.Size = New System.Drawing.Size(209, 22)
        Me.txt_Total.StyleController = Me.StyleController1
        Me.txt_Total.TabIndex = 5
        '
        'txt_Date
        '
        Me.txt_Date.EditValue = Nothing
        Me.txt_Date.Location = New System.Drawing.Point(75, 35)
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Date.Properties.Appearance.Options.UseFont = True
        Me.txt_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Date.Properties.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.txt_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_Date.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_Date.Size = New System.Drawing.Size(209, 22)
        Me.txt_Date.StyleController = Me.StyleController1
        Me.txt_Date.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(10, 72)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Item Code"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(10, 107)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Item Title"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(10, 139)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Item Qty"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(10, 172)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "Item Cost"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(10, 206)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Item Total"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(75, 237)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "Add"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(156, 237)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "Cancel"
        '
        'StyleController1
        '
        Me.StyleController1.AppearanceFocused.BackColor = System.Drawing.Color.Gray
        Me.StyleController1.AppearanceFocused.BorderColor = System.Drawing.Color.Black
        Me.StyleController1.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StyleController1.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.StyleController1.AppearanceFocused.Options.UseBackColor = True
        Me.StyleController1.AppearanceFocused.Options.UseBorderColor = True
        Me.StyleController1.AppearanceFocused.Options.UseFont = True
        Me.StyleController1.AppearanceFocused.Options.UseForeColor = True
        '
        'ItemAdder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 283)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ItemAdder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItemAdder"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Title.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Cost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Date.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_Total As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Cost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Title As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
End Class
