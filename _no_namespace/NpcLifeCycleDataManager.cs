public class NpcLifeCycleDataManager // TypeDefIndex: 8127
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16B3F0 Offset: 0x16B4F1 VA: 0x16B3F0
	private NpcLifeCycleData <LifeCycleData>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x16B400 Offset: 0x16B501 VA: 0x16B400
	private int <LifeCycleDataId>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16B410 Offset: 0x16B511 VA: 0x16B410
	private Dictionary<Weather, int> <WeatherOffset>k__BackingField; // 0x20

	// Properties
	public NpcLifeCycleData LifeCycleData { get; set; }
	public int LifeCycleDataId { get; set; }
	public Dictionary<Weather, int> WeatherOffset { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A62D0 Offset: 0x1A63D1 VA: 0x1A62D0
	// RVA: 0x1D7E9A0 Offset: 0x1D7EAA1 VA: 0x1D7E9A0
	public NpcLifeCycleData get_LifeCycleData() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A62E0 Offset: 0x1A63E1 VA: 0x1A62E0
	// RVA: 0x1D7E9B0 Offset: 0x1D7EAB1 VA: 0x1D7E9B0
	private void set_LifeCycleData(NpcLifeCycleData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A62F0 Offset: 0x1A63F1 VA: 0x1A62F0
	// RVA: 0x1D7E9C0 Offset: 0x1D7EAC1 VA: 0x1D7E9C0
	public int get_LifeCycleDataId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6300 Offset: 0x1A6401 VA: 0x1A6300
	// RVA: 0x1D7E9D0 Offset: 0x1D7EAD1 VA: 0x1D7E9D0
	public void set_LifeCycleDataId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6310 Offset: 0x1A6411 VA: 0x1A6310
	// RVA: 0x1D7E9E0 Offset: 0x1D7EAE1 VA: 0x1D7E9E0
	public Dictionary<Weather, int> get_WeatherOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6320 Offset: 0x1A6421 VA: 0x1A6320
	// RVA: 0x1D7E9F0 Offset: 0x1D7EAF1 VA: 0x1D7E9F0
	private void set_WeatherOffset(Dictionary<Weather, int> value) { }

	// RVA: 0x1D7EA00 Offset: 0x1D7EB01 VA: 0x1D7EA00
	public void .ctor() { }

	// RVA: 0x1D7EB10 Offset: 0x1D7EC11 VA: 0x1D7EB10 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1D7EBE0 Offset: 0x1D7ECE1 VA: 0x1D7EBE0
	public void RemoveResources() { }

	// RVA: 0x1D7EA90 Offset: 0x1D7EB91 VA: 0x1D7EA90
	public void Init() { }

	// RVA: 0x1D7EC60 Offset: 0x1D7ED61 VA: 0x1D7EC60
	public void DataSet(NpcLifeCycleData data, int loaderId) { }

	// RVA: 0x1D7EE70 Offset: 0x1D7EF71 VA: 0x1D7EE70
	public NpcLifeCycleTime GetCurrentTimeList(int time) { }

	// RVA: 0x1D7EFC0 Offset: 0x1D7F0C1 VA: 0x1D7EFC0
	public void ShiftTimeList(int time) { }

	// RVA: 0x1D7F110 Offset: 0x1D7F211 VA: 0x1D7F110
	public NpcLifeCycleTime[] GetTimeList() { }

	// RVA: 0x1D7F130 Offset: 0x1D7F231 VA: 0x1D7F130
	public NpcLifeCycleTimeData[] GetTimeData(Weather weather) { }

	// RVA: 0x1D7F1D0 Offset: 0x1D7F2D1 VA: 0x1D7F1D0
	public int TimeToIndex(int time) { }

	// RVA: 0x1D7F290 Offset: 0x1D7F391 VA: 0x1D7F290
	public NpcLifeCycleTimeData GetTimeData(Weather weather, int time) { }
}

