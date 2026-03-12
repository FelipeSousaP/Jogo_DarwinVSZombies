using UnityEngine;

public class ZombieController : MonoBehaviour
{
    [SerializeField] float spped;
    [SerializeField] GameObject Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,Player.transform.position,spped * Time.deltaTime);
    }
}
