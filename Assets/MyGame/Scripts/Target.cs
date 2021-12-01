using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    float CurrentTime;
    public int Startminutes;
    bool Timeractiv = true;

    [SerializeField] private int secToDestroy;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {

        gameManager = FindObjectOfType<GameManager>();
        /*secToDestroy = 2;
       Destroy(gameObject, secToDestroy); */

        CurrentTime = 500;
    }

    private void OnMouseDown()
    {
        gameManager.IncrementScore();
        Destroy(gameObject);

 

    }

    private void Update()
    {
        if (Timeractiv == true)
        {
            CurrentTime = CurrentTime - 1;
            if (CurrentTime <= 0)
            {
                Destroy(gameObject);
                Start();
                Debug.Log("countdown done!");
            }
        }
    }





}
