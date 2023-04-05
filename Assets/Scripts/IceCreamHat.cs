using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using static UnityEngine.Rendering.DebugUI.Table;

public class IceCreamHat : MonoBehaviour
{
    [SerializeField]
    GameObject topConeGameObject;

    [SerializeField]
    GameObject leftConeGameObject;

    [SerializeField]
    GameObject rightConeGameObject;


    float angle = 360.0f; // Degree per time unit
    float time = 5.0f; // Time unit in sec
    Vector3 axis = Vector3.up; // Rotation axis, here it the yaw axis


    // Start is called before the first frame update
    void Start()
    {
        topConeGameObject.transform.DOLocalRotate(new Vector3(0, 360, 0), time, RotateMode.FastBeyond360).SetRelative(true).SetEase(Ease.Linear).SetLoops(-1).SetEase(Ease.Linear); 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
