[RequiredByNativeCodeAttribute] // RVA: 0xFAEC0 Offset: 0xFAFC1 VA: 0xFAEC0
public class Collision2D // TypeDefIndex: 3642
{
	// Fields
	internal int m_Collider; // 0x10
	internal int m_OtherCollider; // 0x14
	internal int m_Rigidbody; // 0x18
	internal int m_OtherRigidbody; // 0x1C
	internal Vector2 m_RelativeVelocity; // 0x20
	internal int m_Enabled; // 0x28
	internal int m_ContactCount; // 0x2C
	internal ContactPoint2D[] m_ReusedContacts; // 0x30
	internal ContactPoint2D[] m_LegacyContacts; // 0x38

	// Properties
	public Collider2D collider { get; }
	public Rigidbody2D rigidbody { get; }
	public GameObject gameObject { get; }
	public Vector2 relativeVelocity { get; }

	// Methods

	// RVA: 0x1BC3500 Offset: 0x1BC3601 VA: 0x1BC3500
	public Collider2D get_collider() { }

	// RVA: 0x1BC35E0 Offset: 0x1BC36E1 VA: 0x1BC35E0
	public Rigidbody2D get_rigidbody() { }

	// RVA: 0x1BC3680 Offset: 0x1BC3781 VA: 0x1BC3680
	public GameObject get_gameObject() { }

	// RVA: 0x1BC3880 Offset: 0x1BC3981 VA: 0x1BC3880
	public Vector2 get_relativeVelocity() { }
}

