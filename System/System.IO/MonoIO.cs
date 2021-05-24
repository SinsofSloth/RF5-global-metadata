internal static class MonoIO // TypeDefIndex: 690
{
	// Fields
	public static readonly IntPtr InvalidHandle; // 0x0
	private static bool dump_handles; // 0x8

	// Properties
	public static IntPtr ConsoleOutput { get; }
	public static IntPtr ConsoleInput { get; }
	public static IntPtr ConsoleError { get; }
	public static char VolumeSeparatorChar { get; }
	public static char DirectorySeparatorChar { get; }
	public static char AltDirectorySeparatorChar { get; }
	public static char PathSeparator { get; }

	// Methods

	// RVA: 0x18A0600 Offset: 0x18A0701 VA: 0x18A0600
	public static Exception GetException(MonoIOError error) { }

	// RVA: 0x189EE00 Offset: 0x189EF01 VA: 0x189EE00
	public static Exception GetException(string path, MonoIOError error) { }

	// RVA: 0x18AC840 Offset: 0x18AC941 VA: 0x18AC840
	private static bool CreateDirectory(char* path, out MonoIOError error) { }

	// RVA: 0x189ED70 Offset: 0x189EE71 VA: 0x189ED70
	public static bool CreateDirectory(string path, out MonoIOError error) { }

	// RVA: 0x18AC850 Offset: 0x18AC951 VA: 0x18AC850
	private static bool RemoveDirectory(char* path, out MonoIOError error) { }

	// RVA: 0x189FA70 Offset: 0x189FB71 VA: 0x189FA70
	public static bool RemoveDirectory(string path, out MonoIOError error) { }

	// RVA: 0x18A05F0 Offset: 0x18A06F1 VA: 0x18A05F0
	public static string GetCurrentDirectory(out MonoIOError error) { }

	// RVA: 0x18AC860 Offset: 0x18AC961 VA: 0x18AC860
	private static bool MoveFile(char* path, char* dest, out MonoIOError error) { }

	// RVA: 0x18A24B0 Offset: 0x18A25B1 VA: 0x18A24B0
	public static bool MoveFile(string path, string dest, out MonoIOError error) { }

	// RVA: 0x18AC870 Offset: 0x18AC971 VA: 0x18AC870
	private static bool DeleteFile(char* path, out MonoIOError error) { }

	// RVA: 0x189F9E0 Offset: 0x189FAE1 VA: 0x189F9E0
	public static bool DeleteFile(string path, out MonoIOError error) { }

	// RVA: 0x18AC880 Offset: 0x18AC981 VA: 0x18AC880
	private static FileAttributes GetFileAttributes(char* path, out MonoIOError error) { }

	// RVA: 0x18AC890 Offset: 0x18AC991 VA: 0x18AC890
	public static FileAttributes GetFileAttributes(string path, out MonoIOError error) { }

	// RVA: 0x18AC920 Offset: 0x18ACA21 VA: 0x18AC920
	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x18A6640 Offset: 0x18A6741 VA: 0x18A6640
	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x18AC930 Offset: 0x18ACA31 VA: 0x18AC930
	private static IntPtr FindFirstFile(char* pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x18AC940 Offset: 0x18ACA41 VA: 0x18AC940
	public static IntPtr FindFirstFile(string pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x18AC9E0 Offset: 0x18ACAE1 VA: 0x18AC9E0
	public static bool FindNextFile(IntPtr hnd, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x18AC9F0 Offset: 0x18ACAF1 VA: 0x18AC9F0
	public static bool FindCloseFile(IntPtr hnd) { }

	// RVA: 0x18A2370 Offset: 0x18A2471 VA: 0x18A2370
	public static bool Exists(string path, out MonoIOError error) { }

	// RVA: 0x18A1DF0 Offset: 0x18A1EF1 VA: 0x18A1DF0
	public static bool ExistsFile(string path, out MonoIOError error) { }

	// RVA: 0x18A0410 Offset: 0x18A0511 VA: 0x18A0410
	public static bool ExistsDirectory(string path, out MonoIOError error) { }

	// RVA: 0x189F8E0 Offset: 0x189F9E1 VA: 0x189F8E0
	public static bool ExistsSymlink(string path, out MonoIOError error) { }

	// RVA: 0x18ACA00 Offset: 0x18ACB01 VA: 0x18ACA00
	private static bool GetFileStat(char* path, out MonoIOStat stat, out MonoIOError error) { }

	// RVA: 0x18A33B0 Offset: 0x18A34B1 VA: 0x18A33B0
	public static bool GetFileStat(string path, out MonoIOStat stat, out MonoIOError error) { }

	// RVA: 0x18ACA10 Offset: 0x18ACB11 VA: 0x18ACA10
	private static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x18A6490 Offset: 0x18A6591 VA: 0x18A6490
	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x18A98E0 Offset: 0x18A99E1 VA: 0x18A98E0
	public static bool Close(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x18ACA20 Offset: 0x18ACB21 VA: 0x18ACA20
	private static int Read(IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x18A9BF0 Offset: 0x18A9CF1 VA: 0x18A9BF0
	public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x18ACA30 Offset: 0x18ACB31 VA: 0x18ACA30
	private static int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x18A8840 Offset: 0x18A8941 VA: 0x18A8840
	public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x18ACA40 Offset: 0x18ACB41 VA: 0x18ACA40
	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x18A6A80 Offset: 0x18A6B81 VA: 0x18A6A80
	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x18ACA50 Offset: 0x18ACB51 VA: 0x18ACA50
	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x18A6D80 Offset: 0x18A6E81 VA: 0x18A6D80
	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x18ACA60 Offset: 0x18ACB61 VA: 0x18ACA60
	public static IntPtr get_ConsoleOutput() { }

	// RVA: 0x18ACA70 Offset: 0x18ACB71 VA: 0x18ACA70
	public static IntPtr get_ConsoleInput() { }

	// RVA: 0x18ACA80 Offset: 0x18ACB81 VA: 0x18ACA80
	public static IntPtr get_ConsoleError() { }

	// RVA: 0x18ACA90 Offset: 0x18ACB91 VA: 0x18ACA90
	public static char get_VolumeSeparatorChar() { }

	// RVA: 0x18ACAA0 Offset: 0x18ACBA1 VA: 0x18ACAA0
	public static char get_DirectorySeparatorChar() { }

	// RVA: 0x18ACAB0 Offset: 0x18ACBB1 VA: 0x18ACAB0
	public static char get_AltDirectorySeparatorChar() { }

	// RVA: 0x18ACAC0 Offset: 0x18ACBC1 VA: 0x18ACAC0
	public static char get_PathSeparator() { }

	// RVA: 0x18AC7E0 Offset: 0x18AC8E1 VA: 0x18AC7E0
	private static void DumpHandles() { }

	// RVA: 0x18ACAD0 Offset: 0x18ACBD1 VA: 0x18ACAD0
	public static bool RemapPath(string path, out string newPath) { }

	// RVA: 0x18ACAE0 Offset: 0x18ACBE1 VA: 0x18ACAE0
	private static void .cctor() { }
}

