using UnityEngine;
using System.Collections;

public class TimeSpell : MonoBehaviour
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
        if (Input.GetKeyDown("t"))
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
        yield return new WaitForSeconds(1);
        colliderTime.SetActive(false);


    }
}
