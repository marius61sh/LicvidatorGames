using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            // Salvează poziția jucătorului când întâlnește un checkpoint
            if (gameManager != null)
            {
                gameManager.SavePlayerPosition(transform.position);
            }
        }
    }

    private void OnDestroy()
    {
        // Salvează poziția jucătorului când iese din scenă
        if (gameManager != null)
        {
            gameManager.SavePlayerPosition(transform.position);
        }
    }
}
