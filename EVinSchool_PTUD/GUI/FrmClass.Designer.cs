
namespace GUI
{
    partial class FrmClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClass));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.gv_Class = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txt_ClassName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_RefreshClass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_AddClass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.btn_EditClass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_ClassID = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Class)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Class
            // 
            this.gv_Class.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gv_Class.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Class.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Class.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.gv_Class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Class.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_Class.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Class.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Class.ColumnHeadersHeight = 40;
            this.gv_Class.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gv_Class.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gv_Class.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_Class.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gv_Class.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gv_Class.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gv_Class.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gv_Class.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gv_Class.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gv_Class.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gv_Class.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gv_Class.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gv_Class.CurrentTheme.Name = null;
            this.gv_Class.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_Class.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gv_Class.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_Class.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gv_Class.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Class.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Class.EnableHeadersVisualStyles = false;
            this.gv_Class.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gv_Class.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gv_Class.HeaderBgColor = System.Drawing.Color.Empty;
            this.gv_Class.HeaderForeColor = System.Drawing.Color.White;
            this.gv_Class.Location = new System.Drawing.Point(211, 131);
            this.gv_Class.Name = "gv_Class";
            this.gv_Class.RowHeadersVisible = false;
            this.gv_Class.RowHeadersWidth = 51;
            this.gv_Class.RowTemplate.Height = 40;
            this.gv_Class.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Class.Size = new System.Drawing.Size(265, 295);
            this.gv_Class.TabIndex = 0;
            this.gv_Class.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.gv_Class.SelectionChanged += new System.EventHandler(this.gv_Class_SelectionChanged);
            // 
            // txt_ClassName
            // 
            this.txt_ClassName.AcceptsReturn = false;
            this.txt_ClassName.AcceptsTab = false;
            this.txt_ClassName.AnimationSpeed = 200;
            this.txt_ClassName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_ClassName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_ClassName.BackColor = System.Drawing.Color.Transparent;
            this.txt_ClassName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_ClassName.BackgroundImage")));
            this.txt_ClassName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_ClassName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_ClassName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_ClassName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_ClassName.BorderRadius = 10;
            this.txt_ClassName.BorderThickness = 1;
            this.txt_ClassName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_ClassName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ClassName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_ClassName.DefaultText = "";
            this.txt_ClassName.FillColor = System.Drawing.Color.White;
            this.txt_ClassName.HideSelection = true;
            this.txt_ClassName.IconLeft = null;
            this.txt_ClassName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ClassName.IconPadding = 10;
            this.txt_ClassName.IconRight = null;
            this.txt_ClassName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ClassName.Lines = new string[0];
            this.txt_ClassName.Location = new System.Drawing.Point(32, 225);
            this.txt_ClassName.MaxLength = 32767;
            this.txt_ClassName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_ClassName.Modified = false;
            this.txt_ClassName.Multiline = false;
            this.txt_ClassName.Name = "txt_ClassName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_ClassName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_ClassName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_ClassName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_ClassName.OnIdleState = stateProperties4;
            this.txt_ClassName.Padding = new System.Windows.Forms.Padding(3);
            this.txt_ClassName.PasswordChar = '\0';
            this.txt_ClassName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_ClassName.PlaceholderText = "Enter new class";
            this.txt_ClassName.ReadOnly = false;
            this.txt_ClassName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ClassName.SelectedText = "";
            this.txt_ClassName.SelectionLength = 0;
            this.txt_ClassName.SelectionStart = 0;
            this.txt_ClassName.ShortcutsEnabled = true;
            this.txt_ClassName.Size = new System.Drawing.Size(159, 41);
            this.txt_ClassName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_ClassName.TabIndex = 89;
            this.txt_ClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ClassName.TextMarginBottom = 0;
            this.txt_ClassName.TextMarginLeft = 3;
            this.txt_ClassName.TextMarginTop = 0;
            this.txt_ClassName.TextPlaceholder = "Enter new class";
            this.txt_ClassName.UseSystemPasswordChar = false;
            this.txt_ClassName.WordWrap = true;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuLabel3.Location = new System.Drawing.Point(155, 78);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(181, 30);
            this.bunifuLabel3.TabIndex = 88;
            this.bunifuLabel3.Text = "CLASSROOMS";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = false;
            this.bunifuFormDock1.ShowDockingIndicators = false;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_RefreshClass
            // 
            this.btn_RefreshClass.ActiveBorderThickness = 1;
            this.btn_RefreshClass.ActiveCornerRadius = 20;
            this.btn_RefreshClass.ActiveFillColor = System.Drawing.Color.DarkSalmon;
            this.btn_RefreshClass.ActiveForecolor = System.Drawing.Color.White;
            this.btn_RefreshClass.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_RefreshClass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_RefreshClass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_RefreshClass.BackgroundImage")));
            this.btn_RefreshClass.ButtonText = "↻";
            this.btn_RefreshClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RefreshClass.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshClass.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_RefreshClass.IdleBorderThickness = 1;
            this.btn_RefreshClass.IdleCornerRadius = 25;
            this.btn_RefreshClass.IdleFillColor = System.Drawing.Color.White;
            this.btn_RefreshClass.IdleForecolor = System.Drawing.Color.DarkRed;
            this.btn_RefreshClass.IdleLineColor = System.Drawing.Color.IndianRed;
            this.btn_RefreshClass.Location = new System.Drawing.Point(322, 71);
            this.btn_RefreshClass.Margin = new System.Windows.Forms.Padding(5);
            this.btn_RefreshClass.Name = "btn_RefreshClass";
            this.btn_RefreshClass.Size = new System.Drawing.Size(30, 37);
            this.btn_RefreshClass.TabIndex = 90;
            this.btn_RefreshClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_RefreshClass.Click += new System.EventHandler(this.btn_RefreshClass_Click);
            // 
            // btn_AddClass
            // 
            this.btn_AddClass.ActiveBorderThickness = 1;
            this.btn_AddClass.ActiveCornerRadius = 20;
            this.btn_AddClass.ActiveFillColor = System.Drawing.Color.DarkSalmon;
            this.btn_AddClass.ActiveForecolor = System.Drawing.Color.White;
            this.btn_AddClass.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_AddClass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AddClass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddClass.BackgroundImage")));
            this.btn_AddClass.ButtonText = "Add";
            this.btn_AddClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddClass.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddClass.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_AddClass.IdleBorderThickness = 1;
            this.btn_AddClass.IdleCornerRadius = 20;
            this.btn_AddClass.IdleFillColor = System.Drawing.Color.White;
            this.btn_AddClass.IdleForecolor = System.Drawing.Color.DarkRed;
            this.btn_AddClass.IdleLineColor = System.Drawing.Color.IndianRed;
            this.btn_AddClass.Location = new System.Drawing.Point(69, 274);
            this.btn_AddClass.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AddClass.Name = "btn_AddClass";
            this.btn_AddClass.Size = new System.Drawing.Size(80, 43);
            this.btn_AddClass.TabIndex = 91;
            this.btn_AddClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddClass.Click += new System.EventHandler(this.btn_AddClass_Click);
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
            // btn_EditClass
            // 
            this.btn_EditClass.ActiveBorderThickness = 1;
            this.btn_EditClass.ActiveCornerRadius = 20;
            this.btn_EditClass.ActiveFillColor = System.Drawing.Color.DarkSalmon;
            this.btn_EditClass.ActiveForecolor = System.Drawing.Color.White;
            this.btn_EditClass.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_EditClass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_EditClass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EditClass.BackgroundImage")));
            this.btn_EditClass.ButtonText = "Edit";
            this.btn_EditClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditClass.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditClass.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_EditClass.IdleBorderThickness = 1;
            this.btn_EditClass.IdleCornerRadius = 20;
            this.btn_EditClass.IdleFillColor = System.Drawing.Color.White;
            this.btn_EditClass.IdleForecolor = System.Drawing.Color.DarkRed;
            this.btn_EditClass.IdleLineColor = System.Drawing.Color.IndianRed;
            this.btn_EditClass.Location = new System.Drawing.Point(69, 327);
            this.btn_EditClass.Margin = new System.Windows.Forms.Padding(5);
            this.btn_EditClass.Name = "btn_EditClass";
            this.btn_EditClass.Size = new System.Drawing.Size(80, 43);
            this.btn_EditClass.TabIndex = 92;
            this.btn_EditClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EditClass.Click += new System.EventHandler(this.btn_EditClass_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Olive;
            this.bunifuLabel1.Location = new System.Drawing.Point(32, 145);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(25, 26);
            this.bunifuLabel1.TabIndex = 118;
            this.bunifuLabel1.Text = "Id:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_ClassID
            // 
            this.lbl_ClassID.AllowParentOverrides = false;
            this.lbl_ClassID.AutoEllipsis = false;
            this.lbl_ClassID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_ClassID.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_ClassID.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClassID.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ClassID.Location = new System.Drawing.Point(69, 145);
            this.lbl_ClassID.Name = "lbl_ClassID";
            this.lbl_ClassID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ClassID.Size = new System.Drawing.Size(26, 26);
            this.lbl_ClassID.TabIndex = 118;
            this.lbl_ClassID.Text = "ID";
            this.lbl_ClassID.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_ClassID.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Olive;
            this.bunifuLabel2.Location = new System.Drawing.Point(32, 193);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(50, 26);
            this.bunifuLabel2.TabIndex = 118;
            this.bunifuLabel2.Text = "Class:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // FrmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(488, 452);
            this.Controls.Add(this.lbl_ClassID);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.btn_EditClass);
            this.Controls.Add(this.btn_AddClass);
            this.Controls.Add(this.btn_RefreshClass);
            this.Controls.Add(this.txt_ClassName);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.gv_Class);
            this.HeaderBackColor = System.Drawing.Color.Navy;
            this.Name = "FrmClass";
            this.Text = "Manage Classrooms";
            this.Load += new System.EventHandler(this.FrmClass_Load);
            this.Controls.SetChildIndex(this.gv_Class, 0);
            this.Controls.SetChildIndex(this.bunifuLabel3, 0);
            this.Controls.SetChildIndex(this.txt_ClassName, 0);
            this.Controls.SetChildIndex(this.btn_RefreshClass, 0);
            this.Controls.SetChildIndex(this.btn_AddClass, 0);
            this.Controls.SetChildIndex(this.btn_EditClass, 0);
            this.Controls.SetChildIndex(this.bunifuLabel1, 0);
            this.Controls.SetChildIndex(this.bunifuLabel2, 0);
            this.Controls.SetChildIndex(this.lbl_ClassID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Class)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView gv_Class;
        private Bunifu.UI.WinForms.BunifuTextBox txt_ClassName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_AddClass;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_RefreshClass;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_EditClass;
        private Bunifu.UI.WinForms.BunifuLabel lbl_ClassID;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
    }
}