using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool hasFlag;
    public bool placedFlag;

    // Start is called before the first frame update
    void Start()
    {
        hasFlag = false;
        hasFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(placedFlag)
        {
            WinGame();
        }

    }

    public void PlaceFlag()
    {
        placedFlag = true;
        Debug.Log("The Flag has been placed at home base!");
    }

    public void WinGame()
    {
        Debug.Log("You have won the game!");
        Time.timeScale = 0; //Freeze time at end
    }
}
