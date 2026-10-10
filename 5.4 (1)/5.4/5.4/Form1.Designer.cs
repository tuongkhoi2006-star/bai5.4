namespace _5._4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các control
        private SplitContainer splitContainer1;
        private TreeView tvDepartments;
        private ListView lsvEmployees;
        private ImageList imageList1;
        private ComboBox cmbViewMode;
        private Panel panelRight;
        private FlowLayoutPanel panelToolbar;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("HR");
            TreeNode treeNode2 = new TreeNode("Development");
            TreeNode treeNode3 = new TreeNode("Support");
            TreeNode treeNode4 = new TreeNode("IT", new TreeNode[] { treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Sales");
            TreeNode treeNode6 = new TreeNode("ACME", new TreeNode[] { treeNode1, treeNode4, treeNode5 });
            imageList1 = new ImageList(components);
            splitContainer1 = new SplitContainer();
            tvDepartments = new TreeView();
            panelRight = new Panel();
            lsvEmployees = new ListView();
            panelToolbar = new FlowLayoutPanel();
            cmbViewMode = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelRight.SuspendLayout();
            panelToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvDepartments);
            splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelRight);
            splitContainer1.Panel2MinSize = 300;
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.TabIndex = 0;
            // 
            // tvDepartments
            // 
            tvDepartments.Dock = DockStyle.Fill;
            tvDepartments.ImageIndex = 0;
            tvDepartments.ImageList = imageList1;
            tvDepartments.Location = new Point(0, 0);
            tvDepartments.Name = "tvDepartments";
            treeNode1.Name = "";
            treeNode1.Text = "HR";
            treeNode2.Name = "";
            treeNode2.Text = "Development";
            treeNode3.Name = "";
            treeNode3.Text = "Support";
            treeNode4.Name = "";
            treeNode4.Text = "IT";
            treeNode5.Name = "";
            treeNode5.Text = "Sales";
            treeNode6.Name = "";
            treeNode6.Text = "ACME";
            tvDepartments.Nodes.AddRange(new TreeNode[] { treeNode6 });
            tvDepartments.SelectedImageIndex = 0;
            tvDepartments.Size = new Size(250, 450);
            tvDepartments.TabIndex = 0;
            tvDepartments.ExpandAll();
            // 
            // panelRight
            // 
            panelRight.Controls.Add(lsvEmployees);
            panelRight.Controls.Add(panelToolbar);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(0, 0);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(5);
            panelRight.Size = new Size(546, 450);
            panelRight.TabIndex = 0;
            // 
            // lsvEmployees
            // 
            lsvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.LargeImageList = imageList1;
            lsvEmployees.Location = new Point(5, 45);
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new Size(536, 400);
            lsvEmployees.SmallImageList = imageList1;
            lsvEmployees.TabIndex = 0;
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = View.Details;
            lsvEmployees.Columns.Add("Mã NV", 80, HorizontalAlignment.Left);
            lsvEmployees.Columns.Add("Họ Tên", 170, HorizontalAlignment.Left);
            lsvEmployees.Columns.Add("Chức vụ", 125, HorizontalAlignment.Left);
            lsvEmployees.Columns.Add("Ngày vào làm", 140, HorizontalAlignment.Left);
            // 
            // panelToolbar
            // 
            panelToolbar.Controls.Add(cmbViewMode);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.FlowDirection = FlowDirection.RightToLeft;
            panelToolbar.Location = new Point(5, 5);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Padding = new Padding(5, 5, 5, 0);
            panelToolbar.Size = new Size(536, 40);
            panelToolbar.TabIndex = 1;
            panelToolbar.WrapContents = false;
            // 
            // cmbViewMode
            // 
            cmbViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbViewMode.Items.AddRange(new object[] { "Details", "LargeIcon", "SmallIcon", "Tile" });
            cmbViewMode.Location = new Point(406, 5);
            cmbViewMode.Margin = new Padding(0);
            cmbViewMode.Name = "cmbViewMode";
            cmbViewMode.Size = new Size(120, 25);
            cmbViewMode.TabIndex = 0;
            cmbViewMode.SelectedIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Manager - TreeView & ListView";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panelToolbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
