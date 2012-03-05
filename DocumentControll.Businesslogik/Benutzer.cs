using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentControll.Businesslogik
{
    public class Benutzer
    {
        public List<Benutzer> GetAllPassivBenutzer()
        {
            return null;
        }
        
        public List<Benutzer> GetAllBenutzer()
        {
            return null;
        }

        public Benutzer GetBenutzerById(Int32 benutzerId)
        {
            return null;
        }

        public bool ExistLogin(string loginName)
        {
            return false;
        }

        public bool LoginCheck(string passwort, string loginName)
        {
            return false;
        }


        private Int32 id;
        /// <summary>
        /// Representiert ein eine Id nur get
        /// </summary>
        public Int32 Id
        {
            get { return id; }
        }

        private string nachname;
        /// <summary>
        /// Representiert ein Benuzer name, get und set bar
        /// </summary>
        public string Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }

        private string vorname;
        /// <summary>
        /// Representiert ein Vorname eines Benuzers, get und set
        /// </summary>
        public string Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }

        private string mail;
        /// <summary>
        /// Representiert eine Mail Adresse, get und set
        /// </summary>
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        private string loginName;
        /// <summary>
        /// Representiert einen einmaligen LoginName, get und set
        /// </summary>
        public string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }

        private string passwort;
        /// <summary>
        /// Representiert ein passwort in Hashform, get und set
        /// </summary>
        public string Passwort
        {
            get { return passwort; }
            set { passwort = value; }
        }

        private bool activ;
        /// <summary>
        /// Representiert den Status, , get und set
        /// </summary>
        public bool Activ
        {
            get { return activ; }
            set { activ = value; }
        }
    }
}
