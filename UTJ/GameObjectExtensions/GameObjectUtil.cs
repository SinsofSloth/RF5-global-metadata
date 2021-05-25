[ExtensionAttribute] // RVA: 0x147BA0 Offset: 0x147CA1 VA: 0x147BA0
public static class GameObjectUtil // TypeDefIndex: 9199
{
	// Methods

	// RVA: -1 Offset: -1
	public static IEnumerable<T> FindComponentsOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D52C0 Offset: 0x22D53C1 VA: 0x22D52C0
	|-GameObjectUtil.FindComponentsOfType<object>
	|-GameObjectUtil.FindComponentsOfType<ForceProvider>
	|-GameObjectUtil.FindComponentsOfType<Transform>
	*/

	// RVA: 0x1FFF540 Offset: 0x1FFF641 VA: 0x1FFF540
	public static IEnumerable<GameObject> GetAllGameObjects() { }

	[ExtensionAttribute] // RVA: 0x1A98A0 Offset: 0x1A99A1 VA: 0x1A98A0
	// RVA: -1 Offset: -1
	public static Dictionary<string, T> BuildNameToComponentMap<T>(GameObject rootObject, bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D3C50 Offset: 0x22D3D51 VA: 0x22D3C50
	|-GameObjectUtil.BuildNameToComponentMap<object>
	|-GameObjectUtil.BuildNameToComponentMap<SpringCapsuleCollider>
	|-GameObjectUtil.BuildNameToComponentMap<SpringPanelCollider>
	|-GameObjectUtil.BuildNameToComponentMap<SpringSphereCollider>
	|-GameObjectUtil.BuildNameToComponentMap<Transform>
	*/

	[ExtensionAttribute] // RVA: 0x1A98B0 Offset: 0x1A99B1 VA: 0x1A98B0
	// RVA: 0x1FFF660 Offset: 0x1FFF761 VA: 0x1FFF660
	public static IEnumerable<Transform> GetAllBones(GameObject rootObject) { }

	[ExtensionAttribute] // RVA: 0x1A98C0 Offset: 0x1A99C1 VA: 0x1A98C0
	// RVA: 0x1FFF7B0 Offset: 0x1FFF8B1 VA: 0x1FFF7B0
	public static Transform FindChildByName(GameObject inRoot, string inName, GameObjectUtil.SearchOptions searchOptions = 1) { }

	[ExtensionAttribute] // RVA: 0x1A98D0 Offset: 0x1A99D1 VA: 0x1A98D0
	// RVA: -1 Offset: -1
	public static T FindChildComponentByName<T>(GameObject inRoot, string inName, GameObjectUtil.SearchOptions searchOptions = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22653B0 Offset: 0x22654B1 VA: 0x22653B0
	|-GameObjectUtil.FindChildComponentByName<object>
	|-GameObjectUtil.FindChildComponentByName<Renderer>
	|-GameObjectUtil.FindChildComponentByName<Transform>
	*/

	[ExtensionAttribute] // RVA: 0x1A98E0 Offset: 0x1A99E1 VA: 0x1A98E0
	// RVA: -1 Offset: -1
	public static T[] FindChildComponentsByName<T>(GameObject inRoot, string[] inNames, GameObjectUtil.SearchOptions searchOptions = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2274BC0 Offset: 0x2274CC1 VA: 0x2274BC0
	|-GameObjectUtil.FindChildComponentsByName<object>
	*/

	// RVA: 0x1FFF820 Offset: 0x1FFF921 VA: 0x1FFF820
	public static string RemoveNamespaceFromName(string inName) { }

	// RVA: 0x1FFF8F0 Offset: 0x1FFF9F1 VA: 0x1FFF8F0
	public static int GetTransformDepth(Transform inObject) { }

	// RVA: 0x1FFF9A0 Offset: 0x1FFFAA1 VA: 0x1FFF9A0
	public static string GetUniqueName(string desiredName) { }
}

