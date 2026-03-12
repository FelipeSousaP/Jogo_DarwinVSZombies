using UnityEngine;

public class GameSystem : MonoBehaviour
{
    [SerializeField] int Life;
    [SerializeField] int MaxLife = 3;

    private void Start()
    {
        Life = MaxLife;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScreenAccess screenAccess = GetComponent<ScreenAccess>();
        if (collision.CompareTag("Carro"))
        {
            screenAccess._TelaDeVitória();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScreenAccess screenAccess = GetComponent<ScreenAccess>();
        if(collision.gameObject.TryGetComponent<ZombieGerator>(out ZombieGerator zg))
        {
            Life -= 1;
            if(Life == 0) { screenAccess._TelaDeDerrota(); }
        }
    }
}
