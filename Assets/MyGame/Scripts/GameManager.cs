using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject target;
    public GameObject parentOFTarget;

    public bool won;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        won = false;
        InvokeRepeating("Spawn",1f,2f);
    }

    //Spawn a target at a random position with a specific x and y range.
    //Instantiate (make a concret GameObjekt ; i.e., a clone from the given preffab target) the
    //target as child of the ParentOfTarget. In this case transform.locationinstead of
    //transform.position is important!!
    private void Spawn ()
    {
        float randomX = Random.Range(-430, 431);
        float randomY = Random.Range(-220, 221);

        Vector2 random2DPosition = new Vector2(randomX, randomY);

        GameObject myTarget = Instantiate(target,parentOFTarget.transform);
        myTarget.transform.localPosition = random2DPosition;

        Debug.Log(random2DPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (won == true)
        {
            CancelInvoke("Spawn");
        }
        else
        {
            Debug.Log(won);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("MousePressed");
        }
    }
    public void IncrementScore()
    {
        score++;
        Debug.Log("increment...+");

        if(score > 10)
        {
            won = true;
        }

    }
}
