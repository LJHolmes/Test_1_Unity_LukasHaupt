using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

public class NumberFilter : MonoBehaviour
{
    /*
   Aufgabenstellung: Refaktorisierung

   - Refaktorisieren Sie das Skript, um die Zahlenreihe effizienter nach geraden und ungeraden Zahlen zu filtern.
   - Nutzen Sie Arrays und foreach-Schleifen für die Refaktorisierung.
   - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
   - Fügen Sie zwei Methoden hinzu, die jeweils alle geraden bzw. ungeraden Zahlen lesbar in die Konsole schreiben.
   - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
   - Nach Abschluss aller Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
   */

    public int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    public int[] evenNumbers = new int[5];
    public int[] oddNumbers = new int[5];

    private void Start()
    {
        CheckEvenOrOddNumber();
        CheckEvenNumbers();
        CheckOddNumbers();
    }

    private void CheckEvenOrOddNumber()
    {
        // Gerade und Ungerade Zähler
        int evenCount = 0;
        int oddCount = 0;

        foreach (int number in numbers)
        {
            // Wenn zahl durch 2 geteilt irgendwann 0 ergibt
            if (number % 2 == 0)
            {
                evenNumbers[evenCount] = number;
                evenCount++;
            }
            else
            {
                oddNumbers[oddCount] = number;
                oddCount++;
            }
        }
    }

    public void CheckEvenNumbers()
    {
        // Schreibe gerade Numbers in Console
        foreach (int number in evenNumbers)
        {
            Debug.Log(number);
        }
    }

    public void CheckOddNumbers()
    {
        // Schreibe ungerade Numbers in Console
        foreach (int number in oddNumbers)
        {
            Debug.Log(number);
        }
    }
}
