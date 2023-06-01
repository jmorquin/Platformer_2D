using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class LoadSpecificScene : MonoBehaviour

{
    public string sceneName;
    public Animator fadeSystem;
    private Transform PlayerSpawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.CompareTag("Player"))
        {
            StartCoroutine(loadNextScene());
            fadeSystem.SetBool("FadeIn", true);
            fadeSystem.SetBool("respawn", false);
        }
    }

    private IEnumerator loadNextScene()
    {

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
        fadeSystem.SetBool("respawn", true);
        fadeSystem.SetBool("FadeIn", false);
    }
}
