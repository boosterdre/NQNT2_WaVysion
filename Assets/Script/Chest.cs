using UnityEngine;
using System.Collections;

public class Chest : MonoBehaviour {

    private static PlayerControl playerStats;
    //public GameObject chest;
    public GameObject particules;
    private bool is_open = false;
    private bool showGUI = false;
    public Animation animation;
    float cpt = 5.0f;
    public string chestName = "";
    public int amount = 0;
	// Use this for initialization
	void Start ()
    {
        //playerStats = gameObject.Find("Health").GetComponent(PlayerStats);
        animation = GetComponent<Animation>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (showGUI)
        {
            if (Input.GetKeyDown("e") && is_open == false)
            {
                PlayerControl.money += amount;
                is_open = true;
                Instantiate(particules, transform.position, transform.rotation);
                Destroy(this.gameObject);
                //animation.Play("chest_anim");
                

            }
        }
        /*if (is_open)
        {
            if (cpt < 0)
            {
                Destroy(this.gameObject);
            }
            else
            {
                cpt -= Time.deltaTime;
            }
        }*/

	}
    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            showGUI = true;
        }
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            showGUI = false;
        }
    }
    void OnGUI()
    {
        if (showGUI && is_open == false)
        {
            GUI.BeginGroup(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 12, 300, 300));
            GUI.Box(new Rect(0, 0, 100, 25), "Press E to open");
            GUI.EndGroup();
        }
    }
}
