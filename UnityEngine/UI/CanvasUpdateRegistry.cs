public class CanvasUpdateRegistry // TypeDefIndex: 3908
{
	// Fields
	private static CanvasUpdateRegistry s_Instance; // 0x0
	private bool m_PerformingLayoutUpdate; // 0x10
	private bool m_PerformingGraphicUpdate; // 0x11
	private string[] m_CanvasUpdateProfilerStrings; // 0x18
	private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";
	private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; // 0x20
	private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; // 0x28
	private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; // 0x8

	// Properties
	public static CanvasUpdateRegistry instance { get; }

	// Methods

	// RVA: 0x16470F0 Offset: 0x16471F1 VA: 0x16470F0
	protected void .ctor() { }

	// RVA: 0x16473A0 Offset: 0x16474A1 VA: 0x16473A0
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x1647480 Offset: 0x1647581 VA: 0x1647480
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x1647580 Offset: 0x1647681 VA: 0x1647580
	private void CleanInvalidItems() { }

	// RVA: 0x16478C0 Offset: 0x16479C1 VA: 0x16478C0
	private void PerformUpdate() { }

	// RVA: 0x1648270 Offset: 0x1648371 VA: 0x1648270
	private static int ParentCount(Transform child) { }

	// RVA: 0x1648350 Offset: 0x1648451 VA: 0x1648350
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x16484D0 Offset: 0x16485D1 VA: 0x16484D0
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1648660 Offset: 0x1648761 VA: 0x1648660
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x16485C0 Offset: 0x16486C1 VA: 0x16485C0
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1648750 Offset: 0x1648851 VA: 0x1648750
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1648890 Offset: 0x1648991 VA: 0x1648890
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x16487C0 Offset: 0x16488C1 VA: 0x16487C0
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1648900 Offset: 0x1648A01 VA: 0x1648900
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x1648980 Offset: 0x1648A81 VA: 0x1648980
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1648AE0 Offset: 0x1648BE1 VA: 0x1648AE0
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1648C40 Offset: 0x1648D41 VA: 0x1648C40
	public static bool IsRebuildingLayout() { }

	// RVA: 0x1648CB0 Offset: 0x1648DB1 VA: 0x1648CB0
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x1648D20 Offset: 0x1648E21 VA: 0x1648D20
	private static void .cctor() { }
}

