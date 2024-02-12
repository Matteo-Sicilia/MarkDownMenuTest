using Spectre.Console;

namespace EsercizioMd;


class Program
{
    static void Main(string[] args)
    {

        MdTitle title = new MdTitle();
        Console.Write("Inserisci un Titolo: ");
        title.text = Console.ReadLine();



        Console.Write("Inserisci il nome del Link: ");
        string LinkText = Console.ReadLine();
        Console.Write("Inserisci l'indirizzo del Link: ");
        string LinkAddress = Console.ReadLine();

        MdLink link = new MdLink(LinkText, LinkAddress);

        Console.WriteLine(title.GetMdTitle());
        Console.WriteLine(link.GetMdLink());

        MdAccordion accordion = new MdAccordion();

        string AccordionTitle = accordion.AddTitle();
        accordion.AddItem();
        var root = new Tree(AccordionTitle);

        int counter = 0;
        foreach (var item in accordion.Accordion)
        {
            var foo = root.AddNode($"{accordion[counter]}");
            counter++;
        }

        Console.Read();

    }
}
