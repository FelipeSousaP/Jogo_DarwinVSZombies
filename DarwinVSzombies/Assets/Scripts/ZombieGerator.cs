using UnityEngine;

public class ZombieGerator : MonoBehaviour
{
    objectPool<GameObject> pool = new objectPool<GameObject>();

    [SerializeField] Transform[] Spawn;
    [SerializeField] Transform Armazem;
    [SerializeField] GameObject Zombie;
    [SerializeField] int index;
    [SerializeField] int QuantidadedeZombie;
    int Aleatório() => index = Random.Range(1, Spawn.Length);
    private void Start()
    {
        for (int i = 0; i < QuantidadedeZombie; i++)
        {
            GameObject g = Instantiate(Zombie, Spawn[Aleatório()].position, Quaternion.identity, Armazem.transform);
            g.SetActive(false);
            pool.SetPool(g);
        }
    }
    private void Update()
    {
        GameObject g = pool.TryGetPool(); // onde está o erro
        if (g != null) 
        {   
            int d = Aleatório();
            g.transform.position = Spawn[d].position;
            g.SetActive(true);
        }
    }
}
