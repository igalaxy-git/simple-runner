using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = -5.0f;
    private bool notClicked = true;
    private bool isMovingRight = false;
    public GameObject road;
    public GameObject text;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!notClicked)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isMovingRight = !isMovingRight;
            }

            if (isMovingRight)
            {
                rb.velocity = new Vector3(speed, 0f, 0f);
            }
            else
            {
                rb.velocity = new Vector3(0f, 0f, speed);
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                notClicked = false;
                road.GetComponent<RoadController>().enabled = true;
                isMovingRight = !isMovingRight;
                text.SetActive(false);
            }
        }
    }
}
