
using UnityEngine;
// Camera movement that follows the player

public class CameraMovement : MonoBehaviour   {

    public Transform target;
    public float smoothSpeed = 0.125f;
    private Vector3 velocity = Vector3.zero;
    public Vector3 offSet;

    // Variables for h/v movement
   /** public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
   */

    // Camera movement following the player
    void LateUpdate() {
        Vector3 desiredPosition = target.position + offSet;
        Vector3 smoothPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);

        transform.position = smoothPosition;
        
        // For the camera to always look at the player
        transform.LookAt(target);
    }

    // Camera movement horizontally and vertically
    /**
    void Update() {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
    */
}
