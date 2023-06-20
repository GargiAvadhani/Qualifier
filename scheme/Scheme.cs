using System;
using System.Collections.Generic;

class Program
{
// Declare SchemeDetails dictionary as a static variable
public static Dictionary<string, double> SchemeDetails = new Dictionary<string, double>();

// Method to add scheme details into SchemeDetails dictionary
public void AddSchemeDetails(string[] scheme)
{
foreach (string s in scheme)
{
string[] details = s.Split(':');
SchemeDetails[details[0]] = Convert.ToDouble(details[1]);
}
}

// Method to find the monthly amount of a scheme based on scheme name
public double FindSchemeMonthlyAmount(string schemeName)
{
double amount;
bool isFound = SchemeDetails.TryGetValue(schemeName, out amount);
if (isFound)
{
return amount;
}
else
{
Console.WriteLine("No schemes are available");
return -1;
}
}

// Method to find the lowest monthly amount scheme
public List<string> FindLowestMonthlyAmountScheme()
{
double lowestAmount = double.MaxValue;
List<string> lowestAmountSchemes = new List<string>();
foreach (KeyValuePair<string, double> scheme in SchemeDetails)
{
if (scheme.Value < lowestAmount)
{
lowestAmountSchemes.Clear();
lowestAmount = scheme.Value;
lowestAmountSchemes.Add(scheme.Key);
}
else if (scheme.Value == lowestAmount)
{
lowestAmountSchemes.Add(scheme.Key);
}
}
return lowestAmountSchemes;
}

// Main method to test the functionality
static void Main(string[] args)
{
Program p = new Program();
string[] schemeArray = { "Scheme1:1000", "Scheme2:1500", "Scheme3:800", "Scheme4:1200" };
p.AddSchemeDetails(schemeArray);
double amount = p.FindSchemeMonthlyAmount("Scheme2");
Console.WriteLine("Monthly amount for Scheme2: " + amount);
List<string> lowestSchemes = p.FindLowestMonthlyAmountScheme();
Console.WriteLine("Lowest amount schemes:");
foreach (string scheme in lowestSchemes)
{
Console.WriteLine(scheme);
}
}
}