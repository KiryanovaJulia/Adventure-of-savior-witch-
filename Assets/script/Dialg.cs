using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialg : MonoBehaviour
{
    public string[] lines;
    public float speedText;
    public Text dialogiText;

    public int index;
    void Start()
    {
        dialogiText.text = string.Empty;
        Startdia();
    }

    void Startdia()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray()) {
            dialogiText.text += c;
            yield return new WaitForSeconds(speedText);
        }
    }

    public void clicktext()
    {
        if(dialogiText.text == lines[index]) {
            NextLine();
        }
        else
        {
            StopAllCoroutines();
            dialogiText.text = lines[index];
        }
    }

    private void NextLine()
    {
        if(index<lines.Length - 1) {
            index++;
            dialogiText.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
