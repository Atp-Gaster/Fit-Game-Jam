using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class senddata : MonoBehaviour
{
    public static List<int> CharacterList = new List<int>();
    // Update is called once per frame
    public List<int> ShowList;
    private void Update()
    {
        ShowList = CharacterList;
    }
    

    public List<int> getList ()
    {
        return CharacterList;
    }
}
