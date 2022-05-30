using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="BaseData_Player",menuName ="ScriptableObject/BaseData_Player")]
public class BaseData_Player : ScriptableObject
{
   public float PlayerMaxHp;
   public float MoveSpeed;
   public float FallSpeed;
   public float JumpSpeed;
   public float TwoSpeed;
}
