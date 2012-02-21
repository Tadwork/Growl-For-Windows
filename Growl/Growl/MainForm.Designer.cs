namespace Growl
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.onOffButton1 = new Growl.UI.OnOffButton();
            this.checkBoxAutoStart = new System.Windows.Forms.CheckBox();
            this.labelCurrentState = new System.Windows.Forms.Label();
            this.groupBoxIdleSettings = new System.Windows.Forms.GroupBox();
            this.textBoxIdleAfterSeconds = new System.Windows.Forms.TextBox();
            this.radioButtonIdleAfter = new System.Windows.Forms.RadioButton();
            this.radioButtonIdleNever = new System.Windows.Forms.RadioButton();
            this.groupBoxSoundSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxMuteAllSounds = new System.Windows.Forms.CheckBox();
            this.labelDefaultSound = new System.Windows.Forms.Label();
            this.comboBoxDefaultSound = new System.Windows.Forms.ComboBox();
            this.panelApplications = new System.Windows.Forms.Panel();
            this.listControlApplications = new Growl.UI.ListControl();
            this.panelSelectedApplication = new System.Windows.Forms.Panel();
            this.listControlApplicationNotifications = new Growl.UI.ListControl();
            this.panelPrefs = new System.Windows.Forms.Panel();
            this.labelPrefDuration = new System.Windows.Forms.Label();
            this.comboBoxPrefDuration = new System.Windows.Forms.ComboBox();
            this.labelPrefSound = new System.Windows.Forms.Label();
            this.comboBoxPrefSound = new System.Windows.Forms.ComboBox();
            this.comboBoxPrefSticky = new System.Windows.Forms.ComboBox();
            this.labelPrefPriority = new System.Windows.Forms.Label();
            this.comboBoxPrefPriority = new System.Windows.Forms.ComboBox();
            this.labelPrefForward = new System.Windows.Forms.Label();
            this.comboBoxPrefForward = new System.Windows.Forms.ComboBox();
            this.labelApplicationNotification = new System.Windows.Forms.Label();
            this.pictureBoxApplicationNotification = new System.Windows.Forms.PictureBox();
            this.labelPrefSticky = new System.Windows.Forms.Label();
            this.comboBoxPrefDisplay = new System.Windows.Forms.ComboBox();
            this.labelPrefDisplay = new System.Windows.Forms.Label();
            this.labelPrefEnabled = new System.Windows.Forms.Label();
            this.comboBoxPrefEnabled = new System.Windows.Forms.ComboBox();
            this.pictureBoxApplication = new System.Windows.Forms.PictureBox();
            this.labelApplication = new System.Windows.Forms.Label();
            this.panelNoApps = new System.Windows.Forms.Panel();
            this.labelNoAppsDesc = new System.Windows.Forms.Label();
            this.labelNoApps = new System.Windows.Forms.Label();
            this.panelDisplays = new System.Windows.Forms.Panel();
            this.getDisplaysLabel = new System.Windows.Forms.LinkLabel();
            this.listControlDisplays = new Growl.UI.ListControl();
            this.panelDisplaySettings = new System.Windows.Forms.Panel();
            this.pictureBoxMultipleMonitors = new System.Windows.Forms.PictureBox();
            this.buttonSetAsDefault = new Growl.UI.ButtonEx();
            this.displayStyleWebsiteLabel = new System.Windows.Forms.LinkLabel();
            this.displayStyleVersionLabel = new System.Windows.Forms.Label();
            this.displayStyleAuthorLabel = new System.Windows.Forms.Label();
            this.buttonPreviewDisplay = new Growl.UI.ButtonEx();
            this.displayStyleDescriptionLabel = new System.Windows.Forms.Label();
            this.displayStyleNameLabel = new System.Windows.Forms.Label();
            this.panelDisplaySettingsContainer = new System.Windows.Forms.Panel();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.labelAboutBuildNumber = new System.Windows.Forms.Label();
            this.labelAboutUsLink = new System.Windows.Forms.LinkLabel();
            this.labelAboutUs = new System.Windows.Forms.Label();
            this.labelAboutIconsLink = new System.Windows.Forms.LinkLabel();
            this.labelAboutIcons2 = new System.Windows.Forms.Label();
            this.labelAboutIcons = new System.Windows.Forms.Label();
            this.labelAboutOriginalLink = new System.Windows.Forms.LinkLabel();
            this.labelAboutOriginal2 = new System.Windows.Forms.Label();
            this.labelAboutOriginal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAboutGrowlVersion = new System.Windows.Forms.Label();
            this.panelSecurity = new System.Windows.Forms.Panel();
            this.checkBoxRequireLANPassword = new System.Windows.Forms.CheckBox();
            this.labelPasswordManager = new System.Windows.Forms.Label();
            this.passwordManagerControl1 = new Growl.UI.PasswordManagerControl();
            this.checkBoxAllowSubscriptions = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowWebNotifications = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowNetworkNotifications = new System.Windows.Forms.CheckBox();
            this.checkBoxRequireLocalPassword = new System.Windows.Forms.CheckBox();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.historyFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.historyFilterTextBox = new System.Windows.Forms.TextBox();
            this.buttonClearHistory = new Growl.UI.ButtonEx();
            this.historyDaysGroupBox = new System.Windows.Forms.GroupBox();
            this.historyDaysTrackBar = new Dotnetrix.Controls.TrackBar();
            this.historySortByGroupBox = new System.Windows.Forms.GroupBox();
            this.historySortByDateRadioButton = new System.Windows.Forms.RadioButton();
            this.historySortByApplicationRadioButton = new System.Windows.Forms.RadioButton();
            this.historyListView = new Growl.UI.HistoryListView();
            this.panelHistoryListViewBacker = new System.Windows.Forms.Panel();
            this.panelInitializing = new System.Windows.Forms.Panel();
            this.labelInitializationStage = new System.Windows.Forms.Label();
            this.progressBarInitializing = new System.Windows.Forms.ProgressBar();
            this.labelInitializing = new System.Windows.Forms.Label();
            this.panelNetwork = new System.Windows.Forms.Panel();
            this.checkBoxEnableSubscriptions = new System.Windows.Forms.CheckBox();
            this.buttonUnsubscribe = new Growl.UI.ImageButton();
            this.buttonSubscribe = new Growl.UI.ImageButton();
            this.subscribedListView = new Growl.UI.ForwardListView();
            this.buttonRemoveComputer = new Growl.UI.ImageButton();
            this.buttonAddComputer = new Growl.UI.ImageButton();
            this.forwardListView = new Growl.UI.ForwardListView();
            this.checkBoxEnableForwarding = new System.Windows.Forms.CheckBox();
            this.contextMenuStripApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripForwardDestinations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripSubscriptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSubscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsubscribeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMultipleMonitors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolbarPanel = new Growl.UI.CustomPanel();
            this.toolStrip1 = new Growl.UI.Toolbar();
            this.toolbarButtonGeneral = new System.Windows.Forms.ToolStripButton();
            this.toolbarButtonApplications = new System.Windows.Forms.ToolStripButton();
            this.toolbarButtonDisplays = new System.Windows.Forms.ToolStripButton();
            this.toolbarButtonNetwork = new System.Windows.Forms.ToolStripButton();
            this.toolbarButtonSecurity = new System.Windows.Forms.ToolStripButton();
            this.toolbarButtonHistory = new System.Windows.Forms.ToolStripButton();
            this.toolbarButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.panelGeneral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onOffButton1)).BeginInit();
            this.groupBoxIdleSettings.SuspendLayout();
            this.groupBoxSoundSettings.SuspendLayout();
            this.panelApplications.SuspendLayout();
            this.panelSelectedApplication.SuspendLayout();
            this.panelPrefs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApplicationNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApplication)).BeginInit();
            this.panelNoApps.SuspendLayout();
            this.panelDisplays.SuspendLayout();
            this.panelDisplaySettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMultipleMonitors)).BeginInit();
            this.panelAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSecurity.SuspendLayout();
            this.panelHistory.SuspendLayout();
            this.historyFilterGroupBox.SuspendLayout();
            this.historyDaysGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDaysTrackBar)).BeginInit();
            this.historySortByGroupBox.SuspendLayout();
            this.panelInitializing.SuspendLayout();
            this.panelNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUnsubscribe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSubscribe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRemoveComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAddComputer)).BeginInit();
            this.contextMenuStripApplications.SuspendLayout();
            this.contextMenuStripForwardDestinations.SuspendLayout();
            this.contextMenuStripSubscriptions.SuspendLayout();
            this.toolbarPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGeneral.BackColor = System.Drawing.Color.Transparent;
            this.panelGeneral.Controls.Add(this.groupBox1);
            this.panelGeneral.Controls.Add(this.groupBoxIdleSettings);
            this.panelGeneral.Controls.Add(this.groupBoxSoundSettings);
            this.panelGeneral.Location = new System.Drawing.Point(0, 70);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(663, 304);
            this.panelGeneral.TabIndex = 2;
            this.panelGeneral.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.onOffButton1);
            this.groupBox1.Controls.Add(this.checkBoxAutoStart);
            this.groupBox1.Controls.Add(this.labelCurrentState);
            this.groupBox1.Location = new System.Drawing.Point(96, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 89);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // onOffButton1
            // 
            this.onOffButton1.Image = ((System.Drawing.Image)(resources.GetObject("onOffButton1.Image")));
            this.onOffButton1.Location = new System.Drawing.Point(22, 17);
            this.onOffButton1.Name = "onOffButton1";
            this.onOffButton1.On = false;
            this.onOffButton1.Size = new System.Drawing.Size(94, 27);
            this.onOffButton1.TabIndex = 0;
            this.onOffButton1.TabStop = false;
            // 
            // checkBoxAutoStart
            // 
            this.checkBoxAutoStart.AutoSize = true;
            this.checkBoxAutoStart.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAutoStart.Location = new System.Drawing.Point(22, 51);
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.Size = new System.Drawing.Size(223, 22);
            this.checkBoxAutoStart.TabIndex = 1;
            this.checkBoxAutoStart.Text = "Automatically start Growl at login";
            this.checkBoxAutoStart.UseVisualStyleBackColor = true;
            this.checkBoxAutoStart.CheckedChanged += new System.EventHandler(this.checkBoxAutoStart_CheckedChanged);
            // 
            // labelCurrentState
            // 
            this.labelCurrentState.AutoSize = true;
            this.labelCurrentState.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentState.Location = new System.Drawing.Point(141, 17);
            this.labelCurrentState.Name = "labelCurrentState";
            this.labelCurrentState.Size = new System.Drawing.Size(122, 27);
            this.labelCurrentState.TabIndex = 2;
            this.labelCurrentState.Text = "Growl is {0}";
            // 
            // groupBoxIdleSettings
            // 
            this.groupBoxIdleSettings.Controls.Add(this.textBoxIdleAfterSeconds);
            this.groupBoxIdleSettings.Controls.Add(this.radioButtonIdleAfter);
            this.groupBoxIdleSettings.Controls.Add(this.radioButtonIdleNever);
            this.groupBoxIdleSettings.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIdleSettings.Location = new System.Drawing.Point(96, 185);
            this.groupBoxIdleSettings.Name = "groupBoxIdleSettings";
            this.groupBoxIdleSettings.Size = new System.Drawing.Size(468, 89);
            this.groupBoxIdleSettings.TabIndex = 5;
            this.groupBoxIdleSettings.TabStop = false;
            this.groupBoxIdleSettings.Text = "Idle Settings";
            // 
            // textBoxIdleAfterSeconds
            // 
            this.textBoxIdleAfterSeconds.Enabled = false;
            this.textBoxIdleAfterSeconds.Location = new System.Drawing.Point(184, 53);
            this.textBoxIdleAfterSeconds.Name = "textBoxIdleAfterSeconds";
            this.textBoxIdleAfterSeconds.Size = new System.Drawing.Size(37, 23);
            this.textBoxIdleAfterSeconds.TabIndex = 2;
            this.textBoxIdleAfterSeconds.TextChanged += new System.EventHandler(this.textBoxIdleAfterSeconds_TextChanged);
            this.textBoxIdleAfterSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdleAfterSeconds_KeyPress);
            // 
            // radioButtonIdleAfter
            // 
            this.radioButtonIdleAfter.AutoSize = true;
            this.radioButtonIdleAfter.Location = new System.Drawing.Point(28, 54);
            this.radioButtonIdleAfter.Name = "radioButtonIdleAfter";
            this.radioButtonIdleAfter.Size = new System.Drawing.Size(251, 22);
            this.radioButtonIdleAfter.TabIndex = 1;
            this.radioButtonIdleAfter.TabStop = true;
            this.radioButtonIdleAfter.Text = "Consider me idle after            seconds";
            this.radioButtonIdleAfter.UseVisualStyleBackColor = true;
            this.radioButtonIdleAfter.CheckedChanged += new System.EventHandler(this.radioButtonIdleAfter_CheckedChanged);
            // 
            // radioButtonIdleNever
            // 
            this.radioButtonIdleNever.AutoSize = true;
            this.radioButtonIdleNever.Checked = true;
            this.radioButtonIdleNever.Location = new System.Drawing.Point(28, 26);
            this.radioButtonIdleNever.Name = "radioButtonIdleNever";
            this.radioButtonIdleNever.Size = new System.Drawing.Size(209, 22);
            this.radioButtonIdleNever.TabIndex = 0;
            this.radioButtonIdleNever.TabStop = true;
            this.radioButtonIdleNever.Text = "Never consider me idle or away";
            this.radioButtonIdleNever.UseVisualStyleBackColor = true;
            // 
            // groupBoxSoundSettings
            // 
            this.groupBoxSoundSettings.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSoundSettings.Controls.Add(this.checkBoxMuteAllSounds);
            this.groupBoxSoundSettings.Controls.Add(this.labelDefaultSound);
            this.groupBoxSoundSettings.Controls.Add(this.comboBoxDefaultSound);
            this.groupBoxSoundSettings.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSoundSettings.Location = new System.Drawing.Point(96, 108);
            this.groupBoxSoundSettings.Name = "groupBoxSoundSettings";
            this.groupBoxSoundSettings.Size = new System.Drawing.Size(468, 68);
            this.groupBoxSoundSettings.TabIndex = 4;
            this.groupBoxSoundSettings.TabStop = false;
            this.groupBoxSoundSettings.Text = "Sound Settings";
            // 
            // checkBoxMuteAllSounds
            // 
            this.checkBoxMuteAllSounds.AutoSize = true;
            this.checkBoxMuteAllSounds.Location = new System.Drawing.Point(304, 29);
            this.checkBoxMuteAllSounds.Name = "checkBoxMuteAllSounds";
            this.checkBoxMuteAllSounds.Size = new System.Drawing.Size(117, 22);
            this.checkBoxMuteAllSounds.TabIndex = 22;
            this.checkBoxMuteAllSounds.Text = "Mute all sounds";
            this.checkBoxMuteAllSounds.UseVisualStyleBackColor = true;
            this.checkBoxMuteAllSounds.CheckedChanged += new System.EventHandler(this.checkBoxMuteAllSounds_CheckedChanged);
            // 
            // labelDefaultSound
            // 
            this.labelDefaultSound.AutoSize = true;
            this.labelDefaultSound.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.labelDefaultSound.Location = new System.Drawing.Point(25, 29);
            this.labelDefaultSound.Name = "labelDefaultSound";
            this.labelDefaultSound.Size = new System.Drawing.Size(94, 18);
            this.labelDefaultSound.TabIndex = 21;
            this.labelDefaultSound.Text = "Default Sound:";
            // 
            // comboBoxDefaultSound
            // 
            this.comboBoxDefaultSound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDefaultSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxDefaultSound.FormattingEnabled = true;
            this.comboBoxDefaultSound.Location = new System.Drawing.Point(119, 29);
            this.comboBoxDefaultSound.Name = "comboBoxDefaultSound";
            this.comboBoxDefaultSound.Size = new System.Drawing.Size(139, 21);
            this.comboBoxDefaultSound.TabIndex = 20;
            this.comboBoxDefaultSound.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDefaultSound_SelectionChangeCommitted);
            // 
            // panelApplications
            // 
            this.panelApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelApplications.BackColor = System.Drawing.Color.Transparent;
            this.panelApplications.Controls.Add(this.listControlApplications);
            this.panelApplications.Controls.Add(this.panelSelectedApplication);
            this.panelApplications.Controls.Add(this.panelNoApps);
            this.panelApplications.Location = new System.Drawing.Point(0, 70);
            this.panelApplications.Name = "panelApplications";
            this.panelApplications.Size = new System.Drawing.Size(663, 304);
            this.panelApplications.TabIndex = 3;
            this.panelApplications.Visible = false;
            // 
            // listControlApplications
            // 
            this.listControlApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listControlApplications.BackColor = System.Drawing.Color.White;
            this.listControlApplications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listControlApplications.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.listControlApplications.HeaderText = "Application Name";
            this.listControlApplications.IsDefaultComparer = null;
            this.listControlApplications.Location = new System.Drawing.Point(4, 4);
            this.listControlApplications.Name = "listControlApplications";
            this.listControlApplications.SelectedIndex = -1;
            this.listControlApplications.SelectedItem = null;
            this.listControlApplications.Size = new System.Drawing.Size(176, 291);
            this.listControlApplications.TabIndex = 9;
            this.listControlApplications.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listControlApplications_MouseDown);
            this.listControlApplications.SelectedIndexChanged += new System.EventHandler(this.listControlApplications_SelectedIndexChanged);
            // 
            // panelSelectedApplication
            // 
            this.panelSelectedApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSelectedApplication.Controls.Add(this.listControlApplicationNotifications);
            this.panelSelectedApplication.Controls.Add(this.panelPrefs);
            this.panelSelectedApplication.Controls.Add(this.pictureBoxApplication);
            this.panelSelectedApplication.Controls.Add(this.labelApplication);
            this.panelSelectedApplication.Location = new System.Drawing.Point(186, 4);
            this.panelSelectedApplication.Name = "panelSelectedApplication";
            this.panelSelectedApplication.Size = new System.Drawing.Size(474, 296);
            this.panelSelectedApplication.TabIndex = 3;
            this.panelSelectedApplication.Visible = false;
            // 
            // listControlApplicationNotifications
            // 
            this.listControlApplicationNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listControlApplicationNotifications.BackColor = System.Drawing.Color.White;
            this.listControlApplicationNotifications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listControlApplicationNotifications.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listControlApplicationNotifications.HeaderText = "Notification Type";
            this.listControlApplicationNotifications.IsDefaultComparer = null;
            this.listControlApplicationNotifications.Location = new System.Drawing.Point(7, 57);
            this.listControlApplicationNotifications.Name = "listControlApplicationNotifications";
            this.listControlApplicationNotifications.SelectedIndex = -1;
            this.listControlApplicationNotifications.SelectedItem = null;
            this.listControlApplicationNotifications.Size = new System.Drawing.Size(176, 234);
            this.listControlApplicationNotifications.TabIndex = 7;
            this.listControlApplicationNotifications.SelectedIndexChanged += new System.EventHandler(this.listControlApplicationNotifications_SelectedIndexChanged);
            // 
            // panelPrefs
            // 
            this.panelPrefs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panelPrefs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrefs.Controls.Add(this.labelPrefDuration);
            this.panelPrefs.Controls.Add(this.comboBoxPrefDuration);
            this.panelPrefs.Controls.Add(this.labelPrefSound);
            this.panelPrefs.Controls.Add(this.comboBoxPrefSound);
            this.panelPrefs.Controls.Add(this.comboBoxPrefSticky);
            this.panelPrefs.Controls.Add(this.labelPrefPriority);
            this.panelPrefs.Controls.Add(this.comboBoxPrefPriority);
            this.panelPrefs.Controls.Add(this.labelPrefForward);
            this.panelPrefs.Controls.Add(this.comboBoxPrefForward);
            this.panelPrefs.Controls.Add(this.labelApplicationNotification);
            this.panelPrefs.Controls.Add(this.pictureBoxApplicationNotification);
            this.panelPrefs.Controls.Add(this.labelPrefSticky);
            this.panelPrefs.Controls.Add(this.comboBoxPrefDisplay);
            this.panelPrefs.Controls.Add(this.labelPrefDisplay);
            this.panelPrefs.Controls.Add(this.labelPrefEnabled);
            this.panelPrefs.Controls.Add(this.comboBoxPrefEnabled);
            this.panelPrefs.Location = new System.Drawing.Point(196, 57);
            this.panelPrefs.Name = "panelPrefs";
            this.panelPrefs.Size = new System.Drawing.Size(273, 234);
            this.panelPrefs.TabIndex = 6;
            // 
            // labelPrefDuration
            // 
            this.labelPrefDuration.AutoSize = true;
            this.labelPrefDuration.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrefDuration.Location = new System.Drawing.Point(14, 102);
            this.labelPrefDuration.Name = "labelPrefDuration";
            this.labelPrefDuration.Size = new System.Drawing.Size(63, 18);
            this.labelPrefDuration.TabIndex = 19;
            this.labelPrefDuration.Text = "Duration:";
            // 
            // comboBoxPrefDuration
            // 
            this.comboBoxPrefDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrefDuration.FormattingEnabled = true;
            this.comboBoxPrefDuration.Location = new System.Drawing.Point(106, 102);
            this.comboBoxPrefDuration.Name = "comboBoxPrefDuration";
            this.comboBoxPrefDuration.Size = new System.Drawing.Size(118, 21);
            this.comboBoxPrefDuration.TabIndex = 18;
            this.comboBoxPrefDuration.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPrefDuration_SelectionChangeCommitted);
            // 
            // labelPrefSound
            // 
            this.labelPrefSound.AutoSize = true;
            this.labelPrefSound.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.labelPrefSound.Location = new System.Drawing.Point(14, 202);
            this.labelPrefSound.Name = "labelPrefSound";
            this.labelPrefSound.Size = new System.Drawing.Size(48, 18);
            this.labelPrefSound.TabIndex = 17;
            this.labelPrefSound.Text = "Sound:";
            // 
            // comboBoxPrefSound
            // 
            this.comboBoxPrefSound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrefSound.FormattingEnabled = true;
            this.comboBoxPrefSound.Location = new System.Drawing.Point(106, 202);
            this.comboBoxPrefSound.Name = "comboBoxPrefSound";
            this.comboBoxPrefSound.Size = new System.Drawing.Size(160, 21);
            this.comboBoxPrefSound.TabIndex = 16;
            this.comboBoxPrefSound.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPrefSound_SelectionChangeCommitted);
            // 
            // comboBoxPrefSticky
            // 
            this.comboBoxPrefSticky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrefSticky.FormattingEnabled = true;
            this.comboBoxPrefSticky.Location = new System.Drawing.Point(106, 127);
            this.comboBoxPrefSticky.Name = "comboBoxPrefSticky";
            this.comboBoxPrefSticky.Size = new System.Drawing.Size(118, 21);
            this.comboBoxPrefSticky.TabIndex = 15;
            this.comboBoxPrefSticky.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPrefSticky_SelectionChangeCommitted);
            // 
            // labelPrefPriority
            // 
            this.labelPrefPriority.AutoSize = true;
            this.labelPrefPriority.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.labelPrefPriority.Location = new System.Drawing.Point(14, 177);
            this.labelPrefPriority.Name = "labelPrefPriority";
            this.labelPrefPriority.Size = new System.Drawing.Size(56, 18);
            this.labelPrefPriority.TabIndex = 14;
            this.labelPrefPriority.Text = "Priority:";
            // 
            // comboBoxPrefPriority
            // 
            this.comboBoxPrefPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrefPriority.FormattingEnabled = true;
            this.comboBoxPrefPriority.Location = new System.Drawing.Point(106, 177);
            this.comboBoxPrefPriority.Name = "comboBoxPrefPriority";
            this.comboBoxPrefPriority.Size = new System.Drawing.Size(118, 21);
            this.comboBoxPrefPriority.TabIndex = 13;
            this.comboBoxPrefPriority.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPrefPriority_SelectionChangeCommitted);
            // 
            // labelPrefForward
            // 
            this.labelPrefForward.AutoSize = true;
            this.labelPrefForward.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.labelPrefForward.Location = new System.Drawing.Point(14, 152);
            this.labelPrefForward.Name = "labelPrefForward";
            this.labelPrefForward.Size = new System.Drawing.Size(78, 18);
            this.labelPrefForward.TabIndex = 12;
            this.labelPrefForward.Text = "Forwarding:";
            // 
            // comboBoxPrefForward
            // 
            this.comboBoxPrefForward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrefForward.FormattingEnabled = true;
            this.comboBoxPrefForward.Location = new System.Drawing.Point(106, 152);
            this.comboBoxPrefForward.Name = "comboBoxPrefForward";
            this.comboBoxPrefForward.Size = new System.Drawing.Size(118, 21);
            this.comboBoxPrefForward.TabIndex = 11;
            this.comboBoxPrefForward.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPrefForward_SelectionChangeCommitted);
            // 
            // labelApplicationNotification
            // 
            this.labelApplicationNotification.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationNotification.Location = new System.Drawing.Point(58, 3);
            this.labelApplicationNotification.Name = "labelApplicationNotification";
            this.labelApplicationNotification.Size = new System.Drawing.Size(203, 48);
            this.labelApplicationNotification.TabIndex = 10;
            this.labelApplicationNotification.Text = "label1";
            this.labelApplicationNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelApplicationNotification.UseMnemonic = false;
            // 
            // pictureBoxApplicationNotification
            // 
            this.pictureBoxApplicationNotification.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxApplicationNotification.Name = "pictureBoxApplicationNotification";
            this.pictureBoxApplicationNotification.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxApplicationNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxApplicationNotification.TabIndex = 9;
            this.pictureBoxApplicationNotification.TabStop = false;
            // 
            // labelPrefSticky
            // 
            this.labelPrefSticky.AutoSize = true;
            this.labelPrefSticky.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrefSticky.Location = new System.Drawing.Point(14, 127);
            this.labelPrefSticky.Name = "labelPrefSticky";
            this.labelPrefSticky.Size = new System.Drawing.Size(48, 18);
            this.labelPrefSticky.TabIndex = 8;
            this.labelPrefSticky.Text = "Sticky:";
            // 
            // comboBoxPrefDisplay
            // 
            this.comboBoxPrefDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrefDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrefDisplay.FormattingEnabled = true;
            this.comboBoxPrefDisplay.Location = new System.Drawing.Point(106, 77);
            this.comboBoxPrefDisplay.Name = "comboBoxPrefDisplay";
            this.comboBoxPrefDisplay.Size = new System.Drawing.Size(160, 21);
            this.comboBoxPrefDisplay.TabIndex = 7;
            this.comboBoxPrefDisplay.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPrefDisplay_SelectionChangeCommitted);
            // 
            // labelPrefDisplay
            // 
            this.labelPrefDisplay.AutoSize = true;
            this.labelPrefDisplay.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrefDisplay.Location = new System.Drawing.Point(14, 77);
            this.labelPrefDisplay.Name = "labelPrefDisplay";
            this.labelPrefDisplay.Size = new System.Drawing.Size(54, 18);
            this.labelPrefDisplay.TabIndex = 6;
            this.labelPrefDisplay.Text = "Display:";
            // 
            // labelPrefEnabled
            // 
            this.labelPrefEnabled.AutoSize = true;
            this.labelPrefEnabled.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrefEnabled.Location = new System.Drawing.Point(14, 52);
            this.labelPrefEnabled.Name = "labelPrefEnabled";
            this.labelPrefEnabled.Size = new System.Drawing.Size(58, 18);
            this.labelPrefEnabled.TabIndex = 4;
            this.labelPrefEnabled.Text = "Enabled:";
            // 
            // comboBoxPrefEnabled
            // 
            this.comboBoxPrefEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrefEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrefEnabled.FormattingEnabled = true;
            this.comboBoxPrefEnabled.ItemHeight = 13;
            this.comboBoxPrefEnabled.Location = new System.Drawing.Point(106, 52);
            this.comboBoxPrefEnabled.Name = "comboBoxPrefEnabled";
            this.comboBoxPrefEnabled.Size = new System.Drawing.Size(69, 21);
            this.comboBoxPrefEnabled.TabIndex = 5;
            this.comboBoxPrefEnabled.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPrefEnabled_SelectionChangeCommitted);
            // 
            // pictureBoxApplication
            // 
            this.pictureBoxApplication.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxApplication.Location = new System.Drawing.Point(7, 0);
            this.pictureBoxApplication.Name = "pictureBoxApplication";
            this.pictureBoxApplication.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxApplication.TabIndex = 1;
            this.pictureBoxApplication.TabStop = false;
            // 
            // labelApplication
            // 
            this.labelApplication.BackColor = System.Drawing.Color.Transparent;
            this.labelApplication.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplication.Location = new System.Drawing.Point(61, 1);
            this.labelApplication.Name = "labelApplication";
            this.labelApplication.Size = new System.Drawing.Size(364, 47);
            this.labelApplication.TabIndex = 2;
            this.labelApplication.Text = "label1";
            this.labelApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelNoApps
            // 
            this.panelNoApps.Controls.Add(this.labelNoAppsDesc);
            this.panelNoApps.Controls.Add(this.labelNoApps);
            this.panelNoApps.Location = new System.Drawing.Point(186, 4);
            this.panelNoApps.Name = "panelNoApps";
            this.panelNoApps.Size = new System.Drawing.Size(474, 291);
            this.panelNoApps.TabIndex = 10;
            // 
            // labelNoAppsDesc
            // 
            this.labelNoAppsDesc.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoAppsDesc.Location = new System.Drawing.Point(14, 47);
            this.labelNoAppsDesc.Name = "labelNoAppsDesc";
            this.labelNoAppsDesc.Size = new System.Drawing.Size(444, 101);
            this.labelNoAppsDesc.TabIndex = 1;
            this.labelNoAppsDesc.Text = "When a Growl-enabled application registers to send notifications, it will appear " +
                "in the list to the left and you will be able to customize its settings.";
            // 
            // labelNoApps
            // 
            this.labelNoApps.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoApps.Location = new System.Drawing.Point(13, 15);
            this.labelNoApps.Name = "labelNoApps";
            this.labelNoApps.Size = new System.Drawing.Size(382, 23);
            this.labelNoApps.TabIndex = 0;
            this.labelNoApps.Text = "No Applications Have Registered Yet";
            // 
            // panelDisplays
            // 
            this.panelDisplays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDisplays.BackColor = System.Drawing.Color.Transparent;
            this.panelDisplays.Controls.Add(this.getDisplaysLabel);
            this.panelDisplays.Controls.Add(this.listControlDisplays);
            this.panelDisplays.Controls.Add(this.panelDisplaySettings);
            this.panelDisplays.Location = new System.Drawing.Point(0, 70);
            this.panelDisplays.Name = "panelDisplays";
            this.panelDisplays.Size = new System.Drawing.Size(663, 304);
            this.panelDisplays.TabIndex = 2;
            this.panelDisplays.Visible = false;
            // 
            // getDisplaysLabel
            // 
            this.getDisplaysLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getDisplaysLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.getDisplaysLabel.Location = new System.Drawing.Point(3, 277);
            this.getDisplaysLabel.Name = "getDisplaysLabel";
            this.getDisplaysLabel.Size = new System.Drawing.Size(177, 16);
            this.getDisplaysLabel.TabIndex = 7;
            this.getDisplaysLabel.TabStop = true;
            this.getDisplaysLabel.Tag = "http://www.growlforwindows.com/gfw/displays.aspx";
            this.getDisplaysLabel.Text = "Find & install additional displays";
            this.getDisplaysLabel.UseMnemonic = false;
            this.getDisplaysLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.getDisplaysLabel_LinkClicked);
            // 
            // listControlDisplays
            // 
            this.listControlDisplays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listControlDisplays.BackColor = System.Drawing.Color.White;
            this.listControlDisplays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listControlDisplays.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listControlDisplays.HeaderText = "Display Name";
            this.listControlDisplays.IsDefaultComparer = null;
            this.listControlDisplays.Location = new System.Drawing.Point(4, 4);
            this.listControlDisplays.Name = "listControlDisplays";
            this.listControlDisplays.SelectedIndex = -1;
            this.listControlDisplays.SelectedItem = null;
            this.listControlDisplays.Size = new System.Drawing.Size(176, 269);
            this.listControlDisplays.TabIndex = 2;
            this.listControlDisplays.DoubleClick += new System.EventHandler(this.listControlDisplays_DoubleClick);
            this.listControlDisplays.SelectedIndexChanged += new System.EventHandler(this.listControlDisplays_SelectedIndexChanged);
            // 
            // panelDisplaySettings
            // 
            this.panelDisplaySettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDisplaySettings.BackColor = System.Drawing.Color.Transparent;
            this.panelDisplaySettings.Controls.Add(this.pictureBoxMultipleMonitors);
            this.panelDisplaySettings.Controls.Add(this.buttonSetAsDefault);
            this.panelDisplaySettings.Controls.Add(this.displayStyleWebsiteLabel);
            this.panelDisplaySettings.Controls.Add(this.displayStyleVersionLabel);
            this.panelDisplaySettings.Controls.Add(this.displayStyleAuthorLabel);
            this.panelDisplaySettings.Controls.Add(this.buttonPreviewDisplay);
            this.panelDisplaySettings.Controls.Add(this.displayStyleDescriptionLabel);
            this.panelDisplaySettings.Controls.Add(this.displayStyleNameLabel);
            this.panelDisplaySettings.Controls.Add(this.panelDisplaySettingsContainer);
            this.panelDisplaySettings.Location = new System.Drawing.Point(186, 5);
            this.panelDisplaySettings.Name = "panelDisplaySettings";
            this.panelDisplaySettings.Size = new System.Drawing.Size(470, 291);
            this.panelDisplaySettings.TabIndex = 1;
            this.panelDisplaySettings.Visible = false;
            // 
            // pictureBoxMultipleMonitors
            // 
            this.pictureBoxMultipleMonitors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMultipleMonitors.Image = global::Growl.Properties.Resources.multiplemonitors;
            this.pictureBoxMultipleMonitors.Location = new System.Drawing.Point(432, 46);
            this.pictureBoxMultipleMonitors.Name = "pictureBoxMultipleMonitors";
            this.pictureBoxMultipleMonitors.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxMultipleMonitors.TabIndex = 7;
            this.pictureBoxMultipleMonitors.TabStop = false;
            this.pictureBoxMultipleMonitors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMultipleMonitors_MouseDown);
            // 
            // buttonSetAsDefault
            // 
            this.buttonSetAsDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetAsDefault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSetAsDefault.BackgroundImage")));
            this.buttonSetAsDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSetAsDefault.FlatAppearance.BorderSize = 0;
            this.buttonSetAsDefault.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSetAsDefault.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSetAsDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetAsDefault.Font = new System.Drawing.Font("Trebuchet MS", 10.25F, System.Drawing.FontStyle.Bold);
            this.buttonSetAsDefault.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSetAsDefault.Location = new System.Drawing.Point(279, 256);
            this.buttonSetAsDefault.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSetAsDefault.Name = "buttonSetAsDefault";
            this.buttonSetAsDefault.Size = new System.Drawing.Size(106, 32);
            this.buttonSetAsDefault.TabIndex = 3;
            this.buttonSetAsDefault.Text = "Set as Default";
            this.buttonSetAsDefault.UseVisualStyleBackColor = true;
            this.buttonSetAsDefault.Click += new System.EventHandler(this.buttonSetAsDefault_Click);
            // 
            // displayStyleWebsiteLabel
            // 
            this.displayStyleWebsiteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.displayStyleWebsiteLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.displayStyleWebsiteLabel.Location = new System.Drawing.Point(12, 272);
            this.displayStyleWebsiteLabel.Name = "displayStyleWebsiteLabel";
            this.displayStyleWebsiteLabel.Size = new System.Drawing.Size(253, 16);
            this.displayStyleWebsiteLabel.TabIndex = 6;
            this.displayStyleWebsiteLabel.TabStop = true;
            this.displayStyleWebsiteLabel.Text = "[website]";
            this.displayStyleWebsiteLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.displayStyleWebsiteLabel_LinkClicked);
            // 
            // displayStyleVersionLabel
            // 
            this.displayStyleVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.displayStyleVersionLabel.Font = new System.Drawing.Font("Trebuchet MS", 7.25F);
            this.displayStyleVersionLabel.Location = new System.Drawing.Point(357, 3);
            this.displayStyleVersionLabel.Name = "displayStyleVersionLabel";
            this.displayStyleVersionLabel.Size = new System.Drawing.Size(112, 16);
            this.displayStyleVersionLabel.TabIndex = 5;
            this.displayStyleVersionLabel.Text = "[version]";
            this.displayStyleVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // displayStyleAuthorLabel
            // 
            this.displayStyleAuthorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.displayStyleAuthorLabel.AutoSize = true;
            this.displayStyleAuthorLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayStyleAuthorLabel.Location = new System.Drawing.Point(12, 257);
            this.displayStyleAuthorLabel.Name = "displayStyleAuthorLabel";
            this.displayStyleAuthorLabel.Size = new System.Drawing.Size(50, 16);
            this.displayStyleAuthorLabel.TabIndex = 4;
            this.displayStyleAuthorLabel.Text = "[author]";
            // 
            // buttonPreviewDisplay
            // 
            this.buttonPreviewDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreviewDisplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPreviewDisplay.BackgroundImage")));
            this.buttonPreviewDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPreviewDisplay.FlatAppearance.BorderSize = 0;
            this.buttonPreviewDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPreviewDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPreviewDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviewDisplay.Font = new System.Drawing.Font("Trebuchet MS", 10.25F, System.Drawing.FontStyle.Bold);
            this.buttonPreviewDisplay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPreviewDisplay.Location = new System.Drawing.Point(391, 256);
            this.buttonPreviewDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPreviewDisplay.Name = "buttonPreviewDisplay";
            this.buttonPreviewDisplay.Size = new System.Drawing.Size(73, 32);
            this.buttonPreviewDisplay.TabIndex = 3;
            this.buttonPreviewDisplay.Text = "Preview";
            this.buttonPreviewDisplay.UseVisualStyleBackColor = true;
            this.buttonPreviewDisplay.Click += new System.EventHandler(this.buttonPreviewDisplay_Click);
            // 
            // displayStyleDescriptionLabel
            // 
            this.displayStyleDescriptionLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayStyleDescriptionLabel.Location = new System.Drawing.Point(12, 34);
            this.displayStyleDescriptionLabel.Name = "displayStyleDescriptionLabel";
            this.displayStyleDescriptionLabel.Size = new System.Drawing.Size(414, 37);
            this.displayStyleDescriptionLabel.TabIndex = 2;
            this.displayStyleDescriptionLabel.Text = "[description]";
            // 
            // displayStyleNameLabel
            // 
            this.displayStyleNameLabel.AutoSize = true;
            this.displayStyleNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayStyleNameLabel.Location = new System.Drawing.Point(9, 4);
            this.displayStyleNameLabel.Name = "displayStyleNameLabel";
            this.displayStyleNameLabel.Size = new System.Drawing.Size(149, 27);
            this.displayStyleNameLabel.TabIndex = 1;
            this.displayStyleNameLabel.Text = "[display name]";
            // 
            // panelDisplaySettingsContainer
            // 
            this.panelDisplaySettingsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDisplaySettingsContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDisplaySettingsContainer.Location = new System.Drawing.Point(14, 80);
            this.panelDisplaySettingsContainer.Name = "panelDisplaySettingsContainer";
            this.panelDisplaySettingsContainer.Size = new System.Drawing.Size(450, 173);
            this.panelDisplaySettingsContainer.TabIndex = 0;
            // 
            // panelAbout
            // 
            this.panelAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAbout.BackColor = System.Drawing.Color.Transparent;
            this.panelAbout.Controls.Add(this.labelAboutBuildNumber);
            this.panelAbout.Controls.Add(this.labelAboutUsLink);
            this.panelAbout.Controls.Add(this.labelAboutUs);
            this.panelAbout.Controls.Add(this.labelAboutIconsLink);
            this.panelAbout.Controls.Add(this.labelAboutIcons2);
            this.panelAbout.Controls.Add(this.labelAboutIcons);
            this.panelAbout.Controls.Add(this.labelAboutOriginalLink);
            this.panelAbout.Controls.Add(this.labelAboutOriginal2);
            this.panelAbout.Controls.Add(this.labelAboutOriginal);
            this.panelAbout.Controls.Add(this.pictureBox1);
            this.panelAbout.Controls.Add(this.labelAboutGrowlVersion);
            this.panelAbout.Location = new System.Drawing.Point(0, 70);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(663, 304);
            this.panelAbout.TabIndex = 4;
            this.panelAbout.Visible = false;
            // 
            // labelAboutBuildNumber
            // 
            this.labelAboutBuildNumber.AutoSize = true;
            this.labelAboutBuildNumber.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutBuildNumber.Location = new System.Drawing.Point(138, 44);
            this.labelAboutBuildNumber.Name = "labelAboutBuildNumber";
            this.labelAboutBuildNumber.Size = new System.Drawing.Size(60, 16);
            this.labelAboutBuildNumber.TabIndex = 10;
            this.labelAboutBuildNumber.Text = "(build: {0})";
            // 
            // labelAboutUsLink
            // 
            this.labelAboutUsLink.AutoSize = true;
            this.labelAboutUsLink.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutUsLink.Location = new System.Drawing.Point(39, 91);
            this.labelAboutUsLink.Name = "labelAboutUsLink";
            this.labelAboutUsLink.Size = new System.Drawing.Size(182, 16);
            this.labelAboutUsLink.TabIndex = 9;
            this.labelAboutUsLink.TabStop = true;
            this.labelAboutUsLink.Text = "http://www.growlforwindows.com";
            this.labelAboutUsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelAboutUsLink_LinkClicked);
            // 
            // labelAboutUs
            // 
            this.labelAboutUs.AutoSize = true;
            this.labelAboutUs.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutUs.Location = new System.Drawing.Point(39, 76);
            this.labelAboutUs.Name = "labelAboutUs";
            this.labelAboutUs.Size = new System.Drawing.Size(218, 16);
            this.labelAboutUs.TabIndex = 8;
            this.labelAboutUs.Text = "Find displays, extensions, and updates at:";
            // 
            // labelAboutIconsLink
            // 
            this.labelAboutIconsLink.AutoSize = true;
            this.labelAboutIconsLink.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutIconsLink.Location = new System.Drawing.Point(151, 192);
            this.labelAboutIconsLink.Name = "labelAboutIconsLink";
            this.labelAboutIconsLink.Size = new System.Drawing.Size(138, 16);
            this.labelAboutIconsLink.TabIndex = 7;
            this.labelAboutIconsLink.TabStop = true;
            this.labelAboutIconsLink.Text = "http://www.vistaico.com";
            this.labelAboutIconsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelAboutIconsLink_LinkClicked);
            // 
            // labelAboutIcons2
            // 
            this.labelAboutIcons2.AutoSize = true;
            this.labelAboutIcons2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutIcons2.Location = new System.Drawing.Point(39, 191);
            this.labelAboutIcons2.Name = "labelAboutIcons2";
            this.labelAboutIcons2.Size = new System.Drawing.Size(116, 16);
            this.labelAboutIcons2.TabIndex = 6;
            this.labelAboutIcons2.Text = "VistaICO Aero Pack - ";
            // 
            // labelAboutIcons
            // 
            this.labelAboutIcons.AutoSize = true;
            this.labelAboutIcons.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutIcons.Location = new System.Drawing.Point(39, 175);
            this.labelAboutIcons.Name = "labelAboutIcons";
            this.labelAboutIcons.Size = new System.Drawing.Size(39, 16);
            this.labelAboutIcons.TabIndex = 5;
            this.labelAboutIcons.Text = "Icons:";
            // 
            // labelAboutOriginalLink
            // 
            this.labelAboutOriginalLink.AutoSize = true;
            this.labelAboutOriginalLink.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutOriginalLink.Location = new System.Drawing.Point(121, 152);
            this.labelAboutOriginalLink.Name = "labelAboutOriginalLink";
            this.labelAboutOriginalLink.Size = new System.Drawing.Size(96, 16);
            this.labelAboutOriginalLink.TabIndex = 4;
            this.labelAboutOriginalLink.TabStop = true;
            this.labelAboutOriginalLink.Text = "http://growl.info";
            this.labelAboutOriginalLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelAboutOriginalLink_LinkClicked);
            // 
            // labelAboutOriginal2
            // 
            this.labelAboutOriginal2.AutoSize = true;
            this.labelAboutOriginal2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutOriginal2.Location = new System.Drawing.Point(39, 152);
            this.labelAboutOriginal2.Name = "labelAboutOriginal2";
            this.labelAboutOriginal2.Size = new System.Drawing.Size(87, 16);
            this.labelAboutOriginal2.TabIndex = 3;
            this.labelAboutOriginal2.Text = "Growl for OSX - ";
            // 
            // labelAboutOriginal
            // 
            this.labelAboutOriginal.AutoSize = true;
            this.labelAboutOriginal.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutOriginal.Location = new System.Drawing.Point(39, 136);
            this.labelAboutOriginal.Name = "labelAboutOriginal";
            this.labelAboutOriginal.Size = new System.Drawing.Size(184, 16);
            this.labelAboutOriginal.TabIndex = 2;
            this.labelAboutOriginal.Text = "Original idea, inspiration, and logo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Growl.FormResources.growl_big;
            this.pictureBox1.Location = new System.Drawing.Point(407, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelAboutGrowlVersion
            // 
            this.labelAboutGrowlVersion.AutoSize = true;
            this.labelAboutGrowlVersion.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutGrowlVersion.Location = new System.Drawing.Point(20, 35);
            this.labelAboutGrowlVersion.Name = "labelAboutGrowlVersion";
            this.labelAboutGrowlVersion.Size = new System.Drawing.Size(112, 27);
            this.labelAboutGrowlVersion.TabIndex = 0;
            this.labelAboutGrowlVersion.Text = "Growl v{0}";
            // 
            // panelSecurity
            // 
            this.panelSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSecurity.BackColor = System.Drawing.Color.Transparent;
            this.panelSecurity.Controls.Add(this.checkBoxRequireLANPassword);
            this.panelSecurity.Controls.Add(this.labelPasswordManager);
            this.panelSecurity.Controls.Add(this.passwordManagerControl1);
            this.panelSecurity.Controls.Add(this.checkBoxAllowSubscriptions);
            this.panelSecurity.Controls.Add(this.checkBoxAllowWebNotifications);
            this.panelSecurity.Controls.Add(this.checkBoxAllowNetworkNotifications);
            this.panelSecurity.Controls.Add(this.checkBoxRequireLocalPassword);
            this.panelSecurity.Location = new System.Drawing.Point(0, 70);
            this.panelSecurity.Name = "panelSecurity";
            this.panelSecurity.Size = new System.Drawing.Size(663, 304);
            this.panelSecurity.TabIndex = 4;
            this.panelSecurity.Visible = false;
            // 
            // checkBoxRequireLANPassword
            // 
            this.checkBoxRequireLANPassword.AutoSize = true;
            this.checkBoxRequireLANPassword.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.checkBoxRequireLANPassword.Location = new System.Drawing.Point(83, 60);
            this.checkBoxRequireLANPassword.Name = "checkBoxRequireLANPassword";
            this.checkBoxRequireLANPassword.Size = new System.Drawing.Size(209, 22);
            this.checkBoxRequireLANPassword.TabIndex = 11;
            this.checkBoxRequireLANPassword.Text = "Require password for LAN apps";
            this.checkBoxRequireLANPassword.UseVisualStyleBackColor = true;
            this.checkBoxRequireLANPassword.CheckedChanged += new System.EventHandler(this.checkBoxRequireLANPassword_CheckedChanged);
            // 
            // labelPasswordManager
            // 
            this.labelPasswordManager.AutoSize = true;
            this.labelPasswordManager.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.labelPasswordManager.Location = new System.Drawing.Point(397, 14);
            this.labelPasswordManager.Name = "labelPasswordManager";
            this.labelPasswordManager.Size = new System.Drawing.Size(116, 18);
            this.labelPasswordManager.TabIndex = 16;
            this.labelPasswordManager.Text = "Password Manager";
            // 
            // passwordManagerControl1
            // 
            this.passwordManagerControl1.BackColor = System.Drawing.Color.Transparent;
            this.passwordManagerControl1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordManagerControl1.Location = new System.Drawing.Point(399, 38);
            this.passwordManagerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordManagerControl1.Name = "passwordManagerControl1";
            this.passwordManagerControl1.Size = new System.Drawing.Size(199, 244);
            this.passwordManagerControl1.TabIndex = 15;
            // 
            // checkBoxAllowSubscriptions
            // 
            this.checkBoxAllowSubscriptions.AutoSize = true;
            this.checkBoxAllowSubscriptions.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowSubscriptions.Location = new System.Drawing.Point(83, 192);
            this.checkBoxAllowSubscriptions.MaximumSize = new System.Drawing.Size(293, 44);
            this.checkBoxAllowSubscriptions.Name = "checkBoxAllowSubscriptions";
            this.checkBoxAllowSubscriptions.Size = new System.Drawing.Size(268, 22);
            this.checkBoxAllowSubscriptions.TabIndex = 14;
            this.checkBoxAllowSubscriptions.Text = "Allow clients to subscribe to notifications";
            this.checkBoxAllowSubscriptions.UseVisualStyleBackColor = true;
            this.checkBoxAllowSubscriptions.CheckedChanged += new System.EventHandler(this.checkBoxAllowSubscriptions_CheckedChanged);
            // 
            // checkBoxAllowWebNotifications
            // 
            this.checkBoxAllowWebNotifications.AutoSize = true;
            this.checkBoxAllowWebNotifications.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowWebNotifications.Location = new System.Drawing.Point(83, 126);
            this.checkBoxAllowWebNotifications.Name = "checkBoxAllowWebNotifications";
            this.checkBoxAllowWebNotifications.Size = new System.Drawing.Size(222, 22);
            this.checkBoxAllowWebNotifications.TabIndex = 13;
            this.checkBoxAllowWebNotifications.Text = "Allow notifications from websites";
            this.checkBoxAllowWebNotifications.UseVisualStyleBackColor = true;
            this.checkBoxAllowWebNotifications.CheckedChanged += new System.EventHandler(this.checkBoxAllowWebNotifications_CheckedChanged);
            // 
            // checkBoxAllowNetworkNotifications
            // 
            this.checkBoxAllowNetworkNotifications.AutoSize = true;
            this.checkBoxAllowNetworkNotifications.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowNetworkNotifications.Location = new System.Drawing.Point(83, 104);
            this.checkBoxAllowNetworkNotifications.Name = "checkBoxAllowNetworkNotifications";
            this.checkBoxAllowNetworkNotifications.Size = new System.Drawing.Size(186, 22);
            this.checkBoxAllowNetworkNotifications.TabIndex = 11;
            this.checkBoxAllowNetworkNotifications.Text = "Allow network notifications";
            this.checkBoxAllowNetworkNotifications.UseVisualStyleBackColor = true;
            this.checkBoxAllowNetworkNotifications.CheckedChanged += new System.EventHandler(this.checkBoxAllowNetworkNotifications_CheckedChanged);
            // 
            // checkBoxRequireLocalPassword
            // 
            this.checkBoxRequireLocalPassword.AutoSize = true;
            this.checkBoxRequireLocalPassword.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRequireLocalPassword.Location = new System.Drawing.Point(83, 38);
            this.checkBoxRequireLocalPassword.Name = "checkBoxRequireLocalPassword";
            this.checkBoxRequireLocalPassword.Size = new System.Drawing.Size(212, 22);
            this.checkBoxRequireLocalPassword.TabIndex = 10;
            this.checkBoxRequireLocalPassword.Text = "Require password for local apps";
            this.checkBoxRequireLocalPassword.UseVisualStyleBackColor = true;
            this.checkBoxRequireLocalPassword.CheckedChanged += new System.EventHandler(this.checkBoxRequireLocalPassword_CheckedChanged);
            // 
            // panelHistory
            // 
            this.panelHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHistory.BackColor = System.Drawing.Color.Transparent;
            this.panelHistory.Controls.Add(this.historyFilterGroupBox);
            this.panelHistory.Controls.Add(this.buttonClearHistory);
            this.panelHistory.Controls.Add(this.historyDaysGroupBox);
            this.panelHistory.Controls.Add(this.historySortByGroupBox);
            this.panelHistory.Controls.Add(this.historyListView);
            this.panelHistory.Controls.Add(this.panelHistoryListViewBacker);
            this.panelHistory.Location = new System.Drawing.Point(0, 70);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(663, 304);
            this.panelHistory.TabIndex = 3;
            this.panelHistory.Visible = false;
            // 
            // historyFilterGroupBox
            // 
            this.historyFilterGroupBox.Controls.Add(this.historyFilterTextBox);
            this.historyFilterGroupBox.Location = new System.Drawing.Point(10, 9);
            this.historyFilterGroupBox.Name = "historyFilterGroupBox";
            this.historyFilterGroupBox.Size = new System.Drawing.Size(175, 66);
            this.historyFilterGroupBox.TabIndex = 8;
            this.historyFilterGroupBox.TabStop = false;
            this.historyFilterGroupBox.Text = "Filter";
            // 
            // historyFilterTextBox
            // 
            this.historyFilterTextBox.Location = new System.Drawing.Point(15, 25);
            this.historyFilterTextBox.Name = "historyFilterTextBox";
            this.historyFilterTextBox.Size = new System.Drawing.Size(150, 20);
            this.historyFilterTextBox.TabIndex = 0;
            this.historyFilterTextBox.TextChanged += new System.EventHandler(this.historyFilterTextBox_TextChanged);
            // 
            // buttonClearHistory
            // 
            this.buttonClearHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClearHistory.BackgroundImage")));
            this.buttonClearHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClearHistory.FlatAppearance.BorderSize = 0;
            this.buttonClearHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClearHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearHistory.Font = new System.Drawing.Font("Trebuchet MS", 10.25F, System.Drawing.FontStyle.Bold);
            this.buttonClearHistory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClearHistory.Location = new System.Drawing.Point(112, 256);
            this.buttonClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(73, 32);
            this.buttonClearHistory.TabIndex = 3;
            this.buttonClearHistory.Text = "Clear";
            this.buttonClearHistory.UseVisualStyleBackColor = true;
            this.buttonClearHistory.Click += new System.EventHandler(this.buttonClearHistory_Click);
            // 
            // historyDaysGroupBox
            // 
            this.historyDaysGroupBox.Controls.Add(this.historyDaysTrackBar);
            this.historyDaysGroupBox.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.historyDaysGroupBox.Location = new System.Drawing.Point(10, 163);
            this.historyDaysGroupBox.Name = "historyDaysGroupBox";
            this.historyDaysGroupBox.Size = new System.Drawing.Size(175, 66);
            this.historyDaysGroupBox.TabIndex = 7;
            this.historyDaysGroupBox.TabStop = false;
            this.historyDaysGroupBox.Text = "Number of Days";
            // 
            // historyDaysTrackBar
            // 
            this.historyDaysTrackBar.LargeChange = 1;
            this.historyDaysTrackBar.Location = new System.Drawing.Point(1, 18);
            this.historyDaysTrackBar.Maximum = 7;
            this.historyDaysTrackBar.Name = "historyDaysTrackBar";
            this.historyDaysTrackBar.Size = new System.Drawing.Size(172, 45);
            this.historyDaysTrackBar.TabIndex = 6;
            this.historyDaysTrackBar.Scroll += new System.EventHandler(this.historyDaysTrackBar_Scroll);
            // 
            // historySortByGroupBox
            // 
            this.historySortByGroupBox.Controls.Add(this.historySortByDateRadioButton);
            this.historySortByGroupBox.Controls.Add(this.historySortByApplicationRadioButton);
            this.historySortByGroupBox.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.historySortByGroupBox.Location = new System.Drawing.Point(10, 86);
            this.historySortByGroupBox.Name = "historySortByGroupBox";
            this.historySortByGroupBox.Size = new System.Drawing.Size(175, 66);
            this.historySortByGroupBox.TabIndex = 5;
            this.historySortByGroupBox.TabStop = false;
            this.historySortByGroupBox.Text = "Group By";
            // 
            // historySortByDateRadioButton
            // 
            this.historySortByDateRadioButton.AutoSize = true;
            this.historySortByDateRadioButton.Location = new System.Drawing.Point(17, 19);
            this.historySortByDateRadioButton.Name = "historySortByDateRadioButton";
            this.historySortByDateRadioButton.Size = new System.Drawing.Size(50, 20);
            this.historySortByDateRadioButton.TabIndex = 3;
            this.historySortByDateRadioButton.TabStop = true;
            this.historySortByDateRadioButton.Text = "Date";
            this.historySortByDateRadioButton.UseVisualStyleBackColor = true;
            this.historySortByDateRadioButton.CheckedChanged += new System.EventHandler(this.historySortByDateRadioButton_CheckedChanged);
            // 
            // historySortByApplicationRadioButton
            // 
            this.historySortByApplicationRadioButton.AutoSize = true;
            this.historySortByApplicationRadioButton.Location = new System.Drawing.Point(17, 42);
            this.historySortByApplicationRadioButton.Name = "historySortByApplicationRadioButton";
            this.historySortByApplicationRadioButton.Size = new System.Drawing.Size(81, 20);
            this.historySortByApplicationRadioButton.TabIndex = 4;
            this.historySortByApplicationRadioButton.Text = "Application";
            this.historySortByApplicationRadioButton.UseVisualStyleBackColor = true;
            this.historySortByApplicationRadioButton.CheckedChanged += new System.EventHandler(this.historySortByApplicationRadioButton_CheckedChanged);
            // 
            // historyListView
            // 
            this.historyListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.historyListView.BackColor = System.Drawing.Color.White;
            this.historyListView.Filter = null;
            this.historyListView.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.historyListView.FullRowSelect = true;
            this.historyListView.GroupBy = Growl.UI.HistoryGroupItemsBy.Date;
            this.historyListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.historyListView.LabelWrap = false;
            this.historyListView.Location = new System.Drawing.Point(196, 5);
            this.historyListView.MultiSelect = false;
            this.historyListView.Name = "historyListView";
            this.historyListView.NumberOfDays = 7;
            this.historyListView.OwnerDraw = true;
            this.historyListView.PastNotifications = null;
            this.historyListView.ShowItemToolTips = true;
            this.historyListView.Size = new System.Drawing.Size(460, 289);
            this.historyListView.TabIndex = 2;
            this.historyListView.TileSize = new System.Drawing.Size(205, 56);
            this.historyListView.UseCompatibleStateImageBehavior = false;
            this.historyListView.UseCustomToolTips = false;
            this.historyListView.View = System.Windows.Forms.View.Tile;
            // 
            // panelHistoryListViewBacker
            // 
            this.panelHistoryListViewBacker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHistoryListViewBacker.BackColor = System.Drawing.Color.White;
            this.panelHistoryListViewBacker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHistoryListViewBacker.Location = new System.Drawing.Point(196, 5);
            this.panelHistoryListViewBacker.Name = "panelHistoryListViewBacker";
            this.panelHistoryListViewBacker.Size = new System.Drawing.Size(460, 289);
            this.panelHistoryListViewBacker.TabIndex = 9;
            // 
            // panelInitializing
            // 
            this.panelInitializing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInitializing.Controls.Add(this.labelInitializationStage);
            this.panelInitializing.Controls.Add(this.progressBarInitializing);
            this.panelInitializing.Controls.Add(this.labelInitializing);
            this.panelInitializing.Location = new System.Drawing.Point(0, 70);
            this.panelInitializing.Name = "panelInitializing";
            this.panelInitializing.Size = new System.Drawing.Size(663, 304);
            this.panelInitializing.TabIndex = 2;
            // 
            // labelInitializationStage
            // 
            this.labelInitializationStage.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInitializationStage.Location = new System.Drawing.Point(166, 125);
            this.labelInitializationStage.Name = "labelInitializationStage";
            this.labelInitializationStage.Size = new System.Drawing.Size(331, 18);
            this.labelInitializationStage.TabIndex = 2;
            this.labelInitializationStage.Text = "Initializing...";
            // 
            // progressBarInitializing
            // 
            this.progressBarInitializing.ForeColor = System.Drawing.Color.Green;
            this.progressBarInitializing.Location = new System.Drawing.Point(169, 99);
            this.progressBarInitializing.Name = "progressBarInitializing";
            this.progressBarInitializing.Size = new System.Drawing.Size(328, 23);
            this.progressBarInitializing.TabIndex = 1;
            // 
            // labelInitializing
            // 
            this.labelInitializing.AutoSize = true;
            this.labelInitializing.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInitializing.Location = new System.Drawing.Point(165, 61);
            this.labelInitializing.Name = "labelInitializing";
            this.labelInitializing.Size = new System.Drawing.Size(195, 24);
            this.labelInitializing.TabIndex = 0;
            this.labelInitializing.Text = "Growl is initializing...";
            // 
            // panelNetwork
            // 
            this.panelNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNetwork.BackColor = System.Drawing.Color.Transparent;
            this.panelNetwork.Controls.Add(this.checkBoxEnableSubscriptions);
            this.panelNetwork.Controls.Add(this.buttonUnsubscribe);
            this.panelNetwork.Controls.Add(this.buttonSubscribe);
            this.panelNetwork.Controls.Add(this.subscribedListView);
            this.panelNetwork.Controls.Add(this.buttonRemoveComputer);
            this.panelNetwork.Controls.Add(this.buttonAddComputer);
            this.panelNetwork.Controls.Add(this.forwardListView);
            this.panelNetwork.Controls.Add(this.checkBoxEnableForwarding);
            this.panelNetwork.Location = new System.Drawing.Point(0, 70);
            this.panelNetwork.Name = "panelNetwork";
            this.panelNetwork.Size = new System.Drawing.Size(663, 304);
            this.panelNetwork.TabIndex = 3;
            this.panelNetwork.Visible = false;
            // 
            // checkBoxEnableSubscriptions
            // 
            this.checkBoxEnableSubscriptions.AutoSize = true;
            this.checkBoxEnableSubscriptions.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEnableSubscriptions.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableSubscriptions.Location = new System.Drawing.Point(339, 10);
            this.checkBoxEnableSubscriptions.Name = "checkBoxEnableSubscriptions";
            this.checkBoxEnableSubscriptions.Size = new System.Drawing.Size(309, 22);
            this.checkBoxEnableSubscriptions.TabIndex = 11;
            this.checkBoxEnableSubscriptions.Text = "Subscribe to notifications from other computers";
            this.checkBoxEnableSubscriptions.UseVisualStyleBackColor = false;
            this.checkBoxEnableSubscriptions.CheckedChanged += new System.EventHandler(this.checkBoxEnableSubscriptions_CheckedChanged);
            // 
            // buttonUnsubscribe
            // 
            this.buttonUnsubscribe.DisabledImage = global::Growl.FormResources.button_remove_dim;
            this.buttonUnsubscribe.Enabled = false;
            this.buttonUnsubscribe.Image = global::Growl.FormResources.button_remove;
            this.buttonUnsubscribe.Location = new System.Drawing.Point(379, 225);
            this.buttonUnsubscribe.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUnsubscribe.Name = "buttonUnsubscribe";
            this.buttonUnsubscribe.Size = new System.Drawing.Size(32, 32);
            this.buttonUnsubscribe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonUnsubscribe.TabIndex = 10;
            this.buttonUnsubscribe.TabStop = false;
            this.buttonUnsubscribe.Click += new System.EventHandler(this.buttonUnsubscribe_Click);
            // 
            // buttonSubscribe
            // 
            this.buttonSubscribe.DisabledImage = global::Growl.FormResources.button_add_dim;
            this.buttonSubscribe.Image = global::Growl.FormResources.button_add;
            this.buttonSubscribe.Location = new System.Drawing.Point(343, 225);
            this.buttonSubscribe.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSubscribe.Name = "buttonSubscribe";
            this.buttonSubscribe.Size = new System.Drawing.Size(32, 32);
            this.buttonSubscribe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSubscribe.TabIndex = 9;
            this.buttonSubscribe.TabStop = false;
            this.buttonSubscribe.Click += new System.EventHandler(this.buttonSubscribe_Click);
            // 
            // subscribedListView
            // 
            this.subscribedListView.AllDisabled = true;
            this.subscribedListView.Computers = null;
            this.subscribedListView.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.subscribedListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.subscribedListView.LabelWrap = false;
            this.subscribedListView.Location = new System.Drawing.Point(339, 38);
            this.subscribedListView.MultiSelect = false;
            this.subscribedListView.Name = "subscribedListView";
            this.subscribedListView.OwnerDraw = true;
            this.subscribedListView.ShowItemToolTips = true;
            this.subscribedListView.Size = new System.Drawing.Size(307, 184);
            this.subscribedListView.TabIndex = 8;
            this.subscribedListView.TileSize = new System.Drawing.Size(281, 56);
            this.subscribedListView.UseCompatibleStateImageBehavior = false;
            this.subscribedListView.View = System.Windows.Forms.View.Tile;
            this.subscribedListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.subscribedListView_MouseDown);
            this.subscribedListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.subscribedListView_ItemSelectionChanged);
            // 
            // buttonRemoveComputer
            // 
            this.buttonRemoveComputer.DisabledImage = global::Growl.FormResources.button_remove_dim;
            this.buttonRemoveComputer.Enabled = false;
            this.buttonRemoveComputer.Image = global::Growl.FormResources.button_remove;
            this.buttonRemoveComputer.Location = new System.Drawing.Point(59, 225);
            this.buttonRemoveComputer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemoveComputer.Name = "buttonRemoveComputer";
            this.buttonRemoveComputer.Size = new System.Drawing.Size(32, 32);
            this.buttonRemoveComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonRemoveComputer.TabIndex = 3;
            this.buttonRemoveComputer.TabStop = false;
            this.buttonRemoveComputer.Click += new System.EventHandler(this.buttonRemoveComputer_Click);
            // 
            // buttonAddComputer
            // 
            this.buttonAddComputer.DisabledImage = global::Growl.FormResources.button_add_dim;
            this.buttonAddComputer.Image = global::Growl.FormResources.button_add;
            this.buttonAddComputer.Location = new System.Drawing.Point(23, 225);
            this.buttonAddComputer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddComputer.Name = "buttonAddComputer";
            this.buttonAddComputer.Size = new System.Drawing.Size(32, 32);
            this.buttonAddComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonAddComputer.TabIndex = 2;
            this.buttonAddComputer.TabStop = false;
            this.buttonAddComputer.Click += new System.EventHandler(this.buttonAddComputer_Click);
            // 
            // forwardListView
            // 
            this.forwardListView.AllDisabled = true;
            this.forwardListView.Computers = null;
            this.forwardListView.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.forwardListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.forwardListView.LabelWrap = false;
            this.forwardListView.Location = new System.Drawing.Point(16, 38);
            this.forwardListView.MultiSelect = false;
            this.forwardListView.Name = "forwardListView";
            this.forwardListView.OwnerDraw = true;
            this.forwardListView.ShowItemToolTips = true;
            this.forwardListView.Size = new System.Drawing.Size(307, 184);
            this.forwardListView.TabIndex = 1;
            this.forwardListView.TileSize = new System.Drawing.Size(281, 56);
            this.forwardListView.UseCompatibleStateImageBehavior = false;
            this.forwardListView.View = System.Windows.Forms.View.Tile;
            this.forwardListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forwardListView_MouseDown);
            this.forwardListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.forwardListView_ItemSelectionChanged);
            // 
            // checkBoxEnableForwarding
            // 
            this.checkBoxEnableForwarding.AutoSize = true;
            this.checkBoxEnableForwarding.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEnableForwarding.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableForwarding.Location = new System.Drawing.Point(16, 10);
            this.checkBoxEnableForwarding.Name = "checkBoxEnableForwarding";
            this.checkBoxEnableForwarding.Size = new System.Drawing.Size(268, 22);
            this.checkBoxEnableForwarding.TabIndex = 0;
            this.checkBoxEnableForwarding.Text = "Forward notifications to other computers";
            this.checkBoxEnableForwarding.UseVisualStyleBackColor = false;
            this.checkBoxEnableForwarding.CheckedChanged += new System.EventHandler(this.checkBoxEnableForwarding_CheckedChanged);
            // 
            // contextMenuStripApplications
            // 
            this.contextMenuStripApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeApplicationToolStripMenuItem});
            this.contextMenuStripApplications.Name = "contextMenuStripApplications";
            this.contextMenuStripApplications.ShowImageMargin = false;
            this.contextMenuStripApplications.Size = new System.Drawing.Size(157, 26);
            this.contextMenuStripApplications.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStripApplications_Closed);
            // 
            // removeApplicationToolStripMenuItem
            // 
            this.removeApplicationToolStripMenuItem.Name = "removeApplicationToolStripMenuItem";
            this.removeApplicationToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.removeApplicationToolStripMenuItem.Text = "Remove Application";
            this.removeApplicationToolStripMenuItem.Click += new System.EventHandler(this.removeApplicationToolStripMenuItem_Click);
            // 
            // contextMenuStripForwardDestinations
            // 
            this.contextMenuStripForwardDestinations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeComputerToolStripMenuItem});
            this.contextMenuStripForwardDestinations.Name = "contextMenuStripForwardDestinations";
            this.contextMenuStripForwardDestinations.ShowImageMargin = false;
            this.contextMenuStripForwardDestinations.Size = new System.Drawing.Size(150, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeComputerToolStripMenuItem
            // 
            this.removeComputerToolStripMenuItem.Name = "removeComputerToolStripMenuItem";
            this.removeComputerToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.removeComputerToolStripMenuItem.Text = "Remove Computer";
            this.removeComputerToolStripMenuItem.Click += new System.EventHandler(this.removeComputerToolStripMenuItem_Click);
            // 
            // contextMenuStripSubscriptions
            // 
            this.contextMenuStripSubscriptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSubscriptionToolStripMenuItem,
            this.unsubscribeToolStripMenuItem});
            this.contextMenuStripSubscriptions.Name = "contextMenuStripSubscriptions";
            this.contextMenuStripSubscriptions.ShowImageMargin = false;
            this.contextMenuStripSubscriptions.Size = new System.Drawing.Size(115, 48);
            // 
            // editSubscriptionToolStripMenuItem
            // 
            this.editSubscriptionToolStripMenuItem.Name = "editSubscriptionToolStripMenuItem";
            this.editSubscriptionToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.editSubscriptionToolStripMenuItem.Text = "Edit";
            this.editSubscriptionToolStripMenuItem.Click += new System.EventHandler(this.editSubscriptionToolStripMenuItem_Click);
            // 
            // unsubscribeToolStripMenuItem
            // 
            this.unsubscribeToolStripMenuItem.Name = "unsubscribeToolStripMenuItem";
            this.unsubscribeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.unsubscribeToolStripMenuItem.Text = "Unsubscribe";
            this.unsubscribeToolStripMenuItem.Click += new System.EventHandler(this.unsubscribeToolStripMenuItem_Click);
            // 
            // contextMenuStripMultipleMonitors
            // 
            this.contextMenuStripMultipleMonitors.Name = "contextMenuStripMultipleMonitors";
            this.contextMenuStripMultipleMonitors.ShowCheckMargin = true;
            this.contextMenuStripMultipleMonitors.ShowImageMargin = false;
            this.contextMenuStripMultipleMonitors.Size = new System.Drawing.Size(61, 4);
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbarPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolbarPanel.Controls.Add(this.toolStrip1);
            this.toolbarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolbarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Size = new System.Drawing.Size(663, 69);
            this.toolbarPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarButtonGeneral,
            this.toolbarButtonApplications,
            this.toolbarButtonDisplays,
            this.toolbarButtonNetwork,
            this.toolbarButtonSecurity,
            this.toolbarButtonHistory,
            this.toolbarButtonAbout});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(74, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(521, 67);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolbarButtonGeneral
            // 
            this.toolbarButtonGeneral.AutoSize = false;
            this.toolbarButtonGeneral.Image = global::Growl.FormResources.tab_general;
            this.toolbarButtonGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.toolbarButtonGeneral.Name = "toolbarButtonGeneral";
            this.toolbarButtonGeneral.Padding = new System.Windows.Forms.Padding(10, 4, 10, 0);
            this.toolbarButtonGeneral.Size = new System.Drawing.Size(72, 69);
            this.toolbarButtonGeneral.Text = "General";
            this.toolbarButtonGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolbarButtonApplications
            // 
            this.toolbarButtonApplications.AutoSize = false;
            this.toolbarButtonApplications.Image = global::Growl.FormResources.tab_applications;
            this.toolbarButtonApplications.Margin = new System.Windows.Forms.Padding(0);
            this.toolbarButtonApplications.Name = "toolbarButtonApplications";
            this.toolbarButtonApplications.Padding = new System.Windows.Forms.Padding(10, 4, 10, 0);
            this.toolbarButtonApplications.Size = new System.Drawing.Size(72, 69);
            this.toolbarButtonApplications.Text = "Applications";
            this.toolbarButtonApplications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolbarButtonDisplays
            // 
            this.toolbarButtonDisplays.AutoSize = false;
            this.toolbarButtonDisplays.Image = global::Growl.FormResources.tab_displays;
            this.toolbarButtonDisplays.Margin = new System.Windows.Forms.Padding(0);
            this.toolbarButtonDisplays.Name = "toolbarButtonDisplays";
            this.toolbarButtonDisplays.Padding = new System.Windows.Forms.Padding(10, 4, 10, 0);
            this.toolbarButtonDisplays.Size = new System.Drawing.Size(72, 69);
            this.toolbarButtonDisplays.Text = "Displays";
            this.toolbarButtonDisplays.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolbarButtonNetwork
            // 
            this.toolbarButtonNetwork.AutoSize = false;
            this.toolbarButtonNetwork.Image = global::Growl.FormResources.tab_network;
            this.toolbarButtonNetwork.Margin = new System.Windows.Forms.Padding(0);
            this.toolbarButtonNetwork.Name = "toolbarButtonNetwork";
            this.toolbarButtonNetwork.Padding = new System.Windows.Forms.Padding(10, 4, 10, 0);
            this.toolbarButtonNetwork.Size = new System.Drawing.Size(72, 69);
            this.toolbarButtonNetwork.Text = "Network";
            this.toolbarButtonNetwork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolbarButtonSecurity
            // 
            this.toolbarButtonSecurity.AutoSize = false;
            this.toolbarButtonSecurity.Image = global::Growl.FormResources.tab_security;
            this.toolbarButtonSecurity.Margin = new System.Windows.Forms.Padding(0);
            this.toolbarButtonSecurity.Name = "toolbarButtonSecurity";
            this.toolbarButtonSecurity.Padding = new System.Windows.Forms.Padding(10, 4, 10, 0);
            this.toolbarButtonSecurity.Size = new System.Drawing.Size(72, 69);
            this.toolbarButtonSecurity.Text = "Security";
            this.toolbarButtonSecurity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolbarButtonHistory
            // 
            this.toolbarButtonHistory.AutoSize = false;
            this.toolbarButtonHistory.Image = global::Growl.FormResources.tab_history;
            this.toolbarButtonHistory.Margin = new System.Windows.Forms.Padding(0);
            this.toolbarButtonHistory.Name = "toolbarButtonHistory";
            this.toolbarButtonHistory.Padding = new System.Windows.Forms.Padding(10, 4, 10, 0);
            this.toolbarButtonHistory.Size = new System.Drawing.Size(72, 69);
            this.toolbarButtonHistory.Text = "History";
            this.toolbarButtonHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolbarButtonAbout
            // 
            this.toolbarButtonAbout.AutoSize = false;
            this.toolbarButtonAbout.Image = global::Growl.FormResources.growl;
            this.toolbarButtonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.toolbarButtonAbout.Name = "toolbarButtonAbout";
            this.toolbarButtonAbout.Padding = new System.Windows.Forms.Padding(10, 4, 10, 0);
            this.toolbarButtonAbout.Size = new System.Drawing.Size(72, 69);
            this.toolbarButtonAbout.Text = "About";
            this.toolbarButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 373);
            this.Controls.Add(this.toolbarPanel);
            this.Controls.Add(this.panelHistory);
            this.Controls.Add(this.panelApplications);
            this.Controls.Add(this.panelNetwork);
            this.Controls.Add(this.panelInitializing);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelDisplays);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.panelSecurity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(670, 411);
            this.Name = "MainForm";
            this.Text = "Growl";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelGeneral.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onOffButton1)).EndInit();
            this.groupBoxIdleSettings.ResumeLayout(false);
            this.groupBoxIdleSettings.PerformLayout();
            this.groupBoxSoundSettings.ResumeLayout(false);
            this.groupBoxSoundSettings.PerformLayout();
            this.panelApplications.ResumeLayout(false);
            this.panelSelectedApplication.ResumeLayout(false);
            this.panelPrefs.ResumeLayout(false);
            this.panelPrefs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApplicationNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApplication)).EndInit();
            this.panelNoApps.ResumeLayout(false);
            this.panelDisplays.ResumeLayout(false);
            this.panelDisplaySettings.ResumeLayout(false);
            this.panelDisplaySettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMultipleMonitors)).EndInit();
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSecurity.ResumeLayout(false);
            this.panelSecurity.PerformLayout();
            this.panelHistory.ResumeLayout(false);
            this.historyFilterGroupBox.ResumeLayout(false);
            this.historyFilterGroupBox.PerformLayout();
            this.historyDaysGroupBox.ResumeLayout(false);
            this.historyDaysGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDaysTrackBar)).EndInit();
            this.historySortByGroupBox.ResumeLayout(false);
            this.historySortByGroupBox.PerformLayout();
            this.panelInitializing.ResumeLayout(false);
            this.panelInitializing.PerformLayout();
            this.panelNetwork.ResumeLayout(false);
            this.panelNetwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUnsubscribe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSubscribe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRemoveComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAddComputer)).EndInit();
            this.contextMenuStripApplications.ResumeLayout(false);
            this.contextMenuStripForwardDestinations.ResumeLayout(false);
            this.contextMenuStripSubscriptions.ResumeLayout(false);
            this.toolbarPanel.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Growl.UI.CustomPanel toolbarPanel;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Panel panelApplications;
        private System.Windows.Forms.Panel panelDisplays;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Panel panelSecurity;
        private System.Windows.Forms.Label labelAboutGrowlVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAboutOriginal;
        private System.Windows.Forms.LinkLabel labelAboutOriginalLink;
        private System.Windows.Forms.Label labelAboutOriginal2;
        private System.Windows.Forms.Label labelAboutIcons2;
        private System.Windows.Forms.Label labelAboutIcons;
        private System.Windows.Forms.LinkLabel labelAboutIconsLink;
        private System.Windows.Forms.Label labelAboutUs;
        private System.Windows.Forms.LinkLabel labelAboutUsLink;
        private Growl.UI.OnOffButton onOffButton1;
        private System.Windows.Forms.CheckBox checkBoxAutoStart;
        private System.Windows.Forms.Label labelAboutBuildNumber;
        private Growl.UI.HistoryListView historyListView;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.RadioButton historySortByDateRadioButton;
        private System.Windows.Forms.GroupBox historySortByGroupBox;
        private System.Windows.Forms.RadioButton historySortByApplicationRadioButton;
        private Dotnetrix.Controls.TrackBar historyDaysTrackBar;
        private System.Windows.Forms.GroupBox historyDaysGroupBox;
        private System.Windows.Forms.Panel panelDisplaySettings;
        private System.Windows.Forms.Panel panelDisplaySettingsContainer;
        private System.Windows.Forms.Label displayStyleNameLabel;
        private System.Windows.Forms.Label displayStyleDescriptionLabel;
        private Growl.UI.ButtonEx buttonPreviewDisplay;
        private System.Windows.Forms.Label displayStyleAuthorLabel;
        private System.Windows.Forms.Label displayStyleVersionLabel;
        private System.Windows.Forms.LinkLabel displayStyleWebsiteLabel;
        private Growl.UI.ButtonEx buttonClearHistory;
        private System.Windows.Forms.Panel panelInitializing;
        private System.Windows.Forms.Label labelInitializationStage;
        private System.Windows.Forms.ProgressBar progressBarInitializing;
        private System.Windows.Forms.Label labelInitializing;
        private System.Windows.Forms.PictureBox pictureBoxApplication;
        private System.Windows.Forms.Panel panelSelectedApplication;
        private System.Windows.Forms.Label labelApplication;
        private System.Windows.Forms.Label labelPrefEnabled;
        private System.Windows.Forms.ComboBox comboBoxPrefEnabled;
        private System.Windows.Forms.Panel panelPrefs;
        private System.Windows.Forms.ComboBox comboBoxPrefDisplay;
        private System.Windows.Forms.Label labelPrefDisplay;
        private System.Windows.Forms.Label labelPrefSticky;
        private Growl.UI.ListControl listControlApplications;
        private Growl.UI.ListControl listControlApplicationNotifications;
        private System.Windows.Forms.Label labelApplicationNotification;
        private System.Windows.Forms.PictureBox pictureBoxApplicationNotification;
        private Growl.UI.ListControl listControlDisplays;
        private System.Windows.Forms.Panel panelNetwork;
        private System.Windows.Forms.CheckBox checkBoxEnableForwarding;
        private Growl.UI.ForwardListView forwardListView;
        private Growl.UI.ImageButton buttonAddComputer;
        private Growl.UI.ImageButton buttonRemoveComputer;
        private System.Windows.Forms.Label labelPrefForward;
        private System.Windows.Forms.ComboBox comboBoxPrefForward;
        private System.Windows.Forms.Label labelPrefPriority;
        private System.Windows.Forms.ComboBox comboBoxPrefPriority;
        private System.Windows.Forms.Label labelCurrentState;
        private Growl.UI.Toolbar toolStrip1;
        private System.Windows.Forms.ToolStripButton toolbarButtonGeneral;
        private System.Windows.Forms.ToolStripButton toolbarButtonApplications;
        private System.Windows.Forms.ToolStripButton toolbarButtonDisplays;
        private System.Windows.Forms.ToolStripButton toolbarButtonNetwork;
        private System.Windows.Forms.ToolStripButton toolbarButtonHistory;
        private System.Windows.Forms.ToolStripButton toolbarButtonAbout;
        private System.Windows.Forms.ComboBox comboBoxPrefSticky;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripApplications;
        private System.Windows.Forms.ToolStripMenuItem removeApplicationToolStripMenuItem;
        private System.Windows.Forms.Label labelPrefSound;
        private System.Windows.Forms.ComboBox comboBoxPrefSound;
        private System.Windows.Forms.GroupBox groupBoxIdleSettings;
        private System.Windows.Forms.GroupBox groupBoxSoundSettings;
        private System.Windows.Forms.Label labelDefaultSound;
        private System.Windows.Forms.ComboBox comboBoxDefaultSound;
        private System.Windows.Forms.RadioButton radioButtonIdleAfter;
        private System.Windows.Forms.RadioButton radioButtonIdleNever;
        private System.Windows.Forms.TextBox textBoxIdleAfterSeconds;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForwardDestinations;
        private System.Windows.Forms.ToolStripMenuItem removeComputerToolStripMenuItem;
        private Growl.UI.ForwardListView subscribedListView;
        private Growl.UI.ImageButton buttonUnsubscribe;
        private Growl.UI.ImageButton buttonSubscribe;
        private System.Windows.Forms.ToolStripButton toolbarButtonSecurity;
        private System.Windows.Forms.CheckBox checkBoxAllowNetworkNotifications;
        private System.Windows.Forms.CheckBox checkBoxRequireLocalPassword;
        private System.Windows.Forms.CheckBox checkBoxEnableSubscriptions;
        private System.Windows.Forms.CheckBox checkBoxAllowWebNotifications;
        private System.Windows.Forms.CheckBox checkBoxAllowSubscriptions;
        private Growl.UI.PasswordManagerControl passwordManagerControl1;
        private System.Windows.Forms.Label labelPasswordManager;
        private System.Windows.Forms.Panel panelNoApps;
        private System.Windows.Forms.Label labelNoApps;
        private System.Windows.Forms.GroupBox groupBox1;
        private Growl.UI.ButtonEx buttonSetAsDefault;
        private System.Windows.Forms.CheckBox checkBoxMuteAllSounds;
        private System.Windows.Forms.Label labelNoAppsDesc;
        private System.Windows.Forms.Label labelPrefDuration;
        private System.Windows.Forms.ComboBox comboBoxPrefDuration;
        private System.Windows.Forms.LinkLabel getDisplaysLabel;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSubscriptions;
        private System.Windows.Forms.ToolStripMenuItem editSubscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unsubscribeToolStripMenuItem;
        private System.Windows.Forms.GroupBox historyFilterGroupBox;
        private System.Windows.Forms.TextBox historyFilterTextBox;
        private System.Windows.Forms.Panel panelHistoryListViewBacker;
        private System.Windows.Forms.PictureBox pictureBoxMultipleMonitors;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMultipleMonitors;
        private System.Windows.Forms.CheckBox checkBoxRequireLANPassword;
    }
}
