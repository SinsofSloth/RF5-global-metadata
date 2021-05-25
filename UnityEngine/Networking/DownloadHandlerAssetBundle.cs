[NativeHeaderAttribute] // RVA: 0x1212A0 Offset: 0x1213A1 VA: 0x1212A0
public sealed class DownloadHandlerAssetBundle : DownloadHandler // TypeDefIndex: 4254
{
	// Properties
	public AssetBundle assetBundle { get; }

	// Methods

	// RVA: 0x1BE1360 Offset: 0x1BE1461 VA: 0x1BE1360
	private static IntPtr Create(DownloadHandlerAssetBundle obj, string url, uint crc) { }

	// RVA: 0x1BE13C0 Offset: 0x1BE14C1 VA: 0x1BE13C0
	private static IntPtr CreateCached(DownloadHandlerAssetBundle obj, string url, string name, Hash128 hash, uint crc) { }

	// RVA: 0x1BE14B0 Offset: 0x1BE15B1 VA: 0x1BE14B0
	private void InternalCreateAssetBundle(string url, uint crc) { }

	// RVA: 0x1BE1510 Offset: 0x1BE1611 VA: 0x1BE1510
	private void InternalCreateAssetBundleCached(string url, string name, Hash128 hash, uint crc) { }

	// RVA: 0x1BE1590 Offset: 0x1BE1691 VA: 0x1BE1590
	public void .ctor(string url, uint crc) { }

	// RVA: 0x1BE1600 Offset: 0x1BE1701 VA: 0x1BE1600
	public void .ctor(string url, CachedAssetBundle cachedBundle, uint crc) { }

	// RVA: 0x1BE16B0 Offset: 0x1BE17B1 VA: 0x1BE16B0 Slot: 5
	protected override byte[] GetData() { }

	// RVA: 0x1BE1720 Offset: 0x1BE1821 VA: 0x1BE1720 Slot: 6
	protected override string GetText() { }

	// RVA: 0x1BE1790 Offset: 0x1BE1891 VA: 0x1BE1790
	public AssetBundle get_assetBundle() { }

	// RVA: 0x1BE1440 Offset: 0x1BE1541 VA: 0x1BE1440
	private static IntPtr CreateCached_Injected(DownloadHandlerAssetBundle obj, string url, string name, ref Hash128 hash, uint crc) { }
}

