using UnityEngine;

public class Key : MonoBehaviour
{
    AudioSource audioSource;
    KeyManager keyManager;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        keyManager = GameObject.Find("KeyManager").GetComponent<KeyManager>();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            SoundManager.playKeySound();
            keyManager.AddKey();
            Destroy(transform.parent.gameObject);
        }
    }
}
