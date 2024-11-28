using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;

/*  Commenting the inefficient solution
string guestName = Console.ReadLine();
string hostName = Console.ReadLine();
string Pile =  Console.ReadLine();
 
Dictionary<char, int> GuestHost = new Dictionary<char, int>();
 
GuestHost.Add('A',0);
GuestHost.Add('B', 0);
GuestHost.Add('C', 0);
GuestHost.Add('D', 0);
GuestHost.Add('E', 0);
GuestHost.Add('F', 0);
GuestHost.Add('G', 0);
GuestHost.Add('H', 0);
GuestHost.Add('I', 0);
GuestHost.Add('J', 0);
GuestHost.Add('K', 0);
GuestHost.Add('L', 0);
GuestHost.Add('M', 0);
GuestHost.Add('N', 0);
GuestHost.Add('O', 0);
GuestHost.Add('P', 0);
GuestHost.Add('Q', 0);
GuestHost.Add('R', 0);
GuestHost.Add('S', 0);
GuestHost.Add('T', 0);
GuestHost.Add('U', 0);
GuestHost.Add('V', 0);
GuestHost.Add('W', 0);
GuestHost.Add('X', 0);
GuestHost.Add('Y', 0);
GuestHost.Add('Z', 0);
 
 
foreach(char c in guestName)
{
    if(GuestHost.ContainsKey(c))
    {
        GuestHost[c]++;
    }
}
 
foreach (char c in hostName)
{
    if (GuestHost.ContainsKey(c))
    {
        GuestHost[c]++;
    }
}
 
Dictionary<char, int> DoorChar = new Dictionary<char, int>();
 
DoorChar.Add('A', 0);
DoorChar.Add('B', 0);
DoorChar.Add('C', 0);
DoorChar.Add('D', 0);
DoorChar.Add('E', 0);
DoorChar.Add('F', 0);
DoorChar.Add('G', 0);
DoorChar.Add('H', 0);
DoorChar.Add('I', 0);
DoorChar.Add('J', 0);
DoorChar.Add('K', 0);
DoorChar.Add('L', 0);
DoorChar.Add('M', 0);
DoorChar.Add('N', 0);
DoorChar.Add('O', 0);
DoorChar.Add('P', 0);
DoorChar.Add('Q', 0);
DoorChar.Add('R', 0);
DoorChar.Add('S', 0);
DoorChar.Add('T', 0);
DoorChar.Add('U', 0);
DoorChar.Add('V', 0);
DoorChar.Add('W', 0);
DoorChar.Add('X', 0);
DoorChar.Add('Y', 0);
DoorChar.Add('Z', 0);
 
foreach (char c in Pile)
{
    if (DoorChar.ContainsKey(c))
    {
        DoorChar[c]++;
    }
}
int flg = 1;
foreach(var k in GuestHost)
{
    char key = k.Key;
    int value1 = k.Value;
 
    if(DoorChar.TryGetValue(key, out int value2))
    {
        if(value1 == value2)
        {
            continue;
        }
        else
        {
            flg = 0;
            break;
        }
    }
}
 
if(flg == 0)
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("YES");
}
*/


//Optimized solution
string guestName = Console.ReadLine();
string hostName = Console.ReadLine();
string Pile = Console.ReadLine();

string combinedName = guestName + hostName;
combinedName = string.Concat(combinedName.OrderBy(x => x));
Pile = string.Concat(Pile.OrderBy(x => x));

if (combinedName == Pile)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}