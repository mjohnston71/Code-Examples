#include <stdio.h>
#include <iostream>
#include <cstdlib>
#include <sstream>
#define _USE_MATH_DEFINES // required for pi
#include <math.h>	      // required for pi
using namespace std;

//gets user input after outputting a prompt to the console window
string getInput(string prompt) 
{
	string input;
	cout << prompt;
	getline(cin, input);
	return input;
}

double circleArea(double radius) 
{
	return M_PI*radius*radius; // pi * r^2
}

double sphereArea(double radius)
{
	return 4 * M_PI*radius*radius; // 4*pi*r^2
}

int main(int argc, char * argv[])
{
	//used to store the user input
	string input = "";

	//gives a nice message in the console
	cout << "This program calculates the area of a circle and the surface area of a sphere given a radius.\nType \"x\" to close the program.";

	//loops the program until close condition ("x" is entered) is met
	while (input != "x") 
	{
		input = getInput("\n\nEnter radius: ");
		try
		{
			double numericalInput = stod(input); // not the cleanest conversion or test given its allowance of garbage inputs such as 32.32.32.32 or 32.xxxx, but allows for good usability
			//outputs results
			cout << "A circle with a radius of " << numericalInput << " will have an area of " << circleArea(numericalInput) << endl;
			cout << "A sphere with the same radius will have a surface area of "<< sphereArea(numericalInput);
		}
		catch (exception NotAValidRadius) //will catch on anything not starting with a number, as the string "input" will fail the conversion done by stod
		{
			cout << "Not a valid radius.";
		}
	}
}