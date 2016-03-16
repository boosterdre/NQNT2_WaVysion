using UnityEngine;
using System.Collections;

public class ExplosionSpell : MonoBehaviour
{

    public GameObject colliderTime;
    private PlayerControl playerstats;
    float cpt = 3.0f;

    void Start()
    {
        colliderTime.SetActive(false);
        playerstats = GameObject.Find("Health").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            StartCoroutine(Appear());
            /*Debug.Log("it works");
            Spell.SetActive(true);
            Appear();
            Spell.SetActive(false);*/
        }
    }
    IEnumerator Appear()
    {

        colliderTime.SetActive(true);
        yield return new WaitForSeconds(4);
        colliderTime.SetActive(false);


    }
}
