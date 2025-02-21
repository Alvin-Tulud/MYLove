using Pathfinding;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using UnityEngine;

public class npcMove : MonoBehaviour
{
    private AIDestinationSetter set;
    private GameObject[] nav;

    private bool getDes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        set = GetComponent<AIDestinationSetter>();
        nav = GameObject.FindGameObjectsWithTag("Spawner");

        getDes = true;
    }

    IEnumerator findDes()
    {
        if (getDes)
        {
            getDes = false;

            int randDes = Random.Range(0, nav.Length);

            set.target = nav[randDes].transform;

            yield return new WaitForSeconds(7);

            getDes = true;
        }
    }
}
