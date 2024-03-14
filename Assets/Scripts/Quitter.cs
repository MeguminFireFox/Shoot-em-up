using UnityEngine;

public class Quitter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Balle1 balle1 = collision.GetComponent<Balle1>();
        Balle2 balle2 = collision.GetComponent<Balle2>();
        Balle3 balle3 = collision.GetComponent<Balle3>();

        if (balle1 != null)
        {
            Application.Quit();
            Destroy(balle1.gameObject);
        }
        if (balle2 != null)
        {
            Application.Quit();
            Destroy(balle2.gameObject);
        }
        if (balle3 != null)
        {
            Application.Quit();
            Destroy(balle3.gameObject);
        }
    }
}
