using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reel_Data : MonoBehaviour
{
    public float Rotate_Speed;
    private float Interval_Time;

    public bool Is_Rotating;

    public void Start()
    {
        Is_Rotating = false;
    }

    //Starts spinning reels to be called when the button has been pressed
    public void StartRotate()
    {
        if(Is_Rotating == false)
        {
            Rotate_Speed = Random.Range(50, 100);
            StartCoroutine(Rotate());
        }
    }

    //Spin animation of reels
    IEnumerator Rotate()
    {
        Is_Rotating = true;
        Interval_Time = 0.025f;

        //Makes initial spin fast no randomness
        for(int i=0; i < 30; i++)
        {
            if(transform.localPosition.y <= -1800f)
            {
                transform.position = new Vector2(transform.position.x, 0f);
            }

            transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y - 100f);
            yield return new WaitForSeconds(Interval_Time);
        }

        //Applies random duration of slow movement
        switch(Rotate_Speed % 2)
        {
            case 1:
                Rotate_Speed += 1;
                break;
            case 2:
                Rotate_Speed += 2;
                break;
        }

        //Makes the end of the spin slower, applies randomness when it stops.
        for (int i = 0; i < Rotate_Speed; i++)
        {
            if (transform.localPosition.y <= -1800f)
            {
                transform.position = new Vector2(transform.position.x, 0f);
            }
            transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y - 100f);

            if (i > Mathf.RoundToInt(Rotate_Speed * 0.25f))
                Interval_Time = 0.05f;
            if (i > Mathf.RoundToInt(Rotate_Speed * 0.5f))
                Interval_Time = 0.1f;
            if (i > Mathf.RoundToInt(Rotate_Speed * 0.75f))
                Interval_Time = 0.15f;
            if (i > Mathf.RoundToInt(Rotate_Speed * 0.95f))
                Interval_Time = 0.2f;
            yield return new WaitForSeconds(Interval_Time);
        }
        Is_Rotating = false;
    }
}
