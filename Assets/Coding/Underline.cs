using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Underline : MonoBehaviour
{
    //public TextMeshProUGUI uiText;
    public Text wordOutput = null;

    string remainingWord = string.Empty;
    public string currentWord = "gas";

    public static Underline instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
    }
    void Start()
    {
        SetCurrentWord();
    }
    void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = remainingWord;

    }
    void SetCurrentWord()
    {
        SetRemainingWord(currentWord);
    }
    void Update()
    {
        CheckInput2();
    }
    void CheckInput2()
    {
        if (Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;


            if (keysPressed.Length == 1)
                EnterLetter(keysPressed);

        }
    }
    void EnterLetter(string typedLetter)
    {
        if (isCorrectLetter(typedLetter))
        {
            Debug.Log("Sipppp");
            RemoveLetter2();

            if (isWordComplete())
            {
                /*SetCurrentWord();*/ //Restrat Permainan

            }

        }
    }
    bool isCorrectLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;
    }
    public void RemoveLetter2()
    {
        string newString = remainingWord.Remove(0, 1);
        SetRemainingWord(newString);
    }
    bool isWordComplete()
    {
        return remainingWord.Length == 0;
    }
    public void Nyoba()
    {
        Debug.Log("Bisa dong");
    }
}
