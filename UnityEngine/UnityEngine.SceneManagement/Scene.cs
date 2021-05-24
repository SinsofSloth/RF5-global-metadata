[NativeHeaderAttribute] // RVA: 0xC7930 Offset: 0xC7A31 VA: 0xC7930
[Serializable]
public struct Scene // TypeDefIndex: 3120
{
	// Fields
	[SerializeField] // RVA: 0xCB270 Offset: 0xCB371 VA: 0xCB270
	private int m_Handle; // 0x0

	// Properties
	public int handle { get; }
	public string name { get; }
	public bool isLoaded { get; }
	public int buildIndex { get; }
	public int rootCount { get; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xD9410 Offset: 0xD9511 VA: 0xD9410
	// RVA: 0x2A244F0 Offset: 0x2A245F1 VA: 0x2A244F0
	private static bool IsValidInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xD9450 Offset: 0xD9551 VA: 0xD9450
	// RVA: 0x2A24540 Offset: 0x2A24641 VA: 0x2A24540
	private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xD9490 Offset: 0xD9591 VA: 0xD9490
	// RVA: 0x2A24590 Offset: 0x2A24691 VA: 0x2A24590
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xD94D0 Offset: 0xD95D1 VA: 0xD94D0
	// RVA: 0x2A245E0 Offset: 0x2A246E1 VA: 0x2A245E0
	private static int GetBuildIndexInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xD9510 Offset: 0xD9611 VA: 0xD9510
	// RVA: 0x2A24630 Offset: 0x2A24731 VA: 0x2A24630
	private static int GetRootCountInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xD9550 Offset: 0xD9651 VA: 0xD9550
	// RVA: 0x2A24680 Offset: 0x2A24781 VA: 0x2A24680
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	// RVA: 0x374F30 Offset: 0x375031 VA: 0x374F30
	public int get_handle() { }

	// RVA: 0x374F40 Offset: 0x375041 VA: 0x374F40
	public bool IsValid() { }

	// RVA: 0x374F90 Offset: 0x375091 VA: 0x374F90
	public string get_name() { }

	// RVA: 0x374FE0 Offset: 0x3750E1 VA: 0x374FE0
	public bool get_isLoaded() { }

	// RVA: 0x375030 Offset: 0x375131 VA: 0x375030
	public int get_buildIndex() { }

	// RVA: 0x375080 Offset: 0x375181 VA: 0x375080
	public int get_rootCount() { }

	// RVA: 0x3750D0 Offset: 0x3751D1 VA: 0x3750D0
	public GameObject[] GetRootGameObjects() { }

	// RVA: 0x3750E0 Offset: 0x3751E1 VA: 0x3750E0
	public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

	// RVA: 0x2A24B90 Offset: 0x2A24C91 VA: 0x2A24B90
	public static bool op_Equality(Scene lhs, Scene rhs) { }

	// RVA: 0x3750F0 Offset: 0x3751F1 VA: 0x3750F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x375100 Offset: 0x375201 VA: 0x375100 Slot: 0
	public override bool Equals(object other) { }
}

