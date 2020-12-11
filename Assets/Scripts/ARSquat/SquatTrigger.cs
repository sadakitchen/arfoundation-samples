using UnityEngine;

public class SquatTrigger : MonoBehaviour
{
    [SerializeField] private SquatCounterEffect squatCounterEffect;

    //OnTriggerEnter関数
    void OnTriggerEnter(Collider other)
    {
        //接触したオブジェクトのタグが"Squat"のとき
        if (other.CompareTag("Squat"))
        {
            Debug.Log("Enter");
            GetComponent<Renderer>().material.color = Color.blue;
            GameManager.instance.CountUp();
            squatCounterEffect.GenerateUnchi();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Squat"))
        {
            Debug.Log("Exit");
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}