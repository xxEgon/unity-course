using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        float x, z;
		GameObject copy;
        for (int i = 1; i <= 12; i++)
        {
            x = 10 * Mathf.Sin(i*(2*Mathf.PI/12));
            z = 10 * Mathf.Cos(i*(2*Mathf.PI/12));
			copy = Instantiate(player, new Vector3(x, 0, z), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
	
}
