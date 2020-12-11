using System.Collections.Generic;
using UnityEngine;

public class SquatCounterEffect : MonoBehaviour
{
    [SerializeField] private GameObject unchi;

    private List<GameObject> unchiList = new List<GameObject>();

    public void GenerateUnchi()
    {
        GameObject _unchi = Instantiate(unchi, transform.position, Quaternion.identity);
        _unchi.transform.parent = transform;
        unchiList.Add(_unchi);
    }
}