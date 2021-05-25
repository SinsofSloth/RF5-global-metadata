[Serializable]
public class AssetLabelReference : IKeyEvaluator // TypeDefIndex: 5699
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x13DCE0 Offset: 0x13DDE1 VA: 0x13DCE0
	[SerializeField] // RVA: 0x13DCE0 Offset: 0x13DDE1 VA: 0x13DCE0
	private string m_LabelString; // 0x10

	// Properties
	public string labelString { get; set; }
	public object RuntimeKey { get; }

	// Methods

	// RVA: 0x15E3720 Offset: 0x15E3821 VA: 0x15E3720
	public string get_labelString() { }

	// RVA: 0x15E3730 Offset: 0x15E3831 VA: 0x15E3730
	public void set_labelString(string value) { }

	// RVA: 0x15E3740 Offset: 0x15E3841 VA: 0x15E3740 Slot: 4
	public object get_RuntimeKey() { }

	// RVA: 0x15E37C0 Offset: 0x15E38C1 VA: 0x15E37C0 Slot: 5
	public bool RuntimeKeyIsValid() { }

	// RVA: 0x15E3850 Offset: 0x15E3951 VA: 0x15E3850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15E3870 Offset: 0x15E3971 VA: 0x15E3870
	public void .ctor() { }
}

