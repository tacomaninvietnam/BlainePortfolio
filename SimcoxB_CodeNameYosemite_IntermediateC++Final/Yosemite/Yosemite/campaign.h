#ifndef campaign_H
#define campaign_H

#include <iostream>
#include <fstream>
#include <string>
#include <cstdlib>

#include <Windows.h>
#include "challenges.h"
#include "Save_Load.h"


using namespace std;

class campaign
{
public:
	campaign :: campaign ();
	void readStory (string name);
	void readOption (string name);
	void optionsM (saveLoad *character, inventory *inv, string name, int dmg, int stat, int challRate);
	void cpsearch (saveLoad *character, inventory *inv, int challRate);
	void easyA (saveLoad *character,  int dmg, string line);
	int dice (int dmg);
	bool found;
	void optionsMncbt (saveLoad *character, inventory *inv,  int stat, int challRate);

private:
	string NAME;
	string list[23];
	string op[4];
	int num;
	HANDLE hConsole;
	char sel;
	challenges ch;
};
#endif