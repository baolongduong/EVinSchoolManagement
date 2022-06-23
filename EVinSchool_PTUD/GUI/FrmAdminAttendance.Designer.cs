
namespace GUI
{
    partial class FrmAdminAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminAttendance));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.gv_AdminAttendance = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtp_Schedule = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.drp_Student = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btn_Save = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AdminAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_AdminAttendance
            // 
            this.gv_AdminAttendance.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gv_AdminAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_AdminAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_AdminAttendance.BackgroundColor = System.Drawing.Color.Lavender;
            this.gv_AdminAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_AdminAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_AdminAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_AdminAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_AdminAttendance.ColumnHeadersHeight = 40;
            this.gv_AdminAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gv_AdminAttendance.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gv_AdminAttendance.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gv_AdminAttendance.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_AdminAttendance.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gv_AdminAttendance.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gv_AdminAttendance.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gv_AdminAttendance.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gv_AdminAttendance.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gv_AdminAttendance.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gv_AdminAttendance.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gv_AdminAttendance.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gv_AdminAttendance.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gv_AdminAttendance.CurrentTheme.Name = null;
            this.gv_AdminAttendance.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_AdminAttendance.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gv_AdminAttendance.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_AdminAttendance.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gv_AdminAttendance.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_AdminAttendance.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_AdminAttendance.EnableHeadersVisualStyles = false;
            this.gv_AdminAttendance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gv_AdminAttendance.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gv_AdminAttendance.HeaderBgColor = System.Drawing.Color.Empty;
            this.gv_AdminAttendance.HeaderForeColor = System.Drawing.Color.White;
            this.gv_AdminAttendance.Location = new System.Drawing.Point(97, 207);
            this.gv_AdminAttendance.Name = "gv_AdminAttendance";
            this.gv_AdminAttendance.RowHeadersVisible = false;
            this.gv_AdminAttendance.RowHeadersWidth = 51;
            this.gv_AdminAttendance.RowTemplate.Height = 40;
            this.gv_AdminAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_AdminAttendance.Size = new System.Drawing.Size(858, 310);
            this.gv_AdminAttendance.TabIndex = 106;
            this.gv_AdminAttendance.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Column1
            // 
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(375, 104);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(340, 29);
            this.bunifuSeparator1.TabIndex = 108;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Garamond", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuLabel2.Location = new System.Drawing.Point(401, 68);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(290, 37);
            this.bunifuLabel2.TabIndex = 107;
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
            this.dtp_Schedule.Location = new System.Drawing.Point(434, 145);
            this.dtp_Schedule.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtp_Schedule.Name = "dtp_Schedule";
            this.dtp_Schedule.Size = new System.Drawing.Size(220, 32);
            this.dtp_Schedule.TabIndex = 110;
            this.dtp_Schedule.Value = new System.DateTime(2022, 6, 24, 0, 0, 0, 0);
            // 
            // drp_Student
            // 
            this.drp_Student.BackColor = System.Drawing.Color.Transparent;
            this.drp_Student.BackgroundColor = System.Drawing.Color.White;
            this.drp_Student.BorderColor = System.Drawing.Color.Silver;
            this.drp_Student.BorderRadius = 10;
            this.drp_Student.Color = System.Drawing.Color.Silver;
            this.drp_Student.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drp_Student.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drp_Student.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drp_Student.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drp_Student.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.drp_Student.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.drp_Student.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drp_Student.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.drp_Student.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drp_Student.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drp_Student.FillDropDown = true;
            this.drp_Student.FillIndicator = false;
            this.drp_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drp_Student.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.drp_Student.ForeColor = System.Drawing.Color.Black;
            this.drp_Student.FormattingEnabled = true;
            this.drp_Student.Icon = null;
            this.drp_Student.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drp_Student.IndicatorColor = System.Drawing.Color.Gray;
            this.drp_Student.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drp_Student.ItemBackColor = System.Drawing.Color.White;
            this.drp_Student.ItemBorderColor = System.Drawing.Color.White;
            this.drp_Student.ItemForeColor = System.Drawing.Color.Black;
            this.drp_Student.ItemHeight = 26;
            this.drp_Student.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.drp_Student.ItemHighLightForeColor = System.Drawing.Color.White;
            this.drp_Student.ItemTopMargin = 3;
            this.drp_Student.Location = new System.Drawing.Point(807, 145);
            this.drp_Student.Name = "drp_Student";
            this.drp_Student.Size = new System.Drawing.Size(109, 32);
            this.drp_Student.TabIndex = 109;
            this.drp_Student.Text = "Class";
            this.drp_Student.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drp_Student.TextLeftMargin = 5;
            this.drp_Student.DropDown += new System.EventHandler(this.drp_Student_DropDown);
            this.drp_Student.SelectedIndexChanged += new System.EventHandler(this.drp_Student_SelectedIndexChanged);
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
            this.btn_Save.BackColor1 = System.Drawing.Color.DarkRed;
            this.btn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Save.BackgroundImage")));
            this.btn_Save.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btn_Save.ButtonText = "Save";
            this.btn_Save.ButtonTextMarginLeft = 0;
            this.btn_Save.ColorContrastOnClick = 45;
            this.btn_Save.ColorContrastOnHover = 45;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Save.CustomizableEdges = borderEdges1;
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
            this.btn_Save.IdleFillColor = System.Drawing.Color.DarkRed;
            this.btn_Save.IdleIconLeftImage = null;
            this.btn_Save.IdleIconRightImage = null;
            this.btn_Save.IndicateFocus = false;
            this.btn_Save.Location = new System.Drawing.Point(830, 538);
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
            this.btn_Save.OnIdleState.FillColor = System.Drawing.Color.DarkRed;
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
            this.btn_Save.TabIndex = 111;
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Save.TextMarginLeft = 0;
            this.btn_Save.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Save.UseDefaultRadiusAndThickness = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
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
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 55;
            this.bunifuPictureBox1.Image = global::GUI.Properties.Resources.admin_config;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(0, 51);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(111, 111);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 112;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // FrmAdminAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 601);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dtp_Schedule);
            this.Controls.Add(this.drp_Student);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.gv_AdminAttendance);
            this.HeaderBackColor = System.Drawing.Color.DarkRed;
            this.Name = "FrmAdminAttendance";
            this.Text = "FrmAdminAttendance";
            this.Load += new System.EventHandler(this.FrmAdminAttendance_Load);
            this.Controls.SetChildIndex(this.gv_AdminAttendance, 0);
            this.Controls.SetChildIndex(this.bunifuLabel2, 0);
            this.Controls.SetChildIndex(this.bunifuSeparator1, 0);
            this.Controls.SetChildIndex(this.drp_Student, 0);
            this.Controls.SetChildIndex(this.dtp_Schedule, 0);
            this.Controls.SetChildIndex(this.btn_Save, 0);
            this.Controls.SetChildIndex(this.bunifuPictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gv_AdminAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDataGridView gv_AdminAttendance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker dtp_Schedule;
        private Bunifu.UI.WinForms.BunifuDropdown drp_Student;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Save;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}