namespace SoftwareConstructionLab2
{
    partial class Main
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
            this.appDataSet = new SoftwareConstructionLab2.AppDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new SoftwareConstructionLab2.AppDataSetTableAdapters.BooksTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.journalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalsTableAdapter = new SoftwareConstructionLab2.AppDataSetTableAdapters.JournalsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_session = new System.Windows.Forms.Label();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artinameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donatedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueBook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ArticleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artinameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pubDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donatedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueArticle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appDataSet
            // 
            this.appDataSet.DataSetName = "AppDataSet";
            this.appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.appDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.artinameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.pubDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.donatedDataGridViewCheckBoxColumn,
            this.finesDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.IssueBook});
            this.dataGridView1.DataSource = this.booksBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(42, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1164, 110);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.appDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticleID,
            this.artinameDataGridViewTextBoxColumn1,
            this.authorDataGridViewTextBoxColumn1,
            this.pubDataGridViewTextBoxColumn1,
            this.genreDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn1,
            this.donatedDataGridViewCheckBoxColumn1,
            this.finesDataGridViewTextBoxColumn1,
            this.ownerDataGridViewTextBoxColumn1,
            this.stateDataGridViewTextBoxColumn1,
            this.IssueArticle});
            this.dataGridView2.DataSource = this.journalsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(42, 260);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1177, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // journalsBindingSource
            // 
            this.journalsBindingSource.DataMember = "Journals";
            this.journalsBindingSource.DataSource = this.appDataSet;
            // 
            // journalsTableAdapter
            // 
            this.journalsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Articles";
            // 
            // user_session
            // 
            this.user_session.AutoSize = true;
            this.user_session.Location = new System.Drawing.Point(997, 43);
            this.user_session.Name = "user_session";
            this.user_session.Size = new System.Drawing.Size(58, 13);
            this.user_session.TabIndex = 4;
            this.user_session.Text = "Username:";
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "ID";
            this.BookID.HeaderText = "ID";
            this.BookID.Name = "BookID";
            // 
            // artinameDataGridViewTextBoxColumn
            // 
            this.artinameDataGridViewTextBoxColumn.DataPropertyName = "artiname";
            this.artinameDataGridViewTextBoxColumn.HeaderText = "artiname";
            this.artinameDataGridViewTextBoxColumn.Name = "artinameDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // pubDataGridViewTextBoxColumn
            // 
            this.pubDataGridViewTextBoxColumn.DataPropertyName = "pub";
            this.pubDataGridViewTextBoxColumn.HeaderText = "pub";
            this.pubDataGridViewTextBoxColumn.Name = "pubDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // donatedDataGridViewCheckBoxColumn
            // 
            this.donatedDataGridViewCheckBoxColumn.DataPropertyName = "donated";
            this.donatedDataGridViewCheckBoxColumn.HeaderText = "donated";
            this.donatedDataGridViewCheckBoxColumn.Name = "donatedDataGridViewCheckBoxColumn";
            // 
            // finesDataGridViewTextBoxColumn
            // 
            this.finesDataGridViewTextBoxColumn.DataPropertyName = "fines";
            this.finesDataGridViewTextBoxColumn.HeaderText = "fines";
            this.finesDataGridViewTextBoxColumn.Name = "finesDataGridViewTextBoxColumn";
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "owner";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // IssueBook
            // 
            this.IssueBook.HeaderText = "Issue Book";
            this.IssueBook.Name = "IssueBook";
            // 
            // ArticleID
            // 
            this.ArticleID.DataPropertyName = "ID";
            this.ArticleID.HeaderText = "ID";
            this.ArticleID.Name = "ArticleID";
            this.ArticleID.ReadOnly = true;
            // 
            // artinameDataGridViewTextBoxColumn1
            // 
            this.artinameDataGridViewTextBoxColumn1.DataPropertyName = "artiname";
            this.artinameDataGridViewTextBoxColumn1.HeaderText = "artiname";
            this.artinameDataGridViewTextBoxColumn1.Name = "artinameDataGridViewTextBoxColumn1";
            this.artinameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn1
            // 
            this.authorDataGridViewTextBoxColumn1.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn1.HeaderText = "author";
            this.authorDataGridViewTextBoxColumn1.Name = "authorDataGridViewTextBoxColumn1";
            this.authorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pubDataGridViewTextBoxColumn1
            // 
            this.pubDataGridViewTextBoxColumn1.DataPropertyName = "pub";
            this.pubDataGridViewTextBoxColumn1.HeaderText = "pub";
            this.pubDataGridViewTextBoxColumn1.Name = "pubDataGridViewTextBoxColumn1";
            this.pubDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn1
            // 
            this.genreDataGridViewTextBoxColumn1.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn1.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn1.Name = "genreDataGridViewTextBoxColumn1";
            this.genreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // donatedDataGridViewCheckBoxColumn1
            // 
            this.donatedDataGridViewCheckBoxColumn1.DataPropertyName = "donated";
            this.donatedDataGridViewCheckBoxColumn1.HeaderText = "donated";
            this.donatedDataGridViewCheckBoxColumn1.Name = "donatedDataGridViewCheckBoxColumn1";
            this.donatedDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // finesDataGridViewTextBoxColumn1
            // 
            this.finesDataGridViewTextBoxColumn1.DataPropertyName = "fines";
            this.finesDataGridViewTextBoxColumn1.HeaderText = "fines";
            this.finesDataGridViewTextBoxColumn1.Name = "finesDataGridViewTextBoxColumn1";
            this.finesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ownerDataGridViewTextBoxColumn1
            // 
            this.ownerDataGridViewTextBoxColumn1.DataPropertyName = "owner";
            this.ownerDataGridViewTextBoxColumn1.HeaderText = "owner";
            this.ownerDataGridViewTextBoxColumn1.Name = "ownerDataGridViewTextBoxColumn1";
            this.ownerDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn1
            // 
            this.stateDataGridViewTextBoxColumn1.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn1.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn1.Name = "stateDataGridViewTextBoxColumn1";
            this.stateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // IssueArticle
            // 
            this.IssueArticle.HeaderText = "Issue Article";
            this.IssueArticle.Name = "IssueArticle";
            this.IssueArticle.ReadOnly = true;
            this.IssueArticle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IssueArticle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(933, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 354);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_session);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AppDataSet appDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private AppDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource journalsBindingSource;
        private AppDataSetTableAdapters.JournalsTableAdapter journalsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label user_session;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn artinameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn donatedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn IssueBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn artinameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn donatedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn IssueArticle;
        private System.Windows.Forms.Label label3;
    }
}