public static class SpringBoneSetup // TypeDefIndex: 9145
{
	// Methods

	// RVA: 0x200A1A0 Offset: 0x200A2A1 VA: 0x200A1A0
	public static void DestroyUnityObject(Object objectToDestroy) { }

	// RVA: 0x2008EF0 Offset: 0x2008FF1 VA: 0x2008EF0
	public static void DestroySpringManagersAndBones(GameObject rootObject) { }

	// RVA: 0x2009B10 Offset: 0x2009C11 VA: 0x2009B10
	public static void FindAndAssignSpringBones(SpringManager springManager, bool includeInactive = False) { }

	// RVA: 0x200A900 Offset: 0x200AA01 VA: 0x200A900
	public static void AssignSpringBonesRecursively(Transform rootObject) { }

	// RVA: 0x200AA20 Offset: 0x200AB21 VA: 0x200AA20
	public static Dictionary<Transform, List<SpringBone>> GetPivotToSpringBoneMap(GameObject rootObject) { }

	// RVA: 0x200AF60 Offset: 0x200B061 VA: 0x200AF60
	public static void FixAllPivotNodePositions(GameObject rootObject) { }

	// RVA: 0x2009BF0 Offset: 0x2009CF1 VA: 0x2009BF0
	public static GameObject CreateSpringPivotNode(SpringBone springBone) { }

	// RVA: 0x2008330 Offset: 0x2008431 VA: 0x2008330
	public static bool IsPivotProbablySafeToDestroy(Transform pivot, IEnumerable<Transform> skinBones) { }

	// RVA: 0x200A210 Offset: 0x200A311 VA: 0x200A210
	private static void DestroyPivotObjects(GameObject rootObject) { }

	// RVA: 0x200B6B0 Offset: 0x200B7B1 VA: 0x200B6B0
	private static bool IsPivotSideDirectionValid(Vector3 lookDirection, Vector3 sideDirection) { }

	// RVA: 0x200B7D0 Offset: 0x200B8D1 VA: 0x200B7D0
	private static Vector3 FindClosestMeshNormalToPoint(Transform rootObject, Vector3 sourcePoint) { }

	// RVA: 0x200BE80 Offset: 0x200BF81 VA: 0x200BE80
	private static bool TryToGetPivotSideDirection(SpringBone springBone, Vector3 lookDirection, out Vector3 sideDirection) { }

	// RVA: 0x200B320 Offset: 0x200B421 VA: 0x200B320
	private static Quaternion GetPivotRotation(SpringBone springBone) { }

	// RVA: 0x200A630 Offset: 0x200A731 VA: 0x200A630
	private static List<SpringBone> GetSpringBonesSortedByDepth(GameObject rootObject, bool includeInactive) { }
}

