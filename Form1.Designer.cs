
namespace LabParserSet_k
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_showItems = new System.Windows.Forms.Button();
            this.cbox_podcategory = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_console = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox_category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbox_catalog = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_itemsTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_manufacturer = new System.Windows.Forms.Label();
            this.txt_baseUnit = new System.Windows.Forms.Label();
            this.txt_weight = new System.Windows.Forms.Label();
            this.txt_volume = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_CostItem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_ItemInfo = new System.Windows.Forms.RichTextBox();
            this.itemImage = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemsTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.62838F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.37162F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.92904F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.07096F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 761);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(706, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(478, 105);
            this.panel5.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgv_itemsTable, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 105);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.67183F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.32817F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(706, 656);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_showItems);
            this.panel1.Controls.Add(this.cbox_podcategory);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbox_category);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbox_catalog);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 180);
            this.panel1.TabIndex = 1;
            // 
            // btn_showItems
            // 
            this.btn_showItems.Enabled = false;
            this.btn_showItems.Location = new System.Drawing.Point(553, 99);
            this.btn_showItems.Name = "btn_showItems";
            this.btn_showItems.Size = new System.Drawing.Size(142, 34);
            this.btn_showItems.TabIndex = 4;
            this.btn_showItems.Text = "Показать";
            this.btn_showItems.UseVisualStyleBackColor = true;
            this.btn_showItems.Click += new System.EventHandler(this.btn_showItems_Click);
            // 
            // cbox_podcategory
            // 
            this.cbox_podcategory.Enabled = false;
            this.cbox_podcategory.FormattingEnabled = true;
            this.cbox_podcategory.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbox_podcategory.Location = new System.Drawing.Point(469, 58);
            this.cbox_podcategory.MaxDropDownItems = 20;
            this.cbox_podcategory.Name = "cbox_podcategory";
            this.cbox_podcategory.Size = new System.Drawing.Size(226, 23);
            this.cbox_podcategory.TabIndex = 0;
            this.cbox_podcategory.SelectedIndexChanged += new System.EventHandler(this.cbox_podcategory_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_console);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 36);
            this.panel3.TabIndex = 1;
            // 
            // txt_console
            // 
            this.txt_console.AutoSize = true;
            this.txt_console.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_console.Location = new System.Drawing.Point(8, 10);
            this.txt_console.Name = "txt_console";
            this.txt_console.Size = new System.Drawing.Size(45, 15);
            this.txt_console.TabIndex = 1;
            this.txt_console.Text = "МЕНЮ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Подкатегория";
            // 
            // cbox_category
            // 
            this.cbox_category.Enabled = false;
            this.cbox_category.FormattingEnabled = true;
            this.cbox_category.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbox_category.Location = new System.Drawing.Point(237, 58);
            this.cbox_category.MaxDropDownItems = 20;
            this.cbox_category.Name = "cbox_category";
            this.cbox_category.Size = new System.Drawing.Size(226, 23);
            this.cbox_category.TabIndex = 0;
            this.cbox_category.SelectedIndexChanged += new System.EventHandler(this.cbox_category_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Категория";
            // 
            // cbox_catalog
            // 
            this.cbox_catalog.FormattingEnabled = true;
            this.cbox_catalog.Location = new System.Drawing.Point(5, 58);
            this.cbox_catalog.MaxDropDownItems = 20;
            this.cbox_catalog.Name = "cbox_catalog";
            this.cbox_catalog.Size = new System.Drawing.Size(226, 23);
            this.cbox_catalog.TabIndex = 1;
            this.cbox_catalog.SelectedIndexChanged += new System.EventHandler(this.cbox_catalog_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Каталог";
            // 
            // dgv_itemsTable
            // 
            this.dgv_itemsTable.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgv_itemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itemsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.cost});
            this.dgv_itemsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_itemsTable.Location = new System.Drawing.Point(3, 3);
            this.dgv_itemsTable.MultiSelect = false;
            this.dgv_itemsTable.Name = "dgv_itemsTable";
            this.dgv_itemsTable.RowHeadersWidth = 4;
            this.dgv_itemsTable.RowTemplate.Height = 25;
            this.dgv_itemsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_itemsTable.Size = new System.Drawing.Size(700, 464);
            this.dgv_itemsTable.TabIndex = 0;
            this.dgv_itemsTable.SelectionChanged += new System.EventHandler(this.dgv_itemsTable_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "№";
            this.id.Name = "id";
            this.id.Width = 46;
            // 
            // name
            // 
            this.name.HeaderText = "Название товара";
            this.name.Name = "name";
            this.name.Width = 500;
            // 
            // cost
            // 
            this.cost.HeaderText = "Стоимость";
            this.cost.Name = "cost";
            this.cost.Width = 150;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtb_ItemInfo);
            this.panel2.Controls.Add(this.itemImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(709, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 650);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txt_manufacturer, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_baseUnit, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_weight, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txt_volume, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label11, 1, 4);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 250);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(464, 125);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(4, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Производитель:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(4, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Базовая единица:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(4, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Вес:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(4, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Объем:";
            // 
            // txt_manufacturer
            // 
            this.txt_manufacturer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_manufacturer.AutoSize = true;
            this.txt_manufacturer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_manufacturer.Location = new System.Drawing.Point(166, 2);
            this.txt_manufacturer.Name = "txt_manufacturer";
            this.txt_manufacturer.Size = new System.Drawing.Size(17, 20);
            this.txt_manufacturer.TabIndex = 4;
            this.txt_manufacturer.Text = "–";
            // 
            // txt_baseUnit
            // 
            this.txt_baseUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_baseUnit.AutoSize = true;
            this.txt_baseUnit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_baseUnit.Location = new System.Drawing.Point(166, 26);
            this.txt_baseUnit.Name = "txt_baseUnit";
            this.txt_baseUnit.Size = new System.Drawing.Size(30, 20);
            this.txt_baseUnit.TabIndex = 5;
            this.txt_baseUnit.Text = "шт.";
            // 
            // txt_weight
            // 
            this.txt_weight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_weight.AutoSize = true;
            this.txt_weight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_weight.Location = new System.Drawing.Point(166, 50);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(37, 20);
            this.txt_weight.TabIndex = 6;
            this.txt_weight.Text = "0 кг.";
            // 
            // txt_volume
            // 
            this.txt_volume.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_volume.AutoSize = true;
            this.txt_volume.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_volume.Location = new System.Drawing.Point(166, 74);
            this.txt_volume.Name = "txt_volume";
            this.txt_volume.Size = new System.Drawing.Size(65, 20);
            this.txt_volume.TabIndex = 7;
            this.txt_volume.Text = "0 куб. м.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Наличие:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(166, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "0 шт на складе";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txt_CostItem, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(290, 162);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.625F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.375F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(178, 82);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // txt_CostItem
            // 
            this.txt_CostItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_CostItem.AutoSize = true;
            this.txt_CostItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_CostItem.Location = new System.Drawing.Point(4, 39);
            this.txt_CostItem.Name = "txt_CostItem";
            this.txt_CostItem.Size = new System.Drawing.Size(68, 37);
            this.txt_CostItem.TabIndex = 4;
            this.txt_CostItem.Text = "0.00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ЦЕНА (руб):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Подробное описание";
            // 
            // txtb_ItemInfo
            // 
            this.txtb_ItemInfo.BackColor = System.Drawing.Color.White;
            this.txtb_ItemInfo.Location = new System.Drawing.Point(8, 407);
            this.txtb_ItemInfo.Name = "txtb_ItemInfo";
            this.txtb_ItemInfo.ReadOnly = true;
            this.txtb_ItemInfo.Size = new System.Drawing.Size(443, 233);
            this.txtb_ItemInfo.TabIndex = 1;
            this.txtb_ItemInfo.Text = "";
            // 
            // itemImage
            // 
            this.itemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemImage.Image = ((System.Drawing.Image)(resources.GetObject("itemImage.Image")));
            this.itemImage.Location = new System.Drawing.Point(4, 4);
            this.itemImage.Name = "itemImage";
            this.itemImage.Size = new System.Drawing.Size(280, 240);
            this.itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemImage.TabIndex = 0;
            this.itemImage.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(706, 105);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set-k Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemsTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_itemsTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_console;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_showItems;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbox_podcategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbox_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbox_catalog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox itemImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label txt_CostItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtb_ItemInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txt_;
        private System.Windows.Forms.Label txt_baseUnit;
        private System.Windows.Forms.Label txt_weight;
        private System.Windows.Forms.Label txt_volume;
        private System.Windows.Forms.Label txt_manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
    }
}

