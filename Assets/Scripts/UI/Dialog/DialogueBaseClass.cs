using System.Collections;
using UnityEngine;
using TMPro;

namespace DialogueSystem
{
    public class DialogueBaseClass : MonoBehaviour
    {
        public float inputTime = 0.02f;

        protected IEnumerator WriteText(string input, TMP_Text textHolder)
        {
            for(int i = 0; i < input.Length; i++)
            {
                textHolder.text += input[i];
                yield return new WaitForSeconds(inputTime);
            }
        }
    }
}


