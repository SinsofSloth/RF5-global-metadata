public class RF5SystemData : SaveDataValueBase // TypeDefIndex: 9922
{
	// Fields
	public short LatestSlotIndex; // 0x10
	public ushort TimeMonth; // 0x12
	public SystemLanguage Language; // 0x14
	public SystemLanguage VoiceLanguage; // 0x18
	public SaveFlagStorage SaveFlag; // 0x20
	public uint MovieDataFlag; // 0x28
	public RF5OptionData OptionData; // 0x30
	public RF5ThumbnailData[] ThumbData; // 0x38
	private static readonly RF5SystemData.FLAG[] DLCtoSaveFlag; // 0x0

	// Properties
	public bool IsGameCleared { get; set; }
	public bool IsPlayMan { get; set; }
	public bool IsPlayWoman { get; set; }
	public bool IsOP2Open { get; set; }
	public bool IsMissionAllCleared { get; set; }
	public bool IsChildBorned { get; }

	// Methods

	// RVA: 0x20F3DC0 Offset: 0x20F3EC1 VA: 0x20F3DC0
	public bool get_IsGameCleared() { }

	// RVA: 0x20F3EC0 Offset: 0x20F3FC1 VA: 0x20F3EC0
	public void set_IsGameCleared(bool value) { }

	// RVA: 0x20F3FB0 Offset: 0x20F40B1 VA: 0x20F3FB0
	public bool get_IsPlayMan() { }

	// RVA: 0x20F4020 Offset: 0x20F4121 VA: 0x20F4020
	public void set_IsPlayMan(bool value) { }

	// RVA: 0x20F4080 Offset: 0x20F4181 VA: 0x20F4080
	public bool get_IsPlayWoman() { }

	// RVA: 0x20F40F0 Offset: 0x20F41F1 VA: 0x20F40F0
	public void set_IsPlayWoman(bool value) { }

	// RVA: 0x20F4150 Offset: 0x20F4251 VA: 0x20F4150
	public bool get_IsOP2Open() { }

	// RVA: 0x20F41C0 Offset: 0x20F42C1 VA: 0x20F41C0
	public void set_IsOP2Open(bool value) { }

	// RVA: 0x20F4220 Offset: 0x20F4321 VA: 0x20F4220
	public bool get_IsMissionAllCleared() { }

	// RVA: 0x20F4290 Offset: 0x20F4391 VA: 0x20F4290
	public void set_IsMissionAllCleared(bool value) { }

	// RVA: 0x20F42F0 Offset: 0x20F43F1 VA: 0x20F42F0
	public bool get_IsChildBorned() { }

	// RVA: 0x20F3E30 Offset: 0x20F3F31 VA: 0x20F3E30
	public bool GetSaveFlag(RF5SystemData.FLAG id) { }

	// RVA: 0x20F3F20 Offset: 0x20F4021 VA: 0x20F3F20
	public void SetSaveFlag(RF5SystemData.FLAG id, bool value) { }

	// RVA: 0x20F4400 Offset: 0x20F4501 VA: 0x20F4400
	public void SetMovieFlag(MovieID movieEnum) { }

	// RVA: 0x20F4420 Offset: 0x20F4521 VA: 0x20F4420
	public bool GetMovieFlag(MovieID movieEnum) { }

	// RVA: 0x20F4440 Offset: 0x20F4541 VA: 0x20F4440
	public bool GetDLCFlag(DLCID id) { }

	// RVA: 0x20F4560 Offset: 0x20F4661 VA: 0x20F4560
	public void .ctor() { }

	// RVA: 0x20F45F0 Offset: 0x20F46F1 VA: 0x20F45F0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x20F4870 Offset: 0x20F4971 VA: 0x20F4870
	public void UpdateSaveData(int slot, RF5SaveData saveData) { }

	// RVA: 0x20F4BD0 Offset: 0x20F4CD1 VA: 0x20F4BD0 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x20F4BF0 Offset: 0x20F4CF1 VA: 0x20F4BF0 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x20F4CE0 Offset: 0x20F4DE1 VA: 0x20F4CE0 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x20F4E00 Offset: 0x20F4F01 VA: 0x20F4E00
	public void Reader0000(BinaryReader reader) { }

	// RVA: 0x20F5080 Offset: 0x20F5181 VA: 0x20F5080
	private static void .cctor() { }
}

