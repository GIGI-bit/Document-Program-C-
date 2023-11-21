using DocumentProj;

while (true)
{

    Console.WriteLine("Enter data: ");

    string userData = Console.ReadLine();

    if (userData == "basic")
    {
        DocumentProgram documentProgram = new DocumentProgram();
        documentProgram.OpenDocument();
        documentProgram.SaveDocument();
        documentProgram.EditDocument();
    }
    else if (userData == "pro")
    {
        DocumentProgram proDocumentProgram = new ProDocumentProgram();
        proDocumentProgram.OpenDocument();
        proDocumentProgram.SaveDocument();
        proDocumentProgram.EditDocument();
    }
    else if (userData == "expert")
    {
        DocumentProgram expertDocument = new ExpertDocument();
        expertDocument.OpenDocument();
        expertDocument.SaveDocument();
        expertDocument.EditDocument();
    }



}
