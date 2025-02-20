using UnityEngine;

public class letterGrabber : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("hitplaywr" + collision.transform.childCount);
            if (collision.transform.childCount == 1)
            {
                Debug.Log("cantake");
                transform.SetParent(collision.transform);
            }
        }
    }
}
