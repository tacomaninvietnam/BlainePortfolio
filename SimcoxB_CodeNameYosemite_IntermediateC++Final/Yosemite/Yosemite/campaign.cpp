#include "campaign.h"

campaign :: campaign () // default constructor initializes list to zero
{
	for (num = 0; num <= 22; num ++)
	{
		list[num] = " ";
	}
}
void campaign :: readStory (string name) // reads chapters from fstream
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hConsole, 15); // bright white
	ifstream infile; 
	for (num = 0; num <= 22; num ++) // clear array
	{
		list[num] = " ";
	}
	
	infile.open (name);
	cout << endl << endl;
	for (num = 0; num <= 19; num++) // fill array
	{
	getline (infile, list[num]);
	cout << list[num] << endl;
	}
	infile.close ();
}

void campaign :: readOption (string name) // same as above only different array
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hConsole, 15);
	ifstream infile; 
	for (num = 0; num <= 3; num ++)
	{
		op[num] = " ";
	}
	
	infile.open (name);
	for (num = 0; num <= 3; num++)
	{
	getline (infile, op[num]);
	}
	infile.close ();
}


int campaign :: dice (int dmg) // campaign dice function
{
	int a = 0;
	dmg = (rand() + time (0)) % dmg + 1;
	return dmg;
}

void campaign :: easyA (saveLoad *character,  int dmg, string line) // this function is called when a player would rathe take damage than roll
{
		cout << endl << line << endl;
		dmg = dice (dmg);
		cout << "You receive " << dmg << " damage." << endl;
		cout << "HP before damage: " << character->HP << endl;
		character->HP = character->HP - dmg;
		cout << "HP after damage: " << character->HP << endl << endl;
}

void campaign :: cpsearch (saveLoad *character, inventory *inv, int challRate) // function to search areas
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hConsole, 15); // bright white
	int success = 0; // variable for character
	success = (rand() + time (0)) % 20 + 1 + character->CMOD[4]; // roll character roll
	challRate = challRate;
	if (success >= challRate && found == false)  // found is limiter to stop repeat searching after items found in same area
	{
		cout << endl << "You found something!" << endl;  // if you succedd
		int prize = 0;
		prize = (rand() + time (0)) % 5 + 1; // roll a random prize
		found = true;
		int gp =0;
		SetConsoleTextAttribute(hConsole, 14); // yellow
	switch (prize) // prizes 
		{
		case 1:
		
			gp =  (rand() + time (0)) % 20 + 1;
			cout << endl << "You found " << gp << " GP!" << endl;
			character->GP = character->GP + gp;
			cout << "Your current GP is now " << character->GP<< endl << endl;
			break;
		case 2:
			cout << endl << "You found 1 Health Potion! " << endl << endl;
			inv->hpP = inv->hpP + 1;
			break;
		case 3:
			cout << endl << "You found 1 Magic Potion! " << endl << endl;
			inv->magicP = inv->magicP + 1;
			break;
		case 4:
			cout << endl << "You found a Gladiator's dagger!" << endl << endl;
			inv->dagQt = inv->dagQt + 1;
			break;
		case 5:
			cout << endl << "You found a Helm of the Master!" << endl << endl;
			inv->Helm = inv->Helm + 1;
			inv->helmet = true;
			break;
		}
	}

	else if (found == true) // error message for searching after finding
		cout << endl << "You have already cleared this area of items!" << endl << endl;
	else // failure message
		cout << endl << "You search but find nothing" << endl << endl;

		
}

void campaign :: optionsM (saveLoad *character, inventory *inv, string name, int dmg, int stat, int challRate) // dynamic function to get options fro txt files so story flows better
{
	found = false;
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hConsole, 12); // red
	string fail = "A, B, C, D, or E only!" ; // fail statement
	readOption (name);
	do 
	{
	cout << endl;
	SetConsoleTextAttribute(hConsole, 12);
	cout << "A. " << op[0] << endl; // getline from array
	cout << "B. " << op[1] << endl;
	cout << "C. Search area for items." << endl; // default options
	cout << "D. Inventory Options. " << endl << endl;
	try
	{
		SetConsoleTextAttribute(hConsole, 15);// bright white
		cin >> sel;
		SetConsoleTextAttribute(hConsole, 12);// red

		if (sel != 'a' && sel != 'A' && sel != 'b' && sel != 'B'  && sel != 'c' && sel != 'C' && sel != 'd' && sel != 'D'  && sel != 'e' && sel != 'E') // exception thrower
				throw fail;
	}
	catch (string x) // standard catch block
	{
		SetConsoleTextAttribute(hConsole, 12);
		cout << endl;
		cout << x;
		cout << endl;
		continue;  
	}
	

	if (sel == 'a' || sel == 'A')
	{
		ch.survival(stat, challRate, character); // gives player opportunity to not take damage
		break;
	}

	else if (sel == 'b' || sel == 'B') // easy out with damage
	{
		easyA (character, dmg, op[2]);
		break;
	}
	else if (sel == 'c' || sel == 'C') // static options
	{
		cpsearch (character, inv, challRate);
	}
	else if (sel == 'd' || sel == 'D')
	{
		inv->inventoryMenu (character);
	}
	else if (sel == 'e' || sel == 'E')
		break;



	}while (sel != 'e' || sel != 'E');// do while terminator

	found = false; // set variable found to false on way out

}

void campaign :: optionsMncbt (saveLoad *character, inventory *inv,  int stat, int challRate)
{
	found = false; // search limiter
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hConsole, 12); // red
	string fail = "A, B, C, D, or E only!" ;

	do 
	{
	cout << endl;
	SetConsoleTextAttribute(hConsole, 12); // red
	cout << "A. Search area for items." << endl; // options for this menu
	cout << "B. Inventory Options. " << endl;
	cout << "E. Exit this Menu." << endl << endl;
	try
	{
		SetConsoleTextAttribute(hConsole, 15);// bright white
		cin >> sel;
		SetConsoleTextAttribute(hConsole, 12);// red

		if (sel != 'a' && sel != 'A' && sel != 'b' && sel != 'B'   && sel != 'e' && sel != 'E') // exception thrower
				throw fail;
	}
	catch (string x) // standard catch block
	{
		SetConsoleTextAttribute(hConsole, 12);
		cout << endl;
		cout << x;
		cout << endl;
		continue;  
	}
	

	if (sel == 'a' || sel == 'A') // search
	{
		cpsearch (character, inv, challRate);
	}
	else if (sel == 'b' || sel == 'B') // show inventory menu
	{
		inv->inventoryMenu (character);
	}
	else if (sel == 'e' || sel == 'E')// exit
		break;



	}while (sel != 'e' || sel != 'E'); // terminator

	found = false; // reset found

}// end Options M non combat