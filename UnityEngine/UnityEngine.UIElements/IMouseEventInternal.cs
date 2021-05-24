internal interface IMouseEventInternal // TypeDefIndex: 4192
{
	// Properties
	public abstract bool triggeredByOS { get; set; }
	public abstract bool recomputeTopElementUnderMouse { get; set; }
	public abstract IPointerEvent sourcePointerEvent { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_triggeredByOS() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_triggeredByOS(bool value) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_recomputeTopElementUnderMouse() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_recomputeTopElementUnderMouse(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IPointerEvent get_sourcePointerEvent() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_sourcePointerEvent(IPointerEvent value) { }
}

