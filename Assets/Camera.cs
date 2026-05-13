using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public float distance = 5f;
    public float height = 2f;
    public float mouseSensitivity = 100f;

    float mouseX = 0f;
    float mouseY = 20f;

    void LateUpdate()
    {
        // Mouse Input
        mouseX += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Limit Up/Down Rotation
        mouseY = Mathf.Clamp(mouseY, -20f, 60f);

        // Camera Rotation
        Quaternion rotation = Quaternion.Euler(mouseY, mouseX, 0);

        // Camera Position
        Vector3 offset = rotation * new Vector3(0, height, -distance);

        transform.position = player.position + offset;

        // Look at Player
        transform.LookAt(player.position + Vector3.up * 1.5f);

        // Zoom
        distance -= Input.GetAxis("Mouse ScrollWheel") * 2f;

        distance = Mathf.Clamp(distance, 2f, 10f);
    }
}
