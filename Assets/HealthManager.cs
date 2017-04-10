using System.Collections;
using UnityEngine;

public class HealthManager : MonoBehaviour {

    public GameObject[] hearts;
    private int health;

	// Use this for initialization
	void Start () {
        health = hearts.Length;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "enemybull")
        {
            health = health - 1;
            hearts[health].SetActive(false);

            if (health == 0)
            {
                Destroy(gameObject);
                Application.LoadLevel(0);
            }
        }
    }
   
}
