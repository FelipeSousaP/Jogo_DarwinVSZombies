using Unity.Mathematics.Geometry;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    [Tooltip("Responsavel por cdeixar a sprite peperticular ao cursor do mouse")]
    [SerializeField] float ProximadordoCursor;
    void Update()
    {
        Vector2 mousepos = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousepos.x, mousepos.y) * Mathf.Rad2Deg;
        //deg2Rad mudar de graus para radiano
        //Atan2: calcular o angulo encontrana na posição especifica
        transform.rotation = Quaternion.AngleAxis(angle - ProximadordoCursor,Vector3.back);
        //criando a rotação em volta do eixo, o eixo está em Vector3
    }
}
