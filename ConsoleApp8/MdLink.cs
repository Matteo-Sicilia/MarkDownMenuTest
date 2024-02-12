namespace EsercizioMd;

public class MdLink : IMenuItem
{
    public string text { get; set; }
    public string address { get; set; }
    public string MdSyntax { get; set; }
    public string MdSyntaxText { get; set; }
    public string MdSyntaxAddress { get; set; }

    public MdLink(string text, string address)
    {
        this.text = text;
        this.address = address;
        MdSyntaxText = "[" + this.text + "]";
        MdSyntaxAddress = "(" + this.address + ")";
    }

    public string GetMdLink()
    {
        return (MdSyntaxText + MdSyntaxAddress);
    }
}