
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;
using UnityEngine.SceneManagement;
public class Playbutton : MonoBehaviour

{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    void Start()
    {
        actions.Add("Play", Play);
        actions.Add("Quit", Quit);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }


    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {

        Debug.Log(speech.text);

        actions[speech.text].Invoke();
    }

    public void Play()
    {
        SceneManager.LoadScene("Level");

    }
    public void Quit()
    {
        Application.Quit();
    }
}

