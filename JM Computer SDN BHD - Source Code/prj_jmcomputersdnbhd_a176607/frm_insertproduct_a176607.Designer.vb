﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a176607
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertproduct_a176607))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.pic_back = New System.Windows.Forms.PictureBox()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.lbl_tagline = New System.Windows.Forms.Label()
        Me.lbl_series = New System.Windows.Forms.Label()
        Me.txt_series = New System.Windows.Forms.TextBox()
        Me.lbl_weight = New System.Windows.Forms.Label()
        Me.txt_weight = New System.Windows.Forms.TextBox()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_product_name = New System.Windows.Forms.Label()
        Me.lbl_product_id = New System.Windows.Forms.Label()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_product_name = New System.Windows.Forms.TextBox()
        Me.txt_product_id = New System.Windows.Forms.TextBox()
        Me.cmb_category = New System.Windows.Forms.ComboBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_photo = New System.Windows.Forms.Button()
        Me.txt_photo = New System.Windows.Forms.TextBox()
        Me.lbl_photo = New System.Windows.Forms.Label()
        Me.btn_clearphoto = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(226, 26)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(494, 50)
        Me.lbl_title.TabIndex = 19
        Me.lbl_title.Text = "ADD NEW PRODUCT"
        '
        'pic_logo
        '
        Me.pic_logo.BackColor = System.Drawing.Color.Transparent
        Me.pic_logo.BackgroundImage = CType(resources.GetObject("pic_logo.BackgroundImage"), System.Drawing.Image)
        Me.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_logo.Location = New System.Drawing.Point(12, 12)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(90, 81)
        Me.pic_logo.TabIndex = 18
        Me.pic_logo.TabStop = False
        '
        'pic_back
        '
        Me.pic_back.BackColor = System.Drawing.Color.Transparent
        Me.pic_back.BackgroundImage = CType(resources.GetObject("pic_back.BackgroundImage"), System.Drawing.Image)
        Me.pic_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_back.Location = New System.Drawing.Point(458, 497)
        Me.pic_back.Name = "pic_back"
        Me.pic_back.Size = New System.Drawing.Size(85, 81)
        Me.pic_back.TabIndex = 20
        Me.pic_back.TabStop = False
        '
        'grd_products
        '
        Me.grd_products.AllowUserToAddRows = False
        Me.grd_products.AllowUserToDeleteRows = False
        Me.grd_products.AllowUserToResizeColumns = False
        Me.grd_products.AllowUserToResizeRows = False
        Me.grd_products.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_products.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_products.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_products.DefaultCellStyle = DataGridViewCellStyle2
        Me.grd_products.Location = New System.Drawing.Point(100, 124)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_products.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grd_products.RowHeadersWidth = 51
        Me.grd_products.RowTemplate.Height = 24
        Me.grd_products.Size = New System.Drawing.Size(584, 204)
        Me.grd_products.TabIndex = 23
        '
        'lbl_tagline
        '
        Me.lbl_tagline.AutoSize = True
        Me.lbl_tagline.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tagline.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagline.Location = New System.Drawing.Point(287, 666)
        Me.lbl_tagline.Name = "lbl_tagline"
        Me.lbl_tagline.Size = New System.Drawing.Size(315, 28)
        Me.lbl_tagline.TabIndex = 24
        Me.lbl_tagline.Text = "Affordable Excellence of Tech"
        '
        'lbl_series
        '
        Me.lbl_series.AutoSize = True
        Me.lbl_series.BackColor = System.Drawing.Color.Transparent
        Me.lbl_series.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_series.Location = New System.Drawing.Point(420, 402)
        Me.lbl_series.Name = "lbl_series"
        Me.lbl_series.Size = New System.Drawing.Size(56, 20)
        Me.lbl_series.TabIndex = 58
        Me.lbl_series.Text = "Series"
        '
        'txt_series
        '
        Me.txt_series.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_series.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_series.Location = New System.Drawing.Point(521, 399)
        Me.txt_series.Name = "txt_series"
        Me.txt_series.Size = New System.Drawing.Size(163, 27)
        Me.txt_series.TabIndex = 57
        '
        'lbl_weight
        '
        Me.lbl_weight.AutoSize = True
        Me.lbl_weight.BackColor = System.Drawing.Color.Transparent
        Me.lbl_weight.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_weight.Location = New System.Drawing.Point(420, 433)
        Me.lbl_weight.Name = "lbl_weight"
        Me.lbl_weight.Size = New System.Drawing.Size(64, 20)
        Me.lbl_weight.TabIndex = 56
        Me.lbl_weight.Text = "Weight"
        '
        'txt_weight
        '
        Me.txt_weight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_weight.Location = New System.Drawing.Point(521, 430)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Size = New System.Drawing.Size(163, 27)
        Me.txt_weight.TabIndex = 55
        Me.txt_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(420, 370)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(58, 20)
        Me.lbl_brand.TabIndex = 53
        Me.lbl_brand.Text = "Brand"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(96, 433)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(82, 20)
        Me.lbl_price.TabIndex = 52
        Me.lbl_price.Text = "Price ($)"
        '
        'lbl_product_name
        '
        Me.lbl_product_name.AutoSize = True
        Me.lbl_product_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_product_name.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_name.Location = New System.Drawing.Point(96, 402)
        Me.lbl_product_name.Name = "lbl_product_name"
        Me.lbl_product_name.Size = New System.Drawing.Size(121, 20)
        Me.lbl_product_name.TabIndex = 51
        Me.lbl_product_name.Text = "Product Name"
        '
        'lbl_product_id
        '
        Me.lbl_product_id.AutoSize = True
        Me.lbl_product_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_product_id.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_id.Location = New System.Drawing.Point(96, 370)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(98, 20)
        Me.lbl_product_id.TabIndex = 50
        Me.lbl_product_id.Text = "Product ID"
        '
        'txt_brand
        '
        Me.txt_brand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(521, 367)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(163, 27)
        Me.txt_brand.TabIndex = 49
        Me.txt_brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_product.Location = New System.Drawing.Point(692, 148)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(203, 213)
        Me.pic_product.TabIndex = 48
        Me.pic_product.TabStop = False
        '
        'txt_price
        '
        Me.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(258, 430)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(156, 27)
        Me.txt_price.TabIndex = 47
        Me.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_product_name
        '
        Me.txt_product_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_product_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_name.Location = New System.Drawing.Point(258, 399)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.Size = New System.Drawing.Size(156, 27)
        Me.txt_product_name.TabIndex = 46
        '
        'txt_product_id
        '
        Me.txt_product_id.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_product_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_id.Location = New System.Drawing.Point(258, 367)
        Me.txt_product_id.Name = "txt_product_id"
        Me.txt_product_id.ReadOnly = True
        Me.txt_product_id.Size = New System.Drawing.Size(156, 27)
        Me.txt_product_id.TabIndex = 45
        Me.txt_product_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_category
        '
        Me.cmb_category.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_category.FormattingEnabled = True
        Me.cmb_category.Location = New System.Drawing.Point(100, 334)
        Me.cmb_category.Name = "cmb_category"
        Me.cmb_category.Size = New System.Drawing.Size(586, 28)
        Me.cmb_category.TabIndex = 44
        Me.cmb_category.Text = "Click here to choose the product category that you want to add"
        '
        'btn_add
        '
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(100, 464)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(795, 28)
        Me.btn_add.TabIndex = 59
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_photo
        '
        Me.btn_photo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_photo.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_photo.Location = New System.Drawing.Point(692, 398)
        Me.btn_photo.Name = "btn_photo"
        Me.btn_photo.Size = New System.Drawing.Size(203, 28)
        Me.btn_photo.TabIndex = 62
        Me.btn_photo.Text = "Select Photo"
        Me.btn_photo.UseVisualStyleBackColor = True
        '
        'txt_photo
        '
        Me.txt_photo.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_photo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_photo.Location = New System.Drawing.Point(692, 367)
        Me.txt_photo.Name = "txt_photo"
        Me.txt_photo.ReadOnly = True
        Me.txt_photo.Size = New System.Drawing.Size(203, 27)
        Me.txt_photo.TabIndex = 64
        '
        'lbl_photo
        '
        Me.lbl_photo.AutoSize = True
        Me.lbl_photo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_photo.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_photo.Location = New System.Drawing.Point(744, 120)
        Me.lbl_photo.Name = "lbl_photo"
        Me.lbl_photo.Size = New System.Drawing.Size(75, 25)
        Me.lbl_photo.TabIndex = 65
        Me.lbl_photo.Text = "Photo"
        '
        'btn_clearphoto
        '
        Me.btn_clearphoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clearphoto.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clearphoto.Location = New System.Drawing.Point(692, 429)
        Me.btn_clearphoto.Name = "btn_clearphoto"
        Me.btn_clearphoto.Size = New System.Drawing.Size(203, 28)
        Me.btn_clearphoto.TabIndex = 66
        Me.btn_clearphoto.Text = "Clear Photo"
        Me.btn_clearphoto.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'frm_insertproduct_a176607
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.btn_clearphoto)
        Me.Controls.Add(Me.lbl_photo)
        Me.Controls.Add(Me.txt_photo)
        Me.Controls.Add(Me.btn_photo)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.lbl_series)
        Me.Controls.Add(Me.txt_series)
        Me.Controls.Add(Me.lbl_weight)
        Me.Controls.Add(Me.txt_weight)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_product_name)
        Me.Controls.Add(Me.lbl_product_id)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_product_name)
        Me.Controls.Add(Me.txt_product_id)
        Me.Controls.Add(Me.cmb_category)
        Me.Controls.Add(Me.lbl_tagline)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.pic_back)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_insertproduct_a176607"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Product"
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents pic_back As PictureBox
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents lbl_tagline As Label
    Friend WithEvents lbl_series As Label
    Friend WithEvents txt_series As TextBox
    Friend WithEvents lbl_weight As Label
    Friend WithEvents txt_weight As TextBox
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_product_name As Label
    Friend WithEvents lbl_product_id As Label
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_product_name As TextBox
    Friend WithEvents txt_product_id As TextBox
    Friend WithEvents cmb_category As ComboBox
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_photo As Button
    Friend WithEvents txt_photo As TextBox
    Friend WithEvents lbl_photo As Label
    Friend WithEvents btn_clearphoto As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
