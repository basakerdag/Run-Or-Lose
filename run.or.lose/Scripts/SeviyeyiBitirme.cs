using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SeviyeyiBitirme : MonoBehaviour
{
    public void level1Bitir()
    {
        SeviyelerY�neticisi.level2 = true;
        SceneManager.LoadScene(1);
    }

     public void level2Bitir()
    {
        SeviyelerY�neticisi.level3 = true;
        SceneManager.LoadScene(1);
    }

     public void level3Bitir()
    {
        SeviyelerY�neticisi.level4 = true;
        SceneManager.LoadScene(1);
    }

     public void level4Bitir()
    {
        SeviyelerY�neticisi.level5 = true;
        SceneManager.LoadScene(1);
    }

    public void level5bitir()
    {
        SceneManager.LoadScene(1);
    }
 
}
