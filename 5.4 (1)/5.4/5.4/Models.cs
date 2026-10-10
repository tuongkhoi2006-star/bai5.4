namespace _5._4
{
    /// <summary>
    /// Đại diện cho một nhân viên
    /// </summary>
    public class Employee
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public string PhongBan { get; set; }

        public Employee(string maNV, string hoTen, string chucVu, DateTime ngayVaoLam, string phongBan)
        {
            MaNV = maNV;
            HoTen = hoTen;
            ChucVu = chucVu;
            NgayVaoLam = ngayVaoLam;
            PhongBan = phongBan;
        }
    }

    /// <summary>
    /// Đại diện cho một nhóm (Group)
    /// </summary>
    public class Group
    {
        public string TenNhom { get; set; }
        public List<Employee> NhanViens { get; set; }

        public Group(string tenNhom)
        {
            TenNhom = tenNhom;
            NhanViens = new List<Employee>();
        }
    }

    /// <summary>
    /// Đại diện cho một phòng ban
    /// </summary>
    public class Department
    {
        public string TenPhongBan { get; set; }
        public List<Group> Groups { get; set; }
        public List<Employee> NhanViens { get; set; }

        public Department(string tenPhongBan)
        {
            TenPhongBan = tenPhongBan;
            Groups = new List<Group>();
            NhanViens = new List<Employee>();
        }

        public void AddNhanVien(Employee employee)
        {
            NhanViens.Add(employee);
        }

        public void AddGroup(Group group)
        {
            Groups.Add(group);
        }
    }

    /// <summary>
    /// Đại diện cho công ty (Company)
    /// </summary>
    public class Company
    {
        public string TenCongTy { get; set; }
        public List<Department> PhongBans { get; set; }

        public Company(string tenCongTy)
        {
            TenCongTy = tenCongTy;
            PhongBans = new List<Department>();
        }

        public void AddPhongBan(Department department)
        {
            PhongBans.Add(department);
        }
    }
}
