#ifndef challenges_H
#define challenges_H

#include <iostream>
#include <iomanip>
#include <ctime>
#include <cmath>
#include <cstdlib>
#include <fstream>
#include <string>
#include "CharSheet.h"
#include "Save_Load.h"
#include "inventory.h"



class challenges 
{
public:
	challenges ();
	void survival (int stat, int challRate, saveLoad *character);
	int dice (int num, int stat, saveLoad character);
	void playerDeathC (saveLoad *character);
	void levelCheck (saveLoad *character);
	void npcDeathC (charSheet *enemy, saveLoad *character);
	void damageRoll (saveLoad *character, charSheet *enemy, int num);
	void magicRoll (saveLoad *character, charSheet *enemy, int num, string magic);
	void attackRoll (saveLoad *character, charSheet *enemy, inventory *inv);
	void playerBehav (saveLoad * character, charSheet *enemy, inventory *inv);
	void magicAttack (saveLoad *character, charSheet *enemy, inventory *inv);
	void weaponAttack (saveLoad *character);
	void stoneArmor (saveLoad *character);
	void deathWave (saveLoad *character, charSheet *enemy);

	void playerAttackM (saveLoad *character, charSheet *enemy, inventory *inv);
	void npcDmg (saveLoad *character, charSheet *enemy, int wep);
	void npcAttack (saveLoad *character, charSheet *enemy, int wep, string type);
	bool flee;
	void combat (saveLoad *character, charSheet *enemy, int wep, string type, inventory *inv);
	void multi (saveLoad *character, charSheet *enmy1, charSheet *enemy2, charSheet enemy3, int wep, string type, inventory *inv); 
	
private:
	bool stoneAm;
	int stone;
	int num;
	int dmg;
	char sel;
	bool hasAtt;
	HANDLE  hConsole;
	image img;
	
};
#endif

