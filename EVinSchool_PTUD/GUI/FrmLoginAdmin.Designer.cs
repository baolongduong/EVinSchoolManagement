
namespace GUI
{
    partial class FrmLoginAdmin
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginAdmin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtAdminPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtAdminEmail = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel30 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnLoginAdmin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.AcceptsReturn = false;
            this.txtAdminPassword.AcceptsTab = false;
            this.txtAdminPassword.AnimationSpeed = 200;
            this.txtAdminPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAdminPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAdminPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtAdminPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAdminPassword.BackgroundImage")));
            this.txtAdminPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtAdminPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtAdminPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtAdminPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAdminPassword.BorderRadius = 20;
            this.txtAdminPassword.BorderThickness = 1;
            this.txtAdminPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAdminPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminPassword.DefaultFont = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPassword.DefaultText = "";
            this.txtAdminPassword.FillColor = System.Drawing.Color.White;
            this.txtAdminPassword.HideSelection = true;
            this.txtAdminPassword.IconLeft = global::GUI.Properties.Resources._lock;
            this.txtAdminPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminPassword.IconPadding = 10;
            this.txtAdminPassword.IconRight = null;
            this.txtAdminPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminPassword.Lines = new string[0];
            this.txtAdminPassword.Location = new System.Drawing.Point(248, 231);
            this.txtAdminPassword.MaxLength = 32767;
            this.txtAdminPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAdminPassword.Modified = false;
            this.txtAdminPassword.Multiline = false;
            this.txtAdminPassword.Name = "txtAdminPassword";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdminPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAdminPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdminPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdminPassword.OnIdleState = stateProperties4;
            this.txtAdminPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtAdminPassword.PasswordChar = '●';
            this.txtAdminPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAdminPassword.PlaceholderText = "Enter text";
            this.txtAdminPassword.ReadOnly = false;
            this.txtAdminPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdminPassword.SelectedText = "";
            this.txtAdminPassword.SelectionLength = 0;
            this.txtAdminPassword.SelectionStart = 0;
            this.txtAdminPassword.ShortcutsEnabled = true;
            this.txtAdminPassword.Size = new System.Drawing.Size(295, 43);
            this.txtAdminPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtAdminPassword.TabIndex = 87;
            this.txtAdminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdminPassword.TextMarginBottom = 0;
            this.txtAdminPassword.TextMarginLeft = 3;
            this.txtAdminPassword.TextMarginTop = 0;
            this.txtAdminPassword.TextPlaceholder = "Enter text";
            this.txtAdminPassword.UseSystemPasswordChar = true;
            this.txtAdminPassword.WordWrap = true;
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.AcceptsReturn = false;
            this.txtAdminEmail.AcceptsTab = false;
            this.txtAdminEmail.AnimationSpeed = 200;
            this.txtAdminEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAdminEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAdminEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtAdminEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAdminEmail.BackgroundImage")));
            this.txtAdminEmail.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtAdminEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtAdminEmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtAdminEmail.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAdminEmail.BorderRadius = 20;
            this.txtAdminEmail.BorderThickness = 1;
            this.txtAdminEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAdminEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminEmail.DefaultFont = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminEmail.DefaultText = "";
            this.txtAdminEmail.FillColor = System.Drawing.Color.White;
            this.txtAdminEmail.HideSelection = true;
            this.txtAdminEmail.IconLeft = global::GUI.Properties.Resources.usericon;
            this.txtAdminEmail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminEmail.IconPadding = 10;
            this.txtAdminEmail.IconRight = null;
            this.txtAdminEmail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminEmail.Lines = new string[0];
            this.txtAdminEmail.Location = new System.Drawing.Point(248, 130);
            this.txtAdminEmail.MaxLength = 32767;
            this.txtAdminEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAdminEmail.Modified = false;
            this.txtAdminEmail.Multiline = false;
            this.txtAdminEmail.Name = "txtAdminEmail";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdminEmail.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAdminEmail.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdminEmail.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdminEmail.OnIdleState = stateProperties8;
            this.txtAdminEmail.Padding = new System.Windows.Forms.Padding(3);
            this.txtAdminEmail.PasswordChar = '\0';
            this.txtAdminEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAdminEmail.PlaceholderText = "Enter text";
            this.txtAdminEmail.ReadOnly = false;
            this.txtAdminEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdminEmail.SelectedText = "";
            this.txtAdminEmail.SelectionLength = 0;
            this.txtAdminEmail.SelectionStart = 0;
            this.txtAdminEmail.ShortcutsEnabled = true;
            this.txtAdminEmail.Size = new System.Drawing.Size(295, 43);
            this.txtAdminEmail.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtAdminEmail.TabIndex = 88;
            this.txtAdminEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdminEmail.TextMarginBottom = 0;
            this.txtAdminEmail.TextMarginLeft = 3;
            this.txtAdminEmail.TextMarginTop = 0;
            this.txtAdminEmail.TextPlaceholder = "Enter text";
            this.txtAdminEmail.UseSystemPasswordChar = false;
            this.txtAdminEmail.WordWrap = true;
            // 
            // bunifuLabel30
            // 
            this.bunifuLabel30.AllowParentOverrides = false;
            this.bunifuLabel30.AutoEllipsis = false;
            this.bunifuLabel30.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel30.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel30.Font = new System.Drawing.Font("Garamond", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel30.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bunifuLabel30.Location = new System.Drawing.Point(248, 99);
            this.bunifuLabel30.Name = "bunifuLabel30";
            this.bunifuLabel30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel30.Size = new System.Drawing.Size(55, 25);
            this.bunifuLabel30.TabIndex = 86;
            this.bunifuLabel30.Text = "Email:";
            this.bunifuLabel30.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel30.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Garamond", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bunifuLabel4.Location = new System.Drawing.Point(248, 200);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(86, 25);
            this.bunifuLabel4.TabIndex = 85;
            this.bunifuLabel4.Text = "Password:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.ActiveBorderThickness = 1;
            this.btnLoginAdmin.ActiveCornerRadius = 20;
            this.btnLoginAdmin.ActiveFillColor = System.Drawing.Color.DarkGray;
            this.btnLoginAdmin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLoginAdmin.ActiveLineColor = System.Drawing.Color.DimGray;
            this.btnLoginAdmin.BackColor = System.Drawing.Color.White;
            this.btnLoginAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoginAdmin.BackgroundImage")));
            this.btnLoginAdmin.ButtonText = "Login";
            this.btnLoginAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginAdmin.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAdmin.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnLoginAdmin.IdleBorderThickness = 1;
            this.btnLoginAdmin.IdleCornerRadius = 20;
            this.btnLoginAdmin.IdleFillColor = System.Drawing.Color.White;
            this.btnLoginAdmin.IdleForecolor = System.Drawing.Color.Silver;
            this.btnLoginAdmin.IdleLineColor = System.Drawing.Color.DimGray;
            this.btnLoginAdmin.Location = new System.Drawing.Point(354, 294);
            this.btnLoginAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(77, 36);
            this.btnLoginAdmin.TabIndex = 89;
            this.btnLoginAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 121;
            this.bunifuPictureBox1.Image = global::GUI.Properties.Resources.admin_config;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(0, 78);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(242, 242);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 90;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 355);
            this.ControlBoxColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.txtAdminEmail);
            this.Controls.Add(this.bunifuLabel30);
            this.Controls.Add(this.bunifuLabel4);
            this.HeaderBackColor = System.Drawing.Color.DarkRed;
            this.Icon = global::GUI.Properties.Resources._lock;
            this.Name = "FrmLoginAdmin";
            this.Text = "Login as Adminstrator";
            this.Controls.SetChildIndex(this.bunifuLabel4, 0);
            this.Controls.SetChildIndex(this.bunifuLabel30, 0);
            this.Controls.SetChildIndex(this.txtAdminEmail, 0);
            this.Controls.SetChildIndex(this.txtAdminPassword, 0);
            this.Controls.SetChildIndex(this.btnLoginAdmin, 0);
            this.Controls.SetChildIndex(this.bunifuPictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTextBox txtAdminPassword;
        private Bunifu.UI.WinForms.BunifuTextBox txtAdminEmail;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel30;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLoginAdmin;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}