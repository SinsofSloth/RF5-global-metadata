[Serializable]
public class CacheInitializationData // TypeDefIndex: 5736
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x13E1C0 Offset: 0x13E2C1 VA: 0x13E1C0
	[SerializeField] // RVA: 0x13E1C0 Offset: 0x13E2C1 VA: 0x13E1C0
	private bool m_CompressionEnabled; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0x13E210 Offset: 0x13E311 VA: 0x13E210
	[SerializeField] // RVA: 0x13E210 Offset: 0x13E311 VA: 0x13E210
	private string m_CacheDirectoryOverride; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x13E260 Offset: 0x13E361 VA: 0x13E260
	[SerializeField] // RVA: 0x13E260 Offset: 0x13E361 VA: 0x13E260
	private int m_ExpirationDelay; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0x13E2B0 Offset: 0x13E3B1 VA: 0x13E2B0
	[SerializeField] // RVA: 0x13E2B0 Offset: 0x13E3B1 VA: 0x13E2B0
	private bool m_LimitCacheSize; // 0x24
	[FormerlySerializedAsAttribute] // RVA: 0x13E300 Offset: 0x13E401 VA: 0x13E300
	[SerializeField] // RVA: 0x13E300 Offset: 0x13E401 VA: 0x13E300
	private long m_MaximumCacheSize; // 0x28

	// Properties
	public bool CompressionEnabled { get; set; }
	public string CacheDirectoryOverride { get; set; }
	public int ExpirationDelay { get; set; }
	public bool LimitCacheSize { get; set; }
	public long MaximumCacheSize { get; set; }

	// Methods

	// RVA: 0x15E6590 Offset: 0x15E6691 VA: 0x15E6590
	public bool get_CompressionEnabled() { }

	// RVA: 0x15E65A0 Offset: 0x15E66A1 VA: 0x15E65A0
	public void set_CompressionEnabled(bool value) { }

	// RVA: 0x15E65B0 Offset: 0x15E66B1 VA: 0x15E65B0
	public string get_CacheDirectoryOverride() { }

	// RVA: 0x15E65C0 Offset: 0x15E66C1 VA: 0x15E65C0
	public void set_CacheDirectoryOverride(string value) { }

	// RVA: 0x15E65D0 Offset: 0x15E66D1 VA: 0x15E65D0
	public int get_ExpirationDelay() { }

	// RVA: 0x15E65E0 Offset: 0x15E66E1 VA: 0x15E65E0
	public void set_ExpirationDelay(int value) { }

	// RVA: 0x15E65F0 Offset: 0x15E66F1 VA: 0x15E65F0
	public bool get_LimitCacheSize() { }

	// RVA: 0x15E6600 Offset: 0x15E6701 VA: 0x15E6600
	public void set_LimitCacheSize(bool value) { }

	// RVA: 0x15E6610 Offset: 0x15E6711 VA: 0x15E6610
	public long get_MaximumCacheSize() { }

	// RVA: 0x15E6620 Offset: 0x15E6721 VA: 0x15E6620
	public void set_MaximumCacheSize(long value) { }

	// RVA: 0x15E6630 Offset: 0x15E6731 VA: 0x15E6630
	public void .ctor() { }
}

