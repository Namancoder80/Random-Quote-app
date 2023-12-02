using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
struct Quotes{
    public string content;
    public string author;
}
public class RandomQuote : MonoBehaviour
{
    [Space(10f)]
    [SerializeField] private TMP_Text Quote;
    [Space(10f)]
    [SerializeField] private TMP_Text Author;
    [Space(10f)]
    [SerializeField] private Button NextQuote;
    
    [TextArea(2,11)]
    [Space(10f)]
    [SerializeField] private string QuoteApi;
    private void Start()
    {
        StartCoroutine(GetRandomQuote(QuoteApi));

        //Add Event Listner to the button to fetch random quotes
        NextQuote.onClick.AddListener(() =>
        {
            StartCoroutine(GetRandomQuote(QuoteApi));
        });
    }
    IEnumerator GetRandomQuote(string url)
    {
        UnityWebRequest unityWebRequest = UnityWebRequest.Get(url);
        yield return unityWebRequest.SendWebRequest();
        //Fetch Data
        Quotes quotes = JsonUtility.FromJson<Quotes>(unityWebRequest.downloadHandler.text);
        
        //Display Data in GUI

        Quote.text= ($"\" {quotes.content} \" ");
        Author.text= quotes.author;
    }
}
