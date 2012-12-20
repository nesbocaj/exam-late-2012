using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class Course : IModel
    {
        private int _courseId, _courseTypeId, _diffiulty;
        private string _courseName;
        private double _price;

        public Course()
        {
            
        }

        public int ID
        {
            set { _courseId = value; }
            get { return _courseId; }
        }

        public int TypeID
        {
            set { _courseTypeId = value; }
            get { return _courseTypeId; }
        }

        public int Difficulty
        {
            set { _diffiulty = value; }
            get { return _diffiulty; }
        }

        public String CourseName
        {
            set { _courseName = value; }
            get { return _courseName; }
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
