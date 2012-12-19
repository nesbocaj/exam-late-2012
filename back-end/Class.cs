using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class Class : IModel
    {
        private int _classId, _classRoomId, _personId, _courseId;
        private string _courseName;

        public int ID
        {
            set { _classId = value; }
            get { return _classId; }
        }

        public int RoomID
        {
            set { _classRoomId = value; }
            get { return _classRoomId; }
        }

        public int PersonID
        {
            set { _personId = value; }
            get { return _personId; }
        }

        public int CourseID
        {
            set { _courseId = value; }
            get { return _courseId; }
        }

        public string CourseName
        {
            set { _courseName = value; }
            get { return _courseName; }
        }

        public void Upadte()
        {

        }
    }
}
