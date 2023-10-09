using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace winform_mvvm
{
    public class CustomerViewModel : IDisposable
    {
        private masterEntities db;
        public CustomerViewModel() => db = new masterEntities();
        public BindingSource CustomerBindingSource { get; set; }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Load()
        {
            db.Customers.Load();
            CustomerBindingSource.DataSource = db.Customers.Local.ToBindingList();

        }
        public void Delete() => CustomerBindingSource.RemoveCurrent();

        public void New() => CustomerBindingSource.AddNew();

        public void Save()
        {
            CustomerBindingSource.EndEdit();
            db.SaveChanges();
        }

    
    }
}
