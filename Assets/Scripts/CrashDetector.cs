using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            Debug.Log("Crash detected!");
        }
    }
}
