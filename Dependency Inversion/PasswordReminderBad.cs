using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ova klasa je high level modul

// Ova implementacija je losa jer sad ova klasa zavisi od MySQLConnectionBad(lowlevel) klase.

// PasswordReminder klasa ne bi trebalo da brine o tome da li mi koristimo MySQL ili MondoDB ili PostgreSQL
// zato treba implementirati interfejs(apstrakciju) od koje ce zavisiti obe klase.

// Ako bi hteli da promenimo bazu podataka morali bi da menjamo i ovu klasu sto bi prekrsili open closed princip.

namespace Dependency_Inversion
{
    class PasswordReminderBad
    {
        private MySQLConnectionBad baza;

        public PasswordReminderBad(MySQLConnectionBad b)
        {
            this.baza = b;
        }
    }
}
