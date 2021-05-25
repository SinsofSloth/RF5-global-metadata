public class IndoorShadowManager : SingletonMonoBehaviour<IndoorShadowManager> // TypeDefIndex: 10451
{
	// Fields
	private HashSet<IndoorShadowFloor> IndoorShadowFloorHashSet; // 0x18
	private IndoorShadowFloor IndoorShadowFloor; // 0x20
	private Dictionary<GameObject, Renderer[]> ItemRendererDictionary; // 0x28
	private bool IsEnable; // 0x30
	private int PlayerFloorIndex; // 0x34
	private CullingGroup CullingGroup; // 0x38
	private BoundingSphere[] Bounds; // 0x40
	private Transform[] Targets; // 0x48
	private bool[] TargetShadowEnables; // 0x50
	[SerializeField] // RVA: 0x181950 Offset: 0x181A51 VA: 0x181950
	private float[] BoundingDistances; // 0x58

	// Methods

	// RVA: 0x1EE7A00 Offset: 0x1EE7B01 VA: 0x1EE7A00
	private void OnDestroy() { }

	// RVA: 0x1EE78C0 Offset: 0x1EE79C1 VA: 0x1EE78C0
	public void AddFloor(IndoorShadowFloor floorObject) { }

	// RVA: 0x1EE7720 Offset: 0x1EE7821 VA: 0x1EE7720
	public void RemoveFloor(IndoorShadowFloor floorObject) { }

	// RVA: 0x1EE7B10 Offset: 0x1EE7C11 VA: 0x1EE7B10
	public bool CheckEnable() { }

	// RVA: 0x1EE7C00 Offset: 0x1EE7D01 VA: 0x1EE7C00 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1EE8080 Offset: 0x1EE8181 VA: 0x1EE8080
	private void Update() { }

	// RVA: 0x1EE82E0 Offset: 0x1EE83E1 VA: 0x1EE82E0
	private void UpdateCharacter(bool isUseCulling) { }

	// RVA: 0x1EE8660 Offset: 0x1EE8761 VA: 0x1EE8660
	private void UpdateSpcItem(bool isUseCulling) { }

	// RVA: 0x1EE8CD0 Offset: 0x1EE8DD1 VA: 0x1EE8CD0
	public void AddSpcItem(GameObject gameObject) { }

	// RVA: 0x1EE8D60 Offset: 0x1EE8E61 VA: 0x1EE8D60
	public void RemoveSpcItem(GameObject gameObject) { }

	// RVA: 0x1EE8A90 Offset: 0x1EE8B91 VA: 0x1EE8A90
	private void UpdateFurniture(bool isUseCulling) { }

	// RVA: 0x1EE8BB0 Offset: 0x1EE8CB1 VA: 0x1EE8BB0
	private void UpdateGroundItem(bool isUseCulling) { }

	// RVA: 0x1EE8DD0 Offset: 0x1EE8ED1 VA: 0x1EE8DD0
	private int CheckFloorIndex(float height) { }

	// RVA: 0x1EE8E50 Offset: 0x1EE8F51 VA: 0x1EE8E50
	public static bool CheckEnableMeshShadow(float checkHeight) { }

	// RVA: 0x1EE7B70 Offset: 0x1EE7C71 VA: 0x1EE7B70
	private void ResetShadow() { }

	// RVA: 0x1EE8F30 Offset: 0x1EE9031 VA: 0x1EE8F30
	private void ResetMeshShadowCharacter() { }

	// RVA: 0x1EE90F0 Offset: 0x1EE91F1 VA: 0x1EE90F0
	private void ResetSpcItem() { }

	// RVA: 0x1EE7C60 Offset: 0x1EE7D61 VA: 0x1EE7C60
	private void SetCullingGroup() { }

	// RVA: 0x1EE92F0 Offset: 0x1EE93F1 VA: 0x1EE92F0
	private void OnChange(CullingGroupEvent ev) { }

	// RVA: 0x1EE9360 Offset: 0x1EE9461 VA: 0x1EE9360
	public void .ctor() { }
}

