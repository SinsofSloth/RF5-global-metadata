public class DelaunayTriangle // TypeDefIndex: 9251
{
	// Fields
	public FixedArray3<TriangulationPoint> Points; // 0x10
	public FixedArray3<DelaunayTriangle> Neighbors; // 0x28
	private FixedBitArray3 mEdgeIsConstrained; // 0x40
	public FixedBitArray3 EdgeIsDelaunay; // 0x43
	[CompilerGeneratedAttribute] // RVA: 0x177840 Offset: 0x177941 VA: 0x177840
	private bool <IsInterior>k__BackingField; // 0x46

	// Properties
	public FixedBitArray3 EdgeIsConstrained { get; }
	public bool IsInterior { get; set; }

	// Methods

	// RVA: 0x2218E90 Offset: 0x2218F91 VA: 0x2218E90
	public FixedBitArray3 get_EdgeIsConstrained() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9AF0 Offset: 0x1A9BF1 VA: 0x1A9AF0
	// RVA: 0x2218EA0 Offset: 0x2218FA1 VA: 0x2218EA0
	public bool get_IsInterior() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B00 Offset: 0x1A9C01 VA: 0x1A9B00
	// RVA: 0x2218EB0 Offset: 0x2218FB1 VA: 0x2218EB0
	public void set_IsInterior(bool value) { }

	// RVA: 0x2214830 Offset: 0x2214931 VA: 0x2214830
	public void .ctor(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3) { }

	// RVA: 0x2217A60 Offset: 0x2217B61 VA: 0x2217A60
	public int IndexOf(TriangulationPoint p) { }

	// RVA: 0x2218EC0 Offset: 0x2218FC1 VA: 0x2218EC0
	public int IndexCWFrom(TriangulationPoint p) { }

	// RVA: 0x2218F90 Offset: 0x2219091 VA: 0x2218F90
	public int IndexCCWFrom(TriangulationPoint p) { }

	// RVA: 0x2213410 Offset: 0x2213511 VA: 0x2213410
	public bool Contains(TriangulationPoint p) { }

	// RVA: 0x2219060 Offset: 0x2219161 VA: 0x2219060
	private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t) { }

	// RVA: 0x22148E0 Offset: 0x22149E1 VA: 0x22148E0
	public void MarkNeighbor(DelaunayTriangle t) { }

	// RVA: 0x22191D0 Offset: 0x22192D1 VA: 0x22191D0
	public void ClearNeighbors() { }

	// RVA: 0x2219260 Offset: 0x2219361 VA: 0x2219260
	public void ClearNeighbor(DelaunayTriangle triangle) { }

	// RVA: 0x2213CA0 Offset: 0x2213DA1 VA: 0x2213CA0
	public void Clear() { }

	// RVA: 0x22134F0 Offset: 0x22135F1 VA: 0x22134F0
	public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x2213F10 Offset: 0x2214011 VA: 0x2213F10
	public DelaunayTriangle NeighborCWFrom(TriangulationPoint point) { }

	// RVA: 0x2213C00 Offset: 0x2213D01 VA: 0x2213C00
	public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point) { }

	// RVA: 0x2213470 Offset: 0x2213571 VA: 0x2213470
	public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point) { }

	// RVA: 0x2213AF0 Offset: 0x2213BF1 VA: 0x2213AF0
	public TriangulationPoint PointCCWFrom(TriangulationPoint point) { }

	// RVA: 0x2213E00 Offset: 0x2213F01 VA: 0x2213E00
	public TriangulationPoint PointCWFrom(TriangulationPoint point) { }

	// RVA: 0x2219360 Offset: 0x2219461 VA: 0x2219360
	private void RotateCW() { }

	// RVA: 0x2217D90 Offset: 0x2217E91 VA: 0x2217D90
	public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint) { }

	// RVA: 0x2219430 Offset: 0x2219531 VA: 0x2219430 Slot: 3
	public override string ToString() { }

	// RVA: 0x2219640 Offset: 0x2219741 VA: 0x2219640
	public void MarkNeighborEdges() { }

	// RVA: 0x2219AC0 Offset: 0x2219BC1 VA: 0x2219AC0
	public void MarkEdge(DelaunayTriangle triangle) { }

	// RVA: 0x2219F40 Offset: 0x221A041 VA: 0x2219F40
	public void MarkEdge(List<DelaunayTriangle> tList) { }

	// RVA: 0x2213200 Offset: 0x2213301 VA: 0x2213200
	public void MarkConstrainedEdge(int index) { }

	// RVA: 0x221A3F0 Offset: 0x221A4F1 VA: 0x221A3F0
	public void MarkConstrainedEdge(DTSweepConstraint edge) { }

	// RVA: 0x2216650 Offset: 0x2216751 VA: 0x2216650
	public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q) { }

	// RVA: 0x221A530 Offset: 0x221A631 VA: 0x221A530
	public double Area() { }

	// RVA: 0x221A660 Offset: 0x221A761 VA: 0x221A660
	public TriangulationPoint Centroid() { }

	// RVA: 0x2216540 Offset: 0x2216641 VA: 0x2216540
	public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x2213030 Offset: 0x2213131 VA: 0x2213030
	public bool GetConstrainedEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x22141E0 Offset: 0x22142E1 VA: 0x22141E0
	public bool GetConstrainedEdgeCW(TriangulationPoint p) { }

	// RVA: 0x221A7E0 Offset: 0x221A8E1 VA: 0x221A7E0
	public bool GetConstrainedEdgeAcross(TriangulationPoint p) { }

	// RVA: 0x221A8B0 Offset: 0x221A9B1 VA: 0x221A8B0
	protected void SetConstrainedEdge(int idx, bool ce) { }

	// RVA: 0x2218070 Offset: 0x2218171 VA: 0x2218070
	public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x2218150 Offset: 0x2218251 VA: 0x2218150
	public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x2217B10 Offset: 0x2217C11 VA: 0x2217B10
	public void SetConstrainedEdgeAcross(TriangulationPoint p, bool ce) { }

	// RVA: 0x2217BD0 Offset: 0x2217CD1 VA: 0x2217BD0
	public bool GetDelaunayEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x2217CB0 Offset: 0x2217DB1 VA: 0x2217CB0
	public bool GetDelaunayEdgeCW(TriangulationPoint p) { }

	// RVA: 0x221A8C0 Offset: 0x221A9C1 VA: 0x221A8C0
	public bool GetDelaunayEdgeAcross(TriangulationPoint p) { }

	// RVA: 0x2217EB0 Offset: 0x2217FB1 VA: 0x2217EB0
	public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x2217F90 Offset: 0x2218091 VA: 0x2217F90
	public void SetDelaunayEdgeCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x221A980 Offset: 0x221AA81 VA: 0x221A980
	public void SetDelaunayEdgeAcross(TriangulationPoint p, bool ce) { }

	// RVA: 0x221AA40 Offset: 0x221AB41 VA: 0x221AA40
	public bool GetEdge(int idx, out DTSweepConstraint edge) { }

	// RVA: 0x2213120 Offset: 0x2213221 VA: 0x2213120
	public bool GetEdgeCCW(TriangulationPoint p, out DTSweepConstraint edge) { }

	// RVA: 0x221AB70 Offset: 0x221AC71 VA: 0x221AB70
	public bool GetEdgeCW(TriangulationPoint p, out DTSweepConstraint edge) { }

	// RVA: 0x221AC50 Offset: 0x221AD51 VA: 0x221AC50
	public bool GetEdgeAcross(TriangulationPoint p, out DTSweepConstraint edge) { }
}

