using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class Class : IModel
    {
        private uint _id, _roomId;
        private string _name;
        private Course _course;
        private Tutor _tutor;

        public uint ID
        {
            set { _id = value; }
            get { return _id; }
        }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public uint RoomID
        {
            set { _roomId = value; }
            get { return _roomId; }
        }

        public Course Course
        {
            get { return _course; }
            set { _course = value; }
        }

        public Tutor Tutor
        {
            get { return _tutor; }
            set { _tutor = value; }
        }

        public void Update()
        {

        }
    }
}
