	using System;

namespace ConsoleAplicaton
{
    class Allclasses
    {
        static void Main(string[] args)
        {
            DocumentWorker docwor;
            Console.Write("Enter key: ");
            string key = Console.ReadLine();

            if (key=="pro")
                docwor = new ProDocumentWorker();
            else if (key=="exp")
                docwor = new ExpertDocumentWorker();
            else
                docwor = new DocumentWorker();

            docwor.OpenDocument();
            docwor.EditDocument();
            docwor.SaveDocument();
        }   
        class DocumentWorker
        {
        public void OpenDocument()
        {
            Console.WriteLine("Open Document");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Document editing is available in the Pro version.");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving a document is available in the Pro version.");
        }
       
        }
        class ProDocumentWorker:DocumentWorker
        {
        public override void EditDocument()
        {
            Console.WriteLine("Document edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in the old format, saving in other formats is available in the Expert version");
        }
        
        }
         class ExpertDocumentWorker:ProDocumentWorker
        {
        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in a new format");
        }
        }
    }
}
