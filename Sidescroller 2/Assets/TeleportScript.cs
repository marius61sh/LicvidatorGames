using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void TeleportPlayerToSpawnPoint()
    {
        if (gameManager != null)
        {
            Vector3 spawnPointPosition = gameManager.GetSpawnPointPosition();
            // Teleportează jucătorul la poziția spawnPointPosition
            GameObject playerInstance = gameManager.GetPlayerInstance();
            if (playerInstance != null)
            {
                playerInstance.transform.position = spawnPointPosition;
            }
            else
            {
                Debug.LogError("Jucătorul nu a fost creat încă!");
            }
        }
        else
        {
            Debug.LogError("GameManager nu a fost găsit!");
        }
    }
}
