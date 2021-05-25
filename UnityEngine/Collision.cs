[RequiredByNativeCodeAttribute] // RVA: 0xE0F40 Offset: 0xE1041 VA: 0xE0F40
public class Collision // TypeDefIndex: 3422
{
	// Fields
	internal Vector3 m_Impulse; // 0x10
	internal Vector3 m_RelativeVelocity; // 0x1C
	internal Rigidbody m_Rigidbody; // 0x28
	internal Collider m_Collider; // 0x30
	internal int m_ContactCount; // 0x38
	internal ContactPoint[] m_ReusedContacts; // 0x40
	internal ContactPoint[] m_LegacyContacts; // 0x48

	// Properties
	public Vector3 relativeVelocity { get; }
	public Rigidbody rigidbody { get; }
	public Collider collider { get; }
	public GameObject gameObject { get; }
	public ContactPoint[] contacts { get; }

	// Methods

	// RVA: 0x350C1B0 Offset: 0x350C2B1 VA: 0x350C1B0
	public Vector3 get_relativeVelocity() { }

	// RVA: 0x350C1C0 Offset: 0x350C2C1 VA: 0x350C1C0
	public Rigidbody get_rigidbody() { }

	// RVA: 0x350C1D0 Offset: 0x350C2D1 VA: 0x350C1D0
	public Collider get_collider() { }

	// RVA: 0x350C1E0 Offset: 0x350C2E1 VA: 0x350C1E0
	public GameObject get_gameObject() { }

	// RVA: 0x350C270 Offset: 0x350C371 VA: 0x350C270
	public ContactPoint[] get_contacts() { }
}

