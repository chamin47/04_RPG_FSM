using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Characters/Player")]

public class PlayerSO : ScriptableObject
{
	[field: SerializeField] public PlayerGroundData GroundedData { get; private set; }
	[field: SerializeField] public PlayerAirData AirData { get; private set; }
	//public PlayerGroundData GroundedData;
	//public PlayerAirData AirData;

	//void Awake()
	//{
	//	GroundedData = new PlayerGroundData();
	//	AirData = new PlayerAirData();
	//}
}