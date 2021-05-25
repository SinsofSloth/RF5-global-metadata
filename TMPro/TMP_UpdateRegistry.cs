public class TMP_UpdateRegistry // TypeDefIndex: 5882
{
	// Fields
	private static TMP_UpdateRegistry s_Instance; // 0x0
	private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
	private HashSet<int> m_LayoutQueueLookup; // 0x18
	private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
	private HashSet<int> m_GraphicQueueLookup; // 0x28

	// Properties
	public static TMP_UpdateRegistry instance { get; }

	// Methods

	// RVA: 0x15A29B0 Offset: 0x15A2AB1 VA: 0x15A29B0
	public static TMP_UpdateRegistry get_instance() { }

	// RVA: 0x15A2A50 Offset: 0x15A2B51 VA: 0x15A2A50
	protected void .ctor() { }

	// RVA: 0x15A2B90 Offset: 0x15A2C91 VA: 0x15A2B90
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x15A2C30 Offset: 0x15A2D31 VA: 0x15A2C30
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x15A2D40 Offset: 0x15A2E41 VA: 0x15A2D40
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x15A2DE0 Offset: 0x15A2EE1 VA: 0x15A2DE0
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x15A2EF0 Offset: 0x15A2FF1 VA: 0x15A2EF0
	private void PerformUpdateForCanvasRendererObjects() { }

	// RVA: 0x15A3200 Offset: 0x15A3301 VA: 0x15A3200
	private void PerformUpdateForMeshRendererObjects() { }

	// RVA: 0x15A3270 Offset: 0x15A3371 VA: 0x15A3270
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x15A3380 Offset: 0x15A3481 VA: 0x15A3380
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x15A34C0 Offset: 0x15A35C1 VA: 0x15A34C0
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }
}

