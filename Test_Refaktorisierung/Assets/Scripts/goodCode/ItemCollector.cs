using UnityEngine;
using System.Collections.Generic;

public class ItemCollector : MonoBehaviour
{
    /*
    Aufgabenstellung: Refaktorisierung

    - Vereinfachen Sie die Methode 'CollectItems' mithilfe eines Arrays und einer foreach-Schleife.
    - Refaktorisieren Sie den Code gemäß den Best Practices der Code-Formatierung.
    - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
    - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
    - Nach Abschluss aller Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
    */

    public GameObject[] items;

    private List<GameObject> collectedItems = new List<GameObject>();

    private void Update()
    {
        CollectItems();
    }

    private void CollectItems()
    {
        foreach (var item in items)
        {
            collectedItems.Add(item);
        }
    }
}
