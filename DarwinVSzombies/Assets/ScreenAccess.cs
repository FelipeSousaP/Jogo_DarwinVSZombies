using UnityEngine;

public class ScreenAccess : MonoBehaviour
{
    [SerializeField] CanvasGroup telaincial; 
    [SerializeField] CanvasGroup telaDerrota; 
    [SerializeField] CanvasGroup telavitória; 
    [SerializeField] CanvasGroup telajogo; 
    public void _Telainicial()
    {
        UIManeger.Instance.Show(telaincial);
        UIManeger.Instance.Hide(telavitória);
        UIManeger.Instance.Hide(telaDerrota);
        UIManeger.Instance.Hide(telajogo);
    }

    public void _TeladoJogo()
    {
        UIManeger.Instance.Show(telajogo);
        UIManeger.Instance.Hide(telavitória);
        UIManeger.Instance.Hide(telaDerrota);
        UIManeger.Instance.Hide(telaincial);
    }

    public void _TelaDeDerrota()
    {
        UIManeger.Instance.Show(telaDerrota);
        UIManeger.Instance.Hide(telavitória);
        UIManeger.Instance.Hide(telajogo);
        UIManeger.Instance.Hide(telaincial);
    }

    public void _TelaDeVitória()
    {
        UIManeger.Instance.Show(telavitória);
        UIManeger.Instance.Hide(telaDerrota);
        UIManeger.Instance.Hide(telajogo);
        UIManeger.Instance.Hide(telaincial);
    }

    public void Quit() { Application.Quit();}
}
