using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    objectPool<GameObject> pool;

    public void SetBala(objectPool<GameObject> _pool)
    {
        pool = _pool;
    }

    private void OnEnable()
    {
        rb.linearVelocity = Vector2.zero; //aparentemetne sempre ficar adicionando mais velocidade a cada tiro, ent]ao isso vai parar esse fenomeno.
        rb.linearDamping = 0;
        rb.AddForce(transform.up * speed, ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("parede"))
        {
            Debug.Log("acertou;");
            pool.SetPool(gameObject);
            gameObject.SetActive(false);
        }
    }
}
