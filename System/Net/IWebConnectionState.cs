internal interface IWebConnectionState // TypeDefIndex: 1982
{
	// Properties
	public abstract WebConnectionGroup Group { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract WebConnectionGroup get_Group() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool TrySetBusy() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetIdle() { }
}

