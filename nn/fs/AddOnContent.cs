public static class AddOnContent // TypeDefIndex: 11651
{
	// Methods

	// RVA: 0x26AD1A0 Offset: 0x26AD2A1 VA: 0x26AD1A0
	public static extern Result QueryMountCacheSize(ref long pOutValue, int targetIndex) { }

	// RVA: 0x26AD1C0 Offset: 0x26AD2C1 VA: 0x26AD1C0
	public static extern Result Mount(string name, int targetIndex, byte[] pFileSystemCacheBuffer, long fileSystemCacheBufferSize) { }
}

