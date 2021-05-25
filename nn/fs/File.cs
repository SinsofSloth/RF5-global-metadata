public static class File // TypeDefIndex: 11658
{
	// Methods

	// RVA: 0x26AD630 Offset: 0x26AD731 VA: 0x26AD630
	public static extern Result Read(FileHandle handle, long offset, byte[] buffer, long size, ReadOption option) { }

	// RVA: 0x26AD660 Offset: 0x26AD761 VA: 0x26AD660
	public static extern Result Read(FileHandle handle, long offset, byte[] buffer, long size) { }

	// RVA: 0x26AD690 Offset: 0x26AD791 VA: 0x26AD690
	public static extern Result Read(ref long outValue, FileHandle handle, long offset, byte[] buffer, long size, ReadOption option) { }

	// RVA: 0x26AD6C0 Offset: 0x26AD7C1 VA: 0x26AD6C0
	public static extern Result Read(ref long outValue, FileHandle handle, long offset, byte[] buffer, long size) { }

	// RVA: 0x26AD6F0 Offset: 0x26AD7F1 VA: 0x26AD6F0
	public static extern Result Write(FileHandle handle, long offset, byte[] buffer, long size, WriteOption option) { }

	// RVA: 0x26AD720 Offset: 0x26AD821 VA: 0x26AD720
	public static extern Result Flush(FileHandle handle) { }

	// RVA: 0x26AD740 Offset: 0x26AD841 VA: 0x26AD740
	public static extern Result SetSize(FileHandle handle, long size) { }

	// RVA: 0x26AD760 Offset: 0x26AD861 VA: 0x26AD760
	public static extern Result GetSize(ref long outValue, FileHandle handle) { }

	// RVA: 0x26AD780 Offset: 0x26AD881 VA: 0x26AD780
	public static extern OpenFileMode GetOpenMode(FileHandle handle) { }

	// RVA: 0x26AD790 Offset: 0x26AD891 VA: 0x26AD790
	public static extern void Close(FileHandle handle) { }

	// RVA: 0x26AD7A0 Offset: 0x26AD8A1 VA: 0x26AD7A0
	public static extern Result Create(string path, long size) { }

	// RVA: 0x26AD7E0 Offset: 0x26AD8E1 VA: 0x26AD7E0
	public static extern Result Delete(string path) { }

	// RVA: 0x26AD820 Offset: 0x26AD921 VA: 0x26AD820
	public static extern Result Rename(string currentPath, string newPath) { }

	// RVA: 0x26AD880 Offset: 0x26AD981 VA: 0x26AD880
	public static extern Result Open(ref FileHandle outValue, string path, OpenFileMode mode) { }
}

