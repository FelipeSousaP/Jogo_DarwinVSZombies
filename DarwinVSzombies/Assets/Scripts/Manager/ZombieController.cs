using UnityEngine;

public class ZombieController : MonoBehaviour
{
    [SerializeField] float spped;
    [SerializeField] GameObject Player;
    objectPool<GameObject> pool;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    
    public void Setzombie(objectPool<GameObject> _pool)
    {
        pool = _pool;
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,Player.transform.position,spped * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<Bala>(out Bala bala))
        {
            pool.SetPool(gameObject);
            gameObject.SetActive(false);
        }
    }
}
