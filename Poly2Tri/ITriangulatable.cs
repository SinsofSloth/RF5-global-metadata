public interface ITriangulatable // TypeDefIndex: 9262
{
	// Properties
	public abstract IList<DelaunayTriangle> Triangles { get; }
	public abstract TriangulationMode TriangulationMode { get; }
	public abstract string FileName { get; set; }
	public abstract bool DisplayFlipX { get; set; }
	public abstract bool DisplayFlipY { get; set; }
	public abstract float DisplayRotate { get; set; }
	public abstract double Precision { get; set; }
	public abstract double MinX { get; }
	public abstract double MaxX { get; }
	public abstract double MinY { get; }
	public abstract double MaxY { get; }
	public abstract Rect2D Bounds { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IList<DelaunayTriangle> get_Triangles() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TriangulationMode get_TriangulationMode() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_FileName() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_FileName(string value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_DisplayFlipX() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_DisplayFlipX(bool value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_DisplayFlipY() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_DisplayFlipY(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract float get_DisplayRotate() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_DisplayRotate(float value) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract double get_Precision() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void set_Precision(double value) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract double get_MinX() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract double get_MaxX() { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract double get_MinY() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract double get_MaxY() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Rect2D get_Bounds() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Prepare(TriangulationContext tcx) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void AddTriangle(DelaunayTriangle t) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ClearTriangles() { }
}

