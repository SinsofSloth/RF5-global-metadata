public abstract class EventBase : IDisposable // TypeDefIndex: 4163
{
	// Fields
	private static long s_LastTypeId; // 0x0
	private static ulong s_NextEventId; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x11E9A0 Offset: 0x11EAA1 VA: 0x11E9A0
	[CompilerGeneratedAttribute] // RVA: 0x11E9A0 Offset: 0x11EAA1 VA: 0x11E9A0
	private long <timestamp>k__BackingField; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x11E9E0 Offset: 0x11EAE1 VA: 0x11E9E0
	[CompilerGeneratedAttribute] // RVA: 0x11E9E0 Offset: 0x11EAE1 VA: 0x11E9E0
	private ulong <eventId>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x11EA20 Offset: 0x11EB21 VA: 0x11EA20
	[CompilerGeneratedAttribute] // RVA: 0x11EA20 Offset: 0x11EB21 VA: 0x11EA20
	private ulong <triggerEventId>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x11EA60 Offset: 0x11EB61 VA: 0x11EA60
	[DebuggerBrowsableAttribute] // RVA: 0x11EA60 Offset: 0x11EB61 VA: 0x11EA60
	private EventBase.EventPropagation <propagation>k__BackingField; // 0x28
	private PropagationPaths m_Path; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x11EAA0 Offset: 0x11EBA1 VA: 0x11EAA0
	[DebuggerBrowsableAttribute] // RVA: 0x11EAA0 Offset: 0x11EBA1 VA: 0x11EAA0
	private EventBase.LifeCycleStatus <lifeCycleStatus>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x11EAE0 Offset: 0x11EBE1 VA: 0x11EAE0
	[DebuggerBrowsableAttribute] // RVA: 0x11EAE0 Offset: 0x11EBE1 VA: 0x11EAE0
	private IEventHandler <leafTarget>k__BackingField; // 0x40
	private IEventHandler m_Target; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x11EB20 Offset: 0x11EC21 VA: 0x11EB20
	[DebuggerBrowsableAttribute] // RVA: 0x11EB20 Offset: 0x11EC21 VA: 0x11EB20
	private readonly List<IEventHandler> <skipElements>k__BackingField; // 0x50
	[DebuggerBrowsableAttribute] // RVA: 0x11EB60 Offset: 0x11EC61 VA: 0x11EB60
	[CompilerGeneratedAttribute] // RVA: 0x11EB60 Offset: 0x11EC61 VA: 0x11EB60
	private PropagationPhase <propagationPhase>k__BackingField; // 0x58
	private IEventHandler m_CurrentTarget; // 0x60
	private Event m_ImguiEvent; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x11EBA0 Offset: 0x11ECA1 VA: 0x11EBA0
	[DebuggerBrowsableAttribute] // RVA: 0x11EBA0 Offset: 0x11ECA1 VA: 0x11EBA0
	private Vector2 <originalMousePosition>k__BackingField; // 0x70

	// Properties
	public virtual long eventTypeId { get; }
	private long timestamp { set; }
	internal ulong eventId { get; set; }
	private ulong triggerEventId { set; }
	internal EventBase.EventPropagation propagation { get; set; }
	internal PropagationPaths path { get; set; }
	private EventBase.LifeCycleStatus lifeCycleStatus { get; set; }
	public bool bubbles { get; }
	public bool tricklesDown { get; }
	internal IEventHandler leafTarget { get; set; }
	public IEventHandler target { get; set; }
	internal List<IEventHandler> skipElements { get; }
	public bool isPropagationStopped { get; set; }
	public bool isImmediatePropagationStopped { get; set; }
	public bool isDefaultPrevented { get; set; }
	public PropagationPhase propagationPhase { get; set; }
	public virtual IEventHandler currentTarget { get; set; }
	public bool dispatch { get; set; }
	private bool dispatched { get; set; }
	internal bool processed { get; set; }
	internal bool stopDispatch { get; set; }
	internal bool propagateToIMGUI { get; set; }
	private bool imguiEventIsValid { get; set; }
	public Event imguiEvent { get; set; }
	public Vector2 originalMousePosition { get; set; }
	protected bool pooled { get; set; }

	// Methods

	// RVA: 0x15BB210 Offset: 0x15BB311 VA: 0x15BB210
	protected static long RegisterEventType() { }

	// RVA: 0x15BB280 Offset: 0x15BB381 VA: 0x15BB280 Slot: 5
	public virtual long get_eventTypeId() { }

	[CompilerGeneratedAttribute] // RVA: 0x11FA60 Offset: 0x11FB61 VA: 0x11FA60
	// RVA: 0x15BB290 Offset: 0x15BB391 VA: 0x15BB290
	private void set_timestamp(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11FA70 Offset: 0x11FB71 VA: 0x11FA70
	// RVA: 0x15BB2A0 Offset: 0x15BB3A1 VA: 0x15BB2A0
	internal ulong get_eventId() { }

	[CompilerGeneratedAttribute] // RVA: 0x11FA80 Offset: 0x11FB81 VA: 0x11FA80
	// RVA: 0x15BB2B0 Offset: 0x15BB3B1 VA: 0x15BB2B0
	private void set_eventId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11FA90 Offset: 0x11FB91 VA: 0x11FA90
	// RVA: 0x15BB2C0 Offset: 0x15BB3C1 VA: 0x15BB2C0
	private void set_triggerEventId(ulong value) { }

	// RVA: 0x15BB2D0 Offset: 0x15BB3D1 VA: 0x15BB2D0
	internal void SetTriggerEventId(ulong id) { }

	[CompilerGeneratedAttribute] // RVA: 0x11FAA0 Offset: 0x11FBA1 VA: 0x11FAA0
	// RVA: 0x15BB2E0 Offset: 0x15BB3E1 VA: 0x15BB2E0
	internal EventBase.EventPropagation get_propagation() { }

	[CompilerGeneratedAttribute] // RVA: 0x11FAB0 Offset: 0x11FBB1 VA: 0x11FAB0
	// RVA: 0x15BB2F0 Offset: 0x15BB3F1 VA: 0x15BB2F0
	internal void set_propagation(EventBase.EventPropagation value) { }

	// RVA: 0x15BB300 Offset: 0x15BB401 VA: 0x15BB300
	internal PropagationPaths get_path() { }

	// RVA: 0x15BB650 Offset: 0x15BB751 VA: 0x15BB650
	internal void set_path(PropagationPaths value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11FAC0 Offset: 0x11FBC1 VA: 0x11FAC0
	// RVA: 0x15BB7D0 Offset: 0x15BB8D1 VA: 0x15BB7D0
	private EventBase.LifeCycleStatus get_lifeCycleStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x11FAD0 Offset: 0x11FBD1 VA: 0x11FAD0
	// RVA: 0x15BB7E0 Offset: 0x15BB8E1 VA: 0x15BB7E0
	private void set_lifeCycleStatus(EventBase.LifeCycleStatus value) { }

	[ObsoleteAttribute] // RVA: 0x11FAE0 Offset: 0x11FBE1 VA: 0x11FAE0
	// RVA: 0x15BB7F0 Offset: 0x15BB8F1 VA: 0x15BB7F0 Slot: 6
	protected virtual void PreDispatch() { }

	// RVA: 0x15B7B90 Offset: 0x15B7C91 VA: 0x15B7B90 Slot: 7
	protected internal virtual void PreDispatch(IPanel panel) { }

	[ObsoleteAttribute] // RVA: 0x11FB20 Offset: 0x11FC21 VA: 0x11FB20
	// RVA: 0x15BB800 Offset: 0x15BB901 VA: 0x15BB800 Slot: 8
	protected virtual void PostDispatch() { }

	// RVA: 0x15BB810 Offset: 0x15BB911 VA: 0x15BB810 Slot: 9
	protected internal virtual void PostDispatch(IPanel panel) { }

	// RVA: 0x15BB410 Offset: 0x15BB511 VA: 0x15BB410
	public bool get_bubbles() { }

	// RVA: 0x15BB400 Offset: 0x15BB501 VA: 0x15BB400
	public bool get_tricklesDown() { }

	[CompilerGeneratedAttribute] // RVA: 0x11FB60 Offset: 0x11FC61 VA: 0x11FB60
	// RVA: 0x15BB870 Offset: 0x15BB971 VA: 0x15BB870
	internal IEventHandler get_leafTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x11FB70 Offset: 0x11FC71 VA: 0x11FB70
	// RVA: 0x15BB880 Offset: 0x15BB981 VA: 0x15BB880
	private void set_leafTarget(IEventHandler value) { }

	// RVA: 0x15B9A50 Offset: 0x15B9B51 VA: 0x15B9A50
	public IEventHandler get_target() { }

	// RVA: 0x15B8B90 Offset: 0x15B8C91 VA: 0x15B8B90
	public void set_target(IEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11FB80 Offset: 0x11FC81 VA: 0x11FB80
	// RVA: 0x15BB890 Offset: 0x15BB991 VA: 0x15BB890
	internal List<IEventHandler> get_skipElements() { }

	// RVA: 0x15B86F0 Offset: 0x15B87F1 VA: 0x15B86F0
	internal bool Skip(IEventHandler h) { }

	// RVA: 0x15B7E60 Offset: 0x15B7F61 VA: 0x15B7E60
	public bool get_isPropagationStopped() { }

	// RVA: 0x15BB8A0 Offset: 0x15BB9A1 VA: 0x15BB8A0
	private void set_isPropagationStopped(bool value) { }

	// RVA: 0x15B88F0 Offset: 0x15B89F1 VA: 0x15B88F0
	public void StopPropagation() { }

	// RVA: 0x15BB8C0 Offset: 0x15BB9C1 VA: 0x15BB8C0
	public bool get_isImmediatePropagationStopped() { }

	// RVA: 0x15BB8D0 Offset: 0x15BB9D1 VA: 0x15BB8D0
	private void set_isImmediatePropagationStopped(bool value) { }

	// RVA: 0x15BB8F0 Offset: 0x15BB9F1 VA: 0x15BB8F0
	public void StopImmediatePropagation() { }

	// RVA: 0x15B8160 Offset: 0x15B8261 VA: 0x15B8160
	public bool get_isDefaultPrevented() { }

	// RVA: 0x15BB900 Offset: 0x15BBA01 VA: 0x15BB900
	private void set_isDefaultPrevented(bool value) { }

	// RVA: 0x15B8900 Offset: 0x15B8A01 VA: 0x15B8900
	public void PreventDefault() { }

	[CompilerGeneratedAttribute] // RVA: 0x11FB90 Offset: 0x11FC91 VA: 0x11FB90
	// RVA: 0x15BB920 Offset: 0x15BBA21 VA: 0x15BB920
	public PropagationPhase get_propagationPhase() { }

	[CompilerGeneratedAttribute] // RVA: 0x11FBA0 Offset: 0x11FCA1 VA: 0x11FBA0
	// RVA: 0x15BB930 Offset: 0x15BBA31 VA: 0x15BB930
	internal void set_propagationPhase(PropagationPhase value) { }

	// RVA: 0x15BB940 Offset: 0x15BBA41 VA: 0x15BB940 Slot: 10
	public virtual IEventHandler get_currentTarget() { }

	// RVA: 0x15BB950 Offset: 0x15BBA51 VA: 0x15BB950 Slot: 11
	internal virtual void set_currentTarget(IEventHandler value) { }

	// RVA: 0x15BBA80 Offset: 0x15BBB81 VA: 0x15BBA80
	public bool get_dispatch() { }

	// RVA: 0x15BBA90 Offset: 0x15BBB91 VA: 0x15BBA90
	internal void set_dispatch(bool value) { }

	// RVA: 0x15BBAD0 Offset: 0x15BBBD1 VA: 0x15BBAD0
	internal void MarkReceivedByDispatcher() { }

	// RVA: 0x15BBB60 Offset: 0x15BBC61 VA: 0x15BBB60
	private bool get_dispatched() { }

	// RVA: 0x15BBAB0 Offset: 0x15BBBB1 VA: 0x15BBAB0
	private void set_dispatched(bool value) { }

	// RVA: 0x15BBB70 Offset: 0x15BBC71 VA: 0x15BBB70
	internal bool get_processed() { }

	// RVA: 0x15BB850 Offset: 0x15BB951 VA: 0x15BB850
	private void set_processed(bool value) { }

	// RVA: 0x15BBB80 Offset: 0x15BBC81 VA: 0x15BBB80
	internal bool get_stopDispatch() { }

	// RVA: 0x15B9510 Offset: 0x15B9611 VA: 0x15B9510
	internal void set_stopDispatch(bool value) { }

	// RVA: 0x15B8920 Offset: 0x15B8A21 VA: 0x15B8920
	internal bool get_propagateToIMGUI() { }

	// RVA: 0x15B94F0 Offset: 0x15B95F1 VA: 0x15B94F0
	internal void set_propagateToIMGUI(bool value) { }

	// RVA: 0x15BBB90 Offset: 0x15BBC91 VA: 0x15BBB90
	private bool get_imguiEventIsValid() { }

	// RVA: 0x15BBBA0 Offset: 0x15BBCA1 VA: 0x15BBBA0
	private void set_imguiEventIsValid(bool value) { }

	// RVA: 0x15BBA60 Offset: 0x15BBB61 VA: 0x15BBA60
	public Event get_imguiEvent() { }

	// RVA: 0x15BBBC0 Offset: 0x15BBCC1 VA: 0x15BBBC0
	protected void set_imguiEvent(Event value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11FBB0 Offset: 0x11FCB1 VA: 0x11FBB0
	// RVA: 0x15BBCB0 Offset: 0x15BBDB1 VA: 0x15BBCB0
	public Vector2 get_originalMousePosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x11FBC0 Offset: 0x11FCC1 VA: 0x11FBC0
	// RVA: 0x15BBCC0 Offset: 0x15BBDC1 VA: 0x15BBCC0
	private void set_originalMousePosition(Vector2 value) { }

	// RVA: 0x15BBCD0 Offset: 0x15BBDD1 VA: 0x15BBCD0 Slot: 12
	protected virtual void Init() { }

	// RVA: 0x15BBCE0 Offset: 0x15BBDE1 VA: 0x15BBCE0
	private void LocalInit() { }

	// RVA: 0x15BBF40 Offset: 0x15BC041 VA: 0x15BBF40
	protected void .ctor() { }

	// RVA: 0x15BBFE0 Offset: 0x15BC0E1 VA: 0x15BBFE0
	protected bool get_pooled() { }

	// RVA: 0x15BBF20 Offset: 0x15BC021 VA: 0x15BBF20
	protected void set_pooled(bool value) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void Acquire() { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Dispose() { }

	// RVA: 0x15BBFF0 Offset: 0x15BC0F1 VA: 0x15BBFF0
	private static void .cctor() { }
}

