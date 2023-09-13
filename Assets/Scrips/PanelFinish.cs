using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelFinish : MonoBehaviour
{
    // Start is called before the first frame update
    public int panelSelect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PanelManager.panel = panelSelect;
        }

    }
}