namespace WinFormsApp4
{
    partial class Form2
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.tb_characteristics = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addItemCollection = new System.Windows.Forms.Button();
            this.btn_editItemCollection = new System.Windows.Forms.Button();
            this.btn_saveItemsCollection = new System.Windows.Forms.Button();
            this.btn_closeForm = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(400, 38);
            this.tb_name.Margin = new System.Windows.Forms.Padding(5);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(155, 33);
            this.tb_name.TabIndex = 1;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(400, 247);
            this.tb_price.Margin = new System.Windows.Forms.Padding(5);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(155, 33);
            this.tb_price.TabIndex = 2;
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(402, 179);
            this.tb_description.Margin = new System.Windows.Forms.Padding(5);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(153, 33);
            this.tb_description.TabIndex = 3;
            // 
            // tb_characteristics
            // 
            this.tb_characteristics.Location = new System.Drawing.Point(400, 106);
            this.tb_characteristics.Margin = new System.Windows.Forms.Padding(5);
            this.tb_characteristics.Name = "tb_characteristics";
            this.tb_characteristics.Size = new System.Drawing.Size(155, 33);
            this.tb_characteristics.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Характеристики";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена";
            // 
            // btn_addItemCollection
            // 
            this.btn_addItemCollection.Location = new System.Drawing.Point(400, 295);
            this.btn_addItemCollection.Name = "btn_addItemCollection";
            this.btn_addItemCollection.Size = new System.Drawing.Size(155, 32);
            this.btn_addItemCollection.TabIndex = 11;
            this.btn_addItemCollection.Text = "Добавить";
            this.btn_addItemCollection.UseVisualStyleBackColor = true;
            this.btn_addItemCollection.Click += new System.EventHandler(this.btn_addItemCollection_Click);
            // 
            // btn_editItemCollection
            // 
            this.btn_editItemCollection.Location = new System.Drawing.Point(400, 344);
            this.btn_editItemCollection.Name = "btn_editItemCollection";
            this.btn_editItemCollection.Size = new System.Drawing.Size(155, 32);
            this.btn_editItemCollection.TabIndex = 12;
            this.btn_editItemCollection.Text = "Редактировать";
            this.btn_editItemCollection.UseVisualStyleBackColor = true;
            this.btn_editItemCollection.Click += new System.EventHandler(this.btn_editItemCollection_Click);
            // 
            // btn_saveItemsCollection
            // 
            this.btn_saveItemsCollection.Location = new System.Drawing.Point(400, 394);
            this.btn_saveItemsCollection.Name = "btn_saveItemsCollection";
            this.btn_saveItemsCollection.Size = new System.Drawing.Size(155, 32);
            this.btn_saveItemsCollection.TabIndex = 13;
            this.btn_saveItemsCollection.Text = "Сохранить";
            this.btn_saveItemsCollection.UseVisualStyleBackColor = true;
            this.btn_saveItemsCollection.Click += new System.EventHandler(this.btn_saveItemsCollection_Click);
            // 
            // btn_closeForm
            // 
            this.btn_closeForm.Location = new System.Drawing.Point(402, 469);
            this.btn_closeForm.Name = "btn_closeForm";
            this.btn_closeForm.Size = new System.Drawing.Size(155, 32);
            this.btn_closeForm.TabIndex = 14;
            this.btn_closeForm.Text = "Закрыть";
            this.btn_closeForm.UseVisualStyleBackColor = true;
            this.btn_closeForm.Click += new System.EventHandler(this.btn_closeForm_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(359, 513);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 513);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_closeForm);
            this.Controls.Add(this.btn_saveItemsCollection);
            this.Controls.Add(this.btn_editItemCollection);
            this.Controls.Add(this.btn_addItemCollection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_characteristics);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_name);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Text = "Добавление и редактирование составляющих";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_name;
        private TextBox tb_price;
        private TextBox tb_description;
        private TextBox tb_characteristics;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_addItemCollection;
        private Button btn_editItemCollection;
        private Button btn_saveItemsCollection;
        private Button btn_closeForm;
        private ListBox listBox1;
    }
}