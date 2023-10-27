using UnityEngine;

public class BallCollisionSound : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Check if the AudioSource component is properly assigned.
        if (audioSource == null)
        {
            Debug.LogError("AudioSource is not found on the GameObject.");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision has a relative velocity above a certain threshold to avoid playing the sound on very gentle impacts.
        if (audioSource != null && collision.relativeVelocity.magnitude > 0.1f)
        {
            audioSource.Play();
        }
    }
}