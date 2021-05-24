internal static class UIElementsUtility // TypeDefIndex: 4132
{
	// Fields
	private static Stack<IMGUIContainer> s_ContainerStack; // 0x0
	private static Dictionary<int, Panel> s_UIElementsCache; // 0x8
	private static Event s_EventInstance; // 0x10
	internal static Color editorPlayModeTintColor; // 0x18
	internal static readonly string s_RepaintProfilerMarkerName; // 0x28
	internal static readonly string s_EventProfilerMarkerName; // 0x30
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x38
	private static readonly ProfilerMarker s_EventProfilerMarker; // 0x40

	// Methods

	// RVA: 0x15CCBD0 Offset: 0x15CCCD1 VA: 0x15CCBD0
	private static void .cctor() { }

	// RVA: 0x15CD010 Offset: 0x15CD111 VA: 0x15CD010
	internal static void MakeCurrentIMGUIContainerDirty() { }

	// RVA: 0x15CD0F0 Offset: 0x15CD1F1 VA: 0x15CD0F0
	private static void TakeCapture() { }

	// RVA: 0x15CD260 Offset: 0x15CD361 VA: 0x15CD260
	private static void ReleaseCapture() { }

	// RVA: 0x15CD270 Offset: 0x15CD371 VA: 0x15CD270
	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	// RVA: 0x15B6670 Offset: 0x15B6771 VA: 0x15B6670
	public static void RemoveCachedPanel(int instanceID) { }

	// RVA: 0x15CD8F0 Offset: 0x15CD9F1 VA: 0x15CD8F0
	private static void CleanupRoots() { }

	// RVA: 0x15CD990 Offset: 0x15CDA91 VA: 0x15CD990
	private static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x15C03D0 Offset: 0x15C04D1 VA: 0x15C03D0
	internal static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, Event evt, IMGUIContainer container) { }

	// RVA: 0x15C0580 Offset: 0x15C0681 VA: 0x15C0580
	internal static void EndContainerGUI(Event evt, Rect layoutSize) { }

	// RVA: 0x15CDA60 Offset: 0x15CDB61 VA: 0x15CDA60
	internal static EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0x15CDAE0 Offset: 0x15CDBE1 VA: 0x15CDAE0
	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	// RVA: 0x15CD390 Offset: 0x15CD491 VA: 0x15CD390
	private static bool DoDispatch(BaseVisualElementPanel panel) { }

	// RVA: 0x15CC940 Offset: 0x15CCA41 VA: 0x15CC940
	internal static void GetAllPanels(List<Panel> panels, ContextType contextType) { }

	// RVA: 0x15CDDD0 Offset: 0x15CDED1 VA: 0x15CDDD0
	internal static Dictionary.Enumerator<int, Panel> GetPanelsIterator() { }
}

