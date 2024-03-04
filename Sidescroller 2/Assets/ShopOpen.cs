using UnityEngine;

public class ShopOpen : MonoBehaviour
{
    public GameObject menuCanvas; // Referință către canvas-ul meniului
    public KeyCode openMenuKey = KeyCode.E; // Tasta pentru deschiderea meniului

    void Update()
    {
        // Verificăm dacă tasta pentru deschiderea meniului a fost apăsată
        if (Input.GetKeyDown(openMenuKey))
        {
            // Verificăm dacă canvas-ul meniului este activat sau dezactivat și inversăm starea
            if (menuCanvas.activeSelf)
            {
                menuCanvas.SetActive(false); // Dezactivăm canvas-ul
            }
            else
            {
                menuCanvas.SetActive(true); // Activăm canvas-ul
            }
        }
    }
}
