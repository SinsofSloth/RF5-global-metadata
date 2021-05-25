[Serializable]
public sealed class Vertex : IEquatable<Vertex> // TypeDefIndex: 5977
{
	// Fields
	[SerializeField] // RVA: 0x142450 Offset: 0x142551 VA: 0x142450
	private Vector3 m_Position; // 0x10
	[SerializeField] // RVA: 0x142460 Offset: 0x142561 VA: 0x142460
	private Color m_Color; // 0x1C
	[SerializeField] // RVA: 0x142470 Offset: 0x142571 VA: 0x142470
	private Vector3 m_Normal; // 0x2C
	[SerializeField] // RVA: 0x142480 Offset: 0x142581 VA: 0x142480
	private Vector4 m_Tangent; // 0x38
	[SerializeField] // RVA: 0x142490 Offset: 0x142591 VA: 0x142490
	private Vector2 m_UV0; // 0x48
	[SerializeField] // RVA: 0x1424A0 Offset: 0x1425A1 VA: 0x1424A0
	private Vector2 m_UV2; // 0x50
	[SerializeField] // RVA: 0x1424B0 Offset: 0x1425B1 VA: 0x1424B0
	private Vector4 m_UV3; // 0x58
	[SerializeField] // RVA: 0x1424C0 Offset: 0x1425C1 VA: 0x1424C0
	private Vector4 m_UV4; // 0x68
	[SerializeField] // RVA: 0x1424D0 Offset: 0x1425D1 VA: 0x1424D0
	private MeshArrays m_Attributes; // 0x78

	// Properties
	public Vector3 position { get; set; }
	public Color color { set; }
	public Vector3 normal { get; set; }
	public Vector4 tangent { set; }
	public Vector2 uv0 { get; set; }
	public Vector2 uv2 { set; }
	public Vector4 uv3 { set; }
	public Vector4 uv4 { set; }
	private bool hasPosition { get; set; }
	private bool hasColor { get; set; }
	private bool hasNormal { get; set; }
	private bool hasTangent { get; set; }
	private bool hasUV0 { get; set; }
	private bool hasUV2 { get; set; }
	private bool hasUV3 { get; set; }
	private bool hasUV4 { get; set; }

	// Methods

	// RVA: 0x1AA5F10 Offset: 0x1AA6011 VA: 0x1AA5F10
	public Vector3 get_position() { }

	// RVA: 0x1A99AD0 Offset: 0x1A99BD1 VA: 0x1A99AD0
	public void set_position(Vector3 value) { }

	// RVA: 0x1A99B00 Offset: 0x1A99C01 VA: 0x1A99B00
	public void set_color(Color value) { }

	// RVA: 0x1AA5F80 Offset: 0x1AA6081 VA: 0x1AA5F80
	public Vector3 get_normal() { }

	// RVA: 0x1A99B30 Offset: 0x1A99C31 VA: 0x1A99B30
	public void set_normal(Vector3 value) { }

	// RVA: 0x1A99B60 Offset: 0x1A99C61 VA: 0x1A99B60
	public void set_tangent(Vector4 value) { }

	// RVA: 0x1AA5FF0 Offset: 0x1AA60F1 VA: 0x1AA5FF0
	public Vector2 get_uv0() { }

	// RVA: 0x1A99B90 Offset: 0x1A99C91 VA: 0x1A99B90
	public void set_uv0(Vector2 value) { }

	// RVA: 0x1A99BC0 Offset: 0x1A99CC1 VA: 0x1A99BC0
	public void set_uv2(Vector2 value) { }

	// RVA: 0x1A99BF0 Offset: 0x1A99CF1 VA: 0x1A99BF0
	public void set_uv3(Vector4 value) { }

	// RVA: 0x1A99C20 Offset: 0x1A99D21 VA: 0x1A99C20
	public void set_uv4(Vector4 value) { }

	// RVA: 0x1A99EF0 Offset: 0x1A99FF1 VA: 0x1A99EF0
	public bool HasArrays(MeshArrays attribute) { }

	// RVA: 0x1AA60C0 Offset: 0x1AA61C1 VA: 0x1AA60C0
	private bool get_hasPosition() { }

	// RVA: 0x1AA5F20 Offset: 0x1AA6021 VA: 0x1AA5F20
	private void set_hasPosition(bool value) { }

	// RVA: 0x1AA60D0 Offset: 0x1AA61D1 VA: 0x1AA60D0
	private bool get_hasColor() { }

	// RVA: 0x1AA5F50 Offset: 0x1AA6051 VA: 0x1AA5F50
	private void set_hasColor(bool value) { }

	// RVA: 0x1AA60E0 Offset: 0x1AA61E1 VA: 0x1AA60E0
	private bool get_hasNormal() { }

	// RVA: 0x1AA5F90 Offset: 0x1AA6091 VA: 0x1AA5F90
	private void set_hasNormal(bool value) { }

	// RVA: 0x1AA60F0 Offset: 0x1AA61F1 VA: 0x1AA60F0
	private bool get_hasTangent() { }

	// RVA: 0x1AA5FC0 Offset: 0x1AA60C1 VA: 0x1AA5FC0
	private void set_hasTangent(bool value) { }

	// RVA: 0x1AA6100 Offset: 0x1AA6201 VA: 0x1AA6100
	private bool get_hasUV0() { }

	// RVA: 0x1AA6000 Offset: 0x1AA6101 VA: 0x1AA6000
	private void set_hasUV0(bool value) { }

	// RVA: 0x1AA6110 Offset: 0x1AA6211 VA: 0x1AA6110
	private bool get_hasUV2() { }

	// RVA: 0x1AA6030 Offset: 0x1AA6131 VA: 0x1AA6030
	private void set_hasUV2(bool value) { }

	// RVA: 0x1AA6120 Offset: 0x1AA6221 VA: 0x1AA6120
	private bool get_hasUV3() { }

	// RVA: 0x1AA6060 Offset: 0x1AA6161 VA: 0x1AA6060
	private void set_hasUV3(bool value) { }

	// RVA: 0x1AA6130 Offset: 0x1AA6231 VA: 0x1AA6130
	private bool get_hasUV4() { }

	// RVA: 0x1AA6090 Offset: 0x1AA6191 VA: 0x1AA6090
	private void set_hasUV4(bool value) { }

	// RVA: 0x1A99AC0 Offset: 0x1A99BC1 VA: 0x1A99AC0
	public void .ctor() { }

	// RVA: 0x1AA6140 Offset: 0x1AA6241 VA: 0x1AA6140 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1AA61D0 Offset: 0x1AA62D1 VA: 0x1AA61D0 Slot: 4
	public bool Equals(Vertex other) { }

	// RVA: 0x1AA63D0 Offset: 0x1AA64D1 VA: 0x1AA63D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A99EC0 Offset: 0x1A99FC1 VA: 0x1A99EC0
	public static bool op_Equality(Vertex a, Vertex b) { }

	// RVA: 0x1A9A040 Offset: 0x1A9A141 VA: 0x1A9A040
	public static void GetArrays(IList<Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4) { }

	// RVA: 0x1AA6590 Offset: 0x1AA6691 VA: 0x1AA6590
	public static void GetArrays(IList<Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4, MeshArrays attributes) { }
}

