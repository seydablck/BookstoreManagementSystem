namespace BookstoreManagementSystem_Test
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabPage_Customer = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_select_customer = new System.Windows.Forms.Button();
            this.btn_update_customer = new System.Windows.Forms.Button();
            this.btn_delete_customer = new System.Windows.Forms.Button();
            this.dataGridView_customer = new System.Windows.Forms.DataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookstoreDataSet2 = new BookstoreManagementSystem_Test.BookstoreDataSet2();
            this.txt_customer_Address = new System.Windows.Forms.TextBox();
            this.txt_customer_Mail = new System.Windows.Forms.TextBox();
            this.txt_customer_ConNum = new System.Windows.Forms.TextBox();
            this.txt_customer_id = new System.Windows.Forms.TextBox();
            this.txt_customer_Name = new System.Windows.Forms.TextBox();
            this.btn_save_customer = new System.Windows.Forms.Button();
            this.customer_Address = new System.Windows.Forms.Label();
            this.customer_Mail = new System.Windows.Forms.Label();
            this.cutomer_ConNum = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.Label();
            this.customer_Name = new System.Windows.Forms.Label();
            this.tabPage_Music = new System.Windows.Forms.TabPage();
            this.btn_select_music = new System.Windows.Forms.Button();
            this.dataGridView_music = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showMusicDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookstoreDataSet4 = new BookstoreManagementSystem_Test.BookstoreDataSet4();
            this.txt_music_info = new System.Windows.Forms.TextBox();
            this.music_info = new System.Windows.Forms.Label();
            this.tabPage_Movie = new System.Windows.Forms.TabPage();
            this.btn_select_movie = new System.Windows.Forms.Button();
            this.dataGridView_movie = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showMovieDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookstoreDataSet = new BookstoreManagementSystem_Test.BookstoreDataSet();
            this.txt_movie_info = new System.Windows.Forms.TextBox();
            this.movie_info = new System.Windows.Forms.Label();
            this.tabPage_Book = new System.Windows.Forms.TabPage();
            this.btn_select_book = new System.Windows.Forms.Button();
            this.dataGridView_book = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showBookDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookstoreDataSet3 = new BookstoreManagementSystem_Test.BookstoreDataSet3();
            this.book_info = new System.Windows.Forms.Label();
            this.txt_book_info = new System.Windows.Forms.TextBox();
            this.tabPage_Product = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Music = new System.Windows.Forms.Button();
            this.btn_Movie = new System.Windows.Forms.Button();
            this.btn_Book = new System.Windows.Forms.Button();
            this.tabPage_Staff = new System.Windows.Forms.TabPage();
            this.btn_update_staff = new System.Windows.Forms.Button();
            this.btn_delete_staff = new System.Windows.Forms.Button();
            this.dataGridView_staff = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookstoreDataSet6 = new BookstoreManagementSystem_Test.BookstoreDataSet6();
            this.txt_staff_AccNum = new System.Windows.Forms.TextBox();
            this.txt_staff_BankName = new System.Windows.Forms.TextBox();
            this.txt_staff_JobTitle = new System.Windows.Forms.TextBox();
            this.txt_staff_id = new System.Windows.Forms.TextBox();
            this.txt_staff_LastName = new System.Windows.Forms.TextBox();
            this.txt_staff_FirstName = new System.Windows.Forms.TextBox();
            this.btn_save_staff = new System.Windows.Forms.Button();
            this.staff_AccNum = new System.Windows.Forms.Label();
            this.staff_BankName = new System.Windows.Forms.Label();
            this.staff_JobTitle = new System.Windows.Forms.Label();
            this.staff_id = new System.Windows.Forms.Label();
            this.staff_LastName = new System.Windows.Forms.Label();
            this.staff_FirstName = new System.Windows.Forms.Label();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookstoreDataSet1 = new BookstoreManagementSystem_Test.BookstoreDataSet1();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Payment = new System.Windows.Forms.TabPage();
            this.btn_select_payment = new System.Windows.Forms.Button();
            this.btn_update_pay = new System.Windows.Forms.Button();
            this.btn_delete_pay = new System.Windows.Forms.Button();
            this.btn_save_pay = new System.Windows.Forms.Button();
            this.dataGridView_payment = new System.Windows.Forms.DataGridView();
            this.paydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookstoreDataSet5 = new BookstoreManagementSystem_Test.BookstoreDataSet5();
            this.txt_pay_date = new System.Windows.Forms.TextBox();
            this.txt_pay_amt = new System.Windows.Forms.TextBox();
            this.txt_pay_id = new System.Windows.Forms.TextBox();
            this.pay_date = new System.Windows.Forms.Label();
            this.pay_amt = new System.Windows.Forms.Label();
            this.payment_id = new System.Windows.Forms.Label();
            this.showMovieDetailsTableAdapter = new BookstoreManagementSystem_Test.BookstoreDataSetTableAdapters.showMovieDetailsTableAdapter();
            this.staffTableAdapter = new BookstoreManagementSystem_Test.BookstoreDataSet1TableAdapters.StaffTableAdapter();
            this.customerTableAdapter = new BookstoreManagementSystem_Test.BookstoreDataSet2TableAdapters.CustomerTableAdapter();
            this.showBookDetailsTableAdapter = new BookstoreManagementSystem_Test.BookstoreDataSet3TableAdapters.showBookDetailsTableAdapter();
            this.showMusicDetailsTableAdapter = new BookstoreManagementSystem_Test.BookstoreDataSet4TableAdapters.showMusicDetailsTableAdapter();
            this.paymentTableAdapter = new BookstoreManagementSystem_Test.BookstoreDataSet5TableAdapters.PaymentTableAdapter();
            this.staffInfoTableAdapter = new BookstoreManagementSystem_Test.BookstoreDataSet6TableAdapters.StaffInfoTableAdapter();
            this.tabPage_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet2)).BeginInit();
            this.tabPage_Music.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_music)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showMusicDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet4)).BeginInit();
            this.tabPage_Movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_movie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showMovieDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet)).BeginInit();
            this.tabPage_Book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBookDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet3)).BeginInit();
            this.tabPage_Product.SuspendLayout();
            this.tabPage_Staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_Payment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage_Customer
            // 
            this.tabPage_Customer.Controls.Add(this.label2);
            this.tabPage_Customer.Controls.Add(this.btn_select_customer);
            this.tabPage_Customer.Controls.Add(this.btn_update_customer);
            this.tabPage_Customer.Controls.Add(this.btn_delete_customer);
            this.tabPage_Customer.Controls.Add(this.dataGridView_customer);
            this.tabPage_Customer.Controls.Add(this.txt_customer_Address);
            this.tabPage_Customer.Controls.Add(this.txt_customer_Mail);
            this.tabPage_Customer.Controls.Add(this.txt_customer_ConNum);
            this.tabPage_Customer.Controls.Add(this.txt_customer_id);
            this.tabPage_Customer.Controls.Add(this.txt_customer_Name);
            this.tabPage_Customer.Controls.Add(this.btn_save_customer);
            this.tabPage_Customer.Controls.Add(this.customer_Address);
            this.tabPage_Customer.Controls.Add(this.customer_Mail);
            this.tabPage_Customer.Controls.Add(this.cutomer_ConNum);
            this.tabPage_Customer.Controls.Add(this.customer_id);
            this.tabPage_Customer.Controls.Add(this.customer_Name);
            this.tabPage_Customer.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Customer.Name = "tabPage_Customer";
            this.tabPage_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Customer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage_Customer.Size = new System.Drawing.Size(817, 473);
            this.tabPage_Customer.TabIndex = 6;
            this.tabPage_Customer.Text = "Customer";
            this.tabPage_Customer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 43;
            // 
            // btn_select_customer
            // 
            this.btn_select_customer.Location = new System.Drawing.Point(566, 195);
            this.btn_select_customer.Name = "btn_select_customer";
            this.btn_select_customer.Size = new System.Drawing.Size(93, 26);
            this.btn_select_customer.TabIndex = 42;
            this.btn_select_customer.Text = "SELECT";
            this.btn_select_customer.UseVisualStyleBackColor = true;
            this.btn_select_customer.Click += new System.EventHandler(this.btn_select_customer_Click);
            // 
            // btn_update_customer
            // 
            this.btn_update_customer.Location = new System.Drawing.Point(566, 152);
            this.btn_update_customer.Name = "btn_update_customer";
            this.btn_update_customer.Size = new System.Drawing.Size(93, 23);
            this.btn_update_customer.TabIndex = 41;
            this.btn_update_customer.Text = "UPDATE";
            this.btn_update_customer.UseVisualStyleBackColor = true;
            this.btn_update_customer.Click += new System.EventHandler(this.btn_update_customer_Click);
            // 
            // btn_delete_customer
            // 
            this.btn_delete_customer.Location = new System.Drawing.Point(405, 195);
            this.btn_delete_customer.Name = "btn_delete_customer";
            this.btn_delete_customer.Size = new System.Drawing.Size(93, 23);
            this.btn_delete_customer.TabIndex = 40;
            this.btn_delete_customer.Text = "DELETE";
            this.btn_delete_customer.UseVisualStyleBackColor = true;
            this.btn_delete_customer.Click += new System.EventHandler(this.btn_delete_customer_Click);
            // 
            // dataGridView_customer
            // 
            this.dataGridView_customer.AutoGenerateColumns = false;
            this.dataGridView_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.contactnumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.dataGridView_customer.DataSource = this.customerBindingSource;
            this.dataGridView_customer.Location = new System.Drawing.Point(77, 239);
            this.dataGridView_customer.Name = "dataGridView_customer";
            this.dataGridView_customer.RowHeadersWidth = 51;
            this.dataGridView_customer.RowTemplate.Height = 24;
            this.dataGridView_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_customer.Size = new System.Drawing.Size(640, 198);
            this.dataGridView_customer.TabIndex = 39;
            this.dataGridView_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_customer_CellClick);
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.Width = 125;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customer_name";
            this.customernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactnumberDataGridViewTextBoxColumn
            // 
            this.contactnumberDataGridViewTextBoxColumn.DataPropertyName = "contact_number";
            this.contactnumberDataGridViewTextBoxColumn.HeaderText = "contact_number";
            this.contactnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactnumberDataGridViewTextBoxColumn.Name = "contactnumberDataGridViewTextBoxColumn";
            this.contactnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "adress";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.bookstoreDataSet2;
            // 
            // bookstoreDataSet2
            // 
            this.bookstoreDataSet2.DataSetName = "BookstoreDataSet2";
            this.bookstoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_customer_Address
            // 
            this.txt_customer_Address.Location = new System.Drawing.Point(541, 109);
            this.txt_customer_Address.Name = "txt_customer_Address";
            this.txt_customer_Address.Size = new System.Drawing.Size(136, 22);
            this.txt_customer_Address.TabIndex = 38;
            // 
            // txt_customer_Mail
            // 
            this.txt_customer_Mail.Location = new System.Drawing.Point(541, 58);
            this.txt_customer_Mail.Name = "txt_customer_Mail";
            this.txt_customer_Mail.Size = new System.Drawing.Size(136, 22);
            this.txt_customer_Mail.TabIndex = 37;
            // 
            // txt_customer_ConNum
            // 
            this.txt_customer_ConNum.Location = new System.Drawing.Point(189, 168);
            this.txt_customer_ConNum.Name = "txt_customer_ConNum";
            this.txt_customer_ConNum.Size = new System.Drawing.Size(136, 22);
            this.txt_customer_ConNum.TabIndex = 36;
            // 
            // txt_customer_id
            // 
            this.txt_customer_id.Location = new System.Drawing.Point(189, 109);
            this.txt_customer_id.Name = "txt_customer_id";
            this.txt_customer_id.Size = new System.Drawing.Size(136, 22);
            this.txt_customer_id.TabIndex = 35;
            // 
            // txt_customer_Name
            // 
            this.txt_customer_Name.Location = new System.Drawing.Point(189, 51);
            this.txt_customer_Name.Name = "txt_customer_Name";
            this.txt_customer_Name.Size = new System.Drawing.Size(136, 22);
            this.txt_customer_Name.TabIndex = 33;
            // 
            // btn_save_customer
            // 
            this.btn_save_customer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save_customer.Location = new System.Drawing.Point(405, 152);
            this.btn_save_customer.Name = "btn_save_customer";
            this.btn_save_customer.Size = new System.Drawing.Size(93, 23);
            this.btn_save_customer.TabIndex = 32;
            this.btn_save_customer.Text = "INSERT";
            this.btn_save_customer.UseVisualStyleBackColor = true;
            this.btn_save_customer.Click += new System.EventHandler(this.btn_save_customer_Click);
            // 
            // customer_Address
            // 
            this.customer_Address.AutoSize = true;
            this.customer_Address.Location = new System.Drawing.Point(426, 115);
            this.customer_Address.Name = "customer_Address";
            this.customer_Address.Size = new System.Drawing.Size(61, 16);
            this.customer_Address.TabIndex = 31;
            this.customer_Address.Text = "Address:";
            // 
            // customer_Mail
            // 
            this.customer_Mail.AutoSize = true;
            this.customer_Mail.Location = new System.Drawing.Point(426, 64);
            this.customer_Mail.Name = "customer_Mail";
            this.customer_Mail.Size = new System.Drawing.Size(48, 16);
            this.customer_Mail.TabIndex = 30;
            this.customer_Mail.Text = "E-Mail:";
            // 
            // cutomer_ConNum
            // 
            this.cutomer_ConNum.AutoSize = true;
            this.cutomer_ConNum.Location = new System.Drawing.Point(74, 173);
            this.cutomer_ConNum.Name = "cutomer_ConNum";
            this.cutomer_ConNum.Size = new System.Drawing.Size(106, 16);
            this.cutomer_ConNum.TabIndex = 29;
            this.cutomer_ConNum.Text = "Contact Number:";
            // 
            // customer_id
            // 
            this.customer_id.AutoSize = true;
            this.customer_id.Location = new System.Drawing.Point(74, 115);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(83, 16);
            this.customer_id.TabIndex = 28;
            this.customer_id.Text = "Customer ID:";
            // 
            // customer_Name
            // 
            this.customer_Name.AutoSize = true;
            this.customer_Name.Location = new System.Drawing.Point(74, 57);
            this.customer_Name.Name = "customer_Name";
            this.customer_Name.Size = new System.Drawing.Size(47, 16);
            this.customer_Name.TabIndex = 26;
            this.customer_Name.Text = "Name:";
            // 
            // tabPage_Music
            // 
            this.tabPage_Music.Controls.Add(this.btn_select_music);
            this.tabPage_Music.Controls.Add(this.dataGridView_music);
            this.tabPage_Music.Controls.Add(this.txt_music_info);
            this.tabPage_Music.Controls.Add(this.music_info);
            this.tabPage_Music.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Music.Name = "tabPage_Music";
            this.tabPage_Music.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Music.Size = new System.Drawing.Size(817, 473);
            this.tabPage_Music.TabIndex = 5;
            this.tabPage_Music.Text = "Music";
            this.tabPage_Music.UseVisualStyleBackColor = true;
            // 
            // btn_select_music
            // 
            this.btn_select_music.Location = new System.Drawing.Point(520, 98);
            this.btn_select_music.Name = "btn_select_music";
            this.btn_select_music.Size = new System.Drawing.Size(75, 23);
            this.btn_select_music.TabIndex = 3;
            this.btn_select_music.Text = "SELECT";
            this.btn_select_music.UseVisualStyleBackColor = true;
            this.btn_select_music.Click += new System.EventHandler(this.btn_select_music_Click);
            // 
            // dataGridView_music
            // 
            this.dataGridView_music.AutoGenerateColumns = false;
            this.dataGridView_music.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_music.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn2,
            this.titleDataGridViewTextBoxColumn2,
            this.artistDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn2,
            this.priceDataGridViewTextBoxColumn2});
            this.dataGridView_music.DataSource = this.showMusicDetailsBindingSource;
            this.dataGridView_music.Location = new System.Drawing.Point(56, 177);
            this.dataGridView_music.Name = "dataGridView_music";
            this.dataGridView_music.RowHeadersWidth = 51;
            this.dataGridView_music.RowTemplate.Height = 24;
            this.dataGridView_music.Size = new System.Drawing.Size(682, 242);
            this.dataGridView_music.TabIndex = 2;
            // 
            // productidDataGridViewTextBoxColumn2
            // 
            this.productidDataGridViewTextBoxColumn2.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn2.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn2.Name = "productidDataGridViewTextBoxColumn2";
            this.productidDataGridViewTextBoxColumn2.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn2
            // 
            this.titleDataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn2.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn2.Name = "titleDataGridViewTextBoxColumn2";
            this.titleDataGridViewTextBoxColumn2.Width = 125;
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "artist";
            this.artistDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            this.artistDataGridViewTextBoxColumn.Width = 125;
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "album";
            this.albumDataGridViewTextBoxColumn.HeaderText = "album";
            this.albumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            this.albumDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreDataGridViewTextBoxColumn2
            // 
            this.genreDataGridViewTextBoxColumn2.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn2.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.genreDataGridViewTextBoxColumn2.Name = "genreDataGridViewTextBoxColumn2";
            this.genreDataGridViewTextBoxColumn2.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn2
            // 
            this.priceDataGridViewTextBoxColumn2.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn2.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn2.Name = "priceDataGridViewTextBoxColumn2";
            this.priceDataGridViewTextBoxColumn2.Width = 125;
            // 
            // showMusicDetailsBindingSource
            // 
            this.showMusicDetailsBindingSource.DataMember = "showMusicDetails";
            this.showMusicDetailsBindingSource.DataSource = this.bookstoreDataSet4;
            // 
            // bookstoreDataSet4
            // 
            this.bookstoreDataSet4.DataSetName = "BookstoreDataSet4";
            this.bookstoreDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_music_info
            // 
            this.txt_music_info.Location = new System.Drawing.Point(340, 99);
            this.txt_music_info.Name = "txt_music_info";
            this.txt_music_info.Size = new System.Drawing.Size(100, 22);
            this.txt_music_info.TabIndex = 1;
            // 
            // music_info
            // 
            this.music_info.AutoSize = true;
            this.music_info.Location = new System.Drawing.Point(86, 105);
            this.music_info.Name = "music_info";
            this.music_info.Size = new System.Drawing.Size(220, 16);
            this.music_info.TabIndex = 0;
            this.music_info.Text = "Show Selected Music\'s Informations";
            // 
            // tabPage_Movie
            // 
            this.tabPage_Movie.Controls.Add(this.btn_select_movie);
            this.tabPage_Movie.Controls.Add(this.dataGridView_movie);
            this.tabPage_Movie.Controls.Add(this.txt_movie_info);
            this.tabPage_Movie.Controls.Add(this.movie_info);
            this.tabPage_Movie.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Movie.Name = "tabPage_Movie";
            this.tabPage_Movie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Movie.Size = new System.Drawing.Size(817, 473);
            this.tabPage_Movie.TabIndex = 4;
            this.tabPage_Movie.Text = "Movie";
            this.tabPage_Movie.UseVisualStyleBackColor = true;
            // 
            // btn_select_movie
            // 
            this.btn_select_movie.Location = new System.Drawing.Point(520, 98);
            this.btn_select_movie.Name = "btn_select_movie";
            this.btn_select_movie.Size = new System.Drawing.Size(75, 23);
            this.btn_select_movie.TabIndex = 3;
            this.btn_select_movie.Text = "SELECT";
            this.btn_select_movie.UseVisualStyleBackColor = true;
            this.btn_select_movie.Click += new System.EventHandler(this.btn_select_movie_Click);
            // 
            // dataGridView_movie
            // 
            this.dataGridView_movie.AutoGenerateColumns = false;
            this.dataGridView_movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_movie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView_movie.DataSource = this.showMovieDetailsBindingSource;
            this.dataGridView_movie.Location = new System.Drawing.Point(56, 177);
            this.dataGridView_movie.Name = "dataGridView_movie";
            this.dataGridView_movie.RowHeadersWidth = 51;
            this.dataGridView_movie.RowTemplate.Height = 24;
            this.dataGridView_movie.Size = new System.Drawing.Size(682, 242);
            this.dataGridView_movie.TabIndex = 2;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "director";
            this.directorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            this.directorDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // showMovieDetailsBindingSource
            // 
            this.showMovieDetailsBindingSource.DataMember = "showMovieDetails";
            this.showMovieDetailsBindingSource.DataSource = this.bookstoreDataSet;
            // 
            // bookstoreDataSet
            // 
            this.bookstoreDataSet.DataSetName = "BookstoreDataSet";
            this.bookstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_movie_info
            // 
            this.txt_movie_info.Location = new System.Drawing.Point(340, 99);
            this.txt_movie_info.Name = "txt_movie_info";
            this.txt_movie_info.Size = new System.Drawing.Size(100, 22);
            this.txt_movie_info.TabIndex = 1;
            // 
            // movie_info
            // 
            this.movie_info.AutoSize = true;
            this.movie_info.Location = new System.Drawing.Point(86, 105);
            this.movie_info.Name = "movie_info";
            this.movie_info.Size = new System.Drawing.Size(222, 16);
            this.movie_info.TabIndex = 0;
            this.movie_info.Text = "Show Selected Movie\'s Informations";
            // 
            // tabPage_Book
            // 
            this.tabPage_Book.Controls.Add(this.btn_select_book);
            this.tabPage_Book.Controls.Add(this.dataGridView_book);
            this.tabPage_Book.Controls.Add(this.book_info);
            this.tabPage_Book.Controls.Add(this.txt_book_info);
            this.tabPage_Book.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Book.Name = "tabPage_Book";
            this.tabPage_Book.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Book.Size = new System.Drawing.Size(817, 473);
            this.tabPage_Book.TabIndex = 3;
            this.tabPage_Book.Text = "Book";
            this.tabPage_Book.UseVisualStyleBackColor = true;
            // 
            // btn_select_book
            // 
            this.btn_select_book.Location = new System.Drawing.Point(520, 98);
            this.btn_select_book.Name = "btn_select_book";
            this.btn_select_book.Size = new System.Drawing.Size(75, 23);
            this.btn_select_book.TabIndex = 3;
            this.btn_select_book.Text = "SELECT";
            this.btn_select_book.UseVisualStyleBackColor = true;
            this.btn_select_book.Click += new System.EventHandler(this.btn_select_book_Click);
            // 
            // dataGridView_book
            // 
            this.dataGridView_book.AutoGenerateColumns = false;
            this.dataGridView_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn1,
            this.authorDataGridViewTextBoxColumn,
            this.casetypeDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.dataGridView_book.DataSource = this.showBookDetailsBindingSource;
            this.dataGridView_book.Location = new System.Drawing.Point(56, 177);
            this.dataGridView_book.Name = "dataGridView_book";
            this.dataGridView_book.RowHeadersWidth = 51;
            this.dataGridView_book.RowTemplate.Height = 24;
            this.dataGridView_book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_book.Size = new System.Drawing.Size(682, 242);
            this.dataGridView_book.TabIndex = 2;
            // 
            // productidDataGridViewTextBoxColumn1
            // 
            this.productidDataGridViewTextBoxColumn1.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn1.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn1.Name = "productidDataGridViewTextBoxColumn1";
            this.productidDataGridViewTextBoxColumn1.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // casetypeDataGridViewTextBoxColumn
            // 
            this.casetypeDataGridViewTextBoxColumn.DataPropertyName = "case_type";
            this.casetypeDataGridViewTextBoxColumn.HeaderText = "case_type";
            this.casetypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.casetypeDataGridViewTextBoxColumn.Name = "casetypeDataGridViewTextBoxColumn";
            this.casetypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreDataGridViewTextBoxColumn1
            // 
            this.genreDataGridViewTextBoxColumn1.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn1.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.genreDataGridViewTextBoxColumn1.Name = "genreDataGridViewTextBoxColumn1";
            this.genreDataGridViewTextBoxColumn1.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // showBookDetailsBindingSource
            // 
            this.showBookDetailsBindingSource.DataMember = "showBookDetails";
            this.showBookDetailsBindingSource.DataSource = this.bookstoreDataSet3;
            // 
            // bookstoreDataSet3
            // 
            this.bookstoreDataSet3.DataSetName = "BookstoreDataSet3";
            this.bookstoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_info
            // 
            this.book_info.AutoSize = true;
            this.book_info.Location = new System.Drawing.Point(86, 105);
            this.book_info.Name = "book_info";
            this.book_info.Size = new System.Drawing.Size(217, 16);
            this.book_info.TabIndex = 1;
            this.book_info.Text = "Show Selected Book\'s Informations";
            // 
            // txt_book_info
            // 
            this.txt_book_info.Location = new System.Drawing.Point(340, 99);
            this.txt_book_info.Name = "txt_book_info";
            this.txt_book_info.Size = new System.Drawing.Size(100, 22);
            this.txt_book_info.TabIndex = 0;
            // 
            // tabPage_Product
            // 
            this.tabPage_Product.Controls.Add(this.label1);
            this.tabPage_Product.Controls.Add(this.btn_Music);
            this.tabPage_Product.Controls.Add(this.btn_Movie);
            this.tabPage_Product.Controls.Add(this.btn_Book);
            this.tabPage_Product.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Product.Name = "tabPage_Product";
            this.tabPage_Product.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Product.Size = new System.Drawing.Size(817, 473);
            this.tabPage_Product.TabIndex = 2;
            this.tabPage_Product.Text = "Product Page";
            this.tabPage_Product.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "PLEASE SELECT A PRODUCT";
            // 
            // btn_Music
            // 
            this.btn_Music.Location = new System.Drawing.Point(520, 195);
            this.btn_Music.Name = "btn_Music";
            this.btn_Music.Size = new System.Drawing.Size(107, 61);
            this.btn_Music.TabIndex = 2;
            this.btn_Music.Text = "Music";
            this.btn_Music.UseVisualStyleBackColor = true;
            this.btn_Music.Click += new System.EventHandler(this.btn_Music_Click);
            // 
            // btn_Movie
            // 
            this.btn_Movie.Location = new System.Drawing.Point(325, 195);
            this.btn_Movie.Name = "btn_Movie";
            this.btn_Movie.Size = new System.Drawing.Size(113, 61);
            this.btn_Movie.TabIndex = 1;
            this.btn_Movie.Text = "Movie";
            this.btn_Movie.UseVisualStyleBackColor = true;
            this.btn_Movie.Click += new System.EventHandler(this.btn_Movie_Click);
            // 
            // btn_Book
            // 
            this.btn_Book.Location = new System.Drawing.Point(127, 195);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(116, 61);
            this.btn_Book.TabIndex = 0;
            this.btn_Book.Text = "Book";
            this.btn_Book.UseVisualStyleBackColor = true;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // tabPage_Staff
            // 
            this.tabPage_Staff.Controls.Add(this.btn_update_staff);
            this.tabPage_Staff.Controls.Add(this.btn_delete_staff);
            this.tabPage_Staff.Controls.Add(this.dataGridView_staff);
            this.tabPage_Staff.Controls.Add(this.txt_staff_AccNum);
            this.tabPage_Staff.Controls.Add(this.txt_staff_BankName);
            this.tabPage_Staff.Controls.Add(this.txt_staff_JobTitle);
            this.tabPage_Staff.Controls.Add(this.txt_staff_id);
            this.tabPage_Staff.Controls.Add(this.txt_staff_LastName);
            this.tabPage_Staff.Controls.Add(this.txt_staff_FirstName);
            this.tabPage_Staff.Controls.Add(this.btn_save_staff);
            this.tabPage_Staff.Controls.Add(this.staff_AccNum);
            this.tabPage_Staff.Controls.Add(this.staff_BankName);
            this.tabPage_Staff.Controls.Add(this.staff_JobTitle);
            this.tabPage_Staff.Controls.Add(this.staff_id);
            this.tabPage_Staff.Controls.Add(this.staff_LastName);
            this.tabPage_Staff.Controls.Add(this.staff_FirstName);
            this.tabPage_Staff.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Staff.Name = "tabPage_Staff";
            this.tabPage_Staff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Staff.Size = new System.Drawing.Size(817, 473);
            this.tabPage_Staff.TabIndex = 1;
            this.tabPage_Staff.Text = "Staff";
            this.tabPage_Staff.UseVisualStyleBackColor = true;
            // 
            // btn_update_staff
            // 
            this.btn_update_staff.Location = new System.Drawing.Point(504, 208);
            this.btn_update_staff.Name = "btn_update_staff";
            this.btn_update_staff.Size = new System.Drawing.Size(98, 23);
            this.btn_update_staff.TabIndex = 28;
            this.btn_update_staff.Text = "UPDATE";
            this.btn_update_staff.UseVisualStyleBackColor = true;
            this.btn_update_staff.Click += new System.EventHandler(this.btn_update_staff_Click);
            // 
            // btn_delete_staff
            // 
            this.btn_delete_staff.Location = new System.Drawing.Point(323, 208);
            this.btn_delete_staff.Name = "btn_delete_staff";
            this.btn_delete_staff.Size = new System.Drawing.Size(102, 23);
            this.btn_delete_staff.TabIndex = 27;
            this.btn_delete_staff.Text = "DELETE";
            this.btn_delete_staff.UseVisualStyleBackColor = true;
            this.btn_delete_staff.Click += new System.EventHandler(this.btn_delete_staff_Click);
            // 
            // dataGridView_staff
            // 
            this.dataGridView_staff.AutoGenerateColumns = false;
            this.dataGridView_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn});
            this.dataGridView_staff.DataSource = this.staffInfoBindingSource;
            this.dataGridView_staff.Location = new System.Drawing.Point(75, 255);
            this.dataGridView_staff.Name = "dataGridView_staff";
            this.dataGridView_staff.RowHeadersWidth = 51;
            this.dataGridView_staff.RowTemplate.Height = 24;
            this.dataGridView_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_staff.Size = new System.Drawing.Size(634, 200);
            this.dataGridView_staff.TabIndex = 26;
            this.dataGridView_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_staff_CellClick);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            this.jobTitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffInfoBindingSource
            // 
            this.staffInfoBindingSource.DataMember = "StaffInfo";
            this.staffInfoBindingSource.DataSource = this.bookstoreDataSet6;
            // 
            // bookstoreDataSet6
            // 
            this.bookstoreDataSet6.DataSetName = "BookstoreDataSet6";
            this.bookstoreDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_staff_AccNum
            // 
            this.txt_staff_AccNum.Location = new System.Drawing.Point(544, 152);
            this.txt_staff_AccNum.Name = "txt_staff_AccNum";
            this.txt_staff_AccNum.Size = new System.Drawing.Size(136, 22);
            this.txt_staff_AccNum.TabIndex = 25;
            // 
            // txt_staff_BankName
            // 
            this.txt_staff_BankName.Location = new System.Drawing.Point(544, 101);
            this.txt_staff_BankName.Name = "txt_staff_BankName";
            this.txt_staff_BankName.Size = new System.Drawing.Size(136, 22);
            this.txt_staff_BankName.TabIndex = 24;
            // 
            // txt_staff_JobTitle
            // 
            this.txt_staff_JobTitle.Location = new System.Drawing.Point(544, 52);
            this.txt_staff_JobTitle.Name = "txt_staff_JobTitle";
            this.txt_staff_JobTitle.Size = new System.Drawing.Size(136, 22);
            this.txt_staff_JobTitle.TabIndex = 23;
            // 
            // txt_staff_id
            // 
            this.txt_staff_id.Location = new System.Drawing.Point(187, 155);
            this.txt_staff_id.Name = "txt_staff_id";
            this.txt_staff_id.Size = new System.Drawing.Size(136, 22);
            this.txt_staff_id.TabIndex = 22;
            // 
            // txt_staff_LastName
            // 
            this.txt_staff_LastName.Location = new System.Drawing.Point(187, 101);
            this.txt_staff_LastName.Name = "txt_staff_LastName";
            this.txt_staff_LastName.Size = new System.Drawing.Size(136, 22);
            this.txt_staff_LastName.TabIndex = 21;
            // 
            // txt_staff_FirstName
            // 
            this.txt_staff_FirstName.Location = new System.Drawing.Point(187, 48);
            this.txt_staff_FirstName.Name = "txt_staff_FirstName";
            this.txt_staff_FirstName.Size = new System.Drawing.Size(136, 22);
            this.txt_staff_FirstName.TabIndex = 20;
            // 
            // btn_save_staff
            // 
            this.btn_save_staff.Location = new System.Drawing.Point(169, 208);
            this.btn_save_staff.Name = "btn_save_staff";
            this.btn_save_staff.Size = new System.Drawing.Size(75, 23);
            this.btn_save_staff.TabIndex = 19;
            this.btn_save_staff.Text = "INSERT";
            this.btn_save_staff.UseVisualStyleBackColor = true;
            this.btn_save_staff.Click += new System.EventHandler(this.btn_save_staff_Click);
            // 
            // staff_AccNum
            // 
            this.staff_AccNum.AutoSize = true;
            this.staff_AccNum.Location = new System.Drawing.Point(429, 158);
            this.staff_AccNum.Name = "staff_AccNum";
            this.staff_AccNum.Size = new System.Drawing.Size(109, 16);
            this.staff_AccNum.TabIndex = 18;
            this.staff_AccNum.Text = "Account Number:";
            // 
            // staff_BankName
            // 
            this.staff_BankName.AutoSize = true;
            this.staff_BankName.Location = new System.Drawing.Point(429, 107);
            this.staff_BankName.Name = "staff_BankName";
            this.staff_BankName.Size = new System.Drawing.Size(81, 16);
            this.staff_BankName.TabIndex = 17;
            this.staff_BankName.Text = "Bank Name:";
            // 
            // staff_JobTitle
            // 
            this.staff_JobTitle.AutoSize = true;
            this.staff_JobTitle.Location = new System.Drawing.Point(429, 58);
            this.staff_JobTitle.Name = "staff_JobTitle";
            this.staff_JobTitle.Size = new System.Drawing.Size(62, 16);
            this.staff_JobTitle.TabIndex = 16;
            this.staff_JobTitle.Text = "Job Title:";
            // 
            // staff_id
            // 
            this.staff_id.AutoSize = true;
            this.staff_id.Location = new System.Drawing.Point(72, 161);
            this.staff_id.Name = "staff_id";
            this.staff_id.Size = new System.Drawing.Size(52, 16);
            this.staff_id.TabIndex = 15;
            this.staff_id.Text = "Staff ID:";
            // 
            // staff_LastName
            // 
            this.staff_LastName.AutoSize = true;
            this.staff_LastName.Location = new System.Drawing.Point(72, 107);
            this.staff_LastName.Name = "staff_LastName";
            this.staff_LastName.Size = new System.Drawing.Size(76, 16);
            this.staff_LastName.TabIndex = 14;
            this.staff_LastName.Text = "Last_Name";
            // 
            // staff_FirstName
            // 
            this.staff_FirstName.AutoSize = true;
            this.staff_FirstName.Location = new System.Drawing.Point(72, 54);
            this.staff_FirstName.Name = "staff_FirstName";
            this.staff_FirstName.Size = new System.Drawing.Size(75, 16);
            this.staff_FirstName.TabIndex = 13;
            this.staff_FirstName.Text = "First Name:";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.bookstoreDataSet1;
            // 
            // bookstoreDataSet1
            // 
            this.bookstoreDataSet1.DataSetName = "BookstoreDataSet1";
            this.bookstoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Staff);
            this.tabControl1.Controls.Add(this.tabPage_Product);
            this.tabControl1.Controls.Add(this.tabPage_Book);
            this.tabControl1.Controls.Add(this.tabPage_Movie);
            this.tabControl1.Controls.Add(this.tabPage_Music);
            this.tabControl1.Controls.Add(this.tabPage_Customer);
            this.tabControl1.Controls.Add(this.tabPage_Payment);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Payment
            // 
            this.tabPage_Payment.Controls.Add(this.btn_select_payment);
            this.tabPage_Payment.Controls.Add(this.btn_update_pay);
            this.tabPage_Payment.Controls.Add(this.btn_delete_pay);
            this.tabPage_Payment.Controls.Add(this.btn_save_pay);
            this.tabPage_Payment.Controls.Add(this.dataGridView_payment);
            this.tabPage_Payment.Controls.Add(this.txt_pay_date);
            this.tabPage_Payment.Controls.Add(this.txt_pay_amt);
            this.tabPage_Payment.Controls.Add(this.txt_pay_id);
            this.tabPage_Payment.Controls.Add(this.pay_date);
            this.tabPage_Payment.Controls.Add(this.pay_amt);
            this.tabPage_Payment.Controls.Add(this.payment_id);
            this.tabPage_Payment.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Payment.Name = "tabPage_Payment";
            this.tabPage_Payment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Payment.Size = new System.Drawing.Size(817, 473);
            this.tabPage_Payment.TabIndex = 7;
            this.tabPage_Payment.Text = "Payment";
            this.tabPage_Payment.UseVisualStyleBackColor = true;
            // 
            // btn_select_payment
            // 
            this.btn_select_payment.Location = new System.Drawing.Point(579, 151);
            this.btn_select_payment.Name = "btn_select_payment";
            this.btn_select_payment.Size = new System.Drawing.Size(97, 23);
            this.btn_select_payment.TabIndex = 10;
            this.btn_select_payment.Text = "SELECT";
            this.btn_select_payment.UseVisualStyleBackColor = true;
            this.btn_select_payment.Click += new System.EventHandler(this.btn_select_payment_Click);
            // 
            // btn_update_pay
            // 
            this.btn_update_pay.Location = new System.Drawing.Point(579, 89);
            this.btn_update_pay.Name = "btn_update_pay";
            this.btn_update_pay.Size = new System.Drawing.Size(97, 23);
            this.btn_update_pay.TabIndex = 9;
            this.btn_update_pay.Text = "UPDATE";
            this.btn_update_pay.UseVisualStyleBackColor = true;
            this.btn_update_pay.Click += new System.EventHandler(this.btn_update_pay_Click);
            // 
            // btn_delete_pay
            // 
            this.btn_delete_pay.Location = new System.Drawing.Point(453, 151);
            this.btn_delete_pay.Name = "btn_delete_pay";
            this.btn_delete_pay.Size = new System.Drawing.Size(97, 23);
            this.btn_delete_pay.TabIndex = 8;
            this.btn_delete_pay.Text = "DELETE";
            this.btn_delete_pay.UseVisualStyleBackColor = true;
            this.btn_delete_pay.Click += new System.EventHandler(this.btn_delete_pay_Click);
            // 
            // btn_save_pay
            // 
            this.btn_save_pay.Location = new System.Drawing.Point(453, 89);
            this.btn_save_pay.Name = "btn_save_pay";
            this.btn_save_pay.Size = new System.Drawing.Size(97, 23);
            this.btn_save_pay.TabIndex = 7;
            this.btn_save_pay.Text = "INSERT";
            this.btn_save_pay.UseVisualStyleBackColor = true;
            this.btn_save_pay.Click += new System.EventHandler(this.btn_save_pay_Click);
            // 
            // dataGridView_payment
            // 
            this.dataGridView_payment.AutoGenerateColumns = false;
            this.dataGridView_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_payment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paydateDataGridViewTextBoxColumn,
            this.payamtDataGridViewTextBoxColumn,
            this.paymentidDataGridViewTextBoxColumn});
            this.dataGridView_payment.DataSource = this.paymentBindingSource;
            this.dataGridView_payment.Location = new System.Drawing.Point(142, 238);
            this.dataGridView_payment.Name = "dataGridView_payment";
            this.dataGridView_payment.RowHeadersWidth = 51;
            this.dataGridView_payment.RowTemplate.Height = 24;
            this.dataGridView_payment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_payment.Size = new System.Drawing.Size(477, 206);
            this.dataGridView_payment.TabIndex = 6;
            this.dataGridView_payment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_payment_CellClick);
            // 
            // paydateDataGridViewTextBoxColumn
            // 
            this.paydateDataGridViewTextBoxColumn.DataPropertyName = "pay_date";
            this.paydateDataGridViewTextBoxColumn.HeaderText = "pay_date";
            this.paydateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paydateDataGridViewTextBoxColumn.Name = "paydateDataGridViewTextBoxColumn";
            this.paydateDataGridViewTextBoxColumn.Width = 125;
            // 
            // payamtDataGridViewTextBoxColumn
            // 
            this.payamtDataGridViewTextBoxColumn.DataPropertyName = "pay_amt";
            this.payamtDataGridViewTextBoxColumn.HeaderText = "pay_amt";
            this.payamtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payamtDataGridViewTextBoxColumn.Name = "payamtDataGridViewTextBoxColumn";
            this.payamtDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentidDataGridViewTextBoxColumn
            // 
            this.paymentidDataGridViewTextBoxColumn.DataPropertyName = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.HeaderText = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentidDataGridViewTextBoxColumn.Name = "paymentidDataGridViewTextBoxColumn";
            this.paymentidDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.bookstoreDataSet5;
            // 
            // bookstoreDataSet5
            // 
            this.bookstoreDataSet5.DataSetName = "BookstoreDataSet5";
            this.bookstoreDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_pay_date
            // 
            this.txt_pay_date.Location = new System.Drawing.Point(282, 172);
            this.txt_pay_date.Name = "txt_pay_date";
            this.txt_pay_date.Size = new System.Drawing.Size(100, 22);
            this.txt_pay_date.TabIndex = 5;
            // 
            // txt_pay_amt
            // 
            this.txt_pay_amt.Location = new System.Drawing.Point(282, 117);
            this.txt_pay_amt.Name = "txt_pay_amt";
            this.txt_pay_amt.Size = new System.Drawing.Size(100, 22);
            this.txt_pay_amt.TabIndex = 4;
            // 
            // txt_pay_id
            // 
            this.txt_pay_id.Location = new System.Drawing.Point(282, 62);
            this.txt_pay_id.Name = "txt_pay_id";
            this.txt_pay_id.Size = new System.Drawing.Size(100, 22);
            this.txt_pay_id.TabIndex = 3;
            // 
            // pay_date
            // 
            this.pay_date.AutoSize = true;
            this.pay_date.Location = new System.Drawing.Point(86, 178);
            this.pay_date.Name = "pay_date";
            this.pay_date.Size = new System.Drawing.Size(95, 16);
            this.pay_date.TabIndex = 2;
            this.pay_date.Text = "Payment Date:";
            // 
            // pay_amt
            // 
            this.pay_amt.AutoSize = true;
            this.pay_amt.Location = new System.Drawing.Point(86, 123);
            this.pay_amt.Name = "pay_amt";
            this.pay_amt.Size = new System.Drawing.Size(111, 16);
            this.pay_amt.TabIndex = 1;
            this.pay_amt.Text = "Payment Amount:";
            // 
            // payment_id
            // 
            this.payment_id.AutoSize = true;
            this.payment_id.Location = new System.Drawing.Point(86, 68);
            this.payment_id.Name = "payment_id";
            this.payment_id.Size = new System.Drawing.Size(79, 16);
            this.payment_id.TabIndex = 0;
            this.payment_id.Text = "Payment ID:";
            // 
            // showMovieDetailsTableAdapter
            // 
            this.showMovieDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // showBookDetailsTableAdapter
            // 
            this.showBookDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // showMusicDetailsTableAdapter
            // 
            this.showMusicDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // staffInfoTableAdapter
            // 
            this.staffInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1365, 728);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bookstore Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage_Customer.ResumeLayout(false);
            this.tabPage_Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet2)).EndInit();
            this.tabPage_Music.ResumeLayout(false);
            this.tabPage_Music.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_music)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showMusicDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet4)).EndInit();
            this.tabPage_Movie.ResumeLayout(false);
            this.tabPage_Movie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_movie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showMovieDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet)).EndInit();
            this.tabPage_Book.ResumeLayout(false);
            this.tabPage_Book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBookDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet3)).EndInit();
            this.tabPage_Product.ResumeLayout(false);
            this.tabPage_Product.PerformLayout();
            this.tabPage_Staff.ResumeLayout(false);
            this.tabPage_Staff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Payment.ResumeLayout(false);
            this.tabPage_Payment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage_Customer;
        private System.Windows.Forms.Button btn_update_customer;
        private System.Windows.Forms.Button btn_delete_customer;
        private System.Windows.Forms.DataGridView dataGridView_customer;
        private System.Windows.Forms.TextBox txt_customer_Address;
        private System.Windows.Forms.TextBox txt_customer_Mail;
        private System.Windows.Forms.TextBox txt_customer_ConNum;
        private System.Windows.Forms.TextBox txt_customer_id;
        private System.Windows.Forms.TextBox txt_customer_Name;
        private System.Windows.Forms.Button btn_save_customer;
        private System.Windows.Forms.Label customer_Address;
        private System.Windows.Forms.Label customer_Mail;
        private System.Windows.Forms.Label cutomer_ConNum;
        private System.Windows.Forms.Label customer_id;
        private System.Windows.Forms.Label customer_Name;
        private System.Windows.Forms.TabPage tabPage_Music;
        private System.Windows.Forms.TabPage tabPage_Movie;
        private System.Windows.Forms.TabPage tabPage_Book;
        private System.Windows.Forms.TabPage tabPage_Product;
        private System.Windows.Forms.Button btn_Music;
        private System.Windows.Forms.Button btn_Movie;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.TabPage tabPage_Staff;
        private System.Windows.Forms.Button btn_update_staff;
        private System.Windows.Forms.Button btn_delete_staff;
        private System.Windows.Forms.DataGridView dataGridView_staff;
        private System.Windows.Forms.TextBox txt_staff_AccNum;
        private System.Windows.Forms.TextBox txt_staff_BankName;
        private System.Windows.Forms.TextBox txt_staff_JobTitle;
        private System.Windows.Forms.TextBox txt_staff_id;
        private System.Windows.Forms.TextBox txt_staff_LastName;
        private System.Windows.Forms.TextBox txt_staff_FirstName;
        private System.Windows.Forms.Button btn_save_staff;
        private System.Windows.Forms.Label staff_AccNum;
        private System.Windows.Forms.Label staff_BankName;
        private System.Windows.Forms.Label staff_JobTitle;
        private System.Windows.Forms.Label staff_id;
        private System.Windows.Forms.Label staff_LastName;
        private System.Windows.Forms.Label staff_FirstName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txt_music_info;
        private System.Windows.Forms.Label music_info;
        private System.Windows.Forms.TextBox txt_movie_info;
        private System.Windows.Forms.Label movie_info;
        private System.Windows.Forms.Label book_info;
        private System.Windows.Forms.TextBox txt_book_info;
        private System.Windows.Forms.TabPage tabPage_Payment;
        private System.Windows.Forms.DataGridView dataGridView_movie;
        private BookstoreDataSet bookstoreDataSet;
        private System.Windows.Forms.BindingSource showMovieDetailsBindingSource;
        private BookstoreDataSetTableAdapters.showMovieDetailsTableAdapter showMovieDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BookstoreDataSet1 bookstoreDataSet1;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private BookstoreDataSet1TableAdapters.StaffTableAdapter staffTableAdapter;
        private BookstoreDataSet2 bookstoreDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private BookstoreDataSet2TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_book;
        private BookstoreDataSet3 bookstoreDataSet3;
        private System.Windows.Forms.BindingSource showBookDetailsBindingSource;
        private BookstoreDataSet3TableAdapters.showBookDetailsTableAdapter showBookDetailsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_music;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private BookstoreDataSet4 bookstoreDataSet4;
        private System.Windows.Forms.BindingSource showMusicDetailsBindingSource;
        private BookstoreDataSet4TableAdapters.showMusicDetailsTableAdapter showMusicDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label pay_date;
        private System.Windows.Forms.Label pay_amt;
        private System.Windows.Forms.Label payment_id;
        private System.Windows.Forms.DataGridView dataGridView_payment;
        private System.Windows.Forms.TextBox txt_pay_date;
        private System.Windows.Forms.TextBox txt_pay_amt;
        private System.Windows.Forms.TextBox txt_pay_id;
        private BookstoreDataSet5 bookstoreDataSet5;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private BookstoreDataSet5TableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.Button btn_update_pay;
        private System.Windows.Forms.Button btn_delete_pay;
        private System.Windows.Forms.Button btn_save_pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn paydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentidDataGridViewTextBoxColumn;
        private BookstoreDataSet6 bookstoreDataSet6;
        private System.Windows.Forms.BindingSource staffInfoBindingSource;
        private BookstoreDataSet6TableAdapters.StaffInfoTableAdapter staffInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_select_book;
        private System.Windows.Forms.Button btn_select_music;
        private System.Windows.Forms.Button btn_select_movie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_select_customer;
        private System.Windows.Forms.Button btn_select_payment;
    }
}

