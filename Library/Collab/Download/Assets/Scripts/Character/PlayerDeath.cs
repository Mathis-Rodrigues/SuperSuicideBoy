using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public GameObject prefabBlood;
    private GameObject player;

    public void killPlayer()
    {
        StartCoroutine(killPlayerAndReload());
    }

    IEnumerator killPlayerAndReload()
    {
        player = GameObject.FindWithTag("Player");
        GameObject bloodSpray = Instantiate(prefabBlood, player.transform.position, player.transform.rotation);
        Destroy(bloodSpray, 3f);
        Destroy(player);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
