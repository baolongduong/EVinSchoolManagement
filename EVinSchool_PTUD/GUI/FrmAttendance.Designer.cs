
namespace GUI
{
    partial class FrmAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAttendance));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.gv_Attendance = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtp_Schedule = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btn_Save = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.lbl_TeacherID = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_Class = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Attendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Attendance
            // 
            this.gv_Attendance.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.gv_Attendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gv_Attendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Attendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Attendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_Attendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Attendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gv_Attendance.ColumnHeadersHeight = 40;
            this.gv_Attendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gv_Attendance.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gv_Attendance.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gv_Attendance.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_Attendance.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gv_Attendance.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gv_Attendance.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gv_Attendance.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gv_Attendance.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gv_Attendance.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gv_Attendance.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gv_Attendance.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gv_Attendance.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gv_Attendance.CurrentTheme.Name = null;
            this.gv_Attendance.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_Attendance.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gv_Attendance.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_Attendance.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gv_Attendance.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Attendance.DefaultCellStyle = dataGridViewCellStyle9;
            this.gv_Attendance.EnableHeadersVisualStyles = false;
            this.gv_Attendance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gv_Attendance.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gv_Attendance.HeaderBgColor = System.Drawing.Color.Empty;
            this.gv_Attendance.HeaderForeColor = System.Drawing.Color.White;
            this.gv_Attendance.Location = new System.Drawing.Point(90, 216);
            this.gv_Attendance.Name = "gv_Attendance";
            this.gv_Attendance.RowHeadersVisible = false;
            this.gv_Attendance.RowHeadersWidth = 51;
            this.gv_Attendance.RowTemplate.Height = 40;
            this.gv_Attendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Attendance.Size = new System.Drawing.Size(916, 222);
            this.gv_Attendance.TabIndex = 0;
            this.gv_Attendance.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Column1
            // 
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column1.HeaderText = "Check";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(359, 114);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(340, 29);
            this.bunifuSeparator1.TabIndex = 110;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Garamond", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuLabel2.Location = new System.Drawing.Point(384, 75);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(290, 37);
            this.bunifuLabel2.TabIndex = 109;
            this.bunifuLabel2.Text = "Attendance Schedule";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtp_Schedule
            // 
            this.dtp_Schedule.BackColor = System.Drawing.Color.White;
            this.dtp_Schedule.BorderRadius = 1;
            this.dtp_Schedule.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtp_Schedule.Color = System.Drawing.Color.Silver;
            this.dtp_Schedule.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtp_Schedule.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtp_Schedule.DisabledColor = System.Drawing.Color.Gray;
            this.dtp_Schedule.DisplayWeekNumbers = false;
            this.dtp_Schedule.DPHeight = 0;
            this.dtp_Schedule.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_Schedule.FillDatePicker = false;
            this.dtp_Schedule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_Schedule.ForeColor = System.Drawing.Color.Black;
            this.dtp_Schedule.Icon = ((System.Drawing.Image)(resources.GetObject("dtp_Schedule.Icon")));
            this.dtp_Schedule.IconColor = System.Drawing.Color.Gray;
            this.dtp_Schedule.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtp_Schedule.LeftTextMargin = 5;
            this.dtp_Schedule.Location = new System.Drawing.Point(415, 155);
            this.dtp_Schedule.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtp_Schedule.Name = "dtp_Schedule";
            this.dtp_Schedule.Size = new System.Drawing.Size(220, 32);
            this.dtp_Schedule.TabIndex = 112;
            this.dtp_Schedule.Value = new System.DateTime(2022, 6, 24, 0, 0, 0, 0);
            // 
            // btn_Save
            // 
            this.btn_Save.AllowAnimations = true;
            this.btn_Save.AllowMouseEffects = true;
            this.btn_Save.AllowToggling = false;
            this.btn_Save.AnimationSpeed = 200;
            this.btn_Save.AutoGenerateColors = false;
            this.btn_Save.AutoRoundBorders = false;
            this.btn_Save.AutoSizeLeftIcon = true;
            this.btn_Save.AutoSizeRightIcon = true;
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.BackColor1 = System.Drawing.Color.Navy;
            this.btn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Save.BackgroundImage")));
            this.btn_Save.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btn_Save.ButtonText = "Save";
            this.btn_Save.ButtonTextMarginLeft = 0;
            this.btn_Save.ColorContrastOnClick = 45;
            this.btn_Save.ColorContrastOnHover = 45;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_Save.CustomizableEdges = borderEdges3;
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Save.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Save.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Save.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Save.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Save.Font = new System.Drawing.Font("Garamond", 12F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Save.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Save.IconMarginLeft = 11;
            this.btn_Save.IconPadding = 10;
            this.btn_Save.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Save.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Save.IconSize = 25;
            this.btn_Save.IdleBorderColor = System.Drawing.Color.FloralWhite;
            this.btn_Save.IdleBorderRadius = 20;
            this.btn_Save.IdleBorderThickness = 1;
            this.btn_Save.IdleFillColor = System.Drawing.Color.Navy;
            this.btn_Save.IdleIconLeftImage = null;
            this.btn_Save.IdleIconRightImage = null;
            this.btn_Save.IndicateFocus = false;
            this.btn_Save.Location = new System.Drawing.Point(833, 472);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Save.OnDisabledState.BorderRadius = 20;
            this.btn_Save.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Save.OnDisabledState.BorderThickness = 1;
            this.btn_Save.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Save.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Save.OnDisabledState.IconLeftImage = null;
            this.btn_Save.OnDisabledState.IconRightImage = null;
            this.btn_Save.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Save.onHoverState.BorderRadius = 20;
            this.btn_Save.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Save.onHoverState.BorderThickness = 1;
            this.btn_Save.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Save.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Save.onHoverState.IconLeftImage = null;
            this.btn_Save.onHoverState.IconRightImage = null;
            this.btn_Save.OnIdleState.BorderColor = System.Drawing.Color.FloralWhite;
            this.btn_Save.OnIdleState.BorderRadius = 20;
            this.btn_Save.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btn_Save.OnIdleState.BorderThickness = 1;
            this.btn_Save.OnIdleState.FillColor = System.Drawing.Color.Navy;
            this.btn_Save.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Save.OnIdleState.IconLeftImage = null;
            this.btn_Save.OnIdleState.IconRightImage = null;
            this.btn_Save.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Save.OnPressedState.BorderRadius = 20;
            this.btn_Save.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Save.OnPressedState.BorderThickness = 1;
            this.btn_Save.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Save.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Save.OnPressedState.IconLeftImage = null;
            this.btn_Save.OnPressedState.IconRightImage = null;
            this.btn_Save.Size = new System.Drawing.Size(145, 39);
            this.btn_Save.TabIndex = 113;
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Save.TextMarginLeft = 0;
            this.btn_Save.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Save.UseDefaultRadiusAndThickness = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 62;
            this.bunifuPictureBox1.Image = global::GUI.Properties.Resources.evs_logo;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(0, 51);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(125, 125);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 114;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // lbl_TeacherID
            // 
            this.lbl_TeacherID.AllowParentOverrides = false;
            this.lbl_TeacherID.AutoEllipsis = false;
            this.lbl_TeacherID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_TeacherID.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_TeacherID.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeacherID.ForeColor = System.Drawing.Color.Olive;
            this.lbl_TeacherID.Location = new System.Drawing.Point(241, 75);
            this.lbl_TeacherID.Name = "lbl_TeacherID";
            this.lbl_TeacherID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_TeacherID.Size = new System.Drawing.Size(26, 26);
            this.lbl_TeacherID.TabIndex = 115;
            this.lbl_TeacherID.Text = "ID";
            this.lbl_TeacherID.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_TeacherID.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_Class
            // 
            this.lbl_Class.AllowParentOverrides = false;
            this.lbl_Class.AutoEllipsis = false;
            this.lbl_Class.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Class.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_Class.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Class.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_Class.Location = new System.Drawing.Point(822, 160);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Class.Size = new System.Drawing.Size(99, 21);
            this.lbl_Class.TabIndex = 117;
            this.lbl_Class.Text = "Teacher Class";
            this.lbl_Class.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Class.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.ForeColor = System.Drawing.Color.Olive;
            this.bunifuLabel5.Location = new System.Drawing.Point(766, 155);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(50, 26);
            this.bunifuLabel5.TabIndex = 118;
            this.bunifuLabel5.Text = "Class:";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Olive;
            this.bunifuLabel1.Location = new System.Drawing.Point(131, 75);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(104, 26);
            this.bunifuLabel1.TabIndex = 119;
            this.bunifuLabel1.Text = "TeacherID:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // FrmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 532);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.lbl_Class);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.lbl_TeacherID);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dtp_Schedule);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.gv_Attendance);
            this.HeaderBackColor = System.Drawing.Color.Navy;
            this.Name = "FrmAttendance";
            this.Text = "FrmAttendance";
            this.Load += new System.EventHandler(this.FrmAttendance_Load);
            this.Controls.SetChildIndex(this.gv_Attendance, 0);
            this.Controls.SetChildIndex(this.bunifuLabel2, 0);
            this.Controls.SetChildIndex(this.bunifuSeparator1, 0);
            this.Controls.SetChildIndex(this.dtp_Schedule, 0);
            this.Controls.SetChildIndex(this.btn_Save, 0);
            this.Controls.SetChildIndex(this.bunifuPictureBox1, 0);
            this.Controls.SetChildIndex(this.lbl_TeacherID, 0);
            this.Controls.SetChildIndex(this.bunifuLabel5, 0);
            this.Controls.SetChildIndex(this.lbl_Class, 0);
            this.Controls.SetChildIndex(this.bunifuLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Attendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView gv_Attendance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker dtp_Schedule;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Save;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuLabel lbl_TeacherID;
        private Bunifu.UI.WinForms.BunifuLabel lbl_Class;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}