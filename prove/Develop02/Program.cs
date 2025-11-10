using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();
        Journal journal = new Journal();
        
        int userSelection;

        bool done = false;

        do
        {
            userSelection = journalMenu.ProcessMenu();
            switch (userSelection)
            {
                case 1:
                    // Create a new Entry Object
                    // Call creat an that object
                    // Add the entry to the journal
                    JournalEntry journalEntry = new JournalEntry();
                    journalEntry.CreateJournalEntry();
                    journalEntry.Display();
                    journal.AddEntry(journalEntry);
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved successfully!");
                    break;

                case 4:
                    // Read from a file
                    Console.Write("Enter filename to load journal from: ");
                    string loadFile = Console.ReadLine();
                    journal.ReadFromFile(loadFile);
                    Console.WriteLine("Journal loaded successfully!");
                    break;
                case 5:
                // Quit
                    done = true;
                    break;

            }
        } while (!done);
    }
}

/* 
class Journal
list of prompts
List _entries: Entry

AddEntry(): void
DisplayAll(): void
WriteToFile(): void
ReadFromFile(): void

class JournalEntry
_date: string
_prompt: string
_userResponse: string
    Stores date and the user's input
Display(): void
CreateEntry(string _date, string _prompt, string _userResponse): void
CreateEntry(): void
*/