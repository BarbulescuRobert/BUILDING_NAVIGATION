using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scene : MonoBehaviour
{
    public Button start, next;
    public GameObject target;
    int nr = 1;

    private void Start()
    {
        start.onClick.AddListener(startClicked);
        next.onClick.AddListener(nextClicked);
    }

    void startClicked()
    {
        FindObjectOfType<NavScript>().SetDestination(target.transform.position);
    }
    void nextClicked()
    {
        FindObjectOfType<NavScript>().NextCorner(nr);
        nr++;
    }
    public void restartNR()
    {
        nr = 1;
    }
}
