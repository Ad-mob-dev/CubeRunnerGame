using UnityEngine;

public class CollisionController : MonoBehaviour
{
   // public delegate void DlgOnGameOver(bool isGameOver);
    //Delegate & Event
    public static event MyDelegates.DlgGameAudio GameAudio;
    public static event MyDelegates.DlgOnGameOver OnGameOverEvent;
    public static event MyDelegates.DlgUIScoreUpdation ScoreUpdation;

    
    public static event MyDelegates.NewDelegate MyDelegate;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("collectives"))
        {
            GameAudio?.Invoke(false, true);
            ScoreUpdation?.Invoke();
            MyDelegate?.Invoke();
            collision.gameObject.SetActive(false);

        }
        else if (collision.gameObject.CompareTag("obstacles"))
        {

            GameAudio?.Invoke(true,false);
            OnGameOverEvent?.Invoke(true);
            Destroy(gameObject);
          
        }else if (collision.gameObject.CompareTag("EndPoint"))
        {
            OnGameOverEvent?.Invoke(true);
            Destroy(gameObject);
        }


    }


   
}
