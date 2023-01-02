using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class TypingController3 : MonoBehaviour
{
    public Text wordOutput = null;
    public int ketikan;
    public float speedPlayer;
    public float loncatan = 2;
    public GameObject playerKenaHit;
    string remainingWord = string.Empty;
    public string currentWord = "Simple";
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
        PergerakanPlayer();
        MovePlayer();
        CheckInput();

    }
    void CheckInput()
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
            RemoveLetter();
            ketikan++;

            Underline.instance.RemoveLetter2();

            if (isWordComplete())
            {

            }

        }
    }
    bool isCorrectLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;
    }
    void RemoveLetter()
    {
        string newString = remainingWord.Remove(0, 1);
        SetRemainingWord(newString);
    }
    bool isWordComplete()
    {
        return remainingWord.Length == 0;
    }

    //----------------------------------------------

    public void MovePlayer()
    {

        if (ketikan == 1)
        {
            speedPlayer = 15;
            if (speedPlayer == 15)
            {
                Invoke("PenguranganSpeed", 0.068f);
            }
            ketikan = 0;
        }
    }
    public void PenguranganSpeed()
    {
        speedPlayer = 0.001f;
    }
    void PergerakanPlayer()
    {
        transform.Translate(Vector3.right * speedPlayer * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            playerKenaHit.SetActive(true);
        }
    }
    public void LoadScane(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
        Time.timeScale = 1;
    }
}