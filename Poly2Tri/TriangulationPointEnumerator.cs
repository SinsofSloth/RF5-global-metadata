public class TriangulationPointEnumerator : IEnumerator<TriangulationPoint>, IEnumerator, IDisposable // TypeDefIndex: 9283
{
	// Fields
	protected IList<Point2D> mPoints; // 0x10
	protected int position; // 0x18

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public TriangulationPoint Current { get; }

	// Methods

	// RVA: 0x2762D00 Offset: 0x2762E01 VA: 0x2762D00
	public void .ctor(IList<Point2D> points) { }

	// RVA: 0x2771D70 Offset: 0x2771E71 VA: 0x2771D70 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x2771E40 Offset: 0x2771F41 VA: 0x2771E40 Slot: 8
	public void Reset() { }

	// RVA: 0x2771E50 Offset: 0x2771F51 VA: 0x2771E50 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2771E60 Offset: 0x2771F61 VA: 0x2771E60 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2771E70 Offset: 0x2771F71 VA: 0x2771E70 Slot: 4
	public TriangulationPoint get_Current() { }
}

