public class FishObjectPool : MonoBehaviour // TypeDefIndex: 10285
{
	// Fields
	private const int DEF_POOL_MAX = 8;
	private List<FishSwim> Pool; // 0x18
	private GameObject FishShadow; // 0x20

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x1EF3DE0 Offset: 0x1EF3EE1 VA: 0x1EF3DE0
	public int get_Count() { }

	// RVA: 0x1EF3E30 Offset: 0x1EF3F31 VA: 0x1EF3E30
	public void SetFishShadow(GameObject fish) { }

	// RVA: 0x1EF3E40 Offset: 0x1EF3F41 VA: 0x1EF3E40
	private void Awake() { }

	// RVA: 0x1EF3E50 Offset: 0x1EF3F51 VA: 0x1EF3E50
	private void Update() { }

	// RVA: 0x1EF4260 Offset: 0x1EF4361 VA: 0x1EF4260
	private void OnDestroy() { }

	// RVA: 0x1EF43E0 Offset: 0x1EF44E1 VA: 0x1EF43E0
	public int GetIndex() { }

	// RVA: 0x1EF44E0 Offset: 0x1EF45E1 VA: 0x1EF44E0
	public FishSwim Get(int index) { }

	// RVA: 0x1EF3D40 Offset: 0x1EF3E41 VA: 0x1EF3D40
	public void Release(int index) { }

	// RVA: 0x1EF3EC0 Offset: 0x1EF3FC1 VA: 0x1EF3EC0
	private void Add() { }

	// RVA: 0x1EF4600 Offset: 0x1EF4701 VA: 0x1EF4600
	public void .ctor() { }
}

