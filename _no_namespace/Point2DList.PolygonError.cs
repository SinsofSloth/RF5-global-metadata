[FlagsAttribute] // RVA: 0x159CB0 Offset: 0x159DB1 VA: 0x159CB0
public enum Point2DList.PolygonError // TypeDefIndex: 9297
{
	// Fields
	public uint value__; // 0x0
	public const Point2DList.PolygonError None = 0;
	public const Point2DList.PolygonError NotEnoughVertices = 1;
	public const Point2DList.PolygonError NotConvex = 2;
	public const Point2DList.PolygonError NotSimple = 4;
	public const Point2DList.PolygonError AreaTooSmall = 8;
	public const Point2DList.PolygonError SidesTooCloseToParallel = 16;
	public const Point2DList.PolygonError TooThin = 32;
	public const Point2DList.PolygonError Degenerate = 64;
	public const Point2DList.PolygonError Unknown = 1073741824;
}

