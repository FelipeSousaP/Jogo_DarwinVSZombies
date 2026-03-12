using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] Transform Player;
    void Update()
    {
        transform.position = new Vector3(Player.position.x, Player.position.y, Player.position.z - 10);        
    }
}
