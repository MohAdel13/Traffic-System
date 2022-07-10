#include<iostream>
#include<string>
using namespace std;
int Choice = 0;

//Structs........
struct Date
{
	int Day = 0;
	int Month = 0;
	int Year = 0;
};
struct Fine
{
	string Street_name = "Not Set";
	float Value = 0;
	Date Fine_Date;
	string Status = "Not Set";
	bool imposed = false;
};
struct Car
{
	string Model = "Not Set";
	string Plate_number = "Not set";
	int Production_Year = 0;
	Fine Car_Fines[10];
	bool Owned = {};
};
struct Driver
{
	int Driver_License = 0;
	string Driver_name = "Not Set";
	Date Driver_BirthDate;
	Car Owned_cars[3];
};

//Functions Declaration.......
int MainMenu();
int DriverMenu();
int OfficerMenu();
void Driver_Data(Driver D[]);
void Car_Data(Driver D[]);
int Search_Menu();
void Fine_Putting(Driver D[]);
void Fine_Payment(Driver D[]);

//Main..........
int main()
{
	char condition = 'Y';
	int Main_Choice, Driver_Choice, Officer_Choice, Search_Choice;
	bool fine[10] = {};
	Driver examp[100];

	examp[2].Driver_name = "Ahmed";
	examp[2].Driver_License = 23457;
	examp[2].Driver_BirthDate.Day = 13;
	examp[2].Driver_BirthDate.Month = 11;
	examp[2].Driver_BirthDate.Year = 2000;
	examp[2].Owned_cars[0].Model = "Hyundai";
	examp[2].Owned_cars[0].Plate_number = "NOL568";
	examp[2].Owned_cars[0].Production_Year = 2018;
	examp[2].Owned_cars[0].Car_Fines[0].Value = 200;
	examp[2].Owned_cars[0].Car_Fines[0].imposed = true;
	examp[2].Owned_cars[0].Car_Fines[0].Fine_Date.Day = 12;
	examp[2].Owned_cars[0].Car_Fines[0].Fine_Date.Month = 5;
	examp[2].Owned_cars[0].Car_Fines[0].Fine_Date.Year = 2020;
	examp[2].Owned_cars[0].Car_Fines[0].Status = "Not paid!...";
	examp[2].Owned_cars[0].Car_Fines[0].Street_name = "El-Rehab City";
	examp[2].Owned_cars[0].Owned = true;

	examp[6].Driver_name = "Younis";
	examp[6].Driver_License = 57894;
	examp[6].Driver_BirthDate.Day = 17;
	examp[6].Driver_BirthDate.Month = 9;
	examp[6].Driver_BirthDate.Year = 1998;
	examp[6].Owned_cars[0].Model = "Kia";
	examp[6].Owned_cars[0].Plate_number = "SIR123";
	examp[6].Owned_cars[0].Production_Year = 2016;
	examp[6].Owned_cars[0].Owned = true;
	examp[6].Owned_cars[0].Car_Fines[0].Value = 500;
	examp[6].Owned_cars[0].Car_Fines[0].imposed = true;
	examp[6].Owned_cars[0].Car_Fines[0].Fine_Date.Day = 16;
	examp[6].Owned_cars[0].Car_Fines[0].Fine_Date.Month = 5;
	examp[6].Owned_cars[0].Car_Fines[0].Fine_Date.Year = 2020;
	examp[6].Owned_cars[0].Car_Fines[0].Status = "Not paid!...";
	examp[6].Owned_cars[0].Car_Fines[0].Street_name = "Madinat Nasr";
	examp[6].Owned_cars[2].Model = "Nissan";
	examp[6].Owned_cars[2].Plate_number = "DOC456";
	examp[6].Owned_cars[2].Production_Year = 2020;
	examp[6].Owned_cars[2].Owned = true;


	while (condition == 'Y' || condition == 'y')
	{
		Main_Choice = MainMenu();
		if (Main_Choice == 1)
		{
			Driver_Choice = DriverMenu();
			if (Driver_Choice == 1)
			{
				Search_Choice = Search_Menu();
				if (Search_Choice == 1)
				{
					Driver_Data(examp);
				}
				else if (Search_Choice == 2)
				{
					Car_Data(examp);
				}
			}
			else if (Driver_Choice == 2)
			{
				Fine_Payment(examp);
			}
		}
		else if (Main_Choice == 2)
		{
			Officer_Choice = OfficerMenu();
			if (Officer_Choice == 1)
			{
				Search_Choice = Search_Menu();
				if (Search_Choice == 1)
				{
					Driver_Data(examp);
				}
				else if (Search_Choice == 2)
				{
					Car_Data(examp);
				}
				else
				{
					cout << "Wrong Choice number!...........\n";
				}
			}
			else if (Officer_Choice == 2)
			{
				Fine_Putting(examp);
			}
			else
			{
				cout << "Wrong Choice number!...........\n";
			}
		}
		else
		{
			cout << "Wrong Choice number!...........\n";
		}
		cout << "Do You Want Another Function ? \t \"press Y To Continue Or Any Other Key To Exit\"\n----------\n";
		cin >> condition;
		cout << "---------------\n";
	}
	return 0;
}

//Functions Definitions........
int MainMenu()
{
	Choice = 0;
	while (Choice != 1 && Choice != 2)
	{
		cout << "Which Functions Do You Want ?\n----------\n";
		cout << "1- Driver's Functions \n";
		cout << "2- Officer's Functions \n---------------\n";
		cin >> Choice;
		cout << "---------------\n";
		if (Choice == 1 || Choice == 2)
		{
			break;
		}
		cout << "Wrong Choice number!...........\n";
		cout << "---------------\n";
	}
	return Choice;
}
int DriverMenu()
{
	Choice = 0;
	while (Choice != 1 && Choice != 2)
	{
		cout << "What Do You Want To DO ?\n----------\n";
		cout << "1- Check For Car Fines \n";
		cout << "2- Pay A Fine \n---------------\n";
		cin >> Choice;
		cout << "---------------\n";
		if (Choice == 1 || Choice == 2)
		{
			break;
		}
		cout << "Wrong Choice number!...........\n";
		cout << "---------------\n";
	}
	return Choice;
}
int OfficerMenu()
{
	Choice = 0;
	while (Choice != 1 && Choice != 2)
	{
		cout << "What Do You Want To DO ?\n----------\n";
		cout << "1- Check For Data \n";
		cout << "2- Put A Fine \n";
		cout << "---------------\n";
		cin >> Choice;
		cout << "---------------\n";
		if (Choice == 1 || Choice == 2)
		{
			break;
		}
		cout << "Wrong Choice number!...........\n";
		cout << "---------------\n";
	}
	return Choice;
}
void Driver_Data(Driver D[])
{
	bool Repeat = true;
	string Driver_Name;
	while (Repeat == true)
	{
		cout << "Enter The OWner Name :\n----------\n";
		cin >> Driver_Name;
		cout << "---------------\n";
		for (int i = 0; i < 100; i++)
		{
			if (D[i].Driver_name == Driver_Name)
			{
				Repeat = false;
				cout << "Name :\t" << D[i].Driver_name << "\n\n";
				cout << "Birth Date :\t" << D[i].Driver_BirthDate.Day <<
					" / " << D[i].Driver_BirthDate.Month << " / " <<
					D[i].Driver_BirthDate.Year << "\n\n";
				cout << "License Number :\t" << D[i].Driver_License << "\n\n";
				for (int j = 0; j<3; j++)
				{
					if (D[i].Owned_cars[j].Owned == true)
					{
						cout << "********************\n";
						cout << "Car" << j + 1 << " Data :\n\n";
						cout << "Model :\t" << D[i].Owned_cars[j].Model << "\n";
						cout << "Plate Number :\t" << D[i].Owned_cars[j].Plate_number << "\n";
						cout << "Production Year :\t" << D[i].Owned_cars[j].Production_Year << "\n\n";
						int order = 1;
						cout << "Car Fines:-\n----------\n";
						bool found = false;
						for (int l = 0; l < 10; l++)
						{
							if (D[i].Owned_cars[j].Car_Fines[l].imposed == true)
							{
								cout << "Fine" << order << ":";
								cout << "\tValue :\t\t\t" << D[i].Owned_cars[j].Car_Fines[l].Value << "\n";
								cout << "\tFine Date :\t\t" << D[i].Owned_cars[j].Car_Fines[l].Fine_Date.Day << " / " <<
									D[i].Owned_cars[j].Car_Fines[l].Fine_Date.Month << " / " <<
									D[i].Owned_cars[j].Car_Fines[l].Fine_Date.Year << endl;
								cout << "\tName of street :\t" << D[i].Owned_cars[j].Car_Fines[l].Street_name << "\n";
								cout << "\tStatus :\t\t" << D[i].Owned_cars[j].Car_Fines[l].Status << "\n-----\n";
								found = true;
								order++;
							}
						}
						if (found == false)
							cout << "No Fines For This Car!.....\n---------------\n";
					}
				}
			}
		}
		if (Repeat == false)
			break;
		cout << "Name Not Found!...........\n---------------\n";
	}
}
void Car_Data(Driver D[])
{
	bool Repeat = true;
	while (Repeat == true)
	{
		string plate_number;
		cout << "Enter The Car's Plate Number: \n----------\n";
		cin >> plate_number;
		cout << "---------------\n";
		for (int i = 0; i < 100; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				if (D[i].Owned_cars[j].Plate_number == plate_number)
				{
					Repeat = false;
					cout << "Name Of Owner:\t" << D[i].Driver_name << "\n\n";
					cout << "BirthDate Of Owner:\t" << D[i].Driver_BirthDate.Day << " / " <<
						D[i].Driver_BirthDate.Month << " / " <<
						D[i].Driver_BirthDate.Year << "\n\n";
					cout << "Owner License Number:\t" << D[i].Driver_License << "\n\n";
					cout << "Car's Model:\t" << D[i].Owned_cars[j].Model << "\n\n";
					cout << "Car's Plate Number:\t" << D[i].Owned_cars[j].Plate_number << "\n\n";
					cout << "Car's Production Year:\t" << D[i].Owned_cars[j].Production_Year << "\n\n";
					bool found = false;
					int order = 1;
					cout << "Car Fines:-\n----------\n";
					for (int l = 0; l < 10; l++)
					{
						if (D[i].Owned_cars[j].Car_Fines[l].imposed == true)
						{
							cout << "Fine" << order << ":\n";
							cout << "\tStreet name:\t" << D[i].Owned_cars[j].Car_Fines[l].Street_name << "\n";
							cout << "\tFine's Value:\t" << D[i].Owned_cars[j].Car_Fines[l].Value << "\n";
							cout << "\tFine's Date:\t" << D[i].Owned_cars[j].Car_Fines[l].Fine_Date.Day << "/" <<
								D[i].Owned_cars[j].Car_Fines[l].Fine_Date.Month << "/" <<
								D[i].Owned_cars[j].Car_Fines[l].Fine_Date.Year << "\n";
							cout << "\tFine's Status:\t" << D[i].Owned_cars[j].Car_Fines[l].Status << "\n-----\n";
							found = true;
							order++;
						}
					}
					if (found == false)
						cout << "No Fines For This Car!.....\n---------------\n";
				}
			}
		}
		cout << "\n---------------\n";
		if (Repeat == false)
			break;
		cout << "Car Not Found!.........\n---------------\n";
	}
}
int Search_Menu()
{
	Choice = 0;
	while (Choice != 1 && Choice != 2)
	{
		cout << "Search by:\n";
		cout << "----------\n";
		cout << "1- Name\n";
		cout << "2- Plate Number\n";
		cout << "---------------\n";
		cin >> Choice;
		cout << "---------------\n";
		if (Choice == 1 || Choice == 2)
		{
			break;
		}
		cout << "Wrong Choice number!...........\n";
		cout << "---------------\n";
	}
	return Choice;
}
void Fine_Putting(Driver D[])
{
	bool Repeat = true;
	float StreetSpeed, CarSpeed;
	string PlateNumber, Name;
	cout << "What's The Street Maximum Speed In Km:\t"; cin >> StreetSpeed;
	cout << "What's The Car's Speed In Km:\t"; cin >> CarSpeed;
	cout << "---------------\n";
	if (CarSpeed>StreetSpeed)
	{
		while (Repeat == true)
		{
			cout << "Enter The Car's Plate Number:\n----------\n";
			cin >> PlateNumber; cout << "---------------\n";
			for (int i = 0; i < 100; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (D[i].Owned_cars[j].Plate_number == PlateNumber)
					{
						Repeat = false;
						cout << "Enter The Fine's Data:\n----------\n";
						for (int k = 0; k < 10; k++)
						{
							if (D[i].Owned_cars[j].Car_Fines[k].imposed == false)
							{
								cout << "Street Name:\t"; cin >> D[i].Owned_cars[j].Car_Fines[k].Street_name;
								cout << "Date:-\n";
								cout << "Day:\t"; cin >> D[i].Owned_cars[j].Car_Fines[k].Fine_Date.Day;
								cout << "Month:\t"; cin >> D[i].Owned_cars[j].Car_Fines[k].Fine_Date.Month;
								cout << "Year:\t"; cin >> D[i].Owned_cars[j].Car_Fines[k].Fine_Date.Year;
								cout << "\n Done.....\n---------------\n";
								D[i].Owned_cars[j].Car_Fines[k].imposed = true;
								D[i].Owned_cars[j].Car_Fines[k].Status = "Not Paid!...";
								D[i].Owned_cars[j].Car_Fines[k].Value = (CarSpeed - StreetSpeed) * 2;
								break;
							}
						}
					}
				}
			}
			if (Repeat == false)
				break;
			cout << "Car Not Found!.........\n---------------\n";
		}
	}
	else
	{
		cout << "Car speed is normal!........\n---------------\n";
	}
}
void Fine_Payment(Driver D[])
{
	bool Repeat = true;
	string plate_number;
	while (Repeat == true)
	{
		Choice = -1;
		bool found = false, viewed = false;
		cout << "Enter The Car's Plate Number: \n----------\n";
		cin >> plate_number;
		cout << "---------------\n";
		for (int i = 0; i < 100; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				if (D[i].Owned_cars[j].Plate_number == plate_number)
				{
					Repeat = false;
					int num[10];
					while (found == false)
					{
						int order = 1;
						for (int l = 0; l < 10; l++)
						{
							if (D[i].Owned_cars[j].Car_Fines[l].imposed == true && D[i].Owned_cars[j].Car_Fines[l].Status != "Paid.....")
							{
								if (viewed == false)
								{
									cout << "Which One Would You Like To Pay ?\n----------\n";
									viewed = true;
								}
								num[l] = order;
								cout << num[l] << "- " << D[i].Owned_cars[j].Car_Fines[l].Value << "\n";
								cout << "\n---------------\n";
								order++;
							}
						}
						if (viewed == true)
						{
							cin >> Choice;
							cout << "---------------\n";
						}
						else
						{
							cout << "No Fines TO Be Payed \n---------------\n";
							break;
						}
						for (int l = 0; l < 10; l++)
						{
							if (num[l] == Choice)
							{
								found = true;
							}
						}
						if (found == true)
						{
							break;
						}
						else
							cout << "Wrong Choice Number!.........\n---------------\n";
					}
					for (int l = 0; l < 10; l++)
					{
						if (num[l] == Choice&&viewed == true)
						{
							D[i].Owned_cars[j].Car_Fines[l].Status = "Paid.....";
							cout << "Done.....";
						}
					}
				}
			}
		}
		cout << "\n---------------\n";
		if (Repeat == false)
			break;
		cout << "Car Not Found!.........\n---------------\n";
	}
}
