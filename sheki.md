> Detta �r en rapport om projektarbetet som utf�rdes i kursen "**datalagring** *(Win21)*".

## Inneh�llsf�rteckning

## Bakgrund och Inledning
Vi har i tidigare uppgifter skapat databaser och hanterat datan i databasen genom LINQ to SQL(database first) och Entity Framework(code first).
I de tidigare uppgifterna har vi endast arbetat i backenden och till detta projekt skulle vi skapa frontend projekt(GUI) som den anv�ndare som k�r
kommer att interagera med. 
### Syfte
Syftet med detta projektet var att vi skulle skapa en varsin frontend del till ett program som redan hade en f�rdig backend del.
I detta projektarbete har vi f�tt i uppgift
### M�l
M�let f�r projektarbetet var att vi skulle ha utvecklat en varsin fungerande frontend app som interagerar med anv�ndaren
samt utforma tester f�r de metoder som anv�nds i programmet. 

## Planering
Planeringen tycker jag gick bra, vi kommunicerade och pratade i b�rjan om hur och vad vi ville g�ra i projektet.
Vi valde att i projektet utg� ifr�n koden som Natalie skapade till inl�mningsuppgift 2. 
Att vi alla utvecklade olika delar av programmet tycker jag underl�ttade hela uppgiften eftersom att det var sv�rt f�r oss
att hitta en tid d� vi alla kunde sitta tillsammans med uppgiften. 
Arbetet delas upp p� det vis att jag utvecklade RestaurantClient, Ronni utveckalde UserClient och Natalie utvecklade AdminClient projektet.

### Implementering 
Eftersom att Natalies s�tt att skapa datasen i den tidigare uppgiften skilde sig fr�n mitt s�tt s� hade jag sv�righeter i b�rjan att f�rst�
hur backend delen fungerade och hur tabellerna i databasen var kopplade till varandra. 
N�r jag v�l fick kl�m p� det sl�ppte det och jag b�rjade skriva min del i projektet. 
Jag tog belsutet att i min del skriva ut text till konsollen i olika f�rger f�r att g�ra det mer "anv�ndarv�nligt". 
Jag fokuserade ganska mycket p� att g�ra det s� sv�rt som m�jligt f�r anv�ndaren att ange v�rden som skulle kunna crasha programmet 
och detta resulterade i att det blev mycket kod i programmet som sedan resulterade i att jag skapade nya klasser och br�t ut koden i dessa klasser.
Det som jag kan tr�na p� och f�rs�ka g�ra b�ttre till framtiden �r att dela upp koden i mer sammanh�ngande delar. 


Den bit kod som jag blev mest n�jd �ver �r koden som tar in och d�ljer anv�ndarens l�senord
Koden s�g ut s� h�r:
```csharp
 var password = new StringBuilder();
            Console.Write("Password:");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (password.Length > 0)
                    {
                        password.Remove(password.Length - 1, 1);
                        Console.Write("\b \b");
                    }
                }
                else if (key.KeyChar != '\u0000')
                {
                    password.Append(key.KeyChar);
                    Console.Write("*");
                }
            }
            Console.WriteLine();
```
![password](https://github.com/ronnisoderberg/datalag3/blob/master/hidepassword.png?raw=true)