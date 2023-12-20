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


    public GameObject Ski;

    public List<string> Achievements = new List<string>();

    private int playerStamina = 100;
    private float MoveSpeed = 10f;
    private bool isSkiing;

    void Start()
    {
        // Ausdauer auf 100 setzen
        playerStamina = 100;

        Debug.Log("WinterSports beginnt!");
    }
    void Update()
    {
        // Wenn Spieler noch Ausdauer hat
        if (playerStamina > 0)
        {
            CheckSkiing();
            CheckAchievements();
        }
        else
        {
            Debug.Log("Spiel beendet!");
        }
    }
    void CheckSkiing()
    {
        // Ski bewegen, wenn isSkiing true ist
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

    public void LoseStamina(int amount)
    {
        // Spieler wird int amount Ausdauer abgezogen
        playerStamina -= amount;
        
        if (playerStamina < 0)
        {
            playerStamina = 0;
        }
    }

    public void AddAchievement(string achievement)
    {
        // Wenn Achievements kein achviement enthält
        if (!Achievements.Contains(achievement))
        {
            // Füge achivement hinzu
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
