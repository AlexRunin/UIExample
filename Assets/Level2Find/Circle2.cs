using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle2 : MonoBehaviour
{
    private UIManager2 uIManager;
    private bool isTouch;

    [SerializeField] private LayerMask groundLayer; // ?????????? ??????


    private void Start()
    {
        uIManager = FindObjectOfType<UIManager2>(); //FindObjectOfType - ?????? ????????? UImanager
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (((1 << collision.gameObject.layer) & groundLayer) != 0) // collision.gameObject.layer - ???? ? ??????? ???????????
        {
            if (!isTouch)
            {
                uIManager.UpdateScore();
                isTouch = true;
            }
        }

    }
}
