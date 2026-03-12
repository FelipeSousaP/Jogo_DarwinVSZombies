using UnityEngine;

public class GameSystem : MonoBehaviour
{
    [SerializeField] int Life;
    [SerializeField] int MaxLife = 3;
    [SerializeField] float Timer;
    [SerializeField] float TimeToWin = 50.0f;
    [SerializeField] ScreenAccess screenAccess;
    private void Start()
    {
        Life = MaxLife;
    }

    private void Update()
    {
        Timer += Time.deltaTime;
        if (Timer <= TimeToWin) 
        {
            screenAccess._TelaDeVitória();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<ZombieController>(out ZombieController zg))
        {
            Life -= 1;
            if(Life <= 0) { screenAccess._TelaDeDerrota(); }
        }
    }
}
