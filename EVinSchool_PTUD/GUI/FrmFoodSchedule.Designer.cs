
namespace GUI
{
    partial class FrmFoodSchedule
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFoodSchedule));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtFoodName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_ClassID = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_FoodClass = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.drpdown_FoodTime = new Bunifu.UI.WinForms.BunifuDropdown();
            this.gvFoodSchedule = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dp_FoodDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.lbl_FoodID = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFoodSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Olive;
            this.bunifuLabel3.Location = new System.Drawing.Point(16, 154);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(110, 26);
            this.bunifuLabel3.TabIndex = 86;
            this.bunifuLabel3.Text = "Food Name";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Garamond", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuLabel2.Location = new System.Drawing.Point(291, 64);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(357, 37);
            this.bunifuLabel2.TabIndex = 85;
            this.bunifuLabel2.Text = "Add/ Edit Food Schedule";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtFoodName
            // 
            this.txtFoodName.AcceptsReturn = false;
            this.txtFoodName.AcceptsTab = false;
            this.txtFoodName.AnimationSpeed = 200;
            this.txtFoodName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFoodName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFoodName.BackColor = System.Drawing.Color.Transparent;
            this.txtFoodName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFoodName.BackgroundImage")));
            this.txtFoodName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFoodName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFoodName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFoodName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFoodName.BorderRadius = 10;
            this.txtFoodName.BorderThickness = 1;
            this.txtFoodName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFoodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtFoodName.DefaultText = "";
            this.txtFoodName.FillColor = System.Drawing.Color.White;
            this.txtFoodName.HideSelection = true;
            this.txtFoodName.IconLeft = null;
            this.txtFoodName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodName.IconPadding = 10;
            this.txtFoodName.IconRight = null;
            this.txtFoodName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodName.Lines = new string[0];
            this.txtFoodName.Location = new System.Drawing.Point(16, 198);
            this.txtFoodName.MaxLength = 32767;
            this.txtFoodName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFoodName.Modified = false;
            this.txtFoodName.Multiline = false;
            this.txtFoodName.Name = "txtFoodName";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFoodName.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFoodName.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFoodName.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFoodName.OnIdleState = stateProperties16;
            this.txtFoodName.Padding = new System.Windows.Forms.Padding(3);
            this.txtFoodName.PasswordChar = '\0';
            this.txtFoodName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFoodName.PlaceholderText = "Enter your food name";
            this.txtFoodName.ReadOnly = false;
            this.txtFoodName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFoodName.SelectedText = "";
            this.txtFoodName.SelectionLength = 0;
            this.txtFoodName.SelectionStart = 0;
            this.txtFoodName.ShortcutsEnabled = true;
            this.txtFoodName.Size = new System.Drawing.Size(244, 41);
            this.txtFoodName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFoodName.TabIndex = 87;
            this.txtFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFoodName.TextMarginBottom = 0;
            this.txtFoodName.TextMarginLeft = 3;
            this.txtFoodName.TextMarginTop = 0;
            this.txtFoodName.TextPlaceholder = "Enter your food name";
            this.txtFoodName.UseSystemPasswordChar = false;
            this.txtFoodName.WordWrap = true;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Olive;
            this.bunifuLabel1.Location = new System.Drawing.Point(16, 261);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(102, 26);
            this.bunifuLabel1.TabIndex = 86;
            this.bunifuLabel1.Text = "Food Time";
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
            this.lbl_ClassID.ForeColor = System.Drawing.Color.Olive;
            this.lbl_ClassID.Location = new System.Drawing.Point(26, 71);
            this.lbl_ClassID.Name = "lbl_ClassID";
            this.lbl_ClassID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ClassID.Size = new System.Drawing.Size(26, 26);
            this.lbl_ClassID.TabIndex = 86;
            this.lbl_ClassID.Text = "ID";
            this.lbl_ClassID.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_ClassID.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_FoodClass
            // 
            this.lbl_FoodClass.AllowParentOverrides = false;
            this.lbl_FoodClass.AutoEllipsis = false;
            this.lbl_FoodClass.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_FoodClass.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_FoodClass.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FoodClass.ForeColor = System.Drawing.Color.Gray;
            this.lbl_FoodClass.Location = new System.Drawing.Point(66, 71);
            this.lbl_FoodClass.Name = "lbl_FoodClass";
            this.lbl_FoodClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_FoodClass.Size = new System.Drawing.Size(106, 26);
            this.lbl_FoodClass.TabIndex = 86;
            this.lbl_FoodClass.Text = "Class Name";
            this.lbl_FoodClass.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_FoodClass.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // drpdown_FoodTime
            // 
            this.drpdown_FoodTime.BackColor = System.Drawing.Color.Transparent;
            this.drpdown_FoodTime.BackgroundColor = System.Drawing.Color.White;
            this.drpdown_FoodTime.BorderColor = System.Drawing.Color.Silver;
            this.drpdown_FoodTime.BorderRadius = 7;
            this.drpdown_FoodTime.Color = System.Drawing.Color.Silver;
            this.drpdown_FoodTime.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drpdown_FoodTime.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drpdown_FoodTime.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drpdown_FoodTime.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drpdown_FoodTime.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.drpdown_FoodTime.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.drpdown_FoodTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drpdown_FoodTime.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.drpdown_FoodTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdown_FoodTime.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drpdown_FoodTime.FillDropDown = true;
            this.drpdown_FoodTime.FillIndicator = false;
            this.drpdown_FoodTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpdown_FoodTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.drpdown_FoodTime.ForeColor = System.Drawing.Color.Black;
            this.drpdown_FoodTime.FormattingEnabled = true;
            this.drpdown_FoodTime.Icon = null;
            this.drpdown_FoodTime.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpdown_FoodTime.IndicatorColor = System.Drawing.Color.Gray;
            this.drpdown_FoodTime.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpdown_FoodTime.ItemBackColor = System.Drawing.Color.White;
            this.drpdown_FoodTime.ItemBorderColor = System.Drawing.Color.White;
            this.drpdown_FoodTime.ItemForeColor = System.Drawing.Color.Black;
            this.drpdown_FoodTime.ItemHeight = 26;
            this.drpdown_FoodTime.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.drpdown_FoodTime.ItemHighLightForeColor = System.Drawing.Color.White;
            this.drpdown_FoodTime.ItemTopMargin = 3;
            this.drpdown_FoodTime.Location = new System.Drawing.Point(16, 305);
            this.drpdown_FoodTime.Name = "drpdown_FoodTime";
            this.drpdown_FoodTime.Size = new System.Drawing.Size(244, 32);
            this.drpdown_FoodTime.TabIndex = 89;
            this.drpdown_FoodTime.Text = null;
            this.drpdown_FoodTime.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drpdown_FoodTime.TextLeftMargin = 5;
            this.drpdown_FoodTime.SelectedIndexChanged += new System.EventHandler(this.drpdown_FoodTime_SelectedIndexChanged);
            // 
            // gvFoodSchedule
            // 
            this.gvFoodSchedule.AllowCustomTheming = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.gvFoodSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gvFoodSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvFoodSchedule.BackgroundColor = System.Drawing.Color.Lavender;
            this.gvFoodSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvFoodSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvFoodSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvFoodSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gvFoodSchedule.ColumnHeadersHeight = 40;
            this.gvFoodSchedule.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvFoodSchedule.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvFoodSchedule.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvFoodSchedule.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gvFoodSchedule.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gvFoodSchedule.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gvFoodSchedule.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gvFoodSchedule.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gvFoodSchedule.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gvFoodSchedule.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvFoodSchedule.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gvFoodSchedule.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvFoodSchedule.CurrentTheme.Name = null;
            this.gvFoodSchedule.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvFoodSchedule.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvFoodSchedule.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvFoodSchedule.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gvFoodSchedule.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFoodSchedule.DefaultCellStyle = dataGridViewCellStyle12;
            this.gvFoodSchedule.EnableHeadersVisualStyles = false;
            this.gvFoodSchedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gvFoodSchedule.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gvFoodSchedule.HeaderBgColor = System.Drawing.Color.Empty;
            this.gvFoodSchedule.HeaderForeColor = System.Drawing.Color.White;
            this.gvFoodSchedule.Location = new System.Drawing.Point(291, 154);
            this.gvFoodSchedule.Name = "gvFoodSchedule";
            this.gvFoodSchedule.RowHeadersVisible = false;
            this.gvFoodSchedule.RowHeadersWidth = 51;
            this.gvFoodSchedule.RowTemplate.Height = 40;
            this.gvFoodSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvFoodSchedule.Size = new System.Drawing.Size(486, 347);
            this.gvFoodSchedule.TabIndex = 90;
            this.gvFoodSchedule.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.gvFoodSchedule.SelectionChanged += new System.EventHandler(this.gvFoodSchedule_SelectionChanged);
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.ForeColor = System.Drawing.Color.Olive;
            this.bunifuLabel6.Location = new System.Drawing.Point(16, 355);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(99, 26);
            this.bunifuLabel6.TabIndex = 86;
            this.bunifuLabel6.Text = "Food Date";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dp_FoodDate
            // 
            this.dp_FoodDate.BackColor = System.Drawing.Color.White;
            this.dp_FoodDate.BorderRadius = 10;
            this.dp_FoodDate.Color = System.Drawing.Color.Silver;
            this.dp_FoodDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dp_FoodDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dp_FoodDate.DisabledColor = System.Drawing.Color.Gray;
            this.dp_FoodDate.DisplayWeekNumbers = false;
            this.dp_FoodDate.DPHeight = 0;
            this.dp_FoodDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dp_FoodDate.FillDatePicker = false;
            this.dp_FoodDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dp_FoodDate.ForeColor = System.Drawing.Color.Black;
            this.dp_FoodDate.Icon = ((System.Drawing.Image)(resources.GetObject("dp_FoodDate.Icon")));
            this.dp_FoodDate.IconColor = System.Drawing.Color.Gray;
            this.dp_FoodDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dp_FoodDate.LeftTextMargin = 5;
            this.dp_FoodDate.Location = new System.Drawing.Point(16, 398);
            this.dp_FoodDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.dp_FoodDate.Name = "dp_FoodDate";
            this.dp_FoodDate.Size = new System.Drawing.Size(247, 32);
            this.dp_FoodDate.TabIndex = 91;
            // 
            // lbl_FoodID
            // 
            this.lbl_FoodID.AllowParentOverrides = false;
            this.lbl_FoodID.AutoEllipsis = false;
            this.lbl_FoodID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_FoodID.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_FoodID.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FoodID.ForeColor = System.Drawing.Color.Gray;
            this.lbl_FoodID.Location = new System.Drawing.Point(237, 154);
            this.lbl_FoodID.Name = "lbl_FoodID";
            this.lbl_FoodID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_FoodID.Size = new System.Drawing.Size(26, 26);
            this.lbl_FoodID.TabIndex = 86;
            this.lbl_FoodID.Text = "ID";
            this.lbl_FoodID.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lbl_FoodID.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(-23, 105);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(823, 18);
            this.bunifuSeparator1.TabIndex = 92;
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveBorderThickness = 1;
            this.btnEdit.ActiveCornerRadius = 20;
            this.btnEdit.ActiveFillColor = System.Drawing.Color.LightGreen;
            this.btnEdit.ActiveForecolor = System.Drawing.Color.White;
            this.btnEdit.ActiveLineColor = System.Drawing.Color.GreenYellow;
            this.btnEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.ButtonText = "Edit";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.IdleBorderThickness = 1;
            this.btnEdit.IdleCornerRadius = 20;
            this.btnEdit.IdleFillColor = System.Drawing.Color.White;
            this.btnEdit.IdleForecolor = System.Drawing.Color.DarkOliveGreen;
            this.btnEdit.IdleLineColor = System.Drawing.Color.LimeGreen;
            this.btnEdit.Location = new System.Drawing.Point(146, 458);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 43);
            this.btnEdit.TabIndex = 93;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.White;
            this.btnAdd.IdleForecolor = System.Drawing.Color.DarkRed;
            this.btnAdd.IdleLineColor = System.Drawing.Color.IndianRed;
            this.btnAdd.Location = new System.Drawing.Point(48, 458);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 43);
            this.btnAdd.TabIndex = 93;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmFoodSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.dp_FoodDate);
            this.Controls.Add(this.gvFoodSchedule);
            this.Controls.Add(this.drpdown_FoodTime);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.lbl_FoodID);
            this.Controls.Add(this.lbl_FoodClass);
            this.Controls.Add(this.lbl_ClassID);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.HeaderBackColor = System.Drawing.Color.Navy;
            this.Name = "FrmFoodSchedule";
            this.Text = "Manage Food Schedule";
            this.Load += new System.EventHandler(this.FrmFoodSchedule_Load);
            this.Controls.SetChildIndex(this.bunifuLabel2, 0);
            this.Controls.SetChildIndex(this.bunifuLabel3, 0);
            this.Controls.SetChildIndex(this.lbl_ClassID, 0);
            this.Controls.SetChildIndex(this.lbl_FoodClass, 0);
            this.Controls.SetChildIndex(this.lbl_FoodID, 0);
            this.Controls.SetChildIndex(this.bunifuLabel1, 0);
            this.Controls.SetChildIndex(this.bunifuLabel6, 0);
            this.Controls.SetChildIndex(this.txtFoodName, 0);
            this.Controls.SetChildIndex(this.drpdown_FoodTime, 0);
            this.Controls.SetChildIndex(this.gvFoodSchedule, 0);
            this.Controls.SetChildIndex(this.dp_FoodDate, 0);
            this.Controls.SetChildIndex(this.bunifuSeparator1, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFoodSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuTextBox txtFoodName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel lbl_ClassID;
        private Bunifu.UI.WinForms.BunifuLabel lbl_FoodClass;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuDropdown drpdown_FoodTime;
        private Bunifu.UI.WinForms.BunifuDataGridView gvFoodSchedule;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuDatePicker dp_FoodDate;
        private Bunifu.UI.WinForms.BunifuLabel lbl_FoodID;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
    }
}