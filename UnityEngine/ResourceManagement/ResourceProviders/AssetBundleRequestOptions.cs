[Serializable]
public class AssetBundleRequestOptions : ILocationSizeData // TypeDefIndex: 4477
{
	// Fields
	[SerializeField] // RVA: 0x129DE0 Offset: 0x129EE1 VA: 0x129DE0
	[FormerlySerializedAsAttribute] // RVA: 0x129DE0 Offset: 0x129EE1 VA: 0x129DE0
	private string m_Hash; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0x129E30 Offset: 0x129F31 VA: 0x129E30
	[SerializeField] // RVA: 0x129E30 Offset: 0x129F31 VA: 0x129E30
	private uint m_Crc; // 0x18
	[SerializeField] // RVA: 0x129E80 Offset: 0x129F81 VA: 0x129E80
	[FormerlySerializedAsAttribute] // RVA: 0x129E80 Offset: 0x129F81 VA: 0x129E80
	private int m_Timeout; // 0x1C
	[SerializeField] // RVA: 0x129ED0 Offset: 0x129FD1 VA: 0x129ED0
	[FormerlySerializedAsAttribute] // RVA: 0x129ED0 Offset: 0x129FD1 VA: 0x129ED0
	private bool m_ChunkedTransfer; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0x129F20 Offset: 0x12A021 VA: 0x129F20
	[SerializeField] // RVA: 0x129F20 Offset: 0x12A021 VA: 0x129F20
	private int m_RedirectLimit; // 0x24
	[FormerlySerializedAsAttribute] // RVA: 0x129F70 Offset: 0x12A071 VA: 0x129F70
	[SerializeField] // RVA: 0x129F70 Offset: 0x12A071 VA: 0x129F70
	private int m_RetryCount; // 0x28
	[SerializeField] // RVA: 0x129FC0 Offset: 0x12A0C1 VA: 0x129FC0
	private string m_BundleName; // 0x30
	[SerializeField] // RVA: 0x129FD0 Offset: 0x12A0D1 VA: 0x129FD0
	private long m_BundleSize; // 0x38
	[SerializeField] // RVA: 0x129FE0 Offset: 0x12A0E1 VA: 0x129FE0
	private bool m_UseCrcForCachedBundles; // 0x40

	// Properties
	public string Hash { get; set; }
	public uint Crc { get; set; }
	public int Timeout { get; set; }
	public bool ChunkedTransfer { get; set; }
	public int RedirectLimit { get; set; }
	public int RetryCount { get; set; }
	public string BundleName { get; set; }
	public long BundleSize { get; set; }
	public bool UseCrcForCachedBundle { get; set; }

	// Methods

	// RVA: 0x19DDD40 Offset: 0x19DDE41 VA: 0x19DDD40
	public string get_Hash() { }

	// RVA: 0x19DDD50 Offset: 0x19DDE51 VA: 0x19DDD50
	public void set_Hash(string value) { }

	// RVA: 0x19DDD60 Offset: 0x19DDE61 VA: 0x19DDD60
	public uint get_Crc() { }

	// RVA: 0x19DDD70 Offset: 0x19DDE71 VA: 0x19DDD70
	public void set_Crc(uint value) { }

	// RVA: 0x19DDD80 Offset: 0x19DDE81 VA: 0x19DDD80
	public int get_Timeout() { }

	// RVA: 0x19DDD90 Offset: 0x19DDE91 VA: 0x19DDD90
	public void set_Timeout(int value) { }

	// RVA: 0x19DDDA0 Offset: 0x19DDEA1 VA: 0x19DDDA0
	public bool get_ChunkedTransfer() { }

	// RVA: 0x19DDDB0 Offset: 0x19DDEB1 VA: 0x19DDDB0
	public void set_ChunkedTransfer(bool value) { }

	// RVA: 0x19DDDC0 Offset: 0x19DDEC1 VA: 0x19DDDC0
	public int get_RedirectLimit() { }

	// RVA: 0x19DDDD0 Offset: 0x19DDED1 VA: 0x19DDDD0
	public void set_RedirectLimit(int value) { }

	// RVA: 0x19DDDE0 Offset: 0x19DDEE1 VA: 0x19DDDE0
	public int get_RetryCount() { }

	// RVA: 0x19DDDF0 Offset: 0x19DDEF1 VA: 0x19DDDF0
	public void set_RetryCount(int value) { }

	// RVA: 0x19DDE00 Offset: 0x19DDF01 VA: 0x19DDE00
	public string get_BundleName() { }

	// RVA: 0x19DDE10 Offset: 0x19DDF11 VA: 0x19DDE10
	public void set_BundleName(string value) { }

	// RVA: 0x19DDE20 Offset: 0x19DDF21 VA: 0x19DDE20
	public long get_BundleSize() { }

	// RVA: 0x19DDE30 Offset: 0x19DDF31 VA: 0x19DDE30
	public void set_BundleSize(long value) { }

	// RVA: 0x19DDE40 Offset: 0x19DDF41 VA: 0x19DDE40
	public bool get_UseCrcForCachedBundle() { }

	// RVA: 0x19DDE50 Offset: 0x19DDF51 VA: 0x19DDE50
	public void set_UseCrcForCachedBundle(bool value) { }

	// RVA: 0x19DDE60 Offset: 0x19DDF61 VA: 0x19DDE60 Slot: 5
	public virtual long ComputeSize(IResourceLocation location, ResourceManager resourceManager) { }

	// RVA: 0x19DE030 Offset: 0x19DE131 VA: 0x19DE030
	public void .ctor() { }
}

