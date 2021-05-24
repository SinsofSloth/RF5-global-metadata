public class ClipperRegistry // TypeDefIndex: 3910
{
	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly IndexedSet<IClipper> m_Clippers; // 0x10

	// Properties
	public static ClipperRegistry instance { get; }

	// Methods

	// RVA: 0x1648DB0 Offset: 0x1648EB1 VA: 0x1648DB0
	protected void .ctor() { }

	// RVA: 0x1648070 Offset: 0x1648171 VA: 0x1648070
	public static ClipperRegistry get_instance() { }

	// RVA: 0x1648160 Offset: 0x1648261 VA: 0x1648160
	public void Cull() { }

	// RVA: 0x1648E30 Offset: 0x1648F31 VA: 0x1648E30
	public static void Register(IClipper c) { }

	// RVA: 0x1648EB0 Offset: 0x1648FB1 VA: 0x1648EB0
	public static void Unregister(IClipper c) { }
}

