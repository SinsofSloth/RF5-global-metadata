public static class ProfanityFilterForPlatformRegionChina // TypeDefIndex: 11485
{
	// Methods

	// RVA: 0x34F13D0 Offset: 0x34F14D1 VA: 0x34F13D0
	public static extern Result CheckProfanityWords(ref bool pOutCheckResult, [In] string pText) { }

	// RVA: 0x34F1420 Offset: 0x34F1521 VA: 0x34F1420
	public static extern Result CheckProfanityWords(ref bool pOutCheckResult, [In] StringBuilder pText) { }

	// RVA: 0x34F1470 Offset: 0x34F1571 VA: 0x34F1470
	public static extern Result MaskProfanityWords([In] [Out] StringBuilder pOutText) { }
}

