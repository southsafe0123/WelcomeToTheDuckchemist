using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interation_Base : MonoBehaviour
{
    public GameObject bubble;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bubble.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bubble.SetActive(false);
        }
    }

    public void OnLoadClickedData()
    {
        Debug.Log("success");
    }
}
