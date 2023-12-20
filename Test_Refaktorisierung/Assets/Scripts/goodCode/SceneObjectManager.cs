using UnityEditor.Search;
using UnityEngine;

public class SceneObjectManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] items;

    public string[] enemyTypes = { "fire", "water", "ice", "stone" };

    public Vector3 itemPositionRange = new Vector3(10f, 10f, 10f);

    private void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        items = GameObject.FindGameObjectsWithTag("Item");
    }

    public void CheckEnemiesType() // for Button
    {
        foreach (GameObject enemy in enemies)
        {
            // Random Zahl in enemyTypes
            int randomType = Random.Range(0, enemyTypes.Length);

            // Typ zuweißen
            string randomEnemyType = enemyTypes[randomType];

            Debug.Log(enemy.name + " " + randomEnemyType);
        }
    }

    public void CheckItemsPosition() // for Button
    {
        foreach (GameObject item in items)
        {
            // Item auf random Vector3 setzen
            item.transform.position = GetRandomPosition();

            Debug.Log(item.name + " " + item.transform.position);
        }
    }

    private Vector3 GetRandomPosition()
    {
        // Floats random legen, von itemPositionRange
        float randomX = Random.Range(-itemPositionRange.x, itemPositionRange.x);
        float randomY = Random.Range(-itemPositionRange.y, itemPositionRange.y);
        float randomZ = Random.Range(-itemPositionRange.z, itemPositionRange.z);

        // Neuen Vector erstellen
        Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);

        // Rückgabe
        return randomPosition;
    }


    /*
    Aufgabenstellung: Refaktorisierung

    - Refaktorisieren Sie das Skript, um alle Objekte mit dem Tag "Enemy" einem Array von Feinden und alle Objekte mit dem Tag "Item" einem Array von Gegenständen effizient hinzuzufügen.
    - Weisen Sie jedem "Enemy"-Objekt einen zufälligen Typ aus dem enemyTypes-Array zu.
    - Weisen Sie jedem "Item"-Objekt eine zufällige Position innerhalb des angegebenen itemPositionRange-Bereichs zu.
    - Erstellen Sie 2 Button Methoden, Button 1 soll jeden Enemy mit dem dazugehörigen Typ in die Console schreiben. Botton 2 soll jedes Item mit der jeweilig dazugehörigen Position in die Console schreiben.
    - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
    - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
    - Nach Abschluss aller Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
    */
}
