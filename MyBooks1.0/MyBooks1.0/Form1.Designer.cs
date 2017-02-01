namespace MyBooks1._0
{
    partial class Form1
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
            this.dtGr = new System.Windows.Forms.DataGridView();
            this.OpenXML = new System.Windows.Forms.Button();
            this.SaveXML = new System.Windows.Forms.Button();
            this.ReportXML = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGr)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGr
            // 
            this.dtGr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGr.Location = new System.Drawing.Point(12, 48);
            this.dtGr.Name = "dtGr";
            this.dtGr.Size = new System.Drawing.Size(382, 150);
            this.dtGr.TabIndex = 0;
            // 
            // OpenXML
            // 
            this.OpenXML.Location = new System.Drawing.Point(13, 19);
            this.OpenXML.Name = "OpenXML";
            this.OpenXML.Size = new System.Drawing.Size(94, 23);
            this.OpenXML.TabIndex = 1;
            this.OpenXML.Text = "Открыть XML";
            this.OpenXML.UseVisualStyleBackColor = true;
            this.OpenXML.Click += new System.EventHandler(this.OpenXML_Click);
            // 
            // SaveXML
            // 
            this.SaveXML.Location = new System.Drawing.Point(138, 19);
            this.SaveXML.Name = "SaveXML";
            this.SaveXML.Size = new System.Drawing.Size(95, 23);
            this.SaveXML.TabIndex = 2;
            this.SaveXML.Text = "Сохранить XML";
            this.SaveXML.UseVisualStyleBackColor = true;
            this.SaveXML.Click += new System.EventHandler(this.SaveXML_Click);
            // 
            // ReportXML
            // 
            this.ReportXML.Location = new System.Drawing.Point(352, 19);
            this.ReportXML.Name = "ReportXML";
            this.ReportXML.Size = new System.Drawing.Size(75, 23);
            this.ReportXML.TabIndex = 3;
            this.ReportXML.Text = "Отчет XML";
            this.ReportXML.UseVisualStyleBackColor = true;
            this.ReportXML.Click += new System.EventHandler(this.ReportXML_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(86, 204);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(320, 205);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 241);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ReportXML);
            this.Controls.Add(this.SaveXML);
            this.Controls.Add(this.OpenXML);
            this.Controls.Add(this.dtGr);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGr;
        private System.Windows.Forms.Button OpenXML;
        private System.Windows.Forms.Button SaveXML;
        private System.Windows.Forms.Button ReportXML;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
    }
}

