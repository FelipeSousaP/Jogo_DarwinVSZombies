using UnityEngine;
using UnityEngine.InputSystem;

public class Moviment : MonoBehaviour
{
    [SerializeField] InputActionReference MoveAction;
    [SerializeField] Transform Player;
    [SerializeField] float Speed;
    Vector2 dir;

    private void OnEnable()
    {
        if(MoveAction != null)
        {
            MoveAction.action.performed += Move;
            MoveAction.action.canceled += Move;
        }
    }
    private void OnDisable()
    {
        MoveAction.action.performed -= Move;
        MoveAction.action.canceled -= Move;
    }

    void Move(InputAction.CallbackContext callbackContext)
    {
        dir = callbackContext.ReadValue<Vector2>();
    }

    void Update()
    {
        Player.Translate(new Vector3(dir.x, dir.y,0) * Speed * Time.deltaTime);
    }
}
