namespace Bookstore
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.editSum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.editQuantity = new System.Windows.Forms.TextBox();
            this.editBooksId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editCustomerId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.издателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrders,
            this.idCustomer,
            this.idBooks,
            this.quantity,
            this.sum});
            this.dataGridView1.Location = new System.Drawing.Point(269, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(849, 403);
            this.dataGridView1.TabIndex = 15;
            // 
            // idOrders
            // 
            this.idOrders.HeaderText = "id";
            this.idOrders.Name = "idOrders";
            this.idOrders.ReadOnly = true;
            this.idOrders.Visible = false;
            // 
            // idCustomer
            // 
            this.idCustomer.HeaderText = "Покупатель";
            this.idCustomer.Name = "idCustomer";
            // 
            // idBooks
            // 
            this.idBooks.HeaderText = "Книга";
            this.idBooks.Name = "idBooks";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Кол-во";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // sum
            // 
            this.sum.HeaderText = "Сумма";
            this.sum.Name = "sum";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 29);
            this.button3.TabIndex = 14;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1022, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.editSum);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.editQuantity);
            this.panel1.Controls.Add(this.editBooksId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.editCustomerId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(7, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 450);
            this.panel1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Сумма";
            // 
            // editSum
            // 
            this.editSum.Location = new System.Drawing.Point(12, 193);
            this.editSum.Name = "editSum";
            this.editSum.Size = new System.Drawing.Size(231, 23);
            this.editSum.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Кол-во";
            // 
            // editQuantity
            // 
            this.editQuantity.Location = new System.Drawing.Point(12, 139);
            this.editQuantity.Name = "editQuantity";
            this.editQuantity.Size = new System.Drawing.Size(231, 23);
            this.editQuantity.TabIndex = 13;
            // 
            // editBooksId
            // 
            this.editBooksId.FormattingEnabled = true;
            this.editBooksId.Location = new System.Drawing.Point(12, 86);
            this.editBooksId.Name = "editBooksId";
            this.editBooksId.Size = new System.Drawing.Size(231, 23);
            this.editBooksId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Книга";
            // 
            // editCustomerId
            // 
            this.editCustomerId.FormattingEnabled = true;
            this.editCustomerId.Location = new System.Drawing.Point(12, 32);
            this.editCustomerId.Name = "editCustomerId";
            this.editCustomerId.Size = new System.Drawing.Size(231, 23);
            this.editCustomerId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Покупатель";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(920, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.открытьToolStripMenuItem,
            this.отчётыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.toolStripMenuItem1.Text = "Вход";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.издателиToolStripMenuItem,
            this.разделToolStripMenuItem,
            this.авторыToolStripMenuItem,
            this.покупателиToolStripMenuItem,
            this.поставщикиToolStripMenuItem,
            this.книгиToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.открытьToolStripMenuItem.Text = "База данных";
            // 
            // издателиToolStripMenuItem
            // 
            this.издателиToolStripMenuItem.Name = "издателиToolStripMenuItem";
            this.издателиToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.издателиToolStripMenuItem.Text = "Издатели";
            this.издателиToolStripMenuItem.Click += new System.EventHandler(this.издателиToolStripMenuItem_Click);
            // 
            // разделToolStripMenuItem
            // 
            this.разделToolStripMenuItem.Name = "разделToolStripMenuItem";
            this.разделToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.разделToolStripMenuItem.Text = "Раздел";
            this.разделToolStripMenuItem.Click += new System.EventHandler(this.разделToolStripMenuItem_Click);
            // 
            // авторыToolStripMenuItem
            // 
            this.авторыToolStripMenuItem.Name = "авторыToolStripMenuItem";
            this.авторыToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.авторыToolStripMenuItem.Text = "Авторы";
            this.авторыToolStripMenuItem.Click += new System.EventHandler(this.авторыToolStripMenuItem_Click);
            // 
            // покупателиToolStripMenuItem
            // 
            this.покупателиToolStripMenuItem.Name = "покупателиToolStripMenuItem";
            this.покупателиToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.покупателиToolStripMenuItem.Text = "Покупатели";
            this.покупателиToolStripMenuItem.Click += new System.EventHandler(this.покупателиToolStripMenuItem_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.книгиToolStripMenuItem.Text = "Книги";
            this.книгиToolStripMenuItem.Click += new System.EventHandler(this.книгиToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёт";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 479);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "OrdersForm";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private Label label8;
        private TextBox editSum;
        private Label label7;
        private TextBox editQuantity;
        private ComboBox editBooksId;
        private Label label3;
        private ComboBox editCustomerId;
        private Label label2;
        private Button button1;
        private DataGridViewTextBoxColumn idOrders;
        private DataGridViewTextBoxColumn idCustomer;
        private DataGridViewTextBoxColumn idBooks;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn sum;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem издателиToolStripMenuItem;
        private ToolStripMenuItem разделToolStripMenuItem;
        private ToolStripMenuItem авторыToolStripMenuItem;
        private ToolStripMenuItem покупателиToolStripMenuItem;
        private ToolStripMenuItem поставщикиToolStripMenuItem;
        private ToolStripMenuItem книгиToolStripMenuItem;
        private ToolStripMenuItem отчётыToolStripMenuItem;
    }
}