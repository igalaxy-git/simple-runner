using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerFails : MonoBehaviour {
    private Rigidbody rb;
    void Start() {
        rb = GetComponent<Rigidbody> ();
    }
    void Update() {
        RaycastHit hit;
        if(Physics.Raycast (transform.position, Vector3.down, out hit, 5f) && hit.transform.gameObject.tag == "Ground") {
            rb.AddForce(-Vector3.up * 0);
        } else {
            rb.AddForce(-Vector3.up * 50);
        }
    }
}