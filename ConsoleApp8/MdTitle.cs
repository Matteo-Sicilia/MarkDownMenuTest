namespace EsercizioMd;

public class MdTitle : IMenuItem
{
    public string text { get; set; }
    public string MdSyntax { get; set; }

    public MdTitle()
    {
        MdSyntax = "# ";
    }

    public string GetMdTitle()
    {
        return (MdSyntax + text);
    }
}
