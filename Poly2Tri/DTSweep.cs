public static class DTSweep // TypeDefIndex: 9254
{
	// Fields
	private const double PI_div2 = 1.5707963267948966;
	private const double PI_3div4 = 2.356194490192345;

	// Methods

	// RVA: 0x2211940 Offset: 0x2211A41 VA: 0x2211940
	public static void Triangulate(DTSweepContext tcx) { }

	// RVA: 0x2211CD0 Offset: 0x2211DD1 VA: 0x2211CD0
	private static void Sweep(DTSweepContext tcx) { }

	// RVA: 0x2211F70 Offset: 0x2212071 VA: 0x2211F70
	private static void FixupConstrainedEdges(DTSweepContext tcx) { }

	// RVA: 0x22122F0 Offset: 0x22123F1 VA: 0x22122F0
	private static void FinalizationConvexHull(DTSweepContext tcx) { }

	// RVA: 0x2213210 Offset: 0x2213311 VA: 0x2213210
	private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c) { }

	// RVA: 0x22121F0 Offset: 0x22122F1 VA: 0x22121F0
	private static void FinalizationPolygon(DTSweepContext tcx) { }

	// RVA: 0x22142E0 Offset: 0x22143E1 VA: 0x22142E0
	private static void FinalizationConstraints(DTSweepContext tcx) { }

	// RVA: 0x2212A40 Offset: 0x2212B41 VA: 0x2212A40
	private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point) { }

	// RVA: 0x2214490 Offset: 0x2214591 VA: 0x2214490
	private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node) { }

	// RVA: 0x2212C60 Offset: 0x2212D61 VA: 0x2212C60
	private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x22153D0 Offset: 0x22154D1 VA: 0x22153D0
	private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2215D50 Offset: 0x2215E51 VA: 0x2215D50
	private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2215E40 Offset: 0x2215F41 VA: 0x2215E40
	private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2215F60 Offset: 0x2216061 VA: 0x2215F60
	private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2215A00 Offset: 0x2215B01 VA: 0x2215A00
	private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2216150 Offset: 0x2216251 VA: 0x2216150
	private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2216270 Offset: 0x2216371 VA: 0x2216270
	private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2216360 Offset: 0x2216461 VA: 0x2216360
	private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2215BB0 Offset: 0x2215CB1 VA: 0x2215BB0
	private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2215180 Offset: 0x2215281 VA: 0x2215180
	private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq) { }

	// RVA: 0x2215400 Offset: 0x2215501 VA: 0x2215400
	private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point) { }

	// RVA: 0x2216770 Offset: 0x2216871 VA: 0x2216770
	private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x2216F70 Offset: 0x2217071 VA: 0x2216F70
	private static bool NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op, out TriangulationPoint newP) { }

	// RVA: 0x2216D20 Offset: 0x2216E21 VA: 0x2216D20
	private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op) { }

	// RVA: 0x2217090 Offset: 0x2217191 VA: 0x2217090
	private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x2214720 Offset: 0x2214821 VA: 0x2214720
	private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n) { }

	// RVA: 0x22175A0 Offset: 0x22176A1 VA: 0x22175A0
	private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x2217860 Offset: 0x2217961 VA: 0x2217860
	private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x22179A0 Offset: 0x2217AA1 VA: 0x22179A0
	private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x2217340 Offset: 0x2217441 VA: 0x2217340
	private static double HoleAngle(AdvancingFrontNode node) { }

	// RVA: 0x2217490 Offset: 0x2217591 VA: 0x2217490
	private static double BasinAngle(AdvancingFrontNode node) { }

	// RVA: 0x2214030 Offset: 0x2214131 VA: 0x2214030
	private static void Fill(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x2214B50 Offset: 0x2214C51 VA: 0x2214B50
	private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t) { }

	// RVA: 0x2213530 Offset: 0x2213631 VA: 0x2213530
	private static void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op) { }
}

