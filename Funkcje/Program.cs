//Funkcje w C# są blokami kodu, które wykonują określone zadanie.
//Mogą przyjmować parametry wejściowe, wykonywać operacje i zwracać wynik.
//Funkcje są fundamentalnym elementem programowania, ponieważ pozwalają na modularność, ponowne użycie kodu oraz lepsze organizowanie logiki programu.

//Funkcja składa się z typu jaki będzie zwracać, nazwy, oraz argumentów które funkcja przyjmuje

// Funkcja dodająca dwie liczby całkowite
int Add(int x, int y)
{
    // Dodaje x i y, a następnie zwraca wynik
    return x + y;
}

// Funkcja odejmująca dwie liczby całkowite

int Subtract(int x, int y) 
{  
    return x - y; 
}

// Funkcja mnożąca dwie liczby całkowite

int Multiply(int x, int y)
{
    return x * y;
}

// Funkcja dzieląca dwie liczby całkowite

int Divide(int x, int y)
{
    return x / y;
}

// Funkcja zwracająca resztę z dzielenia dwóch liczb całkowitych

int Modulo(int x, int y)
{
    return x % y;
}

// Funkcja dodająca dwie liczby zmiennoprzecinkowe

float AddFloat(float x, float y)
{
    return x + y;
}

// Funkcja dodająca dwie liczby zmiennoprzecinkowe zwracająca liczbę całkowitą

int AddFloatInt(float x, float y)
{
    float temp = x + y;
    return (int)Math.Round(temp);
}

// Funkcja mnożąca dwie liczby zmiennoprzecinkowe zwracająca liczbę całkowitą

int MultiplyFloatInt(float x, float y)
{
    float temp = x * y;
    return (int)Math.Round(temp);
}

// Funkcja mnożąca jedną liczbe zmiennoprzecinkową i jedną całkowitą zwracająca liczbę całkowitą

int MultiplyFloatAndInt(float x, int y)
{
    float temp = x * y;
    return (int)Math.Round(temp);
}

// Funkcja mnożąca jedną liczbe zmiennoprzecinkową i jedną całkowitą zwracająca liczbę zmiennoprzecinkową

float MultiplyFloatAndInt2(float x, int y)
{
    float temp = x * y;
    return temp;
}

// Funkcja dzieląca dwie liczby zmiennoprzecinkowe zwracająca liczbę całkowitą

int Multiply2FloatsToInt(float x, float y)
{
    float temp = x * y;
    return (int)Math.Round(temp);
}

// Funkcja dzieląca jedną liczbe zmiennoprzecinkową i jedną całkowitą zwracająca liczbę całkowitą

int DivideFloatAndInt(float x, int y)
{
    float temp = x / y;
    return (int)Math.Round(temp);
}

// Funkcja dzieląca jedną liczbe zmiennoprzecinkową i jedną całkowitą zwracająca liczbę zmiennoprzecinkową

float DivideFloatAndIntToFloat(float x, int y)
{
    float temp = x / y;
    return temp;
}

//Warunki
//Instrukcja if sprawdza, czy wyrażenie logiczne (w tym przypadku x > 5) jest prawdziwe.
//Jeśli tak, wykonywane są instrukcje w bloku {}.
//W tym przypadku zostanie wyświetlony tekst, ponieważ x (10) jest większe niż 5.

int x = 10;
if (x > 5)
{
    Console.WriteLine("x jest większe niż 5");
}

//Instrukcja if-else pozwala obsłużyć zarówno przypadek, gdy warunek jest prawdziwy (wykonuje się blok if),
//jak i przypadek, gdy jest fałszywy (wykonuje się blok else).
//W tym przykładzie x jest mniejsze niż 5, więc wyświetlony zostanie komunikat "x jest mniejsze lub równe 5".

x = 3;

if (x > 5)
{
    Console.WriteLine("x jest większe niż 5");
}
else
{
    Console.WriteLine("x jest mniejsze lub równe 5");
}

//else if pozwala na sprawdzenie wielu warunków.
//Program sprawdza warunki po kolei, aż znajdzie pierwszy, który jest prawdziwy, i wykonuje odpowiednią sekcję kodu.
//W tym przypadku zostanie wyświetlony komunikat "x jest większe niż 5, ale mniejsze lub równe 10", ponieważ x wynosi 7
x = 7;

if (x > 10)
{
    Console.WriteLine("x jest większe niż 10");
}
else if (x > 5)
{
    Console.WriteLine("x jest większe niż 5, ale mniejsze lub równe 10");
}
else
{
    Console.WriteLine("x jest mniejsze lub równe 5");
}

//Instrukcja warunkowa z operatorem logicznym
//Można używać operatorów logicznych takich jak && (i) lub || (lub) w warunkach.
//W tym przypadku oba warunki muszą być spełnione: x musi być większe niż 10 i mniejsze niż 20, aby komunikat został wyświetlony.
//Ponieważ x wynosi 15, komunikat zostanie wyświetlony.

x = 15;
if (x > 10 && x < 20)
{
    Console.WriteLine("x znajduje się między 10 a 20");
}

//Operator warunkowy (znany również jako operator trójargumentowy) to skrócona forma zapisu warunku if-else.
//Składa się z wyrażenia warunkowego przed znakiem ?, a po nim znajdują się dwie wartości rozdzielone dwukropkiem (:) - pierwsza, jeśli warunek jest prawdziwy, a druga, jeśli jest fałszywy.
//W tym przykładzie, ponieważ x wynosi 8, zostanie przypisana wartość "Większe niż 5", a wynik zostanie wyświetlony.

x = 8;
string wynik = (x > 5) ? "Większe niż 5" : "Mniejsze lub równe 5";
Console.WriteLine(wynik);


//Napisz funkcję, która sprawdza, czy podana liczba jest parzysta.
void CheckModulo(int x)
{
    if (x % 2 == 0)
    {
        Console.WriteLine("x jest parzysty");
    }
    else
    {
        Console.WriteLine("x nie jest parzysty");
    }
}

//Napisz funkcję, która sprawdza, czy liczba jest dodatnia, ujemna czy równa zero.

void CheckPositive(int x)
{
    if (x > 0)
    {
        Console.WriteLine("x jest większy od zera");
    }
    else if (x < 0)
    {
        Console.WriteLine("x jest mniejszy od zera");
    }
    else
    {
        Console.WriteLine("x jest równy 0");
    }
}


//Napisz funkcję, która sprawdza, czy osoba w podanym wieku jest pełnoletnia (przyjmij, że pełnoletność zaczyna się od 18 lat).

void CheckAge(int x)
{
    if (x >= 18)
    {
        Console.WriteLine("osoba jest pełnoletnia");
    }
    else
    {
        Console.WriteLine("osoba nie jest pełnoletnia");
    }
}

//Napisz funkcję, która zwraca większą liczbę z dwóch liczb.

void GreaterInt(int x, int y)
{
    if (x < y) 
    {
        Console.WriteLine($"{y} jest większe od {x}");
    } else if (x > y)
    {
        Console.WriteLine($"{x} jest większe od {y}");
    } else
    {
        Console.WriteLine($"{x} i {y} są równe");
    }
}

//Napisz funkcję, która zwraca największą z trzech liczb.

void GreaterInt2(int x, int y, int z)
{
    int max;
    if (x >= y && x >= z)
    {
        max = x;
    }
    else if (y >= x && y >= z)
    {
        max = y;
    }
    else
    {
        max = z;
    }
    Console.WriteLine($"liczba {max} jest największa");
}

//Napisz funkcję, która sprawdza, czy liczba mieści się w przedziale od 10 do 20 (włącznie).
if (x >= 10 && x <= 20)
{
    Console.WriteLine("x znajduje się między 10 a 20");
} else
{
    Console.WriteLine("x nie znajduje się między 10 a 20");
}

//Napisz funkcję, która przekształca temperaturę w stopniach Celsjusza na stopnie Fahrenheita, ale jeśli temperatura jest niższa niż -273.15°C, zwróci komunikat "Temperatura poniżej zera absolutnego".
void CelsiusToFahrenheit(float celsius)
{
    if (celsius < -273.15)
    {
        Console.WriteLine("Temperatura poniżej zera absolutnego");
    }
    float fahrenheit = (celsius * 9 / 5) + 32;
    Console.WriteLine($"Temperatura {celsius} stopni C jest równa temperaturze {fahrenheit} stopni F");

}

//Napisz funkcję, która na podstawie liczbowej punktów (0-100) zwraca opisową ocenę (np. "niedostateczna", "dostateczna", "dobry").

void PercentToGrade(int x)
{
    if(x > 0 && x <= 39)
    {
        Console.WriteLine("Ocena niedostateczna");
    } else if(x > 39 && x <= 54)
    {
        Console.WriteLine("Ocena dopuszczająca");
    } else if (x > 54 && x <= 69)
    {
        Console.WriteLine("Ocena dostateczna");
    } else if (x > 69 && x <= 85)
    {
        Console.WriteLine("Ocena dobra");
    } else if (x > 85 && x <= 99)
    {
        Console.WriteLine("Ocena bardzo dobra");
    } else if (x > 99 && x <= 100)
    {
        Console.WriteLine("Ocena celująca");
    } else
    {
        Console.WriteLine("Podana liczba nie jest w zakrezie 0-100");
    }
}

//Napisz funkcję, która sprawdza, czy liczba A jest wielokrotnością liczby B.

void CheckMultiple(int A, int B)
{
    if (B != 0 && A % B == 0)
    {
        Console.WriteLine($"{A} jest wielokrotnością {B}.");
    }
    else if (B == 0)
    {
        Console.WriteLine("Nie można dzielić przez 0.");
    }
    else
    {
        Console.WriteLine($"{A} nie jest wielokrotnością {B}.");
    }
}

int a = 10;
int b = 3;

// Wywołanie funkcji i przypisanie wyniku do zmiennych
int sum = Add(a, b); // Wywołanie funkcji dodającej dwie liczby

//Testowanie
Console.WriteLine(sum);
