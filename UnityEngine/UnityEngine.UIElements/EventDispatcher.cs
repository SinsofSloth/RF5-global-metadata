public sealed class EventDispatcher // TypeDefIndex: 4106
{
	// Fields
	private List<IEventDispatchingStrategy> m_DispatchingStrategies; // 0x10
	private static readonly ObjectPool<Queue<EventDispatcher.EventRecord>> k_EventQueuePool; // 0x0
	private Queue<EventDispatcher.EventRecord> m_Queue; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x11E160 Offset: 0x11E261 VA: 0x11E160
	[DebuggerBrowsableAttribute] // RVA: 0x11E160 Offset: 0x11E261 VA: 0x11E160
	private readonly PointerDispatchState <pointerState>k__BackingField; // 0x20
	private uint m_GateCount; // 0x28
	private Stack<EventDispatcher.DispatchContext> m_DispatchContexts; // 0x30
	private bool m_Immediate; // 0x38

	// Properties
	internal PointerDispatchState pointerState { get; }
	private bool dispatchImmediately { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11F700 Offset: 0x11F801 VA: 0x11F700
	// RVA: 0x15BCAE0 Offset: 0x15BCBE1 VA: 0x15BCAE0
	internal PointerDispatchState get_pointerState() { }

	// RVA: 0x15BCAF0 Offset: 0x15BCBF1 VA: 0x15BCAF0
	internal void .ctor() { }

	// RVA: 0x15BCF40 Offset: 0x15BD041 VA: 0x15BCF40
	private bool get_dispatchImmediately() { }

	// RVA: 0x15B68F0 Offset: 0x15B69F1 VA: 0x15B68F0
	internal void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode) { }

	// RVA: 0x15BD3B0 Offset: 0x15BD4B1 VA: 0x15BD3B0
	internal void CloseGate() { }

	// RVA: 0x15BD3C0 Offset: 0x15BD4C1 VA: 0x15BD3C0
	internal void OpenGate() { }

	// RVA: 0x15BD460 Offset: 0x15BD561 VA: 0x15BD460
	private void ProcessEventQueue() { }

	// RVA: 0x15BCF60 Offset: 0x15BD061 VA: 0x15BCF60
	private void ProcessEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x15BD7C0 Offset: 0x15BD8C1 VA: 0x15BD7C0
	private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed) { }

	// RVA: 0x15BDAB0 Offset: 0x15BDBB1 VA: 0x15BDAB0
	private static void .cctor() { }
}

