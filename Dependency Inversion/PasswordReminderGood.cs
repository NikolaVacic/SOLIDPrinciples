using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ova klasa sad ne zavisi od konkretne klase vec od apstrakcije odnosno interfejsa.

// sada ova klasa i mysqlConnectionGood klasa zavise od apstrakcija cime je princip zadovoljen

namespace Dependency_Inversion
{
    class PasswordReminderGood
    {
        private DatabaseConnectionInterface baza;

        PasswordReminderGood(DatabaseConnectionInterface b)
        {
            this.baza = b;
        }
    }
}
