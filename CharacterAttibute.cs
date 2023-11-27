using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterAttibute : MonoBehaviour
{
    public GameObject[] Characters;
    public GameObject current;
    public Transform spawn;
    public int selectCha = 0;

    public void NextCharacter()
    {
        
        Characters[selectCha].SetActive(false);
        selectCha = (selectCha + 1) % Characters.Length;
        Characters[selectCha].SetActive(true);
    }

    public void PreviousCharacter()
    {
        
        Characters[selectCha].SetActive(false);
        selectCha--;
        if (selectCha < 0)
        {
            selectCha += Characters.Length;
        }
       
        Characters[selectCha].SetActive(true);
    }


    public void sendDat()
    {
        senddata.CharacterList.Add(selectCha);
    }
}
