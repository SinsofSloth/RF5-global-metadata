public struct PurchasedItemInfo // TypeDefIndex: 11696
{
	// Fields
	public PurchasedItemInfo.Type type; // 0x0
	public NetworkServiceAccountId nsaId; // 0x8
	internal CourseId _courseId; // 0x10

	// Methods

	// RVA: 0x3623A0 Offset: 0x3624A1 VA: 0x3623A0
	public CourseId GetCourseId() { }

	// RVA: 0x26A8240 Offset: 0x26A8341 VA: 0x26A8240
	private static extern CourseId GetCourseId(PurchasedItemInfo info) { }
}

