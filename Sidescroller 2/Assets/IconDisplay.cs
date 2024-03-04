// IconDisplayScript.cs
using UnityEngine;
using UnityEngine.UI;

public class IconDisplay : MonoBehaviour
{
    public Image iconImage; // Referință către UI Image-ul care afișează iconița
    public KeyCode activationKey = KeyCode.E; // Tasta de activare (E în acest caz)

    void OnTriggerEnter(Collider other)
    {
        // Verificăm dacă jucătorul a intrat în trigger
        if (other.CompareTag("Player"))
        {
            // Afișăm iconița
            iconImage.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Verificăm dacă jucătorul a ieșit din trigger
        if (other.CompareTag("Player"))
        {
            // Ascundem iconița
            iconImage.enabled = false;
        }
    }

    void Update()
    {
        // Verificăm dacă tasta de activare a fost apăsată
        if (Input.GetKeyDown(activationKey))
        {
            // Aici poți adăuga cod pentru teleportare, în funcție de necesități
        }
    }
}
