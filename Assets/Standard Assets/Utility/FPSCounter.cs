using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Utility
{
    [RequireComponent(typeof (Text))]
    public class FPSCounter : MonoBehaviour
    {
        private int currentHeight;
        private int maxHeight;
        const string display = "{0}";
        private Text m_Text;
        Transform robotboy;
        static int highScore = 0;

         
        private void Start()
        {
            m_Text = GetComponent<Text>();
            robotboy = gameObject.transform.Find("/CharacterRobotBoy");
            PlayerPrefs.GetInt("maxHeight");
            highScore = PlayerPrefs.GetInt("maxHeight");
            m_Text.text = "HS:";
        }


        private void Update()
        {
            // measure average frames per second
            currentHeight = (int) robotboy.transform.position.y;
            if (currentHeight > maxHeight)
            {
                maxHeight = currentHeight;
                
            }
            m_Text.text = string.Format(display, maxHeight);
            
        }
    }
}
