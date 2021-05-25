public class UIPositionOnModelHead : MonoBehaviour // TypeDefIndex: 8601
{
	// Fields
	[SerializeField] // RVA: 0x171010 Offset: 0x171111 VA: 0x171010
	private GameObject TargetObject; // 0x18
	private bool BoundSetFlag; // 0x20
	private Bounds TargetBounds; // 0x24
	[SerializeField] // RVA: 0x171020 Offset: 0x171121 VA: 0x171020
	private float _AddHeight; // 0x3C
	[SerializeField] // RVA: 0x171030 Offset: 0x171131 VA: 0x171030
	private bool _AutoAdjustPositionInScreen; // 0x40
	[SerializeField] // RVA: 0x171040 Offset: 0x171141 VA: 0x171040
	private Vector2 _BorderSize; // 0x44
	private const float defaultPlusY = 1;

	// Properties
	public float AddHeight { get; set; }
	public bool AutoAdjustPositionInScreen { get; set; }
	public Vector2 BorderSize { get; set; }

	// Methods

	// RVA: 0x1DCFE50 Offset: 0x1DCFF51 VA: 0x1DCFE50
	public float get_AddHeight() { }

	// RVA: 0x1DCFE60 Offset: 0x1DCFF61 VA: 0x1DCFE60
	public void set_AddHeight(float value) { }

	// RVA: 0x1DCFE70 Offset: 0x1DCFF71 VA: 0x1DCFE70
	public bool get_AutoAdjustPositionInScreen() { }

	// RVA: 0x1DCFE80 Offset: 0x1DCFF81 VA: 0x1DCFE80
	public void set_AutoAdjustPositionInScreen(bool value) { }

	// RVA: 0x1DCFE90 Offset: 0x1DCFF91 VA: 0x1DCFE90
	public Vector2 get_BorderSize() { }

	// RVA: 0x1DCFEA0 Offset: 0x1DCFFA1 VA: 0x1DCFEA0
	public void set_BorderSize(Vector2 value) { }

	// RVA: 0x1DCFEB0 Offset: 0x1DCFFB1 VA: 0x1DCFEB0
	public void Start() { }

	// RVA: 0x1DCFFD0 Offset: 0x1DD00D1 VA: 0x1DCFFD0
	public void SetTarget(GameObject targetObj) { }

	// RVA: 0x1DD0090 Offset: 0x1DD0191 VA: 0x1DD0090
	private bool SetBounds(GameObject targetObj) { }

	// RVA: 0x1DD0230 Offset: 0x1DD0331 VA: 0x1DD0230
	private void Update() { }

	// RVA: 0x1DD0560 Offset: 0x1DD0661 VA: 0x1DD0560
	public void .ctor() { }
}

