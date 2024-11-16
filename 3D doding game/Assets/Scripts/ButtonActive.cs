using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActive : MonoBehaviour
{
   public Player player;
   public void ButtonRestarOnClick()
   {
      if (player.Ispaused == true)
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         player.Ispaused = false;
      }
      
   }
}
