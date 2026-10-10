namespace _5._4
{
    public partial class Form1 : Form
    {
        private Company? company;
        private List<Employee>? allEmployees;

        public Form1()
        {
            InitializeComponent();
            tvDepartments.HandleCreated += (_, _) => tvDepartments.ExpandAll();
            InitializeImages();
            Load += Form1_Load;
            tvDepartments.AfterSelect += TvDepartments_AfterSelect;
            cmbViewMode.SelectedIndexChanged += CmbViewMode_SelectedIndexChanged;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            InitializeData();
            LoadTreeView();
        }

        private void InitializeImages()
        {
            imageList1.Images.Add("folder", SystemIcons.WinLogo);
            imageList1.Images.Add("subfolder", SystemIcons.Application);
            imageList1.Images.Add("file", SystemIcons.Information);
        }

        /// <summary>
        /// Khởi tạo dữ liệu mẫu
        /// </summary>
        private void InitializeData()
        {
            company = new Company("ACME");
            allEmployees = new List<Employee>();

            Department hr = new Department("HR");
            hr.AddNhanVien(new Employee("NV001", "Nguyễn Văn A", "Trưởng phòng nhân sự", new DateTime(2019, 5, 1), "HR"));
            hr.AddNhanVien(new Employee("NV002", "Trần Thị B", "Chuyên viên nhân sự", new DateTime(2021, 6, 20), "HR"));
            hr.AddNhanVien(new Employee("NV003", "Hoàng Văn C", "Chuyên viên tuyển dụng", new DateTime(2022, 3, 10), "HR"));

            Department it = new Department("IT");
            Group development = new Group("Development");
            development.NhanViens.Add(new Employee("NV004", "Phạm Thị D", "Lập trình viên", new DateTime(2020, 1, 15), "IT"));
            development.NhanViens.Add(new Employee("NV005", "Lê Văn E", "Lập trình viên Senior", new DateTime(2021, 4, 5), "IT"));
            development.NhanViens.Add(new Employee("NV006", "Đỗ Văn F", "Lập trình viên", new DateTime(2022, 2, 28), "IT"));

            Group support = new Group("Support");
            support.NhanViens.Add(new Employee("NV007", "Vũ Thị G", "Trưởng nhóm hỗ trợ", new DateTime(2019, 8, 15), "IT"));
            support.NhanViens.Add(new Employee("NV008", "Bùi Văn H", "Kỹ thuật viên", new DateTime(2023, 1, 10), "IT"));

            it.AddGroup(development);
            it.AddGroup(support);
            it.AddNhanVien(new Employee("NV009", "Đinh Thị I", "Trưởng phòng IT", new DateTime(2019, 3, 10), "IT"));

            Department sales = new Department("Sales");
            sales.AddNhanVien(new Employee("NV010", "Giang Văn K", "Trưởng phòng kinh doanh", new DateTime(2019, 7, 20), "Sales"));
            sales.AddNhanVien(new Employee("NV011", "Hà Thị L", "Nhân viên kinh doanh", new DateTime(2021, 9, 5), "Sales"));
            sales.AddNhanVien(new Employee("NV012", "Kiều Văn M", "Nhân viên kinh doanh", new DateTime(2022, 12, 1), "Sales"));

            company.AddPhongBan(hr);
            company.AddPhongBan(it);
            company.AddPhongBan(sales);

            // Collect all employees
            foreach (var dept in company.PhongBans)
            {
                allEmployees.AddRange(dept.NhanViens);
                foreach (var group in dept.Groups)
                {
                    allEmployees.AddRange(group.NhanViens);
                }
            }
        }

        /// <summary>
        /// Nạp dữ liệu vào TreeView
        /// </summary>
        private void LoadTreeView()
        {
            tvDepartments.Nodes.Clear();

            if (company == null) return;

            // Thêm nút công ty
            TreeNode companyNode = new TreeNode(company.TenCongTy);
            companyNode.ImageKey = "folder";
            companyNode.SelectedImageKey = "folder";
            companyNode.Tag = company;

            // Thêm các phòng ban
            foreach (var dept in company.PhongBans)
            {
                TreeNode deptNode = new TreeNode(dept.TenPhongBan);
                deptNode.ImageKey = "folder";
                deptNode.SelectedImageKey = "folder";
                deptNode.Tag = dept;

                // Thêm các nhóm trong phòng ban
                foreach (var group in dept.Groups)
                {
                    TreeNode groupNode = new TreeNode(group.TenNhom);
                    groupNode.ImageKey = "subfolder";
                    groupNode.SelectedImageKey = "subfolder";
                    groupNode.Tag = group;
                    deptNode.Nodes.Add(groupNode);
                }

                companyNode.Nodes.Add(deptNode);
            }

            tvDepartments.Nodes.Add(companyNode);
            tvDepartments.ExpandAll();
            tvDepartments.SelectedNode = companyNode;
        }

        /// <summary>
        /// Xử lý sự kiện khi chọn nút trên TreeView
        /// </summary>
        private void TvDepartments_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            lsvEmployees.Items.Clear();

            if (e.Node?.Tag is Company)
            {
                // Hiển thị tất cả nhân viên
                LoadEmployeesToListView(allEmployees!);
            }
            else if (e.Node?.Tag is Department dept)
            {
                // Hiển thị nhân viên của phòng ban
                var employees = new List<Employee>();
                employees.AddRange(dept.NhanViens);
                foreach (var group in dept.Groups)
                {
                    employees.AddRange(group.NhanViens);
                }
                LoadEmployeesToListView(employees);
            }
            else if (e.Node?.Tag is Group group)
            {
                // Hiển thị nhân viên của nhóm
                LoadEmployeesToListView(group.NhanViens);
            }
        }

        /// <summary>
        /// Nạp danh sách nhân viên vào ListView
        /// </summary>
        private void LoadEmployeesToListView(List<Employee> employees)
        {
            lsvEmployees.Items.Clear();

            foreach (var emp in employees)
            {
                ListViewItem item = new ListViewItem(emp.MaNV);
                item.SubItems.Add(emp.HoTen);
                item.SubItems.Add(emp.ChucVu);
                item.SubItems.Add(emp.NgayVaoLam.ToString("dd/MM/yyyy"));
                item.ImageKey = "file";
                item.Tag = emp;
                lsvEmployees.Items.Add(item);
            }
        }

        /// <summary>
        /// Xử lý sự kiện đổi chế độ xem ListView
        /// </summary>
        private void CmbViewMode_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbViewMode.SelectedItem is string mode)
            {
                switch (mode)
                {
                    case "Details":
                        lsvEmployees.View = View.Details;
                        break;
                    case "LargeIcon":
                        lsvEmployees.View = View.LargeIcon;
                        break;
                    case "SmallIcon":
                        lsvEmployees.View = View.SmallIcon;
                        break;
                    case "Tile":
                        lsvEmployees.View = View.Tile;
                        break;
                    case "List":
                        lsvEmployees.View = View.List;
                        break;
                }
            }
        }

        private void cmbViewMode_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lsvEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
