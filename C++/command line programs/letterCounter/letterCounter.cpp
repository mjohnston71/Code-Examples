// This program counts letters in a given file
#include <stdio.h>
#include <iostream>
#include <fstream>
#include <cstdlib>
#include <sstream>
#include <algorithm>
using namespace std;

//gets user input after outputting a prompt to the console window
string getInput(string prompt) 
{
	string input;
	cout << prompt;
	getline(cin, input);
	return input;
}

void countLetters(string inputString)
{
	for each (char character in inputString)
	{
		cout << character<<endl;
	}
}
int main(int argc, char * argv[])
{
	//used to store the user input
	string input = "";

	//used to store file stream
	ifstream inFile;

	//used to store the current line of the file
	string fileLine;

	//will hold the whole file's worth of characters
	string wholeFile = "";

	//used as a flag for if the file is usable or not
	bool validFile = false;

	//current character being counted
	char currentChar=' ';


	//used to store individual letter counts
	int currentLetterCount = 0;

	//used to store overall count
	int letterCount = 0;

	//prompt used for filename gathering - made into a variable because it's in multiple locations
	string filePrompt = "\n\nEnter the name of the file to use: ";

	//gives a nice message in the console
	cout << "This program displays the count of each letter as well as the total number of letters A-Z found in a file.\nType \"x\" to close the program.";

	input = getInput(filePrompt);
	//loops the program until close condition ("x" is entered) is met
	while (input != "x") 
	{
		//clears containers (From last loop)
		fileLine = ""; wholeFile = "";
		currentLetterCount = 0; letterCount = 0;

		// .c_str() is a required conversion
		inFile.open(input.c_str());

		// reads the whole file into wholeFile
		while (!inFile.eof())
		{
			getline(inFile, fileLine);
			wholeFile += fileLine;
		}

		
		//makes it all uppercase
		transform(wholeFile.begin(), wholeFile.end(), wholeFile.begin(), ::toupper);
		//sorts the file 
		sort(wholeFile.begin(), wholeFile.end());


		for each (char letter in wholeFile)
		{
			if (letter <= 'Z'&&letter >= 'A') 
			{
				//should trigger only on first loop - sets a starting letter for the count
				if (currentChar == ' ') { currentChar = letter; }

				//detects a change in letters, outputs the total count of the current letter before moving on
				if (currentChar != letter) 
				{
					cout << currentChar << ": " << currentLetterCount<<endl;
					currentLetterCount = 0;
					currentChar = letter;
				}
				currentLetterCount++;
				letterCount++;
			}
		}
		//ran again to get the last readout
		cout << currentChar << ": " << currentLetterCount<<endl;

		//gives total count of A-Z letters
		cout << "Total: " << letterCount;
		

		//closes input file
		inFile.close();
		//get the prompt for the next loop through the main body
		input = getInput(filePrompt);
	}
}
