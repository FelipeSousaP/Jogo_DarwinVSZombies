using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    void Start()
    {
        audioSource.Play();
    }
}
