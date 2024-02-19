using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class Gate : MonoBehaviour
{
    private enum OperationType
    { 
        addition,
        difference,
        multiplication,
        division
    }

    [Header("Operation")]
    [SerializeField] private OperationType gateOperation;
    [SerializeField] private int value;

    [Header("References")]
    [SerializeField] private TextMeshPro operationText;
    [SerializeField] private MeshRenderer forceField;
    [SerializeField] private Material[] operationTypeMaterial;
    private PlayerHealth  playerHealth;

    private void Awake()
    {
        AssignOperation();
    }

    private void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }
    private void AssignOperation()
    {
        string finalText = "";

        if (gateOperation == OperationType.addition)
            finalText += "+";
        if (gateOperation == OperationType.difference)
            finalText += "-";
        if (gateOperation == OperationType.multiplication)
            finalText += "x";
        if (gateOperation == OperationType.division)
            finalText += "÷";

        finalText += value.ToString();
        operationText.text = finalText;

        if (gateOperation == OperationType.addition || gateOperation == OperationType.multiplication)
            forceField.material = operationTypeMaterial[0];
        else
            forceField.material = operationTypeMaterial[1];
    }

   public void TakeValue(int _value)
    {
        value += _value; 
    }
     public void OnCollisionEnter(Collision co)
    {
        if(co.gameObject.tag == "Player")
        {
            playerHealth.TakeValue(value);
            Destroy(gameObject);
        }
    }
}