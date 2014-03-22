////////////////////////////////////////////////////////
//
// Project Yosemite 0.1
// All source code by Blaine Simcox
//
// Panos Mastrogiannis
//////////////////////////////////////////////////////

#include "CharSheet.h"
#include <iostream>

charSheet :: charSheet () // default constructor intializes all variable to 0
{
	LVL = 0;
	for (num = 0; num <= 5; num ++)
	{
		CSTAT [num] = 0;
		CMOD [num] = 0;
	}
	
	AC = 0;
	HP = 0;
	EXP = 0;
	MaxHp = 0;
	MaxMp = 0;
	GP = 0;
}
charSheet :: charSheet (int cstat[6], int cMod[6], int hp, int ac, int lvl, 
						int mana, int maxHp, int maxMp, int exp, int gp) // constructor with parameters
{
	charSet (cstat, cMod, hp, ac, lvl, mana, maxHp, maxMp, exp, gp);
}

int charSheet :: smaller (int A, int B) // smaller version of compareFour only compare two.
{
	int least;
	if (A <= B)
		least = A;
	else
		least = B;
	return least;
}

int charSheet :: comparefour(int v, int x, int y, int z) // function is comparing four numbers for the least value
{
	return smaller(v, smaller (x, smaller (y, z)));
}

void charSheet :: charRoll(int cstat[6]) // function to randomly 4 six-sided dice and discard the least value one
{
	for (num = 0; num <= 5; num++)  // these numbers are stored in the array for character statistics (CSTAT)
	{
		if (cstat[num] <= 0)
		{
		int a = 0; // initialize all five variables
		int b = 0;
		int c = 0;
		int d = 0;
		int less = 0;
		a = (rand() + time (0)) % 6 + 1; // get their values
		b = (rand() + time (0)) % 6 + 1;
		c = (rand() + time (0)) % 6 + 1;
		d = (rand() + time (0)) % 6 + 1;

		
		less = comparefour(a,b,c,d); // find the least value
		cstat[num] = a + b + c + d - less; // subtract least value from four
		CSTAT [num] = cstat[num]; // reference class member variable CSTAT
		}
		else
		{
			CSTAT [num] = cstat [num];
		}
	}
} 

int charSheet :: getExp () const // next 14 functions are accessors for charSheet class
{
	return EXP;
}
int charSheet :: getStat (int num) const
{
	return CMOD[num];
}
int charSheet :: getHp () const
{
	return HP;
}
int charSheet :: getMp () const
{
	return MANA;
}
int charSheet :: getAc () const
{
	return AC;
}
int charSheet :: getMaxMp () const
{
	return MaxMp;
}
int charSheet :: getMaxHp () const
{
	return MaxHp;
}
int charSheet :: getLvl () const
{
	return LVL;
}
int charSheet :: getGp () const
{
	return GP;
}

void charSheet :: modifier (int cstat [6], int cMod [6]) // function to find stat modifiers
{

    for (num = 0; num <= 5; num++)  // this takes each stat and finds the corresponding modifier and writes each into another array
	{
		if (cMod[num] <= 0)
		{
		cMod [num] = modList(cstat[num]);
		CMOD [num] = cMod [num];
		}
		else // this sets the number to a predefined number if there is one
		{
			CMOD[num] = cMod[num];
		}
	}
}
int charSheet :: modList (int y) // this is a self-explanatory table for getting the modifier after stats are rolled
{
	switch(y)
	{
	case  1: // if stat == 1-4, modifier = 0, etc.....
	case 2:
	case 3:
	case 4:
		y = 0;
		return  y;
		break;
	case 5:
	case 6:
	case 7:
		y = 1;
		return y;
		break;
	case 8:
	case 9:
		y = 2;
		return y;
		break;
	case 10:
	case 11:
		y = 3;
		return y;
		break;
	case 12:
	case 13:
	case 14:
	
		y = 4;
		return y;
		break;
	case 15:
	case 16:
		y = 5;
		return y;
		break;
	case 17: 
		y = 6;
		return y;
	case 18:
		y = 7;
		return y;
	case 19:
		y = 8;
		return y;
	case 20:
		y = 10;
		return y;
	default:
		break;
	}
}
void charSheet :: setGp (int gp) // this function sets gold value to 120 for level one characters
{
	if (LVL <= 1 && gp <=0)
	{
		gp = 120;
		GP = gp;
	}
	else
		GP = gp;
}

void charSheet :: setExp (int exp) // this initializes your exp to 0
{
	if (exp <= 0)
	{
		exp = 0;
		EXP = exp;
	}
	else 
		EXP = exp;
}

void charSheet :: setHp (int hp) // function to calculate HP
{
	if (hp <= 0)
	{
	hp = 12 * LVL + CMOD[3];
	HP = hp;
	}
	else
	{
		HP = hp;
	}
}
void charSheet :: setMMana (int maxMp) // sets your Maximum MP
{
	if (maxMp <= 0)
	{
		maxMp = (9 + CMOD [4]) * LVL;
		MaxMp = maxMp;
	}
	else
	{
		MaxMp = maxMp;
	}
}
void charSheet :: setMHp (int maxHp) // sets your max Hp
{
	if (maxHp <= 0)
	{
		maxHp = (12  + CMOD [3]) * LVL;
		MaxHp = maxHp;
	}
	else
	{
		MaxHp = maxHp;
	}
}

void charSheet :: setLvl (int lvl) // sets your level to one if level is 0
{
	if (lvl > 1)
	{
		LVL = lvl;
	}
	else
	{
		lvl = 1;
		LVL = lvl;
	}
}


void charSheet :: setAc (int ac) // this functin ssets you AC initially
{
	if (ac <= 0)
	{
	ac = 3 + CMOD[1];
	AC = ac;
	}
	else
	{
		AC = ac;
	}
}
void charSheet :: setMana (int mana) // this is the function to set your mana or MP
{
	if (mana <= 0)
	{
	mana = 9 * LVL + CMOD[4];
	
	MANA = mana;
	}
	else
	{
	MANA = mana;
	}


}
void charSheet :: charSet ( int cstat[6], int cMod[6], int hp, int ac, int lvl, 
							int mana, int maxHp, int maxMp, int exp, int gp) // function to set character stats
{
	setLvl (lvl);
	charRoll(cstat);
	modifier (cstat, cMod);
	setMana(mana);
	setMMana (maxMp);
	setHp (hp);
	setMHp (maxHp);
	setAc (ac);
	setGp (gp);
	setExp (exp);

}
void charSheet :: printAll () // this function will be used to print data to the screen (player info)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hConsole, 3);

	cout << endl;
	cout << endl;
	cout << "This is the printAll() function executing." << endl;
	cout << "******************************************" << endl;
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
void charSheet :: name (string name)  // this is the function to set the name, it will only be used once so it has some of the character gen menu in it
{
	cout << "First we will roll your Character's Stats. Please enter a 1 word name."<< endl;
	cout << endl;
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hConsole, 15);
	cin >> name;
	NAME = name;
	cout << endl;
	SetConsoleTextAttribute(hConsole, 12);
	cout << "You're character's name is " ;
	SetConsoleTextAttribute(hConsole, 15);
	cout << NAME << endl;
	cout << endl;
	SetConsoleTextAttribute(hConsole, 12);
	
}
void charSheet :: wipe () // this function re initializes all variables to 0 for re-rolling stats
{
	for (num = 0; num <=5; num++)
	{
		CSTAT [num] = 0;
		CMOD [num] = 0;
	}

	MaxHp =0;
	MaxMp = 0;
	AC = 0;
	GP = 0;
	HP = 0;
	MANA = 0;
	LVL = 0;
	EXP = 0;
}
ostream& operator<< (ostream& statistic, const charSheet& character) // this is my insertion operator overload it is also in saveLoad class
{
	int num = 0;
	
	HANDLE  hConsole;
	
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hConsole, 3);

	statistic << endl << endl << "This is An Overloaded << Function Call from CharSheet!" << endl;
	statistic << "***************************************" << endl;
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


void charSheet :: generate () // this function calls al necessary functions to build character
{
	char sel;

	name(NAME);
	cout << "Hit Y to roll your character: " << endl << endl;
	do
	{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hConsole, 15);
	
	cin >> sel;
	if (sel == 'y' || sel == 'Y') // this loop is to allow players to re-roll their stats
	{
	wipe();
	cout << endl;
	charSet(CSTAT, CMOD, HP, AC, LVL, MANA, MaxHp, MaxMp, EXP, GP);
	cout << endl;
	
	cout << endl;
	printAll ();
	cout << endl;
	cout << endl;
	SetConsoleTextAttribute(hConsole, 12);
	cout << "Would you like to re-roll?  Press Y or N!" << endl;
	cout << endl;
	}
	else if ( LVL > 0 && sel == 'n' || sel == 'N') // if selection is no, this exits loop and continues on to next section of code
	{
	break;
	}
	else
	{
	SetConsoleTextAttribute(hConsole, 12);
	if (LVL <= 0 && sel == 'n' || sel == 'N')
	{
		cout << endl <<  "You must roll a character to continue!" << endl << endl;
	}
	else
	{
	cout << "Improper Input Received. Hit 'Y' to continue." << endl; // improper input handling
	cout << endl;
	}
	}
	
	
	}while (sel != 'n' || sel != 'N');
}
