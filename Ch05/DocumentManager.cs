using System;
using System.Collections.Generic;

namespace ProCSharp.Ch05
{
    public class DocumentManager<TDocument>
        where TDocument : IDocument
    {
        private readonly Queue<TDocument> documentQueue = new Queue<TDocument>();

        public void AddDocument(TDocument doc)
        {
            lock (this)
            {
                documentQueue.Enqueue(doc);
            }
        }

        public bool IsDocumentAvailable
        {
            get { return documentQueue.Count > 0; }
        }

        public TDocument GetDocument()
        {
            TDocument doc = default(TDocument);
            lock (this)
            {
                doc = documentQueue.Dequeue();
            }
            return doc;
        }

        public void DisplayAllDocuments()
        {
            foreach (TDocument doc in documentQueue)
            {
                Console.WriteLine(((TDocument)doc).Title);
            }
        }
    }
}