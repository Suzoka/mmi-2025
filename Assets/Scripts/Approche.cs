using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Approche : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == PLAYER_TAG)
        {
            Debug.Log("Approche");
            
        }
    }
}
