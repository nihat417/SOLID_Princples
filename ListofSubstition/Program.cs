#region Before_LSP


//public class Document
//{
//    private string data;
//    private string fileName;
//    public void Open() { }
//    public void Save() { }
//}
//
//
//public class ReadOnlyDocument : Document
//{
//    public void Save() 
//    {
//        throw new Exception("cant save readonly file");
//    }
//}
//
//
//public class Program
//{
//    List<Document> documents;
//
//
//
//    public void OpenAll()
//    {
//        foreach (var doc in documents)
//        {
//            doc.Open();
//        }
//    }
//
//
//    public void SaveAll()
//    {
//        foreach (var doc in documents)
//        {
//            doc.Save();
//        }
//    }
//}




#endregion


#region After_Lsp

public class Document
{
    private string data;
    private string file;


    public void Open()
    {

    }

}



public class WritableDocument:Document
{
    public void Save() { }
}


public class Project
{
    private List<Document> alldocuments;
    private List<WritableDocument> writable;

    public void OpenAll()
    {
        foreach (var doc in alldocuments)
        {
            doc.Open();
        }
    }


    public void SaveAll()
    {
        foreach (var doc in writable)
        {
            doc.Save();
        }
    }
}

#endregion