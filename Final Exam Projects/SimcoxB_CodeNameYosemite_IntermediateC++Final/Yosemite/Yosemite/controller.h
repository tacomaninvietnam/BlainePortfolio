#ifndef controller_H
#define controller_H

#include <iostream>
#include <iomanip>
#include <ctime>
#include <cmath>
#include <cstdlib>
#include <fstream>
#include <string>
#include <windows.h>
#include "CharSheet.h"
#include "Save_Load.h"
#include "campaign.h"
#include "challenges.h"
#include "inventory.h"
#include "image.h"

using namespace std;

class controller 
{
public:
	controller :: controller ();
	void runTime ();
	void start ();
	int player (saveLoad *character);
	void start1 ();
	void loadInv (ifstream& infile, inventory *inv);
	void saveInv (ofstream& outfile, inventory *inv);
	int equipH;
	int equipC;
	int equipG;
	int equipS;
	int equipD;
	int equipL;
	void orcCtest (string name);
	void soldierC ();
	void wolfC ();
	void print (charSheet *character);
	void soldierC (string name);
	charSheet *enemy;

	

private:
	charSheet orc; // this and all other charsheet obj will be monsters.
	charSheet soldier;
	charSheet wolf;
	charSheet PC;
	charSheet cha;
	saveLoad character; // this will be the actual player object 
	
	campaign cp; // campaign object
	challenges ch;
	char sel; // variable for selection
	ifstream in;// the rest are self-explanatory
	string name;
	ofstream out;
	int sl;
	int num;
	HANDLE hConsole;
	inventory inv;
	image img;
};
#endif