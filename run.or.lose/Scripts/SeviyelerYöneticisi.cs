using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeviyelerYöneticisi : MonoBehaviour
{
   public Button level1_buttton,level2_button,level3_button,level4_button,level5_button;
   public static bool level1,level2,level3,level4,level5;

   private void Start()
   {
       level1 = true;
      

   }

   private void Update()
   {
          if(level2 == true)
           {
                  level2_button.interactable = true;
           }

           if(level3 == true)
           {
                  level3_button.interactable = true;
           }

           if(level4 == true)
           {
                  level4_button.interactable = true;
           }

           if(level5 == true)
           {
                  level5_button.interactable = true;
           }


   }
}
