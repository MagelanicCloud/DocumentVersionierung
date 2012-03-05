using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentControll.Businesslogik
{
    public class Document
    {
        public List<DocumentHistory> GetDocumentHistory()
        { 
            return null;
        }

        public List<Document> GetAllDocument()
        {
            return null;
        }
        
        public void AddDocument(Document doc)
        {
           
        }

        public void UpdateDocument(Document doc)
        {

        }

        public Document GetDocumentById(Int32 id)
        {
            return null;
        }

        
        public List<Document> GetDocumentByBenutzerId(Int32 userId)
        {
            return null;
        }

        public List<Document> GetDocumentByGruppenId(Int32 gruppenId)
        {
            return null;
        }

        
        private Int32 id;
        /// <summary>
        /// Identifiziert ein Dokument nur get
        /// </summary>
        public Int32 Id
        {
            get { return id; }
        }

        private string anzeigenamen;
        /// <summary>
        /// Representiert den Name eines Projektes, get und set
        /// </summary>
        public string Anzeigenamen
        {
            get { return anzeigenamen; }
            set { anzeigenamen = value; }
        }

        private string vorschaubild;
        /// <summary>
        /// Representiert den Speichernamen
        /// </summary>
        /// /// <!--Eventuel nur get bzw. set wird generiert-->
        public string Vorschaubild
        {
            get { return vorschaubild; }
            set { vorschaubild = value; }
        }

        private string beschreibung;
        /// <summary>
        /// Representiert die Dokument Beschreibung, get und set
        /// </summary>
        public string Beschreibung
        {
            get { return beschreibung; }
            set { beschreibung = value; }
        }


    }
}
