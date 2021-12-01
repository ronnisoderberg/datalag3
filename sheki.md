> Detta är en rapport om projektarbetet som utfördes i kursen "**datalagring** *(Win21)*".

## Innehållsförteckning

## Bakgrund och Inledning
Vi har i tidigare uppgifter skapat databaser och hanterat datan i databasen genom LINQ to SQL(database first) och Entity Framework(code first).
I de tidigare uppgifterna har vi endast arbetat i backenden och till detta projekt skulle vi skapa frontend projekt(GUI) som den användare som kör
kommer att interagera med. 
### Syfte
Syftet med detta projektet var att vi skulle skapa en varsin frontend del till ett program som redan hade en färdig backend del.
I detta projektarbete har vi fått i uppgift
### Mål
Målet för projektarbetet var att vi skulle ha utvecklat en varsin fungerande frontend app som interagerar med användaren
samt utforma tester för de metoder som används i programmet. 

## Planering
Planeringen tycker jag gick bra, vi kommunicerade och pratade i början om hur och vad vi ville göra i projektet.
Vi valde att i projektet utgå ifrån koden som Natalie skapade till inlämningsuppgift 2. 
Att vi alla utvecklade olika delar av programmet tycker jag underlättade hela uppgiften eftersom att det var svårt för oss
att hitta en tid då vi alla kunde sitta tillsammans med uppgiften. 
Arbetet delas upp på det vis att jag utvecklade RestaurantClient, Ronni utveckalde UserClient och Natalie utvecklade AdminClient projektet.

### Implementering 
Eftersom att Natalies sätt att skapa datasen i den tidigare uppgiften skilde sig från mitt sätt så hade jag svårigheter i början att förstå
hur backend delen fungerade och hur tabellerna i databasen var kopplade till varandra. 
När jag väl fick kläm på det släppte det och jag började skriva min del i projektet. 
Jag tog belsutet att i min del skriva ut text till konsollen i olika färger för att göra det mer "användarvänligt". 
Jag fokuserade ganska mycket på att göra det så svårt som möjligt för användaren att ange värden som skulle kunna crasha programmet 
och detta resulterade i att det blev mycket kod i programmet som sedan resulterade i att jag skapade nya klasser och bröt ut koden i dessa klasser.
Det som jag kan träna på och försöka göra bättre till framtiden är att dela upp koden i mer sammanhängande delar. 


Den bit kod som jag blev mest nöjd över är koden som tar in och döljer användarens lösenord
Koden såg ut så här:
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