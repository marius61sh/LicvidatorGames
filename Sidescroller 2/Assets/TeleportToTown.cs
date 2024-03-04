using UnityEngine;

public class TeleportToTown : MonoBehaviour
{
    public string sceneToLoad = "Town"; // Numele scenei către care vrem să ne teleportăm
    public KeyCode teleportKey = KeyCode.E; // Tasta pentru teleportare
    public VectorValue playerStorage; // Referință către variabila care stochează poziția jucătorului
    public Vector2 playerPosition; // Variabilă pentru a stoca temporar poziția jucătorului

    private bool isInsideBar = false; // Verifică dacă jucătorul este în bar

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isInsideBar = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isInsideBar = false;
        }
    }

    void Update()
    {
        // Verificăm dacă tasta pentru teleportare a fost apăsată și jucătorul este în bar
        if (Input.GetKeyDown(teleportKey) && isInsideBar)
        {
            // Salvăm poziția jucătorului în vectorul de stocare
            playerStorage.initialValue = playerPosition;
            // Teleportăm jucătorul către noua scenă
            TeleportPlayerToScene(sceneToLoad);
        }
    }

    // Metodă pentru teleportare la o anumită scenă
    void TeleportPlayerToScene(string sceneName)
    {
        // Încărcăm scena dată
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
