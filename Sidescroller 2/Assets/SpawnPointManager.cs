using UnityEngine;

public class SpawnPointManager : MonoBehaviour
{
    public static SpawnPointManager instance; // Singleton pattern

    public Transform spawnPointBar;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
