using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    public static GameManager1 instance;
    public string spawnPointName;
    private string spawnPointKey = "SpawnPointBarToTown";
    public Transform barSpawnPoint; // Punctul de spawn în fața ușii la bar

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            LoadSpawnPoint();
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void SetSpawnPoint(string spawnPoint)
    {
        spawnPointName = spawnPoint;
        PlayerPrefs.SetString(spawnPointKey, spawnPoint);
    }

    public void LoadSpawnPoint()
    {
        if (PlayerPrefs.HasKey(spawnPointKey))
        {
            spawnPointName = PlayerPrefs.GetString(spawnPointKey);
        }
    }
}
