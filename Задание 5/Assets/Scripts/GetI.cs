using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class GetI : MonoBehaviour
{
    // Start is called before the first frame update
    public string adress;
    public TMP_Text label;
    void Start()
    {
        StartCoroutine(GetRequest(adress));
    }

    // Update is called once per frame
    IEnumerator GetRequest(string url)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            yield return webRequest.SendWebRequest();
            if (webRequest.result == UnityWebRequest.Result.ConnectionError)
            {
                print("Error" + webRequest.error);
            }
            else
            {
                print(webRequest.downloadHandler.text);
                label.text = webRequest.downloadHandler.text;
            }
        }
    }
}
