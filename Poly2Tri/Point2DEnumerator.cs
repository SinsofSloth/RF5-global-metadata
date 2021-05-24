public class Point2DEnumerator : IEnumerator<Point2D>, IEnumerator, IDisposable // TypeDefIndex: 9294
{
	// Fields
	protected IList<Point2D> mPoints; // 0x10
	protected int position; // 0x18

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public Point2D Current { get; }

	// Methods

	// RVA: 0x275CD30 Offset: 0x275CE31 VA: 0x275CD30
	public void .ctor(IList<Point2D> points) { }

	// RVA: 0x275CD70 Offset: 0x275CE71 VA: 0x275CD70 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x275CE40 Offset: 0x275CF41 VA: 0x275CE40 Slot: 8
	public void Reset() { }

	// RVA: 0x275CE50 Offset: 0x275CF51 VA: 0x275CE50 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x275CE60 Offset: 0x275CF61 VA: 0x275CE60 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x275CE70 Offset: 0x275CF71 VA: 0x275CE70 Slot: 4
	public Point2D get_Current() { }
}

