using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeList : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] ListPlayer;
    public static int currentPlayer =0;

    public void nextPlayer()
    {
        currentPlayer = (currentPlayer + 1);
        ListPlayer[currentPlayer].SetActive(true);
    }
}
