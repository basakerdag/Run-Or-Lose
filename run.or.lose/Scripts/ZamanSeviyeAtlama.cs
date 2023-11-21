using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZamanSeviyeAtlama : MonoBehaviour
{  
   public Text zaman;
   public GameObject oyunaDevamUI;
   public GameObject oyunBittiUI;
   float zamanS = 60;
   
   
   bool devam = true;
   bool tamam = false;
   


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         if(devam && !tamam)
        {
          zamanS -= Time.deltaTime;
          zaman.text = (int)zamanS+"";
        }
        else if(!tamam)
        {
          oyunBitti();
          
        }


 
        if (zamanS<0)
        {
            devam = false;
        }
        
    }
       
       
    
    
   
    public void OnCollisionEnter(Collision other)
    {
        string obje = other.gameObject.name;
        if(obje.Equals("Cýkýs"))
        {
           tamam=true;
           oyunaDevam();
        } 
       
    }

    public void oyunaDevam()
    {
        oyunaDevamUI.SetActive(true);
    }
   
    public void oyunBitti()
    {
      oyunBittiUI.SetActive(true);
    }

}
