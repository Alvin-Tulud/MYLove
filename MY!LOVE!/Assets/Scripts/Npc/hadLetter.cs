using System.Collections;
using UnityEngine;

public class hadLetter : MonoBehaviour
{
    public bool hasLetter = false;
    private bool cantake;
    private ParticleSystem ps;

    private void Start()
    {
        cantake = !hasLetter;
        ps = GetComponent<ParticleSystem>();
        if (cantake)
        {
            ps.Play();
        }
        else
        {
            ps.Stop();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasLetter && cantake)
        {
            if (collision.transform.CompareTag("Player"))
            {
                if (collision.transform.childCount == 2)
                {
                    Destroy(collision.transform.GetChild(1).gameObject);

                    cantake = false;

                    ps.Stop();

                    StartCoroutine(destroyNPC());
                }
            }
        }
    }

    IEnumerator destroyNPC()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }
}
