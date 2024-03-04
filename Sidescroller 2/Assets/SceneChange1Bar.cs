using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange1Bar : MonoBehaviour
{
    public string sceneToLoad = "Town";
    private bool playerTeleported = false;

    void Update()
    {
        // Verificăm dacă tasta E a fost apăsată și jucătorul nu a fost teleportat încă
        if (Input.GetKeyDown(KeyCode.E) && !playerTeleported)
        {
            // Teleportăm jucătorul la scena dată
            TeleportPlayerToScene(sceneToLoad);
            playerTeleported = true; // Marcam că jucătorul a fost teleportat
        }
    }

    void TeleportPlayerToScene(string sceneName)
    {
        // Distrugem jucătorul anterior
        DestroyPreviousPlayer();

        // Încărcăm scena dată
        SceneManager.LoadScene(sceneName);
    }

    void DestroyPreviousPlayer()
    {
        // Găsim și distrugem jucătorul anterior
        GameObject previousPlayer = GameObject.FindGameObjectWithTag("Player");
        if (previousPlayer != null)
        {
            Destroy(previousPlayer);
        }
        else
        {
            Debug.LogError("Jucătorul nu a fost găsit!");
        }
    }
}
