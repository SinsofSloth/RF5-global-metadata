public class FurnitureLine : MonoBehaviour // TypeDefIndex: 10264
{
	// Fields
	private BoxCollider box; // 0x18
	private Vector3[] vertex_; // 0x20
	private LineRenderer lRend; // 0x28
	private bool isActive; // 0x30
	private bool isHit; // 0x31
	private Vector3[] pos_tbl_; // 0x38

	// Properties
	public bool Hit { get; }

	// Methods

	// RVA: 0x1F303B0 Offset: 0x1F304B1 VA: 0x1F303B0
	public bool get_Hit() { }

	// RVA: 0x1F303C0 Offset: 0x1F304C1 VA: 0x1F303C0
	private void Start() { }

	// RVA: 0x1F305A0 Offset: 0x1F306A1 VA: 0x1F305A0
	private void LateUpdate() { }

	// RVA: 0x1F305F0 Offset: 0x1F306F1 VA: 0x1F305F0
	public bool CheckHit() { }

	// RVA: 0x1F30AB0 Offset: 0x1F30BB1 VA: 0x1F30AB0
	private void updateLine() { }

	// RVA: 0x1F30EC0 Offset: 0x1F30FC1 VA: 0x1F30EC0
	public void SetCollider(BoxCollider collider) { }

	// RVA: 0x1F310B0 Offset: 0x1F311B1 VA: 0x1F310B0
	public void OnPut() { }

	// RVA: 0x1F310E0 Offset: 0x1F311E1 VA: 0x1F310E0
	public void .ctor() { }
}

