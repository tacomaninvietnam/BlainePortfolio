#include "challenges.h"
challenges :: challenges ()// there just isn't anything to initialize in this class so constructor is empty
{
stoneAm = false;
hasAtt = false;
}

int challenges :: dice(int num, int stat, saveLoad character) // this is my improved dynamic dice
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

void challenges :: survival (int stat, int challRate, saveLoad *character) // this is basic challenge function
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // color change is common as you have already seen
	SetConsoleTextAttribute(hConsole, 12);

	int dmg = 0;

	if (challRate <= 0) // if challenge rate set to 0 or less rolls random challenge rating 
	{
		int x = dice(20, stat, *character); // character roll
		int challRate = dice(20, 7, *character);//dm roll
		
		if (x >= challRate) // you get to proceed if successful roll
		{
			cout << endl;
			cout << "Success! " << endl;
			cout << challRate << endl;
			cout << endl;
			flee = true;
		}
	
		else // this sets damage for failed roll
		{
			int dmg = 0; // initialize dmg (damage to 0)
			cout << endl << "Failure!" << endl; // fail messege show HP before and after hit
			cout << "Your HP before damage is " << character->HP << endl;
			dmg = dice(6, 6, *character);
			cout << "You receive " << dmg << " damage." << endl;
			character->HP = character->HP - dmg;
			cout << "Your Hit Points are: " << character->HP;
			playerDeathC(character); // checks to make sure character is still alive, if not exits the game
			cout << endl;
		}
	}
	else
	{
		int x = dice(20, stat, *character); // character roll
		
		
		if (x >= challRate) // you get to proceed if successful roll
		{
			cout << endl;
			cout << "Success! " << endl;
			cout << challRate << endl;
			cout << endl;
		}
	
		else // this sets damage for failed roll
		{
			int dmg = 0; // initialize dmg (damage to 0)
			cout << endl << "Failure!" << endl << endl; // fail messege show HP before and after hit
			cout << "Your HP before damage is " << character->HP << endl << endl;
			dmg = dice(6, 6, *character);
			cout << "You receive " << dmg << " damage." << endl << endl;
			character->HP = character->HP - dmg;
			cout << "Your Hit Points are: " << character->HP;
			playerDeathC(character); // checks to make sure character is still alive, if not exits the game
			cout << endl;
		}
	}

	
}

void challenges :: playerDeathC (saveLoad *character) // this is player death check as the name implies
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); //set color to red 
	SetConsoleTextAttribute(hConsole, 12);

	if (character->HP <= 0) // check if player is dead or not
	{
		cout << endl;
		cout << "You are dead!" << endl << endl; // cout statement
		img.gameOver (); // prints gameover skull to screen
		system("pause"); // this is more so the player gets to see my skull than anything
		exit(1); // exit program 
	}
}

void challenges :: levelCheck (saveLoad *character)
{
	int y = 0;
	int x = 0;

	if (character->EXP >= character->LVL * 50)
	{
		y = dice (12, 3, *character);
		x = dice (8, 2, *character);
		character->LVL++;
		character->MaxHp = character->MaxHp + y;
		character->MaxMp = character->MaxMp + x;
		character->HP = character->HP + y + character->CMOD[3];
		character->MANA = character->MANA + x;
		cout << "You Gained a level. You are now level " << character->LVL << endl << endl;
		cout << "You Gained " << y << " Hit Points!" << endl;
		cout << "You Gained " << x << " Magic Points! " << endl;
		cout << endl << "HP: " << setw(6) << character->HP << " / " << character->MaxHp << endl;
		cout << "MP: " << setw(6) << character->MANA << " / " << character->MaxMp << endl << endl;
		

	}
}


void challenges :: npcDeathC (charSheet *enemy, saveLoad *character) // similar to player death, different results though
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // set color to bright red
	SetConsoleTextAttribute(hConsole, 12);

	if (enemy->HP <=0) // if enemy character dead transfer experience and money
	{
		cout << endl;
		character->GP = character->GP + enemy->GP;
		cout << "You receive " << enemy->GP << " Gold." << endl;
		character->EXP = character->EXP + enemy->EXP;
		cout << "You receive " << enemy->EXP << " Experience Points" << endl << endl;
		levelCheck (character);
		if (stoneAm == true)
		{
		stoneAm = false;
		character->AC = character->AC - stone;
		}
	}// otherwise keep fighting till one of you die!!!!!!!!!
}


void challenges :: damageRoll (saveLoad *character, charSheet *enemy, int num)
{
	dmg = 0;
	dmg = dice (num, 0, *character);
	cout << endl << "You land a mighty blow!" << endl << endl;
	cout << "You deal " << dmg << " damage!" << endl;
	enemy->HP = enemy->HP - dmg;
	cout << " Enemy HP: " << setw(5) << enemy->HP;
	npcDeathC (enemy, character);
}

void challenges :: magicRoll (saveLoad *character, charSheet *enemy, int num, string magic)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // set color to bright red
	SetConsoleTextAttribute(hConsole, 14);
	dmg = 0;
	dmg = dice (num, 2, *character);
	cout << endl << "You attack with " << magic << endl << endl;
	enemy->HP = enemy->HP - dmg;
	cout << "You deal " << dmg << " damage!" << endl;
	cout << " Enemy HP: " << setw(5) << enemy->HP << endl;
	npcDeathC (enemy, character);
}

void challenges :: stoneArmor (saveLoad *character)
{
	
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // set color to bright red
	SetConsoleTextAttribute(hConsole, 14);
	stone = 0;
	stone = dice(4, 7, *character);
	cout << endl << "You're Ac increased temporarilly increased by " << stone << endl << endl;
	character->AC = character->AC + stone;
	character->MANA = character->MANA - 15;
}

void challenges :: deathWave (saveLoad *character, charSheet *enemy)
{
	
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // set color to bright red
	SetConsoleTextAttribute(hConsole, 14);
	dmg = 0;
	cout << endl << "You're enemy withers from the blow of your magic" << endl;
	dmg = enemy->MaxHp;
	enemy->HP = enemy->HP - dmg;
	cout << "You deal " << dmg << " damage!" << endl;
	cout << " Enemy HP: " << setw(5) << enemy->HP << endl;
	npcDeathC (enemy, character);
	character->MANA = character->MANA - 20;
}

void challenges :: attackRoll (saveLoad *character, charSheet *enemy, inventory *inv)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // set color to bright red
	SetConsoleTextAttribute(hConsole, 14);
	int y = 0;
	int num = 0;
	dmg = 0;
	
	string fail = "You're swing wildly, missing your opponent!";
	y = dice (20, 1, *character);

	if (y >= enemy->AC)
	{
		if (inv->equipDag == true) // if equipped weapon is dagger
		{
			num = 2;
			damageRoll (character, enemy, num);
		}
		else if (inv->equipLsw == true)
		{
			num = 8;
			damageRoll (character, enemy, num);
			
		}
		else if (inv->equipSwd == true)
		{
			num = 5;
			damageRoll (character, enemy, num);
			
		}
		else
		{
			dmg = character->CMOD[0];
			cout << endl << "You land a mighty blow!" << endl << endl;
			cout << "You deal " << dmg << " damage!" << endl;
			enemy->HP = enemy->HP - dmg;
			cout << " Enemy HP: " << setw(5) << enemy->HP;
			npcDeathC (enemy, character);
			
		}
	}
	else
	{
		cout << endl;
		cout << fail << endl << endl;
	}



}

void challenges :: playerBehav (saveLoad *character, charSheet *enemy, inventory *inv)
{
	if (character->LVL >= 4)
	{
		attackRoll (character, enemy, inv);
		if (enemy->HP > 0 )
		{
		attackRoll (character, enemy, inv);
		}
		hasAtt = true;
	}
	else
	{
		attackRoll (character, enemy, inv);
		hasAtt = true;
	}
}

void challenges :: magicAttack (saveLoad *character, charSheet *enemy, inventory *inv)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // sets the hconsole variable to handle object
	SetConsoleTextAttribute(hConsole, 12);
	string fail = "You may only enter A, B, C, D, Or E!" ;
	string x = "Not a High Enough Level for this Option!" ; 
	string y = "Not enough Mana!";
	SetConsoleTextAttribute(hConsole, 12);
	if (character->LVL >= 2)
		inv->fireBall = true;
	if (character->LVL >= 3)
		inv->stoneArmor = true;
	if (character->LVL >= 4)
		inv->deathWave = true;

	do 
	{
	SetConsoleTextAttribute(hConsole, 14);
	cout << "Please choose the the letter spell you want to cast." << endl << endl;
	if (inv->magicBlast == true)
		cout << "A. Magic Blast. 1d4 + INT modifier damage. " << endl << "   MP Cost: 5" << endl;
	if (inv->fireBall == true)
		cout << "B. Fireball. 1d10 + INT modifier damage." << endl << "   MP Cost: 10" << endl;
	if (inv->stoneArmor == true)
		cout << "C. Stone Armor. 1d4 increase to AC. " << endl 
		<< "Effect ends when combat ends"  << endl << "   MP Cost: 15" << endl;
	if (inv->deathWave == true)
		cout << "D. Death Wave.  Instantly kills enemy." << endl << "MP Cost: 20" << endl;
		cout << "E. Exit Magic Attack Menu. " << endl << endl;


	try
	{
		SetConsoleTextAttribute(hConsole, 15);// bright white
		cin >> sel;
		SetConsoleTextAttribute(hConsole, 12);// red

		if (sel != 'a' && sel != 'A' && sel != 'b' && sel != 'B' && sel != 'c' && sel != 'C' && sel != 'd' && sel != 'D' && sel != 'e' && sel != 'E') // exception thrower
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
		if (inv->magicBlast == true && character->MANA >= 5)
		{
			magicRoll (character, enemy, 4, "Magic Blast");
			character->MANA = character->MANA - 5;
			hasAtt = true;
			break;
		}
		else if (inv->magicBlast == true && character->MANA < 5)
			cout << endl << y << endl;
		else
			cout << endl << x << endl << endl;
	}

	else if (sel == 'b' || sel == 'B')
	{
		if (inv->fireBall == true && character->MANA >= 10)
		{
			magicRoll (character, enemy, 10, "Fireball");
			character->MANA = character->MANA - 10;
			hasAtt = true;
			break;
		}
		else if (inv->fireBall == true && character->MANA < 10)
			cout << endl << y << endl;
		else
			cout << endl << x << endl;
	}
	
	else if (sel == 'c' || sel == 'C'&& character->MANA >= 15)
	{
		if (inv->stoneArmor == true && character->MANA >= 15 && stoneAm == false)
		{
			stoneArmor (character);
			stoneAm = true;
			hasAtt = true;
			break;
		}
		else if (inv->stoneArmor == true && character->MANA > 15 && stoneAm == true)
			cout << endl << "Stone Armor already Equipped!" << endl << endl;

		else if (inv->stoneArmor == true && character->MANA < 15)
			cout << endl << y << endl;
		else 
			cout << endl << x << endl << endl;
	}

	else if (sel == 'd' || sel == 'D')
	{
		if (inv->deathWave == true && character->MANA >= 20)
		{
			deathWave (character, enemy);
			hasAtt = true;
			break;
		}
		else if (inv->deathWave == true && character->MANA < 20)
			cout << endl << y << endl << endl;
		else
			cout << endl << x << endl << endl;
	}
	else 
		break;

	}while (sel != 'e' || sel != 'E');
}

void challenges :: playerAttackM (saveLoad *character, charSheet *enemy, inventory *inv)
{
	hasAtt = false;
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // set color to bright red
	SetConsoleTextAttribute(hConsole, 12);
	string fail = "You may only enter A, B, or C!" ;

	while (hasAtt != true)
	{
		SetConsoleTextAttribute(hConsole, 12);
		cout << "A. Attack with Currently Equipped Weapon." << endl;
		cout << "B. Use Magic!" << endl;
		cout << "C. Player Inventory. " << endl << endl;
	try
	{
		SetConsoleTextAttribute(hConsole, 15);// bright white
		cin >> sel;
		SetConsoleTextAttribute(hConsole, 12);// red

		if (sel != 'a' && sel != 'A' && sel != 'b' && sel != 'B' && sel != 'c' && sel != 'C' && sel != 'e' && sel != 'E') // exception thrower
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
		playerBehav (character, enemy, inv);
	}
	else if (sel == 'b' || sel == 'B')
	{
		magicAttack (character, enemy, inv);
	}
	else
		inv->inventoryMenu (character);
	}
}

void challenges :: npcDmg (saveLoad *character, charSheet *enemy, int wep)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // set color to bright red
	SetConsoleTextAttribute(hConsole, 12);
	dmg = 0;
	dmg = (rand() + time (0)) % wep + 1;
	cout << endl <<  endl << "Your enemy lands a mighty blow!" << endl << endl;
	cout << "You Take " << dmg << " damage! " << endl;
	character->HP = character->HP - dmg;
	cout << " Your HP: " << setw(5) << character->HP;
	playerDeathC (character);
}

void challenges :: npcAttack (saveLoad *character, charSheet *enemy, int wep, string type)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // set color to bright red
	SetConsoleTextAttribute(hConsole, 12);
	int roll = 0;
	int mod = 0;
	if (type == "a Wolf")
		mod = 6;
	if (type == "a Soldier")
		mod = 3;
	if (type == "an Orc")
		mod = 2;
	if (type == "Great Red Dragon")
		mod = 10;

	roll = (rand() + time (0)) % 20 + 1 + mod;
	if (roll >= character->AC)
		npcDmg (character, enemy, wep);
	else
		cout << endl << "Your enemy swings wildly, missing you completely! " << endl << endl;
}

void challenges :: combat (saveLoad *character, charSheet *enemy, int wep, string type, inventory *inv)
{
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // set color to bright red
	SetConsoleTextAttribute(hConsole, 12);
	string fail = "You may only enter Y or N!" ;
	flee = false;
	cout <<  endl << "You have been attacked by " << type << "!" << endl;
	while (enemy->HP > 0)
	{
		SetConsoleTextAttribute(hConsole, 12);
		
		cout << endl << "Would you like to attempt to flee? Y or N." << endl << endl;
		try
		{
		SetConsoleTextAttribute(hConsole, 15);// bright white
		cin >> sel;
		SetConsoleTextAttribute(hConsole, 12);// red

		if (sel != 'y' && sel != 'Y' && sel != 'n' && sel != 'N') // exception thrower
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
		if (sel == 'y' || sel == 'Y')
		{
			int y = 0;
			y = (rand() + time (0)) % wep + 1;
			if (y >= 17)
			{
				cout << endl << "You succeed in fleeing form your attacker!" << endl << endl;
				break;
			}
			else
			{
				cout << endl << "You fail to flee!" << endl << endl;
				cout << "You have invoked an attack of opportunity!" << endl;
				npcAttack (character, enemy, wep, type);
			}
		}
		else
		{
		playerAttackM (character, enemy, inv);
			if (enemy->HP > 0)
			{
			npcAttack (character, enemy, wep, type);
			}
		}
	}
	if (stoneAm == true)
	{
		stoneAm = false;
		character->HP = character->HP - stone;
	}
}