using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "SceneData", menuName = "Data/SceneData", order = 100)]
public class SceneDataSO : ScriptableObject
{
    [Header("Player Data")] 
    public Transform playerPosition;
    public int playerHealth;



}
