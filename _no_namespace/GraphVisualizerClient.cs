public class GraphVisualizerClient // TypeDefIndex: 5940
{
	// Fields
	private static GraphVisualizerClient s_Instance; // 0x0
	private List<PlayableGraph> m_Graphs; // 0x10

	// Properties
	public static GraphVisualizerClient instance { get; }

	// Methods

	// RVA: 0x1BE3820 Offset: 0x1BE3921 VA: 0x1BE3820
	public static GraphVisualizerClient get_instance() { }

	// RVA: 0x1BE3990 Offset: 0x1BE3A91 VA: 0x1BE3990 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1BE3A40 Offset: 0x1BE3B41 VA: 0x1BE3A40
	public static void Show(PlayableGraph graph) { }

	// RVA: 0x1BE3AF0 Offset: 0x1BE3BF1 VA: 0x1BE3AF0
	public static void Hide(PlayableGraph graph) { }

	// RVA: 0x1BE3BA0 Offset: 0x1BE3CA1 VA: 0x1BE3BA0
	public static void ClearGraphs() { }

	// RVA: 0x1BE3C00 Offset: 0x1BE3D01 VA: 0x1BE3C00
	public static IEnumerable<PlayableGraph> GetGraphs() { }

	// RVA: 0x1BE3910 Offset: 0x1BE3A11 VA: 0x1BE3910
	public void .ctor() { }
}

