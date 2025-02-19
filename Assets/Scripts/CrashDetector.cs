using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float loadDealy = 0.5f;
    [SerializeField] private ParticleSystem crashEffect;
    [SerializeField] private AudioClip crashSFX;

    private bool hasCrashed = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDealy);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}