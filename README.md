# CodeYou-Mar24

This repo contains examples, class discusssions, etc. for the Code:You Mar24 Software Deelopment session.


Some notes from week 2 videos:
Readiblity
Readable v/s understandable - 

float a(float y, float h) {
sq = y * y; xsq = h * h*
return Math.Sqrt(xsq + 2 * sq - sq)
}

float calculateHypotenuse(float lengthA, float lengthB) {
return Math.Sqrt( (a * a) + (b * b) )
}


the ternary operator: use it! but only when it makes code clearer/eaiser to read
ternary assignments are awesome

nested if stmts are less than ideal for understandabilty, but often necessary. However, if more
than 2 levels deep, consider if breaking code out into other methods would help readability.

case is awesome, and with pattern matching can often make complex and nested if chanins much more readable. 
give an example of pattern matching case with wildcard


Avoid using xor (^) or at least leave a comment stating what it is. the '^' character is used for 
so many different thigns in so many different languages that it will likely lead to confusion.


I use foreach 80% of the time and while loops 15% of the time, pretty evenly split betwen while/do while.
for loops are rare, and generally only useful if processing two related orderd collections. Worse they are prone
to off by one errors.

However, I do make big use of LINQ (we'll cover that later) so YMMV

Generally speaking, if a collection you are using has a .length or .count, it will most liley
work with foreach. Intelisense will tell you if it won't

=> maybe type up some examples of different control flow and talk about readiblity

1) I rarely use arrays. 
1	
1. In practice Lists<> are the most common collection. With dictionaries and has setst tieing for distant second. Honestly, 
1. I only use arrays if I'm forced to by a library.
1.  . Most of the time you don't know how many elements you'll need and Resizing an Array means copying it into a new array, 
		1. and while C# makes this fairly easy, it's still a pain.
1	. Lists grow dynamically. No need to worry about resizing them, just call .Add. 
1	. But you CAN not (should not) delete from or add to a list while looping through it. 
1. 
1. Teh ^1 syntax is new to me. Not sure if I like it yet or not, but it does seem less wordy than blah.lengh-1
1. 