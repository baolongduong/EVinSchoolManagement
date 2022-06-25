
namespace GUI
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.ClassificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentManagementDBDataSet = new GUI.StudentManagementDBDataSet();
            this.rp_Classification = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ClassificationTableAdapter = new GUI.StudentManagementDBDataSetTableAdapters.ClassificationTableAdapter();
            this.btnLoad = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.StudentManagementDBDataSetNew = new GUI.StudentManagementDBDataSetNew();
            this.studentManagementDBDataSetNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentManagementDBDataSetNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDBDataSetNewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassificationBindingSource
            // 
            this.ClassificationBindingSource.DataMember = "Classification";
            this.ClassificationBindingSource.DataSource = this.StudentManagementDBDataSet;
            // 
            // StudentManagementDBDataSet
            // 
            this.StudentManagementDBDataSet.DataSetName = "StudentManagementDBDataSet";
            this.StudentManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rp_Classification
            // 
            reportDataSource1.Name = "CDS";
            reportDataSource1.Value = this.studentManagementDBDataSetNewBindingSource;
            this.rp_Classification.LocalReport.DataSources.Add(reportDataSource1);
            this.rp_Classification.LocalReport.ReportEmbeddedResource = "GUI.test.rdlc";
            this.rp_Classification.Location = new System.Drawing.Point(34, 133);
            this.rp_Classification.Name = "rp_Classification";
            this.rp_Classification.ServerReport.BearerToken = null;
            this.rp_Classification.Size = new System.Drawing.Size(1277, 393);
            this.rp_Classification.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ClassificationTableAdapter
            // 
            this.ClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // btnLoad
            // 
            this.btnLoad.AllowAnimations = true;
            this.btnLoad.AllowMouseEffects = true;
            this.btnLoad.AllowToggling = false;
            this.btnLoad.AnimationSpeed = 200;
            this.btnLoad.AutoGenerateColors = false;
            this.btnLoad.AutoRoundBorders = false;
            this.btnLoad.AutoSizeLeftIcon = true;
            this.btnLoad.AutoSizeRightIcon = true;
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.BackgroundImage")));
            this.btnLoad.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoad.ButtonText = "↻";
            this.btnLoad.ButtonTextMarginLeft = 0;
            this.btnLoad.ColorContrastOnClick = 45;
            this.btnLoad.ColorContrastOnHover = 45;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLoad.CustomizableEdges = borderEdges1;
            this.btnLoad.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoad.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLoad.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLoad.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLoad.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLoad.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLoad.IconMarginLeft = 11;
            this.btnLoad.IconPadding = 10;
            this.btnLoad.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLoad.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLoad.IconSize = 25;
            this.btnLoad.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLoad.IdleBorderRadius = 30;
            this.btnLoad.IdleBorderThickness = 1;
            this.btnLoad.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnLoad.IdleIconLeftImage = null;
            this.btnLoad.IdleIconRightImage = null;
            this.btnLoad.IndicateFocus = false;
            this.btnLoad.Location = new System.Drawing.Point(1264, 74);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLoad.OnDisabledState.BorderRadius = 30;
            this.btnLoad.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoad.OnDisabledState.BorderThickness = 1;
            this.btnLoad.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLoad.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLoad.OnDisabledState.IconLeftImage = null;
            this.btnLoad.OnDisabledState.IconRightImage = null;
            this.btnLoad.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLoad.onHoverState.BorderRadius = 30;
            this.btnLoad.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoad.onHoverState.BorderThickness = 1;
            this.btnLoad.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLoad.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLoad.onHoverState.IconLeftImage = null;
            this.btnLoad.onHoverState.IconRightImage = null;
            this.btnLoad.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLoad.OnIdleState.BorderRadius = 30;
            this.btnLoad.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoad.OnIdleState.BorderThickness = 1;
            this.btnLoad.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLoad.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLoad.OnIdleState.IconLeftImage = null;
            this.btnLoad.OnIdleState.IconRightImage = null;
            this.btnLoad.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLoad.OnPressedState.BorderRadius = 30;
            this.btnLoad.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoad.OnPressedState.BorderThickness = 1;
            this.btnLoad.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLoad.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLoad.OnPressedState.IconLeftImage = null;
            this.btnLoad.OnPressedState.IconRightImage = null;
            this.btnLoad.Size = new System.Drawing.Size(47, 39);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoad.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLoad.TextMarginLeft = 0;
            this.btnLoad.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLoad.UseDefaultRadiusAndThickness = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuLabel1.Location = new System.Drawing.Point(621, 74);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(87, 34);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Report";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // StudentManagementDBDataSetNew
            // 
            this.StudentManagementDBDataSetNew.DataSetName = "StudentManagementDBDataSetNew";
            this.StudentManagementDBDataSetNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentManagementDBDataSetNewBindingSource
            // 
            this.studentManagementDBDataSetNewBindingSource.DataSource = this.StudentManagementDBDataSetNew;
            this.studentManagementDBDataSetNewBindingSource.Position = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 555);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.rp_Classification);
            this.HeaderBackColor = System.Drawing.Color.Navy;
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.Controls.SetChildIndex(this.rp_Classification, 0);
            this.Controls.SetChildIndex(this.btnLoad, 0);
            this.Controls.SetChildIndex(this.bunifuLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentManagementDBDataSetNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDBDataSetNewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_Classification;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.BindingSource ClassificationBindingSource;
        private StudentManagementDBDataSet StudentManagementDBDataSet;
        private StudentManagementDBDataSetTableAdapters.ClassificationTableAdapter ClassificationTableAdapter;
        private StudentManagementDBDataSetNewTableAdapters.ClassificationTableAdapter ClassificationTableAdapter1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLoad;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private StudentManagementDBDataSetNew StudentManagementDBDataSetNew;
        private System.Windows.Forms.BindingSource studentManagementDBDataSetNewBindingSource;
    }
}