using Generics;

//finding of maximum integers numbers
//FindMaximumIntegersNumbers.MaximumIntegerNumbers(10, 20, 30);

//finding of maximum float numbers
//FindMaximumFloatNumbers.MaximumFloatNumbers(1.1,1.2,1.3);

//finding of maximum string numbers
//FindMaximumStringNumbers.MaximumString("Apple","Peach","Banana");

//finding of maximum values using Generics
//Refactor1.MaximumString(1.1,2.2,3.3);

//using GenericClassMaximum
//Generic<double>.MaximumString(1.2,2.1,3.1);

//using T maxMethod
//GenericMaximum<string>.MaximumString("Apple", "PineApple", "WaterMelon");


//Printing of MaxValue In array
int[] arr = { 1, 2, 3, 4, 5, };
GenericMax<int> generic = new GenericMax<int>(arr);
generic.PrintMaxValue();
