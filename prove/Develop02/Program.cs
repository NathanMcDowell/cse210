using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();
        int userSelection;
        userSelection = journalMenu.ProcessMenu();

        switch(userSelection)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
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