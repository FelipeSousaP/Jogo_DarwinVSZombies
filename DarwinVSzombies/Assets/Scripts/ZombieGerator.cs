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
            index = Random.Range(0, Spawn.Length);

            if (Spawn[index] != null)
            {
                g.transform.position = Spawn[index].position;
                g.SetActive(true);
            }
        }
    }
}
