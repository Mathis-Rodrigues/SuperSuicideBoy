using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource click;
    public AudioSource level;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void playClickSound()
    {
        click.Play();
    }

    public static void playKeySound()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>().Play();
    }

    public void playLevelSound() {
        level.Play();
    }
}
