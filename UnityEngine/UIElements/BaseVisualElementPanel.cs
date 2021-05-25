internal abstract class BaseVisualElementPanel : IPanel // TypeDefIndex: 4123
{
	// Fields
	private float m_PixelsPerPoint; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x11E460 Offset: 0x11E561 VA: 0x11E460
	[DebuggerBrowsableAttribute] // RVA: 0x11E460 Offset: 0x11E561 VA: 0x11E460
	private bool <duringLayoutPhase>k__BackingField; // 0x14
	[DebuggerBrowsableAttribute] // RVA: 0x11E4A0 Offset: 0x11E5A1 VA: 0x11E4A0
	[CompilerGeneratedAttribute] // RVA: 0x11E4A0 Offset: 0x11E5A1 VA: 0x11E4A0
	private RepaintData <repaintData>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x11E4E0 Offset: 0x11E5E1 VA: 0x11E4E0
	[CompilerGeneratedAttribute] // RVA: 0x11E4E0 Offset: 0x11E5E1 VA: 0x11E4E0
	private bool <disposed>k__BackingField; // 0x20
	internal ElementUnderPointer m_TopElementUnderPointers; // 0x28

	// Properties
	public abstract EventInterests IMGUIEventInterests { get; }
	public abstract ScriptableObject ownerObject { get; }
	public abstract int IMGUIContainersCount { get; }
	public abstract IMGUIContainer rootIMGUIContainer { get; }
	public abstract FocusController focusController { get; }
	internal float pixelsPerPoint { set; }
	internal bool duringLayoutPhase { get; }
	internal abstract uint version { get; }
	internal virtual RepaintData repaintData { get; }
	public abstract VisualElement visualTree { get; }
	public abstract EventDispatcher dispatcher { get; }
	public abstract ContextType contextType { get; }
	internal bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	public abstract EventInterests get_IMGUIEventInterests() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ScriptableObject get_ownerObject() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_IMGUIContainersCount() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IMGUIContainer get_rootIMGUIContainer() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract FocusController get_focusController() { }

	// RVA: 0x15B6490 Offset: 0x15B6591 VA: 0x15B6490 Slot: 8
	public void Dispose() { }

	// RVA: 0x15B6510 Offset: 0x15B6611 VA: 0x15B6510 Slot: 14
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void Repaint(Event e) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void ValidateLayout() { }

	// RVA: 0x15B6700 Offset: 0x15B6801 VA: 0x15B6700
	internal void set_pixelsPerPoint(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11F800 Offset: 0x11F901 VA: 0x11F800
	// RVA: 0x15B6800 Offset: 0x15B6901 VA: 0x15B6800
	internal bool get_duringLayoutPhase() { }

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract uint get_version() { }

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag) { }

	[CompilerGeneratedAttribute] // RVA: 0x11F810 Offset: 0x11F911 VA: 0x11F810
	// RVA: 0x15B6810 Offset: 0x15B6911 VA: 0x15B6810 Slot: 19
	internal virtual RepaintData get_repaintData() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract VisualElement get_visualTree() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract EventDispatcher get_dispatcher() { }

	// RVA: 0x15B6820 Offset: 0x15B6921 VA: 0x15B6820
	internal void SendEvent(EventBase e, DispatchMode dispatchMode = 1) { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract ContextType get_contextType() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract VisualElement Pick(Vector2 point) { }

	[CompilerGeneratedAttribute] // RVA: 0x11F820 Offset: 0x11F921 VA: 0x11F820
	// RVA: 0x15B6AD0 Offset: 0x15B6BD1 VA: 0x15B6AD0
	internal bool get_disposed() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F830 Offset: 0x11F931 VA: 0x11F830
	// RVA: 0x15B6AE0 Offset: 0x15B6BE1 VA: 0x15B6AE0
	private void set_disposed(bool value) { }

	// RVA: 0x15B6AF0 Offset: 0x15B6BF1 VA: 0x15B6AF0
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0x15B6B80 Offset: 0x15B6C81 VA: 0x15B6B80
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0x15B6BB0 Offset: 0x15B6CB1 VA: 0x15B6BB0
	internal void ClearCachedElementUnderPointer(EventBase triggerEvent) { }

	// RVA: 0x15B6BF0 Offset: 0x15B6CF1 VA: 0x15B6BF0
	internal void CommitElementUnderPointers() { }
}

