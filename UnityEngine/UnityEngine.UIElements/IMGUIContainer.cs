public class IMGUIContainer : VisualElement, IDisposable // TypeDefIndex: 4114
{
	// Fields
	private Action m_OnGUIHandler; // 0x158
	private ObjectGUIState m_ObjectGUIState; // 0x160
	internal bool useOwnerObjectGUIState; // 0x168
	[DebuggerBrowsableAttribute] // RVA: 0x11E320 Offset: 0x11E421 VA: 0x11E320
	[CompilerGeneratedAttribute] // RVA: 0x11E320 Offset: 0x11E421 VA: 0x11E320
	private Rect <lastWorldClip>k__BackingField; // 0x16C
	private GUILayoutUtility.LayoutCache m_Cache; // 0x180
	private Rect m_CachedClippingRect; // 0x188
	private Matrix4x4 m_CachedTransform; // 0x198
	[DebuggerBrowsableAttribute] // RVA: 0x11E360 Offset: 0x11E461 VA: 0x11E360
	[CompilerGeneratedAttribute] // RVA: 0x11E360 Offset: 0x11E461 VA: 0x11E360
	private ContextType <contextType>k__BackingField; // 0x1D8
	private bool lostFocus; // 0x1DC
	private bool receivedFocus; // 0x1DD
	private FocusChangeDirection focusChangeDirection; // 0x1E0
	private bool hasFocusableControls; // 0x1E8
	private int newKeyboardFocusControlID; // 0x1EC
	[DebuggerBrowsableAttribute] // RVA: 0x11E3A0 Offset: 0x11E4A1 VA: 0x11E3A0
	[CompilerGeneratedAttribute] // RVA: 0x11E3A0 Offset: 0x11E4A1 VA: 0x11E3A0
	private bool <focusOnlyIfHasFocusableControls>k__BackingField; // 0x1F0
	public static readonly string ussClassName; // 0x0
	private IMGUIContainer.GUIGlobals m_GUIGlobals; // 0x1F4

	// Properties
	public Action onGUIHandler { get; }
	internal ObjectGUIState guiState { get; }
	internal Rect lastWorldClip { get; }
	private GUILayoutUtility.LayoutCache cache { get; }
	private float layoutMeasuredWidth { get; }
	private float layoutMeasuredHeight { get; }
	public ContextType contextType { get; }
	internal bool focusOnlyIfHasFocusableControls { get; }

	// Methods

	// RVA: 0x15BEF20 Offset: 0x15BF021 VA: 0x15BEF20
	public Action get_onGUIHandler() { }

	// RVA: 0x15BEF30 Offset: 0x15BF031 VA: 0x15BEF30
	internal ObjectGUIState get_guiState() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F780 Offset: 0x11F881 VA: 0x11F780
	// RVA: 0x15BEFF0 Offset: 0x15BF0F1 VA: 0x15BEFF0
	internal Rect get_lastWorldClip() { }

	// RVA: 0x15BF010 Offset: 0x15BF111 VA: 0x15BF010
	private GUILayoutUtility.LayoutCache get_cache() { }

	// RVA: 0x15BF0A0 Offset: 0x15BF1A1 VA: 0x15BF0A0
	private float get_layoutMeasuredWidth() { }

	// RVA: 0x15BF1A0 Offset: 0x15BF2A1 VA: 0x15BF1A0
	private float get_layoutMeasuredHeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F790 Offset: 0x11F891 VA: 0x11F790
	// RVA: 0x15BF2A0 Offset: 0x15BF3A1 VA: 0x15BF2A0
	public ContextType get_contextType() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F7A0 Offset: 0x11F8A1 VA: 0x11F7A0
	// RVA: 0x15BF2B0 Offset: 0x15BF3B1 VA: 0x15BF2B0
	internal bool get_focusOnlyIfHasFocusableControls() { }

	// RVA: 0x15BF2C0 Offset: 0x15BF3C1 VA: 0x15BF2C0
	private void SaveGlobals() { }

	// RVA: 0x15BF3F0 Offset: 0x15BF4F1 VA: 0x15BF3F0
	private void RestoreGlobals() { }

	// RVA: 0x15BF560 Offset: 0x15BF661 VA: 0x15BF560
	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = True) { }

	// RVA: 0x15C07B0 Offset: 0x15C08B1 VA: 0x15C07B0
	public void MarkDirtyLayout() { }

	// RVA: 0x15B8760 Offset: 0x15B8861 VA: 0x15B8760
	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = True) { }

	// RVA: 0x15C07E0 Offset: 0x15C08E1 VA: 0x15C07E0
	internal bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	// RVA: 0x15C07F0 Offset: 0x15C08F1 VA: 0x15C07F0
	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0x15C0AE0 Offset: 0x15C0BE1 VA: 0x15C0AE0
	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0x15C08E0 Offset: 0x15C09E1 VA: 0x15C08E0
	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	// RVA: 0x15C1130 Offset: 0x15C1231 VA: 0x15C1130 Slot: 18
	public void Dispose() { }

	// RVA: 0x15C11B0 Offset: 0x15C12B1 VA: 0x15C11B0 Slot: 19
	protected virtual void Dispose(bool disposeManaged) { }

	// RVA: 0x15C11D0 Offset: 0x15C12D1 VA: 0x15C11D0
	private static void .cctor() { }
}

