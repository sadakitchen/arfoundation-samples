using DG.Tweening;
using UnityEngine;

public class CounterTextEffect : MonoBehaviour
{
    [SerializeField] private float startScale = 1.5f;
    private Vector3 initScale;

    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
        initScale = gameObject.transform.localScale;
    }

    public void InAnimation()
    {
        transform.localScale = new Vector3(initScale.x * startScale, initScale.y * startScale, 1.0f);
        transform.DOScale(initScale, 0.2f).SetEase(Ease.OutQuart);
    }
}