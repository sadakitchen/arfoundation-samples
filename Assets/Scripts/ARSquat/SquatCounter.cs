using TMPro;
using UnityEngine;

public class SquatCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterText;

    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.CountClear();
        count = GameManager.instance.Score;
        counterText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        count = GameManager.instance.Score;
        if (count == 0)
        {
            counterText.text = "";
        }
        else
        {
            counterText.text = count + "!";
        }
    }
}