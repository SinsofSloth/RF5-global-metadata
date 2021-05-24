[ComVisibleAttribute] // RVA: 0xB0310 Offset: 0xB0411 VA: 0xB0310
public class SignatureDescription // TypeDefIndex: 966
{
	// Fields
	private string _strKey; // 0x10
	private string _strDigest; // 0x18
	private string _strFormatter; // 0x20
	private string _strDeformatter; // 0x28

	// Properties
	public string KeyAlgorithm { set; }
	public string DigestAlgorithm { set; }
	public string FormatterAlgorithm { set; }
	public string DeformatterAlgorithm { set; }

	// Methods

	// RVA: 0x26383F0 Offset: 0x26384F1 VA: 0x26383F0
	public void .ctor() { }

	// RVA: 0x2638400 Offset: 0x2638501 VA: 0x2638400
	public void set_KeyAlgorithm(string value) { }

	// RVA: 0x2638410 Offset: 0x2638511 VA: 0x2638410
	public void set_DigestAlgorithm(string value) { }

	// RVA: 0x2638420 Offset: 0x2638521 VA: 0x2638420
	public void set_FormatterAlgorithm(string value) { }

	// RVA: 0x2638430 Offset: 0x2638531 VA: 0x2638430
	public void set_DeformatterAlgorithm(string value) { }
}

