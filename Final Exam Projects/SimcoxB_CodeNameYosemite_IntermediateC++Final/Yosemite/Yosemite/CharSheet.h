////////////////////////////////////////////////////////
//
// Project Yosemite 0.1
// All source code by Blaine Simcox
//
// Panos Magistrianni
//////////////////////////////////////////////////////

#ifndef charSheet_H
#define charSheet_H

#include "image.h"
#include <iostream>
#include <iomanip>
#include <ctime>
#include <cmath>
#include <cstdlib>
#include <fstream>
#include <string>
#include <Windows.h>


using namespace std;

class charSheet
{
public:
	charSheet ();
	charSheet (int cstat[6], int cMod[6], int hp, int ac, int lvl, int mana, int maxHp, int maxMp, int exp, int gp);
	int smaller (int A, int B); 
	int comparefour(int v, int x, int y, int z);
	void charRoll(int cstat[6]);
	void modifier (int cstat[6], int cMod [6]);
	int modList (int y);
	void charSet (int cstat[6], int cMod[6], int hp, int ac, int lvl, int mana, int maxHp, int maxMp, int exp, int gp);
	void setGp (int gp);
	void setExp (int exp);
	int getStat (int num) const;
	int getMp () const;
	int getHp () const;
	int getAc () const;
	int getExp () const;
	int getGp () const;
	int getLvl () const;
	int getMaxMp () const;
	int getMaxHp () const;
	void setMana (int mana);
	void setMMana (int maxMp);
	void setHp (int hp);
	void setMHp (int maxHp);
	void setAc (int ac);
	void setLvl (int lvl);
	void name (string name);
	virtual void printAll ();
	void generate ();
	void wipe ();
	friend ostream& operator<< (ostream& statistic, const charSheet& character);
	void deathCheck (charSheet *character);

	HANDLE  hConsole;
	int HP;
	int AC;
	int CSTAT[6];
	int CMOD [6];
	int LVL;
	int MANA;
	int MaxMp;
	int MaxHp;
	int GP;
	int EXP;
	string NAME;
	image img;


private:
	int num;
	
	
	

};
#endif