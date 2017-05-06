using Carnet_AdressesMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnet_AdressesMVVM.ViewModel
{
    public class ContactViewModel
    {
        private Contacts_dbEntities _entity;


        private List<ContactTable> _listContacts;

        public List<ContactTable> ListContacts
        {
            get { return _listContacts; }
            set { _listContacts = value; }
        }

        private ContactTable _contactCourant;

        public ContactTable ContactCourant
        {
            get { return _contactCourant; }
            set { _contactCourant = value; }
        }




        public ContactViewModel()
        {
            _entity = new Contacts_dbEntities();
            this._listContacts = new List<ContactTable>((_entity.ContactTables.OrderBy(a => a.Nom)));
            this._contactCourant = this.ListContacts[0];
           // ObservableCollection<ContactTable> contact = new ObservableCollection<ContactTable>(context.ContactTables);
        }
    }
}
