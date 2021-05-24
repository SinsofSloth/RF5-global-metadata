[ComVisibleAttribute] // RVA: 0xAE880 Offset: 0xAE981 VA: 0xAE880
public static class Directory // TypeDefIndex: 636
{
	// Methods

	// RVA: 0x189DF20 Offset: 0x189E021 VA: 0x189DF20
	public static string[] GetFiles(string path) { }

	// RVA: 0x189E080 Offset: 0x189E181 VA: 0x189E080
	public static string[] GetFiles(string path, string searchPattern) { }

	// RVA: 0x189DFC0 Offset: 0x189E0C1 VA: 0x189DFC0
	private static string[] InternalGetFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x189E220 Offset: 0x189E321 VA: 0x189E220
	public static string[] GetDirectories(string path) { }

	// RVA: 0x189E380 Offset: 0x189E481 VA: 0x189E380
	public static string[] GetDirectories(string path, string searchPattern) { }

	// RVA: 0x189E2C0 Offset: 0x189E3C1 VA: 0x189E2C0
	private static string[] InternalGetDirectories(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x189E140 Offset: 0x189E241 VA: 0x189E140
	internal static string[] InternalGetFileDirectoryNames(string path, string userPathOriginal, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost) { }

	// RVA: 0x189E560 Offset: 0x189E661 VA: 0x189E560
	public static DirectoryInfo CreateDirectory(string path) { }

	// RVA: 0x189E890 Offset: 0x189E991 VA: 0x189E890
	private static DirectoryInfo CreateDirectoriesInternal(string path) { }

	// RVA: 0x189F540 Offset: 0x189F641 VA: 0x189F540
	public static void Delete(string path) { }

	// RVA: 0x189FB50 Offset: 0x189FC51 VA: 0x189FB50
	private static void RecursiveDelete(string path) { }

	// RVA: 0x18A0120 Offset: 0x18A0221 VA: 0x18A0120
	public static void Delete(string path, bool recursive) { }

	// RVA: 0x18A0210 Offset: 0x18A0311 VA: 0x18A0210
	public static bool Exists(string path) { }

	// RVA: 0x18A0520 Offset: 0x18A0621 VA: 0x18A0520
	public static string GetCurrentDirectory() { }

	// RVA: 0x18A0540 Offset: 0x18A0641 VA: 0x18A0540
	internal static string InsecureGetCurrentDirectory() { }

	// RVA: 0x18A0710 Offset: 0x18A0811 VA: 0x18A0710
	internal static string GetDemandDir(string fullPath, bool thisDirOnly) { }
}

