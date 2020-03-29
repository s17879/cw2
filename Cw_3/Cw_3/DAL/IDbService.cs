using System.Collections.Generic;
using Cw_3.Models;

namespace Cw_3.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
