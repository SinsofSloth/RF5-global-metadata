public class RF5OptionData : SaveDataValueBase // TypeDefIndex: 9920
{
	// Fields
	public float Brightness; // 0x10
	public float VolumeBGM; // 0x14
	public float VolumeSE; // 0x18
	public float VolumeVoice; // 0x1C
	public float VolumeEnvironment; // 0x20
	public float VolumeMovie; // 0x24
	public float TextSpeed; // 0x28
	public float CameraSpeed_Horizon; // 0x2C
	public float CameraSpeed_Vertical; // 0x30
	public SaveFlagStorage SaveFlag; // 0x38

	// Properties
	public bool CameraRevert_Horizon { get; set; }
	public bool CameraRevert_Vertical { get; set; }
	public bool CameraAutoRotate { get; set; }
	public bool ControllerVibration { get; set; }
	public bool MinimapRotate { get; set; }
	public bool AutoLoot { get; set; }
	public bool AutoTarget { get; set; }
	public bool FarmCamera { get; set; }
	public bool SubTitle { get; set; }

	// Methods

	// RVA: 0x1D7BAE0 Offset: 0x1D7BBE1 VA: 0x1D7BAE0
	public void SetAmbient() { }

	// RVA: 0x1D7BAF0 Offset: 0x1D7BBF1 VA: 0x1D7BAF0
	public void GetAmbient() { }

	// RVA: 0x1D7BB20 Offset: 0x1D7BC21 VA: 0x1D7BB20
	public bool get_CameraRevert_Horizon() { }

	// RVA: 0x1D7BB60 Offset: 0x1D7BC61 VA: 0x1D7BB60
	public void set_CameraRevert_Horizon(bool value) { }

	// RVA: 0x1D7BBB0 Offset: 0x1D7BCB1 VA: 0x1D7BBB0
	public bool get_CameraRevert_Vertical() { }

	// RVA: 0x1D7BBD0 Offset: 0x1D7BCD1 VA: 0x1D7BBD0
	public void set_CameraRevert_Vertical(bool value) { }

	// RVA: 0x1D7BC00 Offset: 0x1D7BD01 VA: 0x1D7BC00
	public bool get_CameraAutoRotate() { }

	// RVA: 0x1D7BC20 Offset: 0x1D7BD21 VA: 0x1D7BC20
	public void set_CameraAutoRotate(bool value) { }

	// RVA: 0x1D7BC50 Offset: 0x1D7BD51 VA: 0x1D7BC50
	public bool get_ControllerVibration() { }

	// RVA: 0x1D7BC70 Offset: 0x1D7BD71 VA: 0x1D7BC70
	public void set_ControllerVibration(bool value) { }

	// RVA: 0x1D7BCA0 Offset: 0x1D7BDA1 VA: 0x1D7BCA0
	public bool get_MinimapRotate() { }

	// RVA: 0x1D7BCC0 Offset: 0x1D7BDC1 VA: 0x1D7BCC0
	public void set_MinimapRotate(bool value) { }

	// RVA: 0x1D7BCF0 Offset: 0x1D7BDF1 VA: 0x1D7BCF0
	public bool get_AutoLoot() { }

	// RVA: 0x1D7BD10 Offset: 0x1D7BE11 VA: 0x1D7BD10
	public void set_AutoLoot(bool value) { }

	// RVA: 0x1D7BD40 Offset: 0x1D7BE41 VA: 0x1D7BD40
	public bool get_AutoTarget() { }

	// RVA: 0x1D7BD60 Offset: 0x1D7BE61 VA: 0x1D7BD60
	public void set_AutoTarget(bool value) { }

	// RVA: 0x1D7BD90 Offset: 0x1D7BE91 VA: 0x1D7BD90
	public bool get_FarmCamera() { }

	// RVA: 0x1D7BDB0 Offset: 0x1D7BEB1 VA: 0x1D7BDB0
	public void set_FarmCamera(bool value) { }

	// RVA: 0x1D7BDE0 Offset: 0x1D7BEE1 VA: 0x1D7BDE0
	public bool get_SubTitle() { }

	// RVA: 0x1D7BE00 Offset: 0x1D7BF01 VA: 0x1D7BE00
	public void set_SubTitle(bool value) { }

	// RVA: 0x1D7BE30 Offset: 0x1D7BF31 VA: 0x1D7BE30
	public void SetSoundVolume() { }

	// RVA: 0x1D7BF10 Offset: 0x1D7C011 VA: 0x1D7BF10
	public void SetSoundVolume(MixerVolumeGroup group) { }

	// RVA: 0x1D7BB40 Offset: 0x1D7BC41 VA: 0x1D7BB40
	public bool GetSaveFlag(RF5OptionData.FLAG id) { }

	// RVA: 0x1D7BB90 Offset: 0x1D7BC91 VA: 0x1D7BB90
	public void SetSaveFlag(RF5OptionData.FLAG id, bool value) { }

	// RVA: 0x1D7C040 Offset: 0x1D7C141 VA: 0x1D7C040
	public void .ctor() { }

	// RVA: 0x1D7C0D0 Offset: 0x1D7C1D1 VA: 0x1D7C0D0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D7C280 Offset: 0x1D7C381 VA: 0x1D7C280 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D7C2B0 Offset: 0x1D7C3B1 VA: 0x1D7C2B0 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D7C2E0 Offset: 0x1D7C3E1 VA: 0x1D7C2E0 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D7C3B0 Offset: 0x1D7C4B1 VA: 0x1D7C3B0
	public void Reader0000(BinaryReader reader) { }
}

