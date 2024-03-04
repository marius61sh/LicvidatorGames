using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    private GameObject playerInstance; // Referință către instanța jucătorului actual
    public Transform spawnPoint; // Punctul de spawn pentru jucător

    private void Start()
    {
        // Verificăm dacă există deja o instanță a jucătorului
        if (playerInstance == null)
        {
            // Dacă nu există, încercăm să îl încărcăm din PlayerPrefs
            if (PlayerPrefs.HasKey("PlayerPositionX") && PlayerPrefs.HasKey("PlayerPositionY") && PlayerPrefs.HasKey("PlayerPositionZ"))
            {
                float x = PlayerPrefs.GetFloat("PlayerPositionX");
                float y = PlayerPrefs.GetFloat("PlayerPositionY");
                float z = PlayerPrefs.GetFloat("PlayerPositionZ");
                Vector3 savedPlayerPosition = new Vector3(x, y, z);

                LoadPlayer(savedPlayerPosition);
            }
            else
            {
                // Dacă nu avem o poziție salvată, îl încărcăm la punctul de spawn
                LoadPlayer(GetSpawnPointPosition());
            }
        }
    }

    private void LoadPlayer(Vector3 position)
    {
        // Distrugem jucătorul anterior, dacă există
        if (playerInstance != null)
        {
            Destroy(playerInstance);
        }

        // Spawnează un nou jucător la poziția specificată
        playerInstance = Instantiate(playerPrefab, position, Quaternion.identity);
    }

    public void SavePlayerPosition(Vector3 position)
    {
        PlayerPrefs.SetFloat("PlayerPositionX", position.x);
        PlayerPrefs.SetFloat("PlayerPositionY", position.y);
        PlayerPrefs.SetFloat("PlayerPositionZ", position.z);
        PlayerPrefs.Save();
    }

    public void ReloadScene()
    {
        // Distrugem jucătorul anterior, dacă există
        if (playerInstance != null)
        {
            Destroy(playerInstance);
        }

        // Reîncărcăm scena
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    public Vector3 GetSpawnPointPosition()
    {
        if (spawnPoint != null)
        {
            return spawnPoint.position;
        }
        else
        {
            Debug.LogError("Punctul de spawn nu este setat în GameManager!");
            return Vector3.zero;
        }
    }

    public GameObject GetPlayerInstance()
    {
        return playerInstance;
    }
}
