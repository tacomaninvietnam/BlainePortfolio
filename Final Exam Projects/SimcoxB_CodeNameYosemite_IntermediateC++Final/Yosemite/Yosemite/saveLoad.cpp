#include "Save_Load.h"
saveLoad :: saveLoad () // default constructor for saveload class
{
	FNAME = " ";
}

void saveLoad :: openF (ifstream& outfile, string name) // this function opens the outfile by asking for a name and loading a .txt from the named file so far this only applies to stats
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	
	do // this is the start of a do while loop for the exception handling
	{
	try // start a try 
	{
	SetConsoleTextAttribute(hConsole, 12);
	cout << "Enter Character Name Followed by .txt then the Enter Key" << endl;
	cout << endl;
	SetConsoleTextAttribute(hConsole, 15);
	cin >> name;
	cout << endl;
	
	outfile.open(name); // opens outfile by name

	if (!outfile.is_open ()) // if outfile doesn't open, throws name to exception
		throw name;
		
	}
	catch (string)
	{
		cout << endl;
		SetConsoleTextAttribute(hConsole, 12);
		cout << "File not Found!" << endl; // if outfile not found message
		cout << endl;
		
	}
	}while(!outfile); // stops if outfile is true.

}

void saveLoad :: loadData (ifstream& infile, string name) // this function loads the character sheet from the .txt specified
{
	wipe(); // this is a call to the functin charsheet :: wipe which initializes all variables to 0
	openF (infile, name); // call to the open file function
	infile >> NAME;  // output the NAME variable of charSheet
	for (num = 0; num <= 5; num ++)
	{
		infile >> CSTAT [num]  >> CMOD [num]; // initializes the arrays mod and cstat to the input data
	}

	infile >> HP >> AC >> LVL >> MANA >> MaxHp >> MaxMp >> EXP >> GP; // the rest of the character class variables exported from .txt
	
	

	printAll (); // prints charSheet object stats
	
}

void saveLoad :: saveData (ofstream& outfile, string name) // function loads stats onto .txt of player's naming. it is a reversed clone of LoadData
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hConsole, 12);
	cout << endl; // couldn't get the open function to write correctly seperately by reference so I integrated the coding to these four lines.
	cout << "Enter Character Name Followed by .txt then the Enter Key" << endl;
	cout << "         (use lower case for easy retrieval)" << endl;
	cout << endl;
	SetConsoleTextAttribute(hConsole, 15);
	cin >> name;
	
	outfile.open(name); // create or open new file
	
	outfile << NAME;  // from here down is the oposite of the save function with setw spacers added so the numbers don't become a single big one when read
	outfile << endl;
	for (num = 0; num <= 5; num ++)
	{
		outfile << CSTAT [num] << setw(5) << CMOD [num] << endl;
	}

	outfile << HP << setw(5) << AC << setw(5) << LVL << setw(5) << MANA << setw(5) << 
		MaxHp << setw(5) << MaxMp << setw(5) << EXP << setw(5) << GP;
	
	
	
}

ostream& operator<< (ostream& statistic, const saveLoad& character) // this is my insertion operator overload it is also in saveLoad class
{
	HANDLE  hConsole;
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	
	SetConsoleTextAttribute(hConsole, 3);
	statistic << endl;
	statistic << "This is the Overloaded << operator not the printAll() function: " << endl; // warning message alerting user of << overload
	statistic << "****************************************************************"<< endl;
	statistic << endl;
	int num = 0;
	statistic << "Character Name: " << setw(6) << character.NAME << endl;  // feeding Name variable into statistic ostream object
	statistic << endl;
	statistic << "Level" << setw(8) << character.LVL << endl; // doing the same with Level
	statistic << endl;
	string stats [6] = {"STR", "DEX", "INT", "CON", "WIS", "CHA"}; // string array for labeling y Axis
	statistic << "Ability" << setw(6) << "AS" << setw(6) << "Mod" << endl; // these are just output table labels x axis
	statistic << endl;
	for (num = 0; num <= 5; num ++) // this loop pulls the stats from their arrays and couts them
	{
		statistic << stats[num] << setw (10) // call to print the label array from line 416
		<< character.CSTAT [num] << setw(4) << "+" <<  // printing of character stats + modifier value for each stat
		character.CMOD [num] << endl;
	}
		statistic << endl; // here down is the rest of the charSheet variables
		statistic << "MP" << setw(11) << character.MANA << " / " << character.MaxMp << endl;
		statistic << "HP" << setw(11) << character.HP << " / " << character.MaxHp << endl;
		statistic << endl;
		statistic <<"AC" << setw(12) << character.getAc ();
		statistic << endl;
		statistic << "Gold" << setw(10) << character.getGp () << endl;
		statistic << endl;
		statistic << endl;
		statistic << "Total EXP:" << setw(4) << character.getExp ();

		return statistic; // returns the statistic ostream object
}

void saveLoad :: printAll () // this function will be used to print data to the screen (player info)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	cout << endl;
	cout << endl;
	SetConsoleTextAttribute(hConsole, 12);
	cout << "This is A Virtual Call to Print All;" << endl;
	cout << "************************************" << endl;
	SetConsoleTextAttribute(hConsole, 3);
	cout << "Character Name: " << setw(6) << NAME << endl;
	cout << endl;
	cout << "Level" << setw(8) << LVL << endl;
	cout << endl;
	string stats [6] = {"STR", "DEX", "INT", "CON", "WIS", "CHA"};
	cout << "Ability" << setw(6) << "AS" << setw(6) << "Mod" << endl;
	cout << endl;
	for (num = 0; num <= 5; num ++) // this loop pulls the stats from their arrays and couts them
	{
		cout << stats[num] << setw (10)
		<< CSTAT [num] << setw(4) << "+" <<
		CMOD [num] << endl;
	}
		cout << endl; // here down is all cout statements for the charSheet
		cout << "MP" << setw(11) << MANA << " / " << MaxMp << endl;
		cout << "HP" << setw(11) << HP << " / " << MaxHp << endl;
		cout << endl;
		cout <<"AC" << setw(12) << getAc ();
		cout << endl;
		cout << "Gold" << setw(10) << getGp () << endl;
		cout << endl;
		cout << endl;
		cout << "Total EXP:" << setw(4) << getExp ();
		
}
