using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class Course : IModel
    {
        private uint _id, _courseTypeId, _diffiulty;
        private string _name;
        private double _price;
        private List<Course> requiredCourses;

        public Course()
        {

        }

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

        public uint TypeID
        {
            set { _courseTypeId = value; }
            get { return _courseTypeId; }
        }

        public uint Difficulty
        {
            set { _diffiulty = value; }
            get { return _diffiulty; }
        }

        public double Price
        {
            set { _price = value; }
            get { return _price; }
        }

        public void Update()
        {

        }
    }
}
