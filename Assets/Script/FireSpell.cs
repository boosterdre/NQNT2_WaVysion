using UnityEngine;
using System.Collections;

public class FireSpell : MonoBehaviour {

    public GameObject colliderFlame;
    private PlayerControl playerstats;
    float cpt = 3.0f;
    
	void Start ()
    {
        colliderFlame.SetActive(false);
        playerstats = GameObject.Find("Health").GetComponent<PlayerControl>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("f"))
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

        colliderFlame.SetActive(true);
        yield return new WaitForSeconds(2);
        colliderFlame.SetActive(false);

        
    }
}
