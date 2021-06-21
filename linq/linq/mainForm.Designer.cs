namespace linq
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createTable_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createTable_btn
            // 
            this.createTable_btn.Location = new System.Drawing.Point(12, 12);
            this.createTable_btn.Name = "createTable_btn";
            this.createTable_btn.Size = new System.Drawing.Size(119, 23);
            this.createTable_btn.TabIndex = 0;
            this.createTable_btn.Text = "Создать таблицу";
            this.createTable_btn.UseVisualStyleBackColor = true;
            this.createTable_btn.Click += new System.EventHandler(this.createTable_btn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createTable_btn);
            this.Name = "mainForm";
            this.Text = "linq app";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dBDataSetBindingSource;
        private System.Windows.Forms.Button createTable_btn;
    }
}

