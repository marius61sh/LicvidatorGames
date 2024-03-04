// TeleportToTown.cs
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public string sceneToLoad = "Town"; // Numele scenei către care vrem să ne teleportăm
    public VectorValue playerStorage; // Referință către variabila care stochează poziția jucătorului
    public Vector2 playerPosition; // Variabilă pentru a stoca temporar poziția jucătorului

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
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
