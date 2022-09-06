using System.Collections;
using UnityEngine;
using TMPro;

namespace DialogueSystem
{
    public class DialogueBaseClass : MonoBehaviour
    {
        public bool finished { get; private set; }
        public bool indicateNext { get; private set; }

        public float inputTime = 0.02f;

        protected IEnumerator WriteText(string input, TMP_Text textHolder)
        {
            for(int i = 0; i < input.Length; i++)
            {
                textHolder.text += input[i];
                yield return new WaitForSeconds(inputTime);
            }
            indicateNext = true;

            yield return new WaitUntil(() => Input.GetMouseButton(0));
            FindObjectOfType<AudioManager>().Play("Button Click");

            indicateNext = false;

            finished = true;
        }

        protected bool getNextBool()
        {
            return indicateNext;
        }
    }
}


