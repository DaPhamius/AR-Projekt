using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageFade : MonoBehaviour
{

    // the image you want to fade, assign in inspector
    public Image img;

    public void Start()
    {
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(FadeImage(true));

        }
    }


    public IEnumerator FadeImage(bool fadeAway)
    {
        
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second
            for (float i = 0; i <= 1f; i += Time.deltaTime)
            {
                // set color with i as alpha
                img.color = new Color(1, 1, 1, i);
                yield return null;
            }
            for (float i = 1.5f; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                img.color = new Color(1, 1, 1, i);
                yield return null;
            }

        }
        else
        {
            for (float i = 0; i <= 1f; i += Time.deltaTime)
            {
                // set color with i as alpha
                img.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }

    }
}
