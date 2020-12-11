using UnityEngine;

public class UnchiLifecycle : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.localPosition.y < -200)
        {
            Destroy(gameObject);
        }
    }
}