using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        [StringLength(20)]
        public string TName { get; set; }
        [StringLength(20)]
        public string TSurname { get; set; }



    }
}
