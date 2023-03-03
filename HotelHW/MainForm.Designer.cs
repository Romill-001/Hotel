namespace HotelHW
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomNum = new System.Windows.Forms.Label();
            this.ReservedStatus = new System.Windows.Forms.RadioButton();
            this.FreeStatus = new System.Windows.Forms.RadioButton();
            this.AccupiedStatus = new System.Windows.Forms.RadioButton();
            this.LeavingStatus = new System.Windows.Forms.RadioButton();
            this.stlabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AllStatuses = new System.Windows.Forms.RadioButton();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ClientsList = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.GBDateOfLeaving = new System.Windows.Forms.GroupBox();
            this.DateOfLeaving = new System.Windows.Forms.Label();
            this.GBDateOfEnter = new System.Windows.Forms.GroupBox();
            this.DateOfEnter = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.CurrentStatusLabel = new System.Windows.Forms.Label();
            this.PictureOfClient = new System.Windows.Forms.PictureBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.ShowCardButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsList)).BeginInit();
            this.GBDateOfLeaving.SuspendLayout();
            this.GBDateOfEnter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOfClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(14, 16);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(85, 25);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "СТАТУС";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "СПИСОК ГОСТЕЙ";
            // 
            // RoomNum
            // 
            this.RoomNum.AutoSize = true;
            this.RoomNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomNum.Location = new System.Drawing.Point(5, 16);
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.Size = new System.Drawing.Size(112, 25);
            this.RoomNum.TabIndex = 2;
            this.RoomNum.Text = "НОМЕР №";
            // 
            // ReservedStatus
            // 
            this.ReservedStatus.AutoSize = true;
            this.ReservedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReservedStatus.Location = new System.Drawing.Point(5, 54);
            this.ReservedStatus.Name = "ReservedStatus";
            this.ReservedStatus.Size = new System.Drawing.Size(146, 20);
            this.ReservedStatus.TabIndex = 3;
            this.ReservedStatus.Text = "Зарезервировано";
            this.ReservedStatus.UseVisualStyleBackColor = true;
            this.ReservedStatus.CheckedChanged += new System.EventHandler(this.ReservedStatus_CheckedChanged);
            // 
            // FreeStatus
            // 
            this.FreeStatus.AutoSize = true;
            this.FreeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreeStatus.Location = new System.Drawing.Point(5, 80);
            this.FreeStatus.Name = "FreeStatus";
            this.FreeStatus.Size = new System.Drawing.Size(90, 20);
            this.FreeStatus.TabIndex = 4;
            this.FreeStatus.Text = "Свободно";
            this.FreeStatus.UseVisualStyleBackColor = true;
            this.FreeStatus.CheckedChanged += new System.EventHandler(this.FreeStatus_CheckedChanged);
            // 
            // AccupiedStatus
            // 
            this.AccupiedStatus.AutoSize = true;
            this.AccupiedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccupiedStatus.Location = new System.Drawing.Point(5, 106);
            this.AccupiedStatus.Name = "AccupiedStatus";
            this.AccupiedStatus.Size = new System.Drawing.Size(72, 20);
            this.AccupiedStatus.TabIndex = 5;
            this.AccupiedStatus.Text = "Занято";
            this.AccupiedStatus.UseVisualStyleBackColor = true;
            this.AccupiedStatus.CheckedChanged += new System.EventHandler(this.AccupiedStatus_CheckedChanged);
            // 
            // LeavingStatus
            // 
            this.LeavingStatus.AutoSize = true;
            this.LeavingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeavingStatus.Location = new System.Drawing.Point(5, 132);
            this.LeavingStatus.Name = "LeavingStatus";
            this.LeavingStatus.Size = new System.Drawing.Size(120, 20);
            this.LeavingStatus.TabIndex = 6;
            this.LeavingStatus.Text = "Выписывается";
            this.LeavingStatus.UseVisualStyleBackColor = true;
            this.LeavingStatus.CheckedChanged += new System.EventHandler(this.LeavingStatus_CheckedChanged);
            // 
            // stlabel
            // 
            this.stlabel.AutoSize = true;
            this.stlabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stlabel.Location = new System.Drawing.Point(19, 241);
            this.stlabel.Name = "stlabel";
            this.stlabel.Size = new System.Drawing.Size(80, 22);
            this.stlabel.TabIndex = 7;
            this.stlabel.Text = "СТАТУС:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(6, 13);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(326, 15);
            this.SearchTextBox.TabIndex = 8;
            this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBoxClick);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.Location = new System.Drawing.Point(6, 12);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(56, 16);
            this.SearchLabel.TabIndex = 9;
            this.SearchLabel.Text = "Поиск...";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.SystemColors.Window;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(6, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(106, 18);
            this.TimeLabel.TabIndex = 10;
            this.TimeLabel.Text = "00 : 00 : 00 AM";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.TimeLabel);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(34, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 34);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = global::HotelHW.Properties.Resources.icons8_time_22;
            this.pictureBox2.Location = new System.Drawing.Point(118, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Controls.Add(this.SearchLabel);
            this.groupBox2.Controls.Add(this.SearchTextBox);
            this.groupBox2.Location = new System.Drawing.Point(301, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 34);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Window;
            this.SearchButton.BackgroundImage = global::HotelHW.Properties.Resources.icons8_search_22;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SearchButton.Location = new System.Drawing.Point(340, 7);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(26, 25);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(-2, 45);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.AllStatuses);
            this.splitContainer1.Panel1.Controls.Add(this.splitter3);
            this.splitContainer1.Panel1.Controls.Add(this.StatusLabel);
            this.splitContainer1.Panel1.Controls.Add(this.LeavingStatus);
            this.splitContainer1.Panel1.Controls.Add(this.FreeStatus);
            this.splitContainer1.Panel1.Controls.Add(this.AccupiedStatus);
            this.splitContainer1.Panel1.Controls.Add(this.ReservedStatus);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(940, 497);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 17;
            // 
            // AllStatuses
            // 
            this.AllStatuses.AutoSize = true;
            this.AllStatuses.Checked = true;
            this.AllStatuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllStatuses.Location = new System.Drawing.Point(5, 158);
            this.AllStatuses.Name = "AllStatuses";
            this.AllStatuses.Size = new System.Drawing.Size(49, 20);
            this.AllStatuses.TabIndex = 8;
            this.AllStatuses.TabStop = true;
            this.AllStatuses.Text = "Все";
            this.AllStatuses.UseVisualStyleBackColor = true;
            this.AllStatuses.CheckedChanged += new System.EventHandler(this.AllStatuses_CheckedChanged);
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(198, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(2, 497);
            this.splitter3.TabIndex = 7;
            this.splitter3.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer2.Panel1.Controls.Add(this.ClientsList);
            this.splitContainer2.Panel1.Controls.Add(this.splitter4);
            this.splitContainer2.Panel1.Controls.Add(this.splitter1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1MinSize = 380;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer2.Panel2.Controls.Add(this.GBDateOfLeaving);
            this.splitContainer2.Panel2.Controls.Add(this.GBDateOfEnter);
            this.splitContainer2.Panel2.Controls.Add(this.FullNameLabel);
            this.splitContainer2.Panel2.Controls.Add(this.CurrentStatusLabel);
            this.splitContainer2.Panel2.Controls.Add(this.PictureOfClient);
            this.splitContainer2.Panel2.Controls.Add(this.splitter2);
            this.splitContainer2.Panel2.Controls.Add(this.RoomNum);
            this.splitContainer2.Panel2.Controls.Add(this.stlabel);
            this.splitContainer2.Panel2.Controls.Add(this.ShowCardButton);
            this.splitContainer2.Panel2MinSize = 300;
            this.splitContainer2.Size = new System.Drawing.Size(736, 497);
            this.splitContainer2.SplitterDistance = 427;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 0;
            // 
            // ClientsList
            // 
            this.ClientsList.AllowUserToAddRows = false;
            this.ClientsList.AllowUserToDeleteRows = false;
            this.ClientsList.AllowUserToResizeColumns = false;
            this.ClientsList.AllowUserToResizeRows = false;
            this.ClientsList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClientsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ClientsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.ClientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullName,
            this.Status,
            this.Room});
            this.ClientsList.Location = new System.Drawing.Point(62, 54);
            this.ClientsList.MultiSelect = false;
            this.ClientsList.Name = "ClientsList";
            this.ClientsList.ReadOnly = true;
            this.ClientsList.RowHeadersVisible = false;
            this.ClientsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsList.Size = new System.Drawing.Size(313, 442);
            this.ClientsList.TabIndex = 4;
            this.ClientsList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClientsList_CellMouseDoubleClick);
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Имя";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Width = 140;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 120;
            // 
            // Room
            // 
            this.Room.HeaderText = "Номер";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            this.Room.Width = 50;
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter4.Enabled = false;
            this.splitter4.Location = new System.Drawing.Point(425, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(2, 497);
            this.splitter4.TabIndex = 3;
            this.splitter4.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 497);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // GBDateOfLeaving
            // 
            this.GBDateOfLeaving.Controls.Add(this.DateOfLeaving);
            this.GBDateOfLeaving.Location = new System.Drawing.Point(23, 384);
            this.GBDateOfLeaving.Name = "GBDateOfLeaving";
            this.GBDateOfLeaving.Size = new System.Drawing.Size(200, 50);
            this.GBDateOfLeaving.TabIndex = 14;
            this.GBDateOfLeaving.TabStop = false;
            this.GBDateOfLeaving.Text = "Дата выезда:";
            // 
            // DateOfLeaving
            // 
            this.DateOfLeaving.AutoSize = true;
            this.DateOfLeaving.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfLeaving.Location = new System.Drawing.Point(6, 16);
            this.DateOfLeaving.Name = "DateOfLeaving";
            this.DateOfLeaving.Size = new System.Drawing.Size(37, 21);
            this.DateOfLeaving.TabIndex = 0;
            this.DateOfLeaving.Text = "123";
            // 
            // GBDateOfEnter
            // 
            this.GBDateOfEnter.Controls.Add(this.DateOfEnter);
            this.GBDateOfEnter.Location = new System.Drawing.Point(23, 319);
            this.GBDateOfEnter.Name = "GBDateOfEnter";
            this.GBDateOfEnter.Size = new System.Drawing.Size(200, 50);
            this.GBDateOfEnter.TabIndex = 13;
            this.GBDateOfEnter.TabStop = false;
            this.GBDateOfEnter.Text = "Дата заезда:";
            // 
            // DateOfEnter
            // 
            this.DateOfEnter.AutoSize = true;
            this.DateOfEnter.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfEnter.Location = new System.Drawing.Point(6, 16);
            this.DateOfEnter.Name = "DateOfEnter";
            this.DateOfEnter.Size = new System.Drawing.Size(37, 21);
            this.DateOfEnter.TabIndex = 0;
            this.DateOfEnter.Text = "123";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(23, 278);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(53, 24);
            this.FullNameLabel.TabIndex = 12;
            this.FullNameLabel.Text = "ФИО";
            // 
            // CurrentStatusLabel
            // 
            this.CurrentStatusLabel.AutoSize = true;
            this.CurrentStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentStatusLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentStatusLabel.Location = new System.Drawing.Point(105, 241);
            this.CurrentStatusLabel.Name = "CurrentStatusLabel";
            this.CurrentStatusLabel.Size = new System.Drawing.Size(42, 24);
            this.CurrentStatusLabel.TabIndex = 11;
            this.CurrentStatusLabel.Text = "123";
            // 
            // PictureOfClient
            // 
            this.PictureOfClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureOfClient.BackColor = System.Drawing.SystemColors.Window;
            this.PictureOfClient.ImageLocation = "";
            this.PictureOfClient.Location = new System.Drawing.Point(93, 54);
            this.PictureOfClient.Name = "PictureOfClient";
            this.PictureOfClient.Size = new System.Drawing.Size(150, 150);
            this.PictureOfClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureOfClient.TabIndex = 10;
            this.PictureOfClient.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(2, 497);
            this.splitter2.TabIndex = 8;
            this.splitter2.TabStop = false;
            // 
            // ShowCardButton
            // 
            this.ShowCardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCardButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCardButton.Location = new System.Drawing.Point(131, 452);
            this.ShowCardButton.Name = "ShowCardButton";
            this.ShowCardButton.Size = new System.Drawing.Size(162, 32);
            this.ShowCardButton.TabIndex = 9;
            this.ShowCardButton.Text = "Просмотр карточки";
            this.ShowCardButton.UseVisualStyleBackColor = true;
            this.ShowCardButton.Visible = false;
            this.ShowCardButton.Click += new System.EventHandler(this.ShowCardButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HotelHW.Properties.Resources.icons8_squared_menu_30;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(950, 580);
            this.Name = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsList)).EndInit();
            this.GBDateOfLeaving.ResumeLayout(false);
            this.GBDateOfLeaving.PerformLayout();
            this.GBDateOfEnter.ResumeLayout(false);
            this.GBDateOfEnter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOfClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RoomNum;
        private System.Windows.Forms.RadioButton ReservedStatus;
        private System.Windows.Forms.RadioButton FreeStatus;
        private System.Windows.Forms.RadioButton AccupiedStatus;
        private System.Windows.Forms.RadioButton LeavingStatus;
        private System.Windows.Forms.Label stlabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button ShowCardButton;
        private System.Windows.Forms.PictureBox PictureOfClient;
        private System.Windows.Forms.Label CurrentStatusLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.GroupBox GBDateOfLeaving;
        private System.Windows.Forms.Label DateOfLeaving;
        private System.Windows.Forms.GroupBox GBDateOfEnter;
        private System.Windows.Forms.Label DateOfEnter;
        private System.Windows.Forms.DataGridView ClientsList;
        private System.Windows.Forms.RadioButton AllStatuses;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
    }
}

