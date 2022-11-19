namespace Bookstore
{
    partial class BooksForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.издателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.editTitle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSections = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSuppliers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPublishers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.открытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1139, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.поставщикиToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // издателиToolStripMenuItem
            // 
            this.издателиToolStripMenuItem.Name = "издателиToolStripMenuItem";
            this.издателиToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.издателиToolStripMenuItem.Text = "Издатели";
            // 
            // разделToolStripMenuItem
            // 
            this.разделToolStripMenuItem.Name = "разделToolStripMenuItem";
            this.разделToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.разделToolStripMenuItem.Text = "Раздел";
            // 
            // авторыToolStripMenuItem
            // 
            this.авторыToolStripMenuItem.Name = "авторыToolStripMenuItem";
            this.авторыToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.авторыToolStripMenuItem.Text = "Авторы";
            // 
            // покупателиToolStripMenuItem
            // 
            this.покупателиToolStripMenuItem.Name = "покупателиToolStripMenuItem";
            this.покупателиToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.покупателиToolStripMenuItem.Text = "Покупатели";
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(692, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.editTitle);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 197);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // editTitle
            // 
            this.editTitle.Location = new System.Drawing.Point(12, 47);
            this.editTitle.Name = "editTitle";
            this.editTitle.Size = new System.Drawing.Size(231, 23);
            this.editTitle.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBooks,
            this.title,
            this.idSections,
            this.idAuthor,
            this.idSuppliers,
            this.idPublishers,
            this.year,
            this.quantity,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(262, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(849, 403);
            this.dataGridView1.TabIndex = 10;
            // 
            // idBooks
            // 
            this.idBooks.HeaderText = "id";
            this.idBooks.Name = "idBooks";
            this.idBooks.ReadOnly = true;
            this.idBooks.Visible = false;
            // 
            // title
            // 
            this.title.HeaderText = "Название";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // idSections
            // 
            this.idSections.HeaderText = "Раздел";
            this.idSections.Name = "idSections";
            this.idSections.ReadOnly = true;
            // 
            // idAuthor
            // 
            this.idAuthor.HeaderText = "Автор";
            this.idAuthor.Name = "idAuthor";
            // 
            // idSuppliers
            // 
            this.idSuppliers.HeaderText = "Поставщик";
            this.idSuppliers.Name = "idSuppliers";
            // 
            // idPublishers
            // 
            this.idPublishers.HeaderText = "Издатель";
            this.idPublishers.Name = "idPublishers";
            // 
            // year
            // 
            this.year.HeaderText = "Год";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Кол-во";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem издателиToolStripMenuItem;
        private ToolStripMenuItem разделToolStripMenuItem;
        private ToolStripMenuItem авторыToolStripMenuItem;
        private ToolStripMenuItem покупателиToolStripMenuItem;
        private ToolStripMenuItem поставщикиToolStripMenuItem;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private Label label1;
        private TextBox editTitle;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idBooks;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn idSections;
        private DataGridViewTextBoxColumn idAuthor;
        private DataGridViewTextBoxColumn idSuppliers;
        private DataGridViewTextBoxColumn idPublishers;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
    }
}