using BusinessLayer.Abstract;
using DataAccess.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeacherMan : ITeacherSevice
    {
        ITeacherDAL teacherDAL;
        Teacher teacher;

        public TeacherMan()
        {
            this.teacherDAL = teacherDAL;
        }

        public int AddTeacher(Teacher t)
        {
            return teacherDAL.Add(t);
        }

        public int DeleteTeacher(Teacher t)
        {
            return teacherDAL.Delete(t);
        }

        public Teacher GetById(int id)
        {
            return teacherDAL.GetById(id);
        }

        public List<Teacher> ListAllTeacher(Expression<Func<Teacher, bool>> filter = null)
        {
            return teacherDAL.ListAll();
        }

        public int UpdateTeacher(Teacher t)
        {
            return teacherDAL.Update(t);
        }
    }
}
