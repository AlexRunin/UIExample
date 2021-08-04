using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject circle; // ссылка на м€чик
    [SerializeField] private GameObject hexagon;
    [SerializeField] private UIManager uIManager; // помещ€ем UINABAGER на Spauner

    private bool b;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            if (b)
            {
                Create(circle, 0);
            }
            else 
            {
                Create(hexagon, 1);
            }
            yield return new WaitForSeconds(1f);
            b = !b;
        }
    }

    void Create(GameObject prefab, int i)
    {
        GameObject go = Instantiate(prefab);
        go.GetComponent<Sircle>().SetUIManager(uIManager, i);
    }
}
