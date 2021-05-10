using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Imp.solution
{
    [Serializable]
    public class Modle
    {
        public int id { get; set; }

        public string modleName { get; set; }

        public Vector3d position { get; set; }

        public Vector3d rotation { get; set; }
    }

    [Serializable]
    public class Vector3d
    {
        public float x;
        public float y;
        public float z;
    }

	[Serializable]
	public class SolutionInfo
	{
		public string name { get; set; }

        //public Scene Scene { get; set; }

        public List<Modle> equipmentList = new List<Modle>();

	}

   

    public class Equipment : MonoBehaviour
    {
        //public int id { get; }

        //public string equipmentName { get; }

        //public Vector3 position { get; set; }

        //public Vector3 rotation { get; set; }
    }

    //public class Scene
    //{
    //	public string Name { get; set; }

    //	public Vector3 position { get; set; }

    //	public Vector3 rotation { get; set; }
    //}
}

