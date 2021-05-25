public class TMP_UpdateManager // TypeDefIndex: 5881
{
	// Fields
	private static TMP_UpdateManager s_Instance; // 0x0
	private readonly HashSet<int> m_LayoutQueueLookup; // 0x10
	private readonly List<TMP_Text> m_LayoutRebuildQueue; // 0x18
	private readonly HashSet<int> m_GraphicQueueLookup; // 0x20
	private readonly List<TMP_Text> m_GraphicRebuildQueue; // 0x28
	private readonly HashSet<int> m_InternalUpdateLookup; // 0x30
	private readonly List<TMP_Text> m_InternalUpdateQueue; // 0x38
	private readonly HashSet<int> m_CullingUpdateLookup; // 0x40
	private readonly List<TMP_Text> m_CullingUpdateQueue; // 0x48

	// Properties
	private static TMP_UpdateManager instance { get; }

	// Methods

	// RVA: 0x15A1B10 Offset: 0x15A1C11 VA: 0x15A1B10
	private static TMP_UpdateManager get_instance() { }

	// RVA: 0x15A1BB0 Offset: 0x15A1CB1 VA: 0x15A1BB0
	private void .ctor() { }

	// RVA: 0x15A1D80 Offset: 0x15A1E81 VA: 0x15A1D80
	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x15A1E20 Offset: 0x15A1F21 VA: 0x15A1E20
	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x15A1EF0 Offset: 0x15A1FF1 VA: 0x15A1EF0
	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x15A1F90 Offset: 0x15A2091 VA: 0x15A1F90
	private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x15A2060 Offset: 0x15A2161 VA: 0x15A2060
	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x15A2100 Offset: 0x15A2201 VA: 0x15A2100
	private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x15A21D0 Offset: 0x15A22D1 VA: 0x15A21D0
	public static void RegisterTextElementForCullingUpdate(TMP_Text element) { }

	// RVA: 0x15A2270 Offset: 0x15A2371 VA: 0x15A2270
	private void InternalRegisterTextElementForCullingUpdate(TMP_Text element) { }

	// RVA: 0x15A2340 Offset: 0x15A2441 VA: 0x15A2340
	private void OnCameraPreCull() { }

	// RVA: 0x15A2350 Offset: 0x15A2451 VA: 0x15A2350
	private void DoRebuilds() { }

	// RVA: 0x15A25B0 Offset: 0x15A26B1 VA: 0x15A25B0
	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x15A26F0 Offset: 0x15A27F1 VA: 0x15A26F0
	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	// RVA: 0x15A2870 Offset: 0x15A2971 VA: 0x15A2870
	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x15A2910 Offset: 0x15A2A11 VA: 0x15A2910
	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x15A2650 Offset: 0x15A2751 VA: 0x15A2650
	private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) { }
}

