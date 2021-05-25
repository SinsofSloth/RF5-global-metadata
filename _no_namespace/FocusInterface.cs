public interface FocusInterface // TypeDefIndex: 7634
{
	// Properties
	public abstract bool Focusable { get; }
	public abstract FocusObjectType FocusObjectType { get; }
	public abstract int FocusPriority { get; }
	public abstract FocusPointType FocusPointType { get; }
	public abstract GameObject gameObject { get; }
	public abstract Transform transform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetFocusName() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_Focusable() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnFocus() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OffFocus() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract FocusObjectType get_FocusObjectType() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_FocusPriority() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract FocusPointType get_FocusPointType() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract ushort GetInteractionType() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract GameObject get_gameObject() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Transform get_transform() { }
}

