using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class SpawnNPC : MonoBehaviour
{
    private List<Transform> spawner = new List<Transform>();

    public List<GameObject> NPCS = new List<GameObject>();

    private bool canSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            spawner.Add(transform.GetChild(i));
        }

        canSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        if (canSpawn)
        {
            canSpawn = false;

            yield return new WaitForSeconds(2);

            int randNPC = Random.Range(0, NPCS.Count);
            int randSpawn = Random.Range(0, spawner.Count);

            GameObject g;
            g = Instantiate(NPCS[randNPC],spawner[randSpawn]);
            g.transform.SetParent(null);

            canSpawn = true;
        }
    }
}
