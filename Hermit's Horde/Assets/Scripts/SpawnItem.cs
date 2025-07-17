using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    [SerializeField] private ItemSO item = null;

    void Start()
    {
        SpawnTheItem();
    }

    void SpawnTheItem()
    {
        Instantiate(item.prefab, transform.position, transform.rotation);
    }
}
