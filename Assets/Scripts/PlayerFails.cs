using UnityEngine;

public class PlayerFails : MonoBehaviour {
    private Rigidbody rb;
    public GameObject cameraObj;
    public GameObject menu;
    void Start() {
        rb = GetComponent<Rigidbody> ();
    }
    
    void Update() {
        RaycastHit hit;
        if(Physics.Raycast (transform.position, Vector3.down, out hit, 5f) && hit.transform.gameObject.tag == "Ground") {
            rb.AddForce(-Vector3.up * 0);
        } else {
            rb.AddForce(-Vector3.up * 50);
            RoadController.stopInvoking = true;
            cameraObj.GetComponent<CameraController>().enabled = false;
            menu.SetActive(true);
        }
    }
}