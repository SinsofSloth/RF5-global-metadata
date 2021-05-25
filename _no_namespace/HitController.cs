public class HitController : MonoBehaviour // TypeDefIndex: 7613
{
	// Fields
	[SerializeField] // RVA: 0x1683F0 Offset: 0x1684F1 VA: 0x1683F0
	[RangeAttribute] // RVA: 0x1683F0 Offset: 0x1684F1 VA: 0x1683F0
	private float Position; // 0x18
	[SerializeField] // RVA: 0x168430 Offset: 0x168531 VA: 0x168430
	[RangeAttribute] // RVA: 0x168430 Offset: 0x168531 VA: 0x168430
	private float Scale; // 0x1C
	[SerializeField] // RVA: 0x168470 Offset: 0x168571 VA: 0x168470
	private HitSystem activeHitSystem; // 0x20
	[HeaderAttribute] // RVA: 0x168480 Offset: 0x168581 VA: 0x168480
	[SerializeField] // RVA: 0x168480 Offset: 0x168581 VA: 0x168480
	private string[] hitSystemNames; // 0x28
	[HeaderAttribute] // RVA: 0x1684D0 Offset: 0x1685D1 VA: 0x1684D0
	[SerializeField] // RVA: 0x1684D0 Offset: 0x1685D1 VA: 0x1684D0
	private HitSystem[] hitSystems; // 0x30

	// Properties
	public HitSystem ActiveHitSystem { get; }
	public string[] HitSystemNames { get; }
	public HitSystem[] HitSystems { get; set; }

	// Methods

	// RVA: 0x2303BC0 Offset: 0x2303CC1 VA: 0x2303BC0
	public HitSystem get_ActiveHitSystem() { }

	// RVA: 0x2303BD0 Offset: 0x2303CD1 VA: 0x2303BD0
	public string[] get_HitSystemNames() { }

	// RVA: 0x2303BE0 Offset: 0x2303CE1 VA: 0x2303BE0
	public HitSystem[] get_HitSystems() { }

	// RVA: 0x2303BF0 Offset: 0x2303CF1 VA: 0x2303BF0
	public void set_HitSystems(HitSystem[] value) { }

	// RVA: 0x2303C00 Offset: 0x2303D01 VA: 0x2303C00
	private void Awake() { }

	// RVA: 0x2303C50 Offset: 0x2303D51 VA: 0x2303C50
	public void HitUpdate(float deltaTime) { }

	// RVA: 0x2303E60 Offset: 0x2303F61 VA: 0x2303E60
	public void HitTimeSync(float time) { }

	// RVA: 0x2304070 Offset: 0x2304171 VA: 0x2304070
	public HitSystem StartMotion(string motion_name) { }

	// RVA: 0x23041E0 Offset: 0x23042E1 VA: 0x23041E0
	public void StartMotion() { }

	// RVA: 0x2304120 Offset: 0x2304221 VA: 0x2304120
	public void ClearMotion() { }

	// RVA: 0x2304580 Offset: 0x2304681 VA: 0x2304580
	public void ResetPosition(float position) { }

	// RVA: 0x23045B0 Offset: 0x23046B1 VA: 0x23045B0
	public void ResetScale(float scale) { }

	// RVA: 0x23045E0 Offset: 0x23046E1 VA: 0x23045E0
	public void .ctor() { }
}

