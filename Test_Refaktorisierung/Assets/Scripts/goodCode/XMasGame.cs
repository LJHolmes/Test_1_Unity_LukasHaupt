using UnityEngine;
using System.Collections.Generic;

public class XMasGame : MonoBehaviour
{

    /*
    Aufgabenstellung: Refaktorisierung

    - Legen Sie ein neues Unity-Projekt mit dem Namen "Test_Refaktorisierung" an.
    - Erstellen Sie eine neue private Git-Repository: "Test_1_Unity_[IhrName]".
    - Initialisieren Sie das Projekt mit den notwendigen Inhalten und pushen Sie es in Ihre Repository.
    - Im Projekt erstellen Sie einen Ordner "Scripts" mit zwei Unterordnern: "badCode" und "goodCode".
    - Im "badCode"-Ordner speichern Sie alle orig.-Skripte wie "XMasGame_badCode.cs".
    - Refaktorisieren Sie die badCode Skripte gemäß den Best Practices der Code-Formatierung und
      speichern Sie die verbesserte Version im "goodCode"-Ordner ohne den Zusatz _badCode z.B.: "XMasGame.cs".
      (Achten Sie darauf, sowohl den Dateinamen als auch den Klassennamen im Skript zu ändern.)
    - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion
    - Nach jeder Refaktorisierungen erfolgt ein Push auf Git mit deskriptiven Namen.
    - NumberFilter.cs und SceneObjectManager.cs sollen um Screenshots der jeweiligen Button Funktionen, also die
      entsprechenden ConsolenAusgabe ergänzt werden. Laden Sie die Screenshoots mit entsprechnder Bezeichnung zu ihrer Repo .md hoch.
    - Der Einsatz von KI-Tools wie ChatGPT etc. ist nicht gestattet
    - Hilfestellungen untereinander sind nicht gestattet
    - Zum Abschluss soll vor Abgabe ein Finaler Push zur mit dem Namen Abgabe erfolgen.
    - Nach Abschluss ALLER Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
     */


    public GameObject sleigh;

    public List<string> giftInventory = new List<string>();

    private int santaHealth = 100;
    private bool isFlying;
    private float flyingSpeed = 10f;


    void Start()
    {
        // Santa Health auf 80 Health stellen
        santaHealth = 80; Debug.Log("Weihnachtsabenteuer beginnt!");
    }

    void Update()
    {
        // Wenn Santa lebt
        if (santaHealth > 0)
        {
            CheckMovement();
            CheckInventory();
        }
        // Wenn Santa auf 0 Health ist
        else
        {
            Debug.Log("Weihnachten ist vorbei!");
        }
    }
    
    void CheckMovement()
    {
        // Bewege den Schlitten, wenn isFlying true ist
        if (isFlying)
        {
            var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            sleigh.transform.Translate(move * flyingSpeed * Time.deltaTime);
        }
        else
        {
            Debug.Log("Santa kann nicht fliegen!");
        }
    }

    void CheckInventory()
    {
        // Wenn Geschenkinventar leer
        if (giftInventory.Count == 0)
        {
            Debug.Log("Keine Geschenke vorhanden.");
        }
        else
        {
            foreach (var gift in giftInventory)
            {
                Debug.Log("Geschenk im Inventar: " + gift);
            }
        }
    }

    public void TakeDamage(int damage)
    {
        // int damage wird Santas Health abgezogen
        santaHealth -= damage;

        if (santaHealth < 0)
        {
            santaHealth = 0;
        }
    }
    public void AddGiftToInventory(string gift)
    {
        // Wenn Geschenkeinventar kein Geschenk enthält
        if (!giftInventory.Contains(gift))
        {
            // Füge Geschenk hinzu
            giftInventory.Add(gift);
        }
    }
    public void StartFlying()
    {
        isFlying = true;
    }
    public void StopFlying()
    {
        isFlying = false;
    }
}
