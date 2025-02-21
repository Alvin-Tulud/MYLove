using System.Collections;
using UnityEngine;

public class letterGrabber : MonoBehaviour
{
    private GameObject parent;

    private void Start()
    {
        parent = transform.parent.gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("hitplaywr" + collision.transform.childCount);
            if (collision.transform.childCount == 1)
            {
                Debug.Log("cantake");
                transform.SetParent(collision.transform);

                StartCoroutine(destroyNPC());
            }
        }
    }

    IEnumerator destroyNPC()
    {
        yield return new WaitForSeconds(5);
        Destroy(parent);
    }
}
