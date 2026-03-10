using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    objectPool<GameObject> pool = new objectPool<GameObject>();
    void Update()
    {
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
