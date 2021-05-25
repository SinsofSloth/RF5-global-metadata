internal sealed class SearchResult // TypeDefIndex: 649
{
	// Fields
	private string fullPath; // 0x10
	private string userPath; // 0x18
	private Win32Native.WIN32_FIND_DATA findData; // 0x20

	// Properties
	internal string UserPath { get; }
	internal Win32Native.WIN32_FIND_DATA FindData { get; }

	// Methods

	// RVA: 0x18B0A30 Offset: 0x18B0B31 VA: 0x18B0A30
	internal void .ctor(string fullPath, string userPath, Win32Native.WIN32_FIND_DATA findData) { }

	// RVA: 0x18B0AA0 Offset: 0x18B0BA1 VA: 0x18B0AA0
	internal string get_UserPath() { }

	// RVA: 0x18B0AB0 Offset: 0x18B0BB1 VA: 0x18B0AB0
	internal Win32Native.WIN32_FIND_DATA get_FindData() { }
}

