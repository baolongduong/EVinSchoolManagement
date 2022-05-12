
namespace GUI
{
    partial class FrmSchool
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
            this.gvTeacher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // gvTeacher
            // 
            this.gvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTeacher.Location = new System.Drawing.Point(38, 43);
            this.gvTeacher.Name = "gvTeacher";
            this.gvTeacher.RowHeadersWidth = 51;
            this.gvTeacher.RowTemplate.Height = 24;
            this.gvTeacher.Size = new System.Drawing.Size(708, 336);
            this.gvTeacher.TabIndex = 0;
            // 
            // FrmSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvTeacher);
            this.Name = "FrmSchool";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSchool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTeacher;
    }
}

