public static int FindNumberOfRecords(string bloodGroup)
{
int count = 0;
foreach (KeyValuePair<string, string> donor in donorDetails)
{
if (donor.Value == bloodGroup)
{
count++;
}
}
return count;
}

public static List<string> FindDonorNames(string bloodGroup)
{
List<string> donors = new List<string>();
foreach (KeyValuePair<string, string> donor in donorDetails)
{
if (donor.Value == bloodGroup)
{
donors.Add(donor.Key);
}
}
if (donors.Count == 0)
{
Console.WriteLine("Invalid blood group");
}
return donors;
}

public static Dictionary<string, string> SortByName()
{
Dictionary<string, string> sortedDonors = donorDetails.OrderBy(d => d.Key).ToDictionary(d => d.Key, d => d.Value);
return sortedDonors;
}

static void Main(string[] args)
{
while (true)
{
Console.WriteLine("\n1. Find number of records\n2. Find donor by blood group\n3. Sort donors by name\n4. Exit");
Console.Write("\nEnter your choice: ");
int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1)
{
Console.Write("\nEnter the blood group: ");
string bloodGroup = Console.ReadLine();
int count = FindNumberOfRecords(bloodGroup);
Console.WriteLine("The count is: " + count);
}
else if (choice == 2)
{
Console.Write("\nEnter the blood group: ");
string bloodGroup = Console.ReadLine();
List<string> donors = FindDonorNames(bloodGroup);
if (donors.Count != 0)
{
Console.WriteLine("The " + bloodGroup + " donors are:");
foreach (string donor in donors)
{
Console.WriteLine(donor);
}
}
}
else if (choice == 3)
{
Dictionary<string, string> sortedDonors = SortByName();
Console.WriteLine("\nDonors sorted by name:");
foreach (KeyValuePair<string, string> donor in sortedDonors)
{
Console.WriteLine(donor.Key + " - " + donor.Value);
}
}
else if (choice == 4)
{
break;
}
else
{
Console.WriteLine("Invalid choice!");
}
}
}