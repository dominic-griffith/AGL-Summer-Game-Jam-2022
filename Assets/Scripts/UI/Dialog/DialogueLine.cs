using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass
    {
        [SerializeField] private string input;
        [SerializeField] private Sprite characterHead;
        [SerializeField] private Image headHolder;
        [SerializeField] private GameObject indicateNextImage; //set active based on indicateNext bool in parent
        [SerializeField] private float alphaValue = 255f;
        private Color color;

        private TMP_Text textHolder;

        private void Awake()
        {
            textHolder = GetComponent<TMP_Text>();
            textHolder.text = "";            
        }

        private void Start()
        {
            color = headHolder.color;
            color.a = alphaValue;
            headHolder.color = color;
            headHolder.sprite = characterHead;
            headHolder.preserveAspect = true;
            StartCoroutine(WriteText(input, textHolder));
        }

        private void Update()
        {
            indicateNextImage.SetActive(getNextBool());
        }
    }
}


