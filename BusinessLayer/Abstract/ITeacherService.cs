using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITeacherSevice
    {
        public int AddTeacher(Teacher t);
        public int DeleteTeacher(Teacher t);
        public int UpdateTeacher(Teacher t);
        List<Teacher> ListAllTeacher(Expression<Func<Teacher, bool>> filter = null);

        Teacher GetById(int id);

    }
}
