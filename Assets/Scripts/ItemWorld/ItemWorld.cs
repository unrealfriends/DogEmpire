using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWorld : MonoBehaviour
{
    //private Item item;
    //private float nextSpawnTime;

    //[SerializeField]
    //private GameObject itemPrefab;
    //[SerializeField]
    //private float spawnDelay = 1;


    //// items random spawnen
    //private void Spawn()
    //{
    //    Vector3 position = new Vector3(Random.Range(-33F, 33F), 1, Random.Range(-33F, 33F));
    //    nextSpawnTime = Time.time + spawnDelay;
    //    GameObject newObject = Instantiate(itemPrefab, position, transform.rotation * Quaternion.Euler(90, 0, 0));
    //    newObject.transform.localScale = new Vector3(6, 6, 6);
    //    SetItem(newObject);
    //}

    //private bool ShouldSpawn()
    //{
    //    return Time.time >= nextSpawnTime;
    //}

    ////private MeshFilter meshFilter;
    //private void Awake()
    //{
    //    //meshRenderer = GetComponent<MeshRenderer>();
    //}

    //private void Update()
    //{
    //    if (ShouldSpawn())
    //    {
    //        Spawn();
    //    }
    //}

    //public void SetItem(Item item)
    //{
    //    this.item = item;

    //}

    //public ItemWorld GetItem()
    //{
    //    return item;
    //}

    //public void DestroySelf()
    //{
    //    Destroy(item);
    //}

}
