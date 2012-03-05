using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentControll.Businesslogik
{
    public class Gruppe
    {
        public List<Benutzer> GetBenutzerByGruppenId()
        {
            return null;
        }

        public Gruppe GetGruppeByGruppenId()
        {
            return null;
        }

        private Int32 id;
        /// <summary>
        /// Identifiziert die Gruppe, nur get
        /// </summary>
        public Int32 Id
        {
            get { return id; }
        }

        private Benutzer owner;
        /// <summary>
        /// Ist der Besitzer der Gruppe, get und set
        /// </summary>
        public Benutzer Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        private string gruppenName;
        /// <summary>
        /// Representier den Name der Gruppe, get und set
        /// </summary>
        public string GruppenName
        {
            get { return gruppenName; }
            set { gruppenName = value; }
        }

        private 

    }
}
