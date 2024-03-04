using UnityEngine;

public class PlayerSpawnManager : MonoBehaviour
{
    public GameObject playerPrefab; // Prefab-ul jucătorului
    public Transform initialSpawnPoint; // Punctul de spawn inițial al jucătorului
    private Transform lastCheckpoint; // Ultimul checkpoint atins

    void Start()
    {
        // La începutul jocului, spawnăm jucătorul la punctul inițial de spawn
        SpawnPlayer(initialSpawnPoint.position);
    }

    // Funcție pentru spawn-ul jucătorului la un anumit punct de spawn
    void SpawnPlayer(Vector3 spawnPosition)
    {
        GameObject player = Instantiate(playerPrefab, spawnPosition, Quaternion.identity);
        if (player != null)
        {
            // Spawnăm jucătorul la locația ultimului checkpoint atins
            player.transform.position = lastCheckpoint != null ? lastCheckpoint.position : spawnPosition;
        }
        else
        {
            Debug.LogError("Player prefab not assigned!");
        }
    }

    // Metodă pentru actualizarea checkpoint-ului curent
    public void SetCheckpoint(Transform checkpoint)
    {
        lastCheckpoint = checkpoint;
    }
}
