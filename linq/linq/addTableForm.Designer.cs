namespace linq
{
    partial class addTableForm
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
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columns_groupBox = new System.Windows.Forms.GroupBox();
            this.columns_listBox = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.columns_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(116, 241);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "Ок";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(197, 241);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(101, 6);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(171, 20);
            this.name_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование";
            // 
            // columns_groupBox
            // 
            this.columns_groupBox.Controls.Add(this.delete_btn);
            this.columns_groupBox.Controls.Add(this.add_btn);
            this.columns_groupBox.Controls.Add(this.columns_listBox);
            this.columns_groupBox.Location = new System.Drawing.Point(15, 42);
            this.columns_groupBox.Name = "columns_groupBox";
            this.columns_groupBox.Size = new System.Drawing.Size(257, 193);
            this.columns_groupBox.TabIndex = 4;
            this.columns_groupBox.TabStop = false;
            this.columns_groupBox.Text = "Столбцы";
            // 
            // columns_listBox
            // 
            this.columns_listBox.FormattingEnabled = true;
            this.columns_listBox.Location = new System.Drawing.Point(6, 19);
            this.columns_listBox.Name = "columns_listBox";
            this.columns_listBox.Size = new System.Drawing.Size(245, 134);
            this.columns_listBox.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(6, 159);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(176, 159);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // addTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 272);
            this.Controls.Add(this.columns_groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Name = "addTableForm";
            this.Text = "addTable";
            this.columns_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox columns_groupBox;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ListBox columns_listBox;
    }
}