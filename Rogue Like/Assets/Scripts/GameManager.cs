using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int key;
    public int amount; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddKey(int amount)
   {
        
        key += amount; //Add keys to the inventory
        Debug.Log("You have "+ key +" keys");
   }
}
