using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    // Class này dùng để quản lý dữ liệu nhân viên (Slide 140)
    public class Employee
    {
        public string Id { get; set; }      // Mã nhân viên
        public string Name { get; set; }    // Tên nhân viên
        public int Age { get; set; }        // Tuổi
        public bool Gender { get; set; }    // Giới tính (True = Nam, False = Nữ)
    }
}