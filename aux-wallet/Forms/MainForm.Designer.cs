﻿using ReaLTaiizor.Controls;
using System.Windows.Forms;

namespace AuxWallet
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabAsset = new System.Windows.Forms.TabPage();
            this.bt_claim = new ReaLTaiizor.Controls.MaterialButton();
            this.lb_unavailable = new ReaLTaiizor.Controls.MaterialLabel();
            this.lb_available = new ReaLTaiizor.Controls.MaterialLabel();
            this.lb_title_unavailable = new ReaLTaiizor.Controls.MaterialLabel();
            this.lb_title_available = new ReaLTaiizor.Controls.MaterialLabel();
            this.bt_queryAsset = new ReaLTaiizor.Controls.MaterialButton();
            this.lb_assets = new ReaLTaiizor.Controls.MaterialListBox();
            this.tabLockAsset = new System.Windows.Forms.TabPage();
            this.bt_RefreshLockAsset = new ReaLTaiizor.Controls.MaterialButton();
            this.lb_lockAssets = new ReaLTaiizor.Controls.MaterialListBox();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.bt_dig = new ReaLTaiizor.Controls.MaterialButton();
            this.lb_contacts = new ReaLTaiizor.Controls.MaterialListBox();
            this.bt_addContact = new ReaLTaiizor.Controls.MaterialButton();
            this.tabInHistory = new System.Windows.Forms.TabPage();
            this.lb_inHistory = new ReaLTaiizor.Controls.MaterialListBox();
            this.bt_queryInHistory = new ReaLTaiizor.Controls.MaterialButton();
            this.tabOutHistory = new System.Windows.Forms.TabPage();
            this.bt_queryOutHistory = new ReaLTaiizor.Controls.MaterialButton();
            this.lb_outHistory = new ReaLTaiizor.Controls.MaterialListBox();
            this.tabSignature = new System.Windows.Forms.TabPage();
            this.bt_copy = new ReaLTaiizor.Controls.MaterialButton();
            this.bt_signature = new ReaLTaiizor.Controls.MaterialButton();
            this.rb_hex = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.rb_text = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.tb_output = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            this.tb_input = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.bt_copyAddress = new ReaLTaiizor.Controls.MaterialButton();
            this.tb_privateKey = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_publicKey = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_Address = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.bt_viewKey = new ReaLTaiizor.Controls.MaterialButton();
            this.tb_pwd = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.lb_viewKey = new ReaLTaiizor.Controls.MaterialLabel();
            this.bt_saveApiUrl = new ReaLTaiizor.Controls.MaterialButton();
            this.lb_baseurl = new ReaLTaiizor.Controls.MaterialLabel();
            this.tb_backupapiurl = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.bt_signout = new ReaLTaiizor.Controls.MaterialButton();
            this.bt_changeTheme = new ReaLTaiizor.Controls.MaterialButton();
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabAsset.SuspendLayout();
            this.tabLockAsset.SuspendLayout();
            this.tabContacts.SuspendLayout();
            this.tabInHistory.SuspendLayout();
            this.tabOutHistory.SuspendLayout();
            this.tabSignature.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabAsset);
            this.materialTabControl1.Controls.Add(this.tabLockAsset);
            this.materialTabControl1.Controls.Add(this.tabContacts);
            this.materialTabControl1.Controls.Add(this.tabInHistory);
            this.materialTabControl1.Controls.Add(this.tabOutHistory);
            this.materialTabControl1.Controls.Add(this.tabSignature);
            this.materialTabControl1.Controls.Add(this.tabSetting);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.menuIconList;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 118);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(992, 659);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabAsset
            // 
            this.tabAsset.BackColor = System.Drawing.Color.White;
            this.tabAsset.Controls.Add(this.bt_claim);
            this.tabAsset.Controls.Add(this.lb_unavailable);
            this.tabAsset.Controls.Add(this.lb_available);
            this.tabAsset.Controls.Add(this.lb_title_unavailable);
            this.tabAsset.Controls.Add(this.lb_title_available);
            this.tabAsset.Controls.Add(this.bt_queryAsset);
            this.tabAsset.Controls.Add(this.lb_assets);
            this.tabAsset.ImageKey = "round_assessment_white_24dp.png";
            this.tabAsset.Location = new System.Drawing.Point(4, 33);
            this.tabAsset.Margin = new System.Windows.Forms.Padding(6);
            this.tabAsset.Name = "tabAsset";
            this.tabAsset.Size = new System.Drawing.Size(984, 622);
            this.tabAsset.TabIndex = 0;
            this.tabAsset.Text = "Asset";
            // 
            // bt_claim
            // 
            this.bt_claim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_claim.AutoSize = false;
            this.bt_claim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_claim.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_claim.Depth = 0;
            this.bt_claim.HighEmphasis = true;
            this.bt_claim.Icon = global::AuxWallet.Properties.Resources.round_swap_vert_white_24dp;
            this.bt_claim.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_claim.Location = new System.Drawing.Point(421, 2);
            this.bt_claim.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_claim.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_claim.Name = "bt_claim";
            this.bt_claim.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_claim.Size = new System.Drawing.Size(264, 53);
            this.bt_claim.TabIndex = 83;
            this.bt_claim.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_claim.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_claim.UseAccentColor = false;
            this.bt_claim.UseVisualStyleBackColor = true;
            this.bt_claim.Click += new System.EventHandler(this.bt_claim_Click);
            // 
            // lb_unavailable
            // 
            this.lb_unavailable.AutoSize = true;
            this.lb_unavailable.Depth = 0;
            this.lb_unavailable.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_unavailable.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            this.lb_unavailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_unavailable.HighEmphasis = true;
            this.lb_unavailable.Location = new System.Drawing.Point(109, 29);
            this.lb_unavailable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_unavailable.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lb_unavailable.Name = "lb_unavailable";
            this.lb_unavailable.Size = new System.Drawing.Size(1, 0);
            this.lb_unavailable.TabIndex = 82;
            // 
            // lb_available
            // 
            this.lb_available.AutoSize = true;
            this.lb_available.Depth = 0;
            this.lb_available.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_available.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            this.lb_available.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_available.HighEmphasis = true;
            this.lb_available.Location = new System.Drawing.Point(109, 5);
            this.lb_available.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_available.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lb_available.Name = "lb_available";
            this.lb_available.Size = new System.Drawing.Size(1, 0);
            this.lb_available.TabIndex = 81;
            // 
            // lb_title_unavailable
            // 
            this.lb_title_unavailable.AutoSize = true;
            this.lb_title_unavailable.Depth = 0;
            this.lb_title_unavailable.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_title_unavailable.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Button;
            this.lb_title_unavailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_title_unavailable.Location = new System.Drawing.Point(15, 29);
            this.lb_title_unavailable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_title_unavailable.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lb_title_unavailable.Name = "lb_title_unavailable";
            this.lb_title_unavailable.Size = new System.Drawing.Size(57, 17);
            this.lb_title_unavailable.TabIndex = 79;
            this.lb_title_unavailable.Text = "BUTTON";
            // 
            // lb_title_available
            // 
            this.lb_title_available.AutoSize = true;
            this.lb_title_available.Depth = 0;
            this.lb_title_available.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_title_available.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Button;
            this.lb_title_available.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_title_available.Location = new System.Drawing.Point(15, 5);
            this.lb_title_available.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_title_available.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lb_title_available.Name = "lb_title_available";
            this.lb_title_available.Size = new System.Drawing.Size(57, 17);
            this.lb_title_available.TabIndex = 78;
            this.lb_title_available.Text = "BUTTON";
            // 
            // bt_queryAsset
            // 
            this.bt_queryAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_queryAsset.AutoSize = false;
            this.bt_queryAsset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_queryAsset.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_queryAsset.Depth = 0;
            this.bt_queryAsset.HighEmphasis = true;
            this.bt_queryAsset.Icon = ((System.Drawing.Image)(resources.GetObject("bt_queryAsset.Icon")));
            this.bt_queryAsset.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_queryAsset.Location = new System.Drawing.Point(714, 2);
            this.bt_queryAsset.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_queryAsset.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_queryAsset.Name = "bt_queryAsset";
            this.bt_queryAsset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_queryAsset.Size = new System.Drawing.Size(264, 53);
            this.bt_queryAsset.TabIndex = 17;
            this.bt_queryAsset.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_queryAsset.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_queryAsset.UseAccentColor = false;
            this.bt_queryAsset.UseVisualStyleBackColor = true;
            this.bt_queryAsset.Click += new System.EventHandler(this.bt_queryAsset_Click);
            // 
            // lb_assets
            // 
            this.lb_assets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_assets.BackColor = System.Drawing.Color.White;
            this.lb_assets.BorderColor = System.Drawing.Color.LightGray;
            this.lb_assets.Depth = 0;
            this.lb_assets.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_assets.Location = new System.Drawing.Point(6, 60);
            this.lb_assets.Margin = new System.Windows.Forms.Padding(6);
            this.lb_assets.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lb_assets.Name = "lb_assets";
            this.lb_assets.SelectedIndex = -1;
            this.lb_assets.SelectedItem = null;
            this.lb_assets.Size = new System.Drawing.Size(972, 556);
            this.lb_assets.Style = ReaLTaiizor.Controls.MaterialListBox.ListBoxStyle.ThreeLine;
            this.lb_assets.TabIndex = 3;
            this.lb_assets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_assets_MouseDoubleClick);
            // 
            // tabLockAsset
            // 
            this.tabLockAsset.Controls.Add(this.bt_RefreshLockAsset);
            this.tabLockAsset.Controls.Add(this.lb_lockAssets);
            this.tabLockAsset.ImageKey = "round_mail_outline_black_24dp.png";
            this.tabLockAsset.Location = new System.Drawing.Point(4, 33);
            this.tabLockAsset.Name = "tabLockAsset";
            this.tabLockAsset.Size = new System.Drawing.Size(984, 622);
            this.tabLockAsset.TabIndex = 9;
            this.tabLockAsset.Text = "tabLockAsset";
            this.tabLockAsset.UseVisualStyleBackColor = true;
            // 
            // bt_RefreshLockAsset
            // 
            this.bt_RefreshLockAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_RefreshLockAsset.AutoSize = false;
            this.bt_RefreshLockAsset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_RefreshLockAsset.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_RefreshLockAsset.Depth = 0;
            this.bt_RefreshLockAsset.HighEmphasis = true;
            this.bt_RefreshLockAsset.Icon = ((System.Drawing.Image)(resources.GetObject("bt_RefreshLockAsset.Icon")));
            this.bt_RefreshLockAsset.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_RefreshLockAsset.Location = new System.Drawing.Point(714, 4);
            this.bt_RefreshLockAsset.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_RefreshLockAsset.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_RefreshLockAsset.Name = "bt_RefreshLockAsset";
            this.bt_RefreshLockAsset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_RefreshLockAsset.Size = new System.Drawing.Size(264, 53);
            this.bt_RefreshLockAsset.TabIndex = 19;
            this.bt_RefreshLockAsset.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_RefreshLockAsset.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_RefreshLockAsset.UseAccentColor = false;
            this.bt_RefreshLockAsset.UseVisualStyleBackColor = true;
            this.bt_RefreshLockAsset.Click += new System.EventHandler(this.bt_RefreshLockAsset_Click);
            // 
            // lb_lockAssets
            // 
            this.lb_lockAssets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_lockAssets.BackColor = System.Drawing.Color.White;
            this.lb_lockAssets.BorderColor = System.Drawing.Color.LightGray;
            this.lb_lockAssets.Depth = 0;
            this.lb_lockAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_lockAssets.Location = new System.Drawing.Point(6, 62);
            this.lb_lockAssets.Margin = new System.Windows.Forms.Padding(6);
            this.lb_lockAssets.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lb_lockAssets.Name = "lb_lockAssets";
            this.lb_lockAssets.SelectedIndex = -1;
            this.lb_lockAssets.SelectedItem = null;
            this.lb_lockAssets.Size = new System.Drawing.Size(972, 556);
            this.lb_lockAssets.Style = ReaLTaiizor.Controls.MaterialListBox.ListBoxStyle.ThreeLine;
            this.lb_lockAssets.TabIndex = 18;
            // 
            // tabContacts
            // 
            this.tabContacts.BackColor = System.Drawing.Color.White;
            this.tabContacts.Controls.Add(this.bt_dig);
            this.tabContacts.Controls.Add(this.lb_contacts);
            this.tabContacts.Controls.Add(this.bt_addContact);
            this.tabContacts.ImageKey = "round_person_black_24dp.png";
            this.tabContacts.Location = new System.Drawing.Point(4, 33);
            this.tabContacts.Margin = new System.Windows.Forms.Padding(6);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Padding = new System.Windows.Forms.Padding(6);
            this.tabContacts.Size = new System.Drawing.Size(984, 622);
            this.tabContacts.TabIndex = 6;
            this.tabContacts.Text = "Contacts";
            // 
            // bt_dig
            // 
            this.bt_dig.AutoSize = false;
            this.bt_dig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_dig.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_dig.Depth = 0;
            this.bt_dig.HighEmphasis = true;
            this.bt_dig.Icon = global::AuxWallet.Properties.Resources.baseline_favorite_border_black_24dp;
            this.bt_dig.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_dig.Location = new System.Drawing.Point(6, 3);
            this.bt_dig.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_dig.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_dig.Name = "bt_dig";
            this.bt_dig.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_dig.Size = new System.Drawing.Size(201, 53);
            this.bt_dig.TabIndex = 23;
            this.bt_dig.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_dig.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_dig.UseAccentColor = false;
            this.bt_dig.UseVisualStyleBackColor = true;
            this.bt_dig.Click += new System.EventHandler(this.bt_dig_Click);
            // 
            // lb_contacts
            // 
            this.lb_contacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_contacts.BackColor = System.Drawing.Color.White;
            this.lb_contacts.BorderColor = System.Drawing.Color.LightGray;
            this.lb_contacts.Depth = 0;
            this.lb_contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_contacts.Location = new System.Drawing.Point(6, 61);
            this.lb_contacts.Margin = new System.Windows.Forms.Padding(6);
            this.lb_contacts.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lb_contacts.Name = "lb_contacts";
            this.lb_contacts.SelectedIndex = -1;
            this.lb_contacts.SelectedItem = null;
            this.lb_contacts.Size = new System.Drawing.Size(972, 553);
            this.lb_contacts.Style = ReaLTaiizor.Controls.MaterialListBox.ListBoxStyle.ThreeLine;
            this.lb_contacts.TabIndex = 22;
            this.lb_contacts.DoubleClick += new System.EventHandler(this.lb_contacts_DoubleClick);
            this.lb_contacts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_contacts_MouseDoubleClick);
            // 
            // bt_addContact
            // 
            this.bt_addContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_addContact.AutoSize = false;
            this.bt_addContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_addContact.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_addContact.Depth = 0;
            this.bt_addContact.HighEmphasis = true;
            this.bt_addContact.Icon = global::AuxWallet.Properties.Resources.round_add_black_24dp;
            this.bt_addContact.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_addContact.Location = new System.Drawing.Point(632, 3);
            this.bt_addContact.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_addContact.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_addContact.Name = "bt_addContact";
            this.bt_addContact.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_addContact.Size = new System.Drawing.Size(346, 53);
            this.bt_addContact.TabIndex = 21;
            this.bt_addContact.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_addContact.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_addContact.UseAccentColor = false;
            this.bt_addContact.UseVisualStyleBackColor = true;
            this.bt_addContact.Click += new System.EventHandler(this.bt_addContact_Click);
            // 
            // tabInHistory
            // 
            this.tabInHistory.BackColor = System.Drawing.Color.White;
            this.tabInHistory.Controls.Add(this.lb_inHistory);
            this.tabInHistory.Controls.Add(this.bt_queryInHistory);
            this.tabInHistory.ImageKey = "arrow-autofit-right.png";
            this.tabInHistory.Location = new System.Drawing.Point(4, 33);
            this.tabInHistory.Margin = new System.Windows.Forms.Padding(6);
            this.tabInHistory.Name = "tabInHistory";
            this.tabInHistory.Padding = new System.Windows.Forms.Padding(6);
            this.tabInHistory.Size = new System.Drawing.Size(984, 622);
            this.tabInHistory.TabIndex = 1;
            this.tabInHistory.Text = "InHistory";
            // 
            // lb_inHistory
            // 
            this.lb_inHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_inHistory.BackColor = System.Drawing.Color.White;
            this.lb_inHistory.BorderColor = System.Drawing.Color.LightGray;
            this.lb_inHistory.Depth = 0;
            this.lb_inHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_inHistory.Location = new System.Drawing.Point(6, 62);
            this.lb_inHistory.Margin = new System.Windows.Forms.Padding(6);
            this.lb_inHistory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lb_inHistory.Name = "lb_inHistory";
            this.lb_inHistory.SelectedIndex = -1;
            this.lb_inHistory.SelectedItem = null;
            this.lb_inHistory.Size = new System.Drawing.Size(972, 552);
            this.lb_inHistory.Style = ReaLTaiizor.Controls.MaterialListBox.ListBoxStyle.ThreeLine;
            this.lb_inHistory.TabIndex = 20;
            // 
            // bt_queryInHistory
            // 
            this.bt_queryInHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_queryInHistory.AutoSize = false;
            this.bt_queryInHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_queryInHistory.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_queryInHistory.Depth = 0;
            this.bt_queryInHistory.HighEmphasis = true;
            this.bt_queryInHistory.Icon = ((System.Drawing.Image)(resources.GetObject("bt_queryInHistory.Icon")));
            this.bt_queryInHistory.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_queryInHistory.Location = new System.Drawing.Point(632, 3);
            this.bt_queryInHistory.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_queryInHistory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_queryInHistory.Name = "bt_queryInHistory";
            this.bt_queryInHistory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_queryInHistory.Size = new System.Drawing.Size(346, 53);
            this.bt_queryInHistory.TabIndex = 19;
            this.bt_queryInHistory.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_queryInHistory.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_queryInHistory.UseAccentColor = false;
            this.bt_queryInHistory.UseVisualStyleBackColor = true;
            this.bt_queryInHistory.Click += new System.EventHandler(this.bt_queryInHistory_Click);
            // 
            // tabOutHistory
            // 
            this.tabOutHistory.Controls.Add(this.bt_queryOutHistory);
            this.tabOutHistory.Controls.Add(this.lb_outHistory);
            this.tabOutHistory.ImageKey = "arrow-autofit-left.png";
            this.tabOutHistory.Location = new System.Drawing.Point(4, 33);
            this.tabOutHistory.Name = "tabOutHistory";
            this.tabOutHistory.Size = new System.Drawing.Size(984, 622);
            this.tabOutHistory.TabIndex = 7;
            this.tabOutHistory.Text = "OutHistory";
            this.tabOutHistory.UseVisualStyleBackColor = true;
            // 
            // bt_queryOutHistory
            // 
            this.bt_queryOutHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_queryOutHistory.AutoSize = false;
            this.bt_queryOutHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_queryOutHistory.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_queryOutHistory.Depth = 0;
            this.bt_queryOutHistory.HighEmphasis = true;
            this.bt_queryOutHistory.Icon = ((System.Drawing.Image)(resources.GetObject("bt_queryOutHistory.Icon")));
            this.bt_queryOutHistory.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_queryOutHistory.Location = new System.Drawing.Point(632, 4);
            this.bt_queryOutHistory.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_queryOutHistory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_queryOutHistory.Name = "bt_queryOutHistory";
            this.bt_queryOutHistory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_queryOutHistory.Size = new System.Drawing.Size(346, 53);
            this.bt_queryOutHistory.TabIndex = 20;
            this.bt_queryOutHistory.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_queryOutHistory.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_queryOutHistory.UseAccentColor = false;
            this.bt_queryOutHistory.UseVisualStyleBackColor = true;
            this.bt_queryOutHistory.Click += new System.EventHandler(this.bt_queryOutHistory_Click);
            // 
            // lb_outHistory
            // 
            this.lb_outHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_outHistory.BackColor = System.Drawing.Color.White;
            this.lb_outHistory.BorderColor = System.Drawing.Color.LightGray;
            this.lb_outHistory.Depth = 0;
            this.lb_outHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_outHistory.Location = new System.Drawing.Point(6, 62);
            this.lb_outHistory.Margin = new System.Windows.Forms.Padding(6);
            this.lb_outHistory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lb_outHistory.Name = "lb_outHistory";
            this.lb_outHistory.SelectedIndex = -1;
            this.lb_outHistory.SelectedItem = null;
            this.lb_outHistory.Size = new System.Drawing.Size(972, 556);
            this.lb_outHistory.Style = ReaLTaiizor.Controls.MaterialListBox.ListBoxStyle.ThreeLine;
            this.lb_outHistory.TabIndex = 18;
            // 
            // tabSignature
            // 
            this.tabSignature.Controls.Add(this.bt_copy);
            this.tabSignature.Controls.Add(this.bt_signature);
            this.tabSignature.Controls.Add(this.rb_hex);
            this.tabSignature.Controls.Add(this.rb_text);
            this.tabSignature.Controls.Add(this.tb_output);
            this.tabSignature.Controls.Add(this.tb_input);
            this.tabSignature.ImageKey = "round_swap_vert_white_24dp.png";
            this.tabSignature.Location = new System.Drawing.Point(4, 33);
            this.tabSignature.Name = "tabSignature";
            this.tabSignature.Size = new System.Drawing.Size(984, 622);
            this.tabSignature.TabIndex = 8;
            this.tabSignature.Text = "tabPage1";
            this.tabSignature.UseVisualStyleBackColor = true;
            // 
            // bt_copy
            // 
            this.bt_copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_copy.AutoSize = false;
            this.bt_copy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_copy.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_copy.Depth = 0;
            this.bt_copy.HighEmphasis = true;
            this.bt_copy.Icon = null;
            this.bt_copy.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_copy.Location = new System.Drawing.Point(354, 537);
            this.bt_copy.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_copy.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_copy.Name = "bt_copy";
            this.bt_copy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_copy.Size = new System.Drawing.Size(264, 53);
            this.bt_copy.TabIndex = 76;
            this.bt_copy.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_copy.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_copy.UseAccentColor = false;
            this.bt_copy.UseVisualStyleBackColor = true;
            this.bt_copy.Click += new System.EventHandler(this.bt_copy_Click);
            // 
            // bt_signature
            // 
            this.bt_signature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_signature.AutoSize = false;
            this.bt_signature.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_signature.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_signature.Depth = 0;
            this.bt_signature.HighEmphasis = true;
            this.bt_signature.Icon = global::AuxWallet.Properties.Resources.Collection_16xLG;
            this.bt_signature.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_signature.Image = global::AuxWallet.Properties.Resources.Collection_16xLG;
            this.bt_signature.Location = new System.Drawing.Point(354, 260);
            this.bt_signature.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_signature.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_signature.Name = "bt_signature";
            this.bt_signature.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_signature.Size = new System.Drawing.Size(264, 53);
            this.bt_signature.TabIndex = 75;
            this.bt_signature.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_signature.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_signature.UseAccentColor = false;
            this.bt_signature.UseVisualStyleBackColor = true;
            this.bt_signature.Click += new System.EventHandler(this.bt_signature_Click);
            // 
            // rb_hex
            // 
            this.rb_hex.AutoSize = true;
            this.rb_hex.Depth = 0;
            this.rb_hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rb_hex.Location = new System.Drawing.Point(267, 15);
            this.rb_hex.Margin = new System.Windows.Forms.Padding(0);
            this.rb_hex.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_hex.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.rb_hex.Name = "rb_hex";
            this.rb_hex.Ripple = true;
            this.rb_hex.Size = new System.Drawing.Size(190, 37);
            this.rb_hex.TabIndex = 74;
            this.rb_hex.TabStop = true;
            this.rb_hex.Text = "materialRadioButton2";
            this.rb_hex.UseAccentColor = false;
            this.rb_hex.UseVisualStyleBackColor = true;
            // 
            // rb_text
            // 
            this.rb_text.AutoSize = true;
            this.rb_text.Checked = true;
            this.rb_text.Depth = 0;
            this.rb_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rb_text.Location = new System.Drawing.Point(41, 15);
            this.rb_text.Margin = new System.Windows.Forms.Padding(0);
            this.rb_text.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_text.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.rb_text.Name = "rb_text";
            this.rb_text.Ripple = true;
            this.rb_text.Size = new System.Drawing.Size(190, 37);
            this.rb_text.TabIndex = 73;
            this.rb_text.TabStop = true;
            this.rb_text.Text = "materialRadioButton1";
            this.rb_text.UseAccentColor = false;
            this.rb_text.UseVisualStyleBackColor = true;
            // 
            // tb_output
            // 
            this.tb_output.AnimateReadOnly = false;
            this.tb_output.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_output.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_output.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_output.Depth = 0;
            this.tb_output.HideSelection = true;
            this.tb_output.Hint = "output data";
            this.tb_output.Location = new System.Drawing.Point(41, 334);
            this.tb_output.Margin = new System.Windows.Forms.Padding(6);
            this.tb_output.MaxLength = 2147483647;
            this.tb_output.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_output.Name = "tb_output";
            this.tb_output.PasswordChar = '\0';
            this.tb_output.ReadOnly = false;
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_output.SelectedText = "";
            this.tb_output.SelectionLength = 0;
            this.tb_output.SelectionStart = 0;
            this.tb_output.ShortcutsEnabled = true;
            this.tb_output.Size = new System.Drawing.Size(908, 177);
            this.tb_output.TabIndex = 72;
            this.tb_output.TabStop = false;
            this.tb_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_output.UseSystemPasswordChar = false;
            // 
            // tb_input
            // 
            this.tb_input.AnimateReadOnly = false;
            this.tb_input.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_input.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_input.Depth = 0;
            this.tb_input.HideSelection = true;
            this.tb_input.Hint = "input data";
            this.tb_input.Location = new System.Drawing.Point(41, 71);
            this.tb_input.Margin = new System.Windows.Forms.Padding(6);
            this.tb_input.MaxLength = 2147483647;
            this.tb_input.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_input.Name = "tb_input";
            this.tb_input.PasswordChar = '\0';
            this.tb_input.ReadOnly = false;
            this.tb_input.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_input.SelectedText = "";
            this.tb_input.SelectionLength = 0;
            this.tb_input.SelectionStart = 0;
            this.tb_input.ShortcutsEnabled = true;
            this.tb_input.Size = new System.Drawing.Size(908, 177);
            this.tb_input.TabIndex = 71;
            this.tb_input.TabStop = false;
            this.tb_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_input.UseSystemPasswordChar = false;
            // 
            // tabSetting
            // 
            this.tabSetting.BackColor = System.Drawing.Color.White;
            this.tabSetting.Controls.Add(this.bt_copyAddress);
            this.tabSetting.Controls.Add(this.tb_privateKey);
            this.tabSetting.Controls.Add(this.tb_publicKey);
            this.tabSetting.Controls.Add(this.tb_Address);
            this.tabSetting.Controls.Add(this.bt_viewKey);
            this.tabSetting.Controls.Add(this.tb_pwd);
            this.tabSetting.Controls.Add(this.lb_viewKey);
            this.tabSetting.Controls.Add(this.bt_saveApiUrl);
            this.tabSetting.Controls.Add(this.lb_baseurl);
            this.tabSetting.Controls.Add(this.tb_backupapiurl);
            this.tabSetting.Controls.Add(this.bt_signout);
            this.tabSetting.Controls.Add(this.bt_changeTheme);
            this.tabSetting.ImageKey = "round_build_white_24dp.png";
            this.tabSetting.Location = new System.Drawing.Point(4, 33);
            this.tabSetting.Margin = new System.Windows.Forms.Padding(6);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Padding = new System.Windows.Forms.Padding(6);
            this.tabSetting.Size = new System.Drawing.Size(984, 622);
            this.tabSetting.TabIndex = 2;
            this.tabSetting.Text = "Setting";
            this.tabSetting.Enter += new System.EventHandler(this.tabSetting_Enter);
            // 
            // bt_copyAddress
            // 
            this.bt_copyAddress.AutoSize = false;
            this.bt_copyAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_copyAddress.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_copyAddress.Depth = 0;
            this.bt_copyAddress.HighEmphasis = true;
            this.bt_copyAddress.Icon = null;
            this.bt_copyAddress.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_copyAddress.Location = new System.Drawing.Point(563, 11);
            this.bt_copyAddress.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_copyAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_copyAddress.Name = "bt_copyAddress";
            this.bt_copyAddress.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_copyAddress.Size = new System.Drawing.Size(229, 53);
            this.bt_copyAddress.TabIndex = 81;
            this.bt_copyAddress.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_copyAddress.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_copyAddress.UseAccentColor = false;
            this.bt_copyAddress.UseVisualStyleBackColor = true;
            this.bt_copyAddress.Click += new System.EventHandler(this.bt_copyAddress_Click);
            // 
            // tb_privateKey
            // 
            this.tb_privateKey.AnimateReadOnly = false;
            this.tb_privateKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_privateKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_privateKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_privateKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_privateKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_privateKey.Depth = 0;
            this.tb_privateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_privateKey.HideSelection = true;
            this.tb_privateKey.Hint = "Type here";
            this.tb_privateKey.LeadingIcon = null;
            this.tb_privateKey.Location = new System.Drawing.Point(51, 524);
            this.tb_privateKey.Margin = new System.Windows.Forms.Padding(6);
            this.tb_privateKey.MaxLength = 0;
            this.tb_privateKey.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_privateKey.Name = "tb_privateKey";
            this.tb_privateKey.PasswordChar = '\0';
            this.tb_privateKey.PrefixSuffixText = null;
            this.tb_privateKey.ReadOnly = true;
            this.tb_privateKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_privateKey.SelectedText = "";
            this.tb_privateKey.SelectionLength = 0;
            this.tb_privateKey.SelectionStart = 0;
            this.tb_privateKey.ShortcutsEnabled = true;
            this.tb_privateKey.Size = new System.Drawing.Size(741, 48);
            this.tb_privateKey.TabIndex = 80;
            this.tb_privateKey.TabStop = false;
            this.tb_privateKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_privateKey.TrailingIcon = null;
            this.tb_privateKey.UseSystemPasswordChar = false;
            // 
            // tb_publicKey
            // 
            this.tb_publicKey.AnimateReadOnly = false;
            this.tb_publicKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_publicKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_publicKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_publicKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_publicKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_publicKey.Depth = 0;
            this.tb_publicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_publicKey.HideSelection = true;
            this.tb_publicKey.Hint = "Type here";
            this.tb_publicKey.LeadingIcon = null;
            this.tb_publicKey.Location = new System.Drawing.Point(51, 464);
            this.tb_publicKey.Margin = new System.Windows.Forms.Padding(6);
            this.tb_publicKey.MaxLength = 0;
            this.tb_publicKey.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_publicKey.Name = "tb_publicKey";
            this.tb_publicKey.PasswordChar = '\0';
            this.tb_publicKey.PrefixSuffixText = null;
            this.tb_publicKey.ReadOnly = true;
            this.tb_publicKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_publicKey.SelectedText = "";
            this.tb_publicKey.SelectionLength = 0;
            this.tb_publicKey.SelectionStart = 0;
            this.tb_publicKey.ShortcutsEnabled = true;
            this.tb_publicKey.Size = new System.Drawing.Size(741, 48);
            this.tb_publicKey.TabIndex = 79;
            this.tb_publicKey.TabStop = false;
            this.tb_publicKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_publicKey.TrailingIcon = null;
            this.tb_publicKey.UseSystemPasswordChar = false;
            // 
            // tb_Address
            // 
            this.tb_Address.AnimateReadOnly = false;
            this.tb_Address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_Address.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_Address.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_Address.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Address.Depth = 0;
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Address.HideSelection = true;
            this.tb_Address.Hint = "Type here";
            this.tb_Address.LeadingIcon = null;
            this.tb_Address.Location = new System.Drawing.Point(51, 404);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(6);
            this.tb_Address.MaxLength = 0;
            this.tb_Address.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.PasswordChar = '\0';
            this.tb_Address.PrefixSuffixText = null;
            this.tb_Address.ReadOnly = true;
            this.tb_Address.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_Address.SelectedText = "";
            this.tb_Address.SelectionLength = 0;
            this.tb_Address.SelectionStart = 0;
            this.tb_Address.ShortcutsEnabled = true;
            this.tb_Address.Size = new System.Drawing.Size(741, 48);
            this.tb_Address.TabIndex = 78;
            this.tb_Address.TabStop = false;
            this.tb_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Address.TrailingIcon = null;
            this.tb_Address.UseSystemPasswordChar = false;
            // 
            // bt_viewKey
            // 
            this.bt_viewKey.AutoSize = false;
            this.bt_viewKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_viewKey.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_viewKey.Depth = 0;
            this.bt_viewKey.HighEmphasis = true;
            this.bt_viewKey.Icon = null;
            this.bt_viewKey.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_viewKey.Location = new System.Drawing.Point(446, 334);
            this.bt_viewKey.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_viewKey.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_viewKey.Name = "bt_viewKey";
            this.bt_viewKey.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_viewKey.Size = new System.Drawing.Size(346, 53);
            this.bt_viewKey.TabIndex = 77;
            this.bt_viewKey.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_viewKey.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_viewKey.UseAccentColor = false;
            this.bt_viewKey.UseVisualStyleBackColor = true;
            this.bt_viewKey.Click += new System.EventHandler(this.bt_viewKey_Click);
            // 
            // tb_pwd
            // 
            this.tb_pwd.AnimateReadOnly = false;
            this.tb_pwd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_pwd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_pwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_pwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pwd.Depth = 0;
            this.tb_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_pwd.HideSelection = true;
            this.tb_pwd.Hint = "Password";
            this.tb_pwd.LeadingIcon = null;
            this.tb_pwd.Location = new System.Drawing.Point(51, 339);
            this.tb_pwd.Margin = new System.Windows.Forms.Padding(6);
            this.tb_pwd.MaxLength = 0;
            this.tb_pwd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '●';
            this.tb_pwd.PrefixSuffixText = null;
            this.tb_pwd.ReadOnly = false;
            this.tb_pwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_pwd.SelectedText = "";
            this.tb_pwd.SelectionLength = 0;
            this.tb_pwd.SelectionStart = 0;
            this.tb_pwd.ShortcutsEnabled = true;
            this.tb_pwd.Size = new System.Drawing.Size(346, 48);
            this.tb_pwd.TabIndex = 76;
            this.tb_pwd.TabStop = false;
            this.tb_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_pwd.TrailingIcon = null;
            this.tb_pwd.UseSystemPasswordChar = true;
            // 
            // lb_viewKey
            // 
            this.lb_viewKey.AutoSize = true;
            this.lb_viewKey.Depth = 0;
            this.lb_viewKey.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_viewKey.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            this.lb_viewKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_viewKey.Location = new System.Drawing.Point(51, 292);
            this.lb_viewKey.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_viewKey.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lb_viewKey.Name = "lb_viewKey";
            this.lb_viewKey.Size = new System.Drawing.Size(154, 41);
            this.lb_viewKey.TabIndex = 75;
            this.lb_viewKey.Text = "Heading 4";
            // 
            // bt_saveApiUrl
            // 
            this.bt_saveApiUrl.AutoSize = false;
            this.bt_saveApiUrl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_saveApiUrl.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_saveApiUrl.Depth = 0;
            this.bt_saveApiUrl.HighEmphasis = true;
            this.bt_saveApiUrl.Icon = null;
            this.bt_saveApiUrl.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_saveApiUrl.Location = new System.Drawing.Point(51, 205);
            this.bt_saveApiUrl.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_saveApiUrl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_saveApiUrl.Name = "bt_saveApiUrl";
            this.bt_saveApiUrl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_saveApiUrl.Size = new System.Drawing.Size(741, 53);
            this.bt_saveApiUrl.TabIndex = 74;
            this.bt_saveApiUrl.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_saveApiUrl.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_saveApiUrl.UseAccentColor = false;
            this.bt_saveApiUrl.UseVisualStyleBackColor = true;
            this.bt_saveApiUrl.Click += new System.EventHandler(this.bt_saveApiUrl_Click);
            // 
            // lb_baseurl
            // 
            this.lb_baseurl.AutoSize = true;
            this.lb_baseurl.Depth = 0;
            this.lb_baseurl.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_baseurl.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            this.lb_baseurl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_baseurl.Location = new System.Drawing.Point(51, 93);
            this.lb_baseurl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_baseurl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lb_baseurl.Name = "lb_baseurl";
            this.lb_baseurl.Size = new System.Drawing.Size(154, 41);
            this.lb_baseurl.TabIndex = 73;
            this.lb_baseurl.Text = "Heading 4";
            // 
            // tb_backupapiurl
            // 
            this.tb_backupapiurl.AnimateReadOnly = false;
            this.tb_backupapiurl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_backupapiurl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_backupapiurl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_backupapiurl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_backupapiurl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_backupapiurl.Depth = 0;
            this.tb_backupapiurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_backupapiurl.HideSelection = true;
            this.tb_backupapiurl.Hint = "Type here";
            this.tb_backupapiurl.LeadingIcon = null;
            this.tb_backupapiurl.Location = new System.Drawing.Point(51, 140);
            this.tb_backupapiurl.Margin = new System.Windows.Forms.Padding(6);
            this.tb_backupapiurl.MaxLength = 0;
            this.tb_backupapiurl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_backupapiurl.Name = "tb_backupapiurl";
            this.tb_backupapiurl.PasswordChar = '\0';
            this.tb_backupapiurl.PrefixSuffixText = null;
            this.tb_backupapiurl.ReadOnly = false;
            this.tb_backupapiurl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_backupapiurl.SelectedText = "";
            this.tb_backupapiurl.SelectionLength = 0;
            this.tb_backupapiurl.SelectionStart = 0;
            this.tb_backupapiurl.ShortcutsEnabled = true;
            this.tb_backupapiurl.Size = new System.Drawing.Size(741, 48);
            this.tb_backupapiurl.TabIndex = 72;
            this.tb_backupapiurl.TabStop = false;
            this.tb_backupapiurl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_backupapiurl.TrailingIcon = null;
            this.tb_backupapiurl.UseSystemPasswordChar = false;
            // 
            // bt_signout
            // 
            this.bt_signout.AutoSize = false;
            this.bt_signout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_signout.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_signout.Depth = 0;
            this.bt_signout.HighEmphasis = true;
            this.bt_signout.Icon = null;
            this.bt_signout.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_signout.Location = new System.Drawing.Point(306, 11);
            this.bt_signout.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_signout.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_signout.Name = "bt_signout";
            this.bt_signout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_signout.Size = new System.Drawing.Size(229, 53);
            this.bt_signout.TabIndex = 16;
            this.bt_signout.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_signout.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_signout.UseAccentColor = false;
            this.bt_signout.UseVisualStyleBackColor = true;
            this.bt_signout.Click += new System.EventHandler(this.bt_signout_Click);
            // 
            // bt_changeTheme
            // 
            this.bt_changeTheme.AutoSize = false;
            this.bt_changeTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_changeTheme.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_changeTheme.Depth = 0;
            this.bt_changeTheme.HighEmphasis = true;
            this.bt_changeTheme.Icon = null;
            this.bt_changeTheme.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_changeTheme.Location = new System.Drawing.Point(51, 11);
            this.bt_changeTheme.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_changeTheme.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_changeTheme.Name = "bt_changeTheme";
            this.bt_changeTheme.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_changeTheme.Size = new System.Drawing.Size(229, 53);
            this.bt_changeTheme.TabIndex = 15;
            this.bt_changeTheme.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_changeTheme.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_changeTheme.UseAccentColor = false;
            this.bt_changeTheme.UseVisualStyleBackColor = true;
            this.bt_changeTheme.Click += new System.EventHandler(this.materialButton7_Click);
            // 
            // menuIconList
            // 
            this.menuIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "round_assessment_white_24dp.png");
            this.menuIconList.Images.SetKeyName(1, "round_backup_white_24dp.png");
            this.menuIconList.Images.SetKeyName(2, "round_bluetooth_white_24dp.png");
            this.menuIconList.Images.SetKeyName(3, "round_bookmark_white_24dp.png");
            this.menuIconList.Images.SetKeyName(4, "round_build_white_24dp.png");
            this.menuIconList.Images.SetKeyName(5, "round_gps_fixed_white_24dp.png");
            this.menuIconList.Images.SetKeyName(6, "round_http_white_24dp.png");
            this.menuIconList.Images.SetKeyName(7, "round_report_problem_white_24dp.png");
            this.menuIconList.Images.SetKeyName(8, "round_swap_vert_white_24dp.png");
            this.menuIconList.Images.SetKeyName(9, "round_phone_black_24dp.png");
            this.menuIconList.Images.SetKeyName(10, "round_push_pin_black_24dp.png");
            this.menuIconList.Images.SetKeyName(11, "round_mail_outline_black_24dp.png");
            this.menuIconList.Images.SetKeyName(12, "round_person_black_24dp.png");
            this.menuIconList.Images.SetKeyName(13, "round_add_a_photo_black_24dp.png");
            this.menuIconList.Images.SetKeyName(14, "round_alternate_email_black_24dp.png");
            this.menuIconList.Images.SetKeyName(15, "round_cancel_black_24dp.png");
            this.menuIconList.Images.SetKeyName(16, "round_error_black_24dp.png");
            this.menuIconList.Images.SetKeyName(17, "round_event_black_24dp.png");
            this.menuIconList.Images.SetKeyName(18, "arrow-autofit-right.png");
            this.menuIconList.Images.SetKeyName(19, "arrow-autofit-left.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 783);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(550, 369);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(6, 118, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AU-X Wallet";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabAsset.ResumeLayout(false);
            this.tabAsset.PerformLayout();
            this.tabLockAsset.ResumeLayout(false);
            this.tabContacts.ResumeLayout(false);
            this.tabInHistory.ResumeLayout(false);
            this.tabOutHistory.ResumeLayout(false);
            this.tabSignature.ResumeLayout(false);
            this.tabSignature.PerformLayout();
            this.tabSetting.ResumeLayout(false);
            this.tabSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabAsset;
        private System.Windows.Forms.TabPage tabInHistory;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.TabPage tabContacts;
        private ImageList menuIconList;
        private MaterialListBox lb_assets;
        private MaterialButton bt_changeTheme;
        private MaterialButton bt_signout;
        private MaterialButton bt_saveApiUrl;
        private MaterialLabel lb_baseurl;
        private MaterialTextBoxEdit tb_backupapiurl;
        private MaterialLabel lb_viewKey;
        private MaterialButton bt_viewKey;
        private MaterialTextBoxEdit tb_pwd;
        private MaterialTextBoxEdit tb_privateKey;
        private MaterialTextBoxEdit tb_publicKey;
        private MaterialTextBoxEdit tb_Address;
        private MaterialButton bt_queryAsset;
        private System.Windows.Forms.TabPage tabOutHistory;
        private MaterialButton bt_queryInHistory;
        private MaterialListBox lb_outHistory;
        private MaterialListBox lb_inHistory;
        private MaterialButton bt_queryOutHistory;
        private MaterialListBox lb_contacts;
        private MaterialButton bt_addContact;
        private MaterialButton bt_copyAddress;
        private MaterialLabel lb_title_unavailable;
        private MaterialLabel lb_title_available;
        private MaterialLabel lb_unavailable;
        private MaterialLabel lb_available;
        private MaterialButton bt_claim;
        private MaterialButton bt_dig;
        private System.Windows.Forms.TabPage tabSignature;
        private MaterialButton bt_signature;
        private MaterialRadioButton rb_hex;
        private MaterialRadioButton rb_text;
        private MaterialMultiLineTextBoxEdit tb_output;
        private MaterialMultiLineTextBoxEdit tb_input;
        private MaterialButton bt_copy;
        private System.Windows.Forms.TabPage tabLockAsset;
        private MaterialButton bt_RefreshLockAsset;
        private MaterialListBox lb_lockAssets;
    }
}