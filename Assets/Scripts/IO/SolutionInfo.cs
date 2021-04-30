using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Imp.solution
{
	[Serializable]
	public class SolutionInfo
	{
		public string Name { get; set; }

		public Scene Scene { get; set; }

		public List<Equipment> equipmentList { get; set; }
	}

	public class Equipment
	{
		public string Name { get; set; }

		public Vector3 position { get; set; }

		public Vector3 rotation { get; set; }
	}

	public class Scene
	{
		public string Name { get; set; }

		public Vector3 position { get; set; }

		public Vector3 rotation { get; set; }
	}
}

