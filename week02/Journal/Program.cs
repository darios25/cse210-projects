using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool running = true;

        // ✅ Estensione creativa:
        // - Uso di separatore personalizzato per evitare problemi con virgole
        // - Visualizzazione con timestamp
        // - Gestione file robusta con controllo esistenza
        // - Interfaccia semplice e chiara

        while (running)
        {
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║         Journal Menu         ║");
            Console.WriteLine("╠══════════════════════════════╣");
            Console.WriteLine("║ 1. Scrivi una nuova voce     ║");
            Console.WriteLine("║ 2. Visualizza il diario      ║");
            Console.WriteLine("║ 3. Salva il diario su file   ║");
            Console.WriteLine("║ 4. Carica diario da file     ║");
            Console.WriteLine("║ 5. Esci                      ║");
            Console.WriteLine("╚══════════════════════════════╝");
            Console.Write("Scegli un'opzione: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Risposta: ");
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry(prompt, response);
                    myJournal.AddEntry(newEntry);
                    Console.WriteLine("Voce aggiunta!\n");
                    break;

                case "2":
                    Console.WriteLine("\n--- Diario ---");
                    myJournal.Display();
                    break;

                case "3":
                    Console.Write("Nome del file per il salvataggio: ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    Console.WriteLine("Diario salvato.\n");
                    break;

                case "4":
                    Console.Write("Nome del file da caricare: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    Console.WriteLine("Diario caricato.\n");
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Arrivederci!");
                    break;

                default:
                    Console.WriteLine("Opzione non valida. Riprova.\n");
                    break;
            }
        }


    }
}