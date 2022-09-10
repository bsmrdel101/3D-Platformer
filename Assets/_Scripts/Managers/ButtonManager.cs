using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BEAN
{
    public class ButtonManager : MonoBehaviour
    {
        public void OnClickStartBtn()
        {
            SceneManager.LoadScene("Game");
        }

        public void OnClickOptionsBtn()
        {
            
        }

        public void OnClickQuitBtn()
        {
            Application.Quit();
        }
    }
}
