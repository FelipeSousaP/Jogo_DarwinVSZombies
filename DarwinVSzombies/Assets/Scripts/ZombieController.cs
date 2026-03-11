using UnityEngine;

public class ZombieController : MonoBehaviour
{
    [SerializeField] float spped;
    void Update()
    {
        transform.Translate(new Vector3(0,0,0) * spped * Time.deltaTime);       
    }
}
