using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;
    private int score;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CountUp()
    {
        Debug.Log("CountUp!");
        score++;
    }

    public void CountClear()
    {
        Debug.Log("CountClear!");
        score = 0;
    }
}