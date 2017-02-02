namespace Books
{
    partial class BooksForm
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
            this.OpenXML = new System.Windows.Forms.Button();
            this.SaveXML = new System.Windows.Forms.Button();
            this.ReportHTML = new System.Windows.Forms.Button();
            this.dtGr = new System.Windows.Forms.DataGridView();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGr)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenXML
            // 
            this.OpenXML.Location = new System.Drawing.Point(12, 29);
            this.OpenXML.Name = "OpenXML";
            this.OpenXML.Size = new System.Drawing.Size(92, 23);
            this.OpenXML.TabIndex = 0;
            this.OpenXML.Text = "Открыть XML";
            this.OpenXML.UseVisualStyleBackColor = true;
            this.OpenXML.Click += new System.EventHandler(this.OpenXML_Click);
            // 
            // SaveXML
            // 
            this.SaveXML.Location = new System.Drawing.Point(136, 29);
            this.SaveXML.Name = "SaveXML";
            this.SaveXML.Size = new System.Drawing.Size(96, 23);
            this.SaveXML.TabIndex = 1;
            this.SaveXML.Text = "Сохранить XML";
            this.SaveXML.UseVisualStyleBackColor = true;
            this.SaveXML.Click += new System.EventHandler(this.SaveXML_Click);
            // 
            // ReportHTML
            // 
            this.ReportHTML.Location = new System.Drawing.Point(358, 29);
            this.ReportHTML.Name = "ReportHTML";
            this.ReportHTML.Size = new System.Drawing.Size(117, 23);
            this.ReportHTML.TabIndex = 2;
            this.ReportHTML.Text = "Отчет в HTML";
            this.ReportHTML.UseVisualStyleBackColor = true;
            this.ReportHTML.Click += new System.EventHandler(this.ReportHTML_Click);
            // 
            // dtGr
            // 
            this.dtGr.AllowUserToAddRows = false;
            this.dtGr.AllowUserToDeleteRows = false;
            this.dtGr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGr.Location = new System.Drawing.Point(12, 58);
            this.dtGr.Name = "dtGr";
            this.dtGr.Size = new System.Drawing.Size(463, 150);
            this.dtGr.TabIndex = 3;
            this.dtGr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGr_CellContentClick);
            this.dtGr.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dtGr.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(136, 234);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "Удалить запись";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(271, 234);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 270);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.dtGr);
            this.Controls.Add(this.ReportHTML);
            this.Controls.Add(this.SaveXML);
            this.Controls.Add(this.OpenXML);
            this.Name = "BooksForm";
            this.Text = "Учет книг";
            ((System.ComponentModel.ISupportInitialize)(this.dtGr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenXML;
        private System.Windows.Forms.Button SaveXML;
        private System.Windows.Forms.Button ReportHTML;
        private System.Windows.Forms.DataGridView dtGr;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
    }
}

