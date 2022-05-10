using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    //private float nextSpawnTime;

    //[SerializeField]
    //private GameObject itemPrefab;
    //[SerializeField]
    //private float spawnDelay = 1;


    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (ShouldSpawn())
    //    {
    //        Spawn();
    //    }
    //}

    //private Item item;
    //private MeshRenderer meshRenderer;
    //private void Spawn()
    //{
    //    Vector3 position = new Vector3(Random.Range(-33F,33F), 1, Random.Range(-33F, 33F));
    //    nextSpawnTime = Time.time + spawnDelay;
    //    GameObject newObject = Instantiate(itemPrefab, position, transform.rotation * Quaternion.Euler(90, 0, 0));
    //    newObject.transform.localScale = new Vector3(6, 6, 6);
    //    SetItem(newObject);
    //}

    //private bool ShouldSpawn()
    //{
    //    return Time.time >= nextSpawnTime;
    //}

    //public void SetItem(Item item)
    //{
    //    this.item = item;

    //}

    //public ItemSpawner GetItem()
    //{
    //    return item;
    //}

    //public void DestroySelf()
    //{
    //    Destroy(item);
    //}
}
