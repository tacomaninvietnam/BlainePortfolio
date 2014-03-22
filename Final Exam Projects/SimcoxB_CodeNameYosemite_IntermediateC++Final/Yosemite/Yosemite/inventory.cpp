#include "inventory.h"



inventory :: inventory () // initializes inventory objects to 0, first 3 bool are ownership detection for armor, last 3 equip status for same items
{
	magicP = 0;
	hpP = 0;
	cuirass = false;
	helmet = false;
	greaves = false;
	equipCr = false;
	equipGr = false;
	equipHm = false;

	magicBlast = true;
	fireBall = false;
	stoneArmor = false;
	deathWave = false;

	equipDag = true;
	equipSwd = false;
	equipLsw = false;
	dagQt = 1;
	swdQt = 0;
	lswQt = 0;
	Cur = 0;
	Helm = 0;
	Grvs = 0;
}

void inventory :: print (saveLoad *character) // this is the inventory print function 
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
		
	character->printAll();
	cout << endl << endl;
	SetConsoleTextAttribute(hConsole, 3);
	cout << "Health Potions " << setw(4) << hpP << endl; // cout statements for 
	cout << "Magic Potions " << setw(5) << magicP << endl << endl;
	cout << "Armor:" << endl << endl;
	if (Helm > 0)
		cout << "Helms: " << setw (7) << Helm << endl;
	if (Cur > 0)
		cout << "Cuirass: " << setw (5) << Cur << endl;
	if (Grvs > 0)
		cout << "Greaves: " << setw (5) << Grvs << endl;
	if (Helm <= 0 && Cur <= 0 && Grvs <= 0)  // couts no armor if none owned.
	{
		SetConsoleTextAttribute(hConsole, 12);
		cout << "You have no armor." << endl;
	}
	cout << endl;
	SetConsoleTextAttribute(hConsole, 3);
	cout << "Weapons: " << endl << endl;// same as above just weapons
	if (dagQt > 0)
		cout << "Gladiator's Daggers: " << setw (7) << dagQt << endl;
	if (swdQt > 0)
		cout << "Legionare's Swords: " << setw (8) << swdQt << endl;
	if (lswQt > 0)
		cout << "Swords of Gant: " << setw (12) << lswQt << endl;
	if (dagQt <= 0 && lswQt <= 0 && swdQt <= 0) // cout no weapons if none
	{
		SetConsoleTextAttribute(hConsole, 12);
		cout << "You have no weapons." << endl;
	}
	cout << endl;
}

int inventory :: iDice(int num, int stat, saveLoad character) // this is my improved dynamic dice
{
	if (stat <=5 && stat >= 0) // checks stat as negative integers or integers above 5 will bypass this section
	{
		int y = 0; // this initializes return variable to 0

		if (num == 20) // if dice () detects 20 it knows to add stat modifier to roll
		{
			y =  ((rand() + time (0)) % num + 1) + character.getStat(stat);
		}
		else if (stat == 0 || stat == 2) // if number not 20 but dice roll uses CMOD 0 or 2, adds modifier(only for damage and Magic essentially)
		{
			y = ((rand() + time (0)) % num + 1) + character.getStat(stat);
		}
		else // if not 20 for num, or 0 or 2 for stat rolls this standard instead
		{
			y = (rand() + time (0)) % num + 1;
		}
		return y;
	}
	else // removal of this statement or the one directly above caused errors so its still here, don't know why there are errors without either
	{
		int y = 0;
		y = (rand() + time (0)) % num + 1;
		return y;
	}

}

void inventory :: magic (saveLoad *character)// this is strictly for menu purposes only, the actual functions will be in weapons
{
	
	char input[256] = {0}; // this is an array for storing the Ascii values for atoi () function call later
	int result = 0; // initialize result variable to 0
	string fail = "Cannot use letters or integers greater than four."; // string failure message
	do 
	{
	if (character->LVL >= 1) // this list works based on your level, options will not be there unless you have a sufficient level
	{
		
		hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
		SetConsoleTextAttribute(hConsole, 12);
		cout << endl << endl;
		cout << "The Magic you posess is listed here." << endl;
		cout << "Select a number corresponding to the " << endl;
		cout << "ability you want to see and  the "<< endl;
		cout << "description of that ability will be " << endl;
		cout << "displayed. " << endl << endl;
		cout << "You may press five to exit this menu." << endl;
		img.magic ();
		cout << endl << endl;
		SetConsoleTextAttribute(hConsole, 14);
		cout << "1. Magic Blast. "  << endl; // these menu options are only available if you have a high enough level
	}
	if (character->LVL >= 2)
		{
			cout << "2. Fireball. "  << endl;
		}
	if (character->LVL >= 3)
		{
			cout << "3. Stone Armor. "  << endl;
		}
	if (character->LVL >= 4)
		{
			cout << "4. Death Wave."  << endl;
		}
	SetConsoleTextAttribute(hConsole, 7);
	try // CIN STATEMENT WITH TRY BLOCK
	{
	cin >> input;
	cout << endl;
	
	result = atoi(input); // USING ATOI TO CONVERT LETTERS INTO NEGATIVE NUMBERS FO CATCH BLOCK

	if (result < 1 || result > 5 || result > character->LVL && result != 5)  // if number input not in range, throw to Input failure catch.
			throw fail;
	}// end of try block

	catch (string x) // prints out exception to screen 
	{
		cout << endl;
		cout << endl;
		SetConsoleTextAttribute(hConsole, 12);
		if (character->LVL < result)  // if not a high enough level, you get this error
		{
			cout << endl;
			cout << "You are not a high enough level to view this option!" << endl << endl;
		}
		else // if your input is just plain wrong you get fail message
		{
			cout << endl;
			cout << x;
			cout << endl;
		}
	}
	SetConsoleTextAttribute(hConsole, 14); // set text to yellow
	if (result <= character->LVL)
	{
	switch(result) // otherwise continue into switch
	{
	case 1: // these options will not even appear if you aren't high enough in level
		cout << endl;
		SetConsoleTextAttribute(hConsole, 14); // yellow
		cout << "Magic Blast:  You unleash a ball of pure magical energy" << endl; // all four cases are just cout statements  with ability 
		cout << "Unleashing 1d4 + Intellegence Modifier of damage." << endl; //descripton and 
		SetConsoleTextAttribute(hConsole, 12);// red
		cout << "MP Cost: 5 MP" << endl << endl; // cost of spell
		magicBlast = true;
		break;
	case 2:
		cout << endl;
		SetConsoleTextAttribute(hConsole, 14);
		cout << "Fireball:  Your enemies scream in pain as you burn them " << endl;
		cout << "Alive dealing 1d10 + intelligence modifier damage." << endl;
		SetConsoleTextAttribute(hConsole, 12);
		cout << "MP Cost: 10 MP" << endl << endl;
		fireBall = true;
		break;
	case 3:
		cout << endl;
		SetConsoleTextAttribute(hConsole, 14);
		cout << "Stone Armor.  Gives you a temporary boost to Armor Class. " << endl;
		cout << "1d4 increase in Armor Class Rating. " << endl;
		SetConsoleTextAttribute(hConsole, 12);
		cout << "MP Cost: 10 MP" << endl << endl;
		stoneArmor = true;
		break;
	case 4:
		cout << endl;
		SetConsoleTextAttribute(hConsole, 14);
		cout << "Death Wave:  Instantly kill an enemy on succesful attack. " << endl;
		cout << "Use sparingly as cost to use this ability is high." << endl;
		SetConsoleTextAttribute(hConsole, 12);
		cout << "MP Cost: 20 MP" << endl << endl;
		deathWave = true;
		break;
	case 5:
		break;
	default :
		break;

	}
	}
	}while (result != 5);
}

void inventory :: usePotion (saveLoad *character, string name)
{

	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
	SetConsoleTextAttribute(hConsole, 12);

	int x = 0;
	if (name == "magic" && magicP <= 0)
	{
		cout << "You are out of magic potions. Please buy more at a store. " << endl;
		
	}

	else if (name == "magic"&& magicP > 0)  // statement for magic potions declared by string
	{
		SetConsoleTextAttribute(hConsole, 12);
		int x = 0;
		x = iDice(8, 2, *character);
		cout << endl;

		cout << "You gain " << x  
			 <<  " magic points." << endl << endl;
		character->MANA = character->MANA + x;
		if (character->MANA > character->MaxMp)
		{
			character->MANA = character->MaxMp;
		}
		magicP--;
		
		
	}
	else if (name == "health" && hpP > 0) // same as above just health potions
	{
		SetConsoleTextAttribute(hConsole, 12);
		int x = 0;
		x = iDice(8, 2, *character);
		hpP--;
		cout << endl;

		cout << "You gain " << x 
			 <<  " Hit points." << endl << endl;
		character->HP = character->HP + x;
		if (character->HP > character->MaxHp)
		{
			character->HP = character->MaxHp;
		}
		
	}
	else 
	{
		cout << "You are out of Health Potions.  Please buy more at a store. " << endl;
		
	}
}

void inventory :: buyPot (saveLoad *character)
{
	
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
	SetConsoleTextAttribute(hConsole, 12);
	string fail = "Must enter either Y or N" ;
	char result;
	cout << "Would you like to buy some potions?  Press Y or N!" << endl;
	cout << endl;
	SetConsoleTextAttribute(hConsole, 15);
	try // CIN STATEMENT WITH TRY BLOCK
	{
	cin >> result;
	cout << endl;
	

	if (result != 'y' && result != 'Y' && result != 'n' && result != 'N')  // if number input not in range, throw to Input failure catch.
			throw fail;
	}// end of try block

	catch (string x)
	{
		cout << endl;
		cout << x;
		
		cout << endl;
		cout << endl;
		cout << endl;
	}
	if (result == 'y' || result == 'Y')

	{
		hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		do
		{
		SetConsoleTextAttribute(hConsole, 12);
		cout << "Would you like to buy Magic or Health Potions?" << endl; // cout but potion menu
		cout << "Magic Potions. 15 GP "<< endl;
		cout << "Health Potions. 10 GP " << endl << endl;
		cout << "Press H for health M for magic. " << endl<< endl;
		cout << "Or press E to exit:" << endl;
		cout << endl;
			
		SetConsoleTextAttribute(hConsole, 15);
		cin >> sel;
		
		if (sel == 'h' || sel == 'H')
		{
			int amt = 0;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "How many Health potions would you like to buy?" << endl; // asks the quantity of potions to buy
			cout << endl;
			SetConsoleTextAttribute(hConsole, 15);
			cin >> amt;
			if (character->GP >= (10 * amt))
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << "You bought " << amt << " Health Potions" << endl;
				character->GP = character->GP - (10 * amt);
				hpP = hpP + amt;
				cout << "GP: " << setw(5) << character->GP << endl;
				cout << "Health Potions:" << setw(5) << hpP << endl;
				cout << endl;
			}
			else
			{
				SetConsoleTextAttribute(hConsole, 12); // insufficient funds if not enough money
				cout << endl;
				cout << "Insufficeint funds" << endl;
				cout << endl;
			}
		}
			
		else if (sel == 'M' || sel == 'm') // buy magic potions
		{
			hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
			SetConsoleTextAttribute(hConsole, 12);
			int amt = 0;
			cout << "How many Magic potions would you like to buy?" << endl;
			cout << endl;
			SetConsoleTextAttribute(hConsole, 15);
			cin >> amt;
			if (character->GP >= (15 * amt))
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << "You bought " << amt << " Magic Potions" << endl;
				character->GP = character->GP - (15 * amt);
				magicP = magicP + amt;
				cout << "GP: " << setw(5) << character->GP << endl;
				cout << "Magic Potions:" << setw(5) << magicP << endl;
				cout << endl;
			}
			else
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << endl;
				cout << "Insufficeint funds" << endl;
				cout << endl;
			}
		}
		else if (sel == 'E' || sel == 'e')
			break;
		else // error message
		{
			SetConsoleTextAttribute(hConsole, 12);
			cout << endl << endl << "Improper input." << endl << endl;
		}

		}while (sel != 'e' || sel != 'E');
	}
	
		
}

void inventory :: equipArmor (saveLoad *character)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
	SetConsoleTextAttribute(hConsole, 12);
	string fail = "Must enter either H, C, G, or E" ;
	do 
	{
	cout << "Available Armor: " << endl;	
	if (helmet == true) // shows images of what you have and equip status
	{
		img.helmet ();
		cout << "Helm of the Master" << endl << "Number of Items: " << Helm << endl <<  endl;
		if (equipHm == false)
			cout << "Unequipped." << endl;
		else 
			cout << "Equipped." << endl;
	}
	if (cuirass == true)
	{
		img.armor ();
		cout << "Cuirass of Palandinian." << endl << "Number of Items: " << Cur << endl <<  endl;
		if (equipCr == false)
			cout << "Unequipped." << endl;
		else 
			cout << "Equipped." << endl;
	}
	if (greaves == true)
	{
		img.greaves ();
		cout << "Greaves of Master Shota." << endl << "Number of Items: " << Grvs << endl << endl;
		if (equipGr == false)
			cout << "Unequipped." << endl;
		else 
			cout << "Equipped." << endl;
	}
	if (helmet == false && cuirass == false && greaves == false) // if in no possession of armor displays this
		cout << endl << "You Do Not Own Any Armor" << endl << endl;

	cout << endl;
	cout << "Please choose the Type of armor You would like to equip" << endl; // displays armor options
	cout << "Press H for helmet, G for greaves, or C for cuirass." << endl;
	cout << "If a type of armor is already equipped, you may select " << endl;
	cout << "that piece to unequip it." << endl;
	cout << "Or Press E to exit and return to player menu." << endl << endl;
	

	try
	{
		SetConsoleTextAttribute(hConsole, 15);// bright white
		cin >> sel;

		SetConsoleTextAttribute(hConsole, 12);// red

		if (sel != 'h' && sel != 'H' && sel != 'g' && sel != 'G' && sel != 'c' && sel != 'C' && sel != 'e' && sel != 'E') // exception thrower
			throw fail;
	}
	catch (string x) // standard catch block
	{
		SetConsoleTextAttribute(hConsole, 12);
		cout << endl;
		cout << x;
		cout << endl;
	}
	if (sel == 'h' || sel == 'H')
	{
		if (helmet == true)
		{
			cout << endl << "Would you like to equip the Helm of the Master? Y or N." << endl << endl; // cout question
			try
			{
				SetConsoleTextAttribute(hConsole, 15); // get selection
				cin >> sel;
				SetConsoleTextAttribute(hConsole, 12);

				if (sel != 'n' && sel != 'N' && sel != 'y' && sel != 'Y') // standard try/catch
					throw fail;
			}
			catch (string x)
			{
				cout << endl;
				cout << x;
				cout << endl;
			}
			if (sel == 'y' || sel == 'Y') // if yes equip helmet
			{
				equip (character, "helmet");
			}
			else
				break;
	}
		else
			cout << endl << "You do not Own a helmet!" << endl << endl; // don't own any message
	}
	else if (sel == 'c' || sel == 'C')  // same as options a and b above only for cuirass
	{
		if (cuirass == true)
		{
			cout << endl << "Would you like to equip the Cuirass of Palandinian? Y or N" << endl << endl;
			try
			{
				SetConsoleTextAttribute(hConsole, 15);
				cin >> sel;
				SetConsoleTextAttribute(hConsole, 12);

				if (sel != 'n' && sel != 'N' && sel != 'y' && sel != 'Y')
					throw fail;
			}
			catch (string x)
			{
				cout << endl;
				cout << x;
				cout << endl;
			}
			if (sel == 'y' || sel == 'Y')
			{
				equip (character, "cuirass");
			}
			else
				break;
		}
		else 
			cout << endl << "You do not Own a cuirass!" << endl << endl;
	}
	else if (sel == 'g' || sel == 'G') // same as options a and b above only for greaves
	{
		if (greaves == true)
		{
			cout << endl << "Would you like to euqip the Greaves of Master Shota? Y or N" << endl << endl;
			try
			{
				SetConsoleTextAttribute(hConsole, 15);
				cin >> sel;
				SetConsoleTextAttribute(hConsole, 12);

				if (sel != 'n' && sel != 'N' && sel != 'y' && sel != 'Y')
					throw fail;
			}
			catch (string x)
			{
				cout << endl;
				cout << x;
				cout << endl;
			}
			if (sel == 'y' || sel == 'Y')
			{
				equip (character, "greaves");
			}
			else
				break;
		}
		else
			cout << endl << "You do not own a set of greaves!" << endl << endl;
	}

	else if (sel == 'e' || sel == 'E') // terminator for menu
		break;

	}while (sel != 'e' || sel != 'E');
}// end weapon equip otions

void inventory :: equip (saveLoad *character, string itemType) // this function contains the code to equip and unequip armor
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
	SetConsoleTextAttribute(hConsole, 12);
	string fail = "Must enter either Y or N." ; // string failure for catch block
	if (itemType == "helmet") // get string item type
	{
		if (equipHm == false) // checks to see if the item is already equipped so variables don't stack
		{
		equipHm = true; // sets value to true if false
		character->AC = character->AC + 1; // increase character AC by 1 point
		cout << endl << character->AC << endl << endl; // cout so you can wee what's happening
		}
		else
		{
			
			cout << endl << "Item already equiped!" << endl; // if value is true already, gives option to unequip
			cout << "Would you like to unequip? Y or N" << endl << endl;
			do
			{
			try
			{
				SetConsoleTextAttribute(hConsole, 15); // set input to bright white
				cin >> sel; // get input
				SetConsoleTextAttribute(hConsole, 12); // back to red

				if (sel != 'n' && sel != 'N' && sel != 'y' && sel != 'Y') // throws improper input if selection wrong
					throw fail;
			}
			catch (string x) // catch block, only need one since sel is char type
			{
				cout << endl;
				cout << x;
				cout << endl;
			}
			if (sel == 'Y' || sel == 'y') // if they choose to unequip, decrements AC by vlaue of armor piece, can only get 
			{
				character->AC = character->AC - 1; // this option if bool value is true
				cout << endl << character->AC << endl << endl;
				equipHm = false;
				break;
			}
			else // if selection not y break;
				break;
			}while (sel != 'n' || sel != 'N'); // if sel n exit loop

		}

	}
	else if (itemType == "cuirass") // from here down is the exact same code as above with different modifiers until line 556 where function ends
	{
		if (equipCr == false)// checks to see if item already equipped
		{
		equipCr = true;
		character->AC = character->AC + 4;
		cout << endl << character->AC << endl << endl;
		}
		else
		{
			
			cout << endl << "Item already equiped!" << endl; // item equipped message
			cout << "Would you like to unequip? Y or N" << endl << endl; // option to unequip
			do
			{
			try  // standard try catch
			{
				SetConsoleTextAttribute(hConsole, 15); // get selection
				cin >> sel;
				SetConsoleTextAttribute(hConsole, 12);

				if (sel != 'n' && sel != 'N' && sel != 'y' && sel != 'Y')
					throw fail;
			}
			catch (string x)
			{
				cout << endl;
				cout << x;
				cout << endl;
			}
			if (sel == 'Y' || sel == 'y') // if option yes unequip and decrement AC
			{
				character->AC = character->AC - 4;
				cout << endl << character->AC << endl << endl;
				equipCr = false;
				break;
			}
			else
				break;
			}while (sel != 'n' || sel != 'N');
		}

	}
	else 
	{
		if (equipGr == false) // checks to see if item already equipped
		{
		equipGr = true; // sets equipped value to true
		character->AC = character->AC + 2; // increment AC
		cout << endl << character->AC << endl << endl;
		}
		else
		{
			cout << endl << "Item already equiped!" << endl;  // already equipped message
			cout << "Would you like to unequip? Y or N" << endl << endl; // unequip option
			
			do
			{
			try // try catch
			{
				
				SetConsoleTextAttribute(hConsole, 15);
				cin >> sel;
				SetConsoleTextAttribute(hConsole, 12);

				if (sel != 'n' && sel != 'N' && sel != 'y' && sel != 'Y')
					throw fail;
			}
			catch (string x)
			{
				cout << endl;
				cout << x;
				cout << endl;
			}
			if (sel == 'Y' || sel == 'y') // if y unequip decrement AC by value
			{
				character->AC = character->AC - 2;
				cout << endl << character->AC << endl << endl;
				equipGr = false;
				break;
			}
			else if (sel == 'n' || sel == 'N')
				break;
			else
				break;
			}while (sel != 'n' || sel != 'N');
		}

	}
}

void inventory :: inventoryMenu (saveLoad *character)
{
	
	char input[256] = {0}; // this is an array for storing the Ascii values for atoi () function call later
	int result = 0; // initialize result variable to 0
	do 
	{
		hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
		SetConsoleTextAttribute(hConsole, 12);
		string fail = "Must Enter 1 - 6 only";
		cout << endl;
		img.swordInv ();
		cout << endl << endl;
		SetConsoleTextAttribute(hConsole, 14);

		cout << "1. Show Character Sheet. " << endl << endl; // inventory menu options cout
		cout << "2. Show All Available Armors and Equip or Unequip Options." << endl << endl; 
		cout << "3. Show Available Weapons. " << endl << endl;
		cout << "4. Show Available Magic Spells. " << endl << endl;
		cout << "5. Use Potions." << endl << endl; 
		cout << "6. Store." << endl << endl;
		cout << "7. Exit Inventory Menu. " << endl << endl;

		try // CIN STATEMENT WITH TRY BLOCK
	{

	SetConsoleTextAttribute(hConsole, 15);
	cin >> input;
	cout << endl;
	result = atoi(input); // USING ATOI TO CONVERT LETTERS INTO NEGATIVE NUMBERS FO CATCH BLOCK

	if (result < 1 || result > 7)  // if number input not in range, throw to Input failure catch.
			throw fail;
	}// end of try block

	catch (string x) // prints out exception to screen 
	{
		SetConsoleTextAttribute(hConsole, 12);
		cout << endl;
		cout << x;
		cout << endl;
	}
	switch (result)
	{
	case 1:
		print (character); // inventory print function
		break;
	case 2:
		equipArmor (character); // equip armor call 
		break;
	case 3:
		weaponSelect (); // select weapon
		break;
	case 4:
		magic (character); // magic inventory
		break;
	case 5:
		potionMenu (character); // potion menu
		break;
	case 6:
		storeMenu (character); // store menu
	case 7:
		break;
	}
	}while (result != 7);
}

void inventory :: potionMenu (saveLoad *character)
{
	do 
	{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
	SetConsoleTextAttribute(hConsole, 12);
	string fail = "Press H, M, or E only!";
	img.potion ();
	cout << endl;
	cout << "Health Potions: " << setw(7) << hpP << endl;
	cout << "Magic Potions : " << setw(7) << magicP << endl<< endl;

	cout << "HP: " << setw(6) << character->HP << " / " << character->MaxHp << endl;
	cout << "MP: " << setw(6) << character->MANA << " / " << character->MaxMp << endl << endl << endl;

	cout << "Press M to use a Magic Potion to gain 1d8 + INT modifier Mana." << endl;
	cout << "Press H to use a Health potion to gain 1d8 + INT modifier HP" << endl << endl;
	cout << "Press E to exit this menu. " << endl;

	SetConsoleTextAttribute(hConsole, 15);
	try // CIN STATEMENT WITH TRY BLOCK
	{
	cin >> sel;
	cout << endl;
	

	if (sel != 'm' && sel != 'M' && sel != 'h' && sel != 'H' && sel != 'e' && sel != 'E')  // if number input not in range, throw to Input failure catch.
			throw fail;
	}// end of try block

	catch (string x)
	{
		SetConsoleTextAttribute(hConsole, 12);
		cout << endl;
		cout << x;
		cout << endl;
		cout << endl;
		cout << endl;
	}
	if (sel == 'm' || sel == 'M')
	{
		usePotion (character, "magic");
		break;
	}
	else if (sel == 'H' || sel == 'h')
	{
		usePotion (character, "health");
		break;
	}
	else
		break;
	}while(sel != 'e' || sel != 'E');
}

void inventory :: weaponAv () // this function just displays weapon options as per ownership
{

	if (dagQt > 0)
	{
		img.gladSw ();
		cout << "Qty Gladiator's Dagger: " << dagQt << endl << endl;
		if (equipDag == true)
			cout << "Equipped" << endl << endl;
		else
			cout << "Unequipped"<< endl << endl;
	}
	if (swdQt > 0)
	{
		img.weapon ();
		cout << "Qty Legionare's Sword: " << swdQt << endl << endl;
		if (equipSwd == true)
			cout << "Equipped" << endl << endl;
		else
			cout << "Unequipped"<< endl << endl;
	}
	if (lswQt > 0)
	{
		img.swordGant ();
		cout << "Qty Sword of Gant: " << lswQt << endl << endl;
		if (equipLsw == true)
			cout << "Equipped" << endl << endl;
		else
			cout << "Unequipped"<< endl << endl;
	}
}

void inventory :: weaponAvOp () // another ownership based menu
{
	cout << endl;
	if (dagQt > 0)
		cout << "Press D to equip or unequip dagger." << endl;
	if (swdQt > 0)
		cout << "Press S to equip or unequip Short Sword." << endl;
	if (lswQt > 0)
		cout << "Press L to equip or unequip Long Sword." << endl << endl;
	if (lswQt <= 0 && swdQt <= 0 && dagQt <= 0) // if no weapons owned this message displayed
	{
			cout << "You posess no Weapons" << endl << endl;
	}
}

		
void inventory :: weaponSelect ()
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
	
	string fail = "You may only enter L, S , D, or E!" ;
	SetConsoleTextAttribute(hConsole, 12);
	cout << "Available Weapons: " << endl << endl;
	weaponAv ();
	do 
	{
	
	SetConsoleTextAttribute(hConsole, 14);
	weaponAvOp ();
	SetConsoleTextAttribute(hConsole, 12);
	cout << "Equipping a different type of weapon will " << endl; // instructions
	cout << "unequip any other equipped weapons." << endl << endl;
	cout << "You may press E to exit weapon select menu." << endl << endl;
	cout << endl;
	try
	{
		SetConsoleTextAttribute(hConsole, 15);// bright white
		cin >> sel;
		SetConsoleTextAttribute(hConsole, 12);// red

		if (sel != 'l' && sel != 'L' && sel != 's' && sel != 'S' && sel != 'd' && sel != 'D' && sel != 'e' && sel != 'E') // exception thrower
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
	if (sel == 's' || sel == 'S' ) // this equips legionare sword if qty greater than 1
	{
		if (equipSwd == false && swdQt > 0)
		{
		cout << endl << "Equipping Legionare's Sword." << endl << endl; // next three if else statements set values to false if you equip diferent weapon
		equipDag = false;
		equipLsw = false;
		equipSwd = true;
		}
		else if (equipSwd == false && swdQt <= 0)
			cout << endl << "You do not own any of this item." << endl << endl;
		else if (swdQt <= 0) // if you don't have any prints this message
		cout << endl << "You do not own any Legionare's Swords." << endl << endl;
		else
			cout << endl << "Item Already equipped!" << endl << endl;
	}
	
	else if (sel == 'd' || sel == 'D')
	{
		if (equipDag == false && dagQt > 0)
		{
		cout << endl << "Equipping Gladiator's Daggers." << endl << endl;
		equipDag = true;
		equipLsw = false;
		equipSwd = false;
		}
		else if(dagQt <= 0)
		cout << endl << "You do not own any Gladiator's Daggers." << endl << endl;
		else
			cout << endl << "Item Already equipped!" << endl << endl;
	}
	

	else if (sel == 'l' || sel == 'L')
	{
		if (equipLsw == false && lswQt > 0)
		{
		cout << endl << "Equipping Swords of Gant." << endl << endl;
		equipDag = false;
		equipLsw = true;
		equipSwd = false;
		}
		else if(lswQt <= 0)
		cout << endl << "You do not own any Swords of Gant." << endl << endl;
		else
			cout << endl << "Item Already equipped!" << endl << endl;
	}
	
	else
		break;

	}while(sel != 'e' || sel != 'E');
} // end weapon equip menu

void inventory :: storeCheck (saveLoad *character) // this function stops false equipping from selling all weapons of type
{
	
		if (lswQt <= 0) // stops player from leaving item equipped after selling all weapons or armor of types below
			equipLsw = false;
		if (dagQt <= 0) 
			equipDag = false;
		if (swdQt <= 0)
			equipSwd = false;
		if (Cur <= 0) 
			equipCr = false;
		if (Helm <= 0)
			equipHm = false;
		if (Grvs <= 0)
			equipGr = false;
		
}

void inventory :: buyWeap (saveLoad *character) // start buyWeap
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
	
	
	string fail = "You may only enter A, W , P, or E!" ;
	SetConsoleTextAttribute(hConsole, 12);
	cout << endl;
	do
	{
	cout << "Select the type of weapon you would like to buy." << endl; // prices
	cout << "Press L for long swords. 80 GP" << endl;
	cout << "Press S for short Swords. 50 GP" << endl;
	cout << "Press D for daggers. 30 GP" << endl;
	cout << "Press E to exit buy weapons menu. " << endl << endl;
	try
	{
		SetConsoleTextAttribute(hConsole, 15);// bright white
		cin >> sel;
		SetConsoleTextAttribute(hConsole, 12);// red

		if (sel != 'l' && sel != 'L' && sel != 's' && sel != 'S' && sel != 'd' && sel != 'D' && sel != 'e' && sel != 'E') // exception thrower
			throw fail;
	}
	catch (string x) // standard catch block
	{
		SetConsoleTextAttribute(hConsole, 12);
		cout << endl;
		cout << x;
		cout << endl;
	}
	if (sel == 'l' || sel == 'L')
		{
			int amt = 0;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "How many Swords of Gant would you like to buy?" << endl; // cout for amount
			cout << endl; // get amount
			SetConsoleTextAttribute(hConsole, 15);
			cin >> amt;
			if (character->GP >= (80 * amt))// check if amount * price exceeds player GP
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << "You bought " << amt << " Swords of Gant" << endl; // cout number of item bought
				cout << "GP before transaction was: " <<  character->GP << endl;
				character->GP = character->GP - (80 * amt); // update money
				lswQt = lswQt + amt;// update inventory stock
				cout << "GP: " << setw(5) << character->GP << endl; // cout gold left
				cout << "Swords of Gant:" << setw(5) << lswQt << endl; // number of item in ventory
				cout << endl;
			}
			else
			{
				SetConsoleTextAttribute(hConsole, 12); // if not enough Insufficient funds satement
				cout << endl;
				cout << "Insufficeint funds" << endl;
				cout << endl;
			}
		}

		else if (sel == 's' || sel == 'S') //same as above only for legionare's swords instead
		{
			int amt = 0;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "How many Legionare's Swords would you like to buy?" << endl;
			cout << endl;
			SetConsoleTextAttribute(hConsole, 15);
			cin >> amt;

			if (character->GP >= (50 * amt))
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << "You bought " << amt << " Legionare's Swords" << endl;
				cout << "GP before transaction was: " <<  character->GP << endl;
				character->GP = character->GP - (50 * amt);
				swdQt = swdQt + amt;
				cout << "GP: " << setw(5) << character->GP << endl;
				cout << "Legionare's Swords:" << setw(5) << swdQt << endl;
				cout << endl;
			}
			else
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << endl;
				cout << "Insufficeint funds" << endl;
				cout << endl;
			}
		}

		else if (sel == 'd' || sel == 'D') // same as above only for daggers
		{
			int amt = 0;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "How many Gladiator's Daggers would you like to buy?" << endl;
			cout << "GP before transaction was: " <<  character->GP << endl;
			cout << endl;
			SetConsoleTextAttribute(hConsole, 15);
			cin >> amt;

			if (character->GP >= (30 * amt))
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << "You bought " << amt << " Gladiator's Daggers" << endl;
				character->GP = character->GP - (30 * amt);
				dagQt = dagQt + amt;
				cout << "GP: " << setw(5) << character->GP << endl;
				cout << "Gladiator's Dagger:" << setw(5) << hpP << endl;
				cout << endl;
			}
			else
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << endl;
				cout << "Insufficeint funds" << endl;
				cout << endl;
			}
		}
		else // break on E
			break;
		}while (sel != 'e' || sel != 'E');
}// end buyweap

void inventory :: sellArmor (saveLoad *character)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
	
	string fail = "You may only enter H, C , G, or E!" ; // fail messages
	string fail2 = "You may only enter Y or N!";
	string x = "You don't own enough objects of this type for transaction.";
	SetConsoleTextAttribute(hConsole, 12); // red
	cout << endl;
	do
	{
	cout << "Select the type of weapon you would like to Sell." << endl; // cout instructions
	cout << "Press H for helmet. 20 GP" << endl;
	cout << "Press C for Cuirass. 40 GP" << endl;
	cout << "Press G for Greaves. 30 GP" << endl;
	cout << "Press E to exit sell armor menu. " << endl << endl;
	try
	{
		SetConsoleTextAttribute(hConsole, 15);// bright white
		cin >> sel;
		SetConsoleTextAttribute(hConsole, 12);// red

		if (sel != 'h' && sel != 'H' && sel != 'c' && sel != 'C' && sel != 'g' && sel != 'G' && sel != 'e' && sel != 'E') // exception thrower
			throw fail2;
	}
	catch (string x) // standard catch block
	{
		SetConsoleTextAttribute(hConsole, 12);
		cout << endl;
		cout << x;
		cout << endl;
	}
	if (sel == 'h' || sel == 'H') // if sel L
		{
			int amt = 0;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "How many Helms of the Master would you like to Sell?" << endl; // cout instruction
			cout << endl;
			SetConsoleTextAttribute(hConsole, 15);
			cin >> amt;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "Are you sure you want to sell " << amt << " Helms of the Master?" << endl << endl; // cout question
			
			try
			{
				SetConsoleTextAttribute(hConsole, 15);// bright white
				cin >> sel;
				SetConsoleTextAttribute(hConsole, 12);// red

			if (sel != 'y' && sel != 'Y' && sel != 'n' && sel != 'N') // exception thrower
				throw fail2;
			}
			catch (string x) // standard catch block
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << endl;
				cout << x;
				cout << endl;
			}
			

			if (sel == 'y' || sel == 'Y') // if they still want to sell 
			{
				if (Helm >= amt)
				{
				SetConsoleTextAttribute(hConsole, 12);
				cout << "You sold " << amt << " Helms of the Master" << endl; // cout amount sold
				cout << "GP before transaction was: " <<  character->GP << endl;
				character->GP = character->GP + (20 * amt); // update gold
				Helm = Helm - amt; // update Qty item
				cout << "GP: " << setw(5) << character->GP << endl; // cout current GP
				cout << "Helms of the Master:" << setw(5) << Helm << endl; // cout current item amount
				cout << endl;
				}
				else
					cout << endl << x << endl;
			}
			else
			break;
		}

		else if (sel == 'c' || sel == 'C')
		{
			int amt = 0;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "How many Cuirass of Palandinian would you like to Sell?" << endl; // get amount to sell
			cout << endl;
			SetConsoleTextAttribute(hConsole, 15);
			cin >> amt;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "Are you sure you want to sell " << amt << " Cuirass of Palandinian?" << endl << endl; // confirmation question
			try
			{
				SetConsoleTextAttribute(hConsole, 15);// bright white
				cin >> sel;
				SetConsoleTextAttribute(hConsole, 12);// red

			if (sel != 'y' && sel != 'Y' && sel != 'n' && sel != 'N') // exception thrower
				throw fail2;
			}
			catch (string x) // standard catch block
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << endl;
				cout << x;
				cout << endl;
			}
			
			if (sel == 'y' || sel == 'Y') // if they want to continue
			{
				if (Cur >= amt)
				{
				SetConsoleTextAttribute(hConsole, 12); // red
				cout << "You sold " << amt << " Cuirass of Palandinian" << endl; // cout amount sold
				cout << "GP before transaction was: " <<  character->GP << endl;
				character->GP = character->GP + (40 * amt);// update Gp
				Cur = Cur - amt;// update QTy item
				cout << "GP: " << setw(5) << character->GP << endl; // cout gold
				cout << "Cuirass of Palandinian:" << setw(5) << Cur << endl; // output item qty
				cout << endl;
				}
				else
					cout << endl << x << endl;
			}
			else
			break;
		}

		else if (sel == 'g' || sel == 'G') // dagger sell options
		{
			int amt = 0;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "How many Greaves of Master Shota would you like to Sell?" << endl; // cout question
			cout << endl;
			SetConsoleTextAttribute(hConsole, 15);
			cin >> amt; // get amount to sell
			SetConsoleTextAttribute(hConsole, 12);
			cout << "Are you sure you want to sell " << amt << " Greaves of Master Shota?" << endl << endl; // confirmation question
			try
			{
				SetConsoleTextAttribute(hConsole, 15);// bright white
				cin >> sel;
				SetConsoleTextAttribute(hConsole, 12);// red

			if (sel != 'y' && sel != 'Y' && sel != 'n' && sel != 'N') // exception thrower
				throw fail2;
			}
			catch (string x) // standard catch block
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << endl;
				cout << x;
				cout << endl;
			}
			if (sel == 'y' || sel == 'Y')
			{
				
				if (Grvs >= amt) // checks to make sure you make transaction
				{
				SetConsoleTextAttribute(hConsole, 12);
				cout << "You sold " << amt << " Greaves of Master Shota" << endl;
				cout << "GP before transaction was: " <<  character->GP << endl;
				character->GP = character->GP + (30 * amt);
				Grvs = Grvs - amt;
				cout << "GP: " << setw(5) << character->GP << endl;
				cout << "Greaves of Master Shota:" << setw(5) << Grvs << endl;
				cout << endl;
				}
				else
					cout << endl << x << endl;

			}
			else
			break;
		}
		else 
			break;
		}while (sel != 'e' || sel != 'E');
} // end sellArmor

void inventory :: sellWeap (saveLoad *character)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
	
	string fail = "You may only enter H, C , G, or E!" ; // fail messages
	string fail2 = "You may only enter Y or N!";
	string x = "You don't own enough of this object for the transaction.";
	SetConsoleTextAttribute(hConsole, 12); // red
	cout << endl;
	do
	{
	cout << "Select the type of weapon you would like to Sell." << endl; // cout instructions
	cout << "Press D for daggers. 20 GP" << endl;
	cout << "Press L for Long Swords. 40 GP" << endl;
	cout << "Press S for Short Swords. 25 GP" << endl;
	cout << "Press E to exit sell weapons menu. " << endl << endl;
	try
	{
		SetConsoleTextAttribute(hConsole, 15);// bright white
		cin >> sel;
		SetConsoleTextAttribute(hConsole, 12);// red

		if (sel != 'l' && sel != 'L' && sel != 's' && sel != 'S' && sel != 'd' && sel != 'D' && sel != 'e' && sel != 'E') // exception thrower
			throw fail2;
	}
	catch (string x) // standard catch block
	{
		SetConsoleTextAttribute(hConsole, 12);
		cout << endl;
		cout << x;
		cout << endl;
	}
	if (sel == 'd' || sel == 'D') // if sel L
		{
			int amt = 0;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "How many Gladiator's Daggers would you like to Sell?" << endl; // cout instruction
			cout << endl;
			SetConsoleTextAttribute(hConsole, 15);
			cin >> amt;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "Are you sure you want to sell " << amt << " Gladiator's Daggers?" << endl << endl; // cout question
			
			try
			{
				SetConsoleTextAttribute(hConsole, 15);// bright white
				cin >> sel;
				SetConsoleTextAttribute(hConsole, 12);// red

			if (sel != 'y' && sel != 'Y' && sel != 'n' && sel != 'N') // exception thrower
				throw fail2;
			}
			catch (string x) // standard catch block
			{
				SetConsoleTextAttribute(hConsole, 14);
				cout << endl;
				cout << x;
				cout << endl << endl;
				SetConsoleTextAttribute(hConsole, 12);
			}
			

			if (sel == 'y' || sel == 'Y') // if they still want to sell 
			{
				if (dagQt >= amt)
				{
				SetConsoleTextAttribute(hConsole, 12);
				cout << "You sold " << amt << " Gladiator's Daggers" << endl; // cout amount sold
				cout << "GP before transaction was: " <<  character->GP << endl;
				character->GP = character->GP + (20 * amt); // update gold
				dagQt = dagQt - amt; // update Qty item
				cout << "GP: " << setw(5) << character->GP << endl; // cout current GP
				cout << "Gladiator's Daggers:" << setw(5) << dagQt << endl; // cout current item amount
				cout << endl;
				}
				else
					cout << endl << x << endl;
			}
			else
			break;
		}

		else if (sel == 's' || sel == 'S')
		{
			int amt = 0;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "How many Legionare's Swords would you like to Sell?" << endl; // get amount to sell
			cout << endl;
			SetConsoleTextAttribute(hConsole, 15);
			cin >> amt;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "Are you sure you want to sell " << amt << " Legionare's Swords?" << endl << endl; // confirmation question
			try
			{
				SetConsoleTextAttribute(hConsole, 15);// bright white
				cin >> sel;
				SetConsoleTextAttribute(hConsole, 12);// red

			if (sel != 'y' && sel != 'Y' && sel != 'n' && sel != 'N') // exception thrower
				throw fail2;
			}
			catch (string x) // standard catch block
			{
				SetConsoleTextAttribute(hConsole, 14);
				cout << endl;
				cout << x;
				cout << endl << endl;
				SetConsoleTextAttribute(hConsole, 12);
			}
			
			if (sel == 'y' || sel == 'Y') // if they want to continue
			{
				if (swdQt >= amt)
				{
				SetConsoleTextAttribute(hConsole, 12); // red
				cout << "You sold " << amt << " Legionare's Swords" << endl; // cout amount sold
				cout << "GP before transaction was: " <<  character->GP << endl;
				character->GP = character->GP + (25 * amt);// update Gp
				swdQt = swdQt - amt;// update QTy item
				cout << "GP: " << setw(5) << character->GP << endl; // cout gold
				cout << "Legionare's Swords:" << setw(5) << swdQt << endl; // output item qty
				cout << endl;
				}
				else
					cout << endl << x << endl;
			}
			else
			break;
		}

		else if (sel == 'l' || sel == 'L') // dagger sell options
		{
			int amt = 0;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "How many Swords of Gant would you like to Sell?" << endl; // cout question
			cout << endl;
			SetConsoleTextAttribute(hConsole, 15);
			cin >> amt; // get amount to sell
			SetConsoleTextAttribute(hConsole, 12);
			cout << "Are you sure you want to sell " << amt << " Swords of Gant?" << endl << endl; // confirmation question
			try
			{
				SetConsoleTextAttribute(hConsole, 15);// bright white
				cin >> sel;
				SetConsoleTextAttribute(hConsole, 12);// red

			if (sel != 'y' && sel != 'Y' && sel != 'n' && sel != 'N') // exception thrower
				throw fail2;
			}
			catch (string x) // standard catch block
			{
				SetConsoleTextAttribute(hConsole, 14);
				cout << endl;
				cout << x;
				cout << endl << endl;
				SetConsoleTextAttribute(hConsole, 12);
			}
			if (sel == 'y' || sel == 'Y')
			{
				
				if (lswQt >= amt) // checks inventory Qty
				{
				SetConsoleTextAttribute(hConsole, 12); // change variables gold and invetory QTY
				cout << "You sold " << amt << " Swords of Gant" << endl;
				cout << "GP before transaction was: " <<  character->GP << endl;
				character->GP = character->GP + (40 * amt);
				lswQt = lswQt - amt;
				cout << "GP: " << setw(5) << character->GP << endl;
				cout << "Swords of Gant:" << setw(5) << lswQt << endl;
				cout << endl;
				}
				else
					cout << endl << x << endl;

			}
			else
			break;
		}
		else 
			break;
		}while (sel != 'e' || sel != 'E');
} // end sellWeapons

void inventory :: buyArmor (saveLoad *character)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
	
	string fail = "You may only enter A, W , P, or E!" ;
	SetConsoleTextAttribute(hConsole, 12);
	cout << endl;
	do
	{
	cout << "Select the type of weapon you would like to Buy." << endl; // cout instructions
	cout << "Press H for helmet. 40 GP" << endl;
	cout << "Press C for Cuirass. 80 GP " << endl;
	cout << "Press G for Greaves. 60 GP" << endl;
	cout << "Press E to exit buy armor menu. " << endl << endl;
	try
	{
		SetConsoleTextAttribute(hConsole, 15);// bright white
		cin >> sel;
		SetConsoleTextAttribute(hConsole, 12);// red

		if (sel != 'h' && sel != 'H' && sel != 'c' && sel != 'C' && sel != 'g' && sel != 'G' && sel != 'e' && sel != 'E') // exception thrower
			throw fail;
	}
	catch (string x) // standard catch block
	{
		SetConsoleTextAttribute(hConsole, 12);
		cout << endl;
		cout << x;
		cout << endl;
	}
	if (sel == 'h' || sel == 'H')
		{
			int amt = 0;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "How many Helms of the Master would you like to buy?" << endl; // cout for amount
			cout << endl; // get amount
			SetConsoleTextAttribute(hConsole, 15);
			cin >> amt;
			if (character->GP >= (40 * amt))// check if amount * price exceeds player GP
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << "You bought " << amt << " Helms of the Master" << endl; // cout number of item bought
				cout << "GP before transaction was: " <<  character->GP << endl;
				character->GP = character->GP - (40 * amt); // update money
				Helm = Helm + amt;// update inventory stock
				cout << "GP: " << setw(5) << character->GP << endl; // cout gold left
				cout << "Helms of the Master:" << setw(5) << Helm << endl; // number of item in ventory
				cout << endl;
				helmet = true;
			}
			else
			{
				SetConsoleTextAttribute(hConsole, 12); // if not enough Insufficient funds satement
				cout << endl;
				cout << "Insufficeint funds" << endl;
				cout << endl;
			}
		}

		else if (sel == 'c' || sel == 'C') //same as above only for legionare's swords instead
		{
			int amt = 0;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "How many Cuirass of Palandinian would you like to buy?" << endl;
			cout << endl;
			SetConsoleTextAttribute(hConsole, 15);
			cin >> amt;
			if (character->GP >= (80 * amt))
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << "You bought " << amt << " Cuirass of Palandinian" << endl;
				cout << "GP before transaction was: " <<  character->GP << endl;
				character->GP = character->GP - (80 * amt);
				Cur = Cur + amt;
				cout << "GP: " << setw(5) << character->GP << endl;
				cout << "Cuirass of Palandinian:" << setw(5) << Cur << endl;
				cuirass = true;
				cout << endl;
			}
			else
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << endl;
				cout << "Insufficeint funds" << endl;
				cout << endl;
			}
		}

		else if (sel == 'g' || sel == 'G') // same as above only for daggers
		{
			int amt = 0;
			SetConsoleTextAttribute(hConsole, 12);
			cout << "How many Greaves of Master Shota would you like to buy?" << endl;
			cout << endl;
			SetConsoleTextAttribute(hConsole, 15);
			cin >> amt;

			if (character->GP >= (60 * amt))
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << "You bought " << amt << " Greaves of Master Shota" << endl;
				cout << "GP before transaction was: " <<  character->GP << endl;
				character->GP = character->GP - (60 * amt);
				Grvs = Grvs + amt;
				cout << "GP: " << setw(5) << character->GP << endl;
				cout << "Greaves of Master Shota:" << setw(5) << Grvs << endl;
				greaves = true;
				cout << endl;
			}
			else
			{
				SetConsoleTextAttribute(hConsole, 12);
				cout << endl;
				cout << "Insufficeint funds" << endl;
				cout << endl;
			}
		}
		else // break on E
			break;
		}while (sel != 'e' || sel != 'E');
}// buyWep

void inventory :: storeBuy (saveLoad *character)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
	
	string fail = "You may only enter A, W , P, or E!" ;
	SetConsoleTextAttribute(hConsole, 12);
	do 
	{
		SetConsoleTextAttribute(hConsole, 12);
		cout << endl;
		img.swordbuy ();
		cout << "Press A to buy armor. " << endl;
		cout << "Press W to buy weapons. " << endl;
		cout << "Press P to buy potions. " << endl;
		cout << "Press E to exit store buy menu. " << endl << endl;

	try
	{
		SetConsoleTextAttribute(hConsole, 15);// bright white
		cin >> sel;
		SetConsoleTextAttribute(hConsole, 12);// red

		if (sel != 'a' && sel != 'A' && sel != 'w' && sel != 'W' && sel != 'p' && sel != 'P' && sel != 'e' && sel != 'E') // exception thrower
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
		buyArmor (character);
	}
	else if (sel == 'w' || sel == 'W')
		buyWeap (character);
	
	else if (sel == 'p' || sel == 'P')
		buyPot (character);
	
	else
		break;
	}while (sel != 'e' || sel != 'E');
}// storeBuy

void inventory :: storeSell (saveLoad *character)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
	
	string fail = "You may only enter A, W , P, or E!" ;
	SetConsoleTextAttribute(hConsole, 12);
	do 
	{
		SetConsoleTextAttribute(hConsole, 12);
		cout << endl;
		img.swordsell ();
		cout << "All items purchased at half of value." << endl;
		cout << "Press A to Sell armor. " << endl;
		cout << "Press W to Sell weapons. " << endl;
		cout << "Press E to store sell menu. " << endl << endl;

	try
	{
		SetConsoleTextAttribute(hConsole, 15);// bright white
		cin >> sel;
		SetConsoleTextAttribute(hConsole, 12);// red

		if (sel != 'a' && sel != 'A' && sel != 'w' && sel != 'W'  && sel != 'e' && sel != 'E') // exception thrower
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
		sellArmor (character);

	else if (sel == 'w' || sel == 'W')
		sellWeap (character);

	else
		break;
	}while (sel != 'e' || sel != 'E');
}// storeSell 

void inventory :: storeMenu (saveLoad *character)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
	
	string fail = "You may only enter B, S, or E!" ;
	SetConsoleTextAttribute(hConsole, 12);
	img.swordStor ();
	do
	{
	cout << endl << "Would you like to buy or sell items? " << endl;
	cout << "Press B to Buy" << endl;
	cout << "Press S to Sell" << endl;
	cout << "Press E to General Store menu" << endl;
	cout << endl;
	try
	{
		SetConsoleTextAttribute(hConsole, 15);// bright white
		cin >> sel;
		SetConsoleTextAttribute(hConsole, 12);// red

		if (sel != 'b' && sel != 'B' && sel != 's' && sel != 'S'  && sel != 'e' && sel != 'E') // exception thrower
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
	if (sel == 'b' || sel == 'B')
	{
		storeBuy (character);
	}
	else if (sel == 's' || sel == 'S')
	{
		storeSell (character);
	}

	else
		break;

	}while (sel != 'e' || sel != 'E');
}



