using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





[CreateAssetMenu(fileName = "New Sample Data", menuName = "Sample Data")]
public class ScoreManager : ScriptableObject
{
    [SerializeField]
    private string swordName;
    [SerializeField]
    private string description;
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private int goldCost;
    [SerializeField]
    private int attackDamage;

    private void OnDisable()
    {
       
        CollisionController.MyDelegate -= DelegateDebugging;
    }

    private void OnEnable()
    {
       
        CollisionController.MyDelegate += DelegateDebugging;
    }

    public void DelegateDebugging()
    {
            Debug.Log("Debugger");
     
    }

  


}
