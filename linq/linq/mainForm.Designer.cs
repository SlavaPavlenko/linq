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
            this.createTable_btn = new System.Windows.Forms.Button();
            this.deleteTable_btn = new System.Windows.Forms.Button();
            this.editTable_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTable_btn
            // 
            this.createTable_btn.Location = new System.Drawing.Point(12, 12);
            this.createTable_btn.Name = "createTable_btn";
            this.createTable_btn.Size = new System.Drawing.Size(164, 23);
            this.createTable_btn.TabIndex = 0;
            this.createTable_btn.Text = "Создать таблицу";
            this.createTable_btn.UseVisualStyleBackColor = true;
            this.createTable_btn.Click += new System.EventHandler(this.createTable_btn_Click);
            // 
            // deleteTable_btn
            // 
            this.deleteTable_btn.Location = new System.Drawing.Point(12, 70);
            this.deleteTable_btn.Name = "deleteTable_btn";
            this.deleteTable_btn.Size = new System.Drawing.Size(164, 23);
            this.deleteTable_btn.TabIndex = 1;
            this.deleteTable_btn.Text = "Удалить таблицу";
            this.deleteTable_btn.UseVisualStyleBackColor = true;
            this.deleteTable_btn.Click += new System.EventHandler(this.deleteTable_btn_Click);
            // 
            // editTable_btn
            // 
            this.editTable_btn.Location = new System.Drawing.Point(12, 41);
            this.editTable_btn.Name = "editTable_btn";
            this.editTable_btn.Size = new System.Drawing.Size(164, 23);
            this.editTable_btn.TabIndex = 2;
            this.editTable_btn.Text = "Просмотреть таблицу";
            this.editTable_btn.UseVisualStyleBackColor = true;
            this.editTable_btn.Click += new System.EventHandler(this.editTable_btn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 110);
            this.Controls.Add(this.editTable_btn);
            this.Controls.Add(this.deleteTable_btn);
            this.Controls.Add(this.createTable_btn);
            this.Name = "mainForm";
            this.Text = "linq app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createTable_btn;
        private System.Windows.Forms.Button deleteTable_btn;
        private System.Windows.Forms.Button editTable_btn;
    }
}

