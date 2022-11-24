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
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.editPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.editQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editYear = new System.Windows.Forms.TextBox();
            this.editPublishersId = new System.Windows.Forms.ComboBox();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.editSuppliersId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editAuthorId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editSectionsId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.издателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.button2.Location = new System.Drawing.Point(1015, 36);
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
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.editPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.editQuantity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.editYear);
            this.panel1.Controls.Add(this.editPublishersId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.editSuppliersId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.editAuthorId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.editSectionsId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.editTitle);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 450);
            this.panel1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Цена";
            // 
            // editPrice
            // 
            this.editPrice.Location = new System.Drawing.Point(12, 404);
            this.editPrice.Name = "editPrice";
            this.editPrice.Size = new System.Drawing.Size(231, 23);
            this.editPrice.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Кол-во";
            // 
            // editQuantity
            // 
            this.editQuantity.Location = new System.Drawing.Point(12, 350);
            this.editQuantity.Name = "editQuantity";
            this.editQuantity.Size = new System.Drawing.Size(231, 23);
            this.editQuantity.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Год";
            // 
            // editYear
            // 
            this.editYear.Location = new System.Drawing.Point(12, 297);
            this.editYear.Name = "editYear";
            this.editYear.Size = new System.Drawing.Size(231, 23);
            this.editYear.TabIndex = 11;
            // 
            // editPublishersId
            // 
            this.editPublishersId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.sectionsBindingSource, "idSections", true));
            this.editPublishersId.FormattingEnabled = true;
            this.editPublishersId.Location = new System.Drawing.Point(12, 244);
            this.editPublishersId.Name = "editPublishersId";
            this.editPublishersId.Size = new System.Drawing.Size(231, 23);
            this.editPublishersId.TabIndex = 10;
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataSource = typeof(Bookstore.DBC.Sections);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Издатель";
            // 
            // editSuppliersId
            // 
            this.editSuppliersId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.sectionsBindingSource, "idSections", true));
            this.editSuppliersId.FormattingEnabled = true;
            this.editSuppliersId.Location = new System.Drawing.Point(12, 191);
            this.editSuppliersId.Name = "editSuppliersId";
            this.editSuppliersId.Size = new System.Drawing.Size(231, 23);
            this.editSuppliersId.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Поставщик";
            // 
            // editAuthorId
            // 
            this.editAuthorId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.sectionsBindingSource, "idSections", true));
            this.editAuthorId.FormattingEnabled = true;
            this.editAuthorId.Location = new System.Drawing.Point(12, 136);
            this.editAuthorId.Name = "editAuthorId";
            this.editAuthorId.Size = new System.Drawing.Size(231, 23);
            this.editAuthorId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Автор";
            // 
            // editSectionsId
            // 
            this.editSectionsId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.sectionsBindingSource, "idSections", true));
            this.editSectionsId.FormattingEnabled = true;
            this.editSectionsId.Location = new System.Drawing.Point(12, 82);
            this.editSectionsId.Name = "editSectionsId";
            this.editSectionsId.Size = new System.Drawing.Size(231, 23);
            this.editSectionsId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Раздел";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // editTitle
            // 
            this.editTitle.Location = new System.Drawing.Point(12, 28);
            this.editTitle.Name = "editTitle";
            this.editTitle.Size = new System.Drawing.Size(231, 23);
            this.editTitle.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 36);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.открытьToolStripMenuItem,
            this.отчётыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip1.TabIndex = 11;
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
            this.заказыToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.открытьToolStripMenuItem.Text = "База данных";
            // 
            // издателиToolStripMenuItem
            // 
            this.издателиToolStripMenuItem.Name = "издателиToolStripMenuItem";
            this.издателиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.издателиToolStripMenuItem.Text = "Издатели";
            this.издателиToolStripMenuItem.Click += new System.EventHandler(this.издателиToolStripMenuItem_Click);
            // 
            // разделToolStripMenuItem
            // 
            this.разделToolStripMenuItem.Name = "разделToolStripMenuItem";
            this.разделToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.разделToolStripMenuItem.Text = "Раздел";
            this.разделToolStripMenuItem.Click += new System.EventHandler(this.разделToolStripMenuItem_Click);
            // 
            // авторыToolStripMenuItem
            // 
            this.авторыToolStripMenuItem.Name = "авторыToolStripMenuItem";
            this.авторыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.авторыToolStripMenuItem.Text = "Авторы";
            this.авторыToolStripMenuItem.Click += new System.EventHandler(this.авторыToolStripMenuItem_Click);
            // 
            // покупателиToolStripMenuItem
            // 
            this.покупателиToolStripMenuItem.Name = "покупателиToolStripMenuItem";
            this.покупателиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.покупателиToolStripMenuItem.Text = "Покупатели";
            this.покупателиToolStripMenuItem.Click += new System.EventHandler(this.покупателиToolStripMenuItem_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёт";
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 486);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "BooksForm";
            this.Text = "Книги";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private ComboBox editSectionsId;
        private BindingSource sectionsBindingSource;
        private Label label2;
        private ComboBox editAuthorId;
        private Label label3;
        private ComboBox editSuppliersId;
        private Label label4;
        private ComboBox editPublishersId;
        private Label label5;
        private Label label8;
        private TextBox editPrice;
        private Label label7;
        private TextBox editQuantity;
        private Label label6;
        private TextBox editYear;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem издателиToolStripMenuItem;
        private ToolStripMenuItem разделToolStripMenuItem;
        private ToolStripMenuItem авторыToolStripMenuItem;
        private ToolStripMenuItem покупателиToolStripMenuItem;
        private ToolStripMenuItem поставщикиToolStripMenuItem;
        private ToolStripMenuItem заказыToolStripMenuItem;
        private ToolStripMenuItem отчётыToolStripMenuItem;
    }
}