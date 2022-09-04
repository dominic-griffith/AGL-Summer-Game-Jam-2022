using System.Collections;
using UnityEngine;
using TMPro;

namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass
    {
        [SerializeField] private string input;
        private TMP_Text textHolder;

        private void Awake()
        {
            textHolder = GetComponent<TMP_Text>();

            StartCoroutine(WriteText(input, textHolder));
        }
    }
}


