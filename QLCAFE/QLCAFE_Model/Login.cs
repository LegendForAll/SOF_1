using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAFE_Model
{
    public class Login
    {
        private string maNV;
        private string name;
        private string userName;
        private string password;

        public string MaNV
        {
            get { return maNV; }
            set
            {
                if (value != null) maNV = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value != null) name = value;
            }
        }

        public string UserName
        {
            get { return userName; }
            set
            {
                if (value != null) userName = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (value != null) password = value;
            }
        }

        public Login(string manv, string name, string tendangnhap, string password)
        {
            MaNV = maNV;
            Name = name;
            UserName = tendangnhap;
            Password = password;
        }
    }
}
