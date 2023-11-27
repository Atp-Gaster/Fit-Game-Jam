
using UnityEngine;

public class ScreenChangerScripe : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FadeToScreen(1);
        }
    }

    public void FadeToScreen(int ScreenIndex)
    {
        animator.SetTrigger("FadeOut");
    }

    public void OnfadeComplete() { 
    }
}
