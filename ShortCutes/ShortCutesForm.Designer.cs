﻿namespace ShortCutes
{
    partial class ShortCutes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortCutes));
            this.label5 = new System.Windows.Forms.Label();
            this.GameExplorerBtn = new System.Windows.Forms.Button();
            this.EmuExplorerBtn = new System.Windows.Forms.Button();
            this.ShortCuteNameTxB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmulatorsCbB = new System.Windows.Forms.ComboBox();
            this.EmuDirTxB = new System.Windows.Forms.TextBox();
            this.GameDirTxB = new System.Windows.Forms.TextBox();
            this.createshortbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelBorderStyle = new System.Windows.Forms.Panel();
            this.HistoryBtn = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.ConfigBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.miniBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.OpenFolder = new System.Windows.Forms.Button();
            this.ICOurl = new System.Windows.Forms.TextBox();
            this.ICOpic = new System.Windows.Forms.PictureBox();
            this.ClearSCSelected = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.forceWindowToNotWait = new System.Windows.Forms.CheckBox();
            this.armoryCrateLauncher = new System.Windows.Forms.CheckBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panelBorderStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICOpic)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(443, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 35);
            this.label5.TabIndex = 27;
            this.label5.Text = "Select an  image to set as the shortcut ICON\r\nDouble click to crop selected image" +
    "";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameExplorerBtn
            // 
            this.GameExplorerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.GameExplorerBtn.FlatAppearance.BorderSize = 0;
            this.GameExplorerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(116)))), ((int)(((byte)(128)))));
            this.GameExplorerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameExplorerBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold);
            this.GameExplorerBtn.ForeColor = System.Drawing.Color.White;
            this.GameExplorerBtn.Location = new System.Drawing.Point(302, 265);
            this.GameExplorerBtn.Name = "GameExplorerBtn";
            this.GameExplorerBtn.Size = new System.Drawing.Size(119, 35);
            this.GameExplorerBtn.TabIndex = 3;
            this.GameExplorerBtn.Text = "Select Game";
            this.GameExplorerBtn.UseVisualStyleBackColor = false;
            this.GameExplorerBtn.Click += new System.EventHandler(this.GameBrow_Click);
            // 
            // EmuExplorerBtn
            // 
            this.EmuExplorerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.EmuExplorerBtn.FlatAppearance.BorderSize = 0;
            this.EmuExplorerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(116)))), ((int)(((byte)(128)))));
            this.EmuExplorerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmuExplorerBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold);
            this.EmuExplorerBtn.ForeColor = System.Drawing.Color.White;
            this.EmuExplorerBtn.Location = new System.Drawing.Point(302, 196);
            this.EmuExplorerBtn.Name = "EmuExplorerBtn";
            this.EmuExplorerBtn.Size = new System.Drawing.Size(119, 35);
            this.EmuExplorerBtn.TabIndex = 2;
            this.EmuExplorerBtn.Text = "Select Emulator";
            this.EmuExplorerBtn.UseVisualStyleBackColor = false;
            this.EmuExplorerBtn.Click += new System.EventHandler(this.EmuBrow_Click);
            // 
            // ShortCuteNameTxB
            // 
            this.ShortCuteNameTxB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ShortCuteNameTxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShortCuteNameTxB.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.ShortCuteNameTxB.ForeColor = System.Drawing.Color.White;
            this.ShortCuteNameTxB.Location = new System.Drawing.Point(14, 133);
            this.ShortCuteNameTxB.MaxLength = 50;
            this.ShortCuteNameTxB.Multiline = true;
            this.ShortCuteNameTxB.Name = "ShortCuteNameTxB";
            this.ShortCuteNameTxB.Size = new System.Drawing.Size(254, 25);
            this.ShortCuteNameTxB.TabIndex = 1;
            this.ShortCuteNameTxB.TextChanged += new System.EventHandler(this.ShortCuteName_TextChanged);
            this.ShortCuteNameTxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ICOurl_KeyDown);
            this.ShortCuteNameTxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShortCuteName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Shortcut name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Select an emulator:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Game File Directory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Emulator Directory:";
            // 
            // EmulatorsCbB
            // 
            this.EmulatorsCbB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EmulatorsCbB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmulatorsCbB.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 11F);
            this.EmulatorsCbB.ForeColor = System.Drawing.Color.White;
            this.EmulatorsCbB.FormattingEnabled = true;
            this.EmulatorsCbB.Location = new System.Drawing.Point(14, 73);
            this.EmulatorsCbB.MaxDropDownItems = 10;
            this.EmulatorsCbB.Name = "EmulatorsCbB";
            this.EmulatorsCbB.Size = new System.Drawing.Size(176, 26);
            this.EmulatorsCbB.TabIndex = 6;
            this.EmulatorsCbB.SelectedIndexChanged += new System.EventHandler(this.Emulatorcb_SelectedIndexChanged);
            // 
            // EmuDirTxB
            // 
            this.EmuDirTxB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.EmuDirTxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmuDirTxB.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmuDirTxB.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 9F);
            this.EmuDirTxB.ForeColor = System.Drawing.Color.White;
            this.EmuDirTxB.Location = new System.Drawing.Point(14, 196);
            this.EmuDirTxB.Multiline = true;
            this.EmuDirTxB.Name = "EmuDirTxB";
            this.EmuDirTxB.ReadOnly = true;
            this.EmuDirTxB.Size = new System.Drawing.Size(254, 35);
            this.EmuDirTxB.TabIndex = 14;
            this.EmuDirTxB.TabStop = false;
            this.EmuDirTxB.Text = " ";
            this.EmuDirTxB.Click += new System.EventHandler(this.EmuBrow_Click);
            this.EmuDirTxB.TextChanged += new System.EventHandler(this.EmuGameDirbox_TextChanged);
            // 
            // GameDirTxB
            // 
            this.GameDirTxB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.GameDirTxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameDirTxB.Cursor = System.Windows.Forms.Cursors.Default;
            this.GameDirTxB.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 9F);
            this.GameDirTxB.ForeColor = System.Drawing.Color.White;
            this.GameDirTxB.Location = new System.Drawing.Point(14, 265);
            this.GameDirTxB.Multiline = true;
            this.GameDirTxB.Name = "GameDirTxB";
            this.GameDirTxB.ReadOnly = true;
            this.GameDirTxB.Size = new System.Drawing.Size(254, 35);
            this.GameDirTxB.TabIndex = 15;
            this.GameDirTxB.TabStop = false;
            this.GameDirTxB.Click += new System.EventHandler(this.GameBrow_Click);
            this.GameDirTxB.TextChanged += new System.EventHandler(this.EmuGameDirbox_TextChanged);
            // 
            // createshortbtn
            // 
            this.createshortbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.createshortbtn.FlatAppearance.BorderSize = 0;
            this.createshortbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(116)))), ((int)(((byte)(128)))));
            this.createshortbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createshortbtn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.createshortbtn.ForeColor = System.Drawing.Color.White;
            this.createshortbtn.Location = new System.Drawing.Point(12, 348);
            this.createshortbtn.Name = "createshortbtn";
            this.createshortbtn.Size = new System.Drawing.Size(409, 65);
            this.createshortbtn.TabIndex = 4;
            this.createshortbtn.Text = "Create ShortCute";
            this.createshortbtn.UseVisualStyleBackColor = false;
            this.createshortbtn.Click += new System.EventHandler(this.CreateShortCute_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(199, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 44);
            this.label6.TabIndex = 28;
            this.label6.Text = "Opening \'.exe\' emulator will auto-select it";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBorderStyle
            // 
            this.panelBorderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panelBorderStyle.Controls.Add(this.HistoryBtn);
            this.panelBorderStyle.Controls.Add(this.InfoButton);
            this.panelBorderStyle.Controls.Add(this.ConfigBtn);
            this.panelBorderStyle.Controls.Add(this.label7);
            this.panelBorderStyle.Controls.Add(this.miniBtn);
            this.panelBorderStyle.Controls.Add(this.closeBtn);
            this.panelBorderStyle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorderStyle.Location = new System.Drawing.Point(0, 0);
            this.panelBorderStyle.Name = "panelBorderStyle";
            this.panelBorderStyle.Size = new System.Drawing.Size(760, 42);
            this.panelBorderStyle.TabIndex = 29;
            this.panelBorderStyle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.HistoryBtn.BackgroundImage = global::ShortCutes.Properties.Resources.SCHistory;
            this.HistoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HistoryBtn.FlatAppearance.BorderSize = 0;
            this.HistoryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.HistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.HistoryBtn.Location = new System.Drawing.Point(602, 4);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(35, 35);
            this.HistoryBtn.TabIndex = 5;
            this.HistoryBtn.TabStop = false;
            this.toolTip.SetToolTip(this.HistoryBtn, "History");
            this.HistoryBtn.UseVisualStyleBackColor = false;
            this.HistoryBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.InfoButton.BackgroundImage = global::ShortCutes.Properties.Resources.infobtn;
            this.InfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InfoButton.FlatAppearance.BorderSize = 0;
            this.InfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.InfoButton.Location = new System.Drawing.Point(564, 4);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(35, 35);
            this.InfoButton.TabIndex = 4;
            this.InfoButton.TabStop = false;
            this.toolTip.SetToolTip(this.InfoButton, "ShortCutes Information");
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // ConfigBtn
            // 
            this.ConfigBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.ConfigBtn.BackgroundImage = global::ShortCutes.Properties.Resources.config;
            this.ConfigBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConfigBtn.FlatAppearance.BorderSize = 0;
            this.ConfigBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.ConfigBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfigBtn.Location = new System.Drawing.Point(640, 4);
            this.ConfigBtn.Name = "ConfigBtn";
            this.ConfigBtn.Size = new System.Drawing.Size(35, 35);
            this.ConfigBtn.TabIndex = 3;
            this.ConfigBtn.TabStop = false;
            this.toolTip.SetToolTip(this.ConfigBtn, "Configuration");
            this.ConfigBtn.UseVisualStyleBackColor = false;
            this.ConfigBtn.Click += new System.EventHandler(this.ConfigBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 33);
            this.label7.TabIndex = 2;
            this.label7.Text = "ShortCutes";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            // 
            // miniBtn
            // 
            this.miniBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.miniBtn.BackgroundImage = global::ShortCutes.Properties.Resources.minimizebtn;
            this.miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniBtn.FlatAppearance.BorderSize = 0;
            this.miniBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.miniBtn.Location = new System.Drawing.Point(682, 4);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(35, 35);
            this.miniBtn.TabIndex = 0;
            this.miniBtn.TabStop = false;
            this.miniBtn.UseVisualStyleBackColor = false;
            this.miniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.closeBtn.BackgroundImage = global::ShortCutes.Properties.Resources.closebtn;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(719, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 35);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // OpenFolder
            // 
            this.OpenFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.OpenFolder.FlatAppearance.BorderSize = 0;
            this.OpenFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.OpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFolder.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFolder.ForeColor = System.Drawing.Color.White;
            this.OpenFolder.Location = new System.Drawing.Point(302, 314);
            this.OpenFolder.Margin = new System.Windows.Forms.Padding(0);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(119, 21);
            this.OpenFolder.TabIndex = 32;
            this.OpenFolder.TabStop = false;
            this.OpenFolder.Text = "Open ShortCutes Folder";
            this.OpenFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.OpenFolder.UseVisualStyleBackColor = false;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // ICOurl
            // 
            this.ICOurl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ICOurl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ICOurl.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 11F);
            this.ICOurl.ForeColor = System.Drawing.Color.White;
            this.ICOurl.Location = new System.Drawing.Point(446, 389);
            this.ICOurl.Multiline = true;
            this.ICOurl.Name = "ICOurl";
            this.ICOurl.Size = new System.Drawing.Size(300, 22);
            this.ICOurl.TabIndex = 30;
            this.ICOurl.Text = "or paste an image or an URL here...";
            this.ICOurl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ICOurl.TextChanged += new System.EventHandler(this.ICOurl_TextChanged);
            this.ICOurl.Enter += new System.EventHandler(this.ICOurl_Enter);
            this.ICOurl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ICOurl_KeyDown);
            this.ICOurl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ICOurl_KeyPress);
            this.ICOurl.Leave += new System.EventHandler(this.ICOurl_Leave);
            // 
            // ICOpic
            // 
            this.ICOpic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ICOpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ICOpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ICOpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ICOpic.Location = new System.Drawing.Point(446, 83);
            this.ICOpic.Name = "ICOpic";
            this.ICOpic.Size = new System.Drawing.Size(300, 300);
            this.ICOpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ICOpic.TabIndex = 26;
            this.ICOpic.TabStop = false;
            this.ICOpic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ICOpic_MouseClick);
            this.ICOpic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ICOpic_MouseDoubleClick);
            // 
            // ClearSCSelected
            // 
            this.ClearSCSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            this.ClearSCSelected.FlatAppearance.BorderSize = 0;
            this.ClearSCSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(116)))), ((int)(((byte)(128)))));
            this.ClearSCSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearSCSelected.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold);
            this.ClearSCSelected.ForeColor = System.Drawing.Color.White;
            this.ClearSCSelected.Location = new System.Drawing.Point(302, 123);
            this.ClearSCSelected.Name = "ClearSCSelected";
            this.ClearSCSelected.Size = new System.Drawing.Size(119, 35);
            this.ClearSCSelected.TabIndex = 31;
            this.ClearSCSelected.Text = "Clean Data";
            this.toolTip.SetToolTip(this.ClearSCSelected, "Cleans UI from selected history data");
            this.ClearSCSelected.UseVisualStyleBackColor = false;
            this.ClearSCSelected.Visible = false;
            this.ClearSCSelected.Click += new System.EventHandler(this.ClearSCSelected_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 250;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 250;
            this.toolTip.ReshowDelay = 50;
            // 
            // forceWindowToNotWait
            // 
            this.forceWindowToNotWait.AutoSize = true;
            this.forceWindowToNotWait.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F);
            this.forceWindowToNotWait.ForeColor = System.Drawing.Color.White;
            this.forceWindowToNotWait.Location = new System.Drawing.Point(12, 315);
            this.forceWindowToNotWait.Name = "forceWindowToNotWait";
            this.forceWindowToNotWait.Size = new System.Drawing.Size(139, 18);
            this.forceWindowToNotWait.TabIndex = 33;
            this.forceWindowToNotWait.Text = "Force launcher to close";
            this.toolTip.SetToolTip(this.forceWindowToNotWait, "Forces ShortCute launcher to close when the emulator exe has already opened");
            this.forceWindowToNotWait.UseVisualStyleBackColor = true;
            // 
            // armoryCrateLauncher
            // 
            this.armoryCrateLauncher.AutoSize = true;
            this.armoryCrateLauncher.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F);
            this.armoryCrateLauncher.ForeColor = System.Drawing.Color.White;
            this.armoryCrateLauncher.Location = new System.Drawing.Point(157, 315);
            this.armoryCrateLauncher.Name = "armoryCrateLauncher";
            this.armoryCrateLauncher.Size = new System.Drawing.Size(135, 18);
            this.armoryCrateLauncher.TabIndex = 34;
            this.armoryCrateLauncher.Text = "Armory Crate launcher";
            this.toolTip.SetToolTip(this.armoryCrateLauncher, "Enables compatibility with Armory Crate game profiles");
            this.armoryCrateLauncher.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ShortCutes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(760, 420);
            this.ControlBox = false;
            this.Controls.Add(this.armoryCrateLauncher);
            this.Controls.Add(this.OpenFolder);
            this.Controls.Add(this.forceWindowToNotWait);
            this.Controls.Add(this.ClearSCSelected);
            this.Controls.Add(this.ICOurl);
            this.Controls.Add(this.panelBorderStyle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ICOpic);
            this.Controls.Add(this.GameExplorerBtn);
            this.Controls.Add(this.EmuExplorerBtn);
            this.Controls.Add(this.ShortCuteNameTxB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmulatorsCbB);
            this.Controls.Add(this.EmuDirTxB);
            this.Controls.Add(this.GameDirTxB);
            this.Controls.Add(this.createshortbtn);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShortCutes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShortCutes";
            this.Shown += new System.EventHandler(this.ShortCutes_Shown);
            this.Click += new System.EventHandler(this.Shortcutbox_Focus);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShortCutes_Paint);
            this.panelBorderStyle.ResumeLayout(false);
            this.panelBorderStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICOpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ICOpic;
        private System.Windows.Forms.Button GameExplorerBtn;
        private System.Windows.Forms.Button EmuExplorerBtn;
        private System.Windows.Forms.TextBox ShortCuteNameTxB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EmulatorsCbB;
        private System.Windows.Forms.TextBox EmuDirTxB;
        private System.Windows.Forms.TextBox GameDirTxB;
        private System.Windows.Forms.Button createshortbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelBorderStyle;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ICOurl;
        private System.Windows.Forms.Button ConfigBtn;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button HistoryBtn;
        private System.Windows.Forms.Button ClearSCSelected;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button OpenFolder;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox forceWindowToNotWait;
        private System.Windows.Forms.CheckBox armoryCrateLauncher;
    }
}

