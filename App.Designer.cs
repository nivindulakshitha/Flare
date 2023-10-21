namespace Flare
{
    partial class App
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.DBView = new System.Windows.Forms.GroupBox();
            this.DataBaseView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DBStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DBStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.Queries = new System.Windows.Forms.ToolStripStatusLabel();
            this.SuccessQueries = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProblemQueries = new System.Windows.Forms.ToolStripStatusLabel();
            this.ActionsPane = new System.Windows.Forms.TabControl();
            this.New = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewQnt = new System.Windows.Forms.NumericUpDown();
            this.NewISBN = new System.Windows.Forms.TextBox();
            this.NewAuthor = new System.Windows.Forms.TextBox();
            this.NewTitle = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.TabPage();
            this.FindISBN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UpdateQnt = new System.Windows.Forms.NumericUpDown();
            this.UpdateISBN = new System.Windows.Forms.TextBox();
            this.UpdateAuthor = new System.Windows.Forms.TextBox();
            this.UpdateTitle = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SearchISBN = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DeleteISBN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.SqlComments = new System.Windows.Forms.RichTextBox();
            this.QueryStatusProgress = new System.Windows.Forms.ProgressBar();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseView)).BeginInit();
            this.DBStatusStrip.SuspendLayout();
            this.ActionsPane.SuspendLayout();
            this.New.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewQnt)).BeginInit();
            this.Update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateQnt)).BeginInit();
            this.Search.SuspendLayout();
            this.Delete.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DBView
            // 
            this.DBView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBView.Controls.Add(this.DataBaseView);
            this.DBView.Location = new System.Drawing.Point(12, 0);
            this.DBView.Name = "DBView";
            this.DBView.Size = new System.Drawing.Size(835, 293);
            this.DBView.TabIndex = 0;
            this.DBView.TabStop = false;
            this.DBView.Text = "Database View";
            // 
            // DataBaseView
            // 
            this.DataBaseView.AllowUserToAddRows = false;
            this.DataBaseView.AllowUserToDeleteRows = false;
            this.DataBaseView.AllowUserToResizeColumns = false;
            this.DataBaseView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DataBaseView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataBaseView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataBaseView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataBaseView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataBaseView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBaseView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataBaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.isbn,
            this.title,
            this.author,
            this.qtn});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataBaseView.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataBaseView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DataBaseView.Location = new System.Drawing.Point(4, 18);
            this.DataBaseView.Name = "DataBaseView";
            this.DataBaseView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBaseView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataBaseView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DataBaseView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataBaseView.ShowEditingIcon = false;
            this.DataBaseView.Size = new System.Drawing.Size(824, 269);
            this.DataBaseView.TabIndex = 4;
            this.DataBaseView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDataToClipboard);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(772, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beta 42.0.0.1";
            // 
            // DBStatusStrip
            // 
            this.DBStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.DBStatus,
            this.Queries,
            this.SuccessQueries,
            this.ProblemQueries});
            this.DBStatusStrip.Location = new System.Drawing.Point(0, 439);
            this.DBStatusStrip.Name = "DBStatusStrip";
            this.DBStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.DBStatusStrip.Size = new System.Drawing.Size(859, 22);
            this.DBStatusStrip.TabIndex = 2;
            this.DBStatusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.BackgroundImage = global::Flare.Properties.Resources.Logo;
            this.toolStripStatusLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel1.Text = "toolStrip";
            this.toolStripStatusLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // DBStatus
            // 
            this.DBStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DBStatus.Name = "DBStatus";
            this.DBStatus.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.DBStatus.Size = new System.Drawing.Size(128, 17);
            this.DBStatus.Text = "Trying to connect...";
            // 
            // Queries
            // 
            this.Queries.Name = "Queries";
            this.Queries.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Queries.Size = new System.Drawing.Size(135, 17);
            this.Queries.Text = "(0) Queries executed";
            // 
            // SuccessQueries
            // 
            this.SuccessQueries.Name = "SuccessQueries";
            this.SuccessQueries.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SuccessQueries.Size = new System.Drawing.Size(129, 17);
            this.SuccessQueries.Text = "(0) Success queries ";
            // 
            // ProblemQueries
            // 
            this.ProblemQueries.Name = "ProblemQueries";
            this.ProblemQueries.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ProblemQueries.Size = new System.Drawing.Size(130, 17);
            this.ProblemQueries.Text = "(0) Problem queries";
            // 
            // ActionsPane
            // 
            this.ActionsPane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionsPane.Controls.Add(this.New);
            this.ActionsPane.Controls.Add(this.Update);
            this.ActionsPane.Controls.Add(this.Search);
            this.ActionsPane.Controls.Add(this.Delete);
            this.ActionsPane.Location = new System.Drawing.Point(12, 300);
            this.ActionsPane.Name = "ActionsPane";
            this.ActionsPane.SelectedIndex = 0;
            this.ActionsPane.Size = new System.Drawing.Size(505, 136);
            this.ActionsPane.TabIndex = 3;
            this.ActionsPane.SelectedIndexChanged += new System.EventHandler(this.ActionsPane_SelectedIndexChanged);
            // 
            // New
            // 
            this.New.Controls.Add(this.label5);
            this.New.Controls.Add(this.label4);
            this.New.Controls.Add(this.label3);
            this.New.Controls.Add(this.label2);
            this.New.Controls.Add(this.NewQnt);
            this.New.Controls.Add(this.NewISBN);
            this.New.Controls.Add(this.NewAuthor);
            this.New.Controls.Add(this.NewTitle);
            this.New.Location = new System.Drawing.Point(4, 25);
            this.New.Name = "New";
            this.New.Padding = new System.Windows.Forms.Padding(3);
            this.New.Size = new System.Drawing.Size(497, 107);
            this.New.TabIndex = 0;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity available";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Book ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Authored by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title of the book";
            // 
            // NewQnt
            // 
            this.NewQnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewQnt.Location = new System.Drawing.Point(257, 74);
            this.NewQnt.Name = "NewQnt";
            this.NewQnt.Size = new System.Drawing.Size(225, 24);
            this.NewQnt.TabIndex = 4;
            this.NewQnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NewISBN
            // 
            this.NewISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewISBN.Location = new System.Drawing.Point(257, 28);
            this.NewISBN.Name = "NewISBN";
            this.NewISBN.Size = new System.Drawing.Size(225, 24);
            this.NewISBN.TabIndex = 3;
            // 
            // NewAuthor
            // 
            this.NewAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewAuthor.Location = new System.Drawing.Point(14, 74);
            this.NewAuthor.Name = "NewAuthor";
            this.NewAuthor.Size = new System.Drawing.Size(225, 24);
            this.NewAuthor.TabIndex = 2;
            // 
            // NewTitle
            // 
            this.NewTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewTitle.Location = new System.Drawing.Point(14, 28);
            this.NewTitle.Name = "NewTitle";
            this.NewTitle.Size = new System.Drawing.Size(225, 24);
            this.NewTitle.TabIndex = 0;
            // 
            // Update
            // 
            this.Update.Controls.Add(this.FindISBN);
            this.Update.Controls.Add(this.label6);
            this.Update.Controls.Add(this.label7);
            this.Update.Controls.Add(this.label8);
            this.Update.Controls.Add(this.label9);
            this.Update.Controls.Add(this.UpdateQnt);
            this.Update.Controls.Add(this.UpdateISBN);
            this.Update.Controls.Add(this.UpdateAuthor);
            this.Update.Controls.Add(this.UpdateTitle);
            this.Update.Location = new System.Drawing.Point(4, 25);
            this.Update.Name = "Update";
            this.Update.Padding = new System.Windows.Forms.Padding(3);
            this.Update.Size = new System.Drawing.Size(497, 107);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // FindISBN
            // 
            this.FindISBN.Location = new System.Drawing.Point(399, 28);
            this.FindISBN.Name = "FindISBN";
            this.FindISBN.Size = new System.Drawing.Size(83, 23);
            this.FindISBN.TabIndex = 3;
            this.FindISBN.Text = "Find ISBN";
            this.FindISBN.UseVisualStyleBackColor = true;
            this.FindISBN.Click += new System.EventHandler(this.FindISBN_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quantity available";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "Book ISBN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Authored by";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 14);
            this.label9.TabIndex = 13;
            this.label9.Text = "Title of the book";
            // 
            // UpdateQnt
            // 
            this.UpdateQnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateQnt.Enabled = false;
            this.UpdateQnt.Location = new System.Drawing.Point(257, 74);
            this.UpdateQnt.Name = "UpdateQnt";
            this.UpdateQnt.Size = new System.Drawing.Size(225, 24);
            this.UpdateQnt.TabIndex = 12;
            // 
            // UpdateISBN
            // 
            this.UpdateISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateISBN.Location = new System.Drawing.Point(257, 28);
            this.UpdateISBN.Name = "UpdateISBN";
            this.UpdateISBN.Size = new System.Drawing.Size(136, 24);
            this.UpdateISBN.TabIndex = 11;
            // 
            // UpdateAuthor
            // 
            this.UpdateAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateAuthor.Enabled = false;
            this.UpdateAuthor.Location = new System.Drawing.Point(14, 74);
            this.UpdateAuthor.Name = "UpdateAuthor";
            this.UpdateAuthor.Size = new System.Drawing.Size(225, 24);
            this.UpdateAuthor.TabIndex = 10;
            // 
            // UpdateTitle
            // 
            this.UpdateTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateTitle.Enabled = false;
            this.UpdateTitle.Location = new System.Drawing.Point(14, 28);
            this.UpdateTitle.Name = "UpdateTitle";
            this.UpdateTitle.Size = new System.Drawing.Size(225, 24);
            this.UpdateTitle.TabIndex = 9;
            // 
            // Search
            // 
            this.Search.Controls.Add(this.label13);
            this.Search.Controls.Add(this.label11);
            this.Search.Controls.Add(this.SearchISBN);
            this.Search.Location = new System.Drawing.Point(4, 25);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(497, 107);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoEllipsis = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(7, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(487, 48);
            this.label13.TabIndex = 19;
            this.label13.Text = "Information: Please enter the ISBN number of the book you wish to search. You wil" +
    "l see the book details once the ISBN number is entered and the search is perform" +
    "ed.";
            this.label13.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 14);
            this.label11.TabIndex = 15;
            this.label11.Text = "Book ISBN";
            // 
            // SearchISBN
            // 
            this.SearchISBN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchISBN.Location = new System.Drawing.Point(14, 28);
            this.SearchISBN.Name = "SearchISBN";
            this.SearchISBN.Size = new System.Drawing.Size(225, 24);
            this.SearchISBN.TabIndex = 11;
            // 
            // Delete
            // 
            this.Delete.Controls.Add(this.label12);
            this.Delete.Controls.Add(this.label10);
            this.Delete.Controls.Add(this.DeleteISBN);
            this.Delete.Location = new System.Drawing.Point(4, 25);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(497, 107);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoEllipsis = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(7, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(487, 48);
            this.label12.TabIndex = 18;
            this.label12.Text = "Warning: You are about to delete data from the database according to the ISBN you" +
    "\'re given in the input box. This action cannot be undone.";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 14);
            this.label10.TabIndex = 17;
            this.label10.Text = "Book ISBN";
            // 
            // DeleteISBN
            // 
            this.DeleteISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteISBN.Location = new System.Drawing.Point(14, 28);
            this.DeleteISBN.Name = "DeleteISBN";
            this.DeleteISBN.Size = new System.Drawing.Size(225, 24);
            this.DeleteISBN.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.RunButton);
            this.groupBox2.Controls.Add(this.SqlComments);
            this.groupBox2.Controls.Add(this.QueryStatusProgress);
            this.groupBox2.Location = new System.Drawing.Point(523, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 136);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Query Status";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(6, 107);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(83, 23);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "Run Query";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // SqlComments
            // 
            this.SqlComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SqlComments.Cursor = System.Windows.Forms.Cursors.No;
            this.SqlComments.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlComments.Location = new System.Drawing.Point(6, 20);
            this.SqlComments.Name = "SqlComments";
            this.SqlComments.ReadOnly = true;
            this.SqlComments.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.SqlComments.Size = new System.Drawing.Size(311, 81);
            this.SqlComments.TabIndex = 0;
            this.SqlComments.Text = "";
            // 
            // QueryStatusProgress
            // 
            this.QueryStatusProgress.ForeColor = System.Drawing.SystemColors.GrayText;
            this.QueryStatusProgress.Location = new System.Drawing.Point(95, 107);
            this.QueryStatusProgress.Name = "QueryStatusProgress";
            this.QueryStatusProgress.Size = new System.Drawing.Size(222, 23);
            this.QueryStatusProgress.TabIndex = 0;
            // 
            // Index
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Format = "0";
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.DefaultCellStyle = dataGridViewCellStyle3;
            this.Index.FillWeight = 30F;
            this.Index.HeaderText = "#";
            this.Index.MaxInputLength = 999;
            this.Index.MinimumWidth = 30;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // isbn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.isbn.DefaultCellStyle = dataGridViewCellStyle4;
            this.isbn.FillWeight = 159.1878F;
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            // 
            // title
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.title.DefaultCellStyle = dataGridViewCellStyle5;
            this.title.FillWeight = 238.7817F;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // author
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.author.DefaultCellStyle = dataGridViewCellStyle6;
            this.author.FillWeight = 159.1878F;
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // qtn
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.Format = "00";
            dataGridViewCellStyle7.NullValue = "0";
            this.qtn.DefaultCellStyle = dataGridViewCellStyle7;
            this.qtn.FillWeight = 50F;
            this.qtn.HeaderText = "Quantity";
            this.qtn.MinimumWidth = 50;
            this.qtn.Name = "qtn";
            this.qtn.ReadOnly = true;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ActionsPane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DBStatusStrip);
            this.Controls.Add(this.DBView);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(875, 500);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.App_Load);
            this.DBView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseView)).EndInit();
            this.DBStatusStrip.ResumeLayout(false);
            this.DBStatusStrip.PerformLayout();
            this.ActionsPane.ResumeLayout(false);
            this.New.ResumeLayout(false);
            this.New.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewQnt)).EndInit();
            this.Update.ResumeLayout(false);
            this.Update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateQnt)).EndInit();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.Delete.ResumeLayout(false);
            this.Delete.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DBView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip DBStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Queries;
        private System.Windows.Forms.ToolStripStatusLabel SuccessQueries;
        private System.Windows.Forms.ToolStripStatusLabel ProblemQueries;
        private System.Windows.Forms.ToolStripStatusLabel DBStatus;
        private System.Windows.Forms.TabControl ActionsPane;
        private System.Windows.Forms.TabPage New;
        private System.Windows.Forms.TabPage Update;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.TabPage Delete;
        private System.Windows.Forms.TextBox NewAuthor;
        private System.Windows.Forms.TextBox NewTitle;
        private System.Windows.Forms.TextBox NewISBN;
        private System.Windows.Forms.NumericUpDown NewQnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox SqlComments;
        private System.Windows.Forms.ProgressBar QueryStatusProgress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown UpdateQnt;
        private System.Windows.Forms.TextBox UpdateISBN;
        private System.Windows.Forms.TextBox UpdateAuthor;
        private System.Windows.Forms.TextBox UpdateTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SearchISBN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DeleteISBN;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DataBaseView;
        private System.Windows.Forms.Button FindISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtn;
    }
}