[Serializable]
public struct AutoUnwrapSettings // TypeDefIndex: 5944
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x1416E0 Offset: 0x1417E1 VA: 0x1416E0
	[SerializeField] // RVA: 0x1416E0 Offset: 0x1417E1 VA: 0x1416E0
	private bool m_UseWorldSpace; // 0x0
	[SerializeField] // RVA: 0x141730 Offset: 0x141831 VA: 0x141730
	[FormerlySerializedAsAttribute] // RVA: 0x141730 Offset: 0x141831 VA: 0x141730
	private bool m_FlipU; // 0x1
	[SerializeField] // RVA: 0x141780 Offset: 0x141881 VA: 0x141780
	[FormerlySerializedAsAttribute] // RVA: 0x141780 Offset: 0x141881 VA: 0x141780
	private bool m_FlipV; // 0x2
	[FormerlySerializedAsAttribute] // RVA: 0x1417D0 Offset: 0x1418D1 VA: 0x1417D0
	[SerializeField] // RVA: 0x1417D0 Offset: 0x1418D1 VA: 0x1417D0
	private bool m_SwapUV; // 0x3
	[SerializeField] // RVA: 0x141820 Offset: 0x141921 VA: 0x141820
	[FormerlySerializedAsAttribute] // RVA: 0x141820 Offset: 0x141921 VA: 0x141820
	private AutoUnwrapSettings.Fill m_Fill; // 0x4
	[SerializeField] // RVA: 0x141870 Offset: 0x141971 VA: 0x141870
	[FormerlySerializedAsAttribute] // RVA: 0x141870 Offset: 0x141971 VA: 0x141870
	private Vector2 m_Scale; // 0x8
	[SerializeField] // RVA: 0x1418C0 Offset: 0x1419C1 VA: 0x1418C0
	[FormerlySerializedAsAttribute] // RVA: 0x1418C0 Offset: 0x1419C1 VA: 0x1418C0
	private Vector2 m_Offset; // 0x10
	[SerializeField] // RVA: 0x141910 Offset: 0x141A11 VA: 0x141910
	[FormerlySerializedAsAttribute] // RVA: 0x141910 Offset: 0x141A11 VA: 0x141910
	private float m_Rotation; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x141960 Offset: 0x141A61 VA: 0x141960
	[SerializeField] // RVA: 0x141960 Offset: 0x141A61 VA: 0x141960
	private AutoUnwrapSettings.Anchor m_Anchor; // 0x1C

	// Properties
	public bool useWorldSpace { get; }
	public bool flipU { get; }
	public bool flipV { get; }
	public bool swapUV { get; }
	public AutoUnwrapSettings.Fill fill { get; }
	public Vector2 scale { get; }
	public Vector2 offset { get; }
	public float rotation { get; }
	public AutoUnwrapSettings.Anchor anchor { get; }
	public static AutoUnwrapSettings tile { get; }

	// Methods

	// RVA: 0x18F10 Offset: 0x19011 VA: 0x18F10
	public bool get_useWorldSpace() { }

	// RVA: 0x18F20 Offset: 0x19021 VA: 0x18F20
	public bool get_flipU() { }

	// RVA: 0x18F30 Offset: 0x19031 VA: 0x18F30
	public bool get_flipV() { }

	// RVA: 0x18F40 Offset: 0x19041 VA: 0x18F40
	public bool get_swapUV() { }

	// RVA: 0x18F50 Offset: 0x19051 VA: 0x18F50
	public AutoUnwrapSettings.Fill get_fill() { }

	// RVA: 0x18F60 Offset: 0x19061 VA: 0x18F60
	public Vector2 get_scale() { }

	// RVA: 0x18F70 Offset: 0x19071 VA: 0x18F70
	public Vector2 get_offset() { }

	// RVA: 0x18F80 Offset: 0x19081 VA: 0x18F80
	public float get_rotation() { }

	// RVA: 0x18F90 Offset: 0x19091 VA: 0x18F90
	public AutoUnwrapSettings.Anchor get_anchor() { }

	// RVA: 0x18FA0 Offset: 0x190A1 VA: 0x18FA0
	public void .ctor(AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x1A902B0 Offset: 0x1A903B1 VA: 0x1A902B0
	public static AutoUnwrapSettings get_tile() { }

	// RVA: 0x19010 Offset: 0x19111 VA: 0x19010
	public void Reset() { }

	// RVA: 0x19090 Offset: 0x19191 VA: 0x19090 Slot: 3
	public override string ToString() { }
}

