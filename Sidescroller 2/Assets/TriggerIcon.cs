using UnityEngine;

public class TriggerIcon : MonoBehaviour
{
    public GameObject icon; // Trage iconița pe care dorești să o afișezi aici

    void Start()
    {
        // Dezactivează iconița la începutul jocului
        icon.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Activează iconița atunci când playerul intră în trigger
            icon.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Dezactivează iconița atunci când playerul iese din trigger
            icon.SetActive(false);
        }
    }
}
