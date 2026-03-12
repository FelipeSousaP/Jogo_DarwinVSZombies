using TMPro;
using UnityEngine;

public class IconManeger : MonoBehaviour
{
    static IconManeger _instance;
    private void Awake() { if (_instance == null) { _instance = this; } }
    public static IconManeger Instance => _instance;
    [Header("textos nos icones")]
    public TMP_Text Life;
    public TMP_Text Bullet;
    public TMP_Text Timer;

    public void UpdateUILife(int _life)
    {
        Life.text = $"{_life}";
    }
    public void UpdateUIBullet(int _bullet)
    {
        Bullet.text = $"{_bullet}";
    }
    public void UpdateUITimer(float _timer)
    {
        Timer.text = $" Sobreviva por 60 segundos\n Tempo atual: {_timer.ToString("F2")}";
    }
}
