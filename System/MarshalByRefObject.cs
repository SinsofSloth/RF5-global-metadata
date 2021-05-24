[ComVisibleAttribute] // RVA: 0xACDE0 Offset: 0xACEE1 VA: 0xACDE0
[Serializable]
public abstract class MarshalByRefObject // TypeDefIndex: 382
{
	// Fields
	private object _identity; // 0x10

	// Properties
	internal ServerIdentity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x18DC1B0 Offset: 0x18DC2B1 VA: 0x18DC1B0
	protected void .ctor() { }

	// RVA: 0x18DC1C0 Offset: 0x18DC2C1 VA: 0x18DC1C0
	internal ServerIdentity get_ObjectIdentity() { }

	// RVA: 0x18DC2A0 Offset: 0x18DC3A1 VA: 0x18DC2A0
	internal void set_ObjectIdentity(ServerIdentity value) { }

	// RVA: 0x18DC300 Offset: 0x18DC401 VA: 0x18DC300 Slot: 4
	public virtual ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x18DC360 Offset: 0x18DC461 VA: 0x18DC360 Slot: 5
	public virtual object InitializeLifetimeService() { }
}

