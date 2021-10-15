using System;
using System.Collections.Generic;
using System.Text;

namespace TugasKelompok
{
    class Admin : User
    {        public Admin(string namaDepan, string namaBelakang, string userName, string password, bool admin) : base(namaDepan, namaBelakang, userName, password, admin) 
        {
          
        }                
    }
}
