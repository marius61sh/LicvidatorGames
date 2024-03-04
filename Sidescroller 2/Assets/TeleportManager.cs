using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    private static Vector3 teleportPosition;

    public static Vector3 GetTeleportPosition()
    {
        return teleportPosition;
    }

    public static void SetTeleportPosition(Vector3 position)
    {
        teleportPosition = position;
    }
}
