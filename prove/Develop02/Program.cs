using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();

        journalMenu.ProcessMenu();
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