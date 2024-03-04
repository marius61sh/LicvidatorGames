using UnityEngine;

public class SceneChangeTownScript : MonoBehaviour
{
    public string sceneToLoad = "Town"; // Numele scenei către care vrem să ne teleportăm
    public string spawnPointName = "BarExitSpawn"; // Numele punctului de spawn

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Dacă jucătorul intră în trigger
        {
            // Încărcăm scena specificată
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
            // Setăm punctul de spawn static
        }
    }
}
