using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextLoading : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMesh = null;
    void Start()
    {
        StartCoroutine(SetTextLoading());
    }

    IEnumerator SetTextLoading()
    {
        List<string> txtLoading = new List<string>() { "Loading", "Loading.", "Loading..", "Loading..." };
        int inndex = 0;
        while (true)
        {
            textMesh.text = txtLoading[inndex % txtLoading.Count];
            inndex++;
            yield return null;
            yield return new WaitForSeconds(0.25f);
            yield return new WaitForEndOfFrame();
        }
    }
}
