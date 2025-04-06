namespace EDHitchhiker
{
    partial class frmMain
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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            lblSystemName = new Label();
            gridBodies = new DataGridView();
            lblHonked = new Label();
            lblBodies = new Label();
            lblBodyCount = new Label();
            gridRoute = new DataGridView();
            Fuel = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            imgList = new ImageList(components);
            lblJumps = new Label();
            lblFlying = new Label();
            lblFuel = new Label();
            lblAboutFuel = new Label();
            BodyIcon = new DataGridViewImageColumn();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            bodyColumn = new DataGridViewTextBoxColumn();
            typeColumn = new DataGridViewTextBoxColumn();
            elColumn = new DataGridViewCheckBoxColumn();
            waterColumn = new DataGridViewCheckBoxColumn();
            ammColumn = new DataGridViewCheckBoxColumn();
            terrColumn = new DataGridViewCheckBoxColumn();
            SurfaceScanned = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridBodies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridRoute).BeginInit();
            SuspendLayout();
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSystemName.Location = new Point(12, 31);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(137, 21);
            lblSystemName.TabIndex = 2;
            lblSystemName.Text = "<System Name>";
            // 
            // gridBodies
            // 
            gridBodies.AllowUserToAddRows = false;
            gridBodies.AllowUserToDeleteRows = false;
            gridBodies.AllowUserToResizeColumns = false;
            gridBodies.AllowUserToResizeRows = false;
            gridBodies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gridBodies.BackgroundColor = SystemColors.ControlLightLight;
            gridBodies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBodies.Columns.AddRange(new DataGridViewColumn[] { BodyIcon, dataGridViewImageColumn1, bodyColumn, typeColumn, elColumn, waterColumn, ammColumn, terrColumn, SurfaceScanned });
            gridBodies.GridColor = SystemColors.WindowText;
            gridBodies.Location = new Point(12, 74);
            gridBodies.MultiSelect = false;
            gridBodies.Name = "gridBodies";
            gridBodies.ReadOnly = true;
            gridBodies.RowHeadersVisible = false;
            gridBodies.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridBodies.Size = new Size(797, 675);
            gridBodies.TabIndex = 3;
            gridBodies.CellValueChanged += gridBodies_CellValueChanged;
            // 
            // lblHonked
            // 
            lblHonked.AutoSize = true;
            lblHonked.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHonked.ForeColor = Color.Silver;
            lblHonked.Location = new Point(124, 52);
            lblHonked.Name = "lblHonked";
            lblHonked.Size = new Size(70, 21);
            lblHonked.TabIndex = 4;
            lblHonked.Text = "Honked";
            // 
            // lblBodies
            // 
            lblBodies.AutoSize = true;
            lblBodies.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBodies.Location = new Point(12, 52);
            lblBodies.Name = "lblBodies";
            lblBodies.Size = new Size(106, 19);
            lblBodies.TabIndex = 6;
            lblBodies.Text = "System Bodies";
            // 
            // lblBodyCount
            // 
            lblBodyCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBodyCount.Location = new Point(650, 52);
            lblBodyCount.Name = "lblBodyCount";
            lblBodyCount.RightToLeft = RightToLeft.No;
            lblBodyCount.Size = new Size(159, 19);
            lblBodyCount.TabIndex = 9;
            lblBodyCount.Text = "0/0";
            lblBodyCount.TextAlign = ContentAlignment.TopRight;
            // 
            // gridRoute
            // 
            gridRoute.AllowUserToAddRows = false;
            gridRoute.AllowUserToDeleteRows = false;
            gridRoute.AllowUserToResizeColumns = false;
            gridRoute.AllowUserToResizeRows = false;
            gridRoute.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridRoute.BackgroundColor = SystemColors.ControlLightLight;
            gridRoute.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRoute.Columns.AddRange(new DataGridViewColumn[] { Fuel, dataGridViewTextBoxColumn1, Type, dataGridViewTextBoxColumn2 });
            gridRoute.GridColor = SystemColors.WindowText;
            gridRoute.Location = new Point(829, 74);
            gridRoute.MultiSelect = false;
            gridRoute.Name = "gridRoute";
            gridRoute.ReadOnly = true;
            gridRoute.RowHeadersVisible = false;
            gridRoute.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridRoute.Size = new Size(516, 675);
            gridRoute.TabIndex = 10;
            gridRoute.CellFormatting += gridRoute_CellFormatting;
            // 
            // Fuel
            // 
            Fuel.HeaderText = "Fuel";
            Fuel.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Fuel.Name = "Fuel";
            Fuel.ReadOnly = true;
            Fuel.Resizable = DataGridViewTriState.False;
            Fuel.Width = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "System";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn1.Width = 250;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Distance/LY";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn2.Width = 80;
            // 
            // imgList
            // 
            imgList.ColorDepth = ColorDepth.Depth8Bit;
            imgList.ImageStream = (ImageListStreamer)resources.GetObject("imgList.ImageStream");
            imgList.TransparentColor = Color.Transparent;
            imgList.Images.SetKeyName(0, "fuel-icon-256x256.png");
            imgList.Images.SetKeyName(1, "blank-256x.png");
            imgList.Images.SetKeyName(2, "planet.png");
            imgList.Images.SetKeyName(3, "star.png");
            // 
            // lblJumps
            // 
            lblJumps.AutoSize = true;
            lblJumps.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblJumps.Location = new Point(829, 52);
            lblJumps.Name = "lblJumps";
            lblJumps.Size = new Size(61, 19);
            lblJumps.TabIndex = 11;
            lblJumps.Text = "0 jumps";
            // 
            // lblFlying
            // 
            lblFlying.AutoSize = true;
            lblFlying.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFlying.Location = new Point(12, 9);
            lblFlying.Name = "lblFlying";
            lblFlying.Size = new Size(21, 19);
            lblFlying.TabIndex = 12;
            lblFlying.Text = "...";
            // 
            // lblFuel
            // 
            lblFuel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFuel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFuel.Location = new Point(1239, 52);
            lblFuel.Name = "lblFuel";
            lblFuel.RightToLeft = RightToLeft.No;
            lblFuel.Size = new Size(106, 19);
            lblFuel.TabIndex = 13;
            lblFuel.Text = "0.00/0.00";
            lblFuel.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAboutFuel
            // 
            lblAboutFuel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAboutFuel.AutoSize = true;
            lblAboutFuel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAboutFuel.Location = new Point(1125, 52);
            lblAboutFuel.Name = "lblAboutFuel";
            lblAboutFuel.Size = new Size(119, 19);
            lblAboutFuel.TabIndex = 14;
            lblAboutFuel.Text = "Last fuel update:";
            // 
            // BodyIcon
            // 
            BodyIcon.HeaderText = " ";
            BodyIcon.ImageLayout = DataGridViewImageCellLayout.Stretch;
            BodyIcon.Name = "BodyIcon";
            BodyIcon.ReadOnly = true;
            BodyIcon.Width = 34;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.HeaderText = "Fuel";
            dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.ReadOnly = true;
            dataGridViewImageColumn1.Width = 34;
            // 
            // bodyColumn
            // 
            bodyColumn.HeaderText = "Body";
            bodyColumn.Name = "bodyColumn";
            bodyColumn.ReadOnly = true;
            bodyColumn.Resizable = DataGridViewTriState.False;
            bodyColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            bodyColumn.Width = 250;
            // 
            // typeColumn
            // 
            typeColumn.HeaderText = "Type";
            typeColumn.Name = "typeColumn";
            typeColumn.ReadOnly = true;
            typeColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            typeColumn.Width = 140;
            // 
            // elColumn
            // 
            elColumn.FlatStyle = FlatStyle.Flat;
            elColumn.HeaderText = "Earth Like";
            elColumn.Name = "elColumn";
            elColumn.ReadOnly = true;
            elColumn.Resizable = DataGridViewTriState.False;
            elColumn.Width = 80;
            // 
            // waterColumn
            // 
            waterColumn.FlatStyle = FlatStyle.Flat;
            waterColumn.HeaderText = "Water";
            waterColumn.Name = "waterColumn";
            waterColumn.ReadOnly = true;
            waterColumn.Resizable = DataGridViewTriState.False;
            waterColumn.Width = 80;
            // 
            // ammColumn
            // 
            ammColumn.FlatStyle = FlatStyle.Flat;
            ammColumn.HeaderText = "Ammonia";
            ammColumn.Name = "ammColumn";
            ammColumn.ReadOnly = true;
            ammColumn.Resizable = DataGridViewTriState.False;
            ammColumn.Width = 80;
            // 
            // terrColumn
            // 
            terrColumn.FlatStyle = FlatStyle.Flat;
            terrColumn.HeaderText = "Terraform";
            terrColumn.Name = "terrColumn";
            terrColumn.ReadOnly = true;
            terrColumn.Resizable = DataGridViewTriState.False;
            terrColumn.Width = 80;
            // 
            // SurfaceScanned
            // 
            SurfaceScanned.HeaderText = "SurfaceScanned";
            SurfaceScanned.Name = "SurfaceScanned";
            SurfaceScanned.ReadOnly = true;
            SurfaceScanned.Visible = false;
            SurfaceScanned.Width = 5;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 761);
            Controls.Add(lblAboutFuel);
            Controls.Add(lblFuel);
            Controls.Add(lblFlying);
            Controls.Add(lblJumps);
            Controls.Add(gridRoute);
            Controls.Add(lblBodyCount);
            Controls.Add(lblBodies);
            Controls.Add(lblHonked);
            Controls.Add(gridBodies);
            Controls.Add(lblSystemName);
            MinimumSize = new Size(620, 200);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ED Hitchhiker";
            FormClosing += frmMain_FormClosing;
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)gridBodies).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridRoute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSystemName;
        private DataGridView gridBodies;
        private Label lblHonked;
        private Label lblBodies;
        private Label lblBodyCount;
        private DataGridView gridRoute;
        private ImageList imgList;
        private DataGridViewImageColumn Fuel;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label lblJumps;
        private Label lblFlying;
        private Label lblFuel;
        private Label lblAboutFuel;
        private DataGridViewImageColumn BodyIcon;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewTextBoxColumn bodyColumn;
        private DataGridViewTextBoxColumn typeColumn;
        private DataGridViewCheckBoxColumn elColumn;
        private DataGridViewCheckBoxColumn waterColumn;
        private DataGridViewCheckBoxColumn ammColumn;
        private DataGridViewCheckBoxColumn terrColumn;
        private DataGridViewCheckBoxColumn SurfaceScanned;
    }
}