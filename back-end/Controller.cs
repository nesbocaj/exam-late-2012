using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    public class Controller
    {
        private static Controller _instance;
        private Catalog<Employee> _employeeCatalog;
        private Catalog<Tutor> _tutorCatalog;
        private Catalog<Class> _classCatalog;

        private Controller()
        {
            _employeeCatalog = new Catalog<Employee>();
            _tutorCatalog = new Catalog<Tutor>();
            _classCatalog = new Catalog<Class>();
        }

        public static Controller Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Controller();

                return _instance;
            }
        }

        public List<T> Search<T>(string input) where T : IModel
        {
            return default(List<T>);
        }
    }
}
