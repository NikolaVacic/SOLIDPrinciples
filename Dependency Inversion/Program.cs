﻿
// Dependency Inversion princip je peti i poslednji princip u SOLID akronimu
// Ovaj princip kaze da high-level module ne smeju zavisiti od low level modula. Oba bi trebalo da zavise od apstrakcije. 

// Ovaj princip se ne nastavlja na prethodan primer

// U ovom projektu imamo klasu PasswordReminder koja se konektuje na MySQL bazu podataka.
// Postoje klase nove klase MySQLConnectionBad i PasswordReminderBad u kojima ce biti implementirano kako ne treba raditi ovo
// U klasama MySQLConnectionGood i PasswordReminderGood ce biti implementiran nacin koji postuje ovaj princip

namespace Dependency_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
