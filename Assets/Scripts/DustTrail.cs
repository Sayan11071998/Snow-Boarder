using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] private ParticleSystem dustParticles;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dustParticles.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dustParticles.Stop();
        }
    }
}