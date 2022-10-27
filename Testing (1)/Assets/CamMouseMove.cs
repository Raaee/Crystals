using UnityEngine;
// Camera movement with mouse

public class CamMouseMove : MonoBehaviour   {

    float moveSpeed = 10.0f;
   
    void Update() {

        if (Input.GetAxis("Mouse X") > 0) {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * moveSpeed,
                0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * moveSpeed);
        }
        else if (Input.GetAxis("Mouse X") < 0) {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * moveSpeed,
                0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * moveSpeed);
        }
    }    
}
