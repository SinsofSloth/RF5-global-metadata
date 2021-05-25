public abstract class FocusObjectControllerBase // TypeDefIndex: 8531
{
	// Properties
	public virtual FocusObjectType FocusObjectType { get; }
	public virtual Color TextColor { get; }

	// Methods

	// RVA: 0x1D53900 Offset: 0x1D53A01 VA: 0x1D53900 Slot: 4
	public virtual FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1D53910 Offset: 0x1D53A11 VA: 0x1D53910 Slot: 5
	public virtual Color get_TextColor() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract FocusInterface GetFocus() { }

	// RVA: 0x1D53920 Offset: 0x1D53A21 VA: 0x1D53920
	protected void .ctor() { }
}

