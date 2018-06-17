using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class ClassUsuario
    {
        public int idUser { get; set; }
        public int idTypeUser { get; set; }
        public string nomUser { get; set; }
        public string apeUser { get; set; }
        public string password { get; set; }
        public string nickNameUser { get; set; }
    }
}
