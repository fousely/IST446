using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float panSpeed = 20f;
    public float scrollSpeed = 5f;
    public bool freeCamera = true;

    public float miny = 10f;
    public float maxy = 50f;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.L))
            freeCamera = !freeCamera;
        if (!freeCamera)
            return;

        if (Input.GetKey("w")/* || Input.mousePosition.y >= Screen.height - 10f*/) {
            if ((transform.position + (Vector3.forward * panSpeed * Time.deltaTime)).z < 20f)
                transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("s")/* || Input.mousePosition.y <= 10f*/) {
            if ((transform.position + (Vector3.forward * panSpeed * Time.deltaTime)).z > -21f)
                transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("a")/* || Input.mousePosition.x <= 10f*/) {
            if ((transform.position + (Vector3.left * panSpeed * Time.deltaTime)).x > -30f)
                transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d")/* || Input.mousePosition.x >= Screen.width - 10f*/) {
            if ((transform.position + (Vector3.left * panSpeed * Time.deltaTime)).x < 10f)
                transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }

        float scrollInfo = Input.GetAxis("Mouse ScrollWheel");
        Vector3 pos = transform.position;
        pos.y -= scrollInfo * 1000 * scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, miny, maxy);
        transform.position = pos;
    }
}
