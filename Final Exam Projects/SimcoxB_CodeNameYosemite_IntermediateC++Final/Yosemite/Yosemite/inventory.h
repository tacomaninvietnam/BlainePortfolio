#ifndef inventory_H
#define inventory_H

#include "save_Load.h"
#include "CharSheet.h"
#include "image.h"
#include <iostream>
#include <iomanip>
#include <ctime>
#include <cmath>
#include <Windows.h>
#include <cstdlib>
#include <fstream>
#include <string>


using namespace std;

class inventory 
{
public:
	inventory ();
	void print(saveLoad *character);
	void printAll();
	void weapon ();
	void magic (saveLoad *character);
	void equip (saveLoad *character, string itemType);
	void uneqip (saveLoad *charcter);
	int potion ();
	void usePotion (saveLoad *character, string name);
	int magicP; // variable for storing magic potions
	int hpP; // variable for storing health potions
	int Cur;
	int Helm;
	int Grvs;
	image img;
	void buyWeap (saveLoad *character);
	void buyArmor (saveLoad *character);
	void buyPot (saveLoad *character);
	int iDice (int num, int stat, saveLoad character);

	bool greaves; // values for storing availability of armors
	bool helmet;
	bool cuirass;
	
	bool equipGr;// values for storing equip status of armor
	bool equipHm;
	bool equipCr;

	bool equipDag;// variables for equip status of weapons
	bool equipSwd;
	bool equipLsw;

	bool magicBlast; // availability of magic
	bool fireBall;
	bool stoneArmor;
	bool deathWave;

	int dagQt; // variables for storing weapon quntities
	int swdQt;
	int lswQt;

	void equipArmor (saveLoad *character);
	void inventoryMenu(saveLoad *character);
	void potionMenu(saveLoad *character);
	void weaponAv ();
	void weaponAvOp ();
	void weaponSelect();
	void weaponMenu(saveLoad *character);
	void storeBuy (saveLoad *character);
	void storeCheck (saveLoad *character);
	void sellWeap (saveLoad *character);
	void sellArmor (saveLoad *character);
	void storeSell (saveLoad *character);
	void storeMenu (saveLoad *character);

private:
	
	HANDLE  hConsole;
	char sel;
	
};
#endif
