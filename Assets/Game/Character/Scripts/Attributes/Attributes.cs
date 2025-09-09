using System;
using UnityEngine;



[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/PlayerDateScriptableObject", order = 1)]
public class Attributes: ScriptableObject
{
    [SerializeField] private Int32 maxHealth;
    [SerializeField] private Int32 currentHealth;
}
