#Telerik Akademy Homework C#

##Homework C# Part One

####Introduction-to-PFamiliarize yourself with:
1. Create, compile and run a “Hello C#” console application.
2. Modify the application to print your name.
3. Write a program to print the numbers 1, 101 and 1001.
4. Create console application that prints your first and last name.
5. Create a console application that prints the current date and time.
6. Create a console application that calculates and prints the square of the number 12345.
7. Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
8. Provide a short list with information about the most popular programming languages. How do they differ from C#?
9. Describe the difference between C# and .NET Framework.
10. Write a program to read your age from the console and print how old you will be after 10 years.
 
####Primitive-Data-Types-and-Variables:
1. Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
2. Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
3. Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:
(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003) -> true
4. Declare an integer variable and assign it with the value 254 in hexadecimal format. Use Windows Calculator to find its hexadecimal representation.
5. Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
6. Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.
7. Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
8. Declare two string variables and assign them with following value...
9. Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.
10. A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.
11. Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
12. Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.
13. Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.
14. A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

####Operators-Expressions-and-Statements
1. Write an expression that checks if given integer is odd or even.
2. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
3. Write an expression that calculates rectangle’s area by given width and height.
4. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.
5. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
6. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
7. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
8. Write an expression that calculates trapezoid's area by given sides a and b and height h.
9. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
10. Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1 -> false.
11. Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.
12. We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
	n = 5 (00000101), p=2, v=0 -> 1 (00000001)
13. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
14. *Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

####Console-Input-Output
1. Write a program that reads 3 integer numbers from the console and prints their sum.
2. Write a program that reads the radius r of a circle and prints its perimeter and area.
3. A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.
4. Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
5. Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
6. Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
7. Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
8. Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
9. Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
10. Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
11. ** Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys). A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.

####Conditional-Statements
1. Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
2. Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.
3. Write a program that finds the biggest of three integers using nested if statements.
4. Sort 3 real values in descending order using nested if statements.
5. Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.
6. Write a program that enters the coefficients a, b and c of a quadratic equation
		a*x2 + b*x + c = 0
		and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
7. Write a program that finds the greatest of given 5 variables.
8. Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.
9. We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.
10. Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error.
		Use a switch statement and at the end print the calculated new value in the console.
11. *Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	0  "Zero"
	273  "Two hundred seventy three"
	400  "Four hundred"
	501  "Five hundred and one"
	711  "Seven hundred and eleven"

####Loops
