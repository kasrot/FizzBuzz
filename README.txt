******************************
Please read the following
*****************************
The files attached contains:
1. A Console Application project Files
2. EXE file inside /bin folder
3. A sample Unit Test project files

There are many approaches to implement the solution you've asked me to implement.I am going to discuss one other approach
as well. 

####################
Pseudocode of the other approach
####################

if(input%(5*3)==0) PRINT "FizzBuzz"
else If(input%(3)==0) PRINT "Fizz"
else If(input%(5)==0) PRINT "Buzz"
else PRINT the input

***Advantage of this approach ***
If you run a for loop using random number 100 million times, you may get more efficient running program

####################
Why I didn't choose this approach 
####################

THIS APPROACH VS MY APPROACH ANALYSIS
**THIS APPROACH**
When user enters an input from the console or from any client,  it may compute the modulo three times
BEST CASE: User enters FizzBuzz values such as 15, 30,45...
WORST CASE: User enters Buzz values such as 5,10,20,25,35...

**MY APPROACH**
MY approach has a constant number of computations(Which is 2). 
For this console app, I'd say my approach is a good approach.


P.S.
Bitwise modulo can improve performance ,but we don't require it for this specific requirement.
In normal situations, C# developers are not going to be coding in bitwise unless a program requires it.


THANK YOU FOR YOUR CONSIDERATION !!!

