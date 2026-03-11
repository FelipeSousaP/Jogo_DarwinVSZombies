using UnityEngine;
using UnityEngine.InputSystem;

public class Arma : MonoBehaviour
{
    [Header("Configurações da arma")]
    [SerializeField] GameObject Cartucho;
    [SerializeField] GameObject Disparador;
    [SerializeField] GameObject BalaPrefab;
    [SerializeField] int QuantidadeDeBala;
    [SerializeField] float timer;
    [SerializeField] float timerFinal = 3;

    [Header("Comando")]
    [SerializeField] InputActionReference ShootAction;
    [SerializeField] bool Atirando;

    objectPool<GameObject> pool = new objectPool<GameObject>();
    void Start()
    {
        for (int i = 0; i < QuantidadeDeBala; ++i) 
        {
            GameObject bala = Instantiate(BalaPrefab, Disparador.transform.position, Quaternion.identity,Cartucho.transform);
            bala.SetActive(false);
            pool.SetPool(bala);
        }
    }

    public void OnEnable()
    {
        if(ShootAction != null)
        {
            ShootAction.action.performed += Shoot;
            ShootAction.action.canceled += Shoot;
        }
    }
    public void OnDisable()
    {
        ShootAction.action.performed -= Shoot;   
        ShootAction.action.canceled -= Shoot;   
    }
    void Shoot(InputAction.CallbackContext callbackContext)
    {
        Atirando = callbackContext.ReadValueAsButton();// tipo um readvalue so que bool
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (Atirando && timer >= timerFinal) 
        {
            atirar();
        }
    }
    void atirar()
    {
        GameObject g = pool.TryGetPool();
        if (g != null)
        {
            //impede que vira foguete
            g.transform.position = Disparador.transform.position;
            g.transform.rotation = Disparador.transform.rotation;// o FDP tava indo pra casa do caralho
            
            if(g.TryGetComponent<Bala>(out Bala bala))
            {
                //tentando encontrar o objeto com o componente bala
                bala.SetBala(pool);
            }
            
            g.SetActive(true);
            timer = 0; // Controlando quantidades de tiros
            Atirando = false; // evitando loops
        }
    }
}
