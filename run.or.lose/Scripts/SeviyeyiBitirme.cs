using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SeviyeyiBitirme : MonoBehaviour
{
    public void level1Bitir()
    {
        SeviyelerYöneticisi.level2 = true;
        SceneManager.LoadScene(1);
    }

     public void level2Bitir()
    {
        SeviyelerYöneticisi.level3 = true;
        SceneManager.LoadScene(1);
    }

     public void level3Bitir()
    {
        SeviyelerYöneticisi.level4 = true;
        SceneManager.LoadScene(1);
    }

     public void level4Bitir()
    {
        SeviyelerYöneticisi.level5 = true;
        SceneManager.LoadScene(1);
    }

    public void level5bitir()
    {
        SceneManager.LoadScene(1);
    }
 
}
