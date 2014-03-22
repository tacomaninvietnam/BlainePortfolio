
#include "controller.h"

using namespace std;

controller :: controller ()
{
}
void controller :: start1()
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hConsole, 12);
	string fail = "Must Enter Y or N!"; // string failure message
	img.sword();
	do
	{
	try 
	{
		
		cout << "Would you like to play? Press Y or N. " << endl << endl;
		SetConsoleTextAttribute(hConsole, 15);
		cin >> sel;
		cout << endl;
		SetConsoleTextAttribute(hConsole, 12);
		if (sel == 'n' || sel == 'N')
			exit (1);
		else if (sel == 'y' || sel == 'Y')
			break;
		else
			throw fail;
	}
	catch (string x)
	{
		cout << endl;
		cout << endl;
		cout << x;
		cout << endl << endl;
	}
	}while(sel != 'n' || sel != 'N');
}
			
void controller :: start () // this function is the sttart of the game, give player choice of rolling new level one 
{							// or loading a previous character from the txt of the past games
	do
	{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hConsole, 12);

	cout << "Welcome to my game.  Would you like to load " << endl;
	cout << "an older character or create a new one? " << endl;
	cout << endl;
	cout << "R to roll a new character, L to load previously saved character." << endl;
	cout << endl;
	SetConsoleTextAttribute(hConsole, 15);
	cin >> sel;
	SetConsoleTextAttribute(hConsole, 12);
	cout << endl;
	if (sel == 'r' || sel == 'R')
	{
		character.generate (); // to keep the flow of objects correct all charsheet functions called through Save Load class
		break;
	}
	
	else if (sel == 'l' || sel == 'L')
	{
		character.loadData (in, name); // this gives player option to load previous stats from another game
		loadInv(in, &inv); // this is patched in but it works for loading inventory
		in.close(); // close the infile (don't want to waste memory)
		break;
	}
	
	else
	{
		cout << endl;
		cout << "Improper Input Received." << endl; // improper input handling
		cout << endl;
	}
	}while (sel != 'e' || sel != 'E');
}

int controller :: player (saveLoad *character) // this is the player's option menu, the inventory is no built yet so "under construction" is shown
{
	
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	
	char input[256] = {0}; // this is an array for storing the Ascii values for atoi () function call later
	int result = 0; // initialize result variable to 0
	do  // this will always be an option for the player so I used do while to manage these three resources.
	{
		
		SetConsoleTextAttribute(hConsole, 12);
		string fail = "Cannot use letters, integer input only with value less than 5."; // string failure message
		cout << endl;
		cout << "Choose a selection by number." << endl;
		cout << endl;
		SetConsoleTextAttribute(hConsole, 14);
		cout << "1. Show Character Sheet Which is printed to screen using" << endl;
		cout << "   a virtual call from charSheet." << endl;
		cout << endl;
		cout << "2. Player Inventory." << endl;
		cout << endl;
		cout << "3. Save Character Stats.  You may also exit from this menu." << endl;
		cout << endl;
		cout << "4. Exit player Menu and Continue." << endl;
		cout << endl;
		SetConsoleTextAttribute(hConsole, 15);

        try
		{
		cin >> input; // get the input
		cout << endl;

		result = atoi(input); // a tutor showed me this, it calls atoi from cstdlib and converts letters into integer value to check against my catch statement

		if (result < 1 || result > 4)  // if number input not in range, throw to Input failure catch.
			throw fail;
		}
		catch (string x) // prints out exception to screen 
		{
			cout << endl;
			cout << endl;
			SetConsoleTextAttribute(hConsole, 12);
			cout << x;
			cout << endl;
			cout << endl;
			cout << endl;
		}
		switch(result) // otherwise continue into switch
		{

		case 1:
			cout << endl;
			print (character); // call to charSheet printAll from saveLoad derived class
			cout<< endl;
			break;
		case 2:
			inv.inventoryMenu (character);
			break;
		case 3:
			hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
			
			SetConsoleTextAttribute(hConsole, 12);
			cout << "Press S to save your character or press E to exit game."<< endl; // these are all saveLoad options
			cout << "You may also exit this menu by pressing C." << endl << endl;
			SetConsoleTextAttribute(hConsole, 15);
			cin >> sel;
			
			if (sel == 's' || sel == 'S')
			{
				character->saveData (out, name); // this saves the charSheet data
				saveInv (out, &inv); // saves inventory
				out.close(); // closes the txt file to stop further writing
				break;
			}
			else if (sel == 'c' || sel == 'C')
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << "Improper input received." << endl;
			}
			else if (sel == 'E' || sel == 'e')
			{
				cout << "Are You sure you wnat to exit?  Y or N." << endl << endl;
				
				try
				{
					do
					{
					cin >> sel;
					if (sel == 'y' || sel == 'Y')
					exit(1);
					else if (sel == 'n' || sel == 'N')
						break;
					else
						throw fail;
					}while (sel != 'n' || sel != 'N');
				}
				
				catch (string x) // prints out exception to screen 
				{
					cout << endl;
					SetConsoleTextAttribute(hConsole, 12);
					cout << x;
					cout << endl;
				}
			}
			else
			break;
		
		default:
			break;
		}
		
		
	}while(result != 4);
	return 1;
}

void controller :: loadInv (ifstream& infile, inventory *inv) // this is the patch for inventory loading
{
	infile >> inv->magicP >> inv->hpP; // inputs number of potions
	infile >> equipH; // helmet variables
	if (equipH == 1)  // these next three blocks check for a number value of one and set bool vars to true if one detected
		inv->equipHm = true; // sets bool to true
	else
		inv->equipHm = false; // false if not a 1
	infile >> inv->Helm; // retrieves number of items from inventory;
	if (inv->Helm > 0) // gets number from sheet, sets availablility bool to true if > 0
		inv->helmet = true;
	else
		inv->helmet = false;

	infile >> equipC; // cuirass variables , same as above different object
	if (equipC == 1)
		inv->equipCr = true;
	else 
		inv ->equipCr = false;
	infile >> inv->Cur;
	if (inv->Cur > 0)
		inv->cuirass = true;
	else
		inv->cuirass = false;


	infile >> equipG; // Greaves variables, same as above
	if (equipG == 1)
		inv->equipGr = true;
	else
		inv->equipGr = false;
	infile >> inv->Grvs;
	if (inv->Grvs > 0)
		inv->greaves = true;
	else 
		inv ->greaves = false;

	infile >> equipD; // this loads dagger info
	if (equipD == 1)
		inv->equipDag = true;
	else
		inv->equipDag = false;
	infile >> inv->dagQt;

	infile >> equipS; // load short sword info
	if (equipS == 1)
		inv->equipSwd = true;
	else
		inv->equipSwd = false;
	infile >> inv->swdQt;

	infile >> equipL;
	if (equipL == 1)
		inv->equipLsw = true;
	else
		inv->equipLsw = false;
	infile >> inv->lswQt;
	


}

void controller :: saveInv (ofstream& outfile, inventory *inv) // this is the load inventory patch
{
	outfile << endl;
	outfile << inv->magicP << setw(5) << inv->hpP << endl; // outfiles magic and health potions
	if (inv->equipHm == true) // checks if euqipped outfiles 1 if true
		outfile << 1 << endl;
	else
		outfile << 0 << endl; //0 if false
	if (inv->helmet == true) // checks to see if helmets are in inventory
		outfile << inv->Helm << endl; // if yes sets them to variable
	else
		outfile << 0 << endl; // else 0

	if (inv->equipCr == true) //same as above just for cuirass instead
		outfile << 1 << endl;
	else
		outfile << 0 << endl;
	if (inv->cuirass == true)
		outfile << inv->Cur << endl;
	else
		outfile << 0 << endl;

	if (inv->equipGr == true) //same as above just for greaves instead
		outfile << 1 << endl;
	else
		outfile << 0 << endl;
	if (inv->greaves == true)
		outfile << inv->Grvs << endl;
	else 
		outfile << 0 << endl;

	if (inv->equipDag == true)  // save data for daggers
		outfile << 1 << endl;
	else
		outfile << 0 << endl;
	if (inv->dagQt > 0)
		outfile << inv->dagQt << endl;
	if (inv->dagQt <= 0)
		outfile << 0 << endl;

	if (inv->equipSwd == true)  // save data for short swords
		outfile << 1 << endl;
	else
		outfile << 0 << endl;
	if (inv->swdQt > 0)
		outfile << inv->swdQt << endl;
	if (inv->swdQt <= 0)
		outfile << 0 << endl;

	if (inv->equipLsw == true)  // save data for long swords
		outfile << 1 << endl;
	else
		outfile << 0 << endl;
	if (inv->lswQt > 0)
		outfile << inv->lswQt << endl;
	if (inv->lswQt <= 0)
		outfile << 0 << endl;

}

void controller :: orcCtest (string name) // this is a function to create an enemy
{
	int estat[6] = {0,0,0,0,0,0}; // nect three lines all stats for enemy
	int emod[6] = {0,0,0,0,0,0};
	enemy = new charSheet;
	
	enemy->NAME = name;
	enemy->charSet (estat, emod, 0,0,10,0,0,0, 10, 15);
	print(enemy);
	delete enemy;
}

void controller :: soldierC (string name)
{
	soldier.wipe ();
	soldier.NAME = name;

	int estat[6] = {15, 15, 12, 12, 13, 11}; // next three lines all stats for enemy
	int emod[6] = {5, 5, 3, 4, 4, 3};
	soldier.charSet (estat, emod, 12, 13, 1, 0, 12,  0, 45, 43);
	
}


void controller :: runTime () // this is the start of the main function to run the game 
{
	start1(); // starts the game
	start (); // gets your character
	player (&character); // player option menu
	cp.readStory ("chapter 1.txt"); // read out story
	cp.optionsM (&character, & inv, "chap1.txt", 6, 2, 15); // prints story options
	cp.readStory ("chapter 2.txt");
	soldierC ("Orc");
	ch.combat (&character, &soldier, 6 , "an Orc", &inv); // character combat call 
	cp.readStory ("chapter 3.txt");
	cp.readStory ("chapter 4.txt");
	cp.optionsMncbt(&character, &inv, 3, 12);
	player (&character);
	cp.readStory ("chapter 5.txt");
	soldierC ("Soldier");
	ch.combat (&character, &soldier, 8, "a Soldier", &inv);
	player (&character);// player menu again.
}
void controller :: print (charSheet *character)
{
	character->printAll ();
	cout << endl;
}



