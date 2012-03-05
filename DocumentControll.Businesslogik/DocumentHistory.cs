using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentControll.Businesslogik
{
    public class DocumentHistory
    {
        private Int32 id;
        /// <summary>
        /// Identifiziert eine Version oder History genannt, nur get
        /// </summary>
        public Int32 Id
        {
            get { return id; }
        }

        private DateTime aenderungszeit;
        /// <summary>
        /// Representiert die änderungszeit dieser version, nur get
        /// </summary>
        public DateTime Aenderungszeit
        {
            get { return aenderungszeit; }
        }

        private Document dokument;
        /// <summary>
        /// Representiert das Dokument zurück welche zur History gehört, nur get
        /// </summary>
        public Document Dokument
        {
            get { return dokument; }
        }

        private string speichername;
        /// <summary>
        /// Representiert den Speichernamen
        /// </summary>
        /// <!--Eventuel nur get bzw. set wird generiert-->
        public string Speichername
        {
            get { return speichername; }
            set { speichername = value; }
        }

        private Benutzer benutzer;
        /// <summary>
        /// Representiert den letzen benutzer der das Dokument geändert hat
        /// </summary>
        public Benutzer Benutzer
        {
            get { return benutzer; }
            set { benutzer = value; }
        }


    }
}
