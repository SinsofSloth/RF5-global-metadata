internal class Panel : BaseVisualElementPanel // TypeDefIndex: 4124
{
	// Fields
	private VisualElement m_RootContainer; // 0x30
	private VisualTreeUpdater m_VisualTreeUpdater; // 0x38
	private uint m_Version; // 0x40
	private uint m_RepaintVersion; // 0x44
	private ProfilerMarker m_MarkerUpdate; // 0x48
	private static ProfilerMarker s_MarkerPickAll; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11E520 Offset: 0x11E621 VA: 0x11E520
	[DebuggerBrowsableAttribute] // RVA: 0x11E520 Offset: 0x11E621 VA: 0x11E520
	private EventDispatcher <dispatcher>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x11E560 Offset: 0x11E661 VA: 0x11E560
	[DebuggerBrowsableAttribute] // RVA: 0x11E560 Offset: 0x11E661 VA: 0x11E560
	private ScriptableObject <ownerObject>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x11E5A0 Offset: 0x11E6A1 VA: 0x11E5A0
	[DebuggerBrowsableAttribute] // RVA: 0x11E5A0 Offset: 0x11E6A1 VA: 0x11E5A0
	private ContextType <contextType>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x11E5E0 Offset: 0x11E6E1 VA: 0x11E5E0
	[DebuggerBrowsableAttribute] // RVA: 0x11E5E0 Offset: 0x11E6E1 VA: 0x11E5E0
	private FocusController <focusController>k__BackingField; // 0x68
	[DebuggerBrowsableAttribute] // RVA: 0x11E620 Offset: 0x11E721 VA: 0x11E620
	[CompilerGeneratedAttribute] // RVA: 0x11E620 Offset: 0x11E721 VA: 0x11E620
	private EventInterests <IMGUIEventInterests>k__BackingField; // 0x70
	[DebuggerBrowsableAttribute] // RVA: 0x11E660 Offset: 0x11E761 VA: 0x11E660
	[CompilerGeneratedAttribute] // RVA: 0x11E660 Offset: 0x11E761 VA: 0x11E660
	private int <IMGUIContainersCount>k__BackingField; // 0x74
	[CompilerGeneratedAttribute] // RVA: 0x11E6A0 Offset: 0x11E7A1 VA: 0x11E6A0
	[DebuggerBrowsableAttribute] // RVA: 0x11E6A0 Offset: 0x11E7A1 VA: 0x11E6A0
	private IMGUIContainer <rootIMGUIContainer>k__BackingField; // 0x78
	private bool m_ValidatingLayout; // 0x80

	// Properties
	public override VisualElement visualTree { get; }
	public override EventDispatcher dispatcher { get; }
	public override ScriptableObject ownerObject { get; }
	public override ContextType contextType { get; }
	public override FocusController focusController { get; }
	public override EventInterests IMGUIEventInterests { get; }
	public override int IMGUIContainersCount { get; }
	public override IMGUIContainer rootIMGUIContainer { get; }
	internal override uint version { get; }

	// Methods

	// RVA: 0x15C41B0 Offset: 0x15C42B1 VA: 0x15C41B0 Slot: 20
	public override VisualElement get_visualTree() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F840 Offset: 0x11F941 VA: 0x11F840
	// RVA: 0x15C41C0 Offset: 0x15C42C1 VA: 0x15C41C0 Slot: 21
	public override EventDispatcher get_dispatcher() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F850 Offset: 0x11F951 VA: 0x11F850
	// RVA: 0x15C41D0 Offset: 0x15C42D1 VA: 0x15C41D0 Slot: 10
	public override ScriptableObject get_ownerObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F860 Offset: 0x11F961 VA: 0x11F860
	// RVA: 0x15C41E0 Offset: 0x15C42E1 VA: 0x15C41E0 Slot: 22
	public override ContextType get_contextType() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F870 Offset: 0x11F971 VA: 0x11F870
	// RVA: 0x15C41F0 Offset: 0x15C42F1 VA: 0x15C41F0 Slot: 13
	public override FocusController get_focusController() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F880 Offset: 0x11F981 VA: 0x11F880
	// RVA: 0x15C4200 Offset: 0x15C4301 VA: 0x15C4200 Slot: 9
	public override EventInterests get_IMGUIEventInterests() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F890 Offset: 0x11F991 VA: 0x11F890
	// RVA: 0x15C4210 Offset: 0x15C4311 VA: 0x15C4210 Slot: 11
	public override int get_IMGUIContainersCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F8A0 Offset: 0x11F9A1 VA: 0x11F8A0
	// RVA: 0x15C4220 Offset: 0x15C4321 VA: 0x15C4220 Slot: 12
	public override IMGUIContainer get_rootIMGUIContainer() { }

	// RVA: 0x15C4230 Offset: 0x15C4331 VA: 0x15C4230 Slot: 17
	internal override uint get_version() { }

	// RVA: 0x15C4240 Offset: 0x15C4341 VA: 0x15C4240
	private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked) { }

	// RVA: 0x15C42D0 Offset: 0x15C43D1 VA: 0x15C42D0
	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked) { }

	// RVA: 0x15C4950 Offset: 0x15C4A51 VA: 0x15C4950 Slot: 23
	public override VisualElement Pick(Vector2 point) { }

	// RVA: 0x15C4B30 Offset: 0x15C4C31 VA: 0x15C4B30 Slot: 16
	public override void ValidateLayout() { }

	// RVA: 0x15C4BB0 Offset: 0x15C4CB1 VA: 0x15C4BB0
	private void UpdateForRepaint() { }

	// RVA: 0x15C4C30 Offset: 0x15C4D31 VA: 0x15C4C30 Slot: 15
	public override void Repaint(Event e) { }

	// RVA: 0x15C4DB0 Offset: 0x15C4EB1 VA: 0x15C4DB0 Slot: 18
	internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x15C4DE0 Offset: 0x15C4EE1 VA: 0x15C4DE0
	private static void .cctor() { }
}

