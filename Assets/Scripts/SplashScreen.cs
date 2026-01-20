using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SplashScreen : MonoBehaviour
{
    public Image TF4Logo;
    public Image UnityLogo;
    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        // changes alpha value of logos
        if (TF4Logo.material.color.a < 246)
        {
            Color newColour = TF4Logo.color;
            newColour.a += 0.001f;
            TF4Logo.color = newColour;
            UnityLogo.color = newColour;
        }

        StartCoroutine(Wait());
    }
}
