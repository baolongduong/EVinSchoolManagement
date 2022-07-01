
namespace GUI
{
    partial class ReportOfAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOfAttendance));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 139);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1204, 382);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.AllowAnimations = true;
            this.btnReport.AllowMouseEffects = true;
            this.btnReport.AllowToggling = false;
            this.btnReport.AnimationSpeed = 200;
            this.btnReport.AutoGenerateColors = false;
            this.btnReport.AutoRoundBorders = false;
            this.btnReport.AutoSizeLeftIcon = true;
            this.btnReport.AutoSizeRightIcon = true;
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.ButtonText = "Export";
            this.btnReport.ButtonTextMarginLeft = 0;
            this.btnReport.ColorContrastOnClick = 45;
            this.btnReport.ColorContrastOnHover = 45;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnReport.CustomizableEdges = borderEdges1;
            this.btnReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReport.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReport.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReport.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnReport.IconMarginLeft = 11;
            this.btnReport.IconPadding = 10;
            this.btnReport.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReport.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReport.IconSize = 25;
            this.btnReport.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.IdleBorderRadius = 1;
            this.btnReport.IdleBorderThickness = 1;
            this.btnReport.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.IdleIconLeftImage = null;
            this.btnReport.IdleIconRightImage = null;
            this.btnReport.IndicateFocus = false;
            this.btnReport.Location = new System.Drawing.Point(1116, 77);
            this.btnReport.Name = "btnReport";
            this.btnReport.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReport.OnDisabledState.BorderRadius = 1;
            this.btnReport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.OnDisabledState.BorderThickness = 1;
            this.btnReport.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReport.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReport.OnDisabledState.IconLeftImage = null;
            this.btnReport.OnDisabledState.IconRightImage = null;
            this.btnReport.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnReport.onHoverState.BorderRadius = 1;
            this.btnReport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.onHoverState.BorderThickness = 1;
            this.btnReport.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnReport.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReport.onHoverState.IconLeftImage = null;
            this.btnReport.onHoverState.IconRightImage = null;
            this.btnReport.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.OnIdleState.BorderRadius = 1;
            this.btnReport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.OnIdleState.BorderThickness = 1;
            this.btnReport.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReport.OnIdleState.IconLeftImage = null;
            this.btnReport.OnIdleState.IconRightImage = null;
            this.btnReport.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReport.OnPressedState.BorderRadius = 1;
            this.btnReport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.OnPressedState.BorderThickness = 1;
            this.btnReport.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReport.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReport.OnPressedState.IconLeftImage = null;
            this.btnReport.OnPressedState.IconRightImage = null;
            this.btnReport.Size = new System.Drawing.Size(94, 39);
            this.btnReport.TabIndex = 1;
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReport.TextMarginLeft = 0;
            this.btnReport.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReport.UseDefaultRadiusAndThickness = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuLabel1.Location = new System.Drawing.Point(557, 77);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(120, 30);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Attendance";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ReportOfAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 544);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.reportViewer1);
            this.HeaderBackColor = System.Drawing.Color.Navy;
            this.Name = "ReportOfAttendance";
            this.Text = "ReportOfAttendance";
            this.Load += new System.EventHandler(this.ReportOfAttendance_Load);
            this.Controls.SetChildIndex(this.reportViewer1, 0);
            this.Controls.SetChildIndex(this.btnReport, 0);
            this.Controls.SetChildIndex(this.bunifuLabel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReport;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}