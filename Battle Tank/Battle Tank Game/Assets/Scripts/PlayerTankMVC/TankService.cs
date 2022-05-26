using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour
{
    [SerializeField]public TankView tankView;
    
    public TankScriptableObjectList tankList;    

   
    void Start()
    {
        //tankView.gameObject.SetActive(true);
        StartGame();
        //cameraControl.SetStartPositionAndSize();
    }

    void StartGame()
    {
        
        CreateTank();
        //CreateEnemyTank();
    }

    private void CreateTank()
    {
        int index = Random.Range(0, tankList.tanks.Length);
        TankScriptableObject tankScriptableObject = tankList.tanks[index];
        TankModel tankModel = new TankModel(tankScriptableObject);
        TankController tankController = new TankController(tankModel, tankView);         
    }
}