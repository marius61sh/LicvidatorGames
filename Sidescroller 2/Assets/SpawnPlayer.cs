using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject Player; // Referință către jucătorul care va fi spawnat
    public Transform initialSpawnPoint; // Punctul de spawn inițial
    public Transform doorSpawnPoint; // Punctul de spawn în fața ușii

    void Start()
    {
        if (Player != null && initialSpawnPoint != null)
        {
            // Mutăm jucătorul la poziția și rotația punctului de spawn inițial
            Player.transform.position = initialSpawnPoint.position;
            Player.transform.rotation = initialSpawnPoint.rotation;

            // Setăm coordonatele de teleportare în cazul în care jucătorul iese din bar
            TeleportManager.SetTeleportPosition(doorSpawnPoint.position);
        }
        else
        {
            Debug.LogError("Player or spawn point not assigned!");
        }
    }

    void Update()
    {
        // Poate fi utilizat pentru logica de actualizare, dacă este necesar
    }
}
