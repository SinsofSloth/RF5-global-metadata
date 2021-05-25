[Serializable]
public class SplineNode // TypeDefIndex: 9738
{
	// Fields
	[SerializeField] // RVA: 0x17EDE0 Offset: 0x17EEE1 VA: 0x17EDE0
	private Vector3 position; // 0x10
	[SerializeField] // RVA: 0x17EDF0 Offset: 0x17EEF1 VA: 0x17EDF0
	private Vector3 direction; // 0x1C
	[SerializeField] // RVA: 0x17EE00 Offset: 0x17EF01 VA: 0x17EE00
	private Vector3 up; // 0x28
	[SerializeField] // RVA: 0x17EE10 Offset: 0x17EF11 VA: 0x17EE10
	private Vector2 scale; // 0x34
	[SerializeField] // RVA: 0x17EE20 Offset: 0x17EF21 VA: 0x17EE20
	private float roll; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x17EE30 Offset: 0x17EF31 VA: 0x17EE30
	private EventHandler Changed; // 0x40

	// Properties
	public Vector3 Position { get; set; }
	public Vector3 Direction { get; set; }
	public Vector3 Up { get; set; }
	public Vector2 Scale { get; set; }
	public float Roll { get; set; }

	// Methods

	// RVA: 0x2246490 Offset: 0x2246591 VA: 0x2246490
	public Vector3 get_Position() { }

	// RVA: 0x2240390 Offset: 0x2240491 VA: 0x2240390
	public void set_Position(Vector3 value) { }

	// RVA: 0x22464A0 Offset: 0x22465A1 VA: 0x22464A0
	public Vector3 get_Direction() { }

	// RVA: 0x2243730 Offset: 0x2243831 VA: 0x2243730
	public void set_Direction(Vector3 value) { }

	// RVA: 0x22464B0 Offset: 0x22465B1 VA: 0x22464B0
	public Vector3 get_Up() { }

	// RVA: 0x2240470 Offset: 0x2240571 VA: 0x2240470
	public void set_Up(Vector3 value) { }

	// RVA: 0x22464C0 Offset: 0x22465C1 VA: 0x22464C0
	public Vector2 get_Scale() { }

	// RVA: 0x22438D0 Offset: 0x22439D1 VA: 0x22438D0
	public void set_Scale(Vector2 value) { }

	// RVA: 0x22464D0 Offset: 0x22465D1 VA: 0x22464D0
	public float get_Roll() { }

	// RVA: 0x2243810 Offset: 0x2243911 VA: 0x2243810
	public void set_Roll(float value) { }

	// RVA: 0x2240550 Offset: 0x2240651 VA: 0x2240550
	public void .ctor(Vector3 position, Vector3 direction) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ACF30 Offset: 0x1AD031 VA: 0x1ACF30
	// RVA: 0x22431D0 Offset: 0x22432D1 VA: 0x22431D0
	public void add_Changed(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ACF40 Offset: 0x1AD041 VA: 0x1ACF40
	// RVA: 0x2243120 Offset: 0x2243221 VA: 0x2243120
	public void remove_Changed(EventHandler value) { }
}

