
namespace GUI
{
    partial class FrmEditAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditAttendance));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.gv_EditAttendance = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtp_Schedule = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.drp_Student = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btn_Edit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_EditAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BackColor = System.Drawing.Color.White;
            this.bunifuPictureBox1.BorderRadius = 53;
            this.bunifuPictureBox1.Image = global::GUI.Properties.Resources.evs_logo;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(4, 59);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(106, 106);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 105;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // gv_EditAttendance
            // 
            this.gv_EditAttendance.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.gv_EditAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_EditAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_EditAttendance.BackgroundColor = System.Drawing.Color.Lavender;
            this.gv_EditAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_EditAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_EditAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_EditAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gv_EditAttendance.ColumnHeadersHeight = 40;
            this.gv_EditAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gv_EditAttendance.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gv_EditAttendance.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gv_EditAttendance.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_EditAttendance.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gv_EditAttendance.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gv_EditAttendance.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gv_EditAttendance.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gv_EditAttendance.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gv_EditAttendance.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gv_EditAttendance.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gv_EditAttendance.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gv_EditAttendance.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gv_EditAttendance.CurrentTheme.Name = null;
            this.gv_EditAttendance.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_EditAttendance.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gv_EditAttendance.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_EditAttendance.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gv_EditAttendance.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_EditAttendance.DefaultCellStyle = dataGridViewCellStyle6;
            this.gv_EditAttendance.EnableHeadersVisualStyles = false;
            this.gv_EditAttendance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gv_EditAttendance.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gv_EditAttendance.HeaderBgColor = System.Drawing.Color.Empty;
            this.gv_EditAttendance.HeaderForeColor = System.Drawing.Color.White;
            this.gv_EditAttendance.Location = new System.Drawing.Point(97, 207);
            this.gv_EditAttendance.Name = "gv_EditAttendance";
            this.gv_EditAttendance.RowHeadersVisible = false;
            this.gv_EditAttendance.RowHeadersWidth = 51;
            this.gv_EditAttendance.RowTemplate.Height = 40;
            this.gv_EditAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_EditAttendance.Size = new System.Drawing.Size(858, 310);
            this.gv_EditAttendance.TabIndex = 106;
            this.gv_EditAttendance.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(401, 104);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(279, 29);
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
            this.drp_Student.Location = new System.Drawing.Point(809, 145);
            this.drp_Student.Name = "drp_Student";
            this.drp_Student.Size = new System.Drawing.Size(109, 32);
            this.drp_Student.TabIndex = 109;
            this.drp_Student.Text = "Class";
            this.drp_Student.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drp_Student.TextLeftMargin = 5;
            this.drp_Student.DropDown += new System.EventHandler(this.drp_Student_DropDown);
            this.drp_Student.SelectedIndexChanged += new System.EventHandler(this.drp_Student_SelectedIndexChanged);
            // 
            // btn_Edit
            // 
            this.btn_Edit.AllowAnimations = true;
            this.btn_Edit.AllowMouseEffects = true;
            this.btn_Edit.AllowToggling = false;
            this.btn_Edit.AnimationSpeed = 200;
            this.btn_Edit.AutoGenerateColors = false;
            this.btn_Edit.AutoRoundBorders = false;
            this.btn_Edit.AutoSizeLeftIcon = true;
            this.btn_Edit.AutoSizeRightIcon = true;
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.BackColor1 = System.Drawing.Color.Navy;
            this.btn_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.BackgroundImage")));
            this.btn_Edit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btn_Edit.ButtonText = "Edit";
            this.btn_Edit.ButtonTextMarginLeft = 0;
            this.btn_Edit.ColorContrastOnClick = 45;
            this.btn_Edit.ColorContrastOnHover = 45;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_Edit.CustomizableEdges = borderEdges2;
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Edit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Edit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Edit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Edit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Edit.Font = new System.Drawing.Font("Garamond", 12F);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Edit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Edit.IconMarginLeft = 11;
            this.btn_Edit.IconPadding = 10;
            this.btn_Edit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Edit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Edit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Edit.IconSize = 25;
            this.btn_Edit.IdleBorderColor = System.Drawing.Color.FloralWhite;
            this.btn_Edit.IdleBorderRadius = 20;
            this.btn_Edit.IdleBorderThickness = 1;
            this.btn_Edit.IdleFillColor = System.Drawing.Color.Navy;
            this.btn_Edit.IdleIconLeftImage = null;
            this.btn_Edit.IdleIconRightImage = null;
            this.btn_Edit.IndicateFocus = false;
            this.btn_Edit.Location = new System.Drawing.Point(830, 538);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Edit.OnDisabledState.BorderRadius = 20;
            this.btn_Edit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Edit.OnDisabledState.BorderThickness = 1;
            this.btn_Edit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Edit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Edit.OnDisabledState.IconLeftImage = null;
            this.btn_Edit.OnDisabledState.IconRightImage = null;
            this.btn_Edit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Edit.onHoverState.BorderRadius = 20;
            this.btn_Edit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Edit.onHoverState.BorderThickness = 1;
            this.btn_Edit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Edit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.onHoverState.IconLeftImage = null;
            this.btn_Edit.onHoverState.IconRightImage = null;
            this.btn_Edit.OnIdleState.BorderColor = System.Drawing.Color.FloralWhite;
            this.btn_Edit.OnIdleState.BorderRadius = 20;
            this.btn_Edit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btn_Edit.OnIdleState.BorderThickness = 1;
            this.btn_Edit.OnIdleState.FillColor = System.Drawing.Color.Navy;
            this.btn_Edit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.OnIdleState.IconLeftImage = null;
            this.btn_Edit.OnIdleState.IconRightImage = null;
            this.btn_Edit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Edit.OnPressedState.BorderRadius = 20;
            this.btn_Edit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Edit.OnPressedState.BorderThickness = 1;
            this.btn_Edit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Edit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.OnPressedState.IconLeftImage = null;
            this.btn_Edit.OnPressedState.IconRightImage = null;
            this.btn_Edit.Size = new System.Drawing.Size(145, 39);
            this.btn_Edit.TabIndex = 111;
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Edit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Edit.TextMarginLeft = 0;
            this.btn_Edit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Edit.UseDefaultRadiusAndThickness = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
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
            // FrmEditAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 601);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.dtp_Schedule);
            this.Controls.Add(this.drp_Student);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.gv_EditAttendance);
            this.Controls.Add(this.bunifuPictureBox1);
            this.HeaderBackColor = System.Drawing.Color.Navy;
            this.Name = "FrmEditAttendance";
            this.Text = "FrmEditAttendance";
            this.Load += new System.EventHandler(this.FrmEditAttendance_Load);
            this.Controls.SetChildIndex(this.bunifuPictureBox1, 0);
            this.Controls.SetChildIndex(this.gv_EditAttendance, 0);
            this.Controls.SetChildIndex(this.bunifuLabel2, 0);
            this.Controls.SetChildIndex(this.bunifuSeparator1, 0);
            this.Controls.SetChildIndex(this.drp_Student, 0);
            this.Controls.SetChildIndex(this.dtp_Schedule, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_EditAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView gv_EditAttendance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker dtp_Schedule;
        private Bunifu.UI.WinForms.BunifuDropdown drp_Student;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Edit;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
    }
}