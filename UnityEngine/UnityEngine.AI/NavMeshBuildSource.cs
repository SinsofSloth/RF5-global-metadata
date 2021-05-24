[UsedByNativeCodeAttribute] // RVA: 0x1093C0 Offset: 0x1094C1 VA: 0x1093C0
[NativeHeaderAttribute] // RVA: 0x1093C0 Offset: 0x1094C1 VA: 0x1093C0
public struct NavMeshBuildSource // TypeDefIndex: 3785
{
	// Fields
	private Matrix4x4 m_Transform; // 0x0
	private Vector3 m_Size; // 0x40
	private NavMeshBuildSourceShape m_Shape; // 0x4C
	private int m_Area; // 0x50
	private int m_InstanceID; // 0x54
	private int m_ComponentID; // 0x58

	// Properties
	public Matrix4x4 transform { get; set; }
	public Vector3 size { get; set; }
	public NavMeshBuildSourceShape shape { get; set; }
	public int area { set; }
	public Object sourceObject { get; }
	public Component component { get; }

	// Methods

	// RVA: 0x22DC0 Offset: 0x22EC1 VA: 0x22DC0
	public Matrix4x4 get_transform() { }

	// RVA: 0x22DF0 Offset: 0x22EF1 VA: 0x22DF0
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x22E10 Offset: 0x22F11 VA: 0x22E10
	public Vector3 get_size() { }

	// RVA: 0x22E20 Offset: 0x22F21 VA: 0x22E20
	public void set_size(Vector3 value) { }

	// RVA: 0x22E30 Offset: 0x22F31 VA: 0x22E30
	public NavMeshBuildSourceShape get_shape() { }

	// RVA: 0x22E40 Offset: 0x22F41 VA: 0x22E40
	public void set_shape(NavMeshBuildSourceShape value) { }

	// RVA: 0x22E50 Offset: 0x22F51 VA: 0x22E50
	public void set_area(int value) { }

	// RVA: 0x22E60 Offset: 0x22F61 VA: 0x22E60
	public Object get_sourceObject() { }

	// RVA: 0x22EB0 Offset: 0x22FB1 VA: 0x22EB0
	public Component get_component() { }

	[StaticAccessorAttribute] // RVA: 0x10A1E0 Offset: 0x10A2E1 VA: 0x10A1E0
	// RVA: 0x1BAE700 Offset: 0x1BAE801 VA: 0x1BAE700
	private static Component InternalGetComponent(int instanceID) { }

	[StaticAccessorAttribute] // RVA: 0x10A220 Offset: 0x10A321 VA: 0x10A220
	// RVA: 0x1BAE660 Offset: 0x1BAE761 VA: 0x1BAE660
	private static Object InternalGetObject(int instanceID) { }
}

