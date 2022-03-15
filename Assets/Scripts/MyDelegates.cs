using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDelegates : MonoBehaviour
{
    public delegate void DlgOnGameOver(bool isGameOver);
    public delegate void DlgGameAudio(bool isObstacle, bool isCollectable);
    public delegate void DlgUIScoreUpdation();
    public delegate void NewDelegate();
}
