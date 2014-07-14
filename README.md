#Telerik Akademy Homework C#

##Homework C# Part One

####Introduction-to-Programming
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
 
####Primitive-Data-Types-and-Variables
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
1. Write a program that prints all the numbers from 1 to N.
2. Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
3. Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
4. Write a program that calculates N!/K! for given N and K (1<K<N).
5. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
6. Write a program that, for a given two integer numbers N and X, calculates the sum
S = 1 + 1!/X + 2!/X2 + … + N!/XN
7. Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
8. Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).
9. In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
10. Write a program to calculate the Nth Catalan number by given N.
11. Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.
12. Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix.
13. *Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	N = 10  N! = 3628800  2
	N = 20  N! = 2432902008176640000  4
	Does your program work for N = 50 000?
	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!
14. *Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.

##Homework C# Part Two

####Arrays
1. Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.
2. Write a program that reads two arrays from the console and compares them element by element.
3. Write a program that compares two char arrays lexicographically (letter by letter).
4. Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
5. Write a program that finds the maximal increasing sequence in an array. Example: 
{3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
6. Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.
7. Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
8. Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?
9. Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
10. Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	
11. Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
12. Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.
13. *Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
14. Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
15. Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
16. *We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)
17. *Write a program that reads three integer numbers N, K and S and an array of N elements from the console. Find in the array a subset of K elements that have sum S or indicate about its absence.
18. *Write a program that reads an array of integers and removes from it a minimal number of elements in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
19. *Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
20. Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
21. Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

####Multidimensional-Arrays
1. Write a program that fills and prints a matrix of size (n, n).
2. Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
3. We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.
4. Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
5. You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
6. *Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().
7. * Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. 

####Methods
1. Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.
2. Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
3. Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".
4. Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.
5. Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
6. Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
Use the method from the previous exercise.
7. Write a method that reverses the digits of given decimal number. Example: 256  652
8. Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
9. Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.
10. Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
11. Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		x2 + 5 = 1x2 + 0x + 5 
12. Extend the program to support also subtraction and multiplication of polynomials.
13. Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
14. Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.
15. *Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).

####Numeral-Systems
1. Write a program to convert decimal numbers to their binary representation.
2. Write a program to convert binary numbers to their decimal representation.
3. Write a program to convert decimal numbers to their hexadecimal representation.
4. Write a program to convert hexadecimal numbers to their decimal representation.
5. Write a program to convert hexadecimal numbers to binary numbers (directly).
6. Write a program to convert binary numbers to hexadecimal numbers (directly).
7. Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
8. Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
9. *Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float). Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

####Using-Classes-and-Objects
1. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
2. Write a program that generates and prints to the console 10 random values in the range [100, 200].
3. Write a program that prints to the console which day of the week is today. Use System.DateTime.
4. Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
5. Write a method that calculates the number of workdays between today and given date, passed as parameter. Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
6. You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:
		string = "43 68 9 23 318"  result = 461
7. *Write a program that calculates the value of given arithmetical expression. The expression can contain the following elements only:
Real numbers, e.g. 5, 18.33, 3.14159, 12.6
Arithmetic operators: +, -, *, / (standard priorities)
Mathematical functions: ln(x), sqrt(x), pow(x,y)
Brackets (for changing the default priorities)
	Examples:
	(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)  ~ 10.6
	pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)  ~ 21.22
	Hint: Use the classical "shunting yard" algorithm and "reverse Polish notation".

####Exception-Handling
1. Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.
2. Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100
3. Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.
4. Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

####Text-Files
1. Write a program that reads a text file and prints on the console its odd lines.
2. Write a program that concatenates two text files into another text file.
3. Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.
4. Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.\
5. Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. Example:
4
2 3 3 4
0 2 3 4 -> 17
3 7 1 2
4 3 3 2
6. Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
	Ivan			George
	Peter			Ivan
	Maria	     ->		Maria
	George	 		Peter
7. Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).
8. Modify the solution of the previous problem to replace only whole words (not substrings).
9. Write a program that deletes from given text file all odd lines. The result should be in the same file.
10. Write a program that extracts from given XML file all the text without the tags.
11. Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.
12. Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.
13. Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt. The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order. Handle all possible exceptions in your methods.

####Strings-and-Text-Processing
1. Describe the strings in C#. What is typical for the string data type? Describe the most important methods of the String class.
2. Write a program that reads a string, reverses it and prints the result at the console.
Example: "sample"  "elpmas".
4. Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).
5. Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
		Example: The target substring is "in".
6. You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested.
7. Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.
8. Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
9. Write a program that extracts from a given text all sentences containing given word.
		Example: The word is "in".
		Consider that the sentences are separated by "." and the words – by non-letter symbols.
10. We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks.
11. Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.
12. Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.
13. Write a program that parses an URL address given in the format.
14. Write a program that reverses the words in given sentence.
	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
15. A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word and translates it by using the dictionary.
16. Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment.
17. Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
18. Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
19. Write a program for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
20. Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.
21. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
22. Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 
23. Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
24. Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
25. Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
16. Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

##Homework C# OOP

####Defining-Classes-Part-I-Constructors-Properties
1. Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
2. Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it). Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
3. Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
4. Add a method in the GSM class for displaying all information about it. Try to override ToString().
5. Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. Ensure all fields hold correct data at any given time.
6. Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
7. Write a class GSMTest to test the GSM class:
Create an array of few instances of the GSM class.
Display the information about the GSMs in the array.
Display the information about the static property IPhone4S.
8. Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).
9. Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.
10. Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
11. Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.
12. Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
Create an instance of the GSM class.
Add few calls.
Display the information about the calls.
Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
Remove the longest call from the history 
and calculate the total price again.
Finally clear the call history and print it.

####Defining-Classes-Part-II-Static-Members-Generics
1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.
2. Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.
3. Write a static class with a static method to calculate the distance between two points in the 3D space.
4. Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.
5. Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.
6. Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
7. Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. You may need to add a generic constraints for the type T.
8. Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
9. Implement an indexer this[row, col] to access the inner matrix cells.
10. Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).
11. Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11). Apply the version attribute to a sample class and display its version at runtime.

####Extension-Methods-Delegates-Lambda-LINQ
1. Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
2. Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
3. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.
4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
5. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.
6. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
7. Using delegates write a class Timer that has can execute certain method at each t seconds.
8. *Read in MSDN about the keyword event in C# and how to publish events. Re-implement the above using .NET events and following the best practices.

####Object-Oriented-Programming-Principles-Part-I
1. We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
	Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
2. Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour in descending order. Merge the lists and sort them by first name and last name.
3. Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

####Object-Oriented-Programming-Principles-Part-II
1. Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method. Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.
2. A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
	All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
3. Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

####Common-Type-System
1. Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
2. Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
3. Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
4. Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so. Write a program to test this functionality.
5. Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
6. *Define the data structure binary search tree with operations for "adding new element", "searching element" and "deleting elements". It is not necessary to keep the tree balanced. Implement the standard methods from System.Object – ToString(), Equals(…), GetHashCode() and the operators for comparison  == and !=. Add and implement the ICloneable interface for deep copy of the tree. Remark: Use two types – structure BinarySearchTree (for the tree) and class TreeNode (for the tree elements). Implement IEnumerable<T> to traverse the tree.
