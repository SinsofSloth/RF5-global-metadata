public class AdvancingFrontNode // TypeDefIndex: 9253
{
	// Fields
	public AdvancingFrontNode Next; // 0x10
	public AdvancingFrontNode Prev; // 0x18
	public double Value; // 0x20
	public TriangulationPoint Point; // 0x28
	public DelaunayTriangle Triangle; // 0x30

	// Properties
	public bool HasNext { get; }
	public bool HasPrev { get; }

	// Methods

	// RVA: 0x220C110 Offset: 0x220C211 VA: 0x220C110
	public void .ctor(TriangulationPoint point) { }

	// RVA: 0x220C170 Offset: 0x220C271 VA: 0x220C170
	public bool get_HasNext() { }

	// RVA: 0x220C180 Offset: 0x220C281 VA: 0x220C180
	public bool get_HasPrev() { }
}

