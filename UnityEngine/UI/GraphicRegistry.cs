public class GraphicRegistry // TypeDefIndex: 3932
{
	// Fields
	private static GraphicRegistry s_Instance; // 0x0
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
	private static readonly List<Graphic> s_EmptyList; // 0x8

	// Properties
	public static GraphicRegistry instance { get; }

	// Methods

	// RVA: 0x186ADB0 Offset: 0x186AEB1 VA: 0x186ADB0
	protected void .ctor() { }

	// RVA: 0x186AEE0 Offset: 0x186AFE1 VA: 0x186AEE0
	public static GraphicRegistry get_instance() { }

	// RVA: 0x1865370 Offset: 0x1865471 VA: 0x1865370
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1864F50 Offset: 0x1865051 VA: 0x1864F50
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x186A0A0 Offset: 0x186A1A1 VA: 0x186A0A0
	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x186AFC0 Offset: 0x186B0C1 VA: 0x186AFC0
	private static void .cctor() { }
}

