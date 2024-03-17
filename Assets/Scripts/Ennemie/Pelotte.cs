using UnityEngine;

public class Pelotte : MonoBehaviour
{
    public float HP = 3;
    public GameObject Explos;
    public float Degat = 1;

    private float _speed = 4;
    private float _time = 0;

    void Start()
    {
        this.GetComponent<Renderer>().material.color = Color.HSVToRGB (Random.Range(0.1f,1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
    }

    void FixedUpdate()
    {
        _time += Time.deltaTime;
        transform.Translate(Vector2.left * _speed * Time.deltaTime);

        if (HP <= 0)
        {
            Destroy(gameObject);
        }

        if (_time >= 20)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Balle1 balle1 = collision.GetComponent<Balle1>();
        Balle2 balle2 = collision.GetComponent<Balle2>();
        Balle3 balle3 = collision.GetComponent<Balle3>();
        Explosion explosion = collision.GetComponent<Explosion>();

        if (balle1 != null)
        {
            HP -= balle1.dammage;
            Destroy(balle1.gameObject);
        }
        if (balle2 != null)
        {
            HP -= balle2.dammage;
            Destroy(balle2.gameObject);
        }
        if (balle3 != null)
        {
            HP -= balle3.dammage;
            GameObject go = Instantiate(Explos, transform.position, transform.rotation);
            Destroy(balle3.gameObject);
        }
        if (explosion != null)
        {
            HP -= explosion.dammage;
        }
    }
}
