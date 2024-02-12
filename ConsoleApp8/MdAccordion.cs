namespace EsercizioMd;

public class MdAccordion : IMenuItem
{
    public string text { get; set; }
    public string MdSyntax { get; set; }
    public List<string> Accordion { get; set; }
    public string MdSyntaxTitle { get; set; }
    public string MdSyntaxAccordion { get; set; }

    public MdAccordion()
    {
        MdSyntaxTitle = $"- ";
        Accordion = new List<string>();
        MdSyntaxAccordion = $"   - ";
    }

    public string AddTitle()
    {
        Console.Write("Inserisci il titolo dell'Accordion: ");
        string AccordionTitle = MdSyntaxTitle + Console.ReadLine();
        return AccordionTitle;
    }

    public void AddItem()
    {
        int n;
        Console.WriteLine("Inserisci con quanti item popolare l'accordion: ");
        string input = Console.ReadLine();

        while (!int.TryParse(input, out n))
        {
            Console.WriteLine("Rinserire l'input o Dato obbligatorio");
            input = Console.ReadLine();
        }

        for (int i = 0; i < n; i++)
        {
            string isLink = "";
            Console.Write("L'item è un link? (y/n): ");
            isLink = Console.ReadLine();

            if (isLink == "y")
            {
                Console.Write("Inserisci il nome del Link: ");
                string LinkText = Console.ReadLine();
                Console.Write("Inserisci l'indirizzo del Link: ");
                string LinkAddress = Console.ReadLine();

                MdLink link = new MdLink(LinkText, LinkAddress);
                string item = $"{MdSyntaxAccordion} {link.GetMdLink()}";
                Accordion.Add(item);
            }
            else
            {
                Console.Write("Inserire il contenuto dell'Item: ");
                string item = $"{MdSyntaxAccordion} {Console.ReadLine()}";
                Accordion.Add(item);
            }
        }
    }
}