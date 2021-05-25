public class BitManager : SingletonMonoBehaviour<BitManager> // TypeDefIndex: 6695
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15EDF0 Offset: 0x15EEF1 VA: 0x15EDF0
	private bool <InitCompleted>k__BackingField; // 0x18
	private BitBase m_BitOriginal; // 0x20
	private Register<Character, BitController> m_Register; // 0x28

	// Properties
	public bool InitCompleted { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19CA00 Offset: 0x19CB01 VA: 0x19CA00
	// RVA: 0x22E4590 Offset: 0x22E4691 VA: 0x22E4590
	public bool get_InitCompleted() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CA10 Offset: 0x19CB11 VA: 0x19CA10
	// RVA: 0x22E45A0 Offset: 0x22E46A1 VA: 0x22E45A0
	private void set_InitCompleted(bool value) { }

	// RVA: 0x22E45B0 Offset: 0x22E46B1 VA: 0x22E45B0
	public bool Regist(Character chara, BitController controller) { }

	// RVA: 0x22E4620 Offset: 0x22E4721 VA: 0x22E4620
	public bool Remove(Character chara) { }

	// RVA: 0x22E4690 Offset: 0x22E4791 VA: 0x22E4690
	public BitController Get(Character chara) { }

	// RVA: 0x22E4740 Offset: 0x22E4841 VA: 0x22E4740
	public void Init() { }

	// RVA: 0x22E47F0 Offset: 0x22E48F1 VA: 0x22E47F0
	public void Remove() { }

	// RVA: 0x22E4860 Offset: 0x22E4961 VA: 0x22E4860
	private void OnDestroy() { }

	// RVA: 0x22E48D0 Offset: 0x22E49D1 VA: 0x22E48D0
	private void Update() { }

	// RVA: 0x22E4A30 Offset: 0x22E4B31 VA: 0x22E4A30
	private void FixedUpdate() { }

	// RVA: 0x22E4B90 Offset: 0x22E4C91 VA: 0x22E4B90
	public bool RentBit(out BitBase outBit) { }

	// RVA: 0x22E4C80 Offset: 0x22E4D81 VA: 0x22E4C80
	public bool DoCall(Character chara, BitID bitID, int level) { }

	// RVA: 0x22E4DB0 Offset: 0x22E4EB1 VA: 0x22E4DB0
	public bool DoRelease(Character chara) { }

	// RVA: 0x22E4EE0 Offset: 0x22E4FE1 VA: 0x22E4EE0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CA20 Offset: 0x19CB21 VA: 0x19CA20
	// RVA: 0x22E4F70 Offset: 0x22E5071 VA: 0x22E4F70
	private void <Init>b__9_0(AssetHandle<GameObject> handle) { }
}

