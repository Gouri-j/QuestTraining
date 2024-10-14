﻿//ARRAY                          

1.Length
Gets the number of elements in the array.
int[] numbers = { 1, 2, 3, 4, 5 };
int length = numbers.Length;
Console.WriteLine(length); // Output: 5

2.Rank
Gets the number of dimensions in the array.
int[,] numbers = { { 1, 2 }, { 3, 4 } };
int rank = numbers.Rank;
Console.WriteLine(rank); // Output: 2

3.GetLength(int dimension)
Gets the number of elements in the specified dimension.
int[,] numbers = { { 1, 2 }, { 3, 4 } };
int length = numbers.GetLength(0);
Console.WriteLine(length); // Output: 2

4.GetLowerBound(int dimension)
Gets the lower bound of the specified dimension.
int[,] numbers = { { 1, 2 }, { 3, 4 } };
int lowerBound = numbers.GetLowerBound(0);
Console.WriteLine(lowerBound); // Output: 0

5.GetUpperBound(int dimension)
Gets the upper bound of the specified dimension.
int[,] numbers = { { 1, 2 }, { 3, 4 } };
int upperBound = numbers.GetUpperBound(0);
Console.WriteLine(upperBound); // Output: 1

6.GetValue(int index)
Gets the value at the specified position in the array.
int[] numbers = { 1, 2, 3, 4, 5 };
int value = (int)numbers.GetValue(0);
Console.WriteLine(value); // Output: 1

7.SetValue(object value, int index)
Sets the value at the specified position in the array.
int[] numbers = { 1, 2, 3, 4, 5 };
numbers.SetValue(10, 0);
Console.WriteLine(numbers[0]); // Output: 10

8.BinarySearch(Array array, object value)
Searches for the specified object and returns the zero-based index of the first occurrence within the entire array.
int[] numbers = { 1, 2, 3, 4, 5 };
int index = Array.BinarySearch(numbers, 3);
Console.WriteLine(index); // Output: 2

9.Clear(Array array, int index, int length)
Sets a range of elements in the array to zero, to null, or to a default value.
int[] numbers = { 1, 2, 3, 4, 5 };
Array.Clear(numbers, 1, 2);
Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 0, 0, 4, 5

10.Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
Copies a range of elements from an array to another array.
int[] source = { 1, 2, 3, 4, 5 };
int[] destination = new int[5];
Array.Copy(source, 1, destination, 0, 2);
Console.WriteLine(string.Join(", ", destination)); // Output: 2, 3, 0, 0, 0

11.CreateInstance(Type type, int length)
Creates a new array of the specified type and length.
int[] numbers = (int[])Array.CreateInstance(typeof(int), 5);
Console.WriteLine(numbers.Length); // Output: 5

12.IndexOf(Array array, object value)
Searches for the specified object and returns the zero-based index of the first occurrence within the entire array.
int[] numbers = { 1, 2, 3, 4, 5 };
int index = Array.IndexOf(numbers, 3);
Console.WriteLine(index); // Output: 2

13.LastIndexOf(Array array, object value)
Searches for the specified object and returns the zero-based index of the last occurrence within the entire array.
int[] numbers = { 1, 2, 3, 4, 5, 3 };
int index = Array.LastIndexOf(numbers, 3);
Console.WriteLine(index); // Output: 5

14.Resize(ref Array array, int newSize)
Resizes an array to the specified size.
int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine("Original array: " + string.Join(", ", numbers));
Array.Resize(ref numbers, 8);
Console.WriteLine("Resized array: " + string.Join(", ", numbers));

// Output:
// Original array: 1, 2, 3, 4, 5
// Resized array: 1, 2, 3, 4, 5, 0, 0, 0



// STRING

1. Length
Returns the number of characters in the string.

string str = "Hello";
Console.WriteLine(str.Length); // Output: 5


2. ToUpper()
Converts the string to uppercase.

string str = "hello";
Console.WriteLine(str.ToUpper()); // Output: HELLO


3. ToLower()
Converts the string to lowercase.

string str = "HELLO";
Console.WriteLine(str.ToLower()); // Output: hello

4. Trim()
Removes all leading and trailing whitespace characters.

string str = "  Hello World  ";
Console.WriteLine(str.Trim()); // Output: "Hello World"

5. Substring()
Extracts a substring from the string.

string str = "Hello World";
Console.WriteLine(str.Substring(6, 5)); // Output: World 

6. IndexOf()
Returns the zero-based index of the first occurrence of a specified string.

string str = "Hello World";
Console.WriteLine(str.IndexOf("World")); // Output: 6

7. LastIndexOf()
Returns the zero-based index of the last occurrence of a specified string.

string str = "Hello World, Welcome to the World";
Console.WriteLine(str.LastIndexOf("World")); // Output: 26

8. Replace()
Replaces all occurrences of a specified substring with another substring.

string str = "Hello World";
Console.WriteLine(str.Replace("World", "C#")); // Output: Hello C#

9. Split()
Splits a string into an array of substrings based on a specified delimiter.

string str = "apple,banana,orange";
string[] fruits = str.Split(',');
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit); // Output: apple banana orange
}

10. Join()
Concatenates the elements of a string array, using a specified separator between each element.

string[] fruits = { "apple", "banana", "orange" };
Console.WriteLine(string.Join(", ", fruits)); // Output: apple, banana, orange

11. StartsWith()
Determines whether the string starts with a specified substring.

string str = "Hello World";
Console.WriteLine(str.StartsWith("Hello")); // Output: True

12. EndsWith()
Determines whether the string ends with a specified substring.

string str = "Hello World";
Console.WriteLine(str.EndsWith("World")); // Output: True

13. Contains()
Determines whether the string contains a specified substring.

string str = "Hello World";
Console.WriteLine(str.Contains("World")); // Output: True

14. PadLeft()
Pads the string on the left with spaces (or a specified character) to reach a specified length.

string str = "5";
Console.WriteLine(str.PadLeft(2, '0')); // Output: 05

15. PadRight()
Pads the string on the right with spaces (or a specified character) to reach a specified length.

string str = "5";
Console.WriteLine(str.PadRight(2, '0')); // Output: 50

16. TrimStart()
Removes all leading whitespace characters from the string.

string str = "  Hello World  ";
Console.WriteLine(str.TrimStart()); // Output: "Hello World  "

17. TrimEnd()
Removes all trailing whitespace characters from the string.

string str = "  Hello World  ";
Console.WriteLine(str.TrimEnd()); // Output: "  Hello World"

18. ToCharArray()
Converts the string to a character array.

string str = "Hello";
char[] charArray = str.ToCharArray();
Console.WriteLine(charArray[0]); // Output: H


19. Insert()
Inserts a specified string at a specified index position.

string str = "Hello World";
Console.WriteLine(str.Insert(5, ", C#")); // Output: Hello, C# World


20. Remove()
Deletes a specified number of characters from the string, starting at a specified index.

string str = "Hello World";
Console.WriteLine(str.Remove(5, 6)); // Output: Hello


21. Equals()
Determines whether two specified string instances are equal.

string str1 = "Hello";
string str2 = "Hello";
Console.WriteLine(str1.Equals(str2)); // Output: True


22. Format()
Formats a string using placeholders.

string name = "John";
int age = 30;
Console.WriteLine(string.Format("My name is {0} and I am {1} years old.", name, age)); // Output: My name is John and I am 30 years old.

23. String Interpolation
A modern way to format strings in C#.

string name = "John";
int age = 30;
Console.WriteLine($"My name is {name} and I am {age} years old."); // Output: My name is John and I am 30 years old.

24. EqualsIgnoreCase()
Compares two strings and ignores case.

string str1 = "hello";
string str2 = "HELLO";
Console.WriteLine(string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase)); // Output: True


25. Compare()
Compares two strings and returns an integer that indicates their relative position in the sort order.

string str1 = "abc";
string str2 = "def";
Console.WriteLine(string.Compare(str1, str2)); // Output: Negative number (str1 is less than str2)


26. CompareTo()
Compares this instance to a specified object and returns an integer that indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified object.

string str1 = "abc";
Console.WriteLine(str1.CompareTo("def")); // Output: Negative number


27. GetHashCode()
Returns a hash code for the string.

string str = "Hello";
Console.WriteLine(str.GetHashCode());


28. ToString()
Returns the string representation of the current instance.


object obj = "Hello World";
string str = obj.ToString(); // Output: Hello World


29. Copy()
Creates a new instance of String with the same value as a specified String.

string str = "Hello";
string copy = string.Copy(str);
Console.WriteLine(copy); // Output: Hello


30. Contains()
Checks if a string contains a specific substring.

string str = "Hello World";
Console.WriteLine(str.Contains("World")); // Output: True




//LIST



using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // 1. Add() - Adds an object to the end of the list.
        List<int> numbers = new List<int>();
        numbers.Add(5);
        numbers.Add(10);
        numbers.Add(15);
        Console.WriteLine("List after Add():");
        PrintList(numbers);
        //List after adding elements:1,2,3
        // 2. AddRange() - Adds the elements of the specified collection to the end of
        the list.
List<int> moreNumbers = new List<int> { 20, 25 };
        numbers.AddRange(moreNumbers);
        Console.WriteLine("List after AddRange():");
        PrintList(numbers);
        //List after adding range:1,2,3,4,5,6
        // 3. Remove() - Removes the first occurrence of a specific object from the
        list
numbers.Remove(10); // Removes the first occurrence of 10
        Console.WriteLine("List after Remove(10):");
        PrintList(numbers);
        // List after removing 2:1,3,2,4
        // 4. RemoveAt() - Removes the element at the specified index.
        numbers.RemoveAt(2); // Removes the element at index 2
        Console.WriteLine("List after RemoveAt(2):");
        PrintList(numbers);
        // List after removing element at index 1:1,3,4
        // 5. Insert() - Inserts an element into the list at the specified index.
        numbers.Insert(1, 30); // Inserts 30 at index 1
        Console.WriteLine("List after Insert(30) at index 1:");
        PrintList(numbers);
        // List after inserting 2 at index 1:1,2,3,4
        // 6. Count - Returns the number of elements in the list
        int count = numbers.Count;
        Console.WriteLine("Number of elements in the list: " + count);
        //Number of elements in the list: 3
        // 7. Contains() - Determines whether the list contains a specific value.
        bool containsFive = numbers.Contains(5);
        Console.WriteLine("List contains 5: " + containsFive);
        //List contains 2: True
        // 8. IndexOf() - Returns the zero-based index of the first occurrence of a
        specific item in the list.
int indexOfThirty = numbers.IndexOf(30);
        Console.WriteLine("Index of 30: " + indexOfThirty);
        //Index of 2: 1
        // 9. Clear() - Removes all elements from the list
        numbers.Clear();
        Console.WriteLine("List after Clear():");
        PrintList(numbers); // Should print nothing, as the list is empty
                            //List after clearing: 0
                            // 10. Sort() - Sorts the elements in the entire list using the default
        comparer.
            numbers.AddRange(new List<int> { 3, 1, 4, 2 });
        numbers.Sort(); // Sorts the list
        Console.WriteLine("List after Sort():");
        PrintList(numbers);
        //Sorted list:1,2,3,4
    }
}



//DICTIONARY



Dictionaries
Common Functions and Methods:
Add Method
 Purpose: Adds a new key- value pair to the dictionary.
 Syntax: dictionary.Add(key, value)
 Example:
C#
Dictionary<string, int> ages = new Dictionary<string, int>();
ages.Add("Alice", 30);
ages.Add("Bob", 25);
ContainsKey Method
 Purpose: Checks if a specific key exists in the dictionary.
 Syntax: dictionary.ContainsKey(key)
 Example:
C#
Dictionary<string, int> ages = new Dictionary<string, int>();
bool contains = ages.ContainsKey("Alice"); // Contains will be true
ContainsValue Method
 Purpose: Checks if a specific value exists in the dictionary.
 Syntax: dictionary.ContainsValue(value)
 Example:
C#
Dictionary<string, int> ages = new Dictionary<string, int>();
bool contains = ages.ContainsValue(30); // Contains will be true
Remove Method
Purpose: Removes a key-value pair from the dictionary.
 Syntax: dictionary.Remove(key)
 Example:
C#
Dictionary<string, int> ages = new Dictionary<string, int>();
ages.Remove("Alice"); // Removes the key-value pair for "Alice"
Clear Method
 Purpose: Removes all key-value pairs from the dictionary.
 Syntax: dictionary.Clear()
 Example:
C#
Dictionary<string, int> ages = new Dictionary<string, int>();
ages.Clear(); // Empties the dictionary
Count Property
 Purpose: Returns the number of key-value pairs in the dictionary.
 Syntax: dictionary.Count
 Example:
C#
Dictionary<string, int> ages = new Dictionary<string, int>();
int count = ages.Count;

Keys Property
 Purpose: Returns a collection of keys in the dictionary.
 Syntax: dictionary.Keys
 Example:
C#
Dictionary<string, int> ages = new Dictionary<string, int>();
foreach (string key in ages.Keys)
{
    Console.WriteLine(key);
}
Values Property
 Purpose: Returns a collection of values in the dictionary.
 Syntax: dictionary.Values
 Example:
C#
Dictionary<string, int> ages = new Dictionary<string, int>();
foreach (int value in ages.Values)
{
    Console.WriteLine(value);
}
TryGetValue Method
 Purpose: Attempts to retrieve the value associated with a specified key.
 Syntax: dictionary.TryGetValue(key, out value)
 Example:
C#
Dictionary<string, int> ages = new Dictionary<string, int>();
int age;
if (ages.TryGetValue("Alice", out age))
{
    Console.WriteLine("Age: " + age);
}
ToDictionary Method
    Purpose: Converts the dictionary to a new dictionary of a different type.
 Syntax: dictionary.ToDictionary(keySelector, elementSelector)
 Example:
C#
Dictionary<string, int> numbers = new Dictionary<string, int>();
numbers.Add("one", 1);
numbers.Add("two", 2);
Dictionary<int, string> reversed = numbers.ToDictionary(kvp =>
kvp.Value, kvp => kvp.Key);
TryAdd Method
 Purpose: Attempts to add a new key- value pair to the dictionary.
 Syntax: dictionary.TryAdd(key, value)
 Returns: True if the key - value pair was added, false if the key already exists.
 Example:
C#
Dictionary<string, int> ages = new Dictionary<string, int>();
bool added = ages.TryAdd("Alice", 30);
GetOrAdd Method
 Purpose: Attempts to retrieve the value associated with a specified key. If the key doesn't
exist, it adds a new key- value pair using a specified function.
 Syntax: dictionary.GetOrAdd(key, valueFactory)
 Example:
C#
Dictionary<string, int> ages = new Dictionary<string, int>();
int age = ages.GetOrAdd("Alice", () => 30);
RemoveAll Method
 Purpose: Removes all key-value pairs from the dictionary that satisfy a specified condition.
 Syntax: dictionary.RemoveAll(predicate)
 Example:
C#
Dictionary<string, int> ages = new Dictionary<string, int>();
ages.RemoveAll(kvp => kvp.Value > 30);





