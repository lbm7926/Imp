using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Robot
{
    public class RobotAxis : MonoBehaviour
    {
        [Range(-165f, 165f)]
        public float Axis1 = 0;
        [Range(-110f, 110f)]
        public float Axis2 = 0;
        [Range(-90f, 70f)]
        public float Axis3 = 0;
        [Range(-160f, 160f)]
        public float Axis4 = 0;
        [Range(-120f, 120f)]
        public float Axis5 = 0;
        [Range(-400f, 400f)]
        public float Axis6 = 0;

        private Transform Axis1Trans;
        private Transform Axis2Trans;
        private Transform Axis3Trans;
        private Transform Axis4Trans;
        private Transform Axis5Trans;
        private Transform Axis6Trans;

        UnityAction<float> unityAction;

        private void Awake()
        {
            Axis1Trans = transform.Find("Base/Axis1");
            Axis2Trans = transform.Find("Base/Axis1/Axis2");
            Axis3Trans = transform.Find("Base/Axis1/Axis2/Axis3");
            Axis4Trans = transform.Find("Base/Axis1/Axis2/Axis3/Axis4");
            Axis5Trans = transform.Find("Base/Axis1/Axis2/Axis3/Axis4/Axis5");
            Axis6Trans = transform.Find("Base/Axis1/Axis2/Axis3/Axis4/Axis5/Axis6");
        }

        private void Update()
        {
            Axis1Trans.localRotation = Quaternion.Euler(0,Axis1,0);
            Axis2Trans.localRotation = Quaternion.Euler(Axis2, 0, 0);
            Axis3Trans.localRotation = Quaternion.Euler(Axis3, 0, 0);
            Axis4Trans.localRotation = Quaternion.Euler(0, 0, Axis4);
            Axis5Trans.localRotation = Quaternion.Euler(Axis5, 0, 0);
            Axis6Trans.localRotation = Quaternion.Euler(0, 0, Axis6);
        }
    }
}

