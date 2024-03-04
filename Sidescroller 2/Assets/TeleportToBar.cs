using UnityEngine;

public class TeleportToBar : MonoBehaviour
{
    void TeleportPlayerToBar()
    {
        if (SpawnPointManager.instance != null)
        {
            Transform spawnPoint = SpawnPointManager.instance.spawnPointBar;
            if (spawnPoint != null)
            {
                // Teleportați jucătorul la spawn point
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                if (player != null)
                {
                    player.transform.position = spawnPoint.position;
                }
                else
                {
                    Debug.LogError("Jucătorul nu a fost găsit în scenă!");
                }
            }
            else
            {
                Debug.LogError("Spawn point-ul pentru 'Bar' nu este setat!");
            }
        }
        else
        {
            Debug.LogError("SpawnPointManager nu a fost găsit!");
        }
    }
}
