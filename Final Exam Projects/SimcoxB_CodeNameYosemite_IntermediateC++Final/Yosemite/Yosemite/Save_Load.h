#ifndef saveLoad_H
#define saveLoad_H

#include <fstream>
#include <string>
#include "CharSheet.h"

#include <iostream>
#include <Windows.h>


class saveLoad: public charSheet
{
public:
	saveLoad :: saveLoad ();
	void getData ();
	void loadData (ifstream& infile, string name);
	void saveData (ofstream& outfile, string name);
	void openF (ifstream& infile, string name);
	friend ostream& operator<< (ostream& statistic, const saveLoad& character);
	void printAll ();
	void openO (ofstream& outfile, string name);
	void closeO (ofstream& outfile, string name);
	void saveMenu ();
	
	
private:
	int num;
	
	 
	string FNAME;
	charSheet cha;
	HANDLE  hConsole;
	
	
};
#endif