using UnityEngine;

public class CrystalScript : MonoBehaviour
{
    public GameObject crystal;
    void OnCollisionEnter(Collision col)
    {
        Destroy(crystal);
        ScoreScript.scoreValue += 100;
    }
}
