using UnityEngine;
using System.Collections.Generic;

public class WinterSportsGame : MonoBehaviour
{
    /*
    Aufgabenstellung: Refaktorisierung

    - Refaktorisieren Sie das Skript gemäß den Best Practices der Code-Formatierung.
    - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
    - Achten Sie auf die konsistente Benennung von Variablen und Methoden.
    - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
    - Zum Abschluss soll vor Abgabe ein Finaler Push zur mit dem Namen Abgabe erfolgen.
    - Nach Abschluss ALLER Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
    */

    public int PlayerHealth = 100;
    public float MoveSpeed = 10f;

    public GameObject Ski;

    public List<string> Achievements = new List<string>();

    private bool isSkiing;

    void Start()
    {
        PlayerHealth = 100;

        Debug.Log("WinterSports beginnt!");
    }
    void Update()
    {
        // Wenn Spieler lebt
        if (PlayerHealth > 0)
        {
            CheckSkiing(); CheckAchievements();
        }
        else
        {
            Debug.Log("Spiel beendet!");
        }
    }
    void CheckSkiing()
    {
        // Ski bewegen
        if (isSkiing)
        {
            var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            Ski.transform.Translate(move * MoveSpeed * Time.deltaTime);
        }
        else
        {
            Debug.Log("Spieler kann nicht Ski fahren!");
        }
    }

    void CheckAchievements()
    {
        if (Achievements.Count == 0)
        {
            Debug.Log("Keine Erfolge erzielt.");
        }
        else
        {
            // Alle Achivements in der Console auslesen
            foreach (var achievement in Achievements)
            {
                Debug.Log("Erfolg: " + achievement);
            }
        }
    }

    public void LoseHealth(int amount)
    {
        // Spieler int amount Health abziehen
        PlayerHealth -= amount;
        
        if (PlayerHealth < 0)
        {
            PlayerHealth = 0;
        }
    }

    public void AddAchievement(string achievement)
    {
        // Wenn Achivments keine Achivements enthält
        if (!Achievements.Contains(achievement))
        {
            Achievements.Add(achievement);
        }
    }

    public void StartSkiing()
    {
        isSkiing = true;
    }

    public void StopSkiing()
    {
        isSkiing = false;
    }
}
