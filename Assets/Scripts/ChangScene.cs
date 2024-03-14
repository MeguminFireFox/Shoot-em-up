using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string Scene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Balle1 balle1 = collision.GetComponent<Balle1>();
        Balle2 balle2 = collision.GetComponent<Balle2>();
        Balle3 balle3 = collision.GetComponent<Balle3>();

        if (balle1 != null)
        {
            SceneManager.LoadScene(Scene);
            Destroy(balle1.gameObject);
        }
        if (balle2 != null)
        {
            SceneManager.LoadScene(Scene);
            Destroy(balle2.gameObject);
        }
        if (balle3 != null)
        {
            SceneManager.LoadScene(Scene);
            Destroy(balle3.gameObject);
        }
    }
}
