public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 4090
{
	// Fields
	private BaseRaycaster m_RootRaycaster; // 0x18

	// Properties
	public abstract Camera eventCamera { get; }
	[ObsoleteAttribute] // RVA: 0x11DC60 Offset: 0x11DD61 VA: 0x11DC60
	public virtual int priority { get; }
	public virtual int sortOrderPriority { get; }
	public virtual int renderOrderPriority { get; }
	public BaseRaycaster rootRaycaster { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Camera get_eventCamera() { }

	// RVA: 0x1638C80 Offset: 0x1638D81 VA: 0x1638C80 Slot: 19
	public virtual int get_priority() { }

	// RVA: 0x1638C90 Offset: 0x1638D91 VA: 0x1638C90 Slot: 20
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x1638CA0 Offset: 0x1638DA1 VA: 0x1638CA0 Slot: 21
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x1638CB0 Offset: 0x1638DB1 VA: 0x1638CB0
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x1638D90 Offset: 0x1638E91 VA: 0x1638D90 Slot: 3
	public override string ToString() { }

	// RVA: 0x16390B0 Offset: 0x16391B1 VA: 0x16390B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1639200 Offset: 0x1639301 VA: 0x1639200 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1639350 Offset: 0x1639451 VA: 0x1639350 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1639370 Offset: 0x1639471 VA: 0x1639370 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1639390 Offset: 0x1639491 VA: 0x1639390
	protected void .ctor() { }
}

