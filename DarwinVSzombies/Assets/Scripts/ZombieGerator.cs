using UnityEngine;

public class ZombieGerator : MonoBehaviour
{
    objectPool<GameObject> pool = new objectPool<GameObject>();

    [SerializeField] Transform[] Spawn;
    [SerializeField] Transform Armazem;
    [SerializeField] GameObject Zombie;
    [SerializeField] int index;
    [SerializeField] int QuantidadedeZombie;

    private void Start()
    {
        for (int i = 0; i < QuantidadedeZombie; i++)
        {
            GameObject g = Instantiate(Zombie,Armazem); // não preciso definir ponto de geração aqui
            g.SetActive(false);
            pool.SetPool(g);
        }
    }
    private void Update()
    {
        GameObject g = pool.TryGetPool();

        if (g != null)
        {
            int index = Random.Range(0, Spawn.Length);

            if (Spawn[index] != null)
            {
                g.transform.position = Spawn[index].position;

                // Re-garante que o zumbi sabe qual é a pool dele antes de ativar
                ZombieController controller = g.GetComponent<ZombieController>();
                if (controller != null)
                {
                    controller.Setzombie(pool);
                }

                g.SetActive(true);
            }
        }
    }
}
    

