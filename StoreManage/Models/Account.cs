namespace StoreManage.Models
{
    public class Account
    {
        // Các thuộc tính của lớp Account
        public int AccID { get; set; }
        public string AccName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }
        public int Status { get; set; }

        // Biến tĩnh lưu trữ instance duy nhất của Account
        private static Account _instance;

        // Đối tượng khóa để đảm bảo an toàn luồng (thread-safety)
        private static readonly object _lock = new object();

        // Constructor của Account là private để ngăn chặn việc tạo instance từ bên ngoài
        private Account() { }

        // Phương thức tĩnh để truy cập instance duy nhất
        public static Account GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Account();
                    }
                }
            }
            return _instance;
        }

        // Phương thức hiển thị thông tin tài khoản
        public void ShowInformation()
        {
            Console.WriteLine("Account Information: ID = {0}, Name = {1}, Email = {2}, Permission = {3}, Status = {4}",
                AccID, AccName, Email, Permission, Status);
        }
    }
}
