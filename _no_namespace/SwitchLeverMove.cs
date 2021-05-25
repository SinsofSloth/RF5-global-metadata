[ExecuteInEditMode] // RVA: 0x146730 Offset: 0x146831 VA: 0x146730
public class SwitchLeverMove : MonoBehaviour // TypeDefIndex: 7611
{
	// Fields
	[SerializeField] // RVA: 0x168390 Offset: 0x168491 VA: 0x168390
	private Transform MoveTargetTransform; // 0x18
	[SerializeField] // RVA: 0x1683A0 Offset: 0x1684A1 VA: 0x1683A0
	private float MoveDuration; // 0x20
	[SerializeField] // RVA: 0x1683B0 Offset: 0x1684B1 VA: 0x1683B0
	private Vector3 OffPosition; // 0x24
	[SerializeField] // RVA: 0x1683C0 Offset: 0x1684C1 VA: 0x1683C0
	private Vector3 OnPosition; // 0x30
	[SerializeField] // RVA: 0x1683D0 Offset: 0x1684D1 VA: 0x1683D0
	private Renderer[] Renderers; // 0x40
	[SerializeField] // RVA: 0x1683E0 Offset: 0x1684E1 VA: 0x1683E0
	private Material[] Materials; // 0x48
	private bool MoveDirection; // 0x50
	private bool MoveDone; // 0x51
	private float ElapsedTime; // 0x54

	// Methods

	// RVA: 0x1C63A00 Offset: 0x1C63B01 VA: 0x1C63A00
	private void Awake() { }

	// RVA: 0x1C63C30 Offset: 0x1C63D31 VA: 0x1C63C30
	private void SetElapsedTimeAndUpdatePoint() { }

	// RVA: 0x1C63D70 Offset: 0x1C63E71 VA: 0x1C63D70
	private void Update() { }

	// RVA: 0x1C63DD0 Offset: 0x1C63ED1 VA: 0x1C63DD0
	private void OnChangeSwitchState(bool newState, bool immediate) { }

	// RVA: 0x1C63B20 Offset: 0x1C63C21 VA: 0x1C63B20
	private void ChangeRendererMaterial(bool newState) { }

	// RVA: 0x1C63E20 Offset: 0x1C63F21 VA: 0x1C63E20
	public void .ctor() { }
}

