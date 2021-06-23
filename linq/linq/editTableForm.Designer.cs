namespace linq
{
    partial class editTableForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_comboBox = new System.Windows.Forms.ComboBox();
            this.table_dataGridView = new System.Windows.Forms.DataGridView();
            this.linq_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование таблицы";
            // 
            // name_comboBox
            // 
            this.name_comboBox.FormattingEnabled = true;
            this.name_comboBox.Location = new System.Drawing.Point(147, 6);
            this.name_comboBox.Name = "name_comboBox";
            this.name_comboBox.Size = new System.Drawing.Size(191, 21);
            this.name_comboBox.TabIndex = 1;
            this.name_comboBox.SelectedIndexChanged += new System.EventHandler(this.name_comboBox_SelectedIndexChanged);
            // 
            // table_dataGridView
            // 
            this.table_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_dataGridView.Location = new System.Drawing.Point(15, 33);
            this.table_dataGridView.Name = "table_dataGridView";
            this.table_dataGridView.Size = new System.Drawing.Size(468, 257);
            this.table_dataGridView.TabIndex = 2;
            // 
            // linq_btn
            // 
            this.linq_btn.Location = new System.Drawing.Point(489, 33);
            this.linq_btn.Name = "linq_btn";
            this.linq_btn.Size = new System.Drawing.Size(75, 23);
            this.linq_btn.TabIndex = 3;
            this.linq_btn.Text = "linq";
            this.linq_btn.UseVisualStyleBackColor = true;
            this.linq_btn.Click += new System.EventHandler(this.linq_btn_Click);
            // 
            // editTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 302);
            this.Controls.Add(this.linq_btn);
            this.Controls.Add(this.table_dataGridView);
            this.Controls.Add(this.name_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "editTableForm";
            this.Text = "editTableForm";
            this.Load += new System.EventHandler(this.editTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox name_comboBox;
        private System.Windows.Forms.DataGridView table_dataGridView;
        private System.Windows.Forms.Button linq_btn;
    }
}