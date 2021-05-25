[NativeHeaderAttribute] // RVA: 0x1092D0 Offset: 0x1093D1 VA: 0x1092D0
public sealed class NavMeshData : Object // TypeDefIndex: 3776
{
	// Properties
	public Bounds sourceBounds { get; }
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }

	// Methods

	// RVA: 0x1BAF2C0 Offset: 0x1BAF3C1 VA: 0x1BAF2C0
	public void .ctor() { }

	// RVA: 0x1BAEE40 Offset: 0x1BAEF41 VA: 0x1BAEE40
	public void .ctor(int agentTypeID) { }

	[StaticAccessorAttribute] // RVA: 0x109D90 Offset: 0x109E91 VA: 0x109D90
	// RVA: 0x1BAF360 Offset: 0x1BAF461 VA: 0x1BAF360
	private static void Internal_Create(NavMeshData mono, int agentTypeID) { }

	// RVA: 0x1BAF3B0 Offset: 0x1BAF4B1 VA: 0x1BAF3B0
	public Bounds get_sourceBounds() { }

	// RVA: 0x1BAF470 Offset: 0x1BAF571 VA: 0x1BAF470
	public Vector3 get_position() { }

	// RVA: 0x1BAEEE0 Offset: 0x1BAEFE1 VA: 0x1BAEEE0
	public void set_position(Vector3 value) { }

	// RVA: 0x1BAF570 Offset: 0x1BAF671 VA: 0x1BAF570
	public Quaternion get_rotation() { }

	// RVA: 0x1BAEF40 Offset: 0x1BAF041 VA: 0x1BAEF40
	public void set_rotation(Quaternion value) { }

	// RVA: 0x1BAF420 Offset: 0x1BAF521 VA: 0x1BAF420
	private void get_sourceBounds_Injected(out Bounds ret) { }

	// RVA: 0x1BAF4D0 Offset: 0x1BAF5D1 VA: 0x1BAF4D0
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x1BAF520 Offset: 0x1BAF621 VA: 0x1BAF520
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x1BAF5D0 Offset: 0x1BAF6D1 VA: 0x1BAF5D0
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x1BAF620 Offset: 0x1BAF721 VA: 0x1BAF620
	private void set_rotation_Injected(ref Quaternion value) { }
}

