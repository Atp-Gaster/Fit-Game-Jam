using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    // Start is called before the first frame update

    public Image OldImage;
    public Sprite[] Screen;
    public int current_Screen_Index = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ImageChange();
        }
    }

    public void ImageChange()
    {
        if (current_Screen_Index < Screen.Length)
        {
            OldImage.sprite = Screen[current_Screen_Index];
            current_Screen_Index += 1;
        }
        
    }

}
