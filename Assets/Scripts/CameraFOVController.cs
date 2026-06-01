using UnityEngine;

public class CameraFOVController : MonoBehaviour
{
    public Camera mainCamera;

    public void SetFOV(float fov)
    {
        mainCamera.fieldOfView = 120f - fov;
    }
}